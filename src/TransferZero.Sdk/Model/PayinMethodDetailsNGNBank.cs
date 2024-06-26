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
    /// &#x60;&#x60;&#x60;JSON   \&quot;details\&quot;: {     \&quot;phone_number\&quot;: \&quot;+2347087661211\&quot;   } &#x60;&#x60;&#x60;
    /// </summary>
    [DataContract]
    public partial class PayinMethodDetailsNGNBank :  IEquatable<PayinMethodDetailsNGNBank>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayinMethodDetailsNGNBank" /> class.
        /// </summary>
        /// <param name="phoneNumber">Sender&#39;s phone number.</param>
        public PayinMethodDetailsNGNBank(string phoneNumber = default(string))
        {
            this.PhoneNumber = phoneNumber;
        }
        
        /// <summary>
        /// Sender&#39;s phone number
        /// </summary>
        /// <value>Sender&#39;s phone number</value>
        [DataMember(Name="phone_number", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayinMethodDetailsNGNBank {\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
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
            return this.Equals(input as PayinMethodDetailsNGNBank);
        }

        /// <summary>
        /// Returns true if PayinMethodDetailsNGNBank instances are equal
        /// </summary>
        /// <param name="input">Instance of PayinMethodDetailsNGNBank to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayinMethodDetailsNGNBank input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
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
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
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
