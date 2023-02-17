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
    /// Additional features that are enabled on the transaction. For more details please see [Additional features](https://docs.transferzero.com/docs/additional-features/) in our API documentation
    /// </summary>
    [DataContract]
    public partial class TransactionTraits :  IEquatable<TransactionTraits>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionTraits" /> class.
        /// </summary>
        /// <param name="autoRefund">Enables or disables the auto refund functionality. Please see [Auto cancellation and refund of transactions](https://docs.transferzero.com/docs/additional-features/#auto-cancellation-and-refund-of-transactions) for more details.</param>
        /// <param name="accountValidation">Enabled or disables the name validation functionality. Please see [Name validation in transactions](https://docs.transferzero.com/docs/additional-features/#name-validation-in-transactions) for more details.</param>
        public TransactionTraits(bool? autoRefund = default(bool?), bool? accountValidation = default(bool?))
        {
            this.AutoRefund = autoRefund;
            this.AccountValidation = accountValidation;
        }
        
        /// <summary>
        /// Enables or disables the auto refund functionality. Please see [Auto cancellation and refund of transactions](https://docs.transferzero.com/docs/additional-features/#auto-cancellation-and-refund-of-transactions) for more details
        /// </summary>
        /// <value>Enables or disables the auto refund functionality. Please see [Auto cancellation and refund of transactions](https://docs.transferzero.com/docs/additional-features/#auto-cancellation-and-refund-of-transactions) for more details</value>
        [DataMember(Name="auto_refund", EmitDefaultValue=false)]
        public bool? AutoRefund { get; set; }

        /// <summary>
        /// Enabled or disables the name validation functionality. Please see [Name validation in transactions](https://docs.transferzero.com/docs/additional-features/#name-validation-in-transactions) for more details
        /// </summary>
        /// <value>Enabled or disables the name validation functionality. Please see [Name validation in transactions](https://docs.transferzero.com/docs/additional-features/#name-validation-in-transactions) for more details</value>
        [DataMember(Name="account_validation", EmitDefaultValue=false)]
        public bool? AccountValidation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionTraits {\n");
            sb.Append("  AutoRefund: ").Append(AutoRefund).Append("\n");
            sb.Append("  AccountValidation: ").Append(AccountValidation).Append("\n");
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
            return this.Equals(input as TransactionTraits);
        }

        /// <summary>
        /// Returns true if TransactionTraits instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionTraits to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionTraits input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AutoRefund == input.AutoRefund ||
                    (this.AutoRefund != null &&
                    this.AutoRefund.Equals(input.AutoRefund))
                ) && 
                (
                    this.AccountValidation == input.AccountValidation ||
                    (this.AccountValidation != null &&
                    this.AccountValidation.Equals(input.AccountValidation))
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
                if (this.AutoRefund != null)
                    hashCode = hashCode * 59 + this.AutoRefund.GetHashCode();
                if (this.AccountValidation != null)
                    hashCode = hashCode * 59 + this.AccountValidation.GetHashCode();
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
