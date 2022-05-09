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
    /// This describes the specific details on how the payment has to be routed to the recipient.
    /// </summary>
    [DataContract]
    public partial class PayoutMethod :  IEquatable<PayoutMethod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayoutMethod" /> class.
        /// </summary>
        /// <param name="type">Contains the currency to send the money to, and the type of the money movement  Commonly used payout types are:  - &#x60;NGN::Bank&#x60; - for Nigerian bank account payments. - &#x60;NGN::Mobile&#x60; - for Nigerian mobile money payments. - &#x60;GHS::Bank&#x60; - for Ghanaian bank account payments. - &#x60;GHS::Mobile&#x60; - for Ghanaian mobile money payments. - &#x60;GHS::Cash&#x60; - for Ghanaian cash remittance payments. - &#x60;UGX::Mobile&#x60; - for Ugandan mobile money payments. - &#x60;TZS::Mobile&#x60; - for Tanzanian mobile money payments. - &#x60;XOF::Mobile&#x60; - for mobile money payments to West-Africa. - &#x60;XOF::Bank&#x60; - for Senegalese bank account payments. - &#x60;XOF::Cash&#x60; - for Senegalese cash remittance payments. - &#x60;MAD::Cash&#x60; - for Moroccan cash remittance payments. - &#x60;EUR::Bank&#x60; - for IBAN bank transfers in EUR. - &#x60;GBP::Bank&#x60; - for IBAN bank and FP accounts transfers in GBP. - &#x60;ZAR::Bank&#x60; - for South Africa bank account payments. - &#x60;USD::Bank&#x60; - for USD account payments. *** Currently Nigeria only and in Beta phase *** - &#x60;USD::Cash&#x60; - for USD cash remittance payments. *** Currently Nigeria only and in Beta phase *** - &#x60;KES::Bank&#x60; - for Kenyan bank account payments. - &#x60;KES::Mobile&#x60; - for Kenyan mobile money payments. - &#x60;XAF::Mobile&#x60; - for mobile money payments to Cameroon. - &#x60;GNF::Mobile&#x60; - for mobile money payments to Guinea.  You can also send funds to the internal balance using &#x60;CCY::Balance&#x60;, where &#x60;CCY&#x60; is the appropriate currency. See [Collection from senders](https://docs.transferzero.com/docs/additional-features/#collections-from-senders) for more info on how to collect money into internal balance .</param>
        /// <param name="details">details.</param>
        /// <param name="metadata">Metadata of payout method. You can store any kind of information in this field..</param>
        /// <param name="id">id.</param>
        public PayoutMethod(string type = default(string), PayoutMethodDetails details = default(PayoutMethodDetails), Object metadata = default(Object), Guid id = default(Guid))
        {
            this.Type = type;
            this.Details = details;
            this.Metadata = metadata;
            this.Id = id;
        }
        
        /// <summary>
        /// Contains the currency to send the money to, and the type of the money movement  Commonly used payout types are:  - &#x60;NGN::Bank&#x60; - for Nigerian bank account payments. - &#x60;NGN::Mobile&#x60; - for Nigerian mobile money payments. - &#x60;GHS::Bank&#x60; - for Ghanaian bank account payments. - &#x60;GHS::Mobile&#x60; - for Ghanaian mobile money payments. - &#x60;GHS::Cash&#x60; - for Ghanaian cash remittance payments. - &#x60;UGX::Mobile&#x60; - for Ugandan mobile money payments. - &#x60;TZS::Mobile&#x60; - for Tanzanian mobile money payments. - &#x60;XOF::Mobile&#x60; - for mobile money payments to West-Africa. - &#x60;XOF::Bank&#x60; - for Senegalese bank account payments. - &#x60;XOF::Cash&#x60; - for Senegalese cash remittance payments. - &#x60;MAD::Cash&#x60; - for Moroccan cash remittance payments. - &#x60;EUR::Bank&#x60; - for IBAN bank transfers in EUR. - &#x60;GBP::Bank&#x60; - for IBAN bank and FP accounts transfers in GBP. - &#x60;ZAR::Bank&#x60; - for South Africa bank account payments. - &#x60;USD::Bank&#x60; - for USD account payments. *** Currently Nigeria only and in Beta phase *** - &#x60;USD::Cash&#x60; - for USD cash remittance payments. *** Currently Nigeria only and in Beta phase *** - &#x60;KES::Bank&#x60; - for Kenyan bank account payments. - &#x60;KES::Mobile&#x60; - for Kenyan mobile money payments. - &#x60;XAF::Mobile&#x60; - for mobile money payments to Cameroon. - &#x60;GNF::Mobile&#x60; - for mobile money payments to Guinea.  You can also send funds to the internal balance using &#x60;CCY::Balance&#x60;, where &#x60;CCY&#x60; is the appropriate currency. See [Collection from senders](https://docs.transferzero.com/docs/additional-features/#collections-from-senders) for more info on how to collect money into internal balance 
        /// </summary>
        /// <value>Contains the currency to send the money to, and the type of the money movement  Commonly used payout types are:  - &#x60;NGN::Bank&#x60; - for Nigerian bank account payments. - &#x60;NGN::Mobile&#x60; - for Nigerian mobile money payments. - &#x60;GHS::Bank&#x60; - for Ghanaian bank account payments. - &#x60;GHS::Mobile&#x60; - for Ghanaian mobile money payments. - &#x60;GHS::Cash&#x60; - for Ghanaian cash remittance payments. - &#x60;UGX::Mobile&#x60; - for Ugandan mobile money payments. - &#x60;TZS::Mobile&#x60; - for Tanzanian mobile money payments. - &#x60;XOF::Mobile&#x60; - for mobile money payments to West-Africa. - &#x60;XOF::Bank&#x60; - for Senegalese bank account payments. - &#x60;XOF::Cash&#x60; - for Senegalese cash remittance payments. - &#x60;MAD::Cash&#x60; - for Moroccan cash remittance payments. - &#x60;EUR::Bank&#x60; - for IBAN bank transfers in EUR. - &#x60;GBP::Bank&#x60; - for IBAN bank and FP accounts transfers in GBP. - &#x60;ZAR::Bank&#x60; - for South Africa bank account payments. - &#x60;USD::Bank&#x60; - for USD account payments. *** Currently Nigeria only and in Beta phase *** - &#x60;USD::Cash&#x60; - for USD cash remittance payments. *** Currently Nigeria only and in Beta phase *** - &#x60;KES::Bank&#x60; - for Kenyan bank account payments. - &#x60;KES::Mobile&#x60; - for Kenyan mobile money payments. - &#x60;XAF::Mobile&#x60; - for mobile money payments to Cameroon. - &#x60;GNF::Mobile&#x60; - for mobile money payments to Guinea.  You can also send funds to the internal balance using &#x60;CCY::Balance&#x60;, where &#x60;CCY&#x60; is the appropriate currency. See [Collection from senders](https://docs.transferzero.com/docs/additional-features/#collections-from-senders) for more info on how to collect money into internal balance </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Details
        /// </summary>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public PayoutMethodDetails Details { get; set; }

        /// <summary>
        /// Metadata of payout method. You can store any kind of information in this field.
        /// </summary>
        /// <value>Metadata of payout method. You can store any kind of information in this field.</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Object Metadata { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid Id { get; set; }

        /// <summary>
        /// The fields that have some problems and don&#39;t pass validation
        /// </summary>
        /// <value>The fields that have some problems and don&#39;t pass validation</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public Dictionary<string, List<ValidationErrorDescription>> Errors { get; private set; }

        /// <summary>
        /// The fields needed for payments with this payment method with details on validation requirements
        /// </summary>
        /// <value>The fields needed for payments with this payment method with details on validation requirements</value>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public Dictionary<string, FieldDescription> Fields { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayoutMethod {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
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
            return this.Equals(input as PayoutMethod);
        }

        /// <summary>
        /// Returns true if PayoutMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of PayoutMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayoutMethod input)
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
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Errors == input.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(input.Errors)
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
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
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Errors != null)
                    hashCode = hashCode * 59 + this.Errors.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
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
