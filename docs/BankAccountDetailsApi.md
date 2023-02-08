# TransferZero.Sdk.Api.BankAccountDetailsApi

All URIs are relative to *https://api-sandbox.bitpesa.co/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetBankAccountDetails**](BankAccountDetailsApi.md#getbankaccountdetails) | **GET** /bank_account_details/{Currency} | Fetching bank account details


<a name="getbankaccountdetails"></a>
# **GetBankAccountDetails**
> BankAccountDetailsResponse GetBankAccountDetails (string currency)

Fetching bank account details

Returns single bank account details based on the currency

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
    public class GetBankAccountDetailsExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new BankAccountDetailsApi(configuration);
            var currency = currency_example;  // string | Currency of the required bank account details.  Example: `/v1/bank_account_details/NGN`

            try {
                // Fetching bank account details
                BankAccountDetailsResponse result = apiInstance.GetBankAccountDetails(currency);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    BankAccountDetailsResponse result = e.ParseObject<BankAccountDetailsResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling BankAccountDetailsApi.GetBankAccountDetails: " + e.Message );
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

        Dim apiInstance = new BankAccountDetailsApi(configuration)
        Dim currency = currency_example REM string | Currency of the required bank account details.  Example: `/v1/bank_account_details/NGN`


        Try
            REM Fetching bank account details
            Dim result As BankAccountDetailsResponse = apiInstance.GetBankAccountDetails(currency)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as BankAccountDetailsResponse = e.ParseObject(Of BankAccountDetailsResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling BankAccountDetailsApi.GetBankAccountDetails: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **currency** | **string**| Currency of the required bank account details.  Example: &#x60;/v1/bank_account_details/NGN&#x60; | 

### Return type

[**BankAccountDetailsResponse**](BankAccountDetailsResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

