
# TransferZero.Sdk.Model.Sender

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid?** |  | [optional] 
**Type** | **string** | Type of sender to create - either person or business (defaults to person)  | [optional] 
**State** | [**SenderState**](SenderState.md) |  | [optional] 
**Country** | **string** | Country of sender in 2-character alpha ISO 3166-2 country format | 
**Street** | **string** | Sender&#39;s street | 
**PostalCode** | **string** | Zip code of sender | 
**City** | **string** | Sender&#39;s city | 
**PhoneCountry** | **string** | Phone country of sender in 2-character alpha ISO 3166-2 country format | 
**PhoneNumber** | **string** | Phone number of sender (without country callcode) | [optional] 
**Email** | **string** | Email of sender | 
**Ip** | **string** | IP of sender | 
**AddressDescription** | **string** | Description of address | [optional] 
**IdentificationNumber** | **string** | Identification number of document used | [optional] 
**IdentificationType** | **string** | Document to be identified. The identification type can be one of the following:  - &#x60;DL&#x60;: Driving License - &#x60;PP&#x60;: International Passport - &#x60;ID&#x60;: National ID - &#x60;OT&#x60;: Other | [optional] 
**Name** | **string** | Name of sender (used only with a Business sender) | [optional] 
**FirstName** | **string** | First name of sender (used only with a Personal sender) | [optional] 
**MiddleName** | **string** | Middle name of sender (used only with a Personal sender) | [optional] 
**LastName** | **string** | Last name of sender (used only with a Personal sender) | [optional] 
**BirthDate** | **DateTime?** | Date of birth of sender (used only with a Personal sender) | [optional] 
**Occupation** | **string** | Occupation of sender (used only with a Personal sender) | [optional] 
**Nationality** | **string** | The nationality of the sender (used only with a Personal sender) | [optional] 
**LegalEntityType** | **string** | Legal entity type (used only with a Business sender) | [optional] 
**RegistrationDate** | **string** | The registration date (used only with a Business sender) | [optional] 
**RegistrationNumber** | **string** | The registration number (used only with a Business sender) | [optional] 
**NatureOfBusiness** | **string** | Nature of business options (used only with a Business sender) | [optional] 
**SourceOfFunds** | **string** | The source of funds | [optional] 
**CoreBusinessActivities** | **string** | The core activities (used only with a Business sender) | [optional] 
**PurposeOfOpeningAccount** | **string** | The purpose for opening their account (used only with a Business sender) | [optional] 
**OfficePhone** | **string** | The official phone number (used only with a Business sender) | [optional] 
**VatRegistrationNumber** | **string** | The VAT registration number (used only with a Business sender) | [optional] 
**FinancialRegulator** | **string** | The Financial Regulator (used only with a Business sender) | [optional] 
**RegulatoryLicenceNumber** | **string** | The Regulatory Licence Number (used only with a Business sender) | [optional] 
**ContactPersonEmail** | **string** | The contact&#39;s email address (used only with a Business sender) | [optional] 
**TradingCountry** | **string** | The Business trading country (used only with a Business sender) | [optional] 
**TradingAddress** | **string** | The Business trading address (used only with a Business sender) | [optional] 
**Documents** | [**List&lt;Document&gt;**](Document.md) | Needed for KYC checks. Required to approve the sender unless KYC is waived for your account. Please send us an empty list of documents: &#x60;\&quot;documents\&quot;: [ ]&#x60; in the request if KYC has been waived.  If the documents already exist, please send the Document ID eg. &#x60;&#x60;&#x60;JSON \&quot;documents\&quot;: [   {     \&quot;id\&quot;: \&quot;b6648ba3-1c7b-4f59-8580-684899c84a07\&quot;   } ] &#x60;&#x60;&#x60; | 
**Metadata** | [**Object**](.md) | Metadata of sender. You can store any detail specific to your integration here (for example the local ID of the sender on your end). When requesting sender details you will receive the sent metadata back. Also when sending sender related webhooks you will receive the details stored here as well. | [optional] 
**Errors** | **Dictionary&lt;string, List&lt;ValidationErrorDescription&gt;&gt;** | The fields that have some problems and don&#39;t pass validation | [optional] 
**OnboardingStatus** | **string** | The onboarding status of the sender | [optional] 
**PoliticallyExposedPeople** | [**List&lt;PoliticallyExposedPerson&gt;**](PoliticallyExposedPerson.md) | A list of politically exposed people, individuals who are or have been entrusted with prominent public functions by a country, for example heads of state or heads of government, senior politicians, senior government, judicial or military officials, senior executives of state owned corporations, important political party officials.  There is a limit of three (3) politically exposed people per Sender.  Politically exposed person example: &#x60;&#x60;&#x60;json   {     \&quot;name\&quot;: \&quot;Ronald Reagan\&quot;,     \&quot;position\&quot;: \&quot;President of the United States\&quot;,     \&quot;started_date\&quot;: \&quot;1981-01-20T00:00:00.000Z\&quot;,     \&quot;ended_date\&quot;: \&quot;1989-01-20T00:00:00.000Z\&quot;   } &#x60;&#x60;&#x60; | [optional] 
**ExternalId** | **string** | Optional ID that is supplied by partner linking it to the partner&#39;s own Sender ID. Note: if present we will validate whether the sent ID is a duplicate in our system or not. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

