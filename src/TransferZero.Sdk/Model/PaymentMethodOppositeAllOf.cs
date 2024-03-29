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
    /// PaymentMethodOppositeAllOf
    /// </summary>
    [DataContract]
    public partial class PaymentMethodOppositeAllOf :  IEquatable<PaymentMethodOppositeAllOf>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodOppositeAllOf" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PaymentMethodOppositeAllOf()
        {
        }
        
        /// <summary>
        /// List of all providers that can be used in conjunction with the main provider
        /// </summary>
        /// <value>List of all providers that can be used in conjunction with the main provider</value>
        [DataMember(Name="opposites", EmitDefaultValue=false)]
        public List<PaymentMethod> Opposites { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentMethodOppositeAllOf {\n");
            sb.Append("  Opposites: ").Append(Opposites).Append("\n");
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
            return this.Equals(input as PaymentMethodOppositeAllOf);
        }

        /// <summary>
        /// Returns true if PaymentMethodOppositeAllOf instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentMethodOppositeAllOf to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethodOppositeAllOf input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Opposites == input.Opposites ||
                    this.Opposites != null &&
                    this.Opposites.SequenceEqual(input.Opposites)
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
                if (this.Opposites != null)
                    hashCode = hashCode * 59 + this.Opposites.GetHashCode();
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
