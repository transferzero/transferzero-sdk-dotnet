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
    /// The recipient describes the amount, the currency and the destination where the money should be sent.
    /// </summary>
    [DataContract]
    public partial class Recipient :  IEquatable<Recipient>, IValidatableObject
    {
        /// <summary>
        /// Type of recipient to create - either person or business (defaults to person) 
        /// </summary>
        /// <value>Type of recipient to create - either person or business (defaults to person) </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Person for value: person
            /// </summary>
            [EnumMember(Value = "person")]
            Person = 1,

            /// <summary>
            /// Enum Business for value: business
            /// </summary>
            [EnumMember(Value = "business")]
            Business = 2

        }

        /// <summary>
        /// Type of recipient to create - either person or business (defaults to person) 
        /// </summary>
        /// <value>Type of recipient to create - either person or business (defaults to person) </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Recipient" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Recipient() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Recipient" /> class.
        /// </summary>
        /// <param name="requestedAmount">the amount that should be paid to the recipient. This can be in any currency, usually either the input or the output currency. If the value here is not the output currency we will calculate how much the recipient is going to get using the exchange rates active when the transaction was created. (required).</param>
        /// <param name="requestedCurrency">the currency of the amount in 3-character alpha ISO 4217 currency format (required).</param>
        /// <param name="payoutMethod">payoutMethod (required).</param>
        /// <param name="metadata">Additional metadata that can be added to a recipient. These values will be returned on request.</param>
        /// <param name="stateReasonDetails">stateReasonDetails.</param>
        /// <param name="state">state.</param>
        /// <param name="transactionExternalId">Optional ID that is supplied by partner linking it to the partner&#39;s own Transaction ID..</param>
        /// <param name="transactionState">transactionState.</param>
        /// <param name="type">Type of recipient to create - either person or business (defaults to person) .</param>
        public Recipient(decimal? requestedAmount = default(decimal?), string requestedCurrency = default(string), PayoutMethod payoutMethod = default(PayoutMethod), Object metadata = default(Object), RecipientStateReasonDetails stateReasonDetails = default(RecipientStateReasonDetails), RecipientState state = default(RecipientState), string transactionExternalId = default(string), TransactionState transactionState = default(TransactionState), TypeEnum? type = default(TypeEnum?))
        {
            this.RequestedAmount = requestedAmount;
            this.RequestedCurrency = requestedCurrency;
            this.PayoutMethod = payoutMethod;
            this.Metadata = metadata;
            this.StateReasonDetails = stateReasonDetails;
            this.State = state;
            this.TransactionExternalId = transactionExternalId;
            this.TransactionState = transactionState;
            this.Type = type;
        }
        
        /// <summary>
        /// the amount that should be paid to the recipient. This can be in any currency, usually either the input or the output currency. If the value here is not the output currency we will calculate how much the recipient is going to get using the exchange rates active when the transaction was created.
        /// </summary>
        /// <value>the amount that should be paid to the recipient. This can be in any currency, usually either the input or the output currency. If the value here is not the output currency we will calculate how much the recipient is going to get using the exchange rates active when the transaction was created.</value>
        [DataMember(Name="requested_amount", EmitDefaultValue=false)]
        public decimal? RequestedAmount { get; set; }

        /// <summary>
        /// the currency of the amount in 3-character alpha ISO 4217 currency format
        /// </summary>
        /// <value>the currency of the amount in 3-character alpha ISO 4217 currency format</value>
        [DataMember(Name="requested_currency", EmitDefaultValue=false)]
        public string RequestedCurrency { get; set; }

        /// <summary>
        /// Gets or Sets PayoutMethod
        /// </summary>
        [DataMember(Name="payout_method", EmitDefaultValue=false)]
        public PayoutMethod PayoutMethod { get; set; }

        /// <summary>
        /// Additional metadata that can be added to a recipient. These values will be returned on request
        /// </summary>
        /// <value>Additional metadata that can be added to a recipient. These values will be returned on request</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Object Metadata { get; set; }

        /// <summary>
        /// Date and time that the recipient was created.
        /// </summary>
        /// <value>Date and time that the recipient was created.</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; private set; }

        /// <summary>
        /// Shows whether the recipient can be edited using the PATCH /v1/recipients/{id} endpoint or not
        /// </summary>
        /// <value>Shows whether the recipient can be edited using the PATCH /v1/recipients/{id} endpoint or not</value>
        [DataMember(Name="editable", EmitDefaultValue=false)]
        public bool? Editable { get; private set; }

        /// <summary>
        /// Shows whether the transaction made to the recipient can be retried or not
        /// </summary>
        /// <value>Shows whether the transaction made to the recipient can be retried or not</value>
        [DataMember(Name="retriable", EmitDefaultValue=false)]
        public bool? Retriable { get; private set; }

        /// <summary>
        /// Shows how much this payment is worth in USD
        /// </summary>
        /// <value>Shows how much this payment is worth in USD</value>
        [DataMember(Name="input_usd_amount", EmitDefaultValue=false)]
        public decimal? InputUsdAmount { get; private set; }

        /// <summary>
        /// If true it shows that the payment can be cancelled immediately using the DELETE /v1/recipients/{id} endpoint. If false you can still try to cancel it, however it will only gets cancelled once we have confirmation from our partner that the payment has failed.
        /// </summary>
        /// <value>If true it shows that the payment can be cancelled immediately using the DELETE /v1/recipients/{id} endpoint. If false you can still try to cancel it, however it will only gets cancelled once we have confirmation from our partner that the payment has failed.</value>
        [DataMember(Name="may_cancel", EmitDefaultValue=false)]
        public bool? MayCancel { get; private set; }

        /// <summary>
        /// In case the payment is unsuccessful it holds the error message associated with the last unsuccessful payout.
        /// </summary>
        /// <value>In case the payment is unsuccessful it holds the error message associated with the last unsuccessful payout.</value>
        [DataMember(Name="state_reason", EmitDefaultValue=false)]
        public string StateReason { get; private set; }

        /// <summary>
        /// Gets or Sets StateReasonDetails
        /// </summary>
        [DataMember(Name="state_reason_details", EmitDefaultValue=false)]
        public RecipientStateReasonDetails StateReasonDetails { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public RecipientState State { get; set; }

        /// <summary>
        /// The ID of the transaction that is related to this recipient
        /// </summary>
        /// <value>The ID of the transaction that is related to this recipient</value>
        [DataMember(Name="transaction_id", EmitDefaultValue=false)]
        public string TransactionId { get; private set; }

        /// <summary>
        /// Optional ID that is supplied by partner linking it to the partner&#39;s own Transaction ID.
        /// </summary>
        /// <value>Optional ID that is supplied by partner linking it to the partner&#39;s own Transaction ID.</value>
        [DataMember(Name="transaction_external_id", EmitDefaultValue=false)]
        public string TransactionExternalId { get; set; }

        /// <summary>
        /// Gets or Sets TransactionState
        /// </summary>
        [DataMember(Name="transaction_state", EmitDefaultValue=false)]
        public TransactionState TransactionState { get; set; }

        /// <summary>
        /// The exchange rate used in this payment
        /// </summary>
        /// <value>The exchange rate used in this payment</value>
        [DataMember(Name="exchange_rate", EmitDefaultValue=false)]
        public decimal? ExchangeRate { get; private set; }

        /// <summary>
        /// The fee for this payment in fractional units (for example cents for USD transactions)
        /// </summary>
        /// <value>The fee for this payment in fractional units (for example cents for USD transactions)</value>
        [DataMember(Name="fee_fractional", EmitDefaultValue=false)]
        public decimal? FeeFractional { get; private set; }

        /// <summary>
        /// The amount that had to be paid in for this payment to proceed
        /// </summary>
        /// <value>The amount that had to be paid in for this payment to proceed</value>
        [DataMember(Name="input_amount", EmitDefaultValue=false)]
        public decimal? InputAmount { get; private set; }

        /// <summary>
        /// The currency this payment was paid in
        /// </summary>
        /// <value>The currency this payment was paid in</value>
        [DataMember(Name="input_currency", EmitDefaultValue=false)]
        public string InputCurrency { get; private set; }

        /// <summary>
        /// The amount that will be paid to the recipient
        /// </summary>
        /// <value>The amount that will be paid to the recipient</value>
        [DataMember(Name="output_amount", EmitDefaultValue=false)]
        public decimal? OutputAmount { get; private set; }

        /// <summary>
        /// The currency the payment will be delivered in
        /// </summary>
        /// <value>The currency the payment will be delivered in</value>
        [DataMember(Name="output_currency", EmitDefaultValue=false)]
        public string OutputCurrency { get; private set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; private set; }


        /// <summary>
        /// The fields that have some problems and don&#39;t pass validation
        /// </summary>
        /// <value>The fields that have some problems and don&#39;t pass validation</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public Dictionary<string, List<ValidationErrorDescription>> Errors { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Recipient {\n");
            sb.Append("  RequestedAmount: ").Append(RequestedAmount).Append("\n");
            sb.Append("  RequestedCurrency: ").Append(RequestedCurrency).Append("\n");
            sb.Append("  PayoutMethod: ").Append(PayoutMethod).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Editable: ").Append(Editable).Append("\n");
            sb.Append("  Retriable: ").Append(Retriable).Append("\n");
            sb.Append("  InputUsdAmount: ").Append(InputUsdAmount).Append("\n");
            sb.Append("  MayCancel: ").Append(MayCancel).Append("\n");
            sb.Append("  StateReason: ").Append(StateReason).Append("\n");
            sb.Append("  StateReasonDetails: ").Append(StateReasonDetails).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  TransactionExternalId: ").Append(TransactionExternalId).Append("\n");
            sb.Append("  TransactionState: ").Append(TransactionState).Append("\n");
            sb.Append("  ExchangeRate: ").Append(ExchangeRate).Append("\n");
            sb.Append("  FeeFractional: ").Append(FeeFractional).Append("\n");
            sb.Append("  InputAmount: ").Append(InputAmount).Append("\n");
            sb.Append("  InputCurrency: ").Append(InputCurrency).Append("\n");
            sb.Append("  OutputAmount: ").Append(OutputAmount).Append("\n");
            sb.Append("  OutputCurrency: ").Append(OutputCurrency).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
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
            return this.Equals(input as Recipient);
        }

        /// <summary>
        /// Returns true if Recipient instances are equal
        /// </summary>
        /// <param name="input">Instance of Recipient to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Recipient input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RequestedAmount == input.RequestedAmount ||
                    (this.RequestedAmount != null &&
                    this.RequestedAmount.Equals(input.RequestedAmount))
                ) && 
                (
                    this.RequestedCurrency == input.RequestedCurrency ||
                    (this.RequestedCurrency != null &&
                    this.RequestedCurrency.Equals(input.RequestedCurrency))
                ) && 
                (
                    this.PayoutMethod == input.PayoutMethod ||
                    (this.PayoutMethod != null &&
                    this.PayoutMethod.Equals(input.PayoutMethod))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Editable == input.Editable ||
                    (this.Editable != null &&
                    this.Editable.Equals(input.Editable))
                ) && 
                (
                    this.Retriable == input.Retriable ||
                    (this.Retriable != null &&
                    this.Retriable.Equals(input.Retriable))
                ) && 
                (
                    this.InputUsdAmount == input.InputUsdAmount ||
                    (this.InputUsdAmount != null &&
                    this.InputUsdAmount.Equals(input.InputUsdAmount))
                ) && 
                (
                    this.MayCancel == input.MayCancel ||
                    (this.MayCancel != null &&
                    this.MayCancel.Equals(input.MayCancel))
                ) && 
                (
                    this.StateReason == input.StateReason ||
                    (this.StateReason != null &&
                    this.StateReason.Equals(input.StateReason))
                ) && 
                (
                    this.StateReasonDetails == input.StateReasonDetails ||
                    (this.StateReasonDetails != null &&
                    this.StateReasonDetails.Equals(input.StateReasonDetails))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) && 
                (
                    this.TransactionExternalId == input.TransactionExternalId ||
                    (this.TransactionExternalId != null &&
                    this.TransactionExternalId.Equals(input.TransactionExternalId))
                ) && 
                (
                    this.TransactionState == input.TransactionState ||
                    (this.TransactionState != null &&
                    this.TransactionState.Equals(input.TransactionState))
                ) && 
                (
                    this.ExchangeRate == input.ExchangeRate ||
                    (this.ExchangeRate != null &&
                    this.ExchangeRate.Equals(input.ExchangeRate))
                ) && 
                (
                    this.FeeFractional == input.FeeFractional ||
                    (this.FeeFractional != null &&
                    this.FeeFractional.Equals(input.FeeFractional))
                ) && 
                (
                    this.InputAmount == input.InputAmount ||
                    (this.InputAmount != null &&
                    this.InputAmount.Equals(input.InputAmount))
                ) && 
                (
                    this.InputCurrency == input.InputCurrency ||
                    (this.InputCurrency != null &&
                    this.InputCurrency.Equals(input.InputCurrency))
                ) && 
                (
                    this.OutputAmount == input.OutputAmount ||
                    (this.OutputAmount != null &&
                    this.OutputAmount.Equals(input.OutputAmount))
                ) && 
                (
                    this.OutputCurrency == input.OutputCurrency ||
                    (this.OutputCurrency != null &&
                    this.OutputCurrency.Equals(input.OutputCurrency))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Errors == input.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(input.Errors)
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
                if (this.RequestedAmount != null)
                    hashCode = hashCode * 59 + this.RequestedAmount.GetHashCode();
                if (this.RequestedCurrency != null)
                    hashCode = hashCode * 59 + this.RequestedCurrency.GetHashCode();
                if (this.PayoutMethod != null)
                    hashCode = hashCode * 59 + this.PayoutMethod.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Editable != null)
                    hashCode = hashCode * 59 + this.Editable.GetHashCode();
                if (this.Retriable != null)
                    hashCode = hashCode * 59 + this.Retriable.GetHashCode();
                if (this.InputUsdAmount != null)
                    hashCode = hashCode * 59 + this.InputUsdAmount.GetHashCode();
                if (this.MayCancel != null)
                    hashCode = hashCode * 59 + this.MayCancel.GetHashCode();
                if (this.StateReason != null)
                    hashCode = hashCode * 59 + this.StateReason.GetHashCode();
                if (this.StateReasonDetails != null)
                    hashCode = hashCode * 59 + this.StateReasonDetails.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.TransactionId != null)
                    hashCode = hashCode * 59 + this.TransactionId.GetHashCode();
                if (this.TransactionExternalId != null)
                    hashCode = hashCode * 59 + this.TransactionExternalId.GetHashCode();
                if (this.TransactionState != null)
                    hashCode = hashCode * 59 + this.TransactionState.GetHashCode();
                if (this.ExchangeRate != null)
                    hashCode = hashCode * 59 + this.ExchangeRate.GetHashCode();
                if (this.FeeFractional != null)
                    hashCode = hashCode * 59 + this.FeeFractional.GetHashCode();
                if (this.InputAmount != null)
                    hashCode = hashCode * 59 + this.InputAmount.GetHashCode();
                if (this.InputCurrency != null)
                    hashCode = hashCode * 59 + this.InputCurrency.GetHashCode();
                if (this.OutputAmount != null)
                    hashCode = hashCode * 59 + this.OutputAmount.GetHashCode();
                if (this.OutputCurrency != null)
                    hashCode = hashCode * 59 + this.OutputCurrency.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Errors != null)
                    hashCode = hashCode * 59 + this.Errors.GetHashCode();
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
