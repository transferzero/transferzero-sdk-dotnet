
# TransferZero.Sdk.Model.Debit

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **double?** | The amount to be debited from your account.  The \&quot;amount\&quot; parameter is optional - - if included, it must equal the amount required to fund the transaction. - if omitted, it will default to the amount required to fund the transaction.  | [optional] 
**Currency** | **string** | The currency of the amount in 3-character alpha ISO 4217 currency format.  The \&quot;currency\&quot; parameter is optional - if omitted, it will default to the payin currency of the transaction. - it can be added in as an additional check to ensure that the expected currency is used. (an error will be given back if it does not match up with the payin currency of the transaction)  | [optional] 
**ToType** | **string** | Describes what the debit is funding | 
**ToId** | **Guid?** | The ID of the resource the debit is funding | 
**Metadata** | [**Object**](.md) | Metadata of account debit | [optional] 
**Id** | **Guid?** |  | [optional] 
**CreatedAt** | **DateTime?** | Date and time that the debit was created | [optional] 
**UsdAmount** | **double?** | The amount to be debited from your account converted to USD  | [optional] 
**RunningBalance** | **double?** | The total amount remaining in your account after the debit call  | [optional] 
**Errors** | **Dictionary&lt;string, List&lt;ValidationErrorDescription&gt;&gt;** | The fields that have some problems and don&#39;t pass validation | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

