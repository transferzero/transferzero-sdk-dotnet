# TransferZero.Sdk.Api.SanctionedCountriesApi

All URIs are relative to *https://api-sandbox.bitpesa.co/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetSanctionedCountries**](SanctionedCountriesApi.md#getsanctionedcountries) | **GET** /sanctioned_countries | Get List of Sanctioned Countries


<a name="getsanctionedcountries"></a>
# **GetSanctionedCountries**
> SanctionedCountryListResponse GetSanctionedCountries ()

Get List of Sanctioned Countries

Get a list of sanctioned countries

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
    public class GetSanctionedCountriesExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new SanctionedCountriesApi(configuration);

            try {
                // Get List of Sanctioned Countries
                SanctionedCountryListResponse result = apiInstance.GetSanctionedCountries();
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    SanctionedCountryListResponse result = e.ParseObject<SanctionedCountryListResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling SanctionedCountriesApi.GetSanctionedCountries: " + e.Message );
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

        Dim apiInstance = new SanctionedCountriesApi(configuration)


        Try
            REM Get List of Sanctioned Countries
            Dim result As SanctionedCountryListResponse = apiInstance.GetSanctionedCountries()
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as SanctionedCountryListResponse = e.ParseObject(Of SanctionedCountryListResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling SanctionedCountriesApi.GetSanctionedCountries: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**SanctionedCountryListResponse**](SanctionedCountryListResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

