# TransferZero.Sdk - the C# library for the TransferZero API

TransferZero API

- API version: 1.0

Reference documentation for the TransferZero API V1

For more information, please visit:

* [API Documentation](https://docs.transferzero.com)
  * [Onboarding guide](https://docs.transferzero.com/docs/quick-integration/)
  * [Transaction flow](https://docs.transferzero.com/docs/transaction-flow/)
  * [Additional features](https://docs.transferzero.com/docs/additional-features/)
* [API Specification](https://api.transferzero.com/documentation)

This .NET SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.0
- SDK version: 1.7.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.5 or later
- .NET Core >=2.0

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 10.0.3 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using TransferZero.Sdk.Api;
using TransferZero.Sdk.Client;
using TransferZero.Sdk.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out TransferZero.Sdk.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

Please follow the [installation](#installation) instruction.

You can find examples in the `examples` directory on the features required by the [Onboarding documentation](https://docs.transferzero.com/docs/quick-integration/) for the following languages:

- C# on .NET 4.5
- VB.NET on .NET 4.5
- C# on .NET Core 2.0

<a name="webhooks"></a>
## Webhooks

To parse webhooks you can use the following snippet:

### C#

```csharp
string webhookContent = "<data from webhook>";

string url = "<url of the webhook endpoint>";

Dictionary<string, string> headers = new Dictionary<string, string>();
headers.Add("Authorization-Nonce", "<nonce from webhook headers>");
headers.Add("Authorization-Signature", "<signature from webhook headerse>");
headers.Add("Authorization-Key", "<key from webhook headers>");

if (configuration.ValidWebhookRequest(url, webhookContent, headers)) {
    Webhook webhook = configuration.ParseString<Webhook>(webhookContent);

    if (webhook.Event.StartsWith("transaction"))
    {
        TransactionWebhook transactionWebhook = configuration.ParseString<TransactionWebhook>(webhookContent);
        System.Console.WriteLine(transactionWebhook);
    }
    else if (webhook.Event.StartsWith("recipient"))
    {
        RecipientWebhook recipientWebhook = configuration.ParseString<RecipientWebhook>(webhookContent);
        System.Console.WriteLine(recipientWebhook);
    }
    else if (webhook.Event.StartsWith("sender"))
    {
        SenderWebhook senderWebhook = configuration.ParseString<SenderWebhook>(webhookContent);
        System.Console.WriteLine(senderWebhook);
    }
    else if (webhook.Event.StartsWith("document"))
    {
        DocumentWebhook documentWebhook = configuration.ParseString<DocumentWebhook>(webhookContent);
        System.Console.WriteLine(documentWebhook);
    }
    else if (webhook.Event.StartsWith("payout_method"))
    {
        PayoutMethodWebhook payoutMethodWebhook = configuration.ParseString<PayoutMethodWebhook>(webhookContent);
        System.Console.WriteLine(payoutMethodWebhook);
    }
}
```

### VB.NET

```vbnet
Dim webhookContent As String = "{<data from webhook>}"

Dim url As String = "<url of webhook request>"
Dim headers As Dictionary(Of String, String) = New Dictionary(Of String, String)()

headers.Add("Authorization-Nonce", "<nonce from webhook headers>")
headers.Add("Authorization-Signature", "<signature from webhook headers>")
headers.Add("Authorization-Key", "<key from webhook headers>")

If configuration.ValidWebhookRequest(url, webhookContent, headers) Then
    Dim webhook As Webhook = configuration.ParseString(Of Webhook)(webhookContent)

    If webhook.[Event].StartsWith("transaction") Then
        Dim transactionWebhook As TransactionWebhook = configuration.ParseString(Of TransactionWebhook)(webhookContent)
        System.Console.WriteLine(transactionWebhook)
    ElseIf webhook.[Event].StartsWith("recipient") Then
        Dim recipientWebhook As RecipientWebhook = configuration.ParseString(Of RecipientWebhook)(webhookContent)
        System.Console.WriteLine(recipientWebhook)
    ElseIf webhook.[Event].StartsWith("sender") Then
        Dim senderWebhook As SenderWebhook = configuration.ParseString(Of SenderWebhook)(webhookContent)
        System.Console.WriteLine(senderWebhook)
    ElseIf webhook.[Event].StartsWith("document") Then
        Dim documentWebhook As DocumentWebhook = configuration.ParseString(Of DocumentWebhook)(webhookContent)
        System.Console.WriteLine(documentWebhook)
    ElseIf webhook.[Event].StartsWith("payout_method") Then
        Dim payoutMethodWebhook As PayoutMethodWebhook = configuration.ParseString(Of PayoutMethodWebhook)(webhookContent)
        System.Console.WriteLine(payoutMethodWebhook)
    End If
End If
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api-sandbox.transferzero.com/v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*APILogsApi* | [**GetApiLog**](docs/APILogsApi.md#getapilog) | **GET** /api_logs/{API Log ID} | Fetch an individual API log
*APILogsApi* | [**GetApiLogs**](docs/APILogsApi.md#getapilogs) | **GET** /api_logs | Fetch a list of API logs
*AccountDebitsApi* | [**GetAccountsDebit**](docs/AccountDebitsApi.md#getaccountsdebit) | **GET** /accounts/debits/{Account Debit ID} | Fetching an account debit
*AccountDebitsApi* | [**GetAccountsDebits**](docs/AccountDebitsApi.md#getaccountsdebits) | **GET** /accounts/debits | Listing Accounts debits
*AccountDebitsApi* | [**PostAccountsDebits**](docs/AccountDebitsApi.md#postaccountsdebits) | **POST** /accounts/debits | Creating an account debit
*AccountValidationApi* | [**PostAccountValidations**](docs/AccountValidationApi.md#postaccountvalidations) | **POST** /account_validations | Validates the existence of a bank account or a mobile phone number
*AccountsApi* | [**GetAccount**](docs/AccountsApi.md#getaccount) | **GET** /accounts/{Currency} | Fetches account balance for specified currrency
*AccountsApi* | [**GetAccounts**](docs/AccountsApi.md#getaccounts) | **GET** /accounts | Fetches account balances for all currencies
*CurrencyInfoApi* | [**InfoCurrencies**](docs/CurrencyInfoApi.md#infocurrencies) | **GET** /info/currencies | Getting a list of possible requested currencies
*CurrencyInfoApi* | [**InfoCurrenciesIn**](docs/CurrencyInfoApi.md#infocurrenciesin) | **GET** /info/currencies/in | Getting a list of possible input currencies
*CurrencyInfoApi* | [**InfoCurrenciesOut**](docs/CurrencyInfoApi.md#infocurrenciesout) | **GET** /info/currencies/out | Getting a list of possible output currencies
*DocumentsApi* | [**GetDocument**](docs/DocumentsApi.md#getdocument) | **GET** /documents/{Document ID} | Fetching a document
*DocumentsApi* | [**GetDocuments**](docs/DocumentsApi.md#getdocuments) | **GET** /documents | Getting a list of documents
*DocumentsApi* | [**PostDocuments**](docs/DocumentsApi.md#postdocuments) | **POST** /documents | Creating a document
*LogsApi* | [**GetWebhookLog**](docs/LogsApi.md#getwebhooklog) | **GET** /logs/{Webhook Log ID} | Fetch an individual webhook log
*LogsApi* | [**GetWebhookLogs**](docs/LogsApi.md#getwebhooklogs) | **GET** /logs/webhooks | Fetch a list of webhook logs
*PaymentMethodsApi* | [**PaymentMethodsIn**](docs/PaymentMethodsApi.md#paymentmethodsin) | **GET** /info/payment_methods/in | This method returns possible payin methods.
*PaymentMethodsApi* | [**PaymentMethodsOut**](docs/PaymentMethodsApi.md#paymentmethodsout) | **GET** /info/payment_methods/out | This method returns possible payout methods.
*PayoutMethodsApi* | [**DeletePayoutMethod**](docs/PayoutMethodsApi.md#deletepayoutmethod) | **DELETE** /payout_methods/{Payout Method ID} | Deleting a payout method
*PayoutMethodsApi* | [**GetPayoutMethod**](docs/PayoutMethodsApi.md#getpayoutmethod) | **GET** /payout_methods/{Payout Method ID} | Fetching a payout method
*PayoutMethodsApi* | [**GetPayoutMethods**](docs/PayoutMethodsApi.md#getpayoutmethods) | **GET** /payout_methods | Listing payout methods
*PayoutMethodsApi* | [**PatchPayoutMethod**](docs/PayoutMethodsApi.md#patchpayoutmethod) | **PATCH** /payout_methods/{Payout Method ID} | Updating a payout method
*PayoutMethodsApi* | [**PostPayoutMethods**](docs/PayoutMethodsApi.md#postpayoutmethods) | **POST** /payout_methods | Creating a payout method
*RecipientsApi* | [**DeleteRecipient**](docs/RecipientsApi.md#deleterecipient) | **DELETE** /recipients/{Recipient ID} | Cancelling a recipient
*RecipientsApi* | [**GetRecipients**](docs/RecipientsApi.md#getrecipients) | **GET** /recipients | Getting a list of recipients with filtering
*RecipientsApi* | [**PatchRecipient**](docs/RecipientsApi.md#patchrecipient) | **PATCH** /recipients/{Recipient ID} | Updating a recipient
*SendersApi* | [**DeleteSender**](docs/SendersApi.md#deletesender) | **DELETE** /senders/{Sender ID} | Deleting a sender
*SendersApi* | [**GetSender**](docs/SendersApi.md#getsender) | **GET** /senders/{Sender ID} | Fetching a sender
*SendersApi* | [**GetSenders**](docs/SendersApi.md#getsenders) | **GET** /senders | Listing senders
*SendersApi* | [**PatchSender**](docs/SendersApi.md#patchsender) | **PATCH** /senders/{Sender ID} | Updating a sender
*SendersApi* | [**PostSenders**](docs/SendersApi.md#postsenders) | **POST** /senders | Creating a sender
*TransactionsApi* | [**CalculateTransactions**](docs/TransactionsApi.md#calculatetransactions) | **POST** /transactions/calculate | Calculates transaction amounts for a transaction payload
*TransactionsApi* | [**CreateAndFundTransaction**](docs/TransactionsApi.md#createandfundtransaction) | **POST** /transactions/create_and_fund | Creates a new transaction and funds it from account balance
*TransactionsApi* | [**GetTransaction**](docs/TransactionsApi.md#gettransaction) | **GET** /transactions/{Transaction ID} | Fetch a single transaction
*TransactionsApi* | [**GetTransactions**](docs/TransactionsApi.md#gettransactions) | **GET** /transactions | Get a list of transactions
*TransactionsApi* | [**PayinTransaction**](docs/TransactionsApi.md#payintransaction) | **POST** /transactions/{Transaction ID}/payin | Creates a fake payin for transaction
*TransactionsApi* | [**PayoutTransaction**](docs/TransactionsApi.md#payouttransaction) | **POST** /transactions/{Transaction ID}/payout | Creates a fake payout for transaction
*TransactionsApi* | [**PostTransactions**](docs/TransactionsApi.md#posttransactions) | **POST** /transactions | Creates a new transaction
*TransactionsApi* | [**ValidateTransactions**](docs/TransactionsApi.md#validatetransactions) | **POST** /transactions/validate | Validates a transaction payload
*WebhooksApi* | [**DeleteWebhook**](docs/WebhooksApi.md#deletewebhook) | **DELETE** /webhooks/{Webhook ID} | Unsubscribing from a webhook
*WebhooksApi* | [**GetWebhook**](docs/WebhooksApi.md#getwebhook) | **GET** /webhooks/{Webhook ID} | Find a webhook's details
*WebhooksApi* | [**GetWebhookEvents**](docs/WebhooksApi.md#getwebhookevents) | **GET** /webhooks/events | Find possible webhook events
*WebhooksApi* | [**GetWebhooks**](docs/WebhooksApi.md#getwebhooks) | **GET** /webhooks | Listing webhooks
*WebhooksApi* | [**PostWebhooks**](docs/WebhooksApi.md#postwebhooks) | **POST** /webhooks | Creating a webhook


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.Account](docs/Account.md)
 - [Model.AccountListResponse](docs/AccountListResponse.md)
 - [Model.AccountMeta](docs/AccountMeta.md)
 - [Model.AccountResponse](docs/AccountResponse.md)
 - [Model.AccountValidationError](docs/AccountValidationError.md)
 - [Model.AccountValidationRequest](docs/AccountValidationRequest.md)
 - [Model.AccountValidationResponse](docs/AccountValidationResponse.md)
 - [Model.AccountValidationResult](docs/AccountValidationResult.md)
 - [Model.ApiLog](docs/ApiLog.md)
 - [Model.ApiLogListResponse](docs/ApiLogListResponse.md)
 - [Model.ApiLogResponse](docs/ApiLogResponse.md)
 - [Model.Currency](docs/Currency.md)
 - [Model.CurrencyExchange](docs/CurrencyExchange.md)
 - [Model.CurrencyExchangeListResponse](docs/CurrencyExchangeListResponse.md)
 - [Model.CurrencyListResponse](docs/CurrencyListResponse.md)
 - [Model.CurrencyOpposite](docs/CurrencyOpposite.md)
 - [Model.Debit](docs/Debit.md)
 - [Model.DebitListRequest](docs/DebitListRequest.md)
 - [Model.DebitListResponse](docs/DebitListResponse.md)
 - [Model.DebitRequest](docs/DebitRequest.md)
 - [Model.DebitRequestWrapper](docs/DebitRequestWrapper.md)
 - [Model.DebitResponse](docs/DebitResponse.md)
 - [Model.Document](docs/Document.md)
 - [Model.DocumentListResponse](docs/DocumentListResponse.md)
 - [Model.DocumentRequest](docs/DocumentRequest.md)
 - [Model.DocumentResponse](docs/DocumentResponse.md)
 - [Model.DocumentWebhook](docs/DocumentWebhook.md)
 - [Model.ErrorStatus](docs/ErrorStatus.md)
 - [Model.FieldDescription](docs/FieldDescription.md)
 - [Model.FieldSelectValidation](docs/FieldSelectValidation.md)
 - [Model.FieldValidation](docs/FieldValidation.md)
 - [Model.Pagination](docs/Pagination.md)
 - [Model.PaginationMeta](docs/PaginationMeta.md)
 - [Model.PayinMethod](docs/PayinMethod.md)
 - [Model.PayinMethodDetails](docs/PayinMethodDetails.md)
 - [Model.PayinMethodDetailsBTC](docs/PayinMethodDetailsBTC.md)
 - [Model.PayinMethodDetailsMobile](docs/PayinMethodDetailsMobile.md)
 - [Model.PayinMethodDetailsNGNBank](docs/PayinMethodDetailsNGNBank.md)
 - [Model.PayinMethodRequest](docs/PayinMethodRequest.md)
 - [Model.PaymentMethod](docs/PaymentMethod.md)
 - [Model.PaymentMethodListResponse](docs/PaymentMethodListResponse.md)
 - [Model.PaymentMethodOpposite](docs/PaymentMethodOpposite.md)
 - [Model.PayoutMethod](docs/PayoutMethod.md)
 - [Model.PayoutMethodBankAccountTypeEnum](docs/PayoutMethodBankAccountTypeEnum.md)
 - [Model.PayoutMethodDetails](docs/PayoutMethodDetails.md)
 - [Model.PayoutMethodDetailsBTC](docs/PayoutMethodDetailsBTC.md)
 - [Model.PayoutMethodDetailsBalance](docs/PayoutMethodDetailsBalance.md)
 - [Model.PayoutMethodDetailsGBPBank](docs/PayoutMethodDetailsGBPBank.md)
 - [Model.PayoutMethodDetailsGHSBank](docs/PayoutMethodDetailsGHSBank.md)
 - [Model.PayoutMethodDetailsIBAN](docs/PayoutMethodDetailsIBAN.md)
 - [Model.PayoutMethodDetailsMADCash](docs/PayoutMethodDetailsMADCash.md)
 - [Model.PayoutMethodDetailsMobile](docs/PayoutMethodDetailsMobile.md)
 - [Model.PayoutMethodDetailsNGNBank](docs/PayoutMethodDetailsNGNBank.md)
 - [Model.PayoutMethodDetailsXOFBank](docs/PayoutMethodDetailsXOFBank.md)
 - [Model.PayoutMethodDetailsXOFMobile](docs/PayoutMethodDetailsXOFMobile.md)
 - [Model.PayoutMethodDetailsZARBank](docs/PayoutMethodDetailsZARBank.md)
 - [Model.PayoutMethodGenderEnum](docs/PayoutMethodGenderEnum.md)
 - [Model.PayoutMethodIdentityCardTypeEnum](docs/PayoutMethodIdentityCardTypeEnum.md)
 - [Model.PayoutMethodListResponse](docs/PayoutMethodListResponse.md)
 - [Model.PayoutMethodMobileProviderEnum](docs/PayoutMethodMobileProviderEnum.md)
 - [Model.PayoutMethodRequest](docs/PayoutMethodRequest.md)
 - [Model.PayoutMethodResponse](docs/PayoutMethodResponse.md)
 - [Model.PayoutMethodWebhook](docs/PayoutMethodWebhook.md)
 - [Model.PoliticallyExposedPerson](docs/PoliticallyExposedPerson.md)
 - [Model.Recipient](docs/Recipient.md)
 - [Model.RecipientListResponse](docs/RecipientListResponse.md)
 - [Model.RecipientRequest](docs/RecipientRequest.md)
 - [Model.RecipientResponse](docs/RecipientResponse.md)
 - [Model.RecipientState](docs/RecipientState.md)
 - [Model.RecipientWebhook](docs/RecipientWebhook.md)
 - [Model.Sender](docs/Sender.md)
 - [Model.SenderListResponse](docs/SenderListResponse.md)
 - [Model.SenderRequest](docs/SenderRequest.md)
 - [Model.SenderResponse](docs/SenderResponse.md)
 - [Model.SenderResponseExisting](docs/SenderResponseExisting.md)
 - [Model.SenderResponseMeta](docs/SenderResponseMeta.md)
 - [Model.SenderState](docs/SenderState.md)
 - [Model.SenderWebhook](docs/SenderWebhook.md)
 - [Model.Transaction](docs/Transaction.md)
 - [Model.TransactionListResponse](docs/TransactionListResponse.md)
 - [Model.TransactionRequest](docs/TransactionRequest.md)
 - [Model.TransactionResponse](docs/TransactionResponse.md)
 - [Model.TransactionResponseExisting](docs/TransactionResponseExisting.md)
 - [Model.TransactionResponseMeta](docs/TransactionResponseMeta.md)
 - [Model.TransactionState](docs/TransactionState.md)
 - [Model.TransactionTraits](docs/TransactionTraits.md)
 - [Model.TransactionWebhook](docs/TransactionWebhook.md)
 - [Model.ValidationErrorDescription](docs/ValidationErrorDescription.md)
 - [Model.Webhook](docs/Webhook.md)
 - [Model.WebhookDefinition](docs/WebhookDefinition.md)
 - [Model.WebhookDefinitionEventListResponse](docs/WebhookDefinitionEventListResponse.md)
 - [Model.WebhookDefinitionListResponse](docs/WebhookDefinitionListResponse.md)
 - [Model.WebhookDefinitionRequest](docs/WebhookDefinitionRequest.md)
 - [Model.WebhookDefinitionResponse](docs/WebhookDefinitionResponse.md)
 - [Model.WebhookLog](docs/WebhookLog.md)
 - [Model.WebhookLogListResponse](docs/WebhookLogListResponse.md)
 - [Model.WebhookLogMetadata](docs/WebhookLogMetadata.md)
 - [Model.WebhookLogMetadataRequest](docs/WebhookLogMetadataRequest.md)
 - [Model.WebhookLogMetadataResponse](docs/WebhookLogMetadataResponse.md)
 - [Model.WebhookLogResponse](docs/WebhookLogResponse.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

You can set the API Key and Secret on the Configuration object for authentication:

### C#

```csharp
Configuration configuration = new Configuration();
configuration.ApiKey = "<key>";
configuration.ApiSecret = "<secret>";
configuration.BasePath = "https://api-sandbox.transferzero.com/v1";
```

### VB.NET

```vbnet
Dim configuration As Configuration = New Configuration()
configuration.ApiKey = "<key>"
configuration.ApiSecret = "<secret>"
configuration.BasePath = "https://api-sandbox.transferzero.com/v1"
```
