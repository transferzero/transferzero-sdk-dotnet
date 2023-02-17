# TransferZero.Sdk.Api.AccountValidationApi

All URIs are relative to *https://api-sandbox.transferzero.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PostAccountValidations**](AccountValidationApi.md#postaccountvalidations) | **POST** /account_validations | Validates the existence of a bank account or a mobile phone number


<a name="postaccountvalidations"></a>
# **PostAccountValidations**
> AccountValidationResponse PostAccountValidations (AccountValidationRequest accountValidationRequest)

Validates the existence of a bank account or a mobile phone number

Validates the existence of a bank account or mobile phone number and returns the associated customer name

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
    public class PostAccountValidationsExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new AccountValidationApi(configuration);
            var accountValidationRequest = new AccountValidationRequest(); // AccountValidationRequest | 

            try {
                // Validates the existence of a bank account or a mobile phone number
                AccountValidationResponse result = apiInstance.PostAccountValidations(accountValidationRequest);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    AccountValidationResponse result = e.ParseObject<AccountValidationResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling AccountValidationApi.PostAccountValidations: " + e.Message );
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

        Dim apiInstance = new AccountValidationApi(configuration)
        Dim accountValidationRequest = new AccountValidationRequest() REM AccountValidationRequest | 


        Try
            REM Validates the existence of a bank account or a mobile phone number
            Dim result As AccountValidationResponse = apiInstance.PostAccountValidations(accountValidationRequest)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as AccountValidationResponse = e.ParseObject(Of AccountValidationResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling AccountValidationApi.PostAccountValidations: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountValidationRequest** | [**AccountValidationRequest**](AccountValidationRequest.md)|  | 

### Return type

[**AccountValidationResponse**](AccountValidationResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

