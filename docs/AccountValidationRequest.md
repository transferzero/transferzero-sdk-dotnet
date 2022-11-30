
# TransferZero.Sdk.Model.AccountValidationRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BankAccount** | **string** | Account Number to query | [optional] 
**BankCode** | **string** | Bank Code to query - same codes are used as for creating the transactions | [optional] 
**Iban** | **string** | IBAN to query - BBAN format for XOF bank accounts | [optional] 
**PhoneNumber** | **string** | Phone number to query in E.164 format | [optional] 
**MobileProvider** | [**PayoutMethodMobileProviderEnum**](PayoutMethodMobileProviderEnum.md) |  | [optional] 
**Country** | **string** | Country of account in 2-character alpha ISO 3166-2 country format | 
**Currency** | **string** | The currency the bank account is in | 
**Method** | **string** | The method of the payment. Currently bank and mobile are supported | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

