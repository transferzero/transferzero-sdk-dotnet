# TransferZero.Sdk.Api.PayinMethodsApi

All URIs are relative to *https://api-sandbox.transferzero.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeletePayinMethod**](PayinMethodsApi.md#deletepayinmethod) | **DELETE** /payin_methods/{PayinMethod ID} | Deleting a payin method
[**GetPayinMethod**](PayinMethodsApi.md#getpayinmethod) | **GET** /payin_methods/{PayinMethod ID} | Fetching a payin method
[**PatchPayinMethod**](PayinMethodsApi.md#patchpayinmethod) | **PATCH** /payin_methods/{PayinMethod ID} | Updating a payin method
[**RetryPayinMethod**](PayinMethodsApi.md#retrypayinmethod) | **POST** /payin_methods/{PayinMethod ID}/retry | Retries PayinMethod


<a name="deletepayinmethod"></a>
# **DeletePayinMethod**
> PayinMethodResponse DeletePayinMethod (Guid? payinMethodID)

Deleting a payin method

Initiates a cancellation request for the specified payin method

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
    public class DeletePayinMethodExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new PayinMethodsApi(configuration);
            var payinMethodID = new Guid?(); // Guid? | ID of the payin method to delete.  Example: `/v1/payin_methods/bf9ff782-e182-45ac-abea-5bce83ad6670`

            try {
                // Deleting a payin method
                PayinMethodResponse result = apiInstance.DeletePayinMethod(payinMethodID);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    PayinMethodResponse result = e.ParseObject<PayinMethodResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling PayinMethodsApi.DeletePayinMethod: " + e.Message );
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

        Dim apiInstance = new PayinMethodsApi(configuration)
        Dim payinMethodID = new Guid?() REM Guid? | ID of the payin method to delete.  Example: `/v1/payin_methods/bf9ff782-e182-45ac-abea-5bce83ad6670`


        Try
            REM Deleting a payin method
            Dim result As PayinMethodResponse = apiInstance.DeletePayinMethod(payinMethodID)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as PayinMethodResponse = e.ParseObject(Of PayinMethodResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling PayinMethodsApi.DeletePayinMethod: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **payinMethodID** | [**Guid?**](Guid?.md)| ID of the payin method to delete.  Example: &#x60;/v1/payin_methods/bf9ff782-e182-45ac-abea-5bce83ad6670&#x60; | 

### Return type

[**PayinMethodResponse**](PayinMethodResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpayinmethod"></a>
# **GetPayinMethod**
> PayinMethodResponse GetPayinMethod (Guid? payinMethodID)

Fetching a payin method

Show a payin method by id

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
    public class GetPayinMethodExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new PayinMethodsApi(configuration);
            var payinMethodID = new Guid?(); // Guid? | ID of the payin method to get.  Example: `/v1/payin_methods/bf9ff782-e182-45ac-abea-5bce83ad6670`

            try {
                // Fetching a payin method
                PayinMethodResponse result = apiInstance.GetPayinMethod(payinMethodID);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    PayinMethodResponse result = e.ParseObject<PayinMethodResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling PayinMethodsApi.GetPayinMethod: " + e.Message );
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

        Dim apiInstance = new PayinMethodsApi(configuration)
        Dim payinMethodID = new Guid?() REM Guid? | ID of the payin method to get.  Example: `/v1/payin_methods/bf9ff782-e182-45ac-abea-5bce83ad6670`


        Try
            REM Fetching a payin method
            Dim result As PayinMethodResponse = apiInstance.GetPayinMethod(payinMethodID)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as PayinMethodResponse = e.ParseObject(Of PayinMethodResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling PayinMethodsApi.GetPayinMethod: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **payinMethodID** | [**Guid?**](Guid?.md)| ID of the payin method to get.  Example: &#x60;/v1/payin_methods/bf9ff782-e182-45ac-abea-5bce83ad6670&#x60; | 

### Return type

[**PayinMethodResponse**](PayinMethodResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchpayinmethod"></a>
# **PatchPayinMethod**
> PayinMethodResponse PatchPayinMethod (Guid? payinMethodID, PayinMethod payinMethod)

Updating a payin method

Updates the payin method specified in the URL path.

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
    public class PatchPayinMethodExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new PayinMethodsApi(configuration);
            var payinMethodID = new Guid?(); // Guid? | ID of the payin method to get.  Example: `/v1/payin_methods/bf9ff782-e182-45ac-abea-5bce83ad6670`
            var payinMethod = new PayinMethod(); // PayinMethod | 

            try {
                // Updating a payin method
                PayinMethodResponse result = apiInstance.PatchPayinMethod(payinMethodID, payinMethod);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    PayinMethodResponse result = e.ParseObject<PayinMethodResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling PayinMethodsApi.PatchPayinMethod: " + e.Message );
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

        Dim apiInstance = new PayinMethodsApi(configuration)
        Dim payinMethodID = new Guid?() REM Guid? | ID of the payin method to get.  Example: `/v1/payin_methods/bf9ff782-e182-45ac-abea-5bce83ad6670`
        Dim payinMethod = new PayinMethod() REM PayinMethod | 


        Try
            REM Updating a payin method
            Dim result As PayinMethodResponse = apiInstance.PatchPayinMethod(payinMethodID, payinMethod)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as PayinMethodResponse = e.ParseObject(Of PayinMethodResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling PayinMethodsApi.PatchPayinMethod: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **payinMethodID** | [**Guid?**](Guid?.md)| ID of the payin method to get.  Example: &#x60;/v1/payin_methods/bf9ff782-e182-45ac-abea-5bce83ad6670&#x60; | 
 **payinMethod** | [**PayinMethod**](PayinMethod.md)|  | 

### Return type

[**PayinMethodResponse**](PayinMethodResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="retrypayinmethod"></a>
# **RetryPayinMethod**
> void RetryPayinMethod (Guid? payinMethodID)

Retries PayinMethod

Retries the collection process for the payin method.  Please note only payin methods in `error` state can be retried.

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
    public class RetryPayinMethodExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new PayinMethodsApi(configuration);
            var payinMethodID = new Guid?(); // Guid? | ID of the payin method whose collection process should be retried  Example: `/v1/payin_methods/9d4d7b73-a94c-4979-ab57-09074fd55d33/retry`

            try {
                // Retries PayinMethod
                apiInstance.RetryPayinMethod(payinMethodID);
            } catch (ApiException e)
            {
                    Debug.Print("Exception when calling PayinMethodsApi.RetryPayinMethod: " + e.Message );
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

        Dim apiInstance = new PayinMethodsApi(configuration)
        Dim payinMethodID = new Guid?() REM Guid? | ID of the payin method whose collection process should be retried  Example: `/v1/payin_methods/9d4d7b73-a94c-4979-ab57-09074fd55d33/retry`


        Try
            REM Retries PayinMethod
            apiInstance.RetryPayinMethod(payinMethodID)
        Catch e as ApiException
            Debug.Print("Exception when calling PayinMethodsApi.RetryPayinMethod: " + e.Message );
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **payinMethodID** | [**Guid?**](Guid?.md)| ID of the payin method whose collection process should be retried  Example: &#x60;/v1/payin_methods/9d4d7b73-a94c-4979-ab57-09074fd55d33/retry&#x60; | 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

