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
    /// &#x60;&#x60;&#x60;JSON \&quot;details\&quot;: {   \&quot;first_name\&quot;: \&quot;First\&quot;,   \&quot;last_name\&quot;: \&quot;Last\&quot;,   \&quot;phone_number\&quot;: \&quot;+237674044436\&quot;, // E.164 international format   \&quot;mobile_provider\&quot;: \&quot;orange\&quot;, // or mtn\&quot;   \&quot;country\&quot; // Optional; Values: \&quot;CM\&quot; } &#x60;&#x60;&#x60;
    /// </summary>
    [DataContract]
    public partial class PayoutMethodDetailsXAFMobile :  IEquatable<PayoutMethodDetailsXAFMobile>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutMethodDetailsXAFMobile" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PayoutMethodDetailsXAFMobile() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutMethodDetailsXAFMobile" /> class.
        /// </summary>
        /// <param name="firstName">firstName (required).</param>
        /// <param name="lastName">lastName (required).</param>
        /// <param name="phoneNumber">phoneNumber (required).</param>
        /// <param name="mobileProvider">mobileProvider (required).</param>
        /// <param name="country">country.</param>
        /// <param name="birthDate">Date of birth of recipient.</param>
        public PayoutMethodDetailsXAFMobile(string firstName = default(string), string lastName = default(string), string phoneNumber = default(string), PayoutMethodMobileProviderEnum mobileProvider = default(PayoutMethodMobileProviderEnum), PayoutMethodCountryEnum country = default(PayoutMethodCountryEnum), DateTime? birthDate = default(DateTime?))
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.MobileProvider = mobileProvider;
            this.Country = country;
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
            sb.Append("class PayoutMethodDetailsXAFMobile {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  MobileProvider: ").Append(MobileProvider).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
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
            return this.Equals(input as PayoutMethodDetailsXAFMobile);
        }

        /// <summary>
        /// Returns true if PayoutMethodDetailsXAFMobile instances are equal
        /// </summary>
        /// <param name="input">Instance of PayoutMethodDetailsXAFMobile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayoutMethodDetailsXAFMobile input)
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
                if (this.MobileProvider != null)
                    hashCode = hashCode * 59 + this.MobileProvider.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
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
