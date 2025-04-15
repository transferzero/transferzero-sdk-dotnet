# TransferZero.Sdk.Api.AccountDebitsApi

All URIs are relative to *https://api-sandbox.transferzero.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PostAccountsDebits**](AccountDebitsApi.md#postaccountsdebits) | **POST** /accounts/debits | Creating an account debit


<a name="postaccountsdebits"></a>
# **PostAccountsDebits**
> DebitListResponse PostAccountsDebits (DebitRequestWrapper debitRequestWrapper)

Creating an account debit

Creates a new account debit finding transaction through the internal balance  To successfully fund a transaction - - The currency needs to be the same as the input_currency on the transaction - The amount has to be the same as the input_amount on the transaction - The to_id is the id of the transaction - You need to have enough balance of the appropriate currency inside your wallet  Once the transaction is funded, we will immediately start trying to pay out the recipient(s).  It is also possible to create multiple account debits by supplying an array of debit objects 

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
    public class PostAccountsDebitsExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new AccountDebitsApi(configuration);
            var debitRequestWrapper = new DebitRequestWrapper(); // DebitRequestWrapper | 

            try {
                // Creating an account debit
                DebitListResponse result = apiInstance.PostAccountsDebits(debitRequestWrapper);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    DebitListResponse result = e.ParseObject<DebitListResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling AccountDebitsApi.PostAccountsDebits: " + e.Message );
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

        Dim apiInstance = new AccountDebitsApi(configuration)
        Dim debitRequestWrapper = new DebitRequestWrapper() REM DebitRequestWrapper | 


        Try
            REM Creating an account debit
            Dim result As DebitListResponse = apiInstance.PostAccountsDebits(debitRequestWrapper)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as DebitListResponse = e.ParseObject(Of DebitListResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling AccountDebitsApi.PostAccountsDebits: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **debitRequestWrapper** | [**DebitRequestWrapper**](DebitRequestWrapper.md)|  | 

### Return type

[**DebitListResponse**](DebitListResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

