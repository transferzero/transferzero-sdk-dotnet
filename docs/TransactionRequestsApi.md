# TransferZero.Sdk.Api.TransactionRequestsApi

All URIs are relative to *https://api-sandbox.bitpesa.co/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddDocumentTransactionRequest**](TransactionRequestsApi.md#adddocumenttransactionrequest) | **POST** /transaction_requests/{Transaction Request ID}/add_document | Adding a document to a transaction request (deprecated)
[**CancelTransactionRequest**](TransactionRequestsApi.md#canceltransactionrequest) | **POST** /transaction_requests/{Transaction Request ID}/cancel | Cancelling a transaction request
[**ConfirmTransactionRequest**](TransactionRequestsApi.md#confirmtransactionrequest) | **POST** /transaction_requests/{Transaction Request ID}/confirm | Confirming a transaction request
[**GetTransactionRequest**](TransactionRequestsApi.md#gettransactionrequest) | **GET** /transaction_requests/{Transaction Request ID} | Fetching a transaction request
[**GetTransactionRequests**](TransactionRequestsApi.md#gettransactionrequests) | **GET** /transaction_requests | Listing transaction requests
[**PostTransactionRequest**](TransactionRequestsApi.md#posttransactionrequest) | **POST** /transaction_requests | Creating a transaction request
[**RestfulAddDocumentTransactionRequest**](TransactionRequestsApi.md#restfuladddocumenttransactionrequest) | **POST** /transaction_requests/{Transaction Request ID}/documents/{Document ID}/add | Adding a document to a transaction request
[**TransactionRequestLimits**](TransactionRequestsApi.md#transactionrequestlimits) | **GET** /transaction_requests/limits | Specifies the limits for transaction requests
[**ValidateTransactionRequests**](TransactionRequestsApi.md#validatetransactionrequests) | **POST** /transaction_requests/validate | Validates a transaction request payload


<a name="adddocumenttransactionrequest"></a>
# **AddDocumentTransactionRequest**
> DocumentResponse AddDocumentTransactionRequest (Guid? transactionRequestID, Guid? documentId)

Adding a document to a transaction request (deprecated)

Adds a new document to a transaction request 

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
    public class AddDocumentTransactionRequestExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new TransactionRequestsApi(configuration);
            var transactionRequestID = new Guid?(); // Guid? | ID of the transaction request to add the document.  Example: `/v1/info/transaction_requests/bf9ff782-e182-45ac-abea-5bce83ad6670/add_document?document_id=26ec8517-2f0d-48c0-b74f-0bccb9ab3a87`
            var documentId = new Guid?(); // Guid? | The ID of the document to be added to the transaction request.  Example: `/v1/info/transaction_requests/bf9ff782-e182-45ac-abea-5bce83ad6670/add_document?document_id=26ec8517-2f0d-48c0-b74f-0bccb9ab3a87`

            try {
                // Adding a document to a transaction request (deprecated)
                DocumentResponse result = apiInstance.AddDocumentTransactionRequest(transactionRequestID, documentId);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    DocumentResponse result = e.ParseObject<DocumentResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling TransactionRequestsApi.AddDocumentTransactionRequest: " + e.Message );
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

        Dim apiInstance = new TransactionRequestsApi(configuration)
        Dim transactionRequestID = new Guid?() REM Guid? | ID of the transaction request to add the document.  Example: `/v1/info/transaction_requests/bf9ff782-e182-45ac-abea-5bce83ad6670/add_document?document_id=26ec8517-2f0d-48c0-b74f-0bccb9ab3a87`
        Dim documentId = new Guid?() REM Guid? | The ID of the document to be added to the transaction request.  Example: `/v1/info/transaction_requests/bf9ff782-e182-45ac-abea-5bce83ad6670/add_document?document_id=26ec8517-2f0d-48c0-b74f-0bccb9ab3a87`


        Try
            REM Adding a document to a transaction request (deprecated)
            Dim result As DocumentResponse = apiInstance.AddDocumentTransactionRequest(transactionRequestID, documentId)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as DocumentResponse = e.ParseObject(Of DocumentResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling TransactionRequestsApi.AddDocumentTransactionRequest: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transactionRequestID** | [**Guid?**](Guid?.md)| ID of the transaction request to add the document.  Example: &#x60;/v1/info/transaction_requests/bf9ff782-e182-45ac-abea-5bce83ad6670/add_document?document_id&#x3D;26ec8517-2f0d-48c0-b74f-0bccb9ab3a87&#x60; | 
 **documentId** | [**Guid?**](Guid?.md)| The ID of the document to be added to the transaction request.  Example: &#x60;/v1/info/transaction_requests/bf9ff782-e182-45ac-abea-5bce83ad6670/add_document?document_id&#x3D;26ec8517-2f0d-48c0-b74f-0bccb9ab3a87&#x60; | 

### Return type

[**DocumentResponse**](DocumentResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="canceltransactionrequest"></a>
# **CancelTransactionRequest**
> TransactionReqResponse CancelTransactionRequest (Guid? transactionRequestID, string reasonCancellation)

Cancelling a transaction request

Cancels a transaction request 

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
    public class CancelTransactionRequestExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new TransactionRequestsApi(configuration);
            var transactionRequestID = new Guid?(); // Guid? | ID of the transaction request to cancel.  Example: `/v1/transaction_requests/bf9ff782-e182-45ac-abea-5bce83ad6670/cancel`
            var reasonCancellation = reasonCancellation_example;  // string | Reason for the transaction request to cancel.  Example: `Not enough funds`

            try {
                // Cancelling a transaction request
                TransactionReqResponse result = apiInstance.CancelTransactionRequest(transactionRequestID, reasonCancellation);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    TransactionReqResponse result = e.ParseObject<TransactionReqResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling TransactionRequestsApi.CancelTransactionRequest: " + e.Message );
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

        Dim apiInstance = new TransactionRequestsApi(configuration)
        Dim transactionRequestID = new Guid?() REM Guid? | ID of the transaction request to cancel.  Example: `/v1/transaction_requests/bf9ff782-e182-45ac-abea-5bce83ad6670/cancel`
        Dim reasonCancellation = reasonCancellation_example REM string | Reason for the transaction request to cancel.  Example: `Not enough funds`


        Try
            REM Cancelling a transaction request
            Dim result As TransactionReqResponse = apiInstance.CancelTransactionRequest(transactionRequestID, reasonCancellation)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as TransactionReqResponse = e.ParseObject(Of TransactionReqResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling TransactionRequestsApi.CancelTransactionRequest: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transactionRequestID** | [**Guid?**](Guid?.md)| ID of the transaction request to cancel.  Example: &#x60;/v1/transaction_requests/bf9ff782-e182-45ac-abea-5bce83ad6670/cancel&#x60; | 
 **reasonCancellation** | **string**| Reason for the transaction request to cancel.  Example: &#x60;Not enough funds&#x60; | 

### Return type

[**TransactionReqResponse**](TransactionReqResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="confirmtransactionrequest"></a>
# **ConfirmTransactionRequest**
> TransactionReqResponse ConfirmTransactionRequest (Guid? transactionRequestID)

Confirming a transaction request

Confirms a new transaction request 

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
    public class ConfirmTransactionRequestExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new TransactionRequestsApi(configuration);
            var transactionRequestID = new Guid?(); // Guid? | ID of the transaction request to confirm.  Example: `/v1/transaction_requests/bf9ff782-e182-45ac-abea-5bce83ad6670/confirm`

            try {
                // Confirming a transaction request
                TransactionReqResponse result = apiInstance.ConfirmTransactionRequest(transactionRequestID);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    TransactionReqResponse result = e.ParseObject<TransactionReqResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling TransactionRequestsApi.ConfirmTransactionRequest: " + e.Message );
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

        Dim apiInstance = new TransactionRequestsApi(configuration)
        Dim transactionRequestID = new Guid?() REM Guid? | ID of the transaction request to confirm.  Example: `/v1/transaction_requests/bf9ff782-e182-45ac-abea-5bce83ad6670/confirm`


        Try
            REM Confirming a transaction request
            Dim result As TransactionReqResponse = apiInstance.ConfirmTransactionRequest(transactionRequestID)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as TransactionReqResponse = e.ParseObject(Of TransactionReqResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling TransactionRequestsApi.ConfirmTransactionRequest: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transactionRequestID** | [**Guid?**](Guid?.md)| ID of the transaction request to confirm.  Example: &#x60;/v1/transaction_requests/bf9ff782-e182-45ac-abea-5bce83ad6670/confirm&#x60; | 

### Return type

[**TransactionReqResponse**](TransactionReqResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransactionrequest"></a>
# **GetTransactionRequest**
> TransactionReqResponse GetTransactionRequest (Guid? transactionRequestID, bool? versioned = null)

Fetching a transaction request

Returns a single transaction request by the Transaction Request ID

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
    public class GetTransactionRequestExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new TransactionRequestsApi(configuration);
            var transactionRequestID = new Guid?(); // Guid? | ID of the transaction request to get.  Example: `/v1/transaction_requests/bf9ff782-e182-45ac-abea-5bce83ad6670`
            var versioned = true;  // bool? | If false is passed, returns a Transaction request containing a not cached Transaction object  Example: `/v1/transaction_requests/bf9ff782-e182-45ac-abea-5bce83ad6670?versioned=false` (optional) 

            try {
                // Fetching a transaction request
                TransactionReqResponse result = apiInstance.GetTransactionRequest(transactionRequestID, versioned);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    TransactionReqResponse result = e.ParseObject<TransactionReqResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling TransactionRequestsApi.GetTransactionRequest: " + e.Message );
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

        Dim apiInstance = new TransactionRequestsApi(configuration)
        Dim transactionRequestID = new Guid?() REM Guid? | ID of the transaction request to get.  Example: `/v1/transaction_requests/bf9ff782-e182-45ac-abea-5bce83ad6670`
        Dim versioned = true REM bool? | If false is passed, returns a Transaction request containing a not cached Transaction object  Example: `/v1/transaction_requests/bf9ff782-e182-45ac-abea-5bce83ad6670?versioned=false` (optional) 


        Try
            REM Fetching a transaction request
            Dim result As TransactionReqResponse = apiInstance.GetTransactionRequest(transactionRequestID, versioned)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as TransactionReqResponse = e.ParseObject(Of TransactionReqResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling TransactionRequestsApi.GetTransactionRequest: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transactionRequestID** | [**Guid?**](Guid?.md)| ID of the transaction request to get.  Example: &#x60;/v1/transaction_requests/bf9ff782-e182-45ac-abea-5bce83ad6670&#x60; | 
 **versioned** | **bool?**| If false is passed, returns a Transaction request containing a not cached Transaction object  Example: &#x60;/v1/transaction_requests/bf9ff782-e182-45ac-abea-5bce83ad6670?versioned&#x3D;false&#x60; | [optional] 

### Return type

[**TransactionReqResponse**](TransactionReqResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransactionrequests"></a>
# **GetTransactionRequests**
> TransactionReqListResponse GetTransactionRequests (int? page = null, int? per = null, List<string> state = null, List<string> currency = null, string createdAtFrom = null, string createdAtTo = null, string amountFrom = null, string amountTo = null, string senderId = null, bool? versioned = null, List<string> tag = null, List<string> ids = null, List<string> included = null, List<string> excluded = null)

Listing transaction requests

Get a list of transaction requests

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
    public class GetTransactionRequestsExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new TransactionRequestsApi(configuration);
            var page = 1;  // int? | The page number to request (defaults to 1) (optional) 
            var per = 10;  // int? | The number of results to load per page (defaults to 10) (optional) 
            var state = new List<string>(); // List<string> | Returns transaction requests with specified states.  Example: `/v1/transaction_requests?state[]=pending&state[]=modified` (optional) 
            var currency = new List<string>(); // List<string> | Returns transaction requests with specified input_currency.  Example: `/v1/transaction_requests?currency[]=USD` (optional) 
            var createdAtFrom = createdAtFrom_example;  // string | Returns transaction requests with specified created_at lower limit.  Example: `/v1/transaction_requests?created_at_from=2018-06-09` (optional) 
            var createdAtTo = createdAtTo_example;  // string | Returns transaction requests with specified created_at upper limit.  Example: `/v1/transaction_requests?created_at_to=2018-06-08` (optional) 
            var amountFrom = amountFrom_example;  // string | Returns transaction requests with specified amount lower limit.  Example: `/v1/transaction_requests?currency=NGN&amount_from=2.4319983` (optional) 
            var amountTo = amountTo_example;  // string | Returns transaction requests with specified amount upper limit.  Example: `/v1/transaction_requests?currency=NGN&amount_to=2.4319985` (optional) 
            var senderId = senderId_example;  // string | Returns transaction requests for the specified sender.  Example: `/v1/transaction_requests?sender_id=b41d3cb7-6c54-4245-85fc-8e30690eb0f7` (optional) 
            var versioned = true;  // bool? | If false is passed, returns Transaction requests containing not cached Transaction objects  Example: `/v1/transaction_requests?versioned=false` (optional) 
            var tag = new List<string>(); // List<string> | Returns transaction requests with the specified tag(s). Tags are optional labels assigned to transaction requests for organizational purposes  Example: `/v1/transaction_requests?tag[]=square` (optional) 
            var ids = new List<string>(); // List<string> | Returns transaction requests with the specified id(s). This allows the fetching of multiple transaction requests by ids for efficiency  Example: `/v1/transaction_requests?ids[]=b41d3cb7-6c54-4245-85fc-8e30690eb0f7` (optional) 
            var included = new List<string>(); // List<string> | Returns transaction requests with the specified payout currencies.  Example: `/v1/transaction_requests?included[]=KES` (optional) 
            var excluded = new List<string>(); // List<string> | Returns transaction requests without the specified payout currencies.  Example: `/v1/transaction_requests?excluded[]=KES` (optional) 

            try {
                // Listing transaction requests
                TransactionReqListResponse result = apiInstance.GetTransactionRequests(page, per, state, currency, createdAtFrom, createdAtTo, amountFrom, amountTo, senderId, versioned, tag, ids, included, excluded);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    TransactionReqListResponse result = e.ParseObject<TransactionReqListResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling TransactionRequestsApi.GetTransactionRequests: " + e.Message );
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

        Dim apiInstance = new TransactionRequestsApi(configuration)
        Dim page = 1 REM int? | The page number to request (defaults to 1) (optional) 
        Dim per = 10 REM int? | The number of results to load per page (defaults to 10) (optional) 
        Dim state = new List<string>() REM List<string> | Returns transaction requests with specified states.  Example: `/v1/transaction_requests?state[]=pending&state[]=modified` (optional) 
        Dim currency = new List<string>() REM List<string> | Returns transaction requests with specified input_currency.  Example: `/v1/transaction_requests?currency[]=USD` (optional) 
        Dim createdAtFrom = createdAtFrom_example REM string | Returns transaction requests with specified created_at lower limit.  Example: `/v1/transaction_requests?created_at_from=2018-06-09` (optional) 
        Dim createdAtTo = createdAtTo_example REM string | Returns transaction requests with specified created_at upper limit.  Example: `/v1/transaction_requests?created_at_to=2018-06-08` (optional) 
        Dim amountFrom = amountFrom_example REM string | Returns transaction requests with specified amount lower limit.  Example: `/v1/transaction_requests?currency=NGN&amount_from=2.4319983` (optional) 
        Dim amountTo = amountTo_example REM string | Returns transaction requests with specified amount upper limit.  Example: `/v1/transaction_requests?currency=NGN&amount_to=2.4319985` (optional) 
        Dim senderId = senderId_example REM string | Returns transaction requests for the specified sender.  Example: `/v1/transaction_requests?sender_id=b41d3cb7-6c54-4245-85fc-8e30690eb0f7` (optional) 
        Dim versioned = true REM bool? | If false is passed, returns Transaction requests containing not cached Transaction objects  Example: `/v1/transaction_requests?versioned=false` (optional) 
        Dim tag = new List<string>() REM List<string> | Returns transaction requests with the specified tag(s). Tags are optional labels assigned to transaction requests for organizational purposes  Example: `/v1/transaction_requests?tag[]=square` (optional) 
        Dim ids = new List<string>() REM List<string> | Returns transaction requests with the specified id(s). This allows the fetching of multiple transaction requests by ids for efficiency  Example: `/v1/transaction_requests?ids[]=b41d3cb7-6c54-4245-85fc-8e30690eb0f7` (optional) 
        Dim included = new List<string>() REM List<string> | Returns transaction requests with the specified payout currencies.  Example: `/v1/transaction_requests?included[]=KES` (optional) 
        Dim excluded = new List<string>() REM List<string> | Returns transaction requests without the specified payout currencies.  Example: `/v1/transaction_requests?excluded[]=KES` (optional) 


        Try
            REM Listing transaction requests
            Dim result As TransactionReqListResponse = apiInstance.GetTransactionRequests(page, per, state, currency, createdAtFrom, createdAtTo, amountFrom, amountTo, senderId, versioned, tag, ids, included, excluded)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as TransactionReqListResponse = e.ParseObject(Of TransactionReqListResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling TransactionRequestsApi.GetTransactionRequests: " + e.Message )
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
 **state** | [**List&lt;string&gt;**](string.md)| Returns transaction requests with specified states.  Example: &#x60;/v1/transaction_requests?state[]&#x3D;pending&amp;state[]&#x3D;modified&#x60; | [optional] 
 **currency** | [**List&lt;string&gt;**](string.md)| Returns transaction requests with specified input_currency.  Example: &#x60;/v1/transaction_requests?currency[]&#x3D;USD&#x60; | [optional] 
 **createdAtFrom** | **string**| Returns transaction requests with specified created_at lower limit.  Example: &#x60;/v1/transaction_requests?created_at_from&#x3D;2018-06-09&#x60; | [optional] 
 **createdAtTo** | **string**| Returns transaction requests with specified created_at upper limit.  Example: &#x60;/v1/transaction_requests?created_at_to&#x3D;2018-06-08&#x60; | [optional] 
 **amountFrom** | **string**| Returns transaction requests with specified amount lower limit.  Example: &#x60;/v1/transaction_requests?currency&#x3D;NGN&amp;amount_from&#x3D;2.4319983&#x60; | [optional] 
 **amountTo** | **string**| Returns transaction requests with specified amount upper limit.  Example: &#x60;/v1/transaction_requests?currency&#x3D;NGN&amp;amount_to&#x3D;2.4319985&#x60; | [optional] 
 **senderId** | **string**| Returns transaction requests for the specified sender.  Example: &#x60;/v1/transaction_requests?sender_id&#x3D;b41d3cb7-6c54-4245-85fc-8e30690eb0f7&#x60; | [optional] 
 **versioned** | **bool?**| If false is passed, returns Transaction requests containing not cached Transaction objects  Example: &#x60;/v1/transaction_requests?versioned&#x3D;false&#x60; | [optional] 
 **tag** | [**List&lt;string&gt;**](string.md)| Returns transaction requests with the specified tag(s). Tags are optional labels assigned to transaction requests for organizational purposes  Example: &#x60;/v1/transaction_requests?tag[]&#x3D;square&#x60; | [optional] 
 **ids** | [**List&lt;string&gt;**](string.md)| Returns transaction requests with the specified id(s). This allows the fetching of multiple transaction requests by ids for efficiency  Example: &#x60;/v1/transaction_requests?ids[]&#x3D;b41d3cb7-6c54-4245-85fc-8e30690eb0f7&#x60; | [optional] 
 **included** | [**List&lt;string&gt;**](string.md)| Returns transaction requests with the specified payout currencies.  Example: &#x60;/v1/transaction_requests?included[]&#x3D;KES&#x60; | [optional] 
 **excluded** | [**List&lt;string&gt;**](string.md)| Returns transaction requests without the specified payout currencies.  Example: &#x60;/v1/transaction_requests?excluded[]&#x3D;KES&#x60; | [optional] 

### Return type

[**TransactionReqListResponse**](TransactionReqListResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posttransactionrequest"></a>
# **PostTransactionRequest**
> TransactionReqResponse PostTransactionRequest (TransactionReqRequest transactionReqRequest)

Creating a transaction request

Creates a new transaction request 

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
    public class PostTransactionRequestExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new TransactionRequestsApi(configuration);
            var transactionReqRequest = new TransactionReqRequest(); // TransactionReqRequest | 

            try {
                // Creating a transaction request
                TransactionReqResponse result = apiInstance.PostTransactionRequest(transactionReqRequest);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    TransactionReqResponse result = e.ParseObject<TransactionReqResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling TransactionRequestsApi.PostTransactionRequest: " + e.Message );
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

        Dim apiInstance = new TransactionRequestsApi(configuration)
        Dim transactionReqRequest = new TransactionReqRequest() REM TransactionReqRequest | 


        Try
            REM Creating a transaction request
            Dim result As TransactionReqResponse = apiInstance.PostTransactionRequest(transactionReqRequest)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as TransactionReqResponse = e.ParseObject(Of TransactionReqResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling TransactionRequestsApi.PostTransactionRequest: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transactionReqRequest** | [**TransactionReqRequest**](TransactionReqRequest.md)|  | 

### Return type

[**TransactionReqResponse**](TransactionReqResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="restfuladddocumenttransactionrequest"></a>
# **RestfulAddDocumentTransactionRequest**
> DocumentResponse RestfulAddDocumentTransactionRequest (Guid? transactionRequestID, Guid? documentID)

Adding a document to a transaction request

Adds a new document to a transaction request 

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
    public class RestfulAddDocumentTransactionRequestExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new TransactionRequestsApi(configuration);
            var transactionRequestID = new Guid?(); // Guid? | ID of the transaction request to add the document.  Example: `/v1/transaction_requests/bf9ff782-e182-45ac-abea-5bce83ad6670/documents/26ec8517-2f0d-48c0-b74f-0bccb9ab3a87/add`
            var documentID = new Guid?(); // Guid? | The ID of the document to be added to the transaction request.  Example: `/v1/transaction_requests/bf9ff782-e182-45ac-abea-5bce83ad6670/documents/26ec8517-2f0d-48c0-b74f-0bccb9ab3a87/add`

            try {
                // Adding a document to a transaction request
                DocumentResponse result = apiInstance.RestfulAddDocumentTransactionRequest(transactionRequestID, documentID);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    DocumentResponse result = e.ParseObject<DocumentResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling TransactionRequestsApi.RestfulAddDocumentTransactionRequest: " + e.Message );
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

        Dim apiInstance = new TransactionRequestsApi(configuration)
        Dim transactionRequestID = new Guid?() REM Guid? | ID of the transaction request to add the document.  Example: `/v1/transaction_requests/bf9ff782-e182-45ac-abea-5bce83ad6670/documents/26ec8517-2f0d-48c0-b74f-0bccb9ab3a87/add`
        Dim documentID = new Guid?() REM Guid? | The ID of the document to be added to the transaction request.  Example: `/v1/transaction_requests/bf9ff782-e182-45ac-abea-5bce83ad6670/documents/26ec8517-2f0d-48c0-b74f-0bccb9ab3a87/add`


        Try
            REM Adding a document to a transaction request
            Dim result As DocumentResponse = apiInstance.RestfulAddDocumentTransactionRequest(transactionRequestID, documentID)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as DocumentResponse = e.ParseObject(Of DocumentResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling TransactionRequestsApi.RestfulAddDocumentTransactionRequest: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transactionRequestID** | [**Guid?**](Guid?.md)| ID of the transaction request to add the document.  Example: &#x60;/v1/transaction_requests/bf9ff782-e182-45ac-abea-5bce83ad6670/documents/26ec8517-2f0d-48c0-b74f-0bccb9ab3a87/add&#x60; | 
 **documentID** | [**Guid?**](Guid?.md)| The ID of the document to be added to the transaction request.  Example: &#x60;/v1/transaction_requests/bf9ff782-e182-45ac-abea-5bce83ad6670/documents/26ec8517-2f0d-48c0-b74f-0bccb9ab3a87/add&#x60; | 

### Return type

[**DocumentResponse**](DocumentResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="transactionrequestlimits"></a>
# **TransactionRequestLimits**
> TransactionReqLimitsResponse TransactionRequestLimits ()

Specifies the limits for transaction requests

Specifies the minimum and maximum limits for transaction requests

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
    public class TransactionRequestLimitsExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new TransactionRequestsApi(configuration);

            try {
                // Specifies the limits for transaction requests
                TransactionReqLimitsResponse result = apiInstance.TransactionRequestLimits();
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    TransactionReqLimitsResponse result = e.ParseObject<TransactionReqLimitsResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling TransactionRequestsApi.TransactionRequestLimits: " + e.Message );
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

        Dim apiInstance = new TransactionRequestsApi(configuration)


        Try
            REM Specifies the limits for transaction requests
            Dim result As TransactionReqLimitsResponse = apiInstance.TransactionRequestLimits()
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as TransactionReqLimitsResponse = e.ParseObject(Of TransactionReqLimitsResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling TransactionRequestsApi.TransactionRequestLimits: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**TransactionReqLimitsResponse**](TransactionReqLimitsResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="validatetransactionrequests"></a>
# **ValidateTransactionRequests**
> TransactionReqResponse ValidateTransactionRequests (TransactionReqRequest transactionReqRequest)

Validates a transaction request payload

Validates fields in a transaction request payload and displays invalid or missing fields

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
    public class ValidateTransactionRequestsExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new TransactionRequestsApi(configuration);
            var transactionReqRequest = new TransactionReqRequest(); // TransactionReqRequest | 

            try {
                // Validates a transaction request payload
                TransactionReqResponse result = apiInstance.ValidateTransactionRequests(transactionReqRequest);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    TransactionReqResponse result = e.ParseObject<TransactionReqResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling TransactionRequestsApi.ValidateTransactionRequests: " + e.Message );
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

        Dim apiInstance = new TransactionRequestsApi(configuration)
        Dim transactionReqRequest = new TransactionReqRequest() REM TransactionReqRequest | 


        Try
            REM Validates a transaction request payload
            Dim result As TransactionReqResponse = apiInstance.ValidateTransactionRequests(transactionReqRequest)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as TransactionReqResponse = e.ParseObject(Of TransactionReqResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling TransactionRequestsApi.ValidateTransactionRequests: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transactionReqRequest** | [**TransactionReqRequest**](TransactionReqRequest.md)|  | 

### Return type

[**TransactionReqResponse**](TransactionReqResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

