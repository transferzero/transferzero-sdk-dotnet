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
    /// &#x60;&#x60;&#x60;JSON \&quot;details\&quot;: {   \&quot;first_name\&quot;: \&quot;First\&quot;,   \&quot;last_name\&quot;: \&quot;Last\&quot;,   \&quot;phone_number\&quot;: \&quot;+212537718685\&quot;     # Mandatory; E.164 international format   \&quot;sender_identity_card_type\&quot; &#x3D;&gt; \&quot;O\&quot;,     # Mandatory; Values: \&quot;O\&quot;: Other, \&quot;PP\&quot;: Passport, \&quot;ID\&quot;: National ID   \&quot;sender_identity_card_id\&quot; &#x3D;&gt; &#39;AB12345678&#39;,     # Mandatory   \&quot;sender_city_of_birth\&quot; &#x3D;&gt; \&quot;London\&quot;,     # Optional   \&quot;sender_country_of_birth\&quot; &#x3D;&gt; \&quot;GB\&quot;,     # Optional; ISO 2-letter format   \&quot;sender_gender\&quot; &#x3D;&gt; \&quot;M\&quot;,     # Optional; Values: \&quot;M\&quot;: Male, \&quot;F\&quot;: Female   \&quot;reason\&quot; &#x3D;&gt; \&quot;Remittance payment\&quot;,     # Optional; Default value is &#39;Remittance payment&#39;   \&quot;identity_card_type\&quot; &#x3D;&gt; \&quot;ID\&quot;,     # Optional; Values: \&quot;PP\&quot;: Passport, \&quot;ID\&quot;: National ID   \&quot;identity_card_id\&quot; &#x3D;&gt; &#39;AB12345678&#39;     # Optional } &#x60;&#x60;&#x60;  Please note when sending MAD::Cash payments you should subscribe to the recipient.pending webhook, as that will broadcast the payment reference ID the customer need to use to obtain the funds. Example webhook response excerpt -  &#x60;&#x60;&#x60;JSON {   (...)   \&quot;state\&quot;:\&quot;pending\&quot;,   \&quot;metadata\&quot;: {     \&quot;payment_reference\&quot;:\&quot;9M5GJRJUBCY\&quot;   },   (...) } &#x60;&#x60;&#x60;  The reference can also be provided optionally for MAD::Cash, but if you want to use this functionality please contact us for more details.
    /// </summary>
    [DataContract]
    public partial class PayoutMethodDetailsMADCash :  IEquatable<PayoutMethodDetailsMADCash>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutMethodDetailsMADCash" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PayoutMethodDetailsMADCash() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutMethodDetailsMADCash" /> class.
        /// </summary>
        /// <param name="firstName">firstName (required).</param>
        /// <param name="lastName">lastName (required).</param>
        /// <param name="phoneNumber">phoneNumber (required).</param>
        /// <param name="senderIdentityCardType">senderIdentityCardType (required).</param>
        /// <param name="senderIdentityCardId">senderIdentityCardId (required).</param>
        /// <param name="senderCityOfBirth">senderCityOfBirth.</param>
        /// <param name="senderCountryOfBirth">senderCountryOfBirth.</param>
        /// <param name="senderGender">senderGender.</param>
        /// <param name="reason">reason.</param>
        /// <param name="identityCardType">identityCardType.</param>
        /// <param name="identityCardId">identityCardId.</param>
        /// <param name="birthDate">Date of birth of recipient.</param>
        public PayoutMethodDetailsMADCash(string firstName = default(string), string lastName = default(string), string phoneNumber = default(string), PayoutMethodIdentityCardTypeEnum senderIdentityCardType = default(PayoutMethodIdentityCardTypeEnum), string senderIdentityCardId = default(string), string senderCityOfBirth = default(string), string senderCountryOfBirth = default(string), PayoutMethodGenderEnum senderGender = default(PayoutMethodGenderEnum), string reason = default(string), PayoutMethodIdentityCardTypeEnum identityCardType = default(PayoutMethodIdentityCardTypeEnum), string identityCardId = default(string), DateTime? birthDate = default(DateTime?))
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.SenderIdentityCardType = senderIdentityCardType;
            this.SenderIdentityCardId = senderIdentityCardId;
            this.SenderCityOfBirth = senderCityOfBirth;
            this.SenderCountryOfBirth = senderCountryOfBirth;
            this.SenderGender = senderGender;
            this.Reason = reason;
            this.IdentityCardType = identityCardType;
            this.IdentityCardId = identityCardId;
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
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name="phone_number", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

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
            sb.Append("class PayoutMethodDetailsMADCash {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  SenderIdentityCardType: ").Append(SenderIdentityCardType).Append("\n");
            sb.Append("  SenderIdentityCardId: ").Append(SenderIdentityCardId).Append("\n");
            sb.Append("  SenderCityOfBirth: ").Append(SenderCityOfBirth).Append("\n");
            sb.Append("  SenderCountryOfBirth: ").Append(SenderCountryOfBirth).Append("\n");
            sb.Append("  SenderGender: ").Append(SenderGender).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  IdentityCardType: ").Append(IdentityCardType).Append("\n");
            sb.Append("  IdentityCardId: ").Append(IdentityCardId).Append("\n");
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
            return this.Equals(input as PayoutMethodDetailsMADCash);
        }

        /// <summary>
        /// Returns true if PayoutMethodDetailsMADCash instances are equal
        /// </summary>
        /// <param name="input">Instance of PayoutMethodDetailsMADCash to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayoutMethodDetailsMADCash input)
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
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
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
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
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
