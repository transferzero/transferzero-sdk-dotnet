# TransferZero.Sdk.Api.OpenCorporatesSenderUpdateApi

All URIs are relative to *https://api-sandbox.bitpesa.co/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UpdateSender**](OpenCorporatesSenderUpdateApi.md#updatesender) | **POST** /open_corporates/update_sender | Update Sender with data retrieved from Open Corporates


<a name="updatesender"></a>
# **UpdateSender**
> OpenCorporatesSenderUpdateResponse UpdateSender (OpenCorporatesSenderUpdateRequest openCorporatesSenderUpdateRequest)

Update Sender with data retrieved from Open Corporates

This endpoint searches for a company on Open Corporates API and updates the associated Sender fields with the search results

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
    public class UpdateSenderExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new OpenCorporatesSenderUpdateApi(configuration);
            var openCorporatesSenderUpdateRequest = new OpenCorporatesSenderUpdateRequest(); // OpenCorporatesSenderUpdateRequest | 

            try {
                // Update Sender with data retrieved from Open Corporates
                OpenCorporatesSenderUpdateResponse result = apiInstance.UpdateSender(openCorporatesSenderUpdateRequest);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    OpenCorporatesSenderUpdateResponse result = e.ParseObject<OpenCorporatesSenderUpdateResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling OpenCorporatesSenderUpdateApi.UpdateSender: " + e.Message );
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

        Dim apiInstance = new OpenCorporatesSenderUpdateApi(configuration)
        Dim openCorporatesSenderUpdateRequest = new OpenCorporatesSenderUpdateRequest() REM OpenCorporatesSenderUpdateRequest | 


        Try
            REM Update Sender with data retrieved from Open Corporates
            Dim result As OpenCorporatesSenderUpdateResponse = apiInstance.UpdateSender(openCorporatesSenderUpdateRequest)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as OpenCorporatesSenderUpdateResponse = e.ParseObject(Of OpenCorporatesSenderUpdateResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling OpenCorporatesSenderUpdateApi.UpdateSender: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **openCorporatesSenderUpdateRequest** | [**OpenCorporatesSenderUpdateRequest**](OpenCorporatesSenderUpdateRequest.md)|  | 

### Return type

[**OpenCorporatesSenderUpdateResponse**](OpenCorporatesSenderUpdateResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

