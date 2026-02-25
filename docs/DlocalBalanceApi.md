# TransferZero.Sdk.Api.DlocalBalanceApi

All URIs are relative to *https://api-sandbox.transferzero.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetBalance**](DlocalBalanceApi.md#getbalance) | **GET** /dlocal/balance | Get dlocal balances


<a name="getbalance"></a>
# **GetBalance**
> DlocalBalanceResponse GetBalance ()

Get dlocal balances

This endpoint retrieves dlocal account balances

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
    public class GetBalanceExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new DlocalBalanceApi(configuration);

            try {
                // Get dlocal balances
                DlocalBalanceResponse result = apiInstance.GetBalance();
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    DlocalBalanceResponse result = e.ParseObject<DlocalBalanceResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling DlocalBalanceApi.GetBalance: " + e.Message );
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

        Dim apiInstance = new DlocalBalanceApi(configuration)


        Try
            REM Get dlocal balances
            Dim result As DlocalBalanceResponse = apiInstance.GetBalance()
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as DlocalBalanceResponse = e.ParseObject(Of DlocalBalanceResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling DlocalBalanceApi.GetBalance: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**DlocalBalanceResponse**](DlocalBalanceResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

