
# TransferZero.Sdk.Model.Transaction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InputCurrency** | **string** | The input currency describes what currency the transaction will be paid in (3-character alpha ISO 4217 currency format). For example if you wish to create an EUR to NGN transaction then input currency should be set to EUR. | 
**PayinMethods** | [**List&lt;PayinMethod&gt;**](PayinMethod.md) | Allows setting alternative collections, where funding the transaction is done through alternative means and not via account balance.  For more information please see [Collections from senders](https://github.com/transferzero/api-documentation/blob/master/additional-features.md#collections-from-senders) in the API documentation | [optional] 
**Metadata** | [**Object**](.md) | Additional metadata to store on the transaction. If you widh to store your local transaction ID, you should add it here inside a &#x60;sendRef&#x60; field, and we will return this value back to you in the daily transaction reports. | [optional] 
**Sender** | [**Sender**](Sender.md) |  | 
**Recipients** | [**List&lt;Recipient&gt;**](Recipient.md) | The details of where the payment should go. although transactions can support paying out multiple recipients, usually one is provided.  | 
**Traits** | [**TransactionTraits**](TransactionTraits.md) |  | [optional] 
**State** | [**TransactionState**](TransactionState.md) |  | [optional] 
**InputAmount** | **decimal?** | The amount that was requested in the input currency | [optional] 
**PayinReference** | **string** | The reference number that has to be provided in case the transaction is not funded through account balance | [optional] 
**PaidAmount** | **decimal?** | The amount that was already paid in to the transaction | [optional] 
**DueAmount** | **decimal?** | The amount needed to be paid in for the transaction to get funded | [optional] 
**CreatedAt** | **DateTime?** | The time the transaction was created | [optional] 
**ExpiresAt** | **DateTime?** | The latest time when the transaction has to be funded, otherwise it will be cancelled | [optional] 
**ExternalId** | **string** | Optional ID that is supplied by partner linking it to the partner&#39;s own Sender ID. Note: if present we will validate whether the sent ID is a duplicate in our system or not. | [optional] 
**Id** | **Guid?** |  | [optional] 
**Errors** | **Dictionary&lt;string, List&lt;ValidationErrorDescription&gt;&gt;** | The fields that have some problems and don&#39;t pass validation | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

