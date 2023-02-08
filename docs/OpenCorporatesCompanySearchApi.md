# TransferZero.Sdk.Api.OpenCorporatesCompanySearchApi

All URIs are relative to *https://api-sandbox.bitpesa.co/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**SearchCompany**](OpenCorporatesCompanySearchApi.md#searchcompany) | **POST** /open_corporates/search | Search for a company on Open Corporates


<a name="searchcompany"></a>
# **SearchCompany**
> OpenCorporatesSearchResponse SearchCompany (OpenCorporatesSearchRequest openCorporatesSearchRequest)

Search for a company on Open Corporates

This endpoint searches for a company on Open Corporates API and returns the name if found

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
    public class SearchCompanyExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new OpenCorporatesCompanySearchApi(configuration);
            var openCorporatesSearchRequest = new OpenCorporatesSearchRequest(); // OpenCorporatesSearchRequest | 

            try {
                // Search for a company on Open Corporates
                OpenCorporatesSearchResponse result = apiInstance.SearchCompany(openCorporatesSearchRequest);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    OpenCorporatesSearchResponse result = e.ParseObject<OpenCorporatesSearchResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling OpenCorporatesCompanySearchApi.SearchCompany: " + e.Message );
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

        Dim apiInstance = new OpenCorporatesCompanySearchApi(configuration)
        Dim openCorporatesSearchRequest = new OpenCorporatesSearchRequest() REM OpenCorporatesSearchRequest | 


        Try
            REM Search for a company on Open Corporates
            Dim result As OpenCorporatesSearchResponse = apiInstance.SearchCompany(openCorporatesSearchRequest)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as OpenCorporatesSearchResponse = e.ParseObject(Of OpenCorporatesSearchResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling OpenCorporatesCompanySearchApi.SearchCompany: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **openCorporatesSearchRequest** | [**OpenCorporatesSearchRequest**](OpenCorporatesSearchRequest.md)|  | 

### Return type

[**OpenCorporatesSearchResponse**](OpenCorporatesSearchResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

