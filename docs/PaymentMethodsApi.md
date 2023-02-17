# TransferZero.Sdk.Api.PaymentMethodsApi

All URIs are relative to *https://api-sandbox.bitpesa.co/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PaymentMethodsIn**](PaymentMethodsApi.md#paymentmethodsin) | **GET** /info/payment_methods/in | This method returns possible payin methods.
[**PaymentMethodsOut**](PaymentMethodsApi.md#paymentmethodsout) | **GET** /info/payment_methods/out | This method returns possible payout methods.


<a name="paymentmethodsin"></a>
# **PaymentMethodsIn**
> PaymentMethodListResponse PaymentMethodsIn ()

This method returns possible payin methods.

Fetching possible payin methods. 

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
    public class PaymentMethodsInExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new PaymentMethodsApi(configuration);

            try {
                // This method returns possible payin methods.
                PaymentMethodListResponse result = apiInstance.PaymentMethodsIn();
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    PaymentMethodListResponse result = e.ParseObject<PaymentMethodListResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling PaymentMethodsApi.PaymentMethodsIn: " + e.Message );
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

        Dim apiInstance = new PaymentMethodsApi(configuration)


        Try
            REM This method returns possible payin methods.
            Dim result As PaymentMethodListResponse = apiInstance.PaymentMethodsIn()
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as PaymentMethodListResponse = e.ParseObject(Of PaymentMethodListResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling PaymentMethodsApi.PaymentMethodsIn: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**PaymentMethodListResponse**](PaymentMethodListResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="paymentmethodsout"></a>
# **PaymentMethodsOut**
> PaymentMethodListResponse PaymentMethodsOut ()

This method returns possible payout methods.

Fetching possible payout methods. 

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
    public class PaymentMethodsOutExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new PaymentMethodsApi(configuration);

            try {
                // This method returns possible payout methods.
                PaymentMethodListResponse result = apiInstance.PaymentMethodsOut();
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    PaymentMethodListResponse result = e.ParseObject<PaymentMethodListResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling PaymentMethodsApi.PaymentMethodsOut: " + e.Message );
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

        Dim apiInstance = new PaymentMethodsApi(configuration)


        Try
            REM This method returns possible payout methods.
            Dim result As PaymentMethodListResponse = apiInstance.PaymentMethodsOut()
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as PaymentMethodListResponse = e.ParseObject(Of PaymentMethodListResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling PaymentMethodsApi.PaymentMethodsOut: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**PaymentMethodListResponse**](PaymentMethodListResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

