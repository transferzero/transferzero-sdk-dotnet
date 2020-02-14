
# TransferZero.Sdk.Model.Document

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SenderId** | **Guid?** |  | [optional] 
**Upload** | **string** | Base64 encoded data uri of an image/pdf file or a fully qualified url | 
**UploadFileName** | **string** | Name of the upload | 
**Metadata** | [**Object**](.md) | Metadata of document | [optional] 
**UploadContentType** | **string** |  | [optional] 
**UploadFileSize** | **int?** |  | [optional] 
**Category** | **string** | uncategorised | [optional] 
**Side** | **string** | The side of the KYC ID. One of &#39;front&#39; or &#39;back&#39; | [optional] 
**DocumentType** | **string** | This is a brief description of the document type | [optional] 
**IssuingCountry** | **string** | Issuing country of ID in 2-character alpha ISO 3166-2 country format | [optional] 
**Id** | **Guid?** |  | [optional] 
**Errors** | **Dictionary&lt;string, List&lt;ValidationErrorDescription&gt;&gt;** | The fields that have some problems and don&#39;t pass validation | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

