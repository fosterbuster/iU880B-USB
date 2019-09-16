# API Documentation

_Welcome to the API documentation for IU880B._

## Getting started

The actual class communicating with the iU880B-USB Dongle is the [IU880BModem](FosterBuster.IU880B.IU880BModem.html)-class.

This class have two public-facing methods:

[SetReceiver](FosterBuster.IU880B.IU880BModem.html#FosterBuster_IU880B_IU880BModem_SetReceiver_System_Func_FosterBuster_IU880B_Messaging_Rx_RxHciMessage_System_Threading_Tasks_Task__)

and

[TransmitMessage](http://localhost:8080/api/FosterBuster.IU880B.IU880BModem.html#FosterBuster_IU880B_IU880BModem_TransmitMessage_FosterBuster_IU880B_Messaging_Tx_TxHciMessage_)


The [SetReceiver](FosterBuster.IU880B.IU880BModem.html#FosterBuster_IU880B_IU880BModem_SetReceiver_System_Func_FosterBuster_IU880B_Messaging_Rx_RxHciMessage_System_Threading_Tasks_Task__)-method takes a _Func<[RxHCIMessage](FosterBuster.IU880B.Messaging.Rx.RxHciMessage.html), Task>_. This is basically an async action that can be used to listen for incoming messages from the dongle. 

**Example usage**

	modem.SetReceiver(async (RxHciMessage message) => { await Task.CompletedTask; });
	
Please refer to the [example project](../Example/Program.cs) for a more fleshed out example.

Its worth noting that all messages which can be received, are of the basetype [RxHCIMessage](FosterBuster.IU880B.Messaging.Rx.RxHciMessage.html).

All messages which can be transmitted are of the type [TxHCIMessage](FosterBuster.IU880B.Messaging.Tx.TxHciMessage.html).

The API is structured so that all Request/Responses are named the same, and grouped with either TX or RX messages.


_It hopefully goes without saying, that if should one actually use this library.. The entirety of the logic of the program should not be shoehorned into an async lambda_
