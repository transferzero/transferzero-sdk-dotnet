# TransferZero.Sdk.Api.CurrencyInfoApi

All URIs are relative to *https://api-sandbox.transferzero.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**InfoCurrencies**](CurrencyInfoApi.md#infocurrencies) | **GET** /info/currencies | Getting a list of possible requested currencies
[**InfoCurrenciesIn**](CurrencyInfoApi.md#infocurrenciesin) | **GET** /info/currencies/in | Getting a list of possible input currencies
[**InfoCurrenciesOut**](CurrencyInfoApi.md#infocurrenciesout) | **GET** /info/currencies/out | Getting a list of possible output currencies


<a name="infocurrencies"></a>
# **InfoCurrencies**
> CurrencyListResponse InfoCurrencies ()

Getting a list of possible requested currencies

Fetches a list of currencies available to use in other API requests. Usually the 3-character alpha ISO 4217 currency code (eg. USD) is used as the identifier.

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
    public class InfoCurrenciesExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new CurrencyInfoApi(configuration);

            try {
                // Getting a list of possible requested currencies
                CurrencyListResponse result = apiInstance.InfoCurrencies();
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    CurrencyListResponse result = e.ParseObject<CurrencyListResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling CurrencyInfoApi.InfoCurrencies: " + e.Message );
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

        Dim apiInstance = new CurrencyInfoApi(configuration)


        Try
            REM Getting a list of possible requested currencies
            Dim result As CurrencyListResponse = apiInstance.InfoCurrencies()
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as CurrencyListResponse = e.ParseObject(Of CurrencyListResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling CurrencyInfoApi.InfoCurrencies: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**CurrencyListResponse**](CurrencyListResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="infocurrenciesin"></a>
# **InfoCurrenciesIn**
> CurrencyExchangeListResponse InfoCurrenciesIn ()

Getting a list of possible input currencies

Fetches a list of currencies available to use as the input currency in other API requests. Usually the 3-character alpha ISO 4217 currency code (eg. USD) is used as the identifier. Use this endpoint to determine the current exchange rate from a specific input currency to any output currency that's available. 

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
    public class InfoCurrenciesInExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new CurrencyInfoApi(configuration);

            try {
                // Getting a list of possible input currencies
                CurrencyExchangeListResponse result = apiInstance.InfoCurrenciesIn();
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    CurrencyExchangeListResponse result = e.ParseObject<CurrencyExchangeListResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling CurrencyInfoApi.InfoCurrenciesIn: " + e.Message );
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

        Dim apiInstance = new CurrencyInfoApi(configuration)


        Try
            REM Getting a list of possible input currencies
            Dim result As CurrencyExchangeListResponse = apiInstance.InfoCurrenciesIn()
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as CurrencyExchangeListResponse = e.ParseObject(Of CurrencyExchangeListResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling CurrencyInfoApi.InfoCurrenciesIn: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**CurrencyExchangeListResponse**](CurrencyExchangeListResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="infocurrenciesout"></a>
# **InfoCurrenciesOut**
> CurrencyExchangeListResponse InfoCurrenciesOut ()

Getting a list of possible output currencies

Fetches a list of currencies available to use as the output currency and their exchange rates against the available input currencies. Usually the 3-character alpha ISO 4217 currency code (eg. USD) is used as the identifier. 

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
    public class InfoCurrenciesOutExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new CurrencyInfoApi(configuration);

            try {
                // Getting a list of possible output currencies
                CurrencyExchangeListResponse result = apiInstance.InfoCurrenciesOut();
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    CurrencyExchangeListResponse result = e.ParseObject<CurrencyExchangeListResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling CurrencyInfoApi.InfoCurrenciesOut: " + e.Message );
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

        Dim apiInstance = new CurrencyInfoApi(configuration)


        Try
            REM Getting a list of possible output currencies
            Dim result As CurrencyExchangeListResponse = apiInstance.InfoCurrenciesOut()
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as CurrencyExchangeListResponse = e.ParseObject(Of CurrencyExchangeListResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling CurrencyInfoApi.InfoCurrenciesOut: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**CurrencyExchangeListResponse**](CurrencyExchangeListResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

