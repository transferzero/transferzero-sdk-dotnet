/* 
 * BitPesa Private API
 *
 * API specification used for internal BitPesa endpoints
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
    /// &#x60;&#x60;&#x60;JSON \&quot;details\&quot;: {   \&quot;first_name\&quot;: \&quot;First\&quot;,   \&quot;last_name\&quot;: \&quot;Last\&quot;,   \&quot;city\&quot;: \&quot;New Delhi\&quot;,   \&quot;street\&quot;: \&quot;1, Akbar Road\&quot;,   \&quot;postal_code\&quot;: \&quot;110016\&quot;,   \&quot;phone_number\&quot;: \&quot;+919876543210\&quot;,   \&quot;bank_name\&quot;: \&quot;Bank of India\&quot;   \&quot;bank_account\&quot;: \&quot;1234567890\&quot;,   \&quot;ifsc_code\&quot;: \&quot;BKID0006005\&quot; } &#x60;&#x60;&#x60; See [INR Bank](https://docs.transferzero.com/docs/payout-details/#inrbank) documentation for the bank_name list
    /// </summary>
    [DataContract]
    public partial class PayoutMethodDetailsINRBank :  IEquatable<PayoutMethodDetailsINRBank>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutMethodDetailsINRBank" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PayoutMethodDetailsINRBank() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutMethodDetailsINRBank" /> class.
        /// </summary>
        /// <param name="firstName">firstName (required).</param>
        /// <param name="lastName">lastName (required).</param>
        /// <param name="city">city (required).</param>
        /// <param name="street">street (required).</param>
        /// <param name="postalCode">postalCode (required).</param>
        /// <param name="phoneNumber">phoneNumber (required).</param>
        /// <param name="bankName">bankName (required).</param>
        /// <param name="bankAccount">bankAccount (required).</param>
        /// <param name="ifscCode">ifscCode (required).</param>
        public PayoutMethodDetailsINRBank(string firstName = default(string), string lastName = default(string), string city = default(string), string street = default(string), string postalCode = default(string), string phoneNumber = default(string), string bankName = default(string), string bankAccount = default(string), string ifscCode = default(string))
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.City = city;
            this.Street = street;
            this.PostalCode = postalCode;
            this.PhoneNumber = phoneNumber;
            this.BankName = bankName;
            this.BankAccount = bankAccount;
            this.IfscCode = ifscCode;
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
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }

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
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name="phone_number", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets BankName
        /// </summary>
        [DataMember(Name="bank_name", EmitDefaultValue=false)]
        public string BankName { get; set; }

        /// <summary>
        /// Gets or Sets BankAccount
        /// </summary>
        [DataMember(Name="bank_account", EmitDefaultValue=false)]
        public string BankAccount { get; set; }

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
            sb.Append("class PayoutMethodDetailsINRBank {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  BankName: ").Append(BankName).Append("\n");
            sb.Append("  BankAccount: ").Append(BankAccount).Append("\n");
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
            return this.Equals(input as PayoutMethodDetailsINRBank);
        }

        /// <summary>
        /// Returns true if PayoutMethodDetailsINRBank instances are equal
        /// </summary>
        /// <param name="input">Instance of PayoutMethodDetailsINRBank to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayoutMethodDetailsINRBank input)
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
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
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
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.BankName == input.BankName ||
                    (this.BankName != null &&
                    this.BankName.Equals(input.BankName))
                ) && 
                (
                    this.BankAccount == input.BankAccount ||
                    (this.BankAccount != null &&
                    this.BankAccount.Equals(input.BankAccount))
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
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Street != null)
                    hashCode = hashCode * 59 + this.Street.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.BankName != null)
                    hashCode = hashCode * 59 + this.BankName.GetHashCode();
                if (this.BankAccount != null)
                    hashCode = hashCode * 59 + this.BankAccount.GetHashCode();
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
