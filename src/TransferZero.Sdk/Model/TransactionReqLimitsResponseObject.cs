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
    /// TransactionReqLimitsResponseObject
    /// </summary>
    [DataContract]
    public partial class TransactionReqLimitsResponseObject :  IEquatable<TransactionReqLimitsResponseObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionReqLimitsResponseObject" /> class.
        /// </summary>
        /// <param name="minimum">The minimum limit for transaction requests (in USD).</param>
        /// <param name="maximum">The maximum limit for transaction requests (in USD).</param>
        public TransactionReqLimitsResponseObject(int? minimum = default(int?), int? maximum = default(int?))
        {
            this.Minimum = minimum;
            this.Maximum = maximum;
        }
        
        /// <summary>
        /// The minimum limit for transaction requests (in USD)
        /// </summary>
        /// <value>The minimum limit for transaction requests (in USD)</value>
        [DataMember(Name="minimum", EmitDefaultValue=false)]
        public int? Minimum { get; set; }

        /// <summary>
        /// The maximum limit for transaction requests (in USD)
        /// </summary>
        /// <value>The maximum limit for transaction requests (in USD)</value>
        [DataMember(Name="maximum", EmitDefaultValue=false)]
        public int? Maximum { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionReqLimitsResponseObject {\n");
            sb.Append("  Minimum: ").Append(Minimum).Append("\n");
            sb.Append("  Maximum: ").Append(Maximum).Append("\n");
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
            return this.Equals(input as TransactionReqLimitsResponseObject);
        }

        /// <summary>
        /// Returns true if TransactionReqLimitsResponseObject instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionReqLimitsResponseObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionReqLimitsResponseObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Minimum == input.Minimum ||
                    (this.Minimum != null &&
                    this.Minimum.Equals(input.Minimum))
                ) && 
                (
                    this.Maximum == input.Maximum ||
                    (this.Maximum != null &&
                    this.Maximum.Equals(input.Maximum))
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
                if (this.Minimum != null)
                    hashCode = hashCode * 59 + this.Minimum.GetHashCode();
                if (this.Maximum != null)
                    hashCode = hashCode * 59 + this.Maximum.GetHashCode();
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
