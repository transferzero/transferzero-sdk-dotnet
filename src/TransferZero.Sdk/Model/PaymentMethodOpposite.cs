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
    /// PaymentMethodOpposite
    /// </summary>
    [DataContract]
    public partial class PaymentMethodOpposite :  IEquatable<PaymentMethodOpposite>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodOpposite" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PaymentMethodOpposite()
        {
        }
        
        /// <summary>
        /// Details currency and type of payment.
        /// </summary>
        /// <value>Details currency and type of payment.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; private set; }

        /// <summary>
        /// Identifies the payment provider.
        /// </summary>
        /// <value>Identifies the payment provider.</value>
        [DataMember(Name="provider", EmitDefaultValue=false)]
        public string Provider { get; private set; }

        /// <summary>
        /// Are over the counter transactions permitted?
        /// </summary>
        /// <value>Are over the counter transactions permitted?</value>
        [DataMember(Name="otc_permitted", EmitDefaultValue=false)]
        public bool OtcPermitted { get; private set; }

        /// <summary>
        /// Fields required to make the payment depending on type.
        /// </summary>
        /// <value>Fields required to make the payment depending on type.</value>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public List<string> Details { get; private set; }

        /// <summary>
        /// Boolean revealing whether this is the default payout method. Only present on payout methods
        /// </summary>
        /// <value>Boolean revealing whether this is the default payout method. Only present on payout methods</value>
        [DataMember(Name="default", EmitDefaultValue=false)]
        public bool Default { get; private set; }

        /// <summary>
        /// The fields needed for payments with this payment method with details on validation requirements
        /// </summary>
        /// <value>The fields needed for payments with this payment method with details on validation requirements</value>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public Dictionary<string, FieldDescription> Fields { get; private set; }

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
            sb.Append("class PaymentMethodOpposite {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  OtcPermitted: ").Append(OtcPermitted).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
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
            return this.Equals(input as PaymentMethodOpposite);
        }

        /// <summary>
        /// Returns true if PaymentMethodOpposite instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentMethodOpposite to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethodOpposite input)
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
                    this.Provider == input.Provider ||
                    (this.Provider != null &&
                    this.Provider.Equals(input.Provider))
                ) && 
                (
                    this.OtcPermitted == input.OtcPermitted ||
                    (this.OtcPermitted != null &&
                    this.OtcPermitted.Equals(input.OtcPermitted))
                ) && 
                (
                    this.Details == input.Details ||
                    this.Details != null &&
                    this.Details.SequenceEqual(input.Details)
                ) && 
                (
                    this.Default == input.Default ||
                    (this.Default != null &&
                    this.Default.Equals(input.Default))
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
                ) && 
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Provider != null)
                    hashCode = hashCode * 59 + this.Provider.GetHashCode();
                if (this.OtcPermitted != null)
                    hashCode = hashCode * 59 + this.OtcPermitted.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.Default != null)
                    hashCode = hashCode * 59 + this.Default.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
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
