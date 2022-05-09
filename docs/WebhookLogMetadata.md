
# TransferZero.Sdk.Model.WebhookLogMetadata

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Params** | [**WebhookDefinition**](WebhookDefinition.md) |  | [optional] 
**Event** | **string** | Specific event that triggered the webhook | [optional] 
**InstanceId** | **string** | Instance ID of the webhook event | [optional] 
**InstanceType** | **string** | Type of instance event | [optional] 
**AttemptId** | **string** | Attempt ID | [optional] 
**Tries** | **int** | Number of tries at the point webhook was triggered | [optional] 
**Request** | [**WebhookLogMetadataRequest**](WebhookLogMetadataRequest.md) |  | [optional] 
**Response** | [**WebhookLogMetadataResponse**](WebhookLogMetadataResponse.md) |  | [optional] 
**AppId** | **string** | ID of app on which webhook event was triggered | [optional] 
**ApiKeyId** | **string** | ID of API key in use at point of webhook event | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

