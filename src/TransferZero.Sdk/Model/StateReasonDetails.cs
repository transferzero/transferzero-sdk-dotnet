/* 
 * TransferZero API
 *
 * Reference documentation for the TransferZero API V1
 *
 * The version of the OpenAPI document: 1.0
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
    /// StateReasonDetails
    /// </summary>
    [DataContract]
    public partial class StateReasonDetails :  IEquatable<StateReasonDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StateReasonDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public StateReasonDetails()
        {
        }
        
        /// <summary>
        /// Status code of transaction
        /// </summary>
        /// <value>Status code of transaction</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; private set; }

        /// <summary>
        /// Main category of status code, it could be paid, unknown, pickupable, temporary_error, recipient_error, sender_error, sender_action_required
        /// </summary>
        /// <value>Main category of status code, it could be paid, unknown, pickupable, temporary_error, recipient_error, sender_error, sender_action_required</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; private set; }

        /// <summary>
        /// Tiered messages
        /// </summary>
        /// <value>Tiered messages</value>
        [DataMember(Name="messages", EmitDefaultValue=false)]
        public List<string> Messages { get; private set; }

        /// <summary>
        /// Public, human readable, detailed error message
        /// </summary>
        /// <value>Public, human readable, detailed error message</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StateReasonDetails {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as StateReasonDetails);
        }

        /// <summary>
        /// Returns true if StateReasonDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of StateReasonDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StateReasonDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Messages == input.Messages ||
                    this.Messages != null &&
                    this.Messages.SequenceEqual(input.Messages)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Messages != null)
                    hashCode = hashCode * 59 + this.Messages.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
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
