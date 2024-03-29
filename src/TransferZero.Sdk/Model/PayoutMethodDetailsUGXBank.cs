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
    /// &#x60;&#x60;&#x60;JSON \&quot;details\&quot;: {   \&quot;first_name\&quot;: \&quot;First\&quot;,   \&quot;last_name\&quot;: \&quot;Last\&quot;,   \&quot;street\&quot;: \&quot;1, Old Taxi Park\&quot;,   \&quot;city\&quot;: \&quot;Kampala\&quot;,   \&quot;postal_code\&quot;: \&quot;10102\&quot;,   \&quot;identity_card_id\&quot;: \&quot;3081900101123411\&quot;,   \&quot;bank_account\&quot;: \&quot;1234567890\&quot;,   \&quot;branch_code\&quot;: \&quot;130547\&quot;,   \&quot;transfer_reason\&quot;: \&quot;personal_account\&quot; } &#x60;&#x60;&#x60; See [UGX Bank](https://docs.transferzero.com/docs/payout-details/#ugxbank) documentation for the branch_code list
    /// </summary>
    [DataContract]
    public partial class PayoutMethodDetailsUGXBank :  IEquatable<PayoutMethodDetailsUGXBank>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutMethodDetailsUGXBank" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PayoutMethodDetailsUGXBank() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutMethodDetailsUGXBank" /> class.
        /// </summary>
        /// <param name="firstName">firstName (required).</param>
        /// <param name="lastName">lastName (required).</param>
        /// <param name="street">street (required).</param>
        /// <param name="city">city (required).</param>
        /// <param name="postalCode">postalCode (required).</param>
        /// <param name="identityCardId">identityCardId (required).</param>
        /// <param name="bankAccount">bankAccount (required).</param>
        /// <param name="branchCode">branchCode (required).</param>
        /// <param name="transferReason">transferReason (required).</param>
        /// <param name="birthDate">Date of birth of recipient.</param>
        public PayoutMethodDetailsUGXBank(string firstName = default(string), string lastName = default(string), string street = default(string), string city = default(string), string postalCode = default(string), string identityCardId = default(string), string bankAccount = default(string), string branchCode = default(string), PayoutMethodTransferReasonEnum transferReason = default(PayoutMethodTransferReasonEnum), DateTime? birthDate = default(DateTime?))
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Street = street;
            this.City = city;
            this.PostalCode = postalCode;
            this.IdentityCardId = identityCardId;
            this.BankAccount = bankAccount;
            this.BranchCode = branchCode;
            this.TransferReason = transferReason;
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
        /// Gets or Sets PostalCode
        /// </summary>
        [DataMember(Name="postal_code", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or Sets IdentityCardId
        /// </summary>
        [DataMember(Name="identity_card_id", EmitDefaultValue=false)]
        public string IdentityCardId { get; set; }

        /// <summary>
        /// Gets or Sets BankAccount
        /// </summary>
        [DataMember(Name="bank_account", EmitDefaultValue=false)]
        public string BankAccount { get; set; }

        /// <summary>
        /// Gets or Sets BranchCode
        /// </summary>
        [DataMember(Name="branch_code", EmitDefaultValue=false)]
        public string BranchCode { get; set; }

        /// <summary>
        /// Gets or Sets TransferReason
        /// </summary>
        [DataMember(Name="transfer_reason", EmitDefaultValue=false)]
        public PayoutMethodTransferReasonEnum TransferReason { get; set; }

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
            sb.Append("class PayoutMethodDetailsUGXBank {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  IdentityCardId: ").Append(IdentityCardId).Append("\n");
            sb.Append("  BankAccount: ").Append(BankAccount).Append("\n");
            sb.Append("  BranchCode: ").Append(BranchCode).Append("\n");
            sb.Append("  TransferReason: ").Append(TransferReason).Append("\n");
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
            return this.Equals(input as PayoutMethodDetailsUGXBank);
        }

        /// <summary>
        /// Returns true if PayoutMethodDetailsUGXBank instances are equal
        /// </summary>
        /// <param name="input">Instance of PayoutMethodDetailsUGXBank to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayoutMethodDetailsUGXBank input)
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
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.IdentityCardId == input.IdentityCardId ||
                    (this.IdentityCardId != null &&
                    this.IdentityCardId.Equals(input.IdentityCardId))
                ) && 
                (
                    this.BankAccount == input.BankAccount ||
                    (this.BankAccount != null &&
                    this.BankAccount.Equals(input.BankAccount))
                ) && 
                (
                    this.BranchCode == input.BranchCode ||
                    (this.BranchCode != null &&
                    this.BranchCode.Equals(input.BranchCode))
                ) && 
                (
                    this.TransferReason == input.TransferReason ||
                    (this.TransferReason != null &&
                    this.TransferReason.Equals(input.TransferReason))
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
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.IdentityCardId != null)
                    hashCode = hashCode * 59 + this.IdentityCardId.GetHashCode();
                if (this.BankAccount != null)
                    hashCode = hashCode * 59 + this.BankAccount.GetHashCode();
                if (this.BranchCode != null)
                    hashCode = hashCode * 59 + this.BranchCode.GetHashCode();
                if (this.TransferReason != null)
                    hashCode = hashCode * 59 + this.TransferReason.GetHashCode();
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
