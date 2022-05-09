# TransferZero.Sdk.Api.AccountDebitsApi

All URIs are relative to *https://api-sandbox.transferzero.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAccountsDebit**](AccountDebitsApi.md#getaccountsdebit) | **GET** /accounts/debits/{Account Debit ID} | Fetching an account debit
[**GetAccountsDebits**](AccountDebitsApi.md#getaccountsdebits) | **GET** /accounts/debits | Listing Accounts debits
[**PostAccountsDebits**](AccountDebitsApi.md#postaccountsdebits) | **POST** /accounts/debits | Creating an account debit


<a name="getaccountsdebit"></a>
# **GetAccountsDebit**
> DebitResponse GetAccountsDebit (Guid accountDebitID)

Fetching an account debit

Returns a single account debit by the account debit ID

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
    public class GetAccountsDebitExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new AccountDebitsApi(configuration);
            var accountDebitID = new Guid(); // Guid | ID of the account debit to get.  Example: `/v1/accounts/debits/9170c890-1a45-46bd-9b79-3deeb8b4ff3d`

            try {
                // Fetching an account debit
                DebitResponse result = apiInstance.GetAccountsDebit(accountDebitID);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    DebitResponse result = e.ParseObject<DebitResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling AccountDebitsApi.GetAccountsDebit: " + e.Message );
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
        Dim accountDebitID = new Guid() REM Guid | ID of the account debit to get.  Example: `/v1/accounts/debits/9170c890-1a45-46bd-9b79-3deeb8b4ff3d`


        Try
            REM Fetching an account debit
            Dim result As DebitResponse = apiInstance.GetAccountsDebit(accountDebitID)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as DebitResponse = e.ParseObject(Of DebitResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling AccountDebitsApi.GetAccountsDebit: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accountDebitID** | [**Guid**](Guid.md)| ID of the account debit to get.  Example: &#x60;/v1/accounts/debits/9170c890-1a45-46bd-9b79-3deeb8b4ff3d&#x60; | 

### Return type

[**DebitResponse**](DebitResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getaccountsdebits"></a>
# **GetAccountsDebits**
> DebitListResponse GetAccountsDebits (int page = null, int per = null)

Listing Accounts debits

Get a list of accounts debits

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
    public class GetAccountsDebitsExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new AccountDebitsApi(configuration);
            var page = 1;  // int | The page number to request (defaults to 1) (optional) 
            var per = 10;  // int | The number of results to load per page (defaults to 10) (optional) 

            try {
                // Listing Accounts debits
                DebitListResponse result = apiInstance.GetAccountsDebits(page, per);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    DebitListResponse result = e.ParseObject<DebitListResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling AccountDebitsApi.GetAccountsDebits: " + e.Message );
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
        Dim page = 1 REM int | The page number to request (defaults to 1) (optional) 
        Dim per = 10 REM int | The number of results to load per page (defaults to 10) (optional) 


        Try
            REM Listing Accounts debits
            Dim result As DebitListResponse = apiInstance.GetAccountsDebits(page, per)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as DebitListResponse = e.ParseObject(Of DebitListResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling AccountDebitsApi.GetAccountsDebits: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int**| The page number to request (defaults to 1) | [optional] 
 **per** | **int**| The number of results to load per page (defaults to 10) | [optional] 

### Return type

[**DebitListResponse**](DebitListResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

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

