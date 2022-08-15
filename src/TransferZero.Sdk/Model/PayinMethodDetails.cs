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
    /// Fields needed by the payment processor. Depends on the chose payin type.  See the appropriate model details for more info:  - &#x60;NGN::Bank&#x60;: see [&#x60;PayinMethodDetailsNGNBank&#x60;](#model-PayinMethodDetailsNGNBank) - &#x60;GHS::Mobile&#x60;: see [&#x60;PayinMethodDetailsMobile&#x60;](#model-PayinMethodDetailsMobile) - &#x60;UGX::Mobile&#x60;: see [&#x60;PayinMethodDetailsMobile&#x60;](#model-PayinMethodDetailsMobile) - &#x60;TZS::Mobile&#x60;: see [&#x60;PayinMethodDetailsMobile&#x60;](#model-PayinMethodDetailsMobile)  Note that some payin processors don&#39;t require additional input, these include &#x60;paga&#x60; through &#x60;NGN::Mobile&#x60;, &#x60;lhv&#x60; through &#x60;EUR::Bank&#x60; and &#x60;GBP::Bank&#x60;. Some providers like &#x60;providus&#x60; also have all of their fields set as optional, so you might not want to set any values. To use these providers please set this value to &#x60;{}&#x60; (an empty hash) 
    /// </summary>
    [DataContract]
    public partial class PayinMethodDetails :  IEquatable<PayinMethodDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayinMethodDetails" /> class.
        /// </summary>
        /// <param name="paymentMethod">The payment method which the sender will use to make the payments. Options are &#x60;bank&#x60;, &#x60;card&#x60; or you can leave empty to support both..</param>
        /// <param name="redirectUrl">This is where the sender should be redirected back when the payment has been finished.</param>
        /// <param name="phoneNumber">The phone number where the funds should be collected from.</param>
        /// <param name="mobileProvider">mobileProvider.</param>
        /// <param name="country">country.</param>
        /// <param name="otp">The OTP that the sender received in otp verified ussd popup ux flow..</param>
        /// <param name="refundAddress">Please make sure the refund_address is a valid BTC address belonging to the sender, as that is going to be used in case the transaction has to be refunded..</param>
        public PayinMethodDetails(string paymentMethod = default(string), string redirectUrl = default(string), string phoneNumber = default(string), PayoutMethodMobileProviderEnum mobileProvider = default(PayoutMethodMobileProviderEnum), PayoutMethodCountryEnum country = default(PayoutMethodCountryEnum), string otp = default(string), string refundAddress = default(string))
        {
            this.PaymentMethod = paymentMethod;
            this.RedirectUrl = redirectUrl;
            this.PhoneNumber = phoneNumber;
            this.MobileProvider = mobileProvider;
            this.Country = country;
            this.Otp = otp;
            this.RefundAddress = refundAddress;
        }
        
        /// <summary>
        /// The payment method which the sender will use to make the payments. Options are &#x60;bank&#x60;, &#x60;card&#x60; or you can leave empty to support both.
        /// </summary>
        /// <value>The payment method which the sender will use to make the payments. Options are &#x60;bank&#x60;, &#x60;card&#x60; or you can leave empty to support both.</value>
        [DataMember(Name="payment_method", EmitDefaultValue=false)]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// This is where the sender should be redirected back when the payment has been finished
        /// </summary>
        /// <value>This is where the sender should be redirected back when the payment has been finished</value>
        [DataMember(Name="redirect_url", EmitDefaultValue=false)]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// The phone number where the funds should be collected from
        /// </summary>
        /// <value>The phone number where the funds should be collected from</value>
        [DataMember(Name="phone_number", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets MobileProvider
        /// </summary>
        [DataMember(Name="mobile_provider", EmitDefaultValue=false)]
        public PayoutMethodMobileProviderEnum MobileProvider { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public PayoutMethodCountryEnum Country { get; set; }

        /// <summary>
        /// The OTP that the sender received in otp verified ussd popup ux flow.
        /// </summary>
        /// <value>The OTP that the sender received in otp verified ussd popup ux flow.</value>
        [DataMember(Name="otp", EmitDefaultValue=false)]
        public string Otp { get; set; }

        /// <summary>
        /// Please make sure the refund_address is a valid BTC address belonging to the sender, as that is going to be used in case the transaction has to be refunded.
        /// </summary>
        /// <value>Please make sure the refund_address is a valid BTC address belonging to the sender, as that is going to be used in case the transaction has to be refunded.</value>
        [DataMember(Name="refund_address", EmitDefaultValue=false)]
        public string RefundAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayinMethodDetails {\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  RedirectUrl: ").Append(RedirectUrl).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  MobileProvider: ").Append(MobileProvider).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Otp: ").Append(Otp).Append("\n");
            sb.Append("  RefundAddress: ").Append(RefundAddress).Append("\n");
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
            return this.Equals(input as PayinMethodDetails);
        }

        /// <summary>
        /// Returns true if PayinMethodDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of PayinMethodDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayinMethodDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    (this.PaymentMethod != null &&
                    this.PaymentMethod.Equals(input.PaymentMethod))
                ) && 
                (
                    this.RedirectUrl == input.RedirectUrl ||
                    (this.RedirectUrl != null &&
                    this.RedirectUrl.Equals(input.RedirectUrl))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.MobileProvider == input.MobileProvider ||
                    (this.MobileProvider != null &&
                    this.MobileProvider.Equals(input.MobileProvider))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Otp == input.Otp ||
                    (this.Otp != null &&
                    this.Otp.Equals(input.Otp))
                ) && 
                (
                    this.RefundAddress == input.RefundAddress ||
                    (this.RefundAddress != null &&
                    this.RefundAddress.Equals(input.RefundAddress))
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
                if (this.PaymentMethod != null)
                    hashCode = hashCode * 59 + this.PaymentMethod.GetHashCode();
                if (this.RedirectUrl != null)
                    hashCode = hashCode * 59 + this.RedirectUrl.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.MobileProvider != null)
                    hashCode = hashCode * 59 + this.MobileProvider.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Otp != null)
                    hashCode = hashCode * 59 + this.Otp.GetHashCode();
                if (this.RefundAddress != null)
                    hashCode = hashCode * 59 + this.RefundAddress.GetHashCode();
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
