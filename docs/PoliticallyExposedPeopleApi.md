# TransferZero.Sdk.Api.PoliticallyExposedPeopleApi

All URIs are relative to *https://api-sandbox.bitpesa.co/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeletePoliticallyExposedPerson**](PoliticallyExposedPeopleApi.md#deletepoliticallyexposedperson) | **DELETE** /politically_exposed_people/{PoliticallyExposedPerson ID} | Deleting a politically exposed person
[**GetPoliticallyExposedPeople**](PoliticallyExposedPeopleApi.md#getpoliticallyexposedpeople) | **GET** /politically_exposed_people | Listing Politically Exposed People
[**GetPoliticallyExposedPerson**](PoliticallyExposedPeopleApi.md#getpoliticallyexposedperson) | **GET** /politically_exposed_people/{PoliticallyExposedPerson ID} | Fetching a politically exposed person
[**PatchPoliticallyExposedPerson**](PoliticallyExposedPeopleApi.md#patchpoliticallyexposedperson) | **PATCH** /politically_exposed_people/{PoliticallyExposedPerson ID} | Updating a politically exposed person
[**PostPoliticallyExposedPeople**](PoliticallyExposedPeopleApi.md#postpoliticallyexposedpeople) | **POST** /politically_exposed_people | Creating a politically exposed person


<a name="deletepoliticallyexposedperson"></a>
# **DeletePoliticallyExposedPerson**
> void DeletePoliticallyExposedPerson (int? politicallyExposedPersonID)

Deleting a politically exposed person

Deletes a single politically exposed person given the PEP ID.

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
    public class DeletePoliticallyExposedPersonExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new PoliticallyExposedPeopleApi(configuration);
            var politicallyExposedPersonID = 56;  // int? | The ID of the Politically Exposed Person you want to delete.  Example: `/v1/politically_exposed_people/1`

            try {
                // Deleting a politically exposed person
                apiInstance.DeletePoliticallyExposedPerson(politicallyExposedPersonID);
            } catch (ApiException e)
            {
                    Debug.Print("Exception when calling PoliticallyExposedPeopleApi.DeletePoliticallyExposedPerson: " + e.Message );
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

        Dim apiInstance = new PoliticallyExposedPeopleApi(configuration)
        Dim politicallyExposedPersonID = 56 REM int? | The ID of the Politically Exposed Person you want to delete.  Example: `/v1/politically_exposed_people/1`


        Try
            REM Deleting a politically exposed person
            apiInstance.DeletePoliticallyExposedPerson(politicallyExposedPersonID)
        Catch e as ApiException
            Debug.Print("Exception when calling PoliticallyExposedPeopleApi.DeletePoliticallyExposedPerson: " + e.Message );
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **politicallyExposedPersonID** | **int?**| The ID of the Politically Exposed Person you want to delete.  Example: &#x60;/v1/politically_exposed_people/1&#x60; | 

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpoliticallyexposedpeople"></a>
# **GetPoliticallyExposedPeople**
> PoliticallyExposedPersonListResponse GetPoliticallyExposedPeople (Guid? senderId = null)

Listing Politically Exposed People

Get a list of politically exposed people

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
    public class GetPoliticallyExposedPeopleExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new PoliticallyExposedPeopleApi(configuration);
            var senderId = new Guid?(); // Guid? | The ID of the Sender to whom the politically exposed people are attached to.  Example: `/v1/politically_exposed_people?sender_id=344fb668-196d-43db-9d94-b34b7e6c7e0b` (optional) 

            try {
                // Listing Politically Exposed People
                PoliticallyExposedPersonListResponse result = apiInstance.GetPoliticallyExposedPeople(senderId);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    PoliticallyExposedPersonListResponse result = e.ParseObject<PoliticallyExposedPersonListResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling PoliticallyExposedPeopleApi.GetPoliticallyExposedPeople: " + e.Message );
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

        Dim apiInstance = new PoliticallyExposedPeopleApi(configuration)
        Dim senderId = new Guid?() REM Guid? | The ID of the Sender to whom the politically exposed people are attached to.  Example: `/v1/politically_exposed_people?sender_id=344fb668-196d-43db-9d94-b34b7e6c7e0b` (optional) 


        Try
            REM Listing Politically Exposed People
            Dim result As PoliticallyExposedPersonListResponse = apiInstance.GetPoliticallyExposedPeople(senderId)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as PoliticallyExposedPersonListResponse = e.ParseObject(Of PoliticallyExposedPersonListResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling PoliticallyExposedPeopleApi.GetPoliticallyExposedPeople: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **senderId** | [**Guid?**](Guid?.md)| The ID of the Sender to whom the politically exposed people are attached to.  Example: &#x60;/v1/politically_exposed_people?sender_id&#x3D;344fb668-196d-43db-9d94-b34b7e6c7e0b&#x60; | [optional] 

### Return type

[**PoliticallyExposedPersonListResponse**](PoliticallyExposedPersonListResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpoliticallyexposedperson"></a>
# **GetPoliticallyExposedPerson**
> PoliticallyExposedPersonResponse GetPoliticallyExposedPerson (int? politicallyExposedPersonID, Guid? senderId = null)

Fetching a politically exposed person

Returns a single politically exposed person given the PEP ID. Can optionally be filtered using the sender_id query parameter.

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
    public class GetPoliticallyExposedPersonExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new PoliticallyExposedPeopleApi(configuration);
            var politicallyExposedPersonID = 56;  // int? | The ID of the Politically Exposed Person you want to retrieve.  Example: `/v1/politically_exposed_people/1?sender_id=344fb668-196d-43db-9d94-b34b7e6c7e0b`
            var senderId = new Guid?(); // Guid? | The ID of the Sender to whom the politically exposed person is attached to. (optional) 

            try {
                // Fetching a politically exposed person
                PoliticallyExposedPersonResponse result = apiInstance.GetPoliticallyExposedPerson(politicallyExposedPersonID, senderId);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    PoliticallyExposedPersonResponse result = e.ParseObject<PoliticallyExposedPersonResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling PoliticallyExposedPeopleApi.GetPoliticallyExposedPerson: " + e.Message );
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

        Dim apiInstance = new PoliticallyExposedPeopleApi(configuration)
        Dim politicallyExposedPersonID = 56 REM int? | The ID of the Politically Exposed Person you want to retrieve.  Example: `/v1/politically_exposed_people/1?sender_id=344fb668-196d-43db-9d94-b34b7e6c7e0b`
        Dim senderId = new Guid?() REM Guid? | The ID of the Sender to whom the politically exposed person is attached to. (optional) 


        Try
            REM Fetching a politically exposed person
            Dim result As PoliticallyExposedPersonResponse = apiInstance.GetPoliticallyExposedPerson(politicallyExposedPersonID, senderId)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as PoliticallyExposedPersonResponse = e.ParseObject(Of PoliticallyExposedPersonResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling PoliticallyExposedPeopleApi.GetPoliticallyExposedPerson: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **politicallyExposedPersonID** | **int?**| The ID of the Politically Exposed Person you want to retrieve.  Example: &#x60;/v1/politically_exposed_people/1?sender_id&#x3D;344fb668-196d-43db-9d94-b34b7e6c7e0b&#x60; | 
 **senderId** | [**Guid?**](Guid?.md)| The ID of the Sender to whom the politically exposed person is attached to. | [optional] 

### Return type

[**PoliticallyExposedPersonResponse**](PoliticallyExposedPersonResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchpoliticallyexposedperson"></a>
# **PatchPoliticallyExposedPerson**
> PoliticallyExposedPersonResponse PatchPoliticallyExposedPerson (int? politicallyExposedPersonID, PoliticallyExposedPerson politicallyExposedPerson)

Updating a politically exposed person

Updates a single politically exposed person given the PEP ID.

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
    public class PatchPoliticallyExposedPersonExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new PoliticallyExposedPeopleApi(configuration);
            var politicallyExposedPersonID = 56;  // int? | The ID of the Politically Exposed Person you want to update.  Example: `/v1/politically_exposed_people/1`
            var politicallyExposedPerson = new PoliticallyExposedPerson(); // PoliticallyExposedPerson | 

            try {
                // Updating a politically exposed person
                PoliticallyExposedPersonResponse result = apiInstance.PatchPoliticallyExposedPerson(politicallyExposedPersonID, politicallyExposedPerson);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    PoliticallyExposedPersonResponse result = e.ParseObject<PoliticallyExposedPersonResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling PoliticallyExposedPeopleApi.PatchPoliticallyExposedPerson: " + e.Message );
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

        Dim apiInstance = new PoliticallyExposedPeopleApi(configuration)
        Dim politicallyExposedPersonID = 56 REM int? | The ID of the Politically Exposed Person you want to update.  Example: `/v1/politically_exposed_people/1`
        Dim politicallyExposedPerson = new PoliticallyExposedPerson() REM PoliticallyExposedPerson | 


        Try
            REM Updating a politically exposed person
            Dim result As PoliticallyExposedPersonResponse = apiInstance.PatchPoliticallyExposedPerson(politicallyExposedPersonID, politicallyExposedPerson)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as PoliticallyExposedPersonResponse = e.ParseObject(Of PoliticallyExposedPersonResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling PoliticallyExposedPeopleApi.PatchPoliticallyExposedPerson: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **politicallyExposedPersonID** | **int?**| The ID of the Politically Exposed Person you want to update.  Example: &#x60;/v1/politically_exposed_people/1&#x60; | 
 **politicallyExposedPerson** | [**PoliticallyExposedPerson**](PoliticallyExposedPerson.md)|  | 

### Return type

[**PoliticallyExposedPersonResponse**](PoliticallyExposedPersonResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postpoliticallyexposedpeople"></a>
# **PostPoliticallyExposedPeople**
> PoliticallyExposedPersonResponse PostPoliticallyExposedPeople (PoliticallyExposedPerson politicallyExposedPerson)

Creating a politically exposed person

Creates a new politically exposed person in our system. 

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
    public class PostPoliticallyExposedPeopleExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new PoliticallyExposedPeopleApi(configuration);
            var politicallyExposedPerson = new PoliticallyExposedPerson(); // PoliticallyExposedPerson | 

            try {
                // Creating a politically exposed person
                PoliticallyExposedPersonResponse result = apiInstance.PostPoliticallyExposedPeople(politicallyExposedPerson);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    PoliticallyExposedPersonResponse result = e.ParseObject<PoliticallyExposedPersonResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling PoliticallyExposedPeopleApi.PostPoliticallyExposedPeople: " + e.Message );
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

        Dim apiInstance = new PoliticallyExposedPeopleApi(configuration)
        Dim politicallyExposedPerson = new PoliticallyExposedPerson() REM PoliticallyExposedPerson | 


        Try
            REM Creating a politically exposed person
            Dim result As PoliticallyExposedPersonResponse = apiInstance.PostPoliticallyExposedPeople(politicallyExposedPerson)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as PoliticallyExposedPersonResponse = e.ParseObject(Of PoliticallyExposedPersonResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling PoliticallyExposedPeopleApi.PostPoliticallyExposedPeople: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **politicallyExposedPerson** | [**PoliticallyExposedPerson**](PoliticallyExposedPerson.md)|  | 

### Return type

[**PoliticallyExposedPersonResponse**](PoliticallyExposedPersonResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

