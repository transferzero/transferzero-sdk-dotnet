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
    /// &#x60;&#x60;&#x60;JSON   \&quot;details\&quot;: {     \&quot;first_name\&quot;: \&quot;First\&quot;,     \&quot;last_name\&quot;: \&quot;Last\&quot;,     \&quot;street\&quot;: \&quot;Main Street\&quot;,     \&quot;city\&quot;: \&quot;Nairobi\&quot;,     \&quot;bank_code\&quot;: \&quot;68\&quot;,     \&quot;bank_account\&quot;: \&quot;12345678\&quot;,     \&quot;transfer_reason\&quot;: \&quot;personal_account\&quot;, // New transfer reason field     \&quot;identity_card_type\&quot;: \&quot;ID\&quot;, // refers to the recipient&#39;s ID details; Values: \&quot;PP\&quot;: Passport, \&quot;ID\&quot;: National ID or \&quot;O\&quot;: Other     \&quot;identity_card_id\&quot;: \&quot;AB12345678\&quot;, // refers to the recipient&#39;s ID details     \&quot;relationship_to_sender\&quot;: \&quot;Relative\&quot; // Optional   } &#x60;&#x60;&#x60;  See [KES Bank](https://docs.transferzero.com/docs/payout-details/#kesbank) documentation for the &#x60;bank_code&#x60; and &#x60;transfer_reason&#x60; lists
    /// </summary>
    [DataContract]
    public partial class PayoutMethodDetailsKESBank :  IEquatable<PayoutMethodDetailsKESBank>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutMethodDetailsKESBank" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PayoutMethodDetailsKESBank() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutMethodDetailsKESBank" /> class.
        /// </summary>
        /// <param name="firstName">firstName (required).</param>
        /// <param name="lastName">lastName (required).</param>
        /// <param name="street">street (required).</param>
        /// <param name="city">city.</param>
        /// <param name="bankCode">bankCode (required).</param>
        /// <param name="bankAccount">bankAccount (required).</param>
        /// <param name="transferReason">transferReason (required).</param>
        /// <param name="identityCardType">identityCardType (required).</param>
        /// <param name="identityCardId">identityCardId (required).</param>
        /// <param name="relationshipToSender">relationshipToSender.</param>
        /// <param name="birthDate">Date of birth of recipient.</param>
        public PayoutMethodDetailsKESBank(string firstName = default(string), string lastName = default(string), string street = default(string), string city = default(string), string bankCode = default(string), string bankAccount = default(string), PayoutMethodTransferReasonEnum transferReason = default(PayoutMethodTransferReasonEnum), PayoutMethodIdentityCardTypeEnum identityCardType = default(PayoutMethodIdentityCardTypeEnum), string identityCardId = default(string), string relationshipToSender = default(string), DateTime? birthDate = default(DateTime?))
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Street = street;
            this.BankCode = bankCode;
            this.BankAccount = bankAccount;
            this.TransferReason = transferReason;
            this.IdentityCardType = identityCardType;
            this.IdentityCardId = identityCardId;
            this.City = city;
            this.RelationshipToSender = relationshipToSender;
            this.BirthDate = birthDate;
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
        /// Gets or Sets Street
        /// </summary>
        [DataMember(Name="street", EmitDefaultValue=false)]
        public string Street { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

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
        /// Gets or Sets TransferReason
        /// </summary>
        [DataMember(Name="transfer_reason", EmitDefaultValue=false)]
        public PayoutMethodTransferReasonEnum TransferReason { get; set; }

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
        /// Gets or Sets RelationshipToSender
        /// </summary>
        [DataMember(Name="relationship_to_sender", EmitDefaultValue=false)]
        public string RelationshipToSender { get; set; }

        /// <summary>
        /// Date of birth of recipient
        /// </summary>
        /// <value>Date of birth of recipient</value>
        [DataMember(Name="birth_date", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayoutMethodDetailsKESBank {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  BankCode: ").Append(BankCode).Append("\n");
            sb.Append("  BankAccount: ").Append(BankAccount).Append("\n");
            sb.Append("  TransferReason: ").Append(TransferReason).Append("\n");
            sb.Append("  IdentityCardType: ").Append(IdentityCardType).Append("\n");
            sb.Append("  IdentityCardId: ").Append(IdentityCardId).Append("\n");
            sb.Append("  RelationshipToSender: ").Append(RelationshipToSender).Append("\n");
            sb.Append("  BirthDate: ").Append(BirthDate).Append("\n");
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
            return this.Equals(input as PayoutMethodDetailsKESBank);
        }

        /// <summary>
        /// Returns true if PayoutMethodDetailsKESBank instances are equal
        /// </summary>
        /// <param name="input">Instance of PayoutMethodDetailsKESBank to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayoutMethodDetailsKESBank input)
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
                    this.Street == input.Street ||
                    (this.Street != null &&
                    this.Street.Equals(input.Street))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
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
                    this.TransferReason == input.TransferReason ||
                    (this.TransferReason != null &&
                    this.TransferReason.Equals(input.TransferReason))
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
                    this.RelationshipToSender == input.RelationshipToSender ||
                    (this.RelationshipToSender != null &&
                    this.RelationshipToSender.Equals(input.RelationshipToSender))
                ) && 
                (
                    this.BirthDate == input.BirthDate ||
                    (this.BirthDate != null &&
                    this.BirthDate.Equals(input.BirthDate))
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
                if (this.Street != null)
                    hashCode = hashCode * 59 + this.Street.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.BankCode != null)
                    hashCode = hashCode * 59 + this.BankCode.GetHashCode();
                if (this.BankAccount != null)
                    hashCode = hashCode * 59 + this.BankAccount.GetHashCode();
                if (this.TransferReason != null)
                    hashCode = hashCode * 59 + this.TransferReason.GetHashCode();
                if (this.IdentityCardType != null)
                    hashCode = hashCode * 59 + this.IdentityCardType.GetHashCode();
                if (this.IdentityCardId != null)
                    hashCode = hashCode * 59 + this.IdentityCardId.GetHashCode();
                if (this.RelationshipToSender != null)
                    hashCode = hashCode * 59 + this.RelationshipToSender.GetHashCode();
                if (this.BirthDate != null)
                    hashCode = hashCode * 59 + this.BirthDate.GetHashCode();
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
