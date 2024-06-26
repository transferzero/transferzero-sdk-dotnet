
# TransferZero.Sdk.Model.PayinMethod

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Describes how the payment should be requested from the sender.  Possible values: - &#x60;GHS::Mobile&#x60;: GHS mobile collections - &#x60;UGX::Mobile&#x60;: UGX mobile collections - &#x60;XOF::Mobile&#x60;: XOF mobile collections - &#x60;NGN::Bank&#x60;: NGN bank collections - &#x60;EUR::Bank&#x60;: EUR IBAN collections - &#x60;GBP::Bank&#x60;: GBP IBAN collections  | [optional] 
**UxFlow** | [**PayinMethodUxFlow**](PayinMethodUxFlow.md) |  | [optional] 
**InDetails** | [**PayinMethodDetails**](PayinMethodDetails.md) |  | [optional] 
**Id** | **Guid?** |  | [optional] 
**State** | [**PayinMethodState**](PayinMethodState.md) |  | [optional] 
**StateReasonDetails** | [**StateReasonDetails**](StateReasonDetails.md) |  | [optional] 
**OutDetails** | [**Object**](.md) | This will contain the description on where to pay the funds. Please see the [Collections Details](https://docs.transferzero.com/docs/collection-details) in the API documentation on what to expect here. | [optional] 
**Instructions** | [**Object**](.md) | This will contain the instructions on how to pay the funds. Please see the [Collections Details](https://docs.transferzero.com/docs/collection-details) in the API documentation on what to expect here. | [optional] 
**Errors** | **Dictionary&lt;string, List&lt;ValidationErrorDescription&gt;&gt;** | The fields that have some problems and don&#39;t pass validation | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

