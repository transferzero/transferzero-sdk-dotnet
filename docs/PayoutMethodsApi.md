# TransferZero.Sdk.Api.PayoutMethodsApi

All URIs are relative to *https://api-sandbox.transferzero.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeletePayoutMethod**](PayoutMethodsApi.md#deletepayoutmethod) | **DELETE** /payout_methods/{Payout Method ID} | Deleting a payout method
[**GetPayoutMethod**](PayoutMethodsApi.md#getpayoutmethod) | **GET** /payout_methods/{Payout Method ID} | Fetching a payout method
[**GetPayoutMethods**](PayoutMethodsApi.md#getpayoutmethods) | **GET** /payout_methods | Listing payout methods
[**PatchPayoutMethod**](PayoutMethodsApi.md#patchpayoutmethod) | **PATCH** /payout_methods/{Payout Method ID} | Updating a payout method
[**PostPayoutMethods**](PayoutMethodsApi.md#postpayoutmethods) | **POST** /payout_methods | Creating a payout method


<a name="deletepayoutmethod"></a>
# **DeletePayoutMethod**
> PayoutMethodResponse DeletePayoutMethod (Guid? payoutMethodID)

Deleting a payout method

Deletes a single payout method by the Payout Method ID

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
    public class DeletePayoutMethodExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new PayoutMethodsApi(configuration);
            var payoutMethodID = new Guid?(); // Guid? | ID of the payout method to delete.  Example: `/v1/payout_methods/bf9ff782-e182-45ac-abea-5bce83ad6670`

            try {
                // Deleting a payout method
                PayoutMethodResponse result = apiInstance.DeletePayoutMethod(payoutMethodID);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    PayoutMethodResponse result = e.ParseObject<PayoutMethodResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling PayoutMethodsApi.DeletePayoutMethod: " + e.Message );
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

        Dim apiInstance = new PayoutMethodsApi(configuration)
        Dim payoutMethodID = new Guid?() REM Guid? | ID of the payout method to delete.  Example: `/v1/payout_methods/bf9ff782-e182-45ac-abea-5bce83ad6670`


        Try
            REM Deleting a payout method
            Dim result As PayoutMethodResponse = apiInstance.DeletePayoutMethod(payoutMethodID)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as PayoutMethodResponse = e.ParseObject(Of PayoutMethodResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling PayoutMethodsApi.DeletePayoutMethod: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **payoutMethodID** | [**Guid?**](Guid?.md)| ID of the payout method to delete.  Example: &#x60;/v1/payout_methods/bf9ff782-e182-45ac-abea-5bce83ad6670&#x60; | 

### Return type

[**PayoutMethodResponse**](PayoutMethodResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpayoutmethod"></a>
# **GetPayoutMethod**
> PayoutMethodResponse GetPayoutMethod (Guid? payoutMethodID)

Fetching a payout method

Show a payout method by id

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
    public class GetPayoutMethodExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new PayoutMethodsApi(configuration);
            var payoutMethodID = new Guid?(); // Guid? | ID of the payout method to get.  Example: `/v1/payout_methods/bf9ff782-e182-45ac-abea-5bce83ad6670`

            try {
                // Fetching a payout method
                PayoutMethodResponse result = apiInstance.GetPayoutMethod(payoutMethodID);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    PayoutMethodResponse result = e.ParseObject<PayoutMethodResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling PayoutMethodsApi.GetPayoutMethod: " + e.Message );
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

        Dim apiInstance = new PayoutMethodsApi(configuration)
        Dim payoutMethodID = new Guid?() REM Guid? | ID of the payout method to get.  Example: `/v1/payout_methods/bf9ff782-e182-45ac-abea-5bce83ad6670`


        Try
            REM Fetching a payout method
            Dim result As PayoutMethodResponse = apiInstance.GetPayoutMethod(payoutMethodID)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as PayoutMethodResponse = e.ParseObject(Of PayoutMethodResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling PayoutMethodsApi.GetPayoutMethod: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **payoutMethodID** | [**Guid?**](Guid?.md)| ID of the payout method to get.  Example: &#x60;/v1/payout_methods/bf9ff782-e182-45ac-abea-5bce83ad6670&#x60; | 

### Return type

[**PayoutMethodResponse**](PayoutMethodResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpayoutmethods"></a>
# **GetPayoutMethods**
> PayoutMethodListResponse GetPayoutMethods (List<string> state = null, List<string> type = null, string senderId = null, int? page = null, int? per = null, string createdAtFrom = null, string createdAtTo = null)

Listing payout methods

List available payout methods

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
    public class GetPayoutMethodsExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new PayoutMethodsApi(configuration);
            var state = state_example;  // List<string> | Allows filtering results by `state` of the payout method.  Example: `/v1/payout_methods?state[]=enabled` (optional) 
            var type = new List<string>(); // List<string> | Allows filtering results by the specified type.  Example: `/v1/payout_methods?type[]=NGN::Bank` (optional) 
            var senderId = senderId_example;  // string | Allows filtering results by the specified sender id.  Example: `/v1/payout_methods?sender_id=bf9ff782-e182-45ac-abea-5bce83ad6670` (optional) 
            var page = 1;  // int? | The page number to request (defaults to 1) (optional) 
            var per = 10;  // int? | The number of results to load per page (defaults to 10) (optional) 
            var createdAtFrom = createdAtFrom_example;  // string | Start date to filter recipients by created_at range Allows filtering results by the specified `created_at` timeframe.  Example: `/v1/recipients?created_at_from=2018-06-06&created_at_to=2018-06-08` (optional) 
            var createdAtTo = createdAtTo_example;  // string | End date to filter recipients by created_at range Allows filtering results by the specified `created_at` timeframe.  Example: `/v1/recipients?created_at_from=2018-06-06&created_at_to=2018-06-08` (optional) 

            try {
                // Listing payout methods
                PayoutMethodListResponse result = apiInstance.GetPayoutMethods(state, type, senderId, page, per, createdAtFrom, createdAtTo);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    PayoutMethodListResponse result = e.ParseObject<PayoutMethodListResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling PayoutMethodsApi.GetPayoutMethods: " + e.Message );
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

        Dim apiInstance = new PayoutMethodsApi(configuration)
        Dim state = state_example REM List<string> | Allows filtering results by `state` of the payout method.  Example: `/v1/payout_methods?state[]=enabled` (optional) 
        Dim type = new List<string>() REM List<string> | Allows filtering results by the specified type.  Example: `/v1/payout_methods?type[]=NGN::Bank` (optional) 
        Dim senderId = senderId_example REM string | Allows filtering results by the specified sender id.  Example: `/v1/payout_methods?sender_id=bf9ff782-e182-45ac-abea-5bce83ad6670` (optional) 
        Dim page = 1 REM int? | The page number to request (defaults to 1) (optional) 
        Dim per = 10 REM int? | The number of results to load per page (defaults to 10) (optional) 
        Dim createdAtFrom = createdAtFrom_example REM string | Start date to filter recipients by created_at range Allows filtering results by the specified `created_at` timeframe.  Example: `/v1/recipients?created_at_from=2018-06-06&created_at_to=2018-06-08` (optional) 
        Dim createdAtTo = createdAtTo_example REM string | End date to filter recipients by created_at range Allows filtering results by the specified `created_at` timeframe.  Example: `/v1/recipients?created_at_from=2018-06-06&created_at_to=2018-06-08` (optional) 


        Try
            REM Listing payout methods
            Dim result As PayoutMethodListResponse = apiInstance.GetPayoutMethods(state, type, senderId, page, per, createdAtFrom, createdAtTo)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as PayoutMethodListResponse = e.ParseObject(Of PayoutMethodListResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling PayoutMethodsApi.GetPayoutMethods: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **state** | **List&lt;string&gt;**| Allows filtering results by &#x60;state&#x60; of the payout method.  Example: &#x60;/v1/payout_methods?state[]&#x3D;enabled&#x60; | [optional] 
 **type** | [**List&lt;string&gt;**](string.md)| Allows filtering results by the specified type.  Example: &#x60;/v1/payout_methods?type[]&#x3D;NGN::Bank&#x60; | [optional] 
 **senderId** | **string**| Allows filtering results by the specified sender id.  Example: &#x60;/v1/payout_methods?sender_id&#x3D;bf9ff782-e182-45ac-abea-5bce83ad6670&#x60; | [optional] 
 **page** | **int?**| The page number to request (defaults to 1) | [optional] 
 **per** | **int?**| The number of results to load per page (defaults to 10) | [optional] 
 **createdAtFrom** | **string**| Start date to filter recipients by created_at range Allows filtering results by the specified &#x60;created_at&#x60; timeframe.  Example: &#x60;/v1/recipients?created_at_from&#x3D;2018-06-06&amp;created_at_to&#x3D;2018-06-08&#x60; | [optional] 
 **createdAtTo** | **string**| End date to filter recipients by created_at range Allows filtering results by the specified &#x60;created_at&#x60; timeframe.  Example: &#x60;/v1/recipients?created_at_from&#x3D;2018-06-06&amp;created_at_to&#x3D;2018-06-08&#x60; | [optional] 

### Return type

[**PayoutMethodListResponse**](PayoutMethodListResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchpayoutmethod"></a>
# **PatchPayoutMethod**
> PayoutMethodResponse PatchPayoutMethod (Guid? payoutMethodID, PayoutMethod payoutMethod)

Updating a payout method

Updates a single payout method by the Payout Method ID

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
    public class PatchPayoutMethodExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new PayoutMethodsApi(configuration);
            var payoutMethodID = new Guid?(); // Guid? | ID of the payout method to get.  Example: `/v1/payout_methods/bf9ff782-e182-45ac-abea-5bce83ad6670`
            var payoutMethod = new PayoutMethod(); // PayoutMethod | 

            try {
                // Updating a payout method
                PayoutMethodResponse result = apiInstance.PatchPayoutMethod(payoutMethodID, payoutMethod);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    PayoutMethodResponse result = e.ParseObject<PayoutMethodResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling PayoutMethodsApi.PatchPayoutMethod: " + e.Message );
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

        Dim apiInstance = new PayoutMethodsApi(configuration)
        Dim payoutMethodID = new Guid?() REM Guid? | ID of the payout method to get.  Example: `/v1/payout_methods/bf9ff782-e182-45ac-abea-5bce83ad6670`
        Dim payoutMethod = new PayoutMethod() REM PayoutMethod | 


        Try
            REM Updating a payout method
            Dim result As PayoutMethodResponse = apiInstance.PatchPayoutMethod(payoutMethodID, payoutMethod)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as PayoutMethodResponse = e.ParseObject(Of PayoutMethodResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling PayoutMethodsApi.PatchPayoutMethod: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **payoutMethodID** | [**Guid?**](Guid?.md)| ID of the payout method to get.  Example: &#x60;/v1/payout_methods/bf9ff782-e182-45ac-abea-5bce83ad6670&#x60; | 
 **payoutMethod** | [**PayoutMethod**](PayoutMethod.md)|  | 

### Return type

[**PayoutMethodResponse**](PayoutMethodResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpayoutmethods"></a>
# **PostPayoutMethods**
> PayoutMethodResponse PostPayoutMethods (PayoutMethodRequest payoutMethodRequest)

Creating a payout method

Creates a new payout method in our system. 

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
    public class PostPayoutMethodsExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new PayoutMethodsApi(configuration);
            var payoutMethodRequest = new PayoutMethodRequest(); // PayoutMethodRequest | 

            try {
                // Creating a payout method
                PayoutMethodResponse result = apiInstance.PostPayoutMethods(payoutMethodRequest);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    PayoutMethodResponse result = e.ParseObject<PayoutMethodResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling PayoutMethodsApi.PostPayoutMethods: " + e.Message );
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

        Dim apiInstance = new PayoutMethodsApi(configuration)
        Dim payoutMethodRequest = new PayoutMethodRequest() REM PayoutMethodRequest | 


        Try
            REM Creating a payout method
            Dim result As PayoutMethodResponse = apiInstance.PostPayoutMethods(payoutMethodRequest)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as PayoutMethodResponse = e.ParseObject(Of PayoutMethodResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling PayoutMethodsApi.PostPayoutMethods: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **payoutMethodRequest** | [**PayoutMethodRequest**](PayoutMethodRequest.md)|  | 

### Return type

[**PayoutMethodResponse**](PayoutMethodResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

