
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
**IdentificationNumber** | **string** | Identification number of document used | [optional] 
**IdentificationType** | **string** | Document to be identified. The identification type can be one of the following:  - &#x60;DL&#x60;: Driving License - &#x60;PP&#x60;: International Passport - &#x60;ID&#x60;: National ID - &#x60;OT&#x60;: Other | [optional] 
**Documents** | [**List&lt;Document&gt;**](Document.md) | Needed for KYC checks. Required to approve the sender unless KYC is waived for your account. Please send us an empty list of documents: &#x60;\&quot;documents\&quot;: [ ]&#x60; in the request if KYC has been waived.  If the documents already exist, please send the Document ID eg. &#x60;&#x60;&#x60;JSON \&quot;documents\&quot;: [   {     \&quot;id\&quot;: \&quot;b6648ba3-1c7b-4f59-8580-684899c84a07\&quot;   } ] &#x60;&#x60;&#x60; | 
**PoliticallyExposedPeople** | [**List&lt;PoliticallyExposedPerson&gt;**](PoliticallyExposedPerson.md) | A list of politically exposed people, individuals who are or have been entrusted with prominent public functions by a country, for example heads of state or heads of government, senior politicians, senior government, judicial or military officials, senior executives of state owned corporations, important political party officials.  There is a limit of three (3) politically exposed people per Sender.  Politically exposed person example: &#x60;&#x60;&#x60;json   {     \&quot;name\&quot;: \&quot;Ronald Reagan\&quot;,     \&quot;position\&quot;: \&quot;President of the United States\&quot;,     \&quot;started_date\&quot;: \&quot;1981-01-20T00:00:00.000Z\&quot;,     \&quot;ended_date\&quot;: \&quot;1989-01-20T00:00:00.000Z\&quot;   } &#x60;&#x60;&#x60; | [optional] 
**Metadata** | [**Object**](.md) | Metadata of sender. You can store any detail specific to your integration here (for example the local ID of the sender on your end). When requesting sender details you will receive the sent metadata back. Also when sending sender related webhooks you will receive the details stored here as well. | [optional] 
**State** | [**SenderState**](SenderState.md) |  | [optional] 
**Id** | **Guid?** |  | [optional] 
**ExternalId** | **string** | Optional ID that is supplied by partner linking it to the partner&#39;s own Sender ID. Note: if present we will validate whether the sent ID is a duplicate in our system or not. | [optional] 
**Errors** | **Dictionary&lt;string, List&lt;ValidationErrorDescription&gt;&gt;** | The fields that have some problems and don&#39;t pass validation | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

