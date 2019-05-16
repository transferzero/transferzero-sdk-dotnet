
# TransferZero.Sdk.Model.Sender

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type of sender to create - either person or business (defaults to person)  | [optional] 
**Country** | **string** | Country of sender in 2-character alpha ISO 3166-2 country format | 
**PhoneCountry** | **string** | Phone country of sender in 2-character alpha ISO 3166-2 country format | 
**PhoneNumber** | **string** | Phone number of sender (without country callcode) | [optional] 
**Email** | **string** | Email of sender | 
**FirstName** | **string** | First name of sender (used only with a Personal sender) | [optional] 
**MiddleName** | **string** | Middle name of sender (used only with a Personal sender) | [optional] 
**LastName** | **string** | Last name of sender (used only with a Personal sender) | [optional] 
**Occupation** | **string** | Occupation of sender (used only with a Personal sender) | [optional] 
**Nationality** | **string** | The nationality of the sender (used only with a Personal sender) | [optional] 
**OnboardingStatus** | **string** | The onboarding status of the sender | [optional] 
**Address** | **string** | The address of the sender | [optional] 
**Description** | **string** | Description of the sender | [optional] 
**Name** | **string** | Name of sender (used only with a Business sender) | [optional] 
**City** | **string** | Sender&#39;s city | 
**Street** | **string** | Sender&#39;s street | 
**AddressDescription** | **string** | Description of address | [optional] 
**PostalCode** | **string** | Zip code of sender | 
**BirthDate** | **DateTime?** | Date of birth of sender | [optional] 
**Ip** | **string** | IP of sender | 
**Documents** | [**List&lt;Document&gt;**](Document.md) | Needed for KYC checks. Required to approve the sender unless KYC is waived for your account. Please send us an empty list of documents: &#x60;\&quot;documents\&quot;: [ ]&#x60; in the request if KYC has been waived.  If the documents already exist, please send the Document ID eg. &#x60;&#x60;&#x60;JSON \&quot;documents\&quot;: [   {     \&quot;id\&quot;: \&quot;b6648ba3-1c7b-4f59-8580-684899c84a07\&quot;   } ] &#x60;&#x60;&#x60; | 
**Metadata** | [**Object**](.md) | Metadata of sender. You can store any detail specific to your integration here (for example the local ID of the sender on your end). When requesting sender details you will receive the sent metadata back. Also when sending sender related webhooks you will receive the details stored here as well. | [optional] 
**State** | [**SenderState**](SenderState.md) |  | [optional] 
**Id** | **Guid?** |  | [optional] 
**ExternalId** | **string** | Optional ID that is supplied by partner linking it to the partner&#39;s own Sender ID. Note: if present we will validate whether the sent ID is a duplicate in our system or not. | [optional] 
**Errors** | **Dictionary&lt;string, List&lt;ValidationErrorDescription&gt;&gt;** | The fields that have some problems and don&#39;t pass validation | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

