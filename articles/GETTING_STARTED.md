# Getting started

The API is structured so that all Request/Responses are named the same, and grouped with either TX or RX messages.

The actual class communicating with the iU880B-USB Dongle is the [IU880BModem](xref:FosterBuster.IU880B.IU880BModem)-class.

This class should be instantiated using the _Microsoft.Extensions.DependencyInjection_-library.

	ServiceProvider serviceCollection = new ServiceCollection().AddIU880BModem(x =>
        {
            x.Name = "USB";
            x.UsePortFinder = true;
        })
        .BuildServiceProvider();
		
    IU880BModem modem = serviceCollection.GetService<IU880BModem>();

Using the _serviceCollection_ to retrieve it, will ensure that you are accessing the class as a singleton.

**...As such you can reference the same instance anywhere in your project.**

## IU880BModem

The IU880BModem class have two public-facing methods:

### SetReceiver
[Documentation for SetReceiver here](xref:FosterBuster.IU880B.IU880BModem.SetReceiver(System.Func{FosterBuster.IU880B.Messaging.Rx.RxHciMessage,System.Threading.Tasks.Task}))


**Example usage**

	modem.SetReceiver(async (RxHciMessage message) => { await Task.CompletedTask; });
	
As seen, this method expects to be passed an async delegate with the type [RxHciMessage](xref:FosterBuster.IU880B.Messaging.Rx.RxHciMessage). It is your responsibility, to derive the actual subtype of this class.

This can be done, by doing something like this:

    if (message is DataMessageResponse response)
    {
        // do something with the response!
    }

or 

	modem.SetReceiver(async (RxHciMessage message) => await Handle((dynamic)message));
	
	private async Task Handle(DataMessageResponse response)
    {
        // do something with the response!
    }

    private async Task Handle(NetworkStatusResponse networkStatusResponse)
    {
        // // do something with the network status response!
    }

    // This method is called if a handler for the type could not be resolved.
    private async Task Handle(object obj)
    {
        throw new NotImplementedException("Not handled: " + obj.ToString());
    }
	
or maybe a completely different strategy.
	
> [!NOTE]
> Since [SetReceiver](xref:FosterBuster.IU880B.IU880BModem.SetReceiver(System.Func{FosterBuster.IU880B.Messaging.Rx.RxHciMessage,System.Threading.Tasks.Task})) is a delegate, you can subscribe to received messages multiple times in your code, by calling it multiple times.

**The IU880BModem class will handle any and all marshalling, checksums and so forth.**

### TransmitMessage

[Documentation for TransmitMessage here](xref:FosterBuster.IU880B.IU880BModem.TransmitMessage(FosterBuster.IU880B.Messaging.Tx.TxHciMessage))



**Example usage**

	var payload = new List<byte>() { 0xFF });
	
	await modem.TransmitMessage(new UnreliableDataMessageRequest(5, payload);

Usage seems quite self-explanitory. Any any type deriving from [TxHciMessage](xref:FosterBuster.IU880B.Messaging.Tx.TxHciMessage) can be passed, and any _concrete_ type should be passed.

**The IU880BModem class will handle any and all marshalling, checksums and so forth.**


## Activation

[Documentation for the TX Activation Namespace](xref:FosterBuster.IU880B.Messaging.Tx.LoRaWAN.Activation)

[Documentation for the RX Activation Namespace](xref:FosterBuster.IU880B.Messaging.Rx.LoRaWAN.Activation)

Activation can be accomplished in the following two ways:

### OTAA

1. First configure the OTAA-parameters by sending a [SetJoinParametersRequest](xref:FosterBuster.IU880B.Messaging.Tx.LoRaWAN.Activation.SetJoinParametersRequest).

2. If you get a successful [response](xref:FosterBuster.IU880B.Messaging.Rx.LoRaWAN.Activation.SetJoinParametersResponse), go ahead and send a [OverTheAirActivationRequest](xref:FosterBuster.IU880B.Messaging.Tx.LoRaWAN.Activation.OverTheAirActivationRequest).

3. When you receive a [JoinNetworkIndication](xref:FosterBuster.IU880B.Messaging.Rx.LoRaWAN.Activation.JoinNetworkIndication) the device has been activated.

### ABP

For ABP just send a [ActivationByPersonalisationRequest](xref:FosterBuster.IU880B.Messaging.Tx.LoRaWAN.Activation.ActivationByPersonalisationRequest)

## Other

It might be of value to know that the project refers to a collection of extension methods, that might come in handy when working with bytes and iMST-products. These are already referenced by the library.

Their source are available [here](https://github.com/fosterbuster/ExtensionMethods/tree/master/ExtensionMethods)

And available on Nuget [here](https://www.nuget.org/packages/FosterBuster.Extensions)