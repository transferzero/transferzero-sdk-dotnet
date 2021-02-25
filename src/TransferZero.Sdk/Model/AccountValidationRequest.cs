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
    /// AccountValidationRequest
    /// </summary>
    [DataContract]
    public partial class AccountValidationRequest :  IEquatable<AccountValidationRequest>, IValidatableObject
    {
        /// <summary>
        /// Country of account in 2-character alpha ISO 3166-2 country format
        /// </summary>
        /// <value>Country of account in 2-character alpha ISO 3166-2 country format</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CountryEnum
        {
            /// <summary>
            /// Enum NG for value: NG
            /// </summary>
            [EnumMember(Value = "NG")]
            NG = 1,

            /// <summary>
            /// Enum GH for value: GH
            /// </summary>
            [EnumMember(Value = "GH")]
            GH = 2

        }

        /// <summary>
        /// Country of account in 2-character alpha ISO 3166-2 country format
        /// </summary>
        /// <value>Country of account in 2-character alpha ISO 3166-2 country format</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public CountryEnum Country { get; set; }
        /// <summary>
        /// The currency the bank account is in
        /// </summary>
        /// <value>The currency the bank account is in</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CurrencyEnum
        {
            /// <summary>
            /// Enum NGN for value: NGN
            /// </summary>
            [EnumMember(Value = "NGN")]
            NGN = 1,

            /// <summary>
            /// Enum GHS for value: GHS
            /// </summary>
            [EnumMember(Value = "GHS")]
            GHS = 2

        }

        /// <summary>
        /// The currency the bank account is in
        /// </summary>
        /// <value>The currency the bank account is in</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public CurrencyEnum Currency { get; set; }
        /// <summary>
        /// The method of the payment. Currently bank and mobile are supported
        /// </summary>
        /// <value>The method of the payment. Currently bank and mobile are supported</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MethodEnum
        {
            /// <summary>
            /// Enum Bank for value: bank
            /// </summary>
            [EnumMember(Value = "bank")]
            Bank = 1,

            /// <summary>
            /// Enum Mobile for value: mobile
            /// </summary>
            [EnumMember(Value = "mobile")]
            Mobile = 2

        }

        /// <summary>
        /// The method of the payment. Currently bank and mobile are supported
        /// </summary>
        /// <value>The method of the payment. Currently bank and mobile are supported</value>
        [DataMember(Name="method", EmitDefaultValue=false)]
        public MethodEnum Method { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountValidationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountValidationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountValidationRequest" /> class.
        /// </summary>
        /// <param name="bankAccount">Account Number to query.</param>
        /// <param name="bankCode">Bank Code to query - same codes are used as for creating the transactions.</param>
        /// <param name="phoneNumber">Phone number to query.</param>
        /// <param name="mobileProvider">mobileProvider.</param>
        /// <param name="country">Country of account in 2-character alpha ISO 3166-2 country format (required).</param>
        /// <param name="currency">The currency the bank account is in (required).</param>
        /// <param name="method">The method of the payment. Currently bank and mobile are supported (required).</param>
        public AccountValidationRequest(string bankAccount = default(string), string bankCode = default(string), string phoneNumber = default(string), PayoutMethodMobileProviderEnum mobileProvider = default(PayoutMethodMobileProviderEnum), CountryEnum country = default(CountryEnum), CurrencyEnum currency = default(CurrencyEnum), MethodEnum method = default(MethodEnum))
        {
            this.Country = country;
            this.Currency = currency;
            this.Method = method;
            this.BankAccount = bankAccount;
            this.BankCode = bankCode;
            this.PhoneNumber = phoneNumber;
            this.MobileProvider = mobileProvider;
        }
        
        /// <summary>
        /// Account Number to query
        /// </summary>
        /// <value>Account Number to query</value>
        [DataMember(Name="bank_account", EmitDefaultValue=false)]
        public string BankAccount { get; set; }

        /// <summary>
        /// Bank Code to query - same codes are used as for creating the transactions
        /// </summary>
        /// <value>Bank Code to query - same codes are used as for creating the transactions</value>
        [DataMember(Name="bank_code", EmitDefaultValue=false)]
        public string BankCode { get; set; }

        /// <summary>
        /// Phone number to query
        /// </summary>
        /// <value>Phone number to query</value>
        [DataMember(Name="phone_number", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets MobileProvider
        /// </summary>
        [DataMember(Name="mobile_provider", EmitDefaultValue=false)]
        public PayoutMethodMobileProviderEnum MobileProvider { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountValidationRequest {\n");
            sb.Append("  BankAccount: ").Append(BankAccount).Append("\n");
            sb.Append("  BankCode: ").Append(BankCode).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  MobileProvider: ").Append(MobileProvider).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
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
            return this.Equals(input as AccountValidationRequest);
        }

        /// <summary>
        /// Returns true if AccountValidationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountValidationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountValidationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BankAccount == input.BankAccount ||
                    (this.BankAccount != null &&
                    this.BankAccount.Equals(input.BankAccount))
                ) && 
                (
                    this.BankCode == input.BankCode ||
                    (this.BankCode != null &&
                    this.BankCode.Equals(input.BankCode))
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
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
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
                if (this.BankAccount != null)
                    hashCode = hashCode * 59 + this.BankAccount.GetHashCode();
                if (this.BankCode != null)
                    hashCode = hashCode * 59 + this.BankCode.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.MobileProvider != null)
                    hashCode = hashCode * 59 + this.MobileProvider.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.Method != null)
                    hashCode = hashCode * 59 + this.Method.GetHashCode();
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
