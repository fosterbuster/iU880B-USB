# Tips for designing binary protocols for LoRaWAN

## Goals

- Keep the payload short.
  - The longer your payload, the less likely it is to be received.
  - The longer your payload, the more punishment of the Duty Cycle.
- Design for extensibility.
  - You never know how your protocol might evolve, so ensure that you are able to extend it rather painlessly.
- Design for a single usecase.
  - A device that can do everything, usually ends up doing nothing (same goes for all development projects tbh).

## Payloads by IRL examples.
_It might be beneficial, to see how other people design their protocols, both good and bad._
### Xignal Mouse Trap


[Link to protocol specification](lorawan_protocol_specifications/xignal_rattrap.pdf)
#### Bad
- Contains a message identifier, used for identifying the packet from other LoRaWAN packets. This is redundant information, since it can be derived from the devices ID, which is always present in a LoRaWAN header.
- Contains a 6-bit device identifier (wtf? why not just use the full byte now that youre at it). Again, the device can already be identified by its device id.
- Not so extensible
#### Good
- I am so disappointed, that i can't think of any.
  - Maybe that they have reserved values...
#### Notes
The protocol defines a size of 6 fixed bytes, out of which 2 can easily be stripped away.

For some reason, they decided to throw in a thermometer in it. I guess it was built-in the chip measuring acceleration. I guess it serves as an extra selling point.

It might be worth noticing, that for the battery voltage, you need to multiply it with 10^-2. This is actually a smart trick, I might elaborate on later.

### Garbage Meter

![](lorawan_protocol_specifications/secretagentman.PNG)
_Unfortunately the documentation for the payload is supposedly confidential, so Ill refrain from mentioning it by name._

#### Bad
- The payload is a fixed 4 bytes, where for the two first bytes each nibble is used to identify a boolean value (wtf?).

#### Good
- Excellent example of what not to do, and letting one talk about optimization options.
  
#### Notes

First of all, it should be evident that the two first bytes could be shaved down to 4 bits (one nibble). Second, the last two bytes are encoded as BCD (binary coded decimal). If the device has a range of 0-2000mm, this can be expressed (if not using BCD) as 1 byte and one nibble.

All in all, you could actually store the entirety of the information in 2 bytes. First 1 byte and nibble for the distance, and a nibble for the booleans.

ie the example would look like this

Meaning:
[Distance][Booleans]

HEX:
[40A][0]

Binary:
[0100 0000 1010][0000]

### Adeunis Field Test Device:

[Link to specification](lorawan_protocol_specifications/adeunis_fieldtester.pdf)

In general, I think this is excellently designed, and documented.

## Tips and tricks for your payload.

### Variable ints (VLQ), zigzag ints.
[Have a look at how Google's Protobuf handles Varints and signed numbers](https://developers.google.com/protocol-buffers/docs/encoding). This enables you to express numbers using only the exact amount of space you need (except for a signed byte, which will be two bytes if using a zigzagged variable int). A decent .NET library is available on github for encoding this is avaiable [here](https://github.com/topas/VarintBitConverter)

## Using a multiplication factor.
If working with decimal numbers, having some bits indicating a multiplication factor, might be a good idea, since it allows you to shrink and grow numbers using less space. Ie imagine this (shamelessly insipired by the mbus protocol)

1 byte details the data information. Ie the first 4 bits denotes the data type (BCD, varint, zigzagged varint, booleans, fixed sized, whatever..), the rest is the data-part

The last 4 bits denotes the multiplication factor. So we imagine that we define our protocol as last 4 bits (0-15), which we now denote nnnn.

value = datapart * 10^(7-nnnn)

value = 1337 * 10^(7-nnnn)

for nnnn = x

- 0 = 13370000000
- 1 = 1337000000
- 2 = 133700000
- 3 = 13370000
- 4 = 1337000
- 5 = 133700
- 6 = 13370
- 7 = 1337
- 8 = 133.7
- 9 = 13.37
- 10 = 1.337
- 11 = 0.1337
- 12 = 0.01337
- 13 = 0.001337
- 14 = 0.0001337
- 15 = 0.00001337

As seen, this gives quite a lot of flexibility. Of course, you could also do this for other operations.. And you don't need to go to extremes and use a full 4 bits.

## Use bits as boolean values.

If anything can be boiled down to a yes or no, true or false, etc - Use the bits! Don't waste a byte, or whatever else you can think of.

## Denote your protocol with extension bits.
If you are unsure, if the protocol might be extended one day - Design for it. This is usually done by reserving one bit in each byte explaining something about something (data types, what measure your measurement is actually of (ie temperature, water flow, cars seen in a day, etc..))