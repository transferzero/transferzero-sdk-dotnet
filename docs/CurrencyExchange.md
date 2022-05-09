
# TransferZero.Sdk.Model.CurrencyExchange

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The currency code in 3-character alpha ISO 4217 currency format | [optional] 
**Name** | **string** | Name of currency | [optional] 
**Symbol** | **string** | Symbol of currency | [optional] 
**Decimals** | **decimal** | Number of decimal points | [optional] 
**SubunitToUnit** | **string** | Subunits in Unit (eg. there are 100 cents in 1 US Dollar) | [optional] 
**Primary** | **bool** | Is this a primary currency? | [optional] 
**Min** | **string** | The minimum amount allowed in a transaction | [optional] 
**Max** | **string** | The maximum amount allowed in a transaction | [optional] 
**UsdEquivalent** | **string** | The equivalent of the currency to 1 USD | [optional] 
**Opposites** | [**List&lt;CurrencyOpposite&gt;**](CurrencyOpposite.md) | Lists the currencies where you can exchange from this one | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

