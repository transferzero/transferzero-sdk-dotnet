# TransferZero.Sdk.Api.TransactionsApi

All URIs are relative to *https://api-sandbox.transferzero.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CalculateTransactions**](TransactionsApi.md#calculatetransactions) | **POST** /transactions/calculate | Calculates transaction amounts for a transaction payload
[**GetTransaction**](TransactionsApi.md#gettransaction) | **GET** /transactions/{Transaction ID} | Fetch a single transaction
[**GetTransactions**](TransactionsApi.md#gettransactions) | **GET** /transactions | Get a list of transactions
[**PayinTransaction**](TransactionsApi.md#payintransaction) | **POST** /transactions/{Transaction ID}/payin | Creates a fake payin for transaction
[**PayoutTransaction**](TransactionsApi.md#payouttransaction) | **POST** /transactions/{Transaction ID}/payout | Creates a fake payout for transaction
[**PostTransactions**](TransactionsApi.md#posttransactions) | **POST** /transactions | Creates a new transaction
[**ValidateTransactions**](TransactionsApi.md#validatetransactions) | **POST** /transactions/validate | Validates a transaction payload


<a name="calculatetransactions"></a>
# **CalculateTransactions**
> TransactionResponse CalculateTransactions (TransactionRequest transactionRequest)

Calculates transaction amounts for a transaction payload

Calculates the input, output and fee amounts for the recipients in a transaction payload

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
    public class CalculateTransactionsExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new TransactionsApi(configuration);
            var transactionRequest = new TransactionRequest(); // TransactionRequest | 

            try {
                // Calculates transaction amounts for a transaction payload
                TransactionResponse result = apiInstance.CalculateTransactions(transactionRequest);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    TransactionResponse result = e.ParseObject<TransactionResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling TransactionsApi.CalculateTransactions: " + e.Message );
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

        Dim apiInstance = new TransactionsApi(configuration)
        Dim transactionRequest = new TransactionRequest() REM TransactionRequest | 


        Try
            REM Calculates transaction amounts for a transaction payload
            Dim result As TransactionResponse = apiInstance.CalculateTransactions(transactionRequest)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as TransactionResponse = e.ParseObject(Of TransactionResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling TransactionsApi.CalculateTransactions: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transactionRequest** | [**TransactionRequest**](TransactionRequest.md)|  | 

### Return type

[**TransactionResponse**](TransactionResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransaction"></a>
# **GetTransaction**
> TransactionResponse GetTransaction (Guid? transactionID)

Fetch a single transaction

Finds and returns a Transaction created by the requesting API key, using the provided Transaction ID.

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
    public class GetTransactionExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new TransactionsApi(configuration);
            var transactionID = new Guid?(); // Guid? | ID of the transaction.  Example: `/v1/transactions/bf9ff782-e182-45ac-abea-5bce83ad6670`

            try {
                // Fetch a single transaction
                TransactionResponse result = apiInstance.GetTransaction(transactionID);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    TransactionResponse result = e.ParseObject<TransactionResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling TransactionsApi.GetTransaction: " + e.Message );
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

        Dim apiInstance = new TransactionsApi(configuration)
        Dim transactionID = new Guid?() REM Guid? | ID of the transaction.  Example: `/v1/transactions/bf9ff782-e182-45ac-abea-5bce83ad6670`


        Try
            REM Fetch a single transaction
            Dim result As TransactionResponse = apiInstance.GetTransaction(transactionID)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as TransactionResponse = e.ParseObject(Of TransactionResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling TransactionsApi.GetTransaction: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transactionID** | [**Guid?**](Guid?.md)| ID of the transaction.  Example: &#x60;/v1/transactions/bf9ff782-e182-45ac-abea-5bce83ad6670&#x60; | 

### Return type

[**TransactionResponse**](TransactionResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettransactions"></a>
# **GetTransactions**
> TransactionListResponse GetTransactions (int? page = null, int? per = null, string externalId = null)

Get a list of transactions

Retrieves a paginated list of the Transactions created by your API key.

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
    public class GetTransactionsExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new TransactionsApi(configuration);
            var page = 1;  // int? | The page number to request (defaults to 1) (optional) 
            var per = 10;  // int? | The number of results to load per page (defaults to 10) (optional) 
            var externalId = externalId_example;  // string | Allows filtering results by `external_id`.  Example: `/v1/senders?external_id=26ec8517-2f0d-48c0-b74f-0bccb9ab3a87` (optional) 

            try {
                // Get a list of transactions
                TransactionListResponse result = apiInstance.GetTransactions(page, per, externalId);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    TransactionListResponse result = e.ParseObject<TransactionListResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling TransactionsApi.GetTransactions: " + e.Message );
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

        Dim apiInstance = new TransactionsApi(configuration)
        Dim page = 1 REM int? | The page number to request (defaults to 1) (optional) 
        Dim per = 10 REM int? | The number of results to load per page (defaults to 10) (optional) 
        Dim externalId = externalId_example REM string | Allows filtering results by `external_id`.  Example: `/v1/senders?external_id=26ec8517-2f0d-48c0-b74f-0bccb9ab3a87` (optional) 


        Try
            REM Get a list of transactions
            Dim result As TransactionListResponse = apiInstance.GetTransactions(page, per, externalId)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as TransactionListResponse = e.ParseObject(Of TransactionListResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling TransactionsApi.GetTransactions: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| The page number to request (defaults to 1) | [optional] 
 **per** | **int?**| The number of results to load per page (defaults to 10) | [optional] 
 **externalId** | **string**| Allows filtering results by &#x60;external_id&#x60;.  Example: &#x60;/v1/senders?external_id&#x3D;26ec8517-2f0d-48c0-b74f-0bccb9ab3a87&#x60; | [optional] 

### Return type

[**TransactionListResponse**](TransactionListResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="payintransaction"></a>
# **PayinTransaction**
> TransactionResponse PayinTransaction (Guid? transactionID, PayinMethodRequest payinMethodRequest)

Creates a fake payin for transaction

This method is available only in sandbox environment and is supposed to be used only for testing integration. It allows you to emulate a payin without paying actual money. 

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
    public class PayinTransactionExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new TransactionsApi(configuration);
            var transactionID = new Guid?(); // Guid? | ID of the transaction to payin.  Example: `/v1/transactions/bf9ff782-e182-45ac-abea-5bce83ad6670/payin`
            var payinMethodRequest = new PayinMethodRequest(); // PayinMethodRequest | 

            try {
                // Creates a fake payin for transaction
                TransactionResponse result = apiInstance.PayinTransaction(transactionID, payinMethodRequest);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    TransactionResponse result = e.ParseObject<TransactionResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling TransactionsApi.PayinTransaction: " + e.Message );
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

        Dim apiInstance = new TransactionsApi(configuration)
        Dim transactionID = new Guid?() REM Guid? | ID of the transaction to payin.  Example: `/v1/transactions/bf9ff782-e182-45ac-abea-5bce83ad6670/payin`
        Dim payinMethodRequest = new PayinMethodRequest() REM PayinMethodRequest | 


        Try
            REM Creates a fake payin for transaction
            Dim result As TransactionResponse = apiInstance.PayinTransaction(transactionID, payinMethodRequest)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as TransactionResponse = e.ParseObject(Of TransactionResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling TransactionsApi.PayinTransaction: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transactionID** | [**Guid?**](Guid?.md)| ID of the transaction to payin.  Example: &#x60;/v1/transactions/bf9ff782-e182-45ac-abea-5bce83ad6670/payin&#x60; | 
 **payinMethodRequest** | [**PayinMethodRequest**](PayinMethodRequest.md)|  | 

### Return type

[**TransactionResponse**](TransactionResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="payouttransaction"></a>
# **PayoutTransaction**
> TransactionResponse PayoutTransaction (Guid? transactionID)

Creates a fake payout for transaction

This method is available only in sandbox environment and is supposed to be used only for testing. It allows you to emulate the payout of a transaction after payin. 

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
    public class PayoutTransactionExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new TransactionsApi(configuration);
            var transactionID = new Guid?(); // Guid? | ID of the transaction to payout.  Example: `/v1/transactions/bf9ff782-e182-45ac-abea-5bce83ad6670/payout`

            try {
                // Creates a fake payout for transaction
                TransactionResponse result = apiInstance.PayoutTransaction(transactionID);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    TransactionResponse result = e.ParseObject<TransactionResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling TransactionsApi.PayoutTransaction: " + e.Message );
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

        Dim apiInstance = new TransactionsApi(configuration)
        Dim transactionID = new Guid?() REM Guid? | ID of the transaction to payout.  Example: `/v1/transactions/bf9ff782-e182-45ac-abea-5bce83ad6670/payout`


        Try
            REM Creates a fake payout for transaction
            Dim result As TransactionResponse = apiInstance.PayoutTransaction(transactionID)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as TransactionResponse = e.ParseObject(Of TransactionResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling TransactionsApi.PayoutTransaction: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transactionID** | [**Guid?**](Guid?.md)| ID of the transaction to payout.  Example: &#x60;/v1/transactions/bf9ff782-e182-45ac-abea-5bce83ad6670/payout&#x60; | 

### Return type

[**TransactionResponse**](TransactionResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="posttransactions"></a>
# **PostTransactions**
> TransactionResponse PostTransactions (TransactionRequest transactionRequest)

Creates a new transaction

Transactions are the main objects in the TransferZero API, so it's important to understand how to create and manage them. Transactions facilitate money movement from one Sender in a specific currency to one or multiple Recipients in another currency.  The main flow of a successful transaction flow is the following - - Transaction is created linking the Sender to the Recipient(s) with the requested amounts. - Once the sender is KYC'd and approved the transaction can be funded. - Once the transaction is funded, we will initiate the payout to the recipient(s). - After the recipient (or all recipients) has received the money, the transaction is finished.

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
    public class PostTransactionsExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new TransactionsApi(configuration);
            var transactionRequest = new TransactionRequest(); // TransactionRequest | 

            try {
                // Creates a new transaction
                TransactionResponse result = apiInstance.PostTransactions(transactionRequest);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    TransactionResponse result = e.ParseObject<TransactionResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling TransactionsApi.PostTransactions: " + e.Message );
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

        Dim apiInstance = new TransactionsApi(configuration)
        Dim transactionRequest = new TransactionRequest() REM TransactionRequest | 


        Try
            REM Creates a new transaction
            Dim result As TransactionResponse = apiInstance.PostTransactions(transactionRequest)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as TransactionResponse = e.ParseObject(Of TransactionResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling TransactionsApi.PostTransactions: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transactionRequest** | [**TransactionRequest**](TransactionRequest.md)|  | 

### Return type

[**TransactionResponse**](TransactionResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="validatetransactions"></a>
# **ValidateTransactions**
> TransactionResponse ValidateTransactions (TransactionRequest transactionRequest)

Validates a transaction payload

Validates fields in a transaction payload and displays invalid or missing fields

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
    public class ValidateTransactionsExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new TransactionsApi(configuration);
            var transactionRequest = new TransactionRequest(); // TransactionRequest | 

            try {
                // Validates a transaction payload
                TransactionResponse result = apiInstance.ValidateTransactions(transactionRequest);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    TransactionResponse result = e.ParseObject<TransactionResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling TransactionsApi.ValidateTransactions: " + e.Message );
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

        Dim apiInstance = new TransactionsApi(configuration)
        Dim transactionRequest = new TransactionRequest() REM TransactionRequest | 


        Try
            REM Validates a transaction payload
            Dim result As TransactionResponse = apiInstance.ValidateTransactions(transactionRequest)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as TransactionResponse = e.ParseObject(Of TransactionResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling TransactionsApi.ValidateTransactions: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **transactionRequest** | [**TransactionRequest**](TransactionRequest.md)|  | 

### Return type

[**TransactionResponse**](TransactionResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

