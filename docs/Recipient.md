
# TransferZero.Sdk.Model.Recipient

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RequestedAmount** | **decimal?** | the amount that should be paid to the recipient. This can be in any currency, usually either the input or the output currency. If the value here is not the output currency we will calculate how much the recipient is going to get using the exchange rates active when the transaction was created. | 
**RequestedCurrency** | **string** | the currency of the amount in 3-character alpha ISO 4217 currency format | 
**PayoutMethod** | [**PayoutMethod**](PayoutMethod.md) |  | 
**Metadata** | [**Object**](.md) | Additional metadata that can be added to a recipient. These values will be returned on request | [optional] 
**CreatedAt** | **DateTime?** | Date and time that the recipient was created. | [optional] 
**Editable** | **bool?** | Shows whether the recipient can be edited using the PATCH /v1/recipients/{id} endpoint or not | [optional] 
**Retriable** | **bool?** | Shows whether the transaction made to the recipient can be retried or not | [optional] 
**InputUsdAmount** | **decimal?** | Shows how much this payment is worth in USD | [optional] 
**MayCancel** | **bool?** | If true it shows that the payment can be cancelled immediately using the DELETE /v1/recipients/{id} endpoint. If false you can still try to cancel it, however it will only gets cancelled once we have confirmation from our partner that the payment has failed. | [optional] 
**StateReason** | **string** | In case the payment is unsuccessful it holds the error message associated with the last unsuccessful payout. | [optional] 
**StateReasonDetails** | [**RecipientStateReasonDetails**](RecipientStateReasonDetails.md) |  | [optional] 
**State** | [**RecipientState**](RecipientState.md) |  | [optional] 
**TransactionId** | **string** | The ID of the transaction that is related to this recipient | [optional] 
**TransactionExternalId** | **string** | Optional ID that is supplied by partner linking it to the partner&#39;s own Transaction ID. | [optional] 
**TransactionState** | [**TransactionState**](TransactionState.md) |  | [optional] 
**ExchangeRate** | **decimal?** | The exchange rate used in this payment | [optional] 
**FeeFractional** | **decimal?** | The fee for this payment in fractional units (for example cents for USD transactions) | [optional] 
**InputAmount** | **decimal?** | The amount that had to be paid in for this payment to proceed | [optional] 
**InputCurrency** | **string** | The currency this payment was paid in | [optional] 
**OutputAmount** | **decimal?** | The amount that will be paid to the recipient | [optional] 
**OutputCurrency** | **string** | The currency the payment will be delivered in | [optional] 
**Id** | **Guid?** |  | [optional] 
**Errors** | **Dictionary&lt;string, List&lt;ValidationErrorDescription&gt;&gt;** | The fields that have some problems and don&#39;t pass validation | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

