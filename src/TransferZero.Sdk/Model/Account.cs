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
    /// Account
    /// </summary>
    [DataContract]
    public partial class Account :  IEquatable<Account>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Account" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Account()
        {
        }
        
        /// <summary>
        /// The account balance for the given currency
        /// </summary>
        /// <value>The account balance for the given currency</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; private set; }

        /// <summary>
        /// The currency of this balance
        /// </summary>
        /// <value>The currency of this balance</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; private set; }

        /// <summary>
        /// Represents the account balance after deducting pending transactions from the last 7 days. It provides a more accurate depiction of available funds.
        /// </summary>
        /// <value>Represents the account balance after deducting pending transactions from the last 7 days. It provides a more accurate depiction of available funds.</value>
        [DataMember(Name="amount_after_pending", EmitDefaultValue=false)]
        public decimal? AmountAfterPending { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Account {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  AmountAfterPending: ").Append(AmountAfterPending).Append("\n");
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
            return this.Equals(input as Account);
        }

        /// <summary>
        /// Returns true if Account instances are equal
        /// </summary>
        /// <param name="input">Instance of Account to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Account input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.AmountAfterPending == input.AmountAfterPending ||
                    (this.AmountAfterPending != null &&
                    this.AmountAfterPending.Equals(input.AmountAfterPending))
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.AmountAfterPending != null)
                    hashCode = hashCode * 59 + this.AmountAfterPending.GetHashCode();
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
