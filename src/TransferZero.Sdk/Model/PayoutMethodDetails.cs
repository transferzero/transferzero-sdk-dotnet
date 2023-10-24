/* 
 * TransferZero API
 *
 * Reference documentation for the TransferZero API V1
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = TransferZero.Sdk.Client.OpenAPIDateConverter;

namespace TransferZero.Sdk.Model
{
    /// <summary>
    /// PayoutMethodDetails
    /// </summary>
    [DataContract]
    public partial class PayoutMethodDetails :  IEquatable<PayoutMethodDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutMethodDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PayoutMethodDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutMethodDetails" /> class.
        /// </summary>
        /// <param name="firstName">firstName (required).</param>
        /// <param name="lastName">lastName (required).</param>
        /// <param name="bankCode">bankCode (required).</param>
        /// <param name="bankAccount">bankAccount (required).</param>
        /// <param name="bankAccountType">bankAccountType.</param>
        /// <param name="phoneNumber">phoneNumber (required).</param>
        /// <param name="mobileProvider">mobileProvider (required).</param>
        /// <param name="country">country (required).</param>
        /// <param name="transferReason">transferReason (required).</param>
        /// <param name="iban">iban (required).</param>
        /// <param name="bankName">bankName (required).</param>
        /// <param name="bankCountry">bankCountry.</param>
        /// <param name="cashProvider">cashProvider (required).</param>
        /// <param name="sortCode">sortCode.</param>
        /// <param name="bic">bic.</param>
        /// <param name="narration">narration.</param>
        /// <param name="senderIdentityCardType">senderIdentityCardType (required).</param>
        /// <param name="senderIdentityCardId">senderIdentityCardId (required).</param>
        /// <param name="senderCityOfBirth">senderCityOfBirth.</param>
        /// <param name="senderCountryOfBirth">senderCountryOfBirth.</param>
        /// <param name="senderGender">senderGender.</param>
        /// <param name="reason">reason.</param>
        /// <param name="identityCardType">identityCardType (required).</param>
        /// <param name="identityCardId">identityCardId (required).</param>
        /// <param name="reference">reference.</param>
        /// <param name="name">name (required).</param>
        /// <param name="address">address (required).</param>
        /// <param name="street">street (required).</param>
        /// <param name="postalCode">postalCode (required).</param>
        /// <param name="city">city (required).</param>
        /// <param name="email">email.</param>
        /// <param name="branchCode">branchCode (required).</param>
        /// <param name="transferReasonCode">transferReasonCode.</param>
        /// <param name="contactFirstName">contactFirstName.</param>
        /// <param name="contactLastName">contactLastName.</param>
        /// <param name="registrationNumber">registrationNumber.</param>
        /// <param name="natureOfBusiness">natureOfBusiness.</param>
        /// <param name="legalEntityType">legalEntityType.</param>
        /// <param name="routingNumber">routingNumber.</param>
        /// <param name="swiftCode">swiftCode.</param>
        /// <param name="relationshipToSender">relationshipToSender.</param>
        /// <param name="pixKeyType">pixKeyType.</param>
        /// <param name="pixKeyValue">pixKeyValue.</param>
        /// <param name="ifscCode">ifscCode (required).</param>
        public PayoutMethodDetails(string firstName = default(string), string lastName = default(string), string bankCode = default(string), string bankAccount = default(string), PayoutMethodBankAccountTypeEnum bankAccountType = default(PayoutMethodBankAccountTypeEnum), string phoneNumber = default(string), PayoutMethodMobileProviderEnum mobileProvider = default(PayoutMethodMobileProviderEnum), PayoutMethodCountryEnum country = default(PayoutMethodCountryEnum), PayoutMethodTransferReasonEnum transferReason = default(PayoutMethodTransferReasonEnum), string iban = default(string), string bankName = default(string), string bankCountry = default(string), PayoutMethodCashProviderEnum cashProvider = default(PayoutMethodCashProviderEnum), string sortCode = default(string), string bic = default(string), string narration = default(string), PayoutMethodIdentityCardTypeEnum senderIdentityCardType = default(PayoutMethodIdentityCardTypeEnum), string senderIdentityCardId = default(string), string senderCityOfBirth = default(string), string senderCountryOfBirth = default(string), PayoutMethodGenderEnum senderGender = default(PayoutMethodGenderEnum), string reason = default(string), PayoutMethodIdentityCardTypeEnum identityCardType = default(PayoutMethodIdentityCardTypeEnum), string identityCardId = default(string), string reference = default(string), string name = default(string), string address = default(string), string street = default(string), string postalCode = default(string), string city = default(string), string email = default(string), string branchCode = default(string), string transferReasonCode = default(string), string contactFirstName = default(string), string contactLastName = default(string), string registrationNumber = default(string), PayoutMethodNatureOfBusinessEnum natureOfBusiness = default(PayoutMethodNatureOfBusinessEnum), PayoutMethodLegalEntityTypeEnum legalEntityType = default(PayoutMethodLegalEntityTypeEnum), string routingNumber = default(string), string swiftCode = default(string), string relationshipToSender = default(string), PayoutMethodPixKeyTypeEnum pixKeyType = default(PayoutMethodPixKeyTypeEnum), string pixKeyValue = default(string), string ifscCode = default(string))
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BankCode = bankCode;
            this.BankAccount = bankAccount;
            this.PhoneNumber = phoneNumber;
            this.MobileProvider = mobileProvider;
            this.Country = country;
            this.TransferReason = transferReason;
            this.Iban = iban;
            this.BankName = bankName;
            this.CashProvider = cashProvider;
            this.SenderIdentityCardType = senderIdentityCardType;
            this.SenderIdentityCardId = senderIdentityCardId;
            this.IdentityCardType = identityCardType;
            this.IdentityCardId = identityCardId;
            this.Name = name;
            this.Address = address;
            this.Street = street;
            this.PostalCode = postalCode;
            this.City = city;
            this.BranchCode = branchCode;
            this.IfscCode = ifscCode;
            this.BankAccountType = bankAccountType;
            this.BankCountry = bankCountry;
            this.SortCode = sortCode;
            this.Bic = bic;
            this.Narration = narration;
            this.SenderCityOfBirth = senderCityOfBirth;
            this.SenderCountryOfBirth = senderCountryOfBirth;
            this.SenderGender = senderGender;
            this.Reason = reason;
            this.Reference = reference;
            this.Email = email;
            this.TransferReasonCode = transferReasonCode;
            this.ContactFirstName = contactFirstName;
            this.ContactLastName = contactLastName;
            this.RegistrationNumber = registrationNumber;
            this.NatureOfBusiness = natureOfBusiness;
            this.LegalEntityType = legalEntityType;
            this.RoutingNumber = routingNumber;
            this.SwiftCode = swiftCode;
            this.RelationshipToSender = relationshipToSender;
            this.PixKeyType = pixKeyType;
            this.PixKeyValue = pixKeyValue;
        }
        
        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="first_name", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="last_name", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets BankCode
        /// </summary>
        [DataMember(Name="bank_code", EmitDefaultValue=false)]
        public string BankCode { get; set; }

        /// <summary>
        /// Gets or Sets BankAccount
        /// </summary>
        [DataMember(Name="bank_account", EmitDefaultValue=false)]
        public string BankAccount { get; set; }

        /// <summary>
        /// Gets or Sets BankAccountType
        /// </summary>
        [DataMember(Name="bank_account_type", EmitDefaultValue=false)]
        public PayoutMethodBankAccountTypeEnum BankAccountType { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name="phone_number", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets MobileProvider
        /// </summary>
        [DataMember(Name="mobile_provider", EmitDefaultValue=false)]
        public PayoutMethodMobileProviderEnum MobileProvider { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public PayoutMethodCountryEnum Country { get; set; }

        /// <summary>
        /// Gets or Sets TransferReason
        /// </summary>
        [DataMember(Name="transfer_reason", EmitDefaultValue=false)]
        public PayoutMethodTransferReasonEnum TransferReason { get; set; }

        /// <summary>
        /// Gets or Sets Iban
        /// </summary>
        [DataMember(Name="iban", EmitDefaultValue=false)]
        public string Iban { get; set; }

        /// <summary>
        /// Gets or Sets BankName
        /// </summary>
        [DataMember(Name="bank_name", EmitDefaultValue=false)]
        public string BankName { get; set; }

        /// <summary>
        /// Gets or Sets BankCountry
        /// </summary>
        [DataMember(Name="bank_country", EmitDefaultValue=false)]
        public string BankCountry { get; set; }

        /// <summary>
        /// Gets or Sets CashProvider
        /// </summary>
        [DataMember(Name="cash_provider", EmitDefaultValue=false)]
        public PayoutMethodCashProviderEnum CashProvider { get; set; }

        /// <summary>
        /// Gets or Sets SortCode
        /// </summary>
        [DataMember(Name="sort_code", EmitDefaultValue=false)]
        public string SortCode { get; set; }

        /// <summary>
        /// Gets or Sets Bic
        /// </summary>
        [DataMember(Name="bic", EmitDefaultValue=false)]
        public string Bic { get; set; }

        /// <summary>
        /// Gets or Sets Narration
        /// </summary>
        [DataMember(Name="narration", EmitDefaultValue=false)]
        public string Narration { get; set; }

        /// <summary>
        /// Gets or Sets SenderIdentityCardType
        /// </summary>
        [DataMember(Name="sender_identity_card_type", EmitDefaultValue=false)]
        public PayoutMethodIdentityCardTypeEnum SenderIdentityCardType { get; set; }

        /// <summary>
        /// Gets or Sets SenderIdentityCardId
        /// </summary>
        [DataMember(Name="sender_identity_card_id", EmitDefaultValue=false)]
        public string SenderIdentityCardId { get; set; }

        /// <summary>
        /// Gets or Sets SenderCityOfBirth
        /// </summary>
        [DataMember(Name="sender_city_of_birth", EmitDefaultValue=false)]
        public string SenderCityOfBirth { get; set; }

        /// <summary>
        /// Gets or Sets SenderCountryOfBirth
        /// </summary>
        [DataMember(Name="sender_country_of_birth", EmitDefaultValue=false)]
        public string SenderCountryOfBirth { get; set; }

        /// <summary>
        /// Gets or Sets SenderGender
        /// </summary>
        [DataMember(Name="sender_gender", EmitDefaultValue=false)]
        public PayoutMethodGenderEnum SenderGender { get; set; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or Sets IdentityCardType
        /// </summary>
        [DataMember(Name="identity_card_type", EmitDefaultValue=false)]
        public PayoutMethodIdentityCardTypeEnum IdentityCardType { get; set; }

        /// <summary>
        /// Gets or Sets IdentityCardId
        /// </summary>
        [DataMember(Name="identity_card_id", EmitDefaultValue=false)]
        public string IdentityCardId { get; set; }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }

        /// <summary>
        /// Gets or Sets Street
        /// </summary>
        [DataMember(Name="street", EmitDefaultValue=false)]
        public string Street { get; set; }

        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>
        [DataMember(Name="postal_code", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets BranchCode
        /// </summary>
        [DataMember(Name="branch_code", EmitDefaultValue=false)]
        public string BranchCode { get; set; }

        /// <summary>
        /// Gets or Sets TransferReasonCode
        /// </summary>
        [DataMember(Name="transfer_reason_code", EmitDefaultValue=false)]
        public string TransferReasonCode { get; set; }

        /// <summary>
        /// Gets or Sets ContactFirstName
        /// </summary>
        [DataMember(Name="contact_first_name", EmitDefaultValue=false)]
        public string ContactFirstName { get; set; }

        /// <summary>
        /// Gets or Sets ContactLastName
        /// </summary>
        [DataMember(Name="contact_last_name", EmitDefaultValue=false)]
        public string ContactLastName { get; set; }

        /// <summary>
        /// Gets or Sets RegistrationNumber
        /// </summary>
        [DataMember(Name="registration_number", EmitDefaultValue=false)]
        public string RegistrationNumber { get; set; }

        /// <summary>
        /// Gets or Sets NatureOfBusiness
        /// </summary>
        [DataMember(Name="nature_of_business", EmitDefaultValue=false)]
        public PayoutMethodNatureOfBusinessEnum NatureOfBusiness { get; set; }

        /// <summary>
        /// Gets or Sets LegalEntityType
        /// </summary>
        [DataMember(Name="legal_entity_type", EmitDefaultValue=false)]
        public PayoutMethodLegalEntityTypeEnum LegalEntityType { get; set; }

        /// <summary>
        /// Gets or Sets RoutingNumber
        /// </summary>
        [DataMember(Name="routing_number", EmitDefaultValue=false)]
        public string RoutingNumber { get; set; }

        /// <summary>
        /// Gets or Sets SwiftCode
        /// </summary>
        [DataMember(Name="swift_code", EmitDefaultValue=false)]
        public string SwiftCode { get; set; }

        /// <summary>
        /// Gets or Sets RelationshipToSender
        /// </summary>
        [DataMember(Name="relationship_to_sender", EmitDefaultValue=false)]
        public string RelationshipToSender { get; set; }

        /// <summary>
        /// Gets or Sets PixKeyType
        /// </summary>
        [DataMember(Name="pix_key_type", EmitDefaultValue=false)]
        public PayoutMethodPixKeyTypeEnum PixKeyType { get; set; }

        /// <summary>
        /// Gets or Sets PixKeyValue
        /// </summary>
        [DataMember(Name="pix_key_value", EmitDefaultValue=false)]
        public string PixKeyValue { get; set; }

        /// <summary>
        /// Gets or Sets IfscCode
        /// </summary>
        [DataMember(Name="ifsc_code", EmitDefaultValue=false)]
        public string IfscCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayoutMethodDetails {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  BankCode: ").Append(BankCode).Append("\n");
            sb.Append("  BankAccount: ").Append(BankAccount).Append("\n");
            sb.Append("  BankAccountType: ").Append(BankAccountType).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  MobileProvider: ").Append(MobileProvider).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  TransferReason: ").Append(TransferReason).Append("\n");
            sb.Append("  Iban: ").Append(Iban).Append("\n");
            sb.Append("  BankName: ").Append(BankName).Append("\n");
            sb.Append("  BankCountry: ").Append(BankCountry).Append("\n");
            sb.Append("  CashProvider: ").Append(CashProvider).Append("\n");
            sb.Append("  SortCode: ").Append(SortCode).Append("\n");
            sb.Append("  Bic: ").Append(Bic).Append("\n");
            sb.Append("  Narration: ").Append(Narration).Append("\n");
            sb.Append("  SenderIdentityCardType: ").Append(SenderIdentityCardType).Append("\n");
            sb.Append("  SenderIdentityCardId: ").Append(SenderIdentityCardId).Append("\n");
            sb.Append("  SenderCityOfBirth: ").Append(SenderCityOfBirth).Append("\n");
            sb.Append("  SenderCountryOfBirth: ").Append(SenderCountryOfBirth).Append("\n");
            sb.Append("  SenderGender: ").Append(SenderGender).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  IdentityCardType: ").Append(IdentityCardType).Append("\n");
            sb.Append("  IdentityCardId: ").Append(IdentityCardId).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  BranchCode: ").Append(BranchCode).Append("\n");
            sb.Append("  TransferReasonCode: ").Append(TransferReasonCode).Append("\n");
            sb.Append("  ContactFirstName: ").Append(ContactFirstName).Append("\n");
            sb.Append("  ContactLastName: ").Append(ContactLastName).Append("\n");
            sb.Append("  RegistrationNumber: ").Append(RegistrationNumber).Append("\n");
            sb.Append("  NatureOfBusiness: ").Append(NatureOfBusiness).Append("\n");
            sb.Append("  LegalEntityType: ").Append(LegalEntityType).Append("\n");
            sb.Append("  RoutingNumber: ").Append(RoutingNumber).Append("\n");
            sb.Append("  SwiftCode: ").Append(SwiftCode).Append("\n");
            sb.Append("  RelationshipToSender: ").Append(RelationshipToSender).Append("\n");
            sb.Append("  PixKeyType: ").Append(PixKeyType).Append("\n");
            sb.Append("  PixKeyValue: ").Append(PixKeyValue).Append("\n");
            sb.Append("  IfscCode: ").Append(IfscCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PayoutMethodDetails);
        }

        /// <summary>
        /// Returns true if PayoutMethodDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of PayoutMethodDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayoutMethodDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.BankCode == input.BankCode ||
                    (this.BankCode != null &&
                    this.BankCode.Equals(input.BankCode))
                ) && 
                (
                    this.BankAccount == input.BankAccount ||
                    (this.BankAccount != null &&
                    this.BankAccount.Equals(input.BankAccount))
                ) && 
                (
                    this.BankAccountType == input.BankAccountType ||
                    (this.BankAccountType != null &&
                    this.BankAccountType.Equals(input.BankAccountType))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.MobileProvider == input.MobileProvider ||
                    (this.MobileProvider != null &&
                    this.MobileProvider.Equals(input.MobileProvider))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.TransferReason == input.TransferReason ||
                    (this.TransferReason != null &&
                    this.TransferReason.Equals(input.TransferReason))
                ) && 
                (
                    this.Iban == input.Iban ||
                    (this.Iban != null &&
                    this.Iban.Equals(input.Iban))
                ) && 
                (
                    this.BankName == input.BankName ||
                    (this.BankName != null &&
                    this.BankName.Equals(input.BankName))
                ) && 
                (
                    this.BankCountry == input.BankCountry ||
                    (this.BankCountry != null &&
                    this.BankCountry.Equals(input.BankCountry))
                ) && 
                (
                    this.CashProvider == input.CashProvider ||
                    (this.CashProvider != null &&
                    this.CashProvider.Equals(input.CashProvider))
                ) && 
                (
                    this.SortCode == input.SortCode ||
                    (this.SortCode != null &&
                    this.SortCode.Equals(input.SortCode))
                ) && 
                (
                    this.Bic == input.Bic ||
                    (this.Bic != null &&
                    this.Bic.Equals(input.Bic))
                ) && 
                (
                    this.Narration == input.Narration ||
                    (this.Narration != null &&
                    this.Narration.Equals(input.Narration))
                ) && 
                (
                    this.SenderIdentityCardType == input.SenderIdentityCardType ||
                    (this.SenderIdentityCardType != null &&
                    this.SenderIdentityCardType.Equals(input.SenderIdentityCardType))
                ) && 
                (
                    this.SenderIdentityCardId == input.SenderIdentityCardId ||
                    (this.SenderIdentityCardId != null &&
                    this.SenderIdentityCardId.Equals(input.SenderIdentityCardId))
                ) && 
                (
                    this.SenderCityOfBirth == input.SenderCityOfBirth ||
                    (this.SenderCityOfBirth != null &&
                    this.SenderCityOfBirth.Equals(input.SenderCityOfBirth))
                ) && 
                (
                    this.SenderCountryOfBirth == input.SenderCountryOfBirth ||
                    (this.SenderCountryOfBirth != null &&
                    this.SenderCountryOfBirth.Equals(input.SenderCountryOfBirth))
                ) && 
                (
                    this.SenderGender == input.SenderGender ||
                    (this.SenderGender != null &&
                    this.SenderGender.Equals(input.SenderGender))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.IdentityCardType == input.IdentityCardType ||
                    (this.IdentityCardType != null &&
                    this.IdentityCardType.Equals(input.IdentityCardType))
                ) && 
                (
                    this.IdentityCardId == input.IdentityCardId ||
                    (this.IdentityCardId != null &&
                    this.IdentityCardId.Equals(input.IdentityCardId))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Street == input.Street ||
                    (this.Street != null &&
                    this.Street.Equals(input.Street))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.BranchCode == input.BranchCode ||
                    (this.BranchCode != null &&
                    this.BranchCode.Equals(input.BranchCode))
                ) && 
                (
                    this.TransferReasonCode == input.TransferReasonCode ||
                    (this.TransferReasonCode != null &&
                    this.TransferReasonCode.Equals(input.TransferReasonCode))
                ) && 
                (
                    this.ContactFirstName == input.ContactFirstName ||
                    (this.ContactFirstName != null &&
                    this.ContactFirstName.Equals(input.ContactFirstName))
                ) && 
                (
                    this.ContactLastName == input.ContactLastName ||
                    (this.ContactLastName != null &&
                    this.ContactLastName.Equals(input.ContactLastName))
                ) && 
                (
                    this.RegistrationNumber == input.RegistrationNumber ||
                    (this.RegistrationNumber != null &&
                    this.RegistrationNumber.Equals(input.RegistrationNumber))
                ) && 
                (
                    this.NatureOfBusiness == input.NatureOfBusiness ||
                    (this.NatureOfBusiness != null &&
                    this.NatureOfBusiness.Equals(input.NatureOfBusiness))
                ) && 
                (
                    this.LegalEntityType == input.LegalEntityType ||
                    (this.LegalEntityType != null &&
                    this.LegalEntityType.Equals(input.LegalEntityType))
                ) && 
                (
                    this.RoutingNumber == input.RoutingNumber ||
                    (this.RoutingNumber != null &&
                    this.RoutingNumber.Equals(input.RoutingNumber))
                ) && 
                (
                    this.SwiftCode == input.SwiftCode ||
                    (this.SwiftCode != null &&
                    this.SwiftCode.Equals(input.SwiftCode))
                ) && 
                (
                    this.RelationshipToSender == input.RelationshipToSender ||
                    (this.RelationshipToSender != null &&
                    this.RelationshipToSender.Equals(input.RelationshipToSender))
                ) && 
                (
                    this.PixKeyType == input.PixKeyType ||
                    (this.PixKeyType != null &&
                    this.PixKeyType.Equals(input.PixKeyType))
                ) && 
                (
                    this.PixKeyValue == input.PixKeyValue ||
                    (this.PixKeyValue != null &&
                    this.PixKeyValue.Equals(input.PixKeyValue))
                ) && 
                (
                    this.IfscCode == input.IfscCode ||
                    (this.IfscCode != null &&
                    this.IfscCode.Equals(input.IfscCode))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.BankCode != null)
                    hashCode = hashCode * 59 + this.BankCode.GetHashCode();
                if (this.BankAccount != null)
                    hashCode = hashCode * 59 + this.BankAccount.GetHashCode();
                if (this.BankAccountType != null)
                    hashCode = hashCode * 59 + this.BankAccountType.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.MobileProvider != null)
                    hashCode = hashCode * 59 + this.MobileProvider.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.TransferReason != null)
                    hashCode = hashCode * 59 + this.TransferReason.GetHashCode();
                if (this.Iban != null)
                    hashCode = hashCode * 59 + this.Iban.GetHashCode();
                if (this.BankName != null)
                    hashCode = hashCode * 59 + this.BankName.GetHashCode();
                if (this.BankCountry != null)
                    hashCode = hashCode * 59 + this.BankCountry.GetHashCode();
                if (this.CashProvider != null)
                    hashCode = hashCode * 59 + this.CashProvider.GetHashCode();
                if (this.SortCode != null)
                    hashCode = hashCode * 59 + this.SortCode.GetHashCode();
                if (this.Bic != null)
                    hashCode = hashCode * 59 + this.Bic.GetHashCode();
                if (this.Narration != null)
                    hashCode = hashCode * 59 + this.Narration.GetHashCode();
                if (this.SenderIdentityCardType != null)
                    hashCode = hashCode * 59 + this.SenderIdentityCardType.GetHashCode();
                if (this.SenderIdentityCardId != null)
                    hashCode = hashCode * 59 + this.SenderIdentityCardId.GetHashCode();
                if (this.SenderCityOfBirth != null)
                    hashCode = hashCode * 59 + this.SenderCityOfBirth.GetHashCode();
                if (this.SenderCountryOfBirth != null)
                    hashCode = hashCode * 59 + this.SenderCountryOfBirth.GetHashCode();
                if (this.SenderGender != null)
                    hashCode = hashCode * 59 + this.SenderGender.GetHashCode();
                if (this.Reason != null)
                    hashCode = hashCode * 59 + this.Reason.GetHashCode();
                if (this.IdentityCardType != null)
                    hashCode = hashCode * 59 + this.IdentityCardType.GetHashCode();
                if (this.IdentityCardId != null)
                    hashCode = hashCode * 59 + this.IdentityCardId.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
                if (this.Street != null)
                    hashCode = hashCode * 59 + this.Street.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.BranchCode != null)
                    hashCode = hashCode * 59 + this.BranchCode.GetHashCode();
                if (this.TransferReasonCode != null)
                    hashCode = hashCode * 59 + this.TransferReasonCode.GetHashCode();
                if (this.ContactFirstName != null)
                    hashCode = hashCode * 59 + this.ContactFirstName.GetHashCode();
                if (this.ContactLastName != null)
                    hashCode = hashCode * 59 + this.ContactLastName.GetHashCode();
                if (this.RegistrationNumber != null)
                    hashCode = hashCode * 59 + this.RegistrationNumber.GetHashCode();
                if (this.NatureOfBusiness != null)
                    hashCode = hashCode * 59 + this.NatureOfBusiness.GetHashCode();
                if (this.LegalEntityType != null)
                    hashCode = hashCode * 59 + this.LegalEntityType.GetHashCode();
                if (this.RoutingNumber != null)
                    hashCode = hashCode * 59 + this.RoutingNumber.GetHashCode();
                if (this.SwiftCode != null)
                    hashCode = hashCode * 59 + this.SwiftCode.GetHashCode();
                if (this.RelationshipToSender != null)
                    hashCode = hashCode * 59 + this.RelationshipToSender.GetHashCode();
                if (this.PixKeyType != null)
                    hashCode = hashCode * 59 + this.PixKeyType.GetHashCode();
                if (this.PixKeyValue != null)
                    hashCode = hashCode * 59 + this.PixKeyValue.GetHashCode();
                if (this.IfscCode != null)
                    hashCode = hashCode * 59 + this.IfscCode.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
