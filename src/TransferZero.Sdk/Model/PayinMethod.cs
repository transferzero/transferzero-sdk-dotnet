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
    /// This describes the specific details on how the funds should be collected from the sender.
    /// </summary>
    [DataContract]
    public partial class PayinMethod :  IEquatable<PayinMethod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayinMethod" /> class.
        /// </summary>
        /// <param name="type">Describes how the payment should be requested from the user.  Possible values: - &#x60;NGN::Bank&#x60;: NGN card collection requests - &#x60;GHS::Mobile&#x60;: GHS mobile collections - &#x60;TZS::Mobile&#x60;: TZS mobile collections - &#x60;UGX::Mobile&#x60;: UGX mobile collections .</param>
        /// <param name="inDetails">inDetails.</param>
        /// <param name="provider">Describes which provider to use for collection. Please see the [Collections from Senders](https://github.com/transferzero/api-documentation/blob/master/additional-features.md#collections-from-senders) in the API documentation on the valid values.</param>
        public PayinMethod(string type = default(string), PayinMethodDetails inDetails = default(PayinMethodDetails), string provider = default(string))
        {
            this.Type = type;
            this.InDetails = inDetails;
            this.Provider = provider;
        }
        
        /// <summary>
        /// Describes how the payment should be requested from the user.  Possible values: - &#x60;NGN::Bank&#x60;: NGN card collection requests - &#x60;GHS::Mobile&#x60;: GHS mobile collections - &#x60;TZS::Mobile&#x60;: TZS mobile collections - &#x60;UGX::Mobile&#x60;: UGX mobile collections 
        /// </summary>
        /// <value>Describes how the payment should be requested from the user.  Possible values: - &#x60;NGN::Bank&#x60;: NGN card collection requests - &#x60;GHS::Mobile&#x60;: GHS mobile collections - &#x60;TZS::Mobile&#x60;: TZS mobile collections - &#x60;UGX::Mobile&#x60;: UGX mobile collections </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets InDetails
        /// </summary>
        [DataMember(Name="in_details", EmitDefaultValue=false)]
        public PayinMethodDetails InDetails { get; set; }

        /// <summary>
        /// This will contain the description on where to pay the funds. Please see the [Collections from Senders](https://github.com/transferzero/api-documentation/blob/master/additional-features.md#collections-from-senders) in the API documentation on what to expect here.
        /// </summary>
        /// <value>This will contain the description on where to pay the funds. Please see the [Collections from Senders](https://github.com/transferzero/api-documentation/blob/master/additional-features.md#collections-from-senders) in the API documentation on what to expect here.</value>
        [DataMember(Name="out_details", EmitDefaultValue=false)]
        public Object OutDetails { get; private set; }

        /// <summary>
        /// This will contain the instructions on how to pay the funds. Please see the [Collections from Senders](https://github.com/transferzero/api-documentation/blob/master/additional-features.md#collections-from-senders) in the API documentation on what to expect here.
        /// </summary>
        /// <value>This will contain the instructions on how to pay the funds. Please see the [Collections from Senders](https://github.com/transferzero/api-documentation/blob/master/additional-features.md#collections-from-senders) in the API documentation on what to expect here.</value>
        [DataMember(Name="instructions", EmitDefaultValue=false)]
        public Object Instructions { get; private set; }

        /// <summary>
        /// Describes which provider to use for collection. Please see the [Collections from Senders](https://github.com/transferzero/api-documentation/blob/master/additional-features.md#collections-from-senders) in the API documentation on the valid values
        /// </summary>
        /// <value>Describes which provider to use for collection. Please see the [Collections from Senders](https://github.com/transferzero/api-documentation/blob/master/additional-features.md#collections-from-senders) in the API documentation on the valid values</value>
        [DataMember(Name="provider", EmitDefaultValue=false)]
        public string Provider { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayinMethod {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  InDetails: ").Append(InDetails).Append("\n");
            sb.Append("  OutDetails: ").Append(OutDetails).Append("\n");
            sb.Append("  Instructions: ").Append(Instructions).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
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
            return this.Equals(input as PayinMethod);
        }

        /// <summary>
        /// Returns true if PayinMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of PayinMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayinMethod input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.InDetails == input.InDetails ||
                    (this.InDetails != null &&
                    this.InDetails.Equals(input.InDetails))
                ) && 
                (
                    this.OutDetails == input.OutDetails ||
                    (this.OutDetails != null &&
                    this.OutDetails.Equals(input.OutDetails))
                ) && 
                (
                    this.Instructions == input.Instructions ||
                    (this.Instructions != null &&
                    this.Instructions.Equals(input.Instructions))
                ) && 
                (
                    this.Provider == input.Provider ||
                    (this.Provider != null &&
                    this.Provider.Equals(input.Provider))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.InDetails != null)
                    hashCode = hashCode * 59 + this.InDetails.GetHashCode();
                if (this.OutDetails != null)
                    hashCode = hashCode * 59 + this.OutDetails.GetHashCode();
                if (this.Instructions != null)
                    hashCode = hashCode * 59 + this.Instructions.GetHashCode();
                if (this.Provider != null)
                    hashCode = hashCode * 59 + this.Provider.GetHashCode();
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
