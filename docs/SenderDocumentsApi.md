# TransferZero.Sdk.Api.SenderDocumentsApi

All URIs are relative to *https://api-sandbox.bitpesa.co/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddDocumentSender**](SenderDocumentsApi.md#adddocumentsender) | **POST** /senders/{Sender ID}/documents/{Document ID}/add | Adding a document to a sender
[**GetSenderDocument**](SenderDocumentsApi.md#getsenderdocument) | **GET** /senders/{Sender ID}/documents/{Document ID} | Fetching a document belonging to a sender
[**GetSenderDocuments**](SenderDocumentsApi.md#getsenderdocuments) | **GET** /senders/{Sender ID}/documents | Getting a list of documents belonging to a sender
[**RemoveDocumentSender**](SenderDocumentsApi.md#removedocumentsender) | **POST** /senders/{Sender ID}/documents/{Document ID}/remove | Removing a document from a sender


<a name="adddocumentsender"></a>
# **AddDocumentSender**
> DocumentResponse AddDocumentSender (Guid? senderID, Guid? documentID)

Adding a document to a sender

Adds a new document to a sender 

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
    public class AddDocumentSenderExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new SenderDocumentsApi(configuration);
            var senderID = new Guid?(); // Guid? | ID of the sender to add the document.  Example: `/v1/senders/bf9ff782-e182-45ac-abea-5bce83ad6670/documents/26ec8517-2f0d-48c0-b74f-0bccb9ab3a87/add`
            var documentID = new Guid?(); // Guid? | The ID of the document to be added to the sender.  Example: `/v1/senders/bf9ff782-e182-45ac-abea-5bce83ad6670/documents/26ec8517-2f0d-48c0-b74f-0bccb9ab3a87/add`

            try {
                // Adding a document to a sender
                DocumentResponse result = apiInstance.AddDocumentSender(senderID, documentID);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    DocumentResponse result = e.ParseObject<DocumentResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling SenderDocumentsApi.AddDocumentSender: " + e.Message );
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

        Dim apiInstance = new SenderDocumentsApi(configuration)
        Dim senderID = new Guid?() REM Guid? | ID of the sender to add the document.  Example: `/v1/senders/bf9ff782-e182-45ac-abea-5bce83ad6670/documents/26ec8517-2f0d-48c0-b74f-0bccb9ab3a87/add`
        Dim documentID = new Guid?() REM Guid? | The ID of the document to be added to the sender.  Example: `/v1/senders/bf9ff782-e182-45ac-abea-5bce83ad6670/documents/26ec8517-2f0d-48c0-b74f-0bccb9ab3a87/add`


        Try
            REM Adding a document to a sender
            Dim result As DocumentResponse = apiInstance.AddDocumentSender(senderID, documentID)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as DocumentResponse = e.ParseObject(Of DocumentResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling SenderDocumentsApi.AddDocumentSender: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **senderID** | [**Guid?**](Guid?.md)| ID of the sender to add the document.  Example: &#x60;/v1/senders/bf9ff782-e182-45ac-abea-5bce83ad6670/documents/26ec8517-2f0d-48c0-b74f-0bccb9ab3a87/add&#x60; | 
 **documentID** | [**Guid?**](Guid?.md)| The ID of the document to be added to the sender.  Example: &#x60;/v1/senders/bf9ff782-e182-45ac-abea-5bce83ad6670/documents/26ec8517-2f0d-48c0-b74f-0bccb9ab3a87/add&#x60; | 

### Return type

[**DocumentResponse**](DocumentResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsenderdocument"></a>
# **GetSenderDocument**
> DocumentResponse GetSenderDocument (Guid? senderID, Guid? documentID)

Fetching a document belonging to a sender

Returns a single document belonging to a sender by the Document ID

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
    public class GetSenderDocumentExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new SenderDocumentsApi(configuration);
            var senderID = new Guid?(); // Guid? | ID of the sender who owns the requested document.  Example: `/v1/senders/bf9ff782-e182-45ac-abea-5bce83ad6670/documents/26ec8517-2f0d-48c0-b74f-0bccb9ab3a87`
            var documentID = new Guid?(); // Guid? | ID of the document to get.  Example: `/v1/senders/bf9ff782-e182-45ac-abea-5bce83ad6670/documents/26ec8517-2f0d-48c0-b74f-0bccb9ab3a87`

            try {
                // Fetching a document belonging to a sender
                DocumentResponse result = apiInstance.GetSenderDocument(senderID, documentID);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    DocumentResponse result = e.ParseObject<DocumentResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling SenderDocumentsApi.GetSenderDocument: " + e.Message );
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

        Dim apiInstance = new SenderDocumentsApi(configuration)
        Dim senderID = new Guid?() REM Guid? | ID of the sender who owns the requested document.  Example: `/v1/senders/bf9ff782-e182-45ac-abea-5bce83ad6670/documents/26ec8517-2f0d-48c0-b74f-0bccb9ab3a87`
        Dim documentID = new Guid?() REM Guid? | ID of the document to get.  Example: `/v1/senders/bf9ff782-e182-45ac-abea-5bce83ad6670/documents/26ec8517-2f0d-48c0-b74f-0bccb9ab3a87`


        Try
            REM Fetching a document belonging to a sender
            Dim result As DocumentResponse = apiInstance.GetSenderDocument(senderID, documentID)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as DocumentResponse = e.ParseObject(Of DocumentResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling SenderDocumentsApi.GetSenderDocument: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **senderID** | [**Guid?**](Guid?.md)| ID of the sender who owns the requested document.  Example: &#x60;/v1/senders/bf9ff782-e182-45ac-abea-5bce83ad6670/documents/26ec8517-2f0d-48c0-b74f-0bccb9ab3a87&#x60; | 
 **documentID** | [**Guid?**](Guid?.md)| ID of the document to get.  Example: &#x60;/v1/senders/bf9ff782-e182-45ac-abea-5bce83ad6670/documents/26ec8517-2f0d-48c0-b74f-0bccb9ab3a87&#x60; | 

### Return type

[**DocumentResponse**](DocumentResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsenderdocuments"></a>
# **GetSenderDocuments**
> DocumentListResponse GetSenderDocuments (Guid? senderID, int? page = null, int? per = null)

Getting a list of documents belonging to a sender

Fetches a list of documents belonging to a sender.

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
    public class GetSenderDocumentsExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new SenderDocumentsApi(configuration);
            var senderID = new Guid?(); // Guid? | ID of the sender who owns the requested documents.  Example: `/v1/senders/bf9ff782-e182-45ac-abea-5bce83ad6670/documents`
            var page = 1;  // int? | The page number to request (defaults to 1) (optional) 
            var per = 10;  // int? | The number of results to load per page (defaults to 10) (optional) 

            try {
                // Getting a list of documents belonging to a sender
                DocumentListResponse result = apiInstance.GetSenderDocuments(senderID, page, per);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    DocumentListResponse result = e.ParseObject<DocumentListResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling SenderDocumentsApi.GetSenderDocuments: " + e.Message );
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

        Dim apiInstance = new SenderDocumentsApi(configuration)
        Dim senderID = new Guid?() REM Guid? | ID of the sender who owns the requested documents.  Example: `/v1/senders/bf9ff782-e182-45ac-abea-5bce83ad6670/documents`
        Dim page = 1 REM int? | The page number to request (defaults to 1) (optional) 
        Dim per = 10 REM int? | The number of results to load per page (defaults to 10) (optional) 


        Try
            REM Getting a list of documents belonging to a sender
            Dim result As DocumentListResponse = apiInstance.GetSenderDocuments(senderID, page, per)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as DocumentListResponse = e.ParseObject(Of DocumentListResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling SenderDocumentsApi.GetSenderDocuments: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **senderID** | [**Guid?**](Guid?.md)| ID of the sender who owns the requested documents.  Example: &#x60;/v1/senders/bf9ff782-e182-45ac-abea-5bce83ad6670/documents&#x60; | 
 **page** | **int?**| The page number to request (defaults to 1) | [optional] 
 **per** | **int?**| The number of results to load per page (defaults to 10) | [optional] 

### Return type

[**DocumentListResponse**](DocumentListResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="removedocumentsender"></a>
# **RemoveDocumentSender**
> DocumentResponse RemoveDocumentSender (Guid? senderID, Guid? documentID)

Removing a document from a sender

Removes a document from a sender 

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
    public class RemoveDocumentSenderExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new SenderDocumentsApi(configuration);
            var senderID = new Guid?(); // Guid? | ID of the sender with the document to remove.  Example: `/v1/senders/bf9ff782-e182-45ac-abea-5bce83ad6670/documents/26ec8517-2f0d-48c0-b74f-0bccb9ab3a87/remove`
            var documentID = new Guid?(); // Guid? | The ID of the document to be removed from the sender.  Example: `/v1/senders/bf9ff782-e182-45ac-abea-5bce83ad6670/documents/26ec8517-2f0d-48c0-b74f-0bccb9ab3a87/remove`

            try {
                // Removing a document from a sender
                DocumentResponse result = apiInstance.RemoveDocumentSender(senderID, documentID);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    DocumentResponse result = e.ParseObject<DocumentResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling SenderDocumentsApi.RemoveDocumentSender: " + e.Message );
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

        Dim apiInstance = new SenderDocumentsApi(configuration)
        Dim senderID = new Guid?() REM Guid? | ID of the sender with the document to remove.  Example: `/v1/senders/bf9ff782-e182-45ac-abea-5bce83ad6670/documents/26ec8517-2f0d-48c0-b74f-0bccb9ab3a87/remove`
        Dim documentID = new Guid?() REM Guid? | The ID of the document to be removed from the sender.  Example: `/v1/senders/bf9ff782-e182-45ac-abea-5bce83ad6670/documents/26ec8517-2f0d-48c0-b74f-0bccb9ab3a87/remove`


        Try
            REM Removing a document from a sender
            Dim result As DocumentResponse = apiInstance.RemoveDocumentSender(senderID, documentID)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as DocumentResponse = e.ParseObject(Of DocumentResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling SenderDocumentsApi.RemoveDocumentSender: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **senderID** | [**Guid?**](Guid?.md)| ID of the sender with the document to remove.  Example: &#x60;/v1/senders/bf9ff782-e182-45ac-abea-5bce83ad6670/documents/26ec8517-2f0d-48c0-b74f-0bccb9ab3a87/remove&#x60; | 
 **documentID** | [**Guid?**](Guid?.md)| The ID of the document to be removed from the sender.  Example: &#x60;/v1/senders/bf9ff782-e182-45ac-abea-5bce83ad6670/documents/26ec8517-2f0d-48c0-b74f-0bccb9ab3a87/remove&#x60; | 

### Return type

[**DocumentResponse**](DocumentResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

