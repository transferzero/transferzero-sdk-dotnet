
# TransferZero.Sdk.Model.Mandate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid?** | ID of the mandate | [optional] 
**Status** | [**MandateStatus**](MandateStatus.md) |  | [optional] 
**TypeId** | **int?** | Numeric beneficiary type identifier. Identifies whether the mandate was issued for a natural person, sole proprietor, partnership, company, etc. | [optional] 
**Reference** | **string** | Human-readable reference assigned to the mandate at creation. | [optional] 
**SignedAt** | **DateTime?** | Timestamp when the mandate transitioned to &#x60;signed&#x60;. &#x60;null&#x60; for mandates that are pending, notified, failed, or bypassed. | [optional] 
**CreatedAt** | **DateTime?** | Timestamp when the mandate was created. | [optional] 
**UpdatedAt** | **DateTime?** | Timestamp when the mandate was last updated. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

