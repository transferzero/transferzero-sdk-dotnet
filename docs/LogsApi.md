# TransferZero.Sdk.Api.LogsApi

All URIs are relative to *https://api-sandbox.bitpesa.co/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetWebhookLog**](LogsApi.md#getwebhooklog) | **GET** /logs/{Webhook Log ID} | Fetch an individual webhook log
[**GetWebhookLogs**](LogsApi.md#getwebhooklogs) | **GET** /logs/webhooks | Fetch a list of webhook logs


<a name="getwebhooklog"></a>
# **GetWebhookLog**
> WebhookLogResponse GetWebhookLog (Guid? webhookLogID)

Fetch an individual webhook log

Returns a single webhook log based on the webhook log ID.

### Example

#### C#

```csharp
using System;
using System.Diagnostics;
using TransferZero.Sdk.Api;
using TransferZero.Sdk.Client;
using TransferZero.Sdk.Model;

namespace Example
{
    public class GetWebhookLogExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new LogsApi(configuration);
            var webhookLogID = new Guid?(); // Guid? | ID of the webhook log to retrieve  Example: `/v1/logs/9d1ad631-f34a-4cff-9a7e-2c83e3a556df`

            try {
                // Fetch an individual webhook log
                WebhookLogResponse result = apiInstance.GetWebhookLog(webhookLogID);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    WebhookLogResponse result = e.ParseObject<WebhookLogResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling LogsApi.GetWebhookLog: " + e.Message );
                }
            }
        }
    }
}
```

#### VB.NET

```vbnet
Imports TransferZero.Sdk.Api;
Imports TransferZero.Sdk.Client;
Imports TransferZero.Sdk.Model;
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Module Example
    Sub Main(ByVal args As String())
        Dim configuration As Configuration = New Configuration()
        configuration.ApiKey = "KEY"
        configuration.ApiSecret = "SECRET"
        configuration.BasePath = "https://api-sandbox.transferzero.com/v1"

        Dim debitsApi As AccountDebitsApi = New AccountDebitsApi(configuration)

        Dim apiInstance = new LogsApi(configuration)
        Dim webhookLogID = new Guid?() REM Guid? | ID of the webhook log to retrieve  Example: `/v1/logs/9d1ad631-f34a-4cff-9a7e-2c83e3a556df`


        Try
            REM Fetch an individual webhook log
            Dim result As WebhookLogResponse = apiInstance.GetWebhookLog(webhookLogID)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as WebhookLogResponse = e.ParseObject(Of WebhookLogResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling LogsApi.GetWebhookLog: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webhookLogID** | [**Guid?**](Guid?.md)| ID of the webhook log to retrieve  Example: &#x60;/v1/logs/9d1ad631-f34a-4cff-9a7e-2c83e3a556df&#x60; | 

### Return type

[**WebhookLogResponse**](WebhookLogResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebhooklogs"></a>
# **GetWebhookLogs**
> WebhookLogListResponse GetWebhookLogs (int? page = null, int? per = null, string createdAtFrom = null, string createdAtTo = null)

Fetch a list of webhook logs

Returns a list of webhook logs. Response includes pagination.

### Example

#### C#

```csharp
using System;
using System.Diagnostics;
using TransferZero.Sdk.Api;
using TransferZero.Sdk.Client;
using TransferZero.Sdk.Model;

namespace Example
{
    public class GetWebhookLogsExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new LogsApi(configuration);
            var page = 1;  // int? | The page number to request (defaults to 1) (optional) 
            var per = 10;  // int? | The number of results to load per page (defaults to 10) (optional) 
            var createdAtFrom = createdAtFrom_example;  // string | Start date to filter recipients by created_at range Allows filtering results by the specified `created_at` timeframe.  Example: `/v1/recipients?created_at_from=2018-06-06&created_at_to=2018-06-08` (optional) 
            var createdAtTo = createdAtTo_example;  // string | End date to filter recipients by created_at range Allows filtering results by the specified `created_at` timeframe.  Example: `/v1/recipients?created_at_from=2018-06-06&created_at_to=2018-06-08` (optional) 

            try {
                // Fetch a list of webhook logs
                WebhookLogListResponse result = apiInstance.GetWebhookLogs(page, per, createdAtFrom, createdAtTo);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    WebhookLogListResponse result = e.ParseObject<WebhookLogListResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling LogsApi.GetWebhookLogs: " + e.Message );
                }
            }
        }
    }
}
```

#### VB.NET

```vbnet
Imports TransferZero.Sdk.Api;
Imports TransferZero.Sdk.Client;
Imports TransferZero.Sdk.Model;
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Module Example
    Sub Main(ByVal args As String())
        Dim configuration As Configuration = New Configuration()
        configuration.ApiKey = "KEY"
        configuration.ApiSecret = "SECRET"
        configuration.BasePath = "https://api-sandbox.transferzero.com/v1"

        Dim debitsApi As AccountDebitsApi = New AccountDebitsApi(configuration)

        Dim apiInstance = new LogsApi(configuration)
        Dim page = 1 REM int? | The page number to request (defaults to 1) (optional) 
        Dim per = 10 REM int? | The number of results to load per page (defaults to 10) (optional) 
        Dim createdAtFrom = createdAtFrom_example REM string | Start date to filter recipients by created_at range Allows filtering results by the specified `created_at` timeframe.  Example: `/v1/recipients?created_at_from=2018-06-06&created_at_to=2018-06-08` (optional) 
        Dim createdAtTo = createdAtTo_example REM string | End date to filter recipients by created_at range Allows filtering results by the specified `created_at` timeframe.  Example: `/v1/recipients?created_at_from=2018-06-06&created_at_to=2018-06-08` (optional) 


        Try
            REM Fetch a list of webhook logs
            Dim result As WebhookLogListResponse = apiInstance.GetWebhookLogs(page, per, createdAtFrom, createdAtTo)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as WebhookLogListResponse = e.ParseObject(Of WebhookLogListResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling LogsApi.GetWebhookLogs: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| The page number to request (defaults to 1) | [optional] 
 **per** | **int?**| The number of results to load per page (defaults to 10) | [optional] 
 **createdAtFrom** | **string**| Start date to filter recipients by created_at range Allows filtering results by the specified &#x60;created_at&#x60; timeframe.  Example: &#x60;/v1/recipients?created_at_from&#x3D;2018-06-06&amp;created_at_to&#x3D;2018-06-08&#x60; | [optional] 
 **createdAtTo** | **string**| End date to filter recipients by created_at range Allows filtering results by the specified &#x60;created_at&#x60; timeframe.  Example: &#x60;/v1/recipients?created_at_from&#x3D;2018-06-06&amp;created_at_to&#x3D;2018-06-08&#x60; | [optional] 

### Return type

[**WebhookLogListResponse**](WebhookLogListResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

