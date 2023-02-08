# TransferZero.Sdk.Api.EntitiesApi

All URIs are relative to *https://api-sandbox.bitpesa.co/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetEntities**](EntitiesApi.md#getentities) | **GET** /risk_assessment/entities/{Entity Type}/summary | Listing entities
[**GetEntitiesByParams**](EntitiesApi.md#getentitiesbyparams) | **GET** /risk_assessment/entities/{Entity Type}/search | Listing entities by params (rating and/or state)
[**GetEntity**](EntitiesApi.md#getentity) | **GET** /risk_assessment/entities/{Entity Type}/{Entity ID} | Fetching a entity
[**PatchEntity**](EntitiesApi.md#patchentity) | **PATCH** /risk_assessment/entities/{Entity Type}/{Entity ID} | Updating an entity
[**PostEntity**](EntitiesApi.md#postentity) | **POST** /risk_assessment/entities/{Entity Type}/{Entity ID} | Creating an entity


<a name="getentities"></a>
# **GetEntities**
> EntityListResponse GetEntities (string entityType, List<string> ids)

Listing entities

Get a list of entities

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
    public class GetEntitiesExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new EntitiesApi(configuration);
            var entityType = entityType_example;  // string | Type of entities to get.  Example: `/risk_assessment/entities/sender/summary?ids[]=bf9ff782-e182-45ac-abea-5bce83ad6670&ids[]=344fb668-196d-43db-9d94-b34b7e6c7e0b`
            var ids = new List<string>(); // List<string> | Returns entities of specified entity(e.g Sender) id(s). This allows the fetching of entities for multiple e.g. senders  Example: `/risk_assessment/entities/sender?ids[]=bf9ff782-e182-45ac-abea-5bce83ad6670&ids[]=344fb668-196d-43db-9d94-b34b7e6c7e0b`

            try {
                // Listing entities
                EntityListResponse result = apiInstance.GetEntities(entityType, ids);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    EntityListResponse result = e.ParseObject<EntityListResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling EntitiesApi.GetEntities: " + e.Message );
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

        Dim apiInstance = new EntitiesApi(configuration)
        Dim entityType = entityType_example REM string | Type of entities to get.  Example: `/risk_assessment/entities/sender/summary?ids[]=bf9ff782-e182-45ac-abea-5bce83ad6670&ids[]=344fb668-196d-43db-9d94-b34b7e6c7e0b`
        Dim ids = new List<string>() REM List<string> | Returns entities of specified entity(e.g Sender) id(s). This allows the fetching of entities for multiple e.g. senders  Example: `/risk_assessment/entities/sender?ids[]=bf9ff782-e182-45ac-abea-5bce83ad6670&ids[]=344fb668-196d-43db-9d94-b34b7e6c7e0b`


        Try
            REM Listing entities
            Dim result As EntityListResponse = apiInstance.GetEntities(entityType, ids)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as EntityListResponse = e.ParseObject(Of EntityListResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling EntitiesApi.GetEntities: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entityType** | **string**| Type of entities to get.  Example: &#x60;/risk_assessment/entities/sender/summary?ids[]&#x3D;bf9ff782-e182-45ac-abea-5bce83ad6670&amp;ids[]&#x3D;344fb668-196d-43db-9d94-b34b7e6c7e0b&#x60; | 
 **ids** | [**List&lt;string&gt;**](string.md)| Returns entities of specified entity(e.g Sender) id(s). This allows the fetching of entities for multiple e.g. senders  Example: &#x60;/risk_assessment/entities/sender?ids[]&#x3D;bf9ff782-e182-45ac-abea-5bce83ad6670&amp;ids[]&#x3D;344fb668-196d-43db-9d94-b34b7e6c7e0b&#x60; | 

### Return type

[**EntityListResponse**](EntityListResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getentitiesbyparams"></a>
# **GetEntitiesByParams**
> EntityListResponse GetEntitiesByParams (string entityType, string rating = null, string state = null)

Listing entities by params (rating and/or state)

Get a list of entities scoped by the requested params (rating and/or state)

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
    public class GetEntitiesByParamsExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new EntitiesApi(configuration);
            var entityType = entityType_example;  // string | Type of entities to retrieve.  Example: `/risk_assessment/entities/sender/search?rating=extremely_high&state=complete`
            var rating = rating_example;  // string | Returns a list of entities scoped by the Entity rating (rating param can be one of 'extremely_high', 'high_risk', 'medium_risk' or 'low_risk')  Example: `/risk_assessment/entities/Sender::Business/search?rating=extremely_high` (optional) 
            var state = state_example;  // string | Returns a list of entities scoped by the Entity state (state param can be one of 'complete' or 'incomplete')  Example: `/risk_assessment/entities/Sender::Business/search?state=complete` (optional) 

            try {
                // Listing entities by params (rating and/or state)
                EntityListResponse result = apiInstance.GetEntitiesByParams(entityType, rating, state);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    EntityListResponse result = e.ParseObject<EntityListResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling EntitiesApi.GetEntitiesByParams: " + e.Message );
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

        Dim apiInstance = new EntitiesApi(configuration)
        Dim entityType = entityType_example REM string | Type of entities to retrieve.  Example: `/risk_assessment/entities/sender/search?rating=extremely_high&state=complete`
        Dim rating = rating_example REM string | Returns a list of entities scoped by the Entity rating (rating param can be one of 'extremely_high', 'high_risk', 'medium_risk' or 'low_risk')  Example: `/risk_assessment/entities/Sender::Business/search?rating=extremely_high` (optional) 
        Dim state = state_example REM string | Returns a list of entities scoped by the Entity state (state param can be one of 'complete' or 'incomplete')  Example: `/risk_assessment/entities/Sender::Business/search?state=complete` (optional) 


        Try
            REM Listing entities by params (rating and/or state)
            Dim result As EntityListResponse = apiInstance.GetEntitiesByParams(entityType, rating, state)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as EntityListResponse = e.ParseObject(Of EntityListResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling EntitiesApi.GetEntitiesByParams: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entityType** | **string**| Type of entities to retrieve.  Example: &#x60;/risk_assessment/entities/sender/search?rating&#x3D;extremely_high&amp;state&#x3D;complete&#x60; | 
 **rating** | **string**| Returns a list of entities scoped by the Entity rating (rating param can be one of &#39;extremely_high&#39;, &#39;high_risk&#39;, &#39;medium_risk&#39; or &#39;low_risk&#39;)  Example: &#x60;/risk_assessment/entities/Sender::Business/search?rating&#x3D;extremely_high&#x60; | [optional] 
 **state** | **string**| Returns a list of entities scoped by the Entity state (state param can be one of &#39;complete&#39; or &#39;incomplete&#39;)  Example: &#x60;/risk_assessment/entities/Sender::Business/search?state&#x3D;complete&#x60; | [optional] 

### Return type

[**EntityListResponse**](EntityListResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getentity"></a>
# **GetEntity**
> EntityCreateResponse GetEntity (string entityType, Guid? entityID)

Fetching a entity

Returns a single entity by the Entity ID

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
    public class GetEntityExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new EntitiesApi(configuration);
            var entityType = entityType_example;  // string | Type of entities to get.  Example: `/risk_assessment/entities/sender/bf9ff782-e182-45ac-abea-5bce83ad6670`
            var entityID = new Guid?(); // Guid? | ID of the entity to get.  Example: `/risk_assessment/entities/sender/bf9ff782-e182-45ac-abea-5bce83ad6670`

            try {
                // Fetching a entity
                EntityCreateResponse result = apiInstance.GetEntity(entityType, entityID);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    EntityCreateResponse result = e.ParseObject<EntityCreateResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling EntitiesApi.GetEntity: " + e.Message );
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

        Dim apiInstance = new EntitiesApi(configuration)
        Dim entityType = entityType_example REM string | Type of entities to get.  Example: `/risk_assessment/entities/sender/bf9ff782-e182-45ac-abea-5bce83ad6670`
        Dim entityID = new Guid?() REM Guid? | ID of the entity to get.  Example: `/risk_assessment/entities/sender/bf9ff782-e182-45ac-abea-5bce83ad6670`


        Try
            REM Fetching a entity
            Dim result As EntityCreateResponse = apiInstance.GetEntity(entityType, entityID)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as EntityCreateResponse = e.ParseObject(Of EntityCreateResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling EntitiesApi.GetEntity: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entityType** | **string**| Type of entities to get.  Example: &#x60;/risk_assessment/entities/sender/bf9ff782-e182-45ac-abea-5bce83ad6670&#x60; | 
 **entityID** | [**Guid?**](Guid?.md)| ID of the entity to get.  Example: &#x60;/risk_assessment/entities/sender/bf9ff782-e182-45ac-abea-5bce83ad6670&#x60; | 

### Return type

[**EntityCreateResponse**](EntityCreateResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="patchentity"></a>
# **PatchEntity**
> EntityUpdateResponse PatchEntity (string entityType, Guid? entityID, EntityUpdateRequest entityUpdateRequest)

Updating an entity

Updates a single entity by the Entity ID

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
    public class PatchEntityExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new EntitiesApi(configuration);
            var entityType = entityType_example;  // string | Type of entities to get.  Example: `/risk_assessment/entities/sender/bf9ff782-e182-45ac-abea-5bce83ad6670`
            var entityID = new Guid?(); // Guid? | ID of the entity to get.  Example: `/risk_assessment/entities/sender/bf9ff782-e182-45ac-abea-5bce83ad6670`
            var entityUpdateRequest = new EntityUpdateRequest(); // EntityUpdateRequest | 

            try {
                // Updating an entity
                EntityUpdateResponse result = apiInstance.PatchEntity(entityType, entityID, entityUpdateRequest);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    EntityUpdateResponse result = e.ParseObject<EntityUpdateResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling EntitiesApi.PatchEntity: " + e.Message );
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

        Dim apiInstance = new EntitiesApi(configuration)
        Dim entityType = entityType_example REM string | Type of entities to get.  Example: `/risk_assessment/entities/sender/bf9ff782-e182-45ac-abea-5bce83ad6670`
        Dim entityID = new Guid?() REM Guid? | ID of the entity to get.  Example: `/risk_assessment/entities/sender/bf9ff782-e182-45ac-abea-5bce83ad6670`
        Dim entityUpdateRequest = new EntityUpdateRequest() REM EntityUpdateRequest | 


        Try
            REM Updating an entity
            Dim result As EntityUpdateResponse = apiInstance.PatchEntity(entityType, entityID, entityUpdateRequest)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as EntityUpdateResponse = e.ParseObject(Of EntityUpdateResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling EntitiesApi.PatchEntity: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entityType** | **string**| Type of entities to get.  Example: &#x60;/risk_assessment/entities/sender/bf9ff782-e182-45ac-abea-5bce83ad6670&#x60; | 
 **entityID** | [**Guid?**](Guid?.md)| ID of the entity to get.  Example: &#x60;/risk_assessment/entities/sender/bf9ff782-e182-45ac-abea-5bce83ad6670&#x60; | 
 **entityUpdateRequest** | [**EntityUpdateRequest**](EntityUpdateRequest.md)|  | 

### Return type

[**EntityUpdateResponse**](EntityUpdateResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postentity"></a>
# **PostEntity**
> EntityCreateResponse PostEntity (string entityType, Guid? entityID, EntityCreateRequest entityCreateRequest)

Creating an entity

Creates a new entity. 

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
    public class PostEntityExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new EntitiesApi(configuration);
            var entityType = entityType_example;  // string | Type of entity to create.
            var entityID = new Guid?(); // Guid? | ID of entity type to create entity for.  Example: `/risk_assessment/entities/sender/e6f67a67-b2c2-4897-ad58-9fc3a9d8d991`
            var entityCreateRequest = new EntityCreateRequest(); // EntityCreateRequest | 

            try {
                // Creating an entity
                EntityCreateResponse result = apiInstance.PostEntity(entityType, entityID, entityCreateRequest);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    EntityCreateResponse result = e.ParseObject<EntityCreateResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling EntitiesApi.PostEntity: " + e.Message );
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

        Dim apiInstance = new EntitiesApi(configuration)
        Dim entityType = entityType_example REM string | Type of entity to create.
        Dim entityID = new Guid?() REM Guid? | ID of entity type to create entity for.  Example: `/risk_assessment/entities/sender/e6f67a67-b2c2-4897-ad58-9fc3a9d8d991`
        Dim entityCreateRequest = new EntityCreateRequest() REM EntityCreateRequest | 


        Try
            REM Creating an entity
            Dim result As EntityCreateResponse = apiInstance.PostEntity(entityType, entityID, entityCreateRequest)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as EntityCreateResponse = e.ParseObject(Of EntityCreateResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling EntitiesApi.PostEntity: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entityType** | **string**| Type of entity to create. | 
 **entityID** | [**Guid?**](Guid?.md)| ID of entity type to create entity for.  Example: &#x60;/risk_assessment/entities/sender/e6f67a67-b2c2-4897-ad58-9fc3a9d8d991&#x60; | 
 **entityCreateRequest** | [**EntityCreateRequest**](EntityCreateRequest.md)|  | 

### Return type

[**EntityCreateResponse**](EntityCreateResponse.md)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

