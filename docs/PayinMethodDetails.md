
# TransferZero.Sdk.Model.PayinMethodDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PhoneNumber** | **string** | The phone number where the funds should be collected from | [optional] 
**MobileProvider** | [**PayoutMethodMobileProviderEnum**](PayoutMethodMobileProviderEnum.md) |  | [optional] 
**Country** | [**PayoutMethodCountryEnum**](PayoutMethodCountryEnum.md) |  | [optional] 
**Otp** | **string** | The OTP that the sender received in otp verified ussd popup ux flow. | [optional] 
**RefundAddress** | **string** | Please make sure the refund_address is a valid BTC address belonging to the sender, as that is going to be used in case the transaction has to be refunded. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

