
# TransferZero.Sdk.Model.PaymentMethod

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Details currency and type of payment. | [optional] 
**Provider** | **string** | Identifies the payment provider. | [optional] 
**OtcPermitted** | **bool?** | Are over the counter transactions permitted? | [optional] 
**Details** | **List&lt;string&gt;** | Fields required to make the payment depending on type. | [optional] 
**Default** | **bool?** | Boolean revealing whether this is the default payout method. Only present on payout methods | [optional] 
**Fields** | [**Dictionary&lt;string, FieldDescription&gt;**](FieldDescription.md) | The fields needed for payments with this payment method with details on validation requirements | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

