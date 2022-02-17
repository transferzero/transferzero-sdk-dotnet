
# TransferZero.Sdk.Model.PayinMethodDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PaymentMethod** | **string** | The payment method which the sender will use to make the payments. Options are &#x60;bank&#x60;, &#x60;card&#x60; or you can leave empty to support both. | [optional] 
**RedirectUrl** | **string** | This is where the sender should be redirected back when the payment has been finished | [optional] 
**PhoneNumber** | **string** | The phone number where the funds should be collected from | [optional] 
**MobileProvider** | [**PayoutMethodMobileProviderEnum**](PayoutMethodMobileProviderEnum.md) |  | [optional] 
**RefundAddress** | **string** | Please make sure the refund_address is a valid BTC address belonging to the sender, as that is going to be used in case the transaction has to be refunded. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

