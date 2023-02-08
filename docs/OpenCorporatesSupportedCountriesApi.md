# TransferZero.Sdk.Api.OpenCorporatesSupportedCountriesApi

All URIs are relative to *https://api-sandbox.bitpesa.co/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetOpenCorporatesSupportedCountries**](OpenCorporatesSupportedCountriesApi.md#getopencorporatessupportedcountries) | **GET** /open_corporates/countries | Get List of Supported Countries from OpenCorporates


<a name="getopencorporatessupportedcountries"></a>
# **GetOpenCorporatesSupportedCountries**
> OpenCorporatesSupportedCountriesListResponse GetOpenCorporatesSupportedCountries ()

Get List of Supported Countries from OpenCorporates

Get List of Supported Countries from OpenCorporates

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
    public class GetOpenCorporatesSupportedCountriesExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new OpenCorporatesSupportedCountriesApi(configuration);

            try {
                // Get List of Supported Countries from OpenCorporates
                OpenCorporatesSupportedCountriesListResponse result = apiInstance.GetOpenCorporatesSupportedCountries();
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    OpenCorporatesSupportedCountriesListResponse result = e.ParseObject<OpenCorporatesSupportedCountriesListResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling OpenCorporatesSupportedCountriesApi.GetOpenCorporatesSupportedCountries: " + e.Message );
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

        Dim apiInstance = new OpenCorporatesSupportedCountriesApi(configuration)


        Try
            REM Get List of Supported Countries from OpenCorporates
            Dim result As OpenCorporatesSupportedCountriesListResponse = apiInstance.GetOpenCorporatesSupportedCountries()
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as OpenCorporatesSupportedCountriesListResponse = e.ParseObject(Of OpenCorporatesSupportedCountriesListResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling OpenCorporatesSupportedCountriesApi.GetOpenCorporatesSupportedCountries: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**OpenCorporatesSupportedCountriesListResponse**](OpenCorporatesSupportedCountriesListResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

