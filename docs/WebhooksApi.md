# TransferZero.Sdk.Api.WebhooksApi

All URIs are relative to *https://api-sandbox.transferzero.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteWebhook**](WebhooksApi.md#deletewebhook) | **DELETE** /webhooks/{Webhook ID} | Unsubscribing from a webhook
[**GetWebhook**](WebhooksApi.md#getwebhook) | **GET** /webhooks/{Webhook ID} | Find a webhook&#39;s details
[**GetWebhookEvents**](WebhooksApi.md#getwebhookevents) | **GET** /webhooks/events | Find possible webhook events
[**GetWebhooks**](WebhooksApi.md#getwebhooks) | **GET** /webhooks | Listing webhooks
[**PostWebhooks**](WebhooksApi.md#postwebhooks) | **POST** /webhooks | Creating a webhook


<a name="deletewebhook"></a>
# **DeleteWebhook**
> WebhookDefinitionResponse DeleteWebhook (string webhookID)

Unsubscribing from a webhook

Unsubscribes from a webhook specified

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
    public class DeleteWebhookExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new WebhooksApi(configuration);
            var webhookID = webhookID_example;  // string | The ID of webhook to cancel.  Example: `/v1/webhooks/9d4d7b73-a94c-4979-ab57-09074fd55d33`

            try {
                // Unsubscribing from a webhook
                WebhookDefinitionResponse result = apiInstance.DeleteWebhook(webhookID);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    WebhookDefinitionResponse result = e.ParseObject<WebhookDefinitionResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling WebhooksApi.DeleteWebhook: " + e.Message );
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

        Dim apiInstance = new WebhooksApi(configuration)
        Dim webhookID = webhookID_example REM string | The ID of webhook to cancel.  Example: `/v1/webhooks/9d4d7b73-a94c-4979-ab57-09074fd55d33`


        Try
            REM Unsubscribing from a webhook
            Dim result As WebhookDefinitionResponse = apiInstance.DeleteWebhook(webhookID)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as WebhookDefinitionResponse = e.ParseObject(Of WebhookDefinitionResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling WebhooksApi.DeleteWebhook: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webhookID** | **string**| The ID of webhook to cancel.  Example: &#x60;/v1/webhooks/9d4d7b73-a94c-4979-ab57-09074fd55d33&#x60; | 

### Return type

[**WebhookDefinitionResponse**](WebhookDefinitionResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebhook"></a>
# **GetWebhook**
> WebhookDefinitionResponse GetWebhook (Guid webhookID)

Find a webhook's details

Look up a webhook's details with its ID

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
    public class GetWebhookExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new WebhooksApi(configuration);
            var webhookID = new Guid(); // Guid | The ID of the Webhook to look up  Example: `/v1/webhooks/9d4d7b73-a94c-4979-ab57-09074fd55d33`

            try {
                // Find a webhook's details
                WebhookDefinitionResponse result = apiInstance.GetWebhook(webhookID);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    WebhookDefinitionResponse result = e.ParseObject<WebhookDefinitionResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling WebhooksApi.GetWebhook: " + e.Message );
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

        Dim apiInstance = new WebhooksApi(configuration)
        Dim webhookID = new Guid() REM Guid | The ID of the Webhook to look up  Example: `/v1/webhooks/9d4d7b73-a94c-4979-ab57-09074fd55d33`


        Try
            REM Find a webhook's details
            Dim result As WebhookDefinitionResponse = apiInstance.GetWebhook(webhookID)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as WebhookDefinitionResponse = e.ParseObject(Of WebhookDefinitionResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling WebhooksApi.GetWebhook: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webhookID** | [**Guid**](Guid.md)| The ID of the Webhook to look up  Example: &#x60;/v1/webhooks/9d4d7b73-a94c-4979-ab57-09074fd55d33&#x60; | 

### Return type

[**WebhookDefinitionResponse**](WebhookDefinitionResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebhookevents"></a>
# **GetWebhookEvents**
> WebhookDefinitionEventListResponse GetWebhookEvents ()

Find possible webhook events

Fetching possible webhook events

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
    public class GetWebhookEventsExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new WebhooksApi(configuration);

            try {
                // Find possible webhook events
                WebhookDefinitionEventListResponse result = apiInstance.GetWebhookEvents();
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    WebhookDefinitionEventListResponse result = e.ParseObject<WebhookDefinitionEventListResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling WebhooksApi.GetWebhookEvents: " + e.Message );
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

        Dim apiInstance = new WebhooksApi(configuration)


        Try
            REM Find possible webhook events
            Dim result As WebhookDefinitionEventListResponse = apiInstance.GetWebhookEvents()
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as WebhookDefinitionEventListResponse = e.ParseObject(Of WebhookDefinitionEventListResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling WebhooksApi.GetWebhookEvents: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**WebhookDefinitionEventListResponse**](WebhookDefinitionEventListResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getwebhooks"></a>
# **GetWebhooks**
> WebhookDefinitionListResponse GetWebhooks (int page = null, int per = null)

Listing webhooks

Get a list of created webhooks

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
    public class GetWebhooksExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new WebhooksApi(configuration);
            var page = 1;  // int | The page number to request (defaults to 1) (optional) 
            var per = 10;  // int | The number of results to load per page (defaults to 10) (optional) 

            try {
                // Listing webhooks
                WebhookDefinitionListResponse result = apiInstance.GetWebhooks(page, per);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    WebhookDefinitionListResponse result = e.ParseObject<WebhookDefinitionListResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling WebhooksApi.GetWebhooks: " + e.Message );
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

        Dim apiInstance = new WebhooksApi(configuration)
        Dim page = 1 REM int | The page number to request (defaults to 1) (optional) 
        Dim per = 10 REM int | The number of results to load per page (defaults to 10) (optional) 


        Try
            REM Listing webhooks
            Dim result As WebhookDefinitionListResponse = apiInstance.GetWebhooks(page, per)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as WebhookDefinitionListResponse = e.ParseObject(Of WebhookDefinitionListResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling WebhooksApi.GetWebhooks: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int**| The page number to request (defaults to 1) | [optional] 
 **per** | **int**| The number of results to load per page (defaults to 10) | [optional] 

### Return type

[**WebhookDefinitionListResponse**](WebhookDefinitionListResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postwebhooks"></a>
# **PostWebhooks**
> WebhookDefinitionResponse PostWebhooks (WebhookDefinitionRequest webhookDefinitionRequest)

Creating a webhook

Creates a new webhook, subscribing the provided endpoint to the specified event(s) 

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
    public class PostWebhooksExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new WebhooksApi(configuration);
            var webhookDefinitionRequest = new WebhookDefinitionRequest(); // WebhookDefinitionRequest | 

            try {
                // Creating a webhook
                WebhookDefinitionResponse result = apiInstance.PostWebhooks(webhookDefinitionRequest);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    WebhookDefinitionResponse result = e.ParseObject<WebhookDefinitionResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling WebhooksApi.PostWebhooks: " + e.Message );
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

        Dim apiInstance = new WebhooksApi(configuration)
        Dim webhookDefinitionRequest = new WebhookDefinitionRequest() REM WebhookDefinitionRequest | 


        Try
            REM Creating a webhook
            Dim result As WebhookDefinitionResponse = apiInstance.PostWebhooks(webhookDefinitionRequest)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as WebhookDefinitionResponse = e.ParseObject(Of WebhookDefinitionResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling WebhooksApi.PostWebhooks: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **webhookDefinitionRequest** | [**WebhookDefinitionRequest**](WebhookDefinitionRequest.md)|  | 

### Return type

[**WebhookDefinitionResponse**](WebhookDefinitionResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

