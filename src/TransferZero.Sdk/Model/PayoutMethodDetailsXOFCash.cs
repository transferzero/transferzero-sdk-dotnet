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
    /// &#x60;&#x60;&#x60;JSON \&quot;details\&quot;: {   \&quot;first_name\&quot;: \&quot;First\&quot;,   \&quot;last_name\&quot;: \&quot;Last\&quot;,   \&quot;phone_number\&quot;: \&quot;221774044436\&quot;, // local or international format   \&quot;cash_provider\&quot;: \&quot;wizall\&quot; // Optional; Values: \&quot;wizall\&quot;; Default value is \&quot;wizall\&quot;;   \&quot;country\&quot;: \&quot;SN\&quot; // Optional; Values: \&quot;CI\&quot;, \&quot;ML\&quot; or \&quot;SN\&quot;; Default value is \&quot;SN\&quot;; } &#x60;&#x60;&#x60;  Please note all senders trying to create Wizall cash pickup requests must have &#x60;identity_type&#x60; and &#x60;identity_number&#x60; present. The fields above are generally considered optional for senders for other payment corridors. If you wish to use an existing sender who has some of these fields missing you can provide them alongside the &#x60;id&#x60; or &#x60;external_id&#x60; field in the sender details. For example -  &#x60;&#x60;&#x60;JSON {   \&quot;transaction\&quot;: {       \&quot;sender\&quot;: {         \&quot;external_id\&quot;: \&quot;&lt;id of sender&gt;\&quot;,         \&quot;identity_type\&quot;: \&quot;ID\&quot;,         \&quot;identity_number\&quot;: \&quot;AB12345678\&quot;,         (...)       },       (...)     } } &#x60;&#x60;&#x60;
    /// </summary>
    [DataContract]
    public partial class PayoutMethodDetailsXOFCash :  IEquatable<PayoutMethodDetailsXOFCash>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutMethodDetailsXOFCash" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PayoutMethodDetailsXOFCash() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutMethodDetailsXOFCash" /> class.
        /// </summary>
        /// <param name="firstName">firstName (required).</param>
        /// <param name="lastName">lastName (required).</param>
        /// <param name="phoneNumber">phoneNumber (required).</param>
        /// <param name="cashProvider">cashProvider.</param>
        /// <param name="country">country.</param>
        public PayoutMethodDetailsXOFCash(string firstName = default(string), string lastName = default(string), string phoneNumber = default(string), PayoutMethodCashProviderEnum cashProvider = default(PayoutMethodCashProviderEnum), PayoutMethodCountryEnum country = default(PayoutMethodCountryEnum))
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
            this.CashProvider = cashProvider;
            this.Country = country;
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
        /// Gets or Sets CashProvider
        /// </summary>
        [DataMember(Name="cash_provider", EmitDefaultValue=false)]
        public PayoutMethodCashProviderEnum CashProvider { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public PayoutMethodCountryEnum Country { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayoutMethodDetailsXOFCash {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  CashProvider: ").Append(CashProvider).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
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
            return this.Equals(input as PayoutMethodDetailsXOFCash);
        }

        /// <summary>
        /// Returns true if PayoutMethodDetailsXOFCash instances are equal
        /// </summary>
        /// <param name="input">Instance of PayoutMethodDetailsXOFCash to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayoutMethodDetailsXOFCash input)
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
                    this.CashProvider == input.CashProvider ||
                    (this.CashProvider != null &&
                    this.CashProvider.Equals(input.CashProvider))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
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
                if (this.CashProvider != null)
                    hashCode = hashCode * 59 + this.CashProvider.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
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
