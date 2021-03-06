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
    /// FieldValidation
    /// </summary>
    [DataContract]
    public partial class FieldValidation :  IEquatable<FieldValidation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldValidation" /> class.
        /// </summary>
        /// <param name="inclusion">inclusion.</param>
        public FieldValidation(FieldSelectValidation inclusion = default(FieldSelectValidation))
        {
            this.Inclusion = inclusion;
        }
        
        /// <summary>
        /// Describes whether the field is mandatory or not
        /// </summary>
        /// <value>Describes whether the field is mandatory or not</value>
        [DataMember(Name="presence", EmitDefaultValue=false)]
        public bool? Presence { get; private set; }

        /// <summary>
        /// Gets or Sets Inclusion
        /// </summary>
        [DataMember(Name="inclusion", EmitDefaultValue=false)]
        public FieldSelectValidation Inclusion { get; set; }

        /// <summary>
        /// Contains the regex to use to validate the input field
        /// </summary>
        /// <value>Contains the regex to use to validate the input field</value>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public Object Format { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldValidation {\n");
            sb.Append("  Presence: ").Append(Presence).Append("\n");
            sb.Append("  Inclusion: ").Append(Inclusion).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
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
            return this.Equals(input as FieldValidation);
        }

        /// <summary>
        /// Returns true if FieldValidation instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldValidation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldValidation input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Presence == input.Presence ||
                    (this.Presence != null &&
                    this.Presence.Equals(input.Presence))
                ) && 
                (
                    this.Inclusion == input.Inclusion ||
                    (this.Inclusion != null &&
                    this.Inclusion.Equals(input.Inclusion))
                ) && 
                (
                    this.Format == input.Format ||
                    (this.Format != null &&
                    this.Format.Equals(input.Format))
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
                if (this.Presence != null)
                    hashCode = hashCode * 59 + this.Presence.GetHashCode();
                if (this.Inclusion != null)
                    hashCode = hashCode * 59 + this.Inclusion.GetHashCode();
                if (this.Format != null)
                    hashCode = hashCode * 59 + this.Format.GetHashCode();
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
