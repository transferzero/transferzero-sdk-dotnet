# TransferZero.Sdk.Api.SendersApi

All URIs are relative to *https://api-sandbox.bitpesa.co/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ConfirmSenderVerification**](SendersApi.md#confirmsenderverification) | **POST** /senders/{Sender ID}/confirm_verification | Change sender onboarding state to &#39;profile_completed&#39;
[**DeleteSender**](SendersApi.md#deletesender) | **DELETE** /senders/{Sender ID} | Deleting a sender
[**GetSender**](SendersApi.md#getsender) | **GET** /senders/{Sender ID} | Fetching a sender
[**GetSenders**](SendersApi.md#getsenders) | **GET** /senders | Listing senders
[**PatchSender**](SendersApi.md#patchsender) | **PATCH** /senders/{Sender ID} | Updating a sender
[**PostSenders**](SendersApi.md#postsenders) | **POST** /senders | Creating a sender


<a name="confirmsenderverification"></a>
# **ConfirmSenderVerification**
> SenderResponse ConfirmSenderVerification (Guid? senderID)

Change sender onboarding state to 'profile_completed'

Transition sender to the 'profile_completed' onboarding state. This will only work if the sender has all the required documents uploaded and profile information present. 

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
    public class ConfirmSenderVerificationExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new SendersApi(configuration);
            var senderID = new Guid?(); // Guid? | ID of the sender to get.  Example: `/v1/senders/bf9ff782-e182-45ac-abea-5bce83ad6670/confirm_verification`

            try {
                // Change sender onboarding state to 'profile_completed'
                SenderResponse result = apiInstance.ConfirmSenderVerification(senderID);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    SenderResponse result = e.ParseObject<SenderResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling SendersApi.ConfirmSenderVerification: " + e.Message );
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

        Dim apiInstance = new SendersApi(configuration)
        Dim senderID = new Guid?() REM Guid? | ID of the sender to get.  Example: `/v1/senders/bf9ff782-e182-45ac-abea-5bce83ad6670/confirm_verification`


        Try
            REM Change sender onboarding state to 'profile_completed'
            Dim result As SenderResponse = apiInstance.ConfirmSenderVerification(senderID)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as SenderResponse = e.ParseObject(Of SenderResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling SendersApi.ConfirmSenderVerification: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **senderID** | [**Guid?**](Guid?.md)| ID of the sender to get.  Example: &#x60;/v1/senders/bf9ff782-e182-45ac-abea-5bce83ad6670/confirm_verification&#x60; | 

### Return type

[**SenderResponse**](SenderResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletesender"></a>
# **DeleteSender**
> SenderResponse DeleteSender (Guid? senderID)

Deleting a sender

Deletes a single sender by the Sender ID

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
    public class DeleteSenderExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new SendersApi(configuration);
            var senderID = new Guid?(); // Guid? | ID of the sender to delete.  Example: `/v1/senders/bf9ff782-e182-45ac-abea-5bce83ad6670`

            try {
                // Deleting a sender
                SenderResponse result = apiInstance.DeleteSender(senderID);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    SenderResponse result = e.ParseObject<SenderResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling SendersApi.DeleteSender: " + e.Message );
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

        Dim apiInstance = new SendersApi(configuration)
        Dim senderID = new Guid?() REM Guid? | ID of the sender to delete.  Example: `/v1/senders/bf9ff782-e182-45ac-abea-5bce83ad6670`


        Try
            REM Deleting a sender
            Dim result As SenderResponse = apiInstance.DeleteSender(senderID)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as SenderResponse = e.ParseObject(Of SenderResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling SendersApi.DeleteSender: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **senderID** | [**Guid?**](Guid?.md)| ID of the sender to delete.  Example: &#x60;/v1/senders/bf9ff782-e182-45ac-abea-5bce83ad6670&#x60; | 

### Return type

[**SenderResponse**](SenderResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsender"></a>
# **GetSender**
> SenderResponse GetSender (Guid? senderID)

Fetching a sender

Returns a single sender by the Sender ID

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
    public class GetSenderExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new SendersApi(configuration);
            var senderID = new Guid?(); // Guid? | ID of the sender to get.  Example: `/v1/senders/bf9ff782-e182-45ac-abea-5bce83ad6670`

            try {
                // Fetching a sender
                SenderResponse result = apiInstance.GetSender(senderID);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    SenderResponse result = e.ParseObject<SenderResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling SendersApi.GetSender: " + e.Message );
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

        Dim apiInstance = new SendersApi(configuration)
        Dim senderID = new Guid?() REM Guid? | ID of the sender to get.  Example: `/v1/senders/bf9ff782-e182-45ac-abea-5bce83ad6670`


        Try
            REM Fetching a sender
            Dim result As SenderResponse = apiInstance.GetSender(senderID)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as SenderResponse = e.ParseObject(Of SenderResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling SendersApi.GetSender: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **senderID** | [**Guid?**](Guid?.md)| ID of the sender to get.  Example: &#x60;/v1/senders/bf9ff782-e182-45ac-abea-5bce83ad6670&#x60; | 

### Return type

[**SenderResponse**](SenderResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsenders"></a>
# **GetSenders**
> SenderListResponse GetSenders (int? page = null, int? per = null, string createdAtFrom = null, string createdAtTo = null, string externalId = null)

Listing senders

Get a list of available senders

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
    public class GetSendersExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new SendersApi(configuration);
            var page = 1;  // int? | The page number to request (defaults to 1) (optional) 
            var per = 10;  // int? | The number of results to load per page (defaults to 10) (optional) 
            var createdAtFrom = createdAtFrom_example;  // string | Start date to filter recipients by created_at range Allows filtering results by the specified `created_at` timeframe.  Example: `/v1/recipients?created_at_from=2018-06-06&created_at_to=2018-06-08` (optional) 
            var createdAtTo = createdAtTo_example;  // string | End date to filter recipients by created_at range Allows filtering results by the specified `created_at` timeframe.  Example: `/v1/recipients?created_at_from=2018-06-06&created_at_to=2018-06-08` (optional) 
            var externalId = externalId_example;  // string | Allows filtering results by `external_id`.  Example: `/v1/senders?external_id=26ec8517-2f0d-48c0-b74f-0bccb9ab3a87` (optional) 

            try {
                // Listing senders
                SenderListResponse result = apiInstance.GetSenders(page, per, createdAtFrom, createdAtTo, externalId);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    SenderListResponse result = e.ParseObject<SenderListResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling SendersApi.GetSenders: " + e.Message );
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

        Dim apiInstance = new SendersApi(configuration)
        Dim page = 1 REM int? | The page number to request (defaults to 1) (optional) 
        Dim per = 10 REM int? | The number of results to load per page (defaults to 10) (optional) 
        Dim createdAtFrom = createdAtFrom_example REM string | Start date to filter recipients by created_at range Allows filtering results by the specified `created_at` timeframe.  Example: `/v1/recipients?created_at_from=2018-06-06&created_at_to=2018-06-08` (optional) 
        Dim createdAtTo = createdAtTo_example REM string | End date to filter recipients by created_at range Allows filtering results by the specified `created_at` timeframe.  Example: `/v1/recipients?created_at_from=2018-06-06&created_at_to=2018-06-08` (optional) 
        Dim externalId = externalId_example REM string | Allows filtering results by `external_id`.  Example: `/v1/senders?external_id=26ec8517-2f0d-48c0-b74f-0bccb9ab3a87` (optional) 


        Try
            REM Listing senders
            Dim result As SenderListResponse = apiInstance.GetSenders(page, per, createdAtFrom, createdAtTo, externalId)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as SenderListResponse = e.ParseObject(Of SenderListResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling SendersApi.GetSenders: " + e.Message )
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
 **externalId** | **string**| Allows filtering results by &#x60;external_id&#x60;.  Example: &#x60;/v1/senders?external_id&#x3D;26ec8517-2f0d-48c0-b74f-0bccb9ab3a87&#x60; | [optional] 

### Return type

[**SenderListResponse**](SenderListResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchsender"></a>
# **PatchSender**
> SenderResponse PatchSender (Guid? senderID, SenderRequest senderRequest)

Updating a sender

Updates a single sender by the Sender ID

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
    public class PatchSenderExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new SendersApi(configuration);
            var senderID = new Guid?(); // Guid? | ID of the sender to get.  Example: `/v1/senders/bf9ff782-e182-45ac-abea-5bce83ad6670`
            var senderRequest = new SenderRequest(); // SenderRequest | 

            try {
                // Updating a sender
                SenderResponse result = apiInstance.PatchSender(senderID, senderRequest);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    SenderResponse result = e.ParseObject<SenderResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling SendersApi.PatchSender: " + e.Message );
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

        Dim apiInstance = new SendersApi(configuration)
        Dim senderID = new Guid?() REM Guid? | ID of the sender to get.  Example: `/v1/senders/bf9ff782-e182-45ac-abea-5bce83ad6670`
        Dim senderRequest = new SenderRequest() REM SenderRequest | 


        Try
            REM Updating a sender
            Dim result As SenderResponse = apiInstance.PatchSender(senderID, senderRequest)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as SenderResponse = e.ParseObject(Of SenderResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling SendersApi.PatchSender: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **senderID** | [**Guid?**](Guid?.md)| ID of the sender to get.  Example: &#x60;/v1/senders/bf9ff782-e182-45ac-abea-5bce83ad6670&#x60; | 
 **senderRequest** | [**SenderRequest**](SenderRequest.md)|  | 

### Return type

[**SenderResponse**](SenderResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postsenders"></a>
# **PostSenders**
> SenderResponse PostSenders (SenderRequest senderRequest)

Creating a sender

Creates a new sender in our system. 

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
    public class PostSendersExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new SendersApi(configuration);
            var senderRequest = new SenderRequest(); // SenderRequest | 

            try {
                // Creating a sender
                SenderResponse result = apiInstance.PostSenders(senderRequest);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    SenderResponse result = e.ParseObject<SenderResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling SendersApi.PostSenders: " + e.Message );
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

        Dim apiInstance = new SendersApi(configuration)
        Dim senderRequest = new SenderRequest() REM SenderRequest | 


        Try
            REM Creating a sender
            Dim result As SenderResponse = apiInstance.PostSenders(senderRequest)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as SenderResponse = e.ParseObject(Of SenderResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling SendersApi.PostSenders: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **senderRequest** | [**SenderRequest**](SenderRequest.md)|  | 

### Return type

[**SenderResponse**](SenderResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

