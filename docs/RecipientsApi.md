# TransferZero.Sdk.Api.RecipientsApi

All URIs are relative to *https://api-sandbox.transferzero.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteRecipient**](RecipientsApi.md#deleterecipient) | **DELETE** /recipients/{Recipient ID} | Cancelling a recipient
[**GetRecipients**](RecipientsApi.md#getrecipients) | **GET** /recipients | Getting a list of recipients with filtering
[**PatchRecipient**](RecipientsApi.md#patchrecipient) | **PATCH** /recipients/{Recipient ID} | Updating a recipient


<a name="deleterecipient"></a>
# **DeleteRecipient**
> RecipientResponse DeleteRecipient (Guid? recipientID)

Cancelling a recipient

Cancels the payment to the recipient specified in the URL path.  Please note recipients where the `may_cancel` attribute is true will be cancelled immediately. If the `may_cancel` attribute is false you can still try to cancel the recipient, however it will only gets cancelled if we will receive a confirmation from our partner that the payment has failed

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
    public class DeleteRecipientExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new RecipientsApi(configuration);
            var recipientID = new Guid?(); // Guid? | ID of recipient to cancel.  Example: `/v1/recipients/9d4d7b73-a94c-4979-ab57-09074fd55d33`

            try {
                // Cancelling a recipient
                RecipientResponse result = apiInstance.DeleteRecipient(recipientID);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    RecipientResponse result = e.ParseObject<RecipientResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling RecipientsApi.DeleteRecipient: " + e.Message );
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

        Dim apiInstance = new RecipientsApi(configuration)
        Dim recipientID = new Guid?() REM Guid? | ID of recipient to cancel.  Example: `/v1/recipients/9d4d7b73-a94c-4979-ab57-09074fd55d33`


        Try
            REM Cancelling a recipient
            Dim result As RecipientResponse = apiInstance.DeleteRecipient(recipientID)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as RecipientResponse = e.ParseObject(Of RecipientResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling RecipientsApi.DeleteRecipient: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **recipientID** | [**Guid?**](Guid?.md)| ID of recipient to cancel.  Example: &#x60;/v1/recipients/9d4d7b73-a94c-4979-ab57-09074fd55d33&#x60; | 

### Return type

[**RecipientResponse**](RecipientResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getrecipients"></a>
# **GetRecipients**
> RecipientListResponse GetRecipients (int? page = null, int? per = null, string createdAtFrom = null, string createdAtTo = null, string amountFrom = null, string amountTo = null, List<string> state = null, List<string> currency = null)

Getting a list of recipients with filtering

Fetches details of all recipients.

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
    public class GetRecipientsExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new RecipientsApi(configuration);
            var page = 1;  // int? | The page number to request (defaults to 1) (optional) 
            var per = 10;  // int? | The number of results to load per page (defaults to 10) (optional) 
            var createdAtFrom = createdAtFrom_example;  // string | Start date to filter recipients by created_at range Allows filtering results by the specified `created_at` timeframe.  Example: `/v1/recipients?created_at_from=2018-06-06&created_at_to=2018-06-08` (optional) 
            var createdAtTo = createdAtTo_example;  // string | End date to filter recipients by created_at range Allows filtering results by the specified `created_at` timeframe.  Example: `/v1/recipients?created_at_from=2018-06-06&created_at_to=2018-06-08` (optional) 
            var amountFrom = amountFrom_example;  // string | Minimum amount to filter recipients by amount range.  Allows filtering results by the specified `amount` range. When using this filter, the `currency` should also be specified.  Example: `/v1/recipients?currency=NGN&amount_from=83.76672339&amount_to=83.76672339` (optional) 
            var amountTo = amountTo_example;  // string | Max amount to filter recipients by amount range.  Allows filtering results by the specified `amount` range. When using this filter, the `currency` should also be specified.  Example: `/v1/recipients?currency=NGN&amount_from=83.76672339&amount_to=83.76672339` (optional) 
            var state = new List<string>(); // List<string> | Allows filtering results by `state` of recipient. See [API Documentation - Recipient state](https://docs.transferzero.com/docs/transaction-flow/#state) for possible states.  Example: `/v1/recipients?state[]=error&state[]=initial` (optional) 
            var currency = new List<string>(); // List<string> | Allows filtering results by `input_currency`.  Additionally required when filtering by an amount range Example: `/v1/recipients?currency[]=KES&currency[]=NGN` (optional) 

            try {
                // Getting a list of recipients with filtering
                RecipientListResponse result = apiInstance.GetRecipients(page, per, createdAtFrom, createdAtTo, amountFrom, amountTo, state, currency);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    RecipientListResponse result = e.ParseObject<RecipientListResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling RecipientsApi.GetRecipients: " + e.Message );
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

        Dim apiInstance = new RecipientsApi(configuration)
        Dim page = 1 REM int? | The page number to request (defaults to 1) (optional) 
        Dim per = 10 REM int? | The number of results to load per page (defaults to 10) (optional) 
        Dim createdAtFrom = createdAtFrom_example REM string | Start date to filter recipients by created_at range Allows filtering results by the specified `created_at` timeframe.  Example: `/v1/recipients?created_at_from=2018-06-06&created_at_to=2018-06-08` (optional) 
        Dim createdAtTo = createdAtTo_example REM string | End date to filter recipients by created_at range Allows filtering results by the specified `created_at` timeframe.  Example: `/v1/recipients?created_at_from=2018-06-06&created_at_to=2018-06-08` (optional) 
        Dim amountFrom = amountFrom_example REM string | Minimum amount to filter recipients by amount range.  Allows filtering results by the specified `amount` range. When using this filter, the `currency` should also be specified.  Example: `/v1/recipients?currency=NGN&amount_from=83.76672339&amount_to=83.76672339` (optional) 
        Dim amountTo = amountTo_example REM string | Max amount to filter recipients by amount range.  Allows filtering results by the specified `amount` range. When using this filter, the `currency` should also be specified.  Example: `/v1/recipients?currency=NGN&amount_from=83.76672339&amount_to=83.76672339` (optional) 
        Dim state = new List<string>() REM List<string> | Allows filtering results by `state` of recipient. See [API Documentation - Recipient state](https://docs.transferzero.com/docs/transaction-flow/#state) for possible states.  Example: `/v1/recipients?state[]=error&state[]=initial` (optional) 
        Dim currency = new List<string>() REM List<string> | Allows filtering results by `input_currency`.  Additionally required when filtering by an amount range Example: `/v1/recipients?currency[]=KES&currency[]=NGN` (optional) 


        Try
            REM Getting a list of recipients with filtering
            Dim result As RecipientListResponse = apiInstance.GetRecipients(page, per, createdAtFrom, createdAtTo, amountFrom, amountTo, state, currency)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as RecipientListResponse = e.ParseObject(Of RecipientListResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling RecipientsApi.GetRecipients: " + e.Message )
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
 **amountFrom** | **string**| Minimum amount to filter recipients by amount range.  Allows filtering results by the specified &#x60;amount&#x60; range. When using this filter, the &#x60;currency&#x60; should also be specified.  Example: &#x60;/v1/recipients?currency&#x3D;NGN&amp;amount_from&#x3D;83.76672339&amp;amount_to&#x3D;83.76672339&#x60; | [optional] 
 **amountTo** | **string**| Max amount to filter recipients by amount range.  Allows filtering results by the specified &#x60;amount&#x60; range. When using this filter, the &#x60;currency&#x60; should also be specified.  Example: &#x60;/v1/recipients?currency&#x3D;NGN&amp;amount_from&#x3D;83.76672339&amp;amount_to&#x3D;83.76672339&#x60; | [optional] 
 **state** | [**List&lt;string&gt;**](string.md)| Allows filtering results by &#x60;state&#x60; of recipient. See [API Documentation - Recipient state](https://docs.transferzero.com/docs/transaction-flow/#state) for possible states.  Example: &#x60;/v1/recipients?state[]&#x3D;error&amp;state[]&#x3D;initial&#x60; | [optional] 
 **currency** | [**List&lt;string&gt;**](string.md)| Allows filtering results by &#x60;input_currency&#x60;.  Additionally required when filtering by an amount range Example: &#x60;/v1/recipients?currency[]&#x3D;KES&amp;currency[]&#x3D;NGN&#x60; | [optional] 

### Return type

[**RecipientListResponse**](RecipientListResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchrecipient"></a>
# **PatchRecipient**
> RecipientResponse PatchRecipient (Guid? recipientID, RecipientRequest recipientRequest)

Updating a recipient

Updates the recipient specified in the URL path.  Please note that only recipients where the `editable` field is true can be modified. Once the recipient is modified any subsequent payout tries will be sent to the updated details.

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
    public class PatchRecipientExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new RecipientsApi(configuration);
            var recipientID = new Guid?(); // Guid? | ID of recipient to update.  Example: `/v1/recipients/9d4d7b73-a94c-4979-ab57-09074fd55d33`
            var recipientRequest = new RecipientRequest(); // RecipientRequest | 

            try {
                // Updating a recipient
                RecipientResponse result = apiInstance.PatchRecipient(recipientID, recipientRequest);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    RecipientResponse result = e.ParseObject<RecipientResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling RecipientsApi.PatchRecipient: " + e.Message );
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

        Dim apiInstance = new RecipientsApi(configuration)
        Dim recipientID = new Guid?() REM Guid? | ID of recipient to update.  Example: `/v1/recipients/9d4d7b73-a94c-4979-ab57-09074fd55d33`
        Dim recipientRequest = new RecipientRequest() REM RecipientRequest | 


        Try
            REM Updating a recipient
            Dim result As RecipientResponse = apiInstance.PatchRecipient(recipientID, recipientRequest)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as RecipientResponse = e.ParseObject(Of RecipientResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling RecipientsApi.PatchRecipient: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **recipientID** | [**Guid?**](Guid?.md)| ID of recipient to update.  Example: &#x60;/v1/recipients/9d4d7b73-a94c-4979-ab57-09074fd55d33&#x60; | 
 **recipientRequest** | [**RecipientRequest**](RecipientRequest.md)|  | 

### Return type

[**RecipientResponse**](RecipientResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

