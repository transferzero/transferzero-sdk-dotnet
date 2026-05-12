# TransferZero.Sdk.Api.MandatesApi

All URIs are relative to *https://api-sandbox.transferzero.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetMandate**](MandatesApi.md#getmandate) | **GET** /mandates/{Mandate ID} | Fetch a single mandate


<a name="getmandate"></a>
# **GetMandate**
> MandateResponse GetMandate (Guid? mandateID)

Fetch a single mandate

Finds and returns a Mandate created within the current calendar year, where the mandate is linked to a Recipient owned by the authenticated API key.  Returns 404 if the mandate is not owned by the API key or was not issued in the current calendar year — mandates are only valid for the year in which they were issued.

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
    public class GetMandateExample
    {
        public void main()
        {
            Configuration configuration = new Configuration();
            configuration.ApiKey = "<key>";
            configuration.ApiSecret = "<secret>";
            configuration.BasePath = "https://api-sandbox.transferzero.com/v1";

            var apiInstance = new MandatesApi(configuration);
            var mandateID = new Guid?(); // Guid? | ID of the mandate.  Example: `/v1/mandates/bf9ff782-e182-45ac-abea-5bce83ad6670`

            try {
                // Fetch a single mandate
                MandateResponse result = apiInstance.GetMandate(mandateID);
                Debug.WriteLine(result);
            } catch (ApiException e)
            {
                if (e.IsValidationError) {
                    // In case there was a validation error, obtain the object
                    MandateResponse result = e.ParseObject<MandateResponse>();
                    Debug.WriteLing("There was a validation error while processing!");
                    Debug.WriteLine(result);
                } else {
                    Debug.Print("Exception when calling MandatesApi.GetMandate: " + e.Message );
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

        Dim apiInstance = new MandatesApi(configuration)
        Dim mandateID = new Guid?() REM Guid? | ID of the mandate.  Example: `/v1/mandates/bf9ff782-e182-45ac-abea-5bce83ad6670`


        Try
            REM Fetch a single mandate
            Dim result As MandateResponse = apiInstance.GetMandate(mandateID)
            Debug.WriteLine(result)
        Catch e as ApiException
            If e.IsValidationError Then
                REM In case there was a validation error, obtain the object
                Dim result as MandateResponse = e.ParseObject(Of MandateResponse)()
                Debug.WriteLine("There was a validation error while processing!")
                Debug.WriteLine(result)
            Else
                Debug.Print("Exception when calling MandatesApi.GetMandate: " + e.Message )
            End If
        End Try
    End Sub
End Module
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mandateID** | [**Guid?**](Guid?.md)| ID of the mandate.  Example: &#x60;/v1/mandates/bf9ff782-e182-45ac-abea-5bce83ad6670&#x60; | 

### Return type

[**MandateResponse**](MandateResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

