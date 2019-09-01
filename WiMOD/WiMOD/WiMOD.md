<a name='assembly'></a>
# WiMOD

## Contents

- [ActivationByPersonalisationRequest](#T-WiMOD-Messaging-Tx-LoRa-Activation-ActivationByPersonalisationRequest 'WiMOD.Messaging.Tx.LoRa.Activation.ActivationByPersonalisationRequest')
  - [#ctor(deviceAddress,networkSessionKey,applicationSessionKey)](#M-WiMOD-Messaging-Tx-LoRa-Activation-ActivationByPersonalisationRequest-#ctor-System-String,System-String,System-String- 'WiMOD.Messaging.Tx.LoRa.Activation.ActivationByPersonalisationRequest.#ctor(System.String,System.String,System.String)')
  - [#ctor(deviceAddress,networkSessionKey,applicationSessionKey)](#M-WiMOD-Messaging-Tx-LoRa-Activation-ActivationByPersonalisationRequest-#ctor-System-Collections-Generic-IList{System-Byte},System-Collections-Generic-IList{System-Byte},System-Collections-Generic-IList{System-Byte}- 'WiMOD.Messaging.Tx.LoRa.Activation.ActivationByPersonalisationRequest.#ctor(System.Collections.Generic.IList{System.Byte},System.Collections.Generic.IList{System.Byte},System.Collections.Generic.IList{System.Byte})')
- [ActivationByPersonalisationResponse](#T-WiMOD-Messaging-Rx-Activation-ActivationByPersonalisationResponse 'WiMOD.Messaging.Rx.Activation.ActivationByPersonalisationResponse')
  - [#ctor(payload)](#M-WiMOD-Messaging-Rx-Activation-ActivationByPersonalisationResponse-#ctor-System-Collections-Generic-IList{System-Byte}- 'WiMOD.Messaging.Rx.Activation.ActivationByPersonalisationResponse.#ctor(System.Collections.Generic.IList{System.Byte})')
  - [Status](#P-WiMOD-Messaging-Rx-Activation-ActivationByPersonalisationResponse-Status 'WiMOD.Messaging.Rx.Activation.ActivationByPersonalisationResponse.Status')
  - [ToString()](#M-WiMOD-Messaging-Rx-Activation-ActivationByPersonalisationResponse-ToString 'WiMOD.Messaging.Rx.Activation.ActivationByPersonalisationResponse.ToString')
- [BitwiseExtensions](#T-WiMOD-Helpers-Extensions-BitwiseExtensions 'WiMOD.Helpers.Extensions.BitwiseExtensions')
  - [CRC16Table](#F-WiMOD-Helpers-Extensions-BitwiseExtensions-CRC16Table 'WiMOD.Helpers.Extensions.BitwiseExtensions.CRC16Table')
  - [AppendCrc(bytes)](#M-WiMOD-Helpers-Extensions-BitwiseExtensions-AppendCrc-System-Collections-Generic-IList{System-Byte}- 'WiMOD.Helpers.Extensions.BitwiseExtensions.AppendCrc(System.Collections.Generic.IList{System.Byte})')
  - [CalculateCrc(bytes)](#M-WiMOD-Helpers-Extensions-BitwiseExtensions-CalculateCrc-System-Collections-Generic-IList{System-Byte}- 'WiMOD.Helpers.Extensions.BitwiseExtensions.CalculateCrc(System.Collections.Generic.IList{System.Byte})')
  - [EncodeSlipFrame(bytes,appendCrc)](#M-WiMOD-Helpers-Extensions-BitwiseExtensions-EncodeSlipFrame-System-Collections-Generic-IList{System-Byte},System-Boolean- 'WiMOD.Helpers.Extensions.BitwiseExtensions.EncodeSlipFrame(System.Collections.Generic.IList{System.Byte},System.Boolean)')
  - [GetBit(b,position)](#M-WiMOD-Helpers-Extensions-BitwiseExtensions-GetBit-System-Byte,System-Int32- 'WiMOD.Helpers.Extensions.BitwiseExtensions.GetBit(System.Byte,System.Int32)')
  - [HexStringToBytes(hexString)](#M-WiMOD-Helpers-Extensions-BitwiseExtensions-HexStringToBytes-System-String- 'WiMOD.Helpers.Extensions.BitwiseExtensions.HexStringToBytes(System.String)')
  - [HighNibble(b)](#M-WiMOD-Helpers-Extensions-BitwiseExtensions-HighNibble-System-Byte- 'WiMOD.Helpers.Extensions.BitwiseExtensions.HighNibble(System.Byte)')
  - [LowNibble(b)](#M-WiMOD-Helpers-Extensions-BitwiseExtensions-LowNibble-System-Byte- 'WiMOD.Helpers.Extensions.BitwiseExtensions.LowNibble(System.Byte)')
  - [Mask(b,mask)](#M-WiMOD-Helpers-Extensions-BitwiseExtensions-Mask-System-Byte,System-Byte- 'WiMOD.Helpers.Extensions.BitwiseExtensions.Mask(System.Byte,System.Byte)')
  - [SetBit(b,position)](#M-WiMOD-Helpers-Extensions-BitwiseExtensions-SetBit-System-Byte,System-Int32- 'WiMOD.Helpers.Extensions.BitwiseExtensions.SetBit(System.Byte,System.Int32)')
  - [StripSlipFrame(bytes,validateCrc)](#M-WiMOD-Helpers-Extensions-BitwiseExtensions-StripSlipFrame-System-Collections-Generic-IList{System-Byte},System-Boolean- 'WiMOD.Helpers.Extensions.BitwiseExtensions.StripSlipFrame(System.Collections.Generic.IList{System.Byte},System.Boolean)')
  - [ToHexString(bytes)](#M-WiMOD-Helpers-Extensions-BitwiseExtensions-ToHexString-System-Collections-Generic-IList{System-Byte}- 'WiMOD.Helpers.Extensions.BitwiseExtensions.ToHexString(System.Collections.Generic.IList{System.Byte})')
  - [ValidateCrc(bytes)](#M-WiMOD-Helpers-Extensions-BitwiseExtensions-ValidateCrc-System-Collections-Generic-IList{System-Byte}- 'WiMOD.Helpers.Extensions.BitwiseExtensions.ValidateCrc(System.Collections.Generic.IList{System.Byte})')
- [ConfigureRadioStackRequest](#T-WiMOD-Messaging-Tx-LoRa-Configuration-ConfigureRadioStackRequest 'WiMOD.Messaging.Tx.LoRa.Configuration.ConfigureRadioStackRequest')
  - [#ctor(dataRateIndex,adaptiveDataRateEnabled,dutyCycleControlEnabled,isClassC,extendedOutputFormatEnabled,rxMacForwardingEnabled,powerSavingEnabled,retryAttemps,headerMacCmdCapacity)](#M-WiMOD-Messaging-Tx-LoRa-Configuration-ConfigureRadioStackRequest-#ctor-WiMOD-Messaging-Tx-LoRa-Configuration-DataRateIndex,System-Boolean,System-Boolean,System-Boolean,System-Boolean,System-Boolean,System-Boolean,System-Byte,System-Byte- 'WiMOD.Messaging.Tx.LoRa.Configuration.ConfigureRadioStackRequest.#ctor(WiMOD.Messaging.Tx.LoRa.Configuration.DataRateIndex,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.Byte,System.Byte)')
- [ConfigureRadioStackResponse](#T-WiMOD-Messaging-Rx-LoRa-Configuration-ConfigureRadioStackResponse 'WiMOD.Messaging.Rx.LoRa.Configuration.ConfigureRadioStackResponse')
  - [#ctor(payload)](#M-WiMOD-Messaging-Rx-LoRa-Configuration-ConfigureRadioStackResponse-#ctor-System-Collections-Generic-IList{System-Byte}- 'WiMOD.Messaging.Rx.LoRa.Configuration.ConfigureRadioStackResponse.#ctor(System.Collections.Generic.IList{System.Byte})')
  - [Status](#P-WiMOD-Messaging-Rx-LoRa-Configuration-ConfigureRadioStackResponse-Status 'WiMOD.Messaging.Rx.LoRa.Configuration.ConfigureRadioStackResponse.Status')
  - [ToString()](#M-WiMOD-Messaging-Rx-LoRa-Configuration-ConfigureRadioStackResponse-ToString 'WiMOD.Messaging.Rx.LoRa.Configuration.ConfigureRadioStackResponse.ToString')
- [DataRateIndex](#T-WiMOD-Messaging-Tx-LoRa-Configuration-DataRateIndex 'WiMOD.Messaging.Tx.LoRa.Configuration.DataRateIndex')
  - [SpreadingFactor10](#F-WiMOD-Messaging-Tx-LoRa-Configuration-DataRateIndex-SpreadingFactor10 'WiMOD.Messaging.Tx.LoRa.Configuration.DataRateIndex.SpreadingFactor10')
  - [SpreadingFactor11](#F-WiMOD-Messaging-Tx-LoRa-Configuration-DataRateIndex-SpreadingFactor11 'WiMOD.Messaging.Tx.LoRa.Configuration.DataRateIndex.SpreadingFactor11')
  - [SpreadingFactor12](#F-WiMOD-Messaging-Tx-LoRa-Configuration-DataRateIndex-SpreadingFactor12 'WiMOD.Messaging.Tx.LoRa.Configuration.DataRateIndex.SpreadingFactor12')
  - [SpreadingFactor7](#F-WiMOD-Messaging-Tx-LoRa-Configuration-DataRateIndex-SpreadingFactor7 'WiMOD.Messaging.Tx.LoRa.Configuration.DataRateIndex.SpreadingFactor7')
  - [SpreadingFactor8](#F-WiMOD-Messaging-Tx-LoRa-Configuration-DataRateIndex-SpreadingFactor8 'WiMOD.Messaging.Tx.LoRa.Configuration.DataRateIndex.SpreadingFactor8')
  - [SpreadingFactor9](#F-WiMOD-Messaging-Tx-LoRa-Configuration-DataRateIndex-SpreadingFactor9 'WiMOD.Messaging.Tx.LoRa.Configuration.DataRateIndex.SpreadingFactor9')
- [DeviceInformationRequest](#T-WiMOD-Messaging-Tx-Device-DeviceInformationRequest 'WiMOD.Messaging.Tx.Device.DeviceInformationRequest')
  - [#ctor()](#M-WiMOD-Messaging-Tx-Device-DeviceInformationRequest-#ctor 'WiMOD.Messaging.Tx.Device.DeviceInformationRequest.#ctor')
- [DeviceInformationResponse](#T-WiMOD-Messaging-Rx-Device-DeviceInformationResponse 'WiMOD.Messaging.Rx.Device.DeviceInformationResponse')
  - [#ctor(payload)](#M-WiMOD-Messaging-Rx-Device-DeviceInformationResponse-#ctor-System-Collections-Generic-IList{System-Byte}- 'WiMOD.Messaging.Rx.Device.DeviceInformationResponse.#ctor(System.Collections.Generic.IList{System.Byte})')
  - [DeviceAddress](#P-WiMOD-Messaging-Rx-Device-DeviceInformationResponse-DeviceAddress 'WiMOD.Messaging.Rx.Device.DeviceInformationResponse.DeviceAddress')
  - [DeviceId](#P-WiMOD-Messaging-Rx-Device-DeviceInformationResponse-DeviceId 'WiMOD.Messaging.Rx.Device.DeviceInformationResponse.DeviceId')
  - [ModuleType](#P-WiMOD-Messaging-Rx-Device-DeviceInformationResponse-ModuleType 'WiMOD.Messaging.Rx.Device.DeviceInformationResponse.ModuleType')
  - [Status](#P-WiMOD-Messaging-Rx-Device-DeviceInformationResponse-Status 'WiMOD.Messaging.Rx.Device.DeviceInformationResponse.Status')
  - [ToString()](#M-WiMOD-Messaging-Rx-Device-DeviceInformationResponse-ToString 'WiMOD.Messaging.Rx.Device.DeviceInformationResponse.ToString')
- [DeviceManagementMessageIdentifier](#T-WiMOD-Messaging-DeviceManagementMessageIdentifier 'WiMOD.Messaging.DeviceManagementMessageIdentifier')
  - [DeviceInfoRequest](#F-WiMOD-Messaging-DeviceManagementMessageIdentifier-DeviceInfoRequest 'WiMOD.Messaging.DeviceManagementMessageIdentifier.DeviceInfoRequest')
  - [DeviceInfoResponse](#F-WiMOD-Messaging-DeviceManagementMessageIdentifier-DeviceInfoResponse 'WiMOD.Messaging.DeviceManagementMessageIdentifier.DeviceInfoResponse')
  - [FirmwareVersionRequest](#F-WiMOD-Messaging-DeviceManagementMessageIdentifier-FirmwareVersionRequest 'WiMOD.Messaging.DeviceManagementMessageIdentifier.FirmwareVersionRequest')
  - [FirmwareVersionResponse](#F-WiMOD-Messaging-DeviceManagementMessageIdentifier-FirmwareVersionResponse 'WiMOD.Messaging.DeviceManagementMessageIdentifier.FirmwareVersionResponse')
  - [PingRequest](#F-WiMOD-Messaging-DeviceManagementMessageIdentifier-PingRequest 'WiMOD.Messaging.DeviceManagementMessageIdentifier.PingRequest')
  - [PingResponse](#F-WiMOD-Messaging-DeviceManagementMessageIdentifier-PingResponse 'WiMOD.Messaging.DeviceManagementMessageIdentifier.PingResponse')
  - [ResetReqest](#F-WiMOD-Messaging-DeviceManagementMessageIdentifier-ResetReqest 'WiMOD.Messaging.DeviceManagementMessageIdentifier.ResetReqest')
  - [ResetResponse](#F-WiMOD-Messaging-DeviceManagementMessageIdentifier-ResetResponse 'WiMOD.Messaging.DeviceManagementMessageIdentifier.ResetResponse')
  - [SystemOperationModeRequest](#F-WiMOD-Messaging-DeviceManagementMessageIdentifier-SystemOperationModeRequest 'WiMOD.Messaging.DeviceManagementMessageIdentifier.SystemOperationModeRequest')
  - [SystemOperationModeResponse](#F-WiMOD-Messaging-DeviceManagementMessageIdentifier-SystemOperationModeResponse 'WiMOD.Messaging.DeviceManagementMessageIdentifier.SystemOperationModeResponse')
- [DeviceRxHciMessage](#T-WiMOD-Messaging-Rx-DeviceRxHciMessage 'WiMOD.Messaging.Rx.DeviceRxHciMessage')
  - [#ctor(identifier,payload)](#M-WiMOD-Messaging-Rx-DeviceRxHciMessage-#ctor-WiMOD-Messaging-DeviceManagementMessageIdentifier,System-Collections-Generic-IList{System-Byte}- 'WiMOD.Messaging.Rx.DeviceRxHciMessage.#ctor(WiMOD.Messaging.DeviceManagementMessageIdentifier,System.Collections.Generic.IList{System.Byte})')
  - [MessageIdentifier](#P-WiMOD-Messaging-Rx-DeviceRxHciMessage-MessageIdentifier 'WiMOD.Messaging.Rx.DeviceRxHciMessage.MessageIdentifier')
- [DeviceTxMessage](#T-WiMOD-Messaging-Tx-Device-DeviceTxMessage 'WiMOD.Messaging.Tx.Device.DeviceTxMessage')
  - [#ctor(messageIdentifier,payload)](#M-WiMOD-Messaging-Tx-Device-DeviceTxMessage-#ctor-WiMOD-Messaging-DeviceManagementMessageIdentifier,System-Collections-Generic-List{System-Byte}- 'WiMOD.Messaging.Tx.Device.DeviceTxMessage.#ctor(WiMOD.Messaging.DeviceManagementMessageIdentifier,System.Collections.Generic.List{System.Byte})')
  - [MessageIdentifier](#P-WiMOD-Messaging-Tx-Device-DeviceTxMessage-MessageIdentifier 'WiMOD.Messaging.Tx.Device.DeviceTxMessage.MessageIdentifier')
- [EndpointIdentifier](#T-WiMOD-Messaging-EndpointIdentifier 'WiMOD.Messaging.EndpointIdentifier')
  - [DeviceManager](#F-WiMOD-Messaging-EndpointIdentifier-DeviceManager 'WiMOD.Messaging.EndpointIdentifier.DeviceManager')
  - [LoRaWANModem](#F-WiMOD-Messaging-EndpointIdentifier-LoRaWANModem 'WiMOD.Messaging.EndpointIdentifier.LoRaWANModem')
- [EnumExtensions](#T-WiMOD-Helpers-Extensions-EnumExtensions 'WiMOD.Helpers.Extensions.EnumExtensions')
  - [As\`\`1(value)](#M-WiMOD-Helpers-Extensions-EnumExtensions-As``1-System-Byte- 'WiMOD.Helpers.Extensions.EnumExtensions.As``1(System.Byte)')
  - [ToFormattedString\`\`1(value)](#M-WiMOD-Helpers-Extensions-EnumExtensions-ToFormattedString``1-``0- 'WiMOD.Helpers.Extensions.EnumExtensions.ToFormattedString``1(``0)')
- [HciMessage](#T-WiMOD-Messaging-HciMessage 'WiMOD.Messaging.HciMessage')
- [JoinNetworkIndication](#T-WiMOD-Messaging-Rx-Activation-JoinNetworkIndication 'WiMOD.Messaging.Rx.Activation.JoinNetworkIndication')
  - [#ctor(payload)](#M-WiMOD-Messaging-Rx-Activation-JoinNetworkIndication-#ctor-System-Collections-Generic-IList{System-Byte}- 'WiMOD.Messaging.Rx.Activation.JoinNetworkIndication.#ctor(System.Collections.Generic.IList{System.Byte})')
  - [ChannelIndex](#P-WiMOD-Messaging-Rx-Activation-JoinNetworkIndication-ChannelIndex 'WiMOD.Messaging.Rx.Activation.JoinNetworkIndication.ChannelIndex')
  - [DataRate](#P-WiMOD-Messaging-Rx-Activation-JoinNetworkIndication-DataRate 'WiMOD.Messaging.Rx.Activation.JoinNetworkIndication.DataRate')
  - [DeviceActivated](#P-WiMOD-Messaging-Rx-Activation-JoinNetworkIndication-DeviceActivated 'WiMOD.Messaging.Rx.Activation.JoinNetworkIndication.DeviceActivated')
  - [DeviceAddress](#P-WiMOD-Messaging-Rx-Activation-JoinNetworkIndication-DeviceAddress 'WiMOD.Messaging.Rx.Activation.JoinNetworkIndication.DeviceAddress')
  - [RelativeSignalStrenghtIndicator](#P-WiMOD-Messaging-Rx-Activation-JoinNetworkIndication-RelativeSignalStrenghtIndicator 'WiMOD.Messaging.Rx.Activation.JoinNetworkIndication.RelativeSignalStrenghtIndicator')
  - [RxSlot](#P-WiMOD-Messaging-Rx-Activation-JoinNetworkIndication-RxSlot 'WiMOD.Messaging.Rx.Activation.JoinNetworkIndication.RxSlot')
  - [SignalToNoiseRatio](#P-WiMOD-Messaging-Rx-Activation-JoinNetworkIndication-SignalToNoiseRatio 'WiMOD.Messaging.Rx.Activation.JoinNetworkIndication.SignalToNoiseRatio')
  - [ToString()](#M-WiMOD-Messaging-Rx-Activation-JoinNetworkIndication-ToString 'WiMOD.Messaging.Rx.Activation.JoinNetworkIndication.ToString')
- [JoinNetworkPacketTransmitIndication](#T-WiMOD-Messaging-Rx-Activation-JoinNetworkPacketTransmitIndication 'WiMOD.Messaging.Rx.Activation.JoinNetworkPacketTransmitIndication')
  - [#ctor(payload)](#M-WiMOD-Messaging-Rx-Activation-JoinNetworkPacketTransmitIndication-#ctor-System-Collections-Generic-IList{System-Byte}- 'WiMOD.Messaging.Rx.Activation.JoinNetworkPacketTransmitIndication.#ctor(System.Collections.Generic.IList{System.Byte})')
  - [ChannelIndex](#P-WiMOD-Messaging-Rx-Activation-JoinNetworkPacketTransmitIndication-ChannelIndex 'WiMOD.Messaging.Rx.Activation.JoinNetworkPacketTransmitIndication.ChannelIndex')
  - [DataRate](#P-WiMOD-Messaging-Rx-Activation-JoinNetworkPacketTransmitIndication-DataRate 'WiMOD.Messaging.Rx.Activation.JoinNetworkPacketTransmitIndication.DataRate')
  - [MessageAirTimeMillis](#P-WiMOD-Messaging-Rx-Activation-JoinNetworkPacketTransmitIndication-MessageAirTimeMillis 'WiMOD.Messaging.Rx.Activation.JoinNetworkPacketTransmitIndication.MessageAirTimeMillis')
  - [RadioPacketSent](#P-WiMOD-Messaging-Rx-Activation-JoinNetworkPacketTransmitIndication-RadioPacketSent 'WiMOD.Messaging.Rx.Activation.JoinNetworkPacketTransmitIndication.RadioPacketSent')
  - [TransmitPowerLevel](#P-WiMOD-Messaging-Rx-Activation-JoinNetworkPacketTransmitIndication-TransmitPowerLevel 'WiMOD.Messaging.Rx.Activation.JoinNetworkPacketTransmitIndication.TransmitPowerLevel')
  - [TransmittedRadioPackets](#P-WiMOD-Messaging-Rx-Activation-JoinNetworkPacketTransmitIndication-TransmittedRadioPackets 'WiMOD.Messaging.Rx.Activation.JoinNetworkPacketTransmitIndication.TransmittedRadioPackets')
  - [ToString()](#M-WiMOD-Messaging-Rx-Activation-JoinNetworkPacketTransmitIndication-ToString 'WiMOD.Messaging.Rx.Activation.JoinNetworkPacketTransmitIndication.ToString')
- [LoRaWanMessageIdentifier](#T-WiMOD-Messaging-LoRaWanMessageIdentifier 'WiMOD.Messaging.LoRaWanMessageIdentifier')
  - [ActivateDeviceRequest](#F-WiMOD-Messaging-LoRaWanMessageIdentifier-ActivateDeviceRequest 'WiMOD.Messaging.LoRaWanMessageIdentifier.ActivateDeviceRequest')
  - [ActivateDeviceResponse](#F-WiMOD-Messaging-LoRaWanMessageIdentifier-ActivateDeviceResponse 'WiMOD.Messaging.LoRaWanMessageIdentifier.ActivateDeviceResponse')
  - [JoinNetworkIndication](#F-WiMOD-Messaging-LoRaWanMessageIdentifier-JoinNetworkIndication 'WiMOD.Messaging.LoRaWanMessageIdentifier.JoinNetworkIndication')
  - [JoinNetworkRequest](#F-WiMOD-Messaging-LoRaWanMessageIdentifier-JoinNetworkRequest 'WiMOD.Messaging.LoRaWanMessageIdentifier.JoinNetworkRequest')
  - [JoinNetworkResponse](#F-WiMOD-Messaging-LoRaWanMessageIdentifier-JoinNetworkResponse 'WiMOD.Messaging.LoRaWanMessageIdentifier.JoinNetworkResponse')
  - [JoinNetworkTxIndication](#F-WiMOD-Messaging-LoRaWanMessageIdentifier-JoinNetworkTxIndication 'WiMOD.Messaging.LoRaWanMessageIdentifier.JoinNetworkTxIndication')
  - [NetworkStatusRequest](#F-WiMOD-Messaging-LoRaWanMessageIdentifier-NetworkStatusRequest 'WiMOD.Messaging.LoRaWanMessageIdentifier.NetworkStatusRequest')
  - [NetworkStatusResponse](#F-WiMOD-Messaging-LoRaWanMessageIdentifier-NetworkStatusResponse 'WiMOD.Messaging.LoRaWanMessageIdentifier.NetworkStatusResponse')
  - [ReceiveAckIndication](#F-WiMOD-Messaging-LoRaWanMessageIdentifier-ReceiveAckIndication 'WiMOD.Messaging.LoRaWanMessageIdentifier.ReceiveAckIndication')
  - [ReceiveCDataIndication](#F-WiMOD-Messaging-LoRaWanMessageIdentifier-ReceiveCDataIndication 'WiMOD.Messaging.LoRaWanMessageIdentifier.ReceiveCDataIndication')
  - [ReceiveNoDataIndication](#F-WiMOD-Messaging-LoRaWanMessageIdentifier-ReceiveNoDataIndication 'WiMOD.Messaging.LoRaWanMessageIdentifier.ReceiveNoDataIndication')
  - [ReceiveUDataIndication](#F-WiMOD-Messaging-LoRaWanMessageIdentifier-ReceiveUDataIndication 'WiMOD.Messaging.LoRaWanMessageIdentifier.ReceiveUDataIndication')
  - [SendCDataRequest](#F-WiMOD-Messaging-LoRaWanMessageIdentifier-SendCDataRequest 'WiMOD.Messaging.LoRaWanMessageIdentifier.SendCDataRequest')
  - [SendCDataResponse](#F-WiMOD-Messaging-LoRaWanMessageIdentifier-SendCDataResponse 'WiMOD.Messaging.LoRaWanMessageIdentifier.SendCDataResponse')
  - [SendCDataTxIndication](#F-WiMOD-Messaging-LoRaWanMessageIdentifier-SendCDataTxIndication 'WiMOD.Messaging.LoRaWanMessageIdentifier.SendCDataTxIndication')
  - [SendUDataRequest](#F-WiMOD-Messaging-LoRaWanMessageIdentifier-SendUDataRequest 'WiMOD.Messaging.LoRaWanMessageIdentifier.SendUDataRequest')
  - [SendUDataResponse](#F-WiMOD-Messaging-LoRaWanMessageIdentifier-SendUDataResponse 'WiMOD.Messaging.LoRaWanMessageIdentifier.SendUDataResponse')
  - [SendUDataTxIndication](#F-WiMOD-Messaging-LoRaWanMessageIdentifier-SendUDataTxIndication 'WiMOD.Messaging.LoRaWanMessageIdentifier.SendUDataTxIndication')
  - [SetJoinParameterRequest](#F-WiMOD-Messaging-LoRaWanMessageIdentifier-SetJoinParameterRequest 'WiMOD.Messaging.LoRaWanMessageIdentifier.SetJoinParameterRequest')
  - [SetJoinParameterResponse](#F-WiMOD-Messaging-LoRaWanMessageIdentifier-SetJoinParameterResponse 'WiMOD.Messaging.LoRaWanMessageIdentifier.SetJoinParameterResponse')
  - [SetRadioStackRequest](#F-WiMOD-Messaging-LoRaWanMessageIdentifier-SetRadioStackRequest 'WiMOD.Messaging.LoRaWanMessageIdentifier.SetRadioStackRequest')
  - [SetRadioStackResponse](#F-WiMOD-Messaging-LoRaWanMessageIdentifier-SetRadioStackResponse 'WiMOD.Messaging.LoRaWanMessageIdentifier.SetRadioStackResponse')
- [LoRaWanRxHciMessage](#T-WiMOD-Messaging-Rx-LoRaWanRxHciMessage 'WiMOD.Messaging.Rx.LoRaWanRxHciMessage')
  - [#ctor(identifier,payload)](#M-WiMOD-Messaging-Rx-LoRaWanRxHciMessage-#ctor-WiMOD-Messaging-LoRaWanMessageIdentifier,System-Collections-Generic-IList{System-Byte}- 'WiMOD.Messaging.Rx.LoRaWanRxHciMessage.#ctor(WiMOD.Messaging.LoRaWanMessageIdentifier,System.Collections.Generic.IList{System.Byte})')
  - [MessageIdentifier](#P-WiMOD-Messaging-Rx-LoRaWanRxHciMessage-MessageIdentifier 'WiMOD.Messaging.Rx.LoRaWanRxHciMessage.MessageIdentifier')
- [LoRaWanTxMessage](#T-WiMOD-Messaging-Tx-LoRa-LoRaWanTxMessage 'WiMOD.Messaging.Tx.LoRa.LoRaWanTxMessage')
  - [#ctor(messageIdentifier,payload)](#M-WiMOD-Messaging-Tx-LoRa-LoRaWanTxMessage-#ctor-WiMOD-Messaging-LoRaWanMessageIdentifier,System-Collections-Generic-List{System-Byte}- 'WiMOD.Messaging.Tx.LoRa.LoRaWanTxMessage.#ctor(WiMOD.Messaging.LoRaWanMessageIdentifier,System.Collections.Generic.List{System.Byte})')
  - [MessageIdentifier](#P-WiMOD-Messaging-Tx-LoRa-LoRaWanTxMessage-MessageIdentifier 'WiMOD.Messaging.Tx.LoRa.LoRaWanTxMessage.MessageIdentifier')
- [NetworkStatusIndicator](#T-WiMOD-Messaging-Rx-Configuration-NetworkStatusIndicator 'WiMOD.Messaging.Rx.Configuration.NetworkStatusIndicator')
  - [DeviceActiveByActivationByPersonalisation](#F-WiMOD-Messaging-Rx-Configuration-NetworkStatusIndicator-DeviceActiveByActivationByPersonalisation 'WiMOD.Messaging.Rx.Configuration.NetworkStatusIndicator.DeviceActiveByActivationByPersonalisation')
  - [DeviceActiveByOverTheAirActivation](#F-WiMOD-Messaging-Rx-Configuration-NetworkStatusIndicator-DeviceActiveByOverTheAirActivation 'WiMOD.Messaging.Rx.Configuration.NetworkStatusIndicator.DeviceActiveByOverTheAirActivation')
  - [DeviceInactive](#F-WiMOD-Messaging-Rx-Configuration-NetworkStatusIndicator-DeviceInactive 'WiMOD.Messaging.Rx.Configuration.NetworkStatusIndicator.DeviceInactive')
  - [DeviceJoiningByOverTheAirActivation](#F-WiMOD-Messaging-Rx-Configuration-NetworkStatusIndicator-DeviceJoiningByOverTheAirActivation 'WiMOD.Messaging.Rx.Configuration.NetworkStatusIndicator.DeviceJoiningByOverTheAirActivation')
- [NetworkStatusRequest](#T-WiMOD-Messaging-Tx-LoRa-Configuration-NetworkStatusRequest 'WiMOD.Messaging.Tx.LoRa.Configuration.NetworkStatusRequest')
  - [#ctor()](#M-WiMOD-Messaging-Tx-LoRa-Configuration-NetworkStatusRequest-#ctor 'WiMOD.Messaging.Tx.LoRa.Configuration.NetworkStatusRequest.#ctor')
- [NetworkStatusResponse](#T-WiMOD-Messaging-Rx-Configuration-NetworkStatusResponse 'WiMOD.Messaging.Rx.Configuration.NetworkStatusResponse')
  - [#ctor(payload)](#M-WiMOD-Messaging-Rx-Configuration-NetworkStatusResponse-#ctor-System-Collections-Generic-IList{System-Byte}- 'WiMOD.Messaging.Rx.Configuration.NetworkStatusResponse.#ctor(System.Collections.Generic.IList{System.Byte})')
  - [DataRate](#P-WiMOD-Messaging-Rx-Configuration-NetworkStatusResponse-DataRate 'WiMOD.Messaging.Rx.Configuration.NetworkStatusResponse.DataRate')
  - [DeviceActive](#P-WiMOD-Messaging-Rx-Configuration-NetworkStatusResponse-DeviceActive 'WiMOD.Messaging.Rx.Configuration.NetworkStatusResponse.DeviceActive')
  - [DeviceAddress](#P-WiMOD-Messaging-Rx-Configuration-NetworkStatusResponse-DeviceAddress 'WiMOD.Messaging.Rx.Configuration.NetworkStatusResponse.DeviceAddress')
  - [DeviceJoining](#P-WiMOD-Messaging-Rx-Configuration-NetworkStatusResponse-DeviceJoining 'WiMOD.Messaging.Rx.Configuration.NetworkStatusResponse.DeviceJoining')
  - [MaximumPayloadSize](#P-WiMOD-Messaging-Rx-Configuration-NetworkStatusResponse-MaximumPayloadSize 'WiMOD.Messaging.Rx.Configuration.NetworkStatusResponse.MaximumPayloadSize')
  - [NetworkStatus](#P-WiMOD-Messaging-Rx-Configuration-NetworkStatusResponse-NetworkStatus 'WiMOD.Messaging.Rx.Configuration.NetworkStatusResponse.NetworkStatus')
  - [PowerLevel](#P-WiMOD-Messaging-Rx-Configuration-NetworkStatusResponse-PowerLevel 'WiMOD.Messaging.Rx.Configuration.NetworkStatusResponse.PowerLevel')
  - [Status](#P-WiMOD-Messaging-Rx-Configuration-NetworkStatusResponse-Status 'WiMOD.Messaging.Rx.Configuration.NetworkStatusResponse.Status')
  - [ToString()](#M-WiMOD-Messaging-Rx-Configuration-NetworkStatusResponse-ToString 'WiMOD.Messaging.Rx.Configuration.NetworkStatusResponse.ToString')
- [NoDataIndication](#T-WiMOD-Messaging-Rx-LoRaWAN-NoDataIndication 'WiMOD.Messaging.Rx.LoRaWAN.NoDataIndication')
  - [#ctor(payload)](#M-WiMOD-Messaging-Rx-LoRaWAN-NoDataIndication-#ctor-System-Collections-Generic-IList{System-Byte}- 'WiMOD.Messaging.Rx.LoRaWAN.NoDataIndication.#ctor(System.Collections.Generic.IList{System.Byte})')
- [OverTheAirActivationRequest](#T-WiMOD-Messaging-Tx-LoRa-Activation-OverTheAirActivationRequest 'WiMOD.Messaging.Tx.LoRa.Activation.OverTheAirActivationRequest')
  - [#ctor()](#M-WiMOD-Messaging-Tx-LoRa-Activation-OverTheAirActivationRequest-#ctor 'WiMOD.Messaging.Tx.LoRa.Activation.OverTheAirActivationRequest.#ctor')
- [OverTheAirActivationResponse](#T-WiMOD-Messaging-Rx-Activation-OverTheAirActivationResponse 'WiMOD.Messaging.Rx.Activation.OverTheAirActivationResponse')
  - [#ctor(payload)](#M-WiMOD-Messaging-Rx-Activation-OverTheAirActivationResponse-#ctor-System-Collections-Generic-IList{System-Byte}- 'WiMOD.Messaging.Rx.Activation.OverTheAirActivationResponse.#ctor(System.Collections.Generic.IList{System.Byte})')
  - [Status](#P-WiMOD-Messaging-Rx-Activation-OverTheAirActivationResponse-Status 'WiMOD.Messaging.Rx.Activation.OverTheAirActivationResponse.Status')
  - [ToString()](#M-WiMOD-Messaging-Rx-Activation-OverTheAirActivationResponse-ToString 'WiMOD.Messaging.Rx.Activation.OverTheAirActivationResponse.ToString')
- [PingRequest](#T-WiMOD-Messaging-Tx-Device-PingRequest 'WiMOD.Messaging.Tx.Device.PingRequest')
  - [#ctor()](#M-WiMOD-Messaging-Tx-Device-PingRequest-#ctor 'WiMOD.Messaging.Tx.Device.PingRequest.#ctor')
  - [ToString()](#M-WiMOD-Messaging-Tx-Device-PingRequest-ToString 'WiMOD.Messaging.Tx.Device.PingRequest.ToString')
- [PingResponse](#T-WiMOD-Messaging-Rx-Device-PingResponse 'WiMOD.Messaging.Rx.Device.PingResponse')
  - [#ctor(payload)](#M-WiMOD-Messaging-Rx-Device-PingResponse-#ctor-System-Collections-Generic-IList{System-Byte}- 'WiMOD.Messaging.Rx.Device.PingResponse.#ctor(System.Collections.Generic.IList{System.Byte})')
  - [Status](#P-WiMOD-Messaging-Rx-Device-PingResponse-Status 'WiMOD.Messaging.Rx.Device.PingResponse.Status')
  - [ToString()](#M-WiMOD-Messaging-Rx-Device-PingResponse-ToString 'WiMOD.Messaging.Rx.Device.PingResponse.ToString')
- [PortFinder](#T-WiMOD-Helpers-PortFinder 'WiMOD.Helpers.PortFinder')
  - [#ctor(options,loggerFactory)](#M-WiMOD-Helpers-PortFinder-#ctor-Microsoft-Extensions-Options-IOptions{WiMOD-DependencyInjection-WiModOptions},Microsoft-Extensions-Logging-ILoggerFactory- 'WiMOD.Helpers.PortFinder.#ctor(Microsoft.Extensions.Options.IOptions{WiMOD.DependencyInjection.WiModOptions},Microsoft.Extensions.Logging.ILoggerFactory)')
  - [ConnectedPortName](#P-WiMOD-Helpers-PortFinder-ConnectedPortName 'WiMOD.Helpers.PortFinder.ConnectedPortName')
  - [ConnectedSerialPort](#P-WiMOD-Helpers-PortFinder-ConnectedSerialPort 'WiMOD.Helpers.PortFinder.ConnectedSerialPort')
  - [DeviceAvailable()](#M-WiMOD-Helpers-PortFinder-DeviceAvailable 'WiMOD.Helpers.PortFinder.DeviceAvailable')
- [ReliableDataIndication](#T-WiMOD-Messaging-Rx-LoRaWAN-ReliableDataIndication 'WiMOD.Messaging.Rx.LoRaWAN.ReliableDataIndication')
  - [#ctor(payload)](#M-WiMOD-Messaging-Rx-LoRaWAN-ReliableDataIndication-#ctor-System-Collections-Generic-IList{System-Byte}- 'WiMOD.Messaging.Rx.LoRaWAN.ReliableDataIndication.#ctor(System.Collections.Generic.IList{System.Byte})')
  - [IsAcknowledgement](#P-WiMOD-Messaging-Rx-LoRaWAN-ReliableDataIndication-IsAcknowledgement 'WiMOD.Messaging.Rx.LoRaWAN.ReliableDataIndication.IsAcknowledgement')
- [ReliableDataMessage](#T-WiMOD-Messaging-Tx-LoRa-Data-ReliableDataMessage 'WiMOD.Messaging.Tx.LoRa.Data.ReliableDataMessage')
  - [#ctor(port,payload)](#M-WiMOD-Messaging-Tx-LoRa-Data-ReliableDataMessage-#ctor-System-Byte,System-Collections-Generic-List{System-Byte}- 'WiMOD.Messaging.Tx.LoRa.Data.ReliableDataMessage.#ctor(System.Byte,System.Collections.Generic.List{System.Byte})')
- [ReliableDataTransmitIndication](#T-WiMOD-Messaging-Rx-LoRaWAN-ReliableDataTransmitIndication 'WiMOD.Messaging.Rx.LoRaWAN.ReliableDataTransmitIndication')
  - [#ctor(payload)](#M-WiMOD-Messaging-Rx-LoRaWAN-ReliableDataTransmitIndication-#ctor-System-Collections-Generic-IList{System-Byte}- 'WiMOD.Messaging.Rx.LoRaWAN.ReliableDataTransmitIndication.#ctor(System.Collections.Generic.IList{System.Byte})')
  - [ChannelIndex](#P-WiMOD-Messaging-Rx-LoRaWAN-ReliableDataTransmitIndication-ChannelIndex 'WiMOD.Messaging.Rx.LoRaWAN.ReliableDataTransmitIndication.ChannelIndex')
  - [DataRate](#P-WiMOD-Messaging-Rx-LoRaWAN-ReliableDataTransmitIndication-DataRate 'WiMOD.Messaging.Rx.LoRaWAN.ReliableDataTransmitIndication.DataRate')
  - [MessageAirTimeMillis](#P-WiMOD-Messaging-Rx-LoRaWAN-ReliableDataTransmitIndication-MessageAirTimeMillis 'WiMOD.Messaging.Rx.LoRaWAN.ReliableDataTransmitIndication.MessageAirTimeMillis')
  - [RadioPacketSent](#P-WiMOD-Messaging-Rx-LoRaWAN-ReliableDataTransmitIndication-RadioPacketSent 'WiMOD.Messaging.Rx.LoRaWAN.ReliableDataTransmitIndication.RadioPacketSent')
  - [TransmitPowerLevel](#P-WiMOD-Messaging-Rx-LoRaWAN-ReliableDataTransmitIndication-TransmitPowerLevel 'WiMOD.Messaging.Rx.LoRaWAN.ReliableDataTransmitIndication.TransmitPowerLevel')
  - [TransmittedRadioPackets](#P-WiMOD-Messaging-Rx-LoRaWAN-ReliableDataTransmitIndication-TransmittedRadioPackets 'WiMOD.Messaging.Rx.LoRaWAN.ReliableDataTransmitIndication.TransmittedRadioPackets')
  - [ToString()](#M-WiMOD-Messaging-Rx-LoRaWAN-ReliableDataTransmitIndication-ToString 'WiMOD.Messaging.Rx.LoRaWAN.ReliableDataTransmitIndication.ToString')
- [ResetRequest](#T-WiMOD-Messaging-Tx-Device-ResetRequest 'WiMOD.Messaging.Tx.Device.ResetRequest')
  - [#ctor()](#M-WiMOD-Messaging-Tx-Device-ResetRequest-#ctor 'WiMOD.Messaging.Tx.Device.ResetRequest.#ctor')
  - [ToString()](#M-WiMOD-Messaging-Tx-Device-ResetRequest-ToString 'WiMOD.Messaging.Tx.Device.ResetRequest.ToString')
- [ResetResponse](#T-WiMOD-Messaging-Rx-Device-ResetResponse 'WiMOD.Messaging.Rx.Device.ResetResponse')
  - [#ctor(payload)](#M-WiMOD-Messaging-Rx-Device-ResetResponse-#ctor-System-Collections-Generic-IList{System-Byte}- 'WiMOD.Messaging.Rx.Device.ResetResponse.#ctor(System.Collections.Generic.IList{System.Byte})')
  - [Status](#P-WiMOD-Messaging-Rx-Device-ResetResponse-Status 'WiMOD.Messaging.Rx.Device.ResetResponse.Status')
  - [ToString()](#M-WiMOD-Messaging-Rx-Device-ResetResponse-ToString 'WiMOD.Messaging.Rx.Device.ResetResponse.ToString')
- [ResponseStatus](#T-WiMOD-Messaging-Rx-ResponseStatus 'WiMOD.Messaging.Rx.ResponseStatus')
  - [#ctor(statusByte)](#M-WiMOD-Messaging-Rx-ResponseStatus-#ctor-System-Byte- 'WiMOD.Messaging.Rx.ResponseStatus.#ctor(System.Byte)')
  - [Status](#P-WiMOD-Messaging-Rx-ResponseStatus-Status 'WiMOD.Messaging.Rx.ResponseStatus.Status')
  - [ToString()](#M-WiMOD-Messaging-Rx-ResponseStatus-ToString 'WiMOD.Messaging.Rx.ResponseStatus.ToString')
- [ResponseStatusIdentifier](#T-WiMOD-Messaging-Rx-ResponseStatusIdentifier 'WiMOD.Messaging.Rx.ResponseStatusIdentifier')
  - [ChannelBlockedByDutyCycle](#F-WiMOD-Messaging-Rx-ResponseStatusIdentifier-ChannelBlockedByDutyCycle 'WiMOD.Messaging.Rx.ResponseStatusIdentifier.ChannelBlockedByDutyCycle')
  - [CommandNotSupported](#F-WiMOD-Messaging-Rx-ResponseStatusIdentifier-CommandNotSupported 'WiMOD.Messaging.Rx.ResponseStatusIdentifier.CommandNotSupported')
  - [DeviceBusyCommandRejected](#F-WiMOD-Messaging-Rx-ResponseStatusIdentifier-DeviceBusyCommandRejected 'WiMOD.Messaging.Rx.ResponseStatusIdentifier.DeviceBusyCommandRejected')
  - [DeviceNotActivated](#F-WiMOD-Messaging-Rx-ResponseStatusIdentifier-DeviceNotActivated 'WiMOD.Messaging.Rx.ResponseStatusIdentifier.DeviceNotActivated')
  - [Error](#F-WiMOD-Messaging-Rx-ResponseStatusIdentifier-Error 'WiMOD.Messaging.Rx.ResponseStatusIdentifier.Error')
  - [FactorySettingsEepromBlockMissing](#F-WiMOD-Messaging-Rx-ResponseStatusIdentifier-FactorySettingsEepromBlockMissing 'WiMOD.Messaging.Rx.ResponseStatusIdentifier.FactorySettingsEepromBlockMissing')
  - [HciMessageLengthIsInvalidOrRadioPayloadSizeTooLarge](#F-WiMOD-Messaging-Rx-ResponseStatusIdentifier-HciMessageLengthIsInvalidOrRadioPayloadSizeTooLarge 'WiMOD.Messaging.Rx.ResponseStatusIdentifier.HciMessageLengthIsInvalidOrRadioPayloadSizeTooLarge')
  - [MessageQueueFullCommandRejected](#F-WiMOD-Messaging-Rx-ResponseStatusIdentifier-MessageQueueFullCommandRejected 'WiMOD.Messaging.Rx.ResponseStatusIdentifier.MessageQueueFullCommandRejected')
  - [NoChannelAvailable](#F-WiMOD-Messaging-Rx-ResponseStatusIdentifier-NoChannelAvailable 'WiMOD.Messaging.Rx.ResponseStatusIdentifier.NoChannelAvailable')
  - [Ok](#F-WiMOD-Messaging-Rx-ResponseStatusIdentifier-Ok 'WiMOD.Messaging.Rx.ResponseStatusIdentifier.Ok')
  - [StackRunningInWrongMode](#F-WiMOD-Messaging-Rx-ResponseStatusIdentifier-StackRunningInWrongMode 'WiMOD.Messaging.Rx.ResponseStatusIdentifier.StackRunningInWrongMode')
  - [WrongParameter](#F-WiMOD-Messaging-Rx-ResponseStatusIdentifier-WrongParameter 'WiMOD.Messaging.Rx.ResponseStatusIdentifier.WrongParameter')
- [RxHciMessage](#T-WiMOD-Messaging-Rx-RxHciMessage 'WiMOD.Messaging.Rx.RxHciMessage')
  - [#ctor(endpointIdentifier,payload)](#M-WiMOD-Messaging-Rx-RxHciMessage-#ctor-WiMOD-Messaging-EndpointIdentifier,System-Collections-Generic-IList{System-Byte}- 'WiMOD.Messaging.Rx.RxHciMessage.#ctor(WiMOD.Messaging.EndpointIdentifier,System.Collections.Generic.IList{System.Byte})')
  - [EndpointIdentifier](#P-WiMOD-Messaging-Rx-RxHciMessage-EndpointIdentifier 'WiMOD.Messaging.Rx.RxHciMessage.EndpointIdentifier')
  - [MessageIdentifier](#P-WiMOD-Messaging-Rx-RxHciMessage-MessageIdentifier 'WiMOD.Messaging.Rx.RxHciMessage.MessageIdentifier')
  - [Payload](#P-WiMOD-Messaging-Rx-RxHciMessage-Payload 'WiMOD.Messaging.Rx.RxHciMessage.Payload')
- [SendReliableDataMessageResponse](#T-WiMOD-Messaging-Rx-LoRaWAN-SendReliableDataMessageResponse 'WiMOD.Messaging.Rx.LoRaWAN.SendReliableDataMessageResponse')
  - [#ctor(payload)](#M-WiMOD-Messaging-Rx-LoRaWAN-SendReliableDataMessageResponse-#ctor-System-Collections-Generic-IList{System-Byte}- 'WiMOD.Messaging.Rx.LoRaWAN.SendReliableDataMessageResponse.#ctor(System.Collections.Generic.IList{System.Byte})')
  - [BlockedByDutyCycle](#P-WiMOD-Messaging-Rx-LoRaWAN-SendReliableDataMessageResponse-BlockedByDutyCycle 'WiMOD.Messaging.Rx.LoRaWAN.SendReliableDataMessageResponse.BlockedByDutyCycle')
  - [Status](#P-WiMOD-Messaging-Rx-LoRaWAN-SendReliableDataMessageResponse-Status 'WiMOD.Messaging.Rx.LoRaWAN.SendReliableDataMessageResponse.Status')
  - [TimeUntilChannelAvailableMillis](#P-WiMOD-Messaging-Rx-LoRaWAN-SendReliableDataMessageResponse-TimeUntilChannelAvailableMillis 'WiMOD.Messaging.Rx.LoRaWAN.SendReliableDataMessageResponse.TimeUntilChannelAvailableMillis')
  - [ToString()](#M-WiMOD-Messaging-Rx-LoRaWAN-SendReliableDataMessageResponse-ToString 'WiMOD.Messaging.Rx.LoRaWAN.SendReliableDataMessageResponse.ToString')
- [SendUnreliableDataMessageResponse](#T-WiMOD-Messaging-Rx-LoRaWAN-SendUnreliableDataMessageResponse 'WiMOD.Messaging.Rx.LoRaWAN.SendUnreliableDataMessageResponse')
  - [#ctor(payload)](#M-WiMOD-Messaging-Rx-LoRaWAN-SendUnreliableDataMessageResponse-#ctor-System-Collections-Generic-IList{System-Byte}- 'WiMOD.Messaging.Rx.LoRaWAN.SendUnreliableDataMessageResponse.#ctor(System.Collections.Generic.IList{System.Byte})')
  - [BlockedByDutyCycle](#P-WiMOD-Messaging-Rx-LoRaWAN-SendUnreliableDataMessageResponse-BlockedByDutyCycle 'WiMOD.Messaging.Rx.LoRaWAN.SendUnreliableDataMessageResponse.BlockedByDutyCycle')
  - [Status](#P-WiMOD-Messaging-Rx-LoRaWAN-SendUnreliableDataMessageResponse-Status 'WiMOD.Messaging.Rx.LoRaWAN.SendUnreliableDataMessageResponse.Status')
  - [TimeUntilChannelAvailableMillis](#P-WiMOD-Messaging-Rx-LoRaWAN-SendUnreliableDataMessageResponse-TimeUntilChannelAvailableMillis 'WiMOD.Messaging.Rx.LoRaWAN.SendUnreliableDataMessageResponse.TimeUntilChannelAvailableMillis')
  - [ToString()](#M-WiMOD-Messaging-Rx-LoRaWAN-SendUnreliableDataMessageResponse-ToString 'WiMOD.Messaging.Rx.LoRaWAN.SendUnreliableDataMessageResponse.ToString')
- [SetJoinParametersRequest](#T-WiMOD-Messaging-Tx-LoRa-Activation-SetJoinParametersRequest 'WiMOD.Messaging.Tx.LoRa.Activation.SetJoinParametersRequest')
  - [#ctor(applicationEui,applicationKey)](#M-WiMOD-Messaging-Tx-LoRa-Activation-SetJoinParametersRequest-#ctor-System-String,System-String- 'WiMOD.Messaging.Tx.LoRa.Activation.SetJoinParametersRequest.#ctor(System.String,System.String)')
  - [#ctor(applicationEui,applicationKey)](#M-WiMOD-Messaging-Tx-LoRa-Activation-SetJoinParametersRequest-#ctor-System-Collections-Generic-IList{System-Byte},System-Collections-Generic-IList{System-Byte}- 'WiMOD.Messaging.Tx.LoRa.Activation.SetJoinParametersRequest.#ctor(System.Collections.Generic.IList{System.Byte},System.Collections.Generic.IList{System.Byte})')
- [SetJoinParametersResponse](#T-WiMOD-Messaging-Rx-Activation-SetJoinParametersResponse 'WiMOD.Messaging.Rx.Activation.SetJoinParametersResponse')
  - [#ctor(payload)](#M-WiMOD-Messaging-Rx-Activation-SetJoinParametersResponse-#ctor-System-Collections-Generic-IList{System-Byte}- 'WiMOD.Messaging.Rx.Activation.SetJoinParametersResponse.#ctor(System.Collections.Generic.IList{System.Byte})')
  - [Status](#P-WiMOD-Messaging-Rx-Activation-SetJoinParametersResponse-Status 'WiMOD.Messaging.Rx.Activation.SetJoinParametersResponse.Status')
  - [ToString()](#M-WiMOD-Messaging-Rx-Activation-SetJoinParametersResponse-ToString 'WiMOD.Messaging.Rx.Activation.SetJoinParametersResponse.ToString')
- [TxHciMessage](#T-WiMOD-Messaging-Tx-TxHciMessage 'WiMOD.Messaging.Tx.TxHciMessage')
  - [#ctor(identifier,payload)](#M-WiMOD-Messaging-Tx-TxHciMessage-#ctor-WiMOD-Messaging-EndpointIdentifier,System-Collections-Generic-List{System-Byte}- 'WiMOD.Messaging.Tx.TxHciMessage.#ctor(WiMOD.Messaging.EndpointIdentifier,System.Collections.Generic.List{System.Byte})')
  - [EndpointIdentifier](#P-WiMOD-Messaging-Tx-TxHciMessage-EndpointIdentifier 'WiMOD.Messaging.Tx.TxHciMessage.EndpointIdentifier')
  - [MessageIdentifier](#P-WiMOD-Messaging-Tx-TxHciMessage-MessageIdentifier 'WiMOD.Messaging.Tx.TxHciMessage.MessageIdentifier')
  - [Payload](#P-WiMOD-Messaging-Tx-TxHciMessage-Payload 'WiMOD.Messaging.Tx.TxHciMessage.Payload')
- [UnreliableDataIndication](#T-WiMOD-Messaging-Rx-LoRaWAN-UnreliableDataIndication 'WiMOD.Messaging.Rx.LoRaWAN.UnreliableDataIndication')
  - [#ctor(payload)](#M-WiMOD-Messaging-Rx-LoRaWAN-UnreliableDataIndication-#ctor-System-Collections-Generic-IList{System-Byte}- 'WiMOD.Messaging.Rx.LoRaWAN.UnreliableDataIndication.#ctor(System.Collections.Generic.IList{System.Byte})')
  - [IsAcknowledgement](#P-WiMOD-Messaging-Rx-LoRaWAN-UnreliableDataIndication-IsAcknowledgement 'WiMOD.Messaging.Rx.LoRaWAN.UnreliableDataIndication.IsAcknowledgement')
- [UnreliableDataMessage](#T-WiMOD-Messaging-Tx-LoRa-Data-UnreliableDataMessage 'WiMOD.Messaging.Tx.LoRa.Data.UnreliableDataMessage')
  - [#ctor(port,payload)](#M-WiMOD-Messaging-Tx-LoRa-Data-UnreliableDataMessage-#ctor-System-Byte,System-Collections-Generic-List{System-Byte}- 'WiMOD.Messaging.Tx.LoRa.Data.UnreliableDataMessage.#ctor(System.Byte,System.Collections.Generic.List{System.Byte})')
- [UnreliableDataTransmitIndication](#T-WiMOD-Messaging-Rx-LoRaWAN-UnreliableDataTransmitIndication 'WiMOD.Messaging.Rx.LoRaWAN.UnreliableDataTransmitIndication')
  - [#ctor(payload)](#M-WiMOD-Messaging-Rx-LoRaWAN-UnreliableDataTransmitIndication-#ctor-System-Collections-Generic-IList{System-Byte}- 'WiMOD.Messaging.Rx.LoRaWAN.UnreliableDataTransmitIndication.#ctor(System.Collections.Generic.IList{System.Byte})')
  - [ChannelIndex](#P-WiMOD-Messaging-Rx-LoRaWAN-UnreliableDataTransmitIndication-ChannelIndex 'WiMOD.Messaging.Rx.LoRaWAN.UnreliableDataTransmitIndication.ChannelIndex')
  - [DataRate](#P-WiMOD-Messaging-Rx-LoRaWAN-UnreliableDataTransmitIndication-DataRate 'WiMOD.Messaging.Rx.LoRaWAN.UnreliableDataTransmitIndication.DataRate')
  - [MaximumNumberOfRetransmissionsReached](#P-WiMOD-Messaging-Rx-LoRaWAN-UnreliableDataTransmitIndication-MaximumNumberOfRetransmissionsReached 'WiMOD.Messaging.Rx.LoRaWAN.UnreliableDataTransmitIndication.MaximumNumberOfRetransmissionsReached')
  - [MaximumPayloadSizeExceededForCurrentDataRate](#P-WiMOD-Messaging-Rx-LoRaWAN-UnreliableDataTransmitIndication-MaximumPayloadSizeExceededForCurrentDataRate 'WiMOD.Messaging.Rx.LoRaWAN.UnreliableDataTransmitIndication.MaximumPayloadSizeExceededForCurrentDataRate')
  - [MessageAirTimeMillis](#P-WiMOD-Messaging-Rx-LoRaWAN-UnreliableDataTransmitIndication-MessageAirTimeMillis 'WiMOD.Messaging.Rx.LoRaWAN.UnreliableDataTransmitIndication.MessageAirTimeMillis')
  - [RadioPacketSent](#P-WiMOD-Messaging-Rx-LoRaWAN-UnreliableDataTransmitIndication-RadioPacketSent 'WiMOD.Messaging.Rx.LoRaWAN.UnreliableDataTransmitIndication.RadioPacketSent')
  - [TransmitPowerLevel](#P-WiMOD-Messaging-Rx-LoRaWAN-UnreliableDataTransmitIndication-TransmitPowerLevel 'WiMOD.Messaging.Rx.LoRaWAN.UnreliableDataTransmitIndication.TransmitPowerLevel')
  - [TransmittedRadioPackets](#P-WiMOD-Messaging-Rx-LoRaWAN-UnreliableDataTransmitIndication-TransmittedRadioPackets 'WiMOD.Messaging.Rx.LoRaWAN.UnreliableDataTransmitIndication.TransmittedRadioPackets')
  - [ToString()](#M-WiMOD-Messaging-Rx-LoRaWAN-UnreliableDataTransmitIndication-ToString 'WiMOD.Messaging.Rx.LoRaWAN.UnreliableDataTransmitIndication.ToString')
- [WiModModem](#T-WiMOD-WiModModem 'WiMOD.WiModModem')
  - [#ctor(options,loggerFactory,portfinder)](#M-WiMOD-WiModModem-#ctor-Microsoft-Extensions-Options-IOptions{WiMOD-DependencyInjection-WiModOptions},Microsoft-Extensions-Logging-ILoggerFactory,WiMOD-Helpers-PortFinder- 'WiMOD.WiModModem.#ctor(Microsoft.Extensions.Options.IOptions{WiMOD.DependencyInjection.WiModOptions},Microsoft.Extensions.Logging.ILoggerFactory,WiMOD.Helpers.PortFinder)')
  - [SetReceiver(onData)](#M-WiMOD-WiModModem-SetReceiver-System-Func{WiMOD-Messaging-Rx-RxHciMessage,System-Threading-Tasks-Task}- 'WiMOD.WiModModem.SetReceiver(System.Func{WiMOD.Messaging.Rx.RxHciMessage,System.Threading.Tasks.Task})')
  - [TransmitMessage(message)](#M-WiMOD-WiModModem-TransmitMessage-WiMOD-Messaging-Tx-TxHciMessage- 'WiMOD.WiModModem.TransmitMessage(WiMOD.Messaging.Tx.TxHciMessage)')
- [WiModModuleType](#T-WiMOD-Messaging-Rx-Device-WiModModuleType 'WiMOD.Messaging.Rx.Device.WiModModuleType')
- [WiModOptions](#T-WiMOD-DependencyInjection-WiModOptions 'WiMOD.DependencyInjection.WiModOptions')
  - [BaudRate](#P-WiMOD-DependencyInjection-WiModOptions-BaudRate 'WiMOD.DependencyInjection.WiModOptions.BaudRate')
  - [Name](#P-WiMOD-DependencyInjection-WiModOptions-Name 'WiMOD.DependencyInjection.WiModOptions.Name')
  - [UsePortFinder](#P-WiMOD-DependencyInjection-WiModOptions-UsePortFinder 'WiMOD.DependencyInjection.WiModOptions.UsePortFinder')
- [WiModServiceCollectionExtensions](#T-WiMOD-DependencyInjection-WiModServiceCollectionExtensions 'WiMOD.DependencyInjection.WiModServiceCollectionExtensions')
  - [AddWiModModem(services,setupAction)](#M-WiMOD-DependencyInjection-WiModServiceCollectionExtensions-AddWiModModem-Microsoft-Extensions-DependencyInjection-IServiceCollection,System-Action{WiMOD-DependencyInjection-WiModOptions}- 'WiMOD.DependencyInjection.WiModServiceCollectionExtensions.AddWiModModem(Microsoft.Extensions.DependencyInjection.IServiceCollection,System.Action{WiMOD.DependencyInjection.WiModOptions})')

<a name='T-WiMOD-Messaging-Tx-LoRa-Activation-ActivationByPersonalisationRequest'></a>
## ActivationByPersonalisationRequest `type`

##### Namespace

WiMOD.Messaging.Tx.LoRa.Activation

##### Summary

This requesr can be used to activate the device. The passed parameters will be stored in a non-volatile memory.

<a name='M-WiMOD-Messaging-Tx-LoRa-Activation-ActivationByPersonalisationRequest-#ctor-System-String,System-String,System-String-'></a>
### #ctor(deviceAddress,networkSessionKey,applicationSessionKey) `constructor`

##### Summary

Initializes a new instance of the [ActivationByPersonalisationRequest](#T-WiMOD-Messaging-Tx-LoRa-Activation-ActivationByPersonalisationRequest 'WiMOD.Messaging.Tx.LoRa.Activation.ActivationByPersonalisationRequest') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| deviceAddress | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A unique 32-Bit device-address, used for radio communication within a network formatted as a Hex-string. |
| networkSessionKey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A device-specific 128-Bit network session key used for MIC calculation and verification formatted as a Hex-string. |
| applicationSessionKey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A device-specific 128-Bit application session key used to encrypt and decrypt the payload field of application specific messages formatted as a Hex-string. |

<a name='M-WiMOD-Messaging-Tx-LoRa-Activation-ActivationByPersonalisationRequest-#ctor-System-Collections-Generic-IList{System-Byte},System-Collections-Generic-IList{System-Byte},System-Collections-Generic-IList{System-Byte}-'></a>
### #ctor(deviceAddress,networkSessionKey,applicationSessionKey) `constructor`

##### Summary

Initializes a new instance of the [ActivationByPersonalisationRequest](#T-WiMOD-Messaging-Tx-LoRa-Activation-ActivationByPersonalisationRequest 'WiMOD.Messaging.Tx.LoRa.Activation.ActivationByPersonalisationRequest') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| deviceAddress | [System.Collections.Generic.IList{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.Byte}') | A unique 32-Bit device-address, used for radio communication within a network. |
| networkSessionKey | [System.Collections.Generic.IList{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.Byte}') | A device-specific 128-Bit network session key used for MIC calculation and verification. |
| applicationSessionKey | [System.Collections.Generic.IList{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.Byte}') | A device-specific 128-Bit application session key used to encrypt and decrypt the payload field of application specific messages. |

<a name='T-WiMOD-Messaging-Rx-Activation-ActivationByPersonalisationResponse'></a>
## ActivationByPersonalisationResponse `type`

##### Namespace

WiMOD.Messaging.Rx.Activation

##### Summary

Response for ABP Request.

<a name='M-WiMOD-Messaging-Rx-Activation-ActivationByPersonalisationResponse-#ctor-System-Collections-Generic-IList{System-Byte}-'></a>
### #ctor(payload) `constructor`

##### Summary

Initializes a new instance of the [ActivationByPersonalisationResponse](#T-WiMOD-Messaging-Rx-Activation-ActivationByPersonalisationResponse 'WiMOD.Messaging.Rx.Activation.ActivationByPersonalisationResponse') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payload | [System.Collections.Generic.IList{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.Byte}') | the payload. |

<a name='P-WiMOD-Messaging-Rx-Activation-ActivationByPersonalisationResponse-Status'></a>
### Status `property`

##### Summary

Gets the status of the response.

<a name='M-WiMOD-Messaging-Rx-Activation-ActivationByPersonalisationResponse-ToString'></a>
### ToString() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-WiMOD-Helpers-Extensions-BitwiseExtensions'></a>
## BitwiseExtensions `type`

##### Namespace

WiMOD.Helpers.Extensions

##### Summary

Extension methods for bitwise manipulation and general help.

<a name='F-WiMOD-Helpers-Extensions-BitwiseExtensions-CRC16Table'></a>
### CRC16Table `constants`

##### Summary

CRC CCITTT Table.

<a name='M-WiMOD-Helpers-Extensions-BitwiseExtensions-AppendCrc-System-Collections-Generic-IList{System-Byte}-'></a>
### AppendCrc(bytes) `method`

##### Summary

Appends a CRC16 to the end of the `bytes`.

##### Returns

`bytes`, but with CRC16 appended.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bytes | [System.Collections.Generic.IList{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.Byte}') | the bytes to append to. |

<a name='M-WiMOD-Helpers-Extensions-BitwiseExtensions-CalculateCrc-System-Collections-Generic-IList{System-Byte}-'></a>
### CalculateCrc(bytes) `method`

##### Summary

Calculates the CRC16 CCITTT.

##### Returns

CRC16 CCITTT.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bytes | [System.Collections.Generic.IList{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.Byte}') | the bytes. |

<a name='M-WiMOD-Helpers-Extensions-BitwiseExtensions-EncodeSlipFrame-System-Collections-Generic-IList{System-Byte},System-Boolean-'></a>
### EncodeSlipFrame(bytes,appendCrc) `method`

##### Summary

Encodes as SLIP.

##### Returns

the `bytes`, but SLIP encoded.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bytes | [System.Collections.Generic.IList{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.Byte}') | the bytes to be encoded. |
| appendCrc | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | optional boolean indicating if CRC16 should be appended, before encoding SLIP. |

<a name='M-WiMOD-Helpers-Extensions-BitwiseExtensions-GetBit-System-Byte,System-Int32-'></a>
### GetBit(b,position) `method`

##### Summary

Gets the bit at the `position`.

##### Returns

A boolean indicating if it was 1 or 0.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| b | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') | the byte. |
| position | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | the bit at the given position to extract. |

<a name='M-WiMOD-Helpers-Extensions-BitwiseExtensions-HexStringToBytes-System-String-'></a>
### HexStringToBytes(hexString) `method`

##### Summary

Transforms a hex-formatted string to a byte array.

##### Returns

a byte array of the hex-strings binary value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| hexString | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | the string. |

<a name='M-WiMOD-Helpers-Extensions-BitwiseExtensions-HighNibble-System-Byte-'></a>
### HighNibble(b) `method`

##### Summary

Gets the high nibble of the passed `b`.

##### Returns

the high nibble.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| b | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') | the byte. |

<a name='M-WiMOD-Helpers-Extensions-BitwiseExtensions-LowNibble-System-Byte-'></a>
### LowNibble(b) `method`

##### Summary

Gets the low nibble of the passed `b`.

##### Returns

the low nibble.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| b | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') | the byte. |

<a name='M-WiMOD-Helpers-Extensions-BitwiseExtensions-Mask-System-Byte,System-Byte-'></a>
### Mask(b,mask) `method`

##### Summary

Applies a bitmask.

##### Returns

the masked value of the byte.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| b | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') | the byte to mask. |
| mask | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') | the mask to apply. |

<a name='M-WiMOD-Helpers-Extensions-BitwiseExtensions-SetBit-System-Byte,System-Int32-'></a>
### SetBit(b,position) `method`

##### Summary

Sets the bit at the `position`.

##### Returns

the same byte, but different.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| b | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') | the byte to manipulate. |
| position | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | the postion. |

<a name='M-WiMOD-Helpers-Extensions-BitwiseExtensions-StripSlipFrame-System-Collections-Generic-IList{System-Byte},System-Boolean-'></a>
### StripSlipFrame(bytes,validateCrc) `method`

##### Summary

Decodes and strips SLIP.

##### Returns

the decoded frame.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bytes | [System.Collections.Generic.IList{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.Byte}') | the bytes to be decoded and stripped. |
| validateCrc | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | optional boolean indicating if CRC16 should be validated. |

<a name='M-WiMOD-Helpers-Extensions-BitwiseExtensions-ToHexString-System-Collections-Generic-IList{System-Byte}-'></a>
### ToHexString(bytes) `method`

##### Summary

Parses the passed `bytes` into a hex-formatted string.

##### Returns

A hex formatted string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bytes | [System.Collections.Generic.IList{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.Byte}') | The bytes to be parsed. |

<a name='M-WiMOD-Helpers-Extensions-BitwiseExtensions-ValidateCrc-System-Collections-Generic-IList{System-Byte}-'></a>
### ValidateCrc(bytes) `method`

##### Summary

Validates CRC16.

##### Returns

A boolean indicating if the CRC is valid.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bytes | [System.Collections.Generic.IList{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.Byte}') | bytes to validate. |

<a name='T-WiMOD-Messaging-Tx-LoRa-Configuration-ConfigureRadioStackRequest'></a>
## ConfigureRadioStackRequest `type`

##### Namespace

WiMOD.Messaging.Tx.LoRa.Configuration

##### Summary

This request can be used to configure the integrated radio stack.

<a name='M-WiMOD-Messaging-Tx-LoRa-Configuration-ConfigureRadioStackRequest-#ctor-WiMOD-Messaging-Tx-LoRa-Configuration-DataRateIndex,System-Boolean,System-Boolean,System-Boolean,System-Boolean,System-Boolean,System-Boolean,System-Byte,System-Byte-'></a>
### #ctor(dataRateIndex,adaptiveDataRateEnabled,dutyCycleControlEnabled,isClassC,extendedOutputFormatEnabled,rxMacForwardingEnabled,powerSavingEnabled,retryAttemps,headerMacCmdCapacity) `constructor`

##### Summary

Initializes a new instance of the [ConfigureRadioStackRequest](#T-WiMOD-Messaging-Tx-LoRa-Configuration-ConfigureRadioStackRequest 'WiMOD.Messaging.Tx.LoRa.Configuration.ConfigureRadioStackRequest') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dataRateIndex | [WiMOD.Messaging.Tx.LoRa.Configuration.DataRateIndex](#T-WiMOD-Messaging-Tx-LoRa-Configuration-DataRateIndex 'WiMOD.Messaging.Tx.LoRa.Configuration.DataRateIndex') | Default Data Rate Index. |
| adaptiveDataRateEnabled | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Adaptive Data Rate enabled/disabled. |
| dutyCycleControlEnabled | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Duty Cycle Control enabled/disabled. (Customer Mode Required). |
| isClassC | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Class indicator. Class A if false, Class C device if true. |
| extendedOutputFormatEnabled | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Extended RF packet output format: Tx/Rx channel info attached if true. |
| rxMacForwardingEnabled | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Rx MAC Command Forwarding enabled/disabled. |
| powerSavingEnabled | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Power Saving. Off is false, automatic if true. |
| retryAttemps | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') | Maximum number of retries for a reliable radio packet (parameter range: 0 to 254). |
| headerMacCmdCapacity | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') | Maximum length of the MAC commands to be piggybacked in the header (parameter range: 0 to 15). |

<a name='T-WiMOD-Messaging-Rx-LoRa-Configuration-ConfigureRadioStackResponse'></a>
## ConfigureRadioStackResponse `type`

##### Namespace

WiMOD.Messaging.Rx.LoRa.Configuration

##### Summary

Response to a ConfigureRadioStack Request.

<a name='M-WiMOD-Messaging-Rx-LoRa-Configuration-ConfigureRadioStackResponse-#ctor-System-Collections-Generic-IList{System-Byte}-'></a>
### #ctor(payload) `constructor`

##### Summary

Initializes a new instance of the [ConfigureRadioStackResponse](#T-WiMOD-Messaging-Rx-LoRa-Configuration-ConfigureRadioStackResponse 'WiMOD.Messaging.Rx.LoRa.Configuration.ConfigureRadioStackResponse') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payload | [System.Collections.Generic.IList{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.Byte}') | The payload. |

<a name='P-WiMOD-Messaging-Rx-LoRa-Configuration-ConfigureRadioStackResponse-Status'></a>
### Status `property`

##### Summary

Gets the status relayed in this message.

<a name='M-WiMOD-Messaging-Rx-LoRa-Configuration-ConfigureRadioStackResponse-ToString'></a>
### ToString() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-WiMOD-Messaging-Tx-LoRa-Configuration-DataRateIndex'></a>
## DataRateIndex `type`

##### Namespace

WiMOD.Messaging.Tx.LoRa.Configuration

##### Summary

Data Rate Index.

<a name='F-WiMOD-Messaging-Tx-LoRa-Configuration-DataRateIndex-SpreadingFactor10'></a>
### SpreadingFactor10 `constants`

##### Summary

LoRa / SF10. Bandwith kHz: 125. Indicative physical bit rate: 890. Maximum payload size: 51.

<a name='F-WiMOD-Messaging-Tx-LoRa-Configuration-DataRateIndex-SpreadingFactor11'></a>
### SpreadingFactor11 `constants`

##### Summary

LoRa / SF11. Bandwith kHz: 125. Indicative physical bit rate: 440. Maximum payload size: 51.

<a name='F-WiMOD-Messaging-Tx-LoRa-Configuration-DataRateIndex-SpreadingFactor12'></a>
### SpreadingFactor12 `constants`

##### Summary

LoRa / SF12. Bandwith kHz: 125. Indicative physical bit rate: 250. Maximum payload size: 51.

<a name='F-WiMOD-Messaging-Tx-LoRa-Configuration-DataRateIndex-SpreadingFactor7'></a>
### SpreadingFactor7 `constants`

##### Summary

LoRa / SF12. Bandwith kHz: 125. Indicative physical bit rate: 5470. Maximum payload size: 242.

<a name='F-WiMOD-Messaging-Tx-LoRa-Configuration-DataRateIndex-SpreadingFactor8'></a>
### SpreadingFactor8 `constants`

##### Summary

LoRa / SF8. Bandwith kHz: 125. Indicative physical bit rate: 3125. Maximum payload size: 242.

<a name='F-WiMOD-Messaging-Tx-LoRa-Configuration-DataRateIndex-SpreadingFactor9'></a>
### SpreadingFactor9 `constants`

##### Summary

LoRa / SF9. Bandwith kHz: 125. Indicative physical bit rate: 1760. Maximum payload size: 115.

<a name='T-WiMOD-Messaging-Tx-Device-DeviceInformationRequest'></a>
## DeviceInformationRequest `type`

##### Namespace

WiMOD.Messaging.Tx.Device

##### Summary

This message can be used to identify the local connected device. As a result the device sends a response message which contains a Device Information Field.

<a name='M-WiMOD-Messaging-Tx-Device-DeviceInformationRequest-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [DeviceInformationRequest](#T-WiMOD-Messaging-Tx-Device-DeviceInformationRequest 'WiMOD.Messaging.Tx.Device.DeviceInformationRequest') class.

##### Parameters

This constructor has no parameters.

<a name='T-WiMOD-Messaging-Rx-Device-DeviceInformationResponse'></a>
## DeviceInformationResponse `type`

##### Namespace

WiMOD.Messaging.Rx.Device

##### Summary

Response to a Device Information Request.

<a name='M-WiMOD-Messaging-Rx-Device-DeviceInformationResponse-#ctor-System-Collections-Generic-IList{System-Byte}-'></a>
### #ctor(payload) `constructor`

##### Summary

Initializes a new instance of the [DeviceInformationResponse](#T-WiMOD-Messaging-Rx-Device-DeviceInformationResponse 'WiMOD.Messaging.Rx.Device.DeviceInformationResponse') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payload | [System.Collections.Generic.IList{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.Byte}') | the payload. |

<a name='P-WiMOD-Messaging-Rx-Device-DeviceInformationResponse-DeviceAddress'></a>
### DeviceAddress `property`

##### Summary

Gets the device address of the device.

<a name='P-WiMOD-Messaging-Rx-Device-DeviceInformationResponse-DeviceId'></a>
### DeviceId `property`

##### Summary

Gets the devices ID.

<a name='P-WiMOD-Messaging-Rx-Device-DeviceInformationResponse-ModuleType'></a>
### ModuleType `property`

##### Summary

Gets the Module Type of the device.

<a name='P-WiMOD-Messaging-Rx-Device-DeviceInformationResponse-Status'></a>
### Status `property`

##### Summary

Gets the Status of the response.

<a name='M-WiMOD-Messaging-Rx-Device-DeviceInformationResponse-ToString'></a>
### ToString() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-WiMOD-Messaging-DeviceManagementMessageIdentifier'></a>
## DeviceManagementMessageIdentifier `type`

##### Namespace

WiMOD.Messaging

##### Summary

Message idenfiers for device management messages.

<a name='F-WiMOD-Messaging-DeviceManagementMessageIdentifier-DeviceInfoRequest'></a>
### DeviceInfoRequest `constants`

##### Summary

Device information request

<a name='F-WiMOD-Messaging-DeviceManagementMessageIdentifier-DeviceInfoResponse'></a>
### DeviceInfoResponse `constants`

##### Summary

Device information response.

<a name='F-WiMOD-Messaging-DeviceManagementMessageIdentifier-FirmwareVersionRequest'></a>
### FirmwareVersionRequest `constants`

##### Summary

Firmware version request.

<a name='F-WiMOD-Messaging-DeviceManagementMessageIdentifier-FirmwareVersionResponse'></a>
### FirmwareVersionResponse `constants`

##### Summary

Firmware version response

<a name='F-WiMOD-Messaging-DeviceManagementMessageIdentifier-PingRequest'></a>
### PingRequest `constants`

##### Summary

Ping request

<a name='F-WiMOD-Messaging-DeviceManagementMessageIdentifier-PingResponse'></a>
### PingResponse `constants`

##### Summary

Ping response

<a name='F-WiMOD-Messaging-DeviceManagementMessageIdentifier-ResetReqest'></a>
### ResetReqest `constants`

##### Summary

Reset Request

<a name='F-WiMOD-Messaging-DeviceManagementMessageIdentifier-ResetResponse'></a>
### ResetResponse `constants`

##### Summary

Reset Response

<a name='F-WiMOD-Messaging-DeviceManagementMessageIdentifier-SystemOperationModeRequest'></a>
### SystemOperationModeRequest `constants`

##### Summary

Operation mode request.

<a name='F-WiMOD-Messaging-DeviceManagementMessageIdentifier-SystemOperationModeResponse'></a>
### SystemOperationModeResponse `constants`

##### Summary

Operation mode response.

<a name='T-WiMOD-Messaging-Rx-DeviceRxHciMessage'></a>
## DeviceRxHciMessage `type`

##### Namespace

WiMOD.Messaging.Rx

##### Summary

A message received from the Device SAP.

<a name='M-WiMOD-Messaging-Rx-DeviceRxHciMessage-#ctor-WiMOD-Messaging-DeviceManagementMessageIdentifier,System-Collections-Generic-IList{System-Byte}-'></a>
### #ctor(identifier,payload) `constructor`

##### Summary

Initializes a new instance of the [DeviceRxHciMessage](#T-WiMOD-Messaging-Rx-DeviceRxHciMessage 'WiMOD.Messaging.Rx.DeviceRxHciMessage') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| identifier | [WiMOD.Messaging.DeviceManagementMessageIdentifier](#T-WiMOD-Messaging-DeviceManagementMessageIdentifier 'WiMOD.Messaging.DeviceManagementMessageIdentifier') | The identifier of this message. |
| payload | [System.Collections.Generic.IList{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.Byte}') | the payload. |

<a name='P-WiMOD-Messaging-Rx-DeviceRxHciMessage-MessageIdentifier'></a>
### MessageIdentifier `property`

##### Summary

*Inherit from parent.*

<a name='T-WiMOD-Messaging-Tx-Device-DeviceTxMessage'></a>
## DeviceTxMessage `type`

##### Namespace

WiMOD.Messaging.Tx.Device

##### Summary

Message to be transmitted to the device management SAP.

<a name='M-WiMOD-Messaging-Tx-Device-DeviceTxMessage-#ctor-WiMOD-Messaging-DeviceManagementMessageIdentifier,System-Collections-Generic-List{System-Byte}-'></a>
### #ctor(messageIdentifier,payload) `constructor`

##### Summary

Initializes a new instance of the [DeviceTxMessage](#T-WiMOD-Messaging-Tx-Device-DeviceTxMessage 'WiMOD.Messaging.Tx.Device.DeviceTxMessage') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageIdentifier | [WiMOD.Messaging.DeviceManagementMessageIdentifier](#T-WiMOD-Messaging-DeviceManagementMessageIdentifier 'WiMOD.Messaging.DeviceManagementMessageIdentifier') | Message type identifier. |
| payload | [System.Collections.Generic.List{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.Byte}') | the payload. |

<a name='P-WiMOD-Messaging-Tx-Device-DeviceTxMessage-MessageIdentifier'></a>
### MessageIdentifier `property`

##### Summary

Gets the message identifier.

<a name='T-WiMOD-Messaging-EndpointIdentifier'></a>
## EndpointIdentifier `type`

##### Namespace

WiMOD.Messaging

##### Summary

Endpoint identifier values.

<a name='F-WiMOD-Messaging-EndpointIdentifier-DeviceManager'></a>
### DeviceManager `constants`

##### Summary

Device manager Identifier

<a name='F-WiMOD-Messaging-EndpointIdentifier-LoRaWANModem'></a>
### LoRaWANModem `constants`

##### Summary

LoRaWAN Modem

<a name='T-WiMOD-Helpers-Extensions-EnumExtensions'></a>
## EnumExtensions `type`

##### Namespace

WiMOD.Helpers.Extensions

##### Summary

Extensions for enum-types.

<a name='M-WiMOD-Helpers-Extensions-EnumExtensions-As``1-System-Byte-'></a>
### As\`\`1(value) `method`

##### Summary

Transforms a byte to an enum.

##### Returns

the byte 'cast' to the enum.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') | the byte. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | the enum type. |

<a name='M-WiMOD-Helpers-Extensions-EnumExtensions-ToFormattedString``1-``0-'></a>
### ToFormattedString\`\`1(value) `method`

##### Summary

Formats a string by insering space before uppercase letters.

##### Returns

a formatted string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') | the named integer of the enum. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type. Should be named integer. |

<a name='T-WiMOD-Messaging-HciMessage'></a>
## HciMessage `type`

##### Namespace

WiMOD.Messaging

##### Summary

Base class for HCI messages.

<a name='T-WiMOD-Messaging-Rx-Activation-JoinNetworkIndication'></a>
## JoinNetworkIndication `type`

##### Namespace

WiMOD.Messaging.Rx.Activation

##### Summary

This message is sent to the host either after successful reception of a server join response packet or after the expiration of a complete join process without success (the join request will be retransmitted changing the spreading factor from SF7 till SF12, reusing each spreading factor twice).

<a name='M-WiMOD-Messaging-Rx-Activation-JoinNetworkIndication-#ctor-System-Collections-Generic-IList{System-Byte}-'></a>
### #ctor(payload) `constructor`

##### Summary

Initializes a new instance of the [JoinNetworkIndication](#T-WiMOD-Messaging-Rx-Activation-JoinNetworkIndication 'WiMOD.Messaging.Rx.Activation.JoinNetworkIndication') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payload | [System.Collections.Generic.IList{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.Byte}') | the payload. |

<a name='P-WiMOD-Messaging-Rx-Activation-JoinNetworkIndication-ChannelIndex'></a>
### ChannelIndex `property`

##### Summary

Gets the channel index the transmission was sent on.

<a name='P-WiMOD-Messaging-Rx-Activation-JoinNetworkIndication-DataRate'></a>
### DataRate `property`

##### Summary

Gets the Data rate (spreading factor) the transmission was sent on.

<a name='P-WiMOD-Messaging-Rx-Activation-JoinNetworkIndication-DeviceActivated'></a>
### DeviceActivated `property`

##### Summary

Gets a value indicating whether the device was activated (true), or if an error occured (false).

<a name='P-WiMOD-Messaging-Rx-Activation-JoinNetworkIndication-DeviceAddress'></a>
### DeviceAddress `property`

##### Summary

Gets the device address.

<a name='P-WiMOD-Messaging-Rx-Activation-JoinNetworkIndication-RelativeSignalStrenghtIndicator'></a>
### RelativeSignalStrenghtIndicator `property`

##### Summary

Gets the RSSI value in dBm.

<a name='P-WiMOD-Messaging-Rx-Activation-JoinNetworkIndication-RxSlot'></a>
### RxSlot `property`

##### Summary

Gets the Rx Slot value.

<a name='P-WiMOD-Messaging-Rx-Activation-JoinNetworkIndication-SignalToNoiseRatio'></a>
### SignalToNoiseRatio `property`

##### Summary

Gets the SNR value in dB.

<a name='M-WiMOD-Messaging-Rx-Activation-JoinNetworkIndication-ToString'></a>
### ToString() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-WiMOD-Messaging-Rx-Activation-JoinNetworkPacketTransmitIndication'></a>
## JoinNetworkPacketTransmitIndication `type`

##### Namespace

WiMOD.Messaging.Rx.Activation

##### Summary

This HCI message is sent to the host after the join radio message has been sent to the server.

<a name='M-WiMOD-Messaging-Rx-Activation-JoinNetworkPacketTransmitIndication-#ctor-System-Collections-Generic-IList{System-Byte}-'></a>
### #ctor(payload) `constructor`

##### Summary

Initializes a new instance of the [JoinNetworkPacketTransmitIndication](#T-WiMOD-Messaging-Rx-Activation-JoinNetworkPacketTransmitIndication 'WiMOD.Messaging.Rx.Activation.JoinNetworkPacketTransmitIndication') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payload | [System.Collections.Generic.IList{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.Byte}') | the payload. |

<a name='P-WiMOD-Messaging-Rx-Activation-JoinNetworkPacketTransmitIndication-ChannelIndex'></a>
### ChannelIndex `property`

##### Summary

Gets the channel index the transmission was sent on.

<a name='P-WiMOD-Messaging-Rx-Activation-JoinNetworkPacketTransmitIndication-DataRate'></a>
### DataRate `property`

##### Summary

Gets the Data rate (spreading factor) the transmission was sent on.

<a name='P-WiMOD-Messaging-Rx-Activation-JoinNetworkPacketTransmitIndication-MessageAirTimeMillis'></a>
### MessageAirTimeMillis `property`

##### Summary

Gets the airrtime in milliseconds of transmitted radio message.

<a name='P-WiMOD-Messaging-Rx-Activation-JoinNetworkPacketTransmitIndication-RadioPacketSent'></a>
### RadioPacketSent `property`

##### Summary

Gets a value indicating whether the radio packet was sent (true), or if an error occured (false).

<a name='P-WiMOD-Messaging-Rx-Activation-JoinNetworkPacketTransmitIndication-TransmitPowerLevel'></a>
### TransmitPowerLevel `property`

##### Summary

Gets the transmit power level configured in transceiver in dBm (min. value 0 dBm).

##### Remarks

The minimum TRX power level depends on the radio module and it could slightly vary from the given power level value for the low power levels.

<a name='P-WiMOD-Messaging-Rx-Activation-JoinNetworkPacketTransmitIndication-TransmittedRadioPackets'></a>
### TransmittedRadioPackets `property`

##### Summary

Gets the number of transmitted radio packets of last request.

<a name='M-WiMOD-Messaging-Rx-Activation-JoinNetworkPacketTransmitIndication-ToString'></a>
### ToString() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-WiMOD-Messaging-LoRaWanMessageIdentifier'></a>
## LoRaWanMessageIdentifier `type`

##### Namespace

WiMOD.Messaging

##### Summary

Message identifiers for LoRaWAN Messages.

<a name='F-WiMOD-Messaging-LoRaWanMessageIdentifier-ActivateDeviceRequest'></a>
### ActivateDeviceRequest `constants`

##### Summary

Activate Device Request

<a name='F-WiMOD-Messaging-LoRaWanMessageIdentifier-ActivateDeviceResponse'></a>
### ActivateDeviceResponse `constants`

##### Summary

Activate Device Response

<a name='F-WiMOD-Messaging-LoRaWanMessageIdentifier-JoinNetworkIndication'></a>
### JoinNetworkIndication `constants`

##### Summary

Join Network Indication

<a name='F-WiMOD-Messaging-LoRaWanMessageIdentifier-JoinNetworkRequest'></a>
### JoinNetworkRequest `constants`

##### Summary

Join Network Request

<a name='F-WiMOD-Messaging-LoRaWanMessageIdentifier-JoinNetworkResponse'></a>
### JoinNetworkResponse `constants`

##### Summary

Join Network Response

<a name='F-WiMOD-Messaging-LoRaWanMessageIdentifier-JoinNetworkTxIndication'></a>
### JoinNetworkTxIndication `constants`

##### Summary

Join Network Transmission Indication

<a name='F-WiMOD-Messaging-LoRaWanMessageIdentifier-NetworkStatusRequest'></a>
### NetworkStatusRequest `constants`

##### Summary

Network Status Request

<a name='F-WiMOD-Messaging-LoRaWanMessageIdentifier-NetworkStatusResponse'></a>
### NetworkStatusResponse `constants`

##### Summary

Network Status Response

<a name='F-WiMOD-Messaging-LoRaWanMessageIdentifier-ReceiveAckIndication'></a>
### ReceiveAckIndication `constants`

##### Summary

Receive ACK Indication

<a name='F-WiMOD-Messaging-LoRaWanMessageIdentifier-ReceiveCDataIndication'></a>
### ReceiveCDataIndication `constants`

##### Summary

Reliable Data Indication

<a name='F-WiMOD-Messaging-LoRaWanMessageIdentifier-ReceiveNoDataIndication'></a>
### ReceiveNoDataIndication `constants`

##### Summary

Receive No-Data Indication

<a name='F-WiMOD-Messaging-LoRaWanMessageIdentifier-ReceiveUDataIndication'></a>
### ReceiveUDataIndication `constants`

##### Summary

Receive Unreliable Data Acknowledgement Indication

<a name='F-WiMOD-Messaging-LoRaWanMessageIdentifier-SendCDataRequest'></a>
### SendCDataRequest `constants`

##### Summary

Send Reliable Data Request

<a name='F-WiMOD-Messaging-LoRaWanMessageIdentifier-SendCDataResponse'></a>
### SendCDataResponse `constants`

##### Summary

Send Reliable Data Response

<a name='F-WiMOD-Messaging-LoRaWanMessageIdentifier-SendCDataTxIndication'></a>
### SendCDataTxIndication `constants`

##### Summary

Send Reliable Data Transmission Indication

<a name='F-WiMOD-Messaging-LoRaWanMessageIdentifier-SendUDataRequest'></a>
### SendUDataRequest `constants`

##### Summary

Send Unreliable Data Request

<a name='F-WiMOD-Messaging-LoRaWanMessageIdentifier-SendUDataResponse'></a>
### SendUDataResponse `constants`

##### Summary

Send Unreliable Data Response

<a name='F-WiMOD-Messaging-LoRaWanMessageIdentifier-SendUDataTxIndication'></a>
### SendUDataTxIndication `constants`

##### Summary

Send Unreliable Data Transmission Indication

<a name='F-WiMOD-Messaging-LoRaWanMessageIdentifier-SetJoinParameterRequest'></a>
### SetJoinParameterRequest `constants`

##### Summary

Set Join Parameters Request

<a name='F-WiMOD-Messaging-LoRaWanMessageIdentifier-SetJoinParameterResponse'></a>
### SetJoinParameterResponse `constants`

##### Summary

Set Join Parameters Response

<a name='F-WiMOD-Messaging-LoRaWanMessageIdentifier-SetRadioStackRequest'></a>
### SetRadioStackRequest `constants`

##### Summary

Set Radio Stack Request

<a name='F-WiMOD-Messaging-LoRaWanMessageIdentifier-SetRadioStackResponse'></a>
### SetRadioStackResponse `constants`

##### Summary

Set Radio Stack Response

<a name='T-WiMOD-Messaging-Rx-LoRaWanRxHciMessage'></a>
## LoRaWanRxHciMessage `type`

##### Namespace

WiMOD.Messaging.Rx

##### Summary

A message received from the LoRaWAN SAP.

<a name='M-WiMOD-Messaging-Rx-LoRaWanRxHciMessage-#ctor-WiMOD-Messaging-LoRaWanMessageIdentifier,System-Collections-Generic-IList{System-Byte}-'></a>
### #ctor(identifier,payload) `constructor`

##### Summary

Initializes a new instance of the [LoRaWanRxHciMessage](#T-WiMOD-Messaging-Rx-LoRaWanRxHciMessage 'WiMOD.Messaging.Rx.LoRaWanRxHciMessage') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| identifier | [WiMOD.Messaging.LoRaWanMessageIdentifier](#T-WiMOD-Messaging-LoRaWanMessageIdentifier 'WiMOD.Messaging.LoRaWanMessageIdentifier') | The identifier of this message. |
| payload | [System.Collections.Generic.IList{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.Byte}') | the payload. |

<a name='P-WiMOD-Messaging-Rx-LoRaWanRxHciMessage-MessageIdentifier'></a>
### MessageIdentifier `property`

##### Summary

*Inherit from parent.*

<a name='T-WiMOD-Messaging-Tx-LoRa-LoRaWanTxMessage'></a>
## LoRaWanTxMessage `type`

##### Namespace

WiMOD.Messaging.Tx.LoRa

##### Summary

Message to be sent to the LoRaWAN SAP.

<a name='M-WiMOD-Messaging-Tx-LoRa-LoRaWanTxMessage-#ctor-WiMOD-Messaging-LoRaWanMessageIdentifier,System-Collections-Generic-List{System-Byte}-'></a>
### #ctor(messageIdentifier,payload) `constructor`

##### Summary

Initializes a new instance of the [LoRaWanTxMessage](#T-WiMOD-Messaging-Tx-LoRa-LoRaWanTxMessage 'WiMOD.Messaging.Tx.LoRa.LoRaWanTxMessage') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| messageIdentifier | [WiMOD.Messaging.LoRaWanMessageIdentifier](#T-WiMOD-Messaging-LoRaWanMessageIdentifier 'WiMOD.Messaging.LoRaWanMessageIdentifier') | the message identifier. |
| payload | [System.Collections.Generic.List{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.Byte}') | the payload. |

<a name='P-WiMOD-Messaging-Tx-LoRa-LoRaWanTxMessage-MessageIdentifier'></a>
### MessageIdentifier `property`

##### Summary

*Inherit from parent.*

<a name='T-WiMOD-Messaging-Rx-Configuration-NetworkStatusIndicator'></a>
## NetworkStatusIndicator `type`

##### Namespace

WiMOD.Messaging.Rx.Configuration

##### Summary

Indicates the current network status.

<a name='F-WiMOD-Messaging-Rx-Configuration-NetworkStatusIndicator-DeviceActiveByActivationByPersonalisation'></a>
### DeviceActiveByActivationByPersonalisation `constants`

##### Summary

Active (ABP)

<a name='F-WiMOD-Messaging-Rx-Configuration-NetworkStatusIndicator-DeviceActiveByOverTheAirActivation'></a>
### DeviceActiveByOverTheAirActivation `constants`

##### Summary

Active (OTAA)

<a name='F-WiMOD-Messaging-Rx-Configuration-NetworkStatusIndicator-DeviceInactive'></a>
### DeviceInactive `constants`

##### Summary

Device inactive

<a name='F-WiMOD-Messaging-Rx-Configuration-NetworkStatusIndicator-DeviceJoiningByOverTheAirActivation'></a>
### DeviceJoiningByOverTheAirActivation `constants`

##### Summary

Joining (OTAA)

<a name='T-WiMOD-Messaging-Tx-LoRa-Configuration-NetworkStatusRequest'></a>
## NetworkStatusRequest `type`

##### Namespace

WiMOD.Messaging.Tx.LoRa.Configuration

##### Summary

This request allows to read the current network / activation status.

<a name='M-WiMOD-Messaging-Tx-LoRa-Configuration-NetworkStatusRequest-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [NetworkStatusRequest](#T-WiMOD-Messaging-Tx-LoRa-Configuration-NetworkStatusRequest 'WiMOD.Messaging.Tx.LoRa.Configuration.NetworkStatusRequest') class.

##### Parameters

This constructor has no parameters.

<a name='T-WiMOD-Messaging-Rx-Configuration-NetworkStatusResponse'></a>
## NetworkStatusResponse `type`

##### Namespace

WiMOD.Messaging.Rx.Configuration

##### Summary

Response to a [NetworkStatusRequest](#T-WiMOD-Messaging-Tx-LoRa-Configuration-NetworkStatusRequest 'WiMOD.Messaging.Tx.LoRa.Configuration.NetworkStatusRequest').

<a name='M-WiMOD-Messaging-Rx-Configuration-NetworkStatusResponse-#ctor-System-Collections-Generic-IList{System-Byte}-'></a>
### #ctor(payload) `constructor`

##### Summary

Initializes a new instance of the [NetworkStatusResponse](#T-WiMOD-Messaging-Rx-Configuration-NetworkStatusResponse 'WiMOD.Messaging.Rx.Configuration.NetworkStatusResponse') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payload | [System.Collections.Generic.IList{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.Byte}') | the payload. |

<a name='P-WiMOD-Messaging-Rx-Configuration-NetworkStatusResponse-DataRate'></a>
### DataRate `property`

##### Summary

Gets the current Data rate (spreading factor) of the device.

<a name='P-WiMOD-Messaging-Rx-Configuration-NetworkStatusResponse-DeviceActive'></a>
### DeviceActive `property`

##### Summary

Gets a value indicating whether the device is active on the network or not.

<a name='P-WiMOD-Messaging-Rx-Configuration-NetworkStatusResponse-DeviceAddress'></a>
### DeviceAddress `property`

##### Summary

Gets the device address.

<a name='P-WiMOD-Messaging-Rx-Configuration-NetworkStatusResponse-DeviceJoining'></a>
### DeviceJoining `property`

##### Summary

Gets a value indicating whether the device is currently joining the network.

<a name='P-WiMOD-Messaging-Rx-Configuration-NetworkStatusResponse-MaximumPayloadSize'></a>
### MaximumPayloadSize `property`

##### Summary

Gets current maximum payload size of the device.

<a name='P-WiMOD-Messaging-Rx-Configuration-NetworkStatusResponse-NetworkStatus'></a>
### NetworkStatus `property`

##### Summary

Gets the status of the network.

<a name='P-WiMOD-Messaging-Rx-Configuration-NetworkStatusResponse-PowerLevel'></a>
### PowerLevel `property`

##### Summary

Gets the current Power Level (EIRP) of the device in dBm.

<a name='P-WiMOD-Messaging-Rx-Configuration-NetworkStatusResponse-Status'></a>
### Status `property`

##### Summary

Gets the status of the response.

<a name='M-WiMOD-Messaging-Rx-Configuration-NetworkStatusResponse-ToString'></a>
### ToString() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-WiMOD-Messaging-Rx-LoRaWAN-NoDataIndication'></a>
## NoDataIndication `type`

##### Namespace

WiMOD.Messaging.Rx.LoRaWAN

##### Summary

This HCI message is sent to the host in case no expected confirmation or data has been received as a result of prior reliable uplink radio packet.

<a name='M-WiMOD-Messaging-Rx-LoRaWAN-NoDataIndication-#ctor-System-Collections-Generic-IList{System-Byte}-'></a>
### #ctor(payload) `constructor`

##### Summary

Initializes a new instance of the [NoDataIndication](#T-WiMOD-Messaging-Rx-LoRaWAN-NoDataIndication 'WiMOD.Messaging.Rx.LoRaWAN.NoDataIndication') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payload | [System.Collections.Generic.IList{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.Byte}') | the payload. |

<a name='T-WiMOD-Messaging-Tx-LoRa-Activation-OverTheAirActivationRequest'></a>
## OverTheAirActivationRequest `type`

##### Namespace

WiMOD.Messaging.Tx.LoRa.Activation

##### Summary

This request can be used to start the join network procedure. The module sends a join network radio packet and waits for a response from server side.

<a name='M-WiMOD-Messaging-Tx-LoRa-Activation-OverTheAirActivationRequest-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [OverTheAirActivationRequest](#T-WiMOD-Messaging-Tx-LoRa-Activation-OverTheAirActivationRequest 'WiMOD.Messaging.Tx.LoRa.Activation.OverTheAirActivationRequest') class.

##### Parameters

This constructor has no parameters.

<a name='T-WiMOD-Messaging-Rx-Activation-OverTheAirActivationResponse'></a>
## OverTheAirActivationResponse `type`

##### Namespace

WiMOD.Messaging.Rx.Activation

##### Summary

Response for OTAA Request.

<a name='M-WiMOD-Messaging-Rx-Activation-OverTheAirActivationResponse-#ctor-System-Collections-Generic-IList{System-Byte}-'></a>
### #ctor(payload) `constructor`

##### Summary

Initializes a new instance of the [OverTheAirActivationResponse](#T-WiMOD-Messaging-Rx-Activation-OverTheAirActivationResponse 'WiMOD.Messaging.Rx.Activation.OverTheAirActivationResponse') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payload | [System.Collections.Generic.IList{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.Byte}') | the payload. |

<a name='P-WiMOD-Messaging-Rx-Activation-OverTheAirActivationResponse-Status'></a>
### Status `property`

##### Summary

Gets the status of the response.

<a name='M-WiMOD-Messaging-Rx-Activation-OverTheAirActivationResponse-ToString'></a>
### ToString() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-WiMOD-Messaging-Tx-Device-PingRequest'></a>
## PingRequest `type`

##### Namespace

WiMOD.Messaging.Tx.Device

##### Summary

This command is used to check if the serial connection is ok and if the connected radiomodule is alive. The host should expect a Ping Response within a very short time interval.

<a name='M-WiMOD-Messaging-Tx-Device-PingRequest-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [PingRequest](#T-WiMOD-Messaging-Tx-Device-PingRequest 'WiMOD.Messaging.Tx.Device.PingRequest') class.

##### Parameters

This constructor has no parameters.

<a name='M-WiMOD-Messaging-Tx-Device-PingRequest-ToString'></a>
### ToString() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-WiMOD-Messaging-Rx-Device-PingResponse'></a>
## PingResponse `type`

##### Namespace

WiMOD.Messaging.Rx.Device

##### Summary

Response to a Ping Request.

<a name='M-WiMOD-Messaging-Rx-Device-PingResponse-#ctor-System-Collections-Generic-IList{System-Byte}-'></a>
### #ctor(payload) `constructor`

##### Summary

Initializes a new instance of the [PingResponse](#T-WiMOD-Messaging-Rx-Device-PingResponse 'WiMOD.Messaging.Rx.Device.PingResponse') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payload | [System.Collections.Generic.IList{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.Byte}') | The payload. |

<a name='P-WiMOD-Messaging-Rx-Device-PingResponse-Status'></a>
### Status `property`

##### Summary

Gets the status relayed in this message.

<a name='M-WiMOD-Messaging-Rx-Device-PingResponse-ToString'></a>
### ToString() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-WiMOD-Helpers-PortFinder'></a>
## PortFinder `type`

##### Namespace

WiMOD.Helpers

##### Summary

Finds connected serialdevices automagically on windows machines.

<a name='M-WiMOD-Helpers-PortFinder-#ctor-Microsoft-Extensions-Options-IOptions{WiMOD-DependencyInjection-WiModOptions},Microsoft-Extensions-Logging-ILoggerFactory-'></a>
### #ctor(options,loggerFactory) `constructor`

##### Summary

Initializes a new instance of the [PortFinder](#T-WiMOD-Helpers-PortFinder 'WiMOD.Helpers.PortFinder') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [Microsoft.Extensions.Options.IOptions{WiMOD.DependencyInjection.WiModOptions}](#T-Microsoft-Extensions-Options-IOptions{WiMOD-DependencyInjection-WiModOptions} 'Microsoft.Extensions.Options.IOptions{WiMOD.DependencyInjection.WiModOptions}') | options object. |
| loggerFactory | [Microsoft.Extensions.Logging.ILoggerFactory](#T-Microsoft-Extensions-Logging-ILoggerFactory 'Microsoft.Extensions.Logging.ILoggerFactory') | logger factory. |

<a name='P-WiMOD-Helpers-PortFinder-ConnectedPortName'></a>
### ConnectedPortName `property`

##### Summary

Gets the first port number mathcing the device name.

##### Returns

A string representation of the devices COM-port.

<a name='P-WiMOD-Helpers-PortFinder-ConnectedSerialPort'></a>
### ConnectedSerialPort `property`

##### Summary

Gets a serial connection to the first port number matching the device name.

##### Returns

the connected [SerialPort](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Ports.SerialPort 'System.IO.Ports.SerialPort').

<a name='M-WiMOD-Helpers-PortFinder-DeviceAvailable'></a>
### DeviceAvailable() `method`

##### Summary

Checks if any device is available.

##### Returns

A boolean indicating if any device is available.

##### Parameters

This method has no parameters.

<a name='T-WiMOD-Messaging-Rx-LoRaWAN-ReliableDataIndication'></a>
## ReliableDataIndication `type`

##### Namespace

WiMOD.Messaging.Rx.LoRaWAN

##### Summary

This HCI message is sent to the host after reception of a reliable radio packet containing application payload. The device will acknowledge the reception with a set Ack-Bit in the next reliable/unreliable uplink radio packet to the network server.

<a name='M-WiMOD-Messaging-Rx-LoRaWAN-ReliableDataIndication-#ctor-System-Collections-Generic-IList{System-Byte}-'></a>
### #ctor(payload) `constructor`

##### Summary

Initializes a new instance of the [ReliableDataIndication](#T-WiMOD-Messaging-Rx-LoRaWAN-ReliableDataIndication 'WiMOD.Messaging.Rx.LoRaWAN.ReliableDataIndication') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payload | [System.Collections.Generic.IList{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.Byte}') | the payload. |

<a name='P-WiMOD-Messaging-Rx-LoRaWAN-ReliableDataIndication-IsAcknowledgement'></a>
### IsAcknowledgement `property`

##### Summary

Gets a value indicating whether or not the message is an acknowledgement sent from the server.

<a name='T-WiMOD-Messaging-Tx-LoRa-Data-ReliableDataMessage'></a>
## ReliableDataMessage `type`

##### Namespace

WiMOD.Messaging.Tx.LoRa.Data

##### Summary

A LoRaWAN Data Transmission requiring acknowledgement.

<a name='M-WiMOD-Messaging-Tx-LoRa-Data-ReliableDataMessage-#ctor-System-Byte,System-Collections-Generic-List{System-Byte}-'></a>
### #ctor(port,payload) `constructor`

##### Summary

Initializes a new instance of the [ReliableDataMessage](#T-WiMOD-Messaging-Tx-LoRa-Data-ReliableDataMessage 'WiMOD.Messaging.Tx.LoRa.Data.ReliableDataMessage') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| port | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') | the port to send the message on. |
| payload | [System.Collections.Generic.List{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.Byte}') | the payload. |

<a name='T-WiMOD-Messaging-Rx-LoRaWAN-ReliableDataTransmitIndication'></a>
## ReliableDataTransmitIndication `type`

##### Namespace

WiMOD.Messaging.Rx.LoRaWAN

##### Summary

This HCI message is sent to the host after the radio packet has been sent.

<a name='M-WiMOD-Messaging-Rx-LoRaWAN-ReliableDataTransmitIndication-#ctor-System-Collections-Generic-IList{System-Byte}-'></a>
### #ctor(payload) `constructor`

##### Summary

Initializes a new instance of the [ReliableDataTransmitIndication](#T-WiMOD-Messaging-Rx-LoRaWAN-ReliableDataTransmitIndication 'WiMOD.Messaging.Rx.LoRaWAN.ReliableDataTransmitIndication') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payload | [System.Collections.Generic.IList{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.Byte}') | the payload. |

<a name='P-WiMOD-Messaging-Rx-LoRaWAN-ReliableDataTransmitIndication-ChannelIndex'></a>
### ChannelIndex `property`

##### Summary

Gets the channel index the transmission was sent on.

<a name='P-WiMOD-Messaging-Rx-LoRaWAN-ReliableDataTransmitIndication-DataRate'></a>
### DataRate `property`

##### Summary

Gets the Data rate (spreading factor) the transmission was sent on.

<a name='P-WiMOD-Messaging-Rx-LoRaWAN-ReliableDataTransmitIndication-MessageAirTimeMillis'></a>
### MessageAirTimeMillis `property`

##### Summary

Gets the airrtime in milliseconds of transmitted radio message.

<a name='P-WiMOD-Messaging-Rx-LoRaWAN-ReliableDataTransmitIndication-RadioPacketSent'></a>
### RadioPacketSent `property`

##### Summary

Gets a value indicating whether the radio packet was sent (true), or if an error occured (false).

<a name='P-WiMOD-Messaging-Rx-LoRaWAN-ReliableDataTransmitIndication-TransmitPowerLevel'></a>
### TransmitPowerLevel `property`

##### Summary

Gets the transmit power level configured in transceiver in dBm (min. value 0 dBm).

##### Remarks

The minimum TRX power level depends on the radio module and it could slightly vary from the given power level value for the low power levels.

<a name='P-WiMOD-Messaging-Rx-LoRaWAN-ReliableDataTransmitIndication-TransmittedRadioPackets'></a>
### TransmittedRadioPackets `property`

##### Summary

Gets the number of transmitted radio packets of last request.

<a name='M-WiMOD-Messaging-Rx-LoRaWAN-ReliableDataTransmitIndication-ToString'></a>
### ToString() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-WiMOD-Messaging-Tx-Device-ResetRequest'></a>
## ResetRequest `type`

##### Namespace

WiMOD.Messaging.Tx.Device

##### Summary

This message can be used to reset the radio module. The reset will be performed after approx. 200ms.

<a name='M-WiMOD-Messaging-Tx-Device-ResetRequest-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [ResetRequest](#T-WiMOD-Messaging-Tx-Device-ResetRequest 'WiMOD.Messaging.Tx.Device.ResetRequest') class.

##### Parameters

This constructor has no parameters.

<a name='M-WiMOD-Messaging-Tx-Device-ResetRequest-ToString'></a>
### ToString() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-WiMOD-Messaging-Rx-Device-ResetResponse'></a>
## ResetResponse `type`

##### Namespace

WiMOD.Messaging.Rx.Device

##### Summary

Response to a Ping Request.

<a name='M-WiMOD-Messaging-Rx-Device-ResetResponse-#ctor-System-Collections-Generic-IList{System-Byte}-'></a>
### #ctor(payload) `constructor`

##### Summary

Initializes a new instance of the [ResetResponse](#T-WiMOD-Messaging-Rx-Device-ResetResponse 'WiMOD.Messaging.Rx.Device.ResetResponse') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payload | [System.Collections.Generic.IList{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.Byte}') | The payload. |

<a name='P-WiMOD-Messaging-Rx-Device-ResetResponse-Status'></a>
### Status `property`

##### Summary

Gets the status relayed in this message.

<a name='M-WiMOD-Messaging-Rx-Device-ResetResponse-ToString'></a>
### ToString() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-WiMOD-Messaging-Rx-ResponseStatus'></a>
## ResponseStatus `type`

##### Namespace

WiMOD.Messaging.Rx

##### Summary

Device Management Endpoint Status Byte.

<a name='M-WiMOD-Messaging-Rx-ResponseStatus-#ctor-System-Byte-'></a>
### #ctor(statusByte) `constructor`

##### Summary

Initializes a new instance of the [ResponseStatus](#T-WiMOD-Messaging-Rx-ResponseStatus 'WiMOD.Messaging.Rx.ResponseStatus') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| statusByte | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') | the byte indicating the status. |

<a name='P-WiMOD-Messaging-Rx-ResponseStatus-Status'></a>
### Status `property`

##### Summary

Gets the status.

<a name='M-WiMOD-Messaging-Rx-ResponseStatus-ToString'></a>
### ToString() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-WiMOD-Messaging-Rx-ResponseStatusIdentifier'></a>
## ResponseStatusIdentifier `type`

##### Namespace

WiMOD.Messaging.Rx

##### Summary

Container for device status bytes and their meaning.

<a name='F-WiMOD-Messaging-Rx-ResponseStatusIdentifier-ChannelBlockedByDutyCycle'></a>
### ChannelBlockedByDutyCycle `constants`

##### Summary

Channel blocked by Duty Cycle

<a name='F-WiMOD-Messaging-Rx-ResponseStatusIdentifier-CommandNotSupported'></a>
### CommandNotSupported `constants`

##### Summary

Command is not supported

<a name='F-WiMOD-Messaging-Rx-ResponseStatusIdentifier-DeviceBusyCommandRejected'></a>
### DeviceBusyCommandRejected `constants`

##### Summary

Device is busy, command rejected

<a name='F-WiMOD-Messaging-Rx-ResponseStatusIdentifier-DeviceNotActivated'></a>
### DeviceNotActivated `constants`

##### Summary

Device is not activated

<a name='F-WiMOD-Messaging-Rx-ResponseStatusIdentifier-Error'></a>
### Error `constants`

##### Summary

Operation failed

<a name='F-WiMOD-Messaging-Rx-ResponseStatusIdentifier-FactorySettingsEepromBlockMissing'></a>
### FactorySettingsEepromBlockMissing `constants`

##### Summary

Factory Settings EEPROM block missing

<a name='F-WiMOD-Messaging-Rx-ResponseStatusIdentifier-HciMessageLengthIsInvalidOrRadioPayloadSizeTooLarge'></a>
### HciMessageLengthIsInvalidOrRadioPayloadSizeTooLarge `constants`

##### Summary

HCI message length is invalid or radio payload size is too large

<a name='F-WiMOD-Messaging-Rx-ResponseStatusIdentifier-MessageQueueFullCommandRejected'></a>
### MessageQueueFullCommandRejected `constants`

##### Summary

Message queue is full, command rejected

<a name='F-WiMOD-Messaging-Rx-ResponseStatusIdentifier-NoChannelAvailable'></a>
### NoChannelAvailable `constants`

##### Summary

No channel available (e.g. no channel defined for the configured spreading factor)

<a name='F-WiMOD-Messaging-Rx-ResponseStatusIdentifier-Ok'></a>
### Ok `constants`

##### Summary

Operation successful

<a name='F-WiMOD-Messaging-Rx-ResponseStatusIdentifier-StackRunningInWrongMode'></a>
### StackRunningInWrongMode `constants`

##### Summary

Stack is running in a wrong mode

<a name='F-WiMOD-Messaging-Rx-ResponseStatusIdentifier-WrongParameter'></a>
### WrongParameter `constants`

##### Summary

HCI message contains wrong parameter

<a name='T-WiMOD-Messaging-Rx-RxHciMessage'></a>
## RxHciMessage `type`

##### Namespace

WiMOD.Messaging.Rx

##### Summary

HCI Message received from WiMod Modem.

<a name='M-WiMOD-Messaging-Rx-RxHciMessage-#ctor-WiMOD-Messaging-EndpointIdentifier,System-Collections-Generic-IList{System-Byte}-'></a>
### #ctor(endpointIdentifier,payload) `constructor`

##### Summary

Initializes a new instance of the [RxHciMessage](#T-WiMOD-Messaging-Rx-RxHciMessage 'WiMOD.Messaging.Rx.RxHciMessage') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| endpointIdentifier | [WiMOD.Messaging.EndpointIdentifier](#T-WiMOD-Messaging-EndpointIdentifier 'WiMOD.Messaging.EndpointIdentifier') | the identifier of the endpoint. |
| payload | [System.Collections.Generic.IList{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.Byte}') | the payload. |

<a name='P-WiMOD-Messaging-Rx-RxHciMessage-EndpointIdentifier'></a>
### EndpointIdentifier `property`

##### Summary

Gets the identifier of the endpoint this message was sent to.

<a name='P-WiMOD-Messaging-Rx-RxHciMessage-MessageIdentifier'></a>
### MessageIdentifier `property`

##### Summary

Gets the message identifier.

<a name='P-WiMOD-Messaging-Rx-RxHciMessage-Payload'></a>
### Payload `property`

##### Summary

Gets or sets the payload of the response.

<a name='T-WiMOD-Messaging-Rx-LoRaWAN-SendReliableDataMessageResponse'></a>
## SendReliableDataMessageResponse `type`

##### Namespace

WiMOD.Messaging.Rx.LoRaWAN

##### Summary

A LoRaWAN Data Transmission not requiring acknowledgement response.

<a name='M-WiMOD-Messaging-Rx-LoRaWAN-SendReliableDataMessageResponse-#ctor-System-Collections-Generic-IList{System-Byte}-'></a>
### #ctor(payload) `constructor`

##### Summary

Initializes a new instance of the [SendReliableDataMessageResponse](#T-WiMOD-Messaging-Rx-LoRaWAN-SendReliableDataMessageResponse 'WiMOD.Messaging.Rx.LoRaWAN.SendReliableDataMessageResponse') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payload | [System.Collections.Generic.IList{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.Byte}') | the payload. |

<a name='P-WiMOD-Messaging-Rx-LoRaWAN-SendReliableDataMessageResponse-BlockedByDutyCycle'></a>
### BlockedByDutyCycle `property`

##### Summary

Gets a value indicating whether or not the channel was blocked by duty cycle.

<a name='P-WiMOD-Messaging-Rx-LoRaWAN-SendReliableDataMessageResponse-Status'></a>
### Status `property`

##### Summary

Gets the status relayed in this message.

<a name='P-WiMOD-Messaging-Rx-LoRaWAN-SendReliableDataMessageResponse-TimeUntilChannelAvailableMillis'></a>
### TimeUntilChannelAvailableMillis `property`

##### Summary

Gets the time [ms] remaining till channel available (sent if channel blocked by Duty Cycle).

<a name='M-WiMOD-Messaging-Rx-LoRaWAN-SendReliableDataMessageResponse-ToString'></a>
### ToString() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-WiMOD-Messaging-Rx-LoRaWAN-SendUnreliableDataMessageResponse'></a>
## SendUnreliableDataMessageResponse `type`

##### Namespace

WiMOD.Messaging.Rx.LoRaWAN

##### Summary

A LoRaWAN Data Transmission not requiring acknowledgement response.

<a name='M-WiMOD-Messaging-Rx-LoRaWAN-SendUnreliableDataMessageResponse-#ctor-System-Collections-Generic-IList{System-Byte}-'></a>
### #ctor(payload) `constructor`

##### Summary

Initializes a new instance of the [SendUnreliableDataMessageResponse](#T-WiMOD-Messaging-Rx-LoRaWAN-SendUnreliableDataMessageResponse 'WiMOD.Messaging.Rx.LoRaWAN.SendUnreliableDataMessageResponse') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payload | [System.Collections.Generic.IList{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.Byte}') | the payload. |

<a name='P-WiMOD-Messaging-Rx-LoRaWAN-SendUnreliableDataMessageResponse-BlockedByDutyCycle'></a>
### BlockedByDutyCycle `property`

##### Summary

Gets a value indicating whether or not the channel was blocked by duty cycle.

<a name='P-WiMOD-Messaging-Rx-LoRaWAN-SendUnreliableDataMessageResponse-Status'></a>
### Status `property`

##### Summary

Gets the status relayed in this message.

<a name='P-WiMOD-Messaging-Rx-LoRaWAN-SendUnreliableDataMessageResponse-TimeUntilChannelAvailableMillis'></a>
### TimeUntilChannelAvailableMillis `property`

##### Summary

Gets the time [ms] remaining till channel available (sent if channel blocked by Duty Cycle).

<a name='M-WiMOD-Messaging-Rx-LoRaWAN-SendUnreliableDataMessageResponse-ToString'></a>
### ToString() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-WiMOD-Messaging-Tx-LoRa-Activation-SetJoinParametersRequest'></a>
## SetJoinParametersRequest `type`

##### Namespace

WiMOD.Messaging.Tx.LoRa.Activation

##### Summary

This request can be used to configure the over-the-air activation parameters which are used during the join procedure.

<a name='M-WiMOD-Messaging-Tx-LoRa-Activation-SetJoinParametersRequest-#ctor-System-String,System-String-'></a>
### #ctor(applicationEui,applicationKey) `constructor`

##### Summary

Initializes a new instance of the [SetJoinParametersRequest](#T-WiMOD-Messaging-Tx-LoRa-Activation-SetJoinParametersRequest 'WiMOD.Messaging.Tx.LoRa.Activation.SetJoinParametersRequest') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| applicationEui | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A globally unique 64-Bit application ID as a Hex-formatted string. |
| applicationKey | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | A device-specific 128-Bit AES application key as a Hex-formatted string. |

<a name='M-WiMOD-Messaging-Tx-LoRa-Activation-SetJoinParametersRequest-#ctor-System-Collections-Generic-IList{System-Byte},System-Collections-Generic-IList{System-Byte}-'></a>
### #ctor(applicationEui,applicationKey) `constructor`

##### Summary

Initializes a new instance of the [SetJoinParametersRequest](#T-WiMOD-Messaging-Tx-LoRa-Activation-SetJoinParametersRequest 'WiMOD.Messaging.Tx.LoRa.Activation.SetJoinParametersRequest') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| applicationEui | [System.Collections.Generic.IList{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.Byte}') | A globally unique 64-Bit application ID. |
| applicationKey | [System.Collections.Generic.IList{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.Byte}') | A device-specific 128-Bit AES application key. |

<a name='T-WiMOD-Messaging-Rx-Activation-SetJoinParametersResponse'></a>
## SetJoinParametersResponse `type`

##### Namespace

WiMOD.Messaging.Rx.Activation

##### Summary

Response to a [](#!-SetJoinParametersRequest 'SetJoinParametersRequest').

<a name='M-WiMOD-Messaging-Rx-Activation-SetJoinParametersResponse-#ctor-System-Collections-Generic-IList{System-Byte}-'></a>
### #ctor(payload) `constructor`

##### Summary

Initializes a new instance of the [SetJoinParametersResponse](#T-WiMOD-Messaging-Rx-Activation-SetJoinParametersResponse 'WiMOD.Messaging.Rx.Activation.SetJoinParametersResponse') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payload | [System.Collections.Generic.IList{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.Byte}') | the payload. |

<a name='P-WiMOD-Messaging-Rx-Activation-SetJoinParametersResponse-Status'></a>
### Status `property`

##### Summary

Gets the status of the response.

<a name='M-WiMOD-Messaging-Rx-Activation-SetJoinParametersResponse-ToString'></a>
### ToString() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-WiMOD-Messaging-Tx-TxHciMessage'></a>
## TxHciMessage `type`

##### Namespace

WiMOD.Messaging.Tx

##### Summary

HCI Message for transmission to WiMod Modem.

<a name='M-WiMOD-Messaging-Tx-TxHciMessage-#ctor-WiMOD-Messaging-EndpointIdentifier,System-Collections-Generic-List{System-Byte}-'></a>
### #ctor(identifier,payload) `constructor`

##### Summary

Initializes a new instance of the [TxHciMessage](#T-WiMOD-Messaging-Tx-TxHciMessage 'WiMOD.Messaging.Tx.TxHciMessage') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| identifier | [WiMOD.Messaging.EndpointIdentifier](#T-WiMOD-Messaging-EndpointIdentifier 'WiMOD.Messaging.EndpointIdentifier') | Identifier for destination endpoint. |
| payload | [System.Collections.Generic.List{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.Byte}') | payload to be sent. |

<a name='P-WiMOD-Messaging-Tx-TxHciMessage-EndpointIdentifier'></a>
### EndpointIdentifier `property`

##### Summary

Gets the identifier of the endpoint this message should be sent to.

<a name='P-WiMOD-Messaging-Tx-TxHciMessage-MessageIdentifier'></a>
### MessageIdentifier `property`

##### Summary

Gets the message identifier.

<a name='P-WiMOD-Messaging-Tx-TxHciMessage-Payload'></a>
### Payload `property`

##### Summary

Gets the payload of this message.

<a name='T-WiMOD-Messaging-Rx-LoRaWAN-UnreliableDataIndication'></a>
## UnreliableDataIndication `type`

##### Namespace

WiMOD.Messaging.Rx.LoRaWAN

##### Summary

This HCI message is sent to the host after reception of an unreliable radio packet containing application payload.

<a name='M-WiMOD-Messaging-Rx-LoRaWAN-UnreliableDataIndication-#ctor-System-Collections-Generic-IList{System-Byte}-'></a>
### #ctor(payload) `constructor`

##### Summary

Initializes a new instance of the [UnreliableDataIndication](#T-WiMOD-Messaging-Rx-LoRaWAN-UnreliableDataIndication 'WiMOD.Messaging.Rx.LoRaWAN.UnreliableDataIndication') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payload | [System.Collections.Generic.IList{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.Byte}') | the payload. |

<a name='P-WiMOD-Messaging-Rx-LoRaWAN-UnreliableDataIndication-IsAcknowledgement'></a>
### IsAcknowledgement `property`

##### Summary

Gets a value indicating whether or not the message is an acknowledgement sent from the server.

<a name='T-WiMOD-Messaging-Tx-LoRa-Data-UnreliableDataMessage'></a>
## UnreliableDataMessage `type`

##### Namespace

WiMOD.Messaging.Tx.LoRa.Data

##### Summary

A LoRaWAN Data Transmission not requiring acknowledgement.

<a name='M-WiMOD-Messaging-Tx-LoRa-Data-UnreliableDataMessage-#ctor-System-Byte,System-Collections-Generic-List{System-Byte}-'></a>
### #ctor(port,payload) `constructor`

##### Summary

Initializes a new instance of the [UnreliableDataMessage](#T-WiMOD-Messaging-Tx-LoRa-Data-UnreliableDataMessage 'WiMOD.Messaging.Tx.LoRa.Data.UnreliableDataMessage') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| port | [System.Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte') | The port to use. |
| payload | [System.Collections.Generic.List{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.Byte}') | The payload. |

<a name='T-WiMOD-Messaging-Rx-LoRaWAN-UnreliableDataTransmitIndication'></a>
## UnreliableDataTransmitIndication `type`

##### Namespace

WiMOD.Messaging.Rx.LoRaWAN

##### Summary

This HCI message is sent to the host after the radio packet has been sent or if the retransmission procedure finishes without success, containing in this case the corresponding error code.

<a name='M-WiMOD-Messaging-Rx-LoRaWAN-UnreliableDataTransmitIndication-#ctor-System-Collections-Generic-IList{System-Byte}-'></a>
### #ctor(payload) `constructor`

##### Summary

Initializes a new instance of the [UnreliableDataTransmitIndication](#T-WiMOD-Messaging-Rx-LoRaWAN-UnreliableDataTransmitIndication 'WiMOD.Messaging.Rx.LoRaWAN.UnreliableDataTransmitIndication') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payload | [System.Collections.Generic.IList{System.Byte}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{System.Byte}') | the payload. |

<a name='P-WiMOD-Messaging-Rx-LoRaWAN-UnreliableDataTransmitIndication-ChannelIndex'></a>
### ChannelIndex `property`

##### Summary

Gets the channel index the transmission was sent on.

<a name='P-WiMOD-Messaging-Rx-LoRaWAN-UnreliableDataTransmitIndication-DataRate'></a>
### DataRate `property`

##### Summary

Gets the Data rate (spreading factor) the transmission was sent on.

<a name='P-WiMOD-Messaging-Rx-LoRaWAN-UnreliableDataTransmitIndication-MaximumNumberOfRetransmissionsReached'></a>
### MaximumNumberOfRetransmissionsReached `property`

##### Summary

Gets a value indicating whether or not maximum number of retransmissions reached (error).

<a name='P-WiMOD-Messaging-Rx-LoRaWAN-UnreliableDataTransmitIndication-MaximumPayloadSizeExceededForCurrentDataRate'></a>
### MaximumPayloadSizeExceededForCurrentDataRate `property`

##### Summary

Gets a value indicating whether or not maximum payload size exceeded for current data rate (error).

<a name='P-WiMOD-Messaging-Rx-LoRaWAN-UnreliableDataTransmitIndication-MessageAirTimeMillis'></a>
### MessageAirTimeMillis `property`

##### Summary

Gets the airrtime in milliseconds of transmitted radio message.

<a name='P-WiMOD-Messaging-Rx-LoRaWAN-UnreliableDataTransmitIndication-RadioPacketSent'></a>
### RadioPacketSent `property`

##### Summary

Gets a value indicating whether the radio packet was sent (true), or if an error occured (false).

<a name='P-WiMOD-Messaging-Rx-LoRaWAN-UnreliableDataTransmitIndication-TransmitPowerLevel'></a>
### TransmitPowerLevel `property`

##### Summary

Gets the transmit power level configured in transceiver in dBm (min. value 0 dBm).

##### Remarks

The minimum TRX power level depends on the radio module and it could slightly vary from the given power level value for the low power levels.

<a name='P-WiMOD-Messaging-Rx-LoRaWAN-UnreliableDataTransmitIndication-TransmittedRadioPackets'></a>
### TransmittedRadioPackets `property`

##### Summary

Gets the number of transmitted radio packets of last request.

<a name='M-WiMOD-Messaging-Rx-LoRaWAN-UnreliableDataTransmitIndication-ToString'></a>
### ToString() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-WiMOD-WiModModem'></a>
## WiModModem `type`

##### Namespace

WiMOD

##### Summary

Represents a physical iMST WiMOD iU880B LoRa Modem.

<a name='M-WiMOD-WiModModem-#ctor-Microsoft-Extensions-Options-IOptions{WiMOD-DependencyInjection-WiModOptions},Microsoft-Extensions-Logging-ILoggerFactory,WiMOD-Helpers-PortFinder-'></a>
### #ctor(options,loggerFactory,portfinder) `constructor`

##### Summary

Initializes a new instance of the [WiModModem](#T-WiMOD-WiModModem 'WiMOD.WiModModem') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [Microsoft.Extensions.Options.IOptions{WiMOD.DependencyInjection.WiModOptions}](#T-Microsoft-Extensions-Options-IOptions{WiMOD-DependencyInjection-WiModOptions} 'Microsoft.Extensions.Options.IOptions{WiMOD.DependencyInjection.WiModOptions}') | options object. |
| loggerFactory | [Microsoft.Extensions.Logging.ILoggerFactory](#T-Microsoft-Extensions-Logging-ILoggerFactory 'Microsoft.Extensions.Logging.ILoggerFactory') | loggerfactory. |
| portfinder | [WiMOD.Helpers.PortFinder](#T-WiMOD-Helpers-PortFinder 'WiMOD.Helpers.PortFinder') | port finder. |

<a name='M-WiMOD-WiModModem-SetReceiver-System-Func{WiMOD-Messaging-Rx-RxHciMessage,System-Threading-Tasks-Task}-'></a>
### SetReceiver(onData) `method`

##### Summary

Set the action to be triggered, when new data is available.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| onData | [System.Func{WiMOD.Messaging.Rx.RxHciMessage,System.Threading.Tasks.Task}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{WiMOD.Messaging.Rx.RxHciMessage,System.Threading.Tasks.Task}') | the action to be triggered. |

<a name='M-WiMOD-WiModModem-TransmitMessage-WiMOD-Messaging-Tx-TxHciMessage-'></a>
### TransmitMessage(message) `method`

##### Summary

Transmits the passed `message` to the physical modem.

##### Returns

A [Task](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Threading.Tasks.Task 'System.Threading.Tasks.Task') representing the asynchronous operation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [WiMOD.Messaging.Tx.TxHciMessage](#T-WiMOD-Messaging-Tx-TxHciMessage 'WiMOD.Messaging.Tx.TxHciMessage') | the message to be sent. |

<a name='T-WiMOD-Messaging-Rx-Device-WiModModuleType'></a>
## WiModModuleType `type`

##### Namespace

WiMOD.Messaging.Rx.Device

##### Summary

Module types for WiMod.

<a name='T-WiMOD-DependencyInjection-WiModOptions'></a>
## WiModOptions `type`

##### Namespace

WiMOD.DependencyInjection

##### Summary

Options which should fit any operating system.

<a name='P-WiMOD-DependencyInjection-WiModOptions-BaudRate'></a>
### BaudRate `property`

##### Summary

Gets or sets the baud rate for the iU880B-stick.

<a name='P-WiMOD-DependencyInjection-WiModOptions-Name'></a>
### Name `property`

##### Summary

Gets or sets of the name of the serial port.

##### Remarks

On UNIX-like systems this shoud be /dev/ttySOMETHINGSOMETHING.
On Windows this would be COM[number].

<a name='P-WiMOD-DependencyInjection-WiModOptions-UsePortFinder'></a>
### UsePortFinder `property`

##### Summary

Gets or sets a value indicating whether or not [Name](#P-WiMOD-DependencyInjection-WiModOptions-Name 'WiMOD.DependencyInjection.WiModOptions.Name') should be used to query a port on Windows.

<a name='T-WiMOD-DependencyInjection-WiModServiceCollectionExtensions'></a>
## WiModServiceCollectionExtensions `type`

##### Namespace

WiMOD.DependencyInjection

##### Summary

Extension methods for DI.

<a name='M-WiMOD-DependencyInjection-WiModServiceCollectionExtensions-AddWiModModem-Microsoft-Extensions-DependencyInjection-IServiceCollection,System-Action{WiMOD-DependencyInjection-WiModOptions}-'></a>
### AddWiModModem(services,setupAction) `method`

##### Summary

Adds WiMOD Dependencies.

##### Returns

a modified service collection.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') | the service collection to be modified. |
| setupAction | [System.Action{WiMOD.DependencyInjection.WiModOptions}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{WiMOD.DependencyInjection.WiModOptions}') | an action for hooking into. |
