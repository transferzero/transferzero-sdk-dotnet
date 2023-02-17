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
    /// The response object returned with requests to access individual API logs 
    /// </summary>
    [DataContract]
    public partial class ApiLog :  IEquatable<ApiLog>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiLog" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public ApiLog()
        {
        }
        
        /// <summary>
        /// ID of the API log
        /// </summary>
        /// <value>ID of the API log</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; private set; }

        /// <summary>
        /// Initial HTTP request method
        /// </summary>
        /// <value>Initial HTTP request method</value>
        [DataMember(Name="request_method", EmitDefaultValue=false)]
        public string RequestMethod { get; private set; }

        /// <summary>
        /// URL to which initial request was sent
        /// </summary>
        /// <value>URL to which initial request was sent</value>
        [DataMember(Name="request_url", EmitDefaultValue=false)]
        public string RequestUrl { get; private set; }

        /// <summary>
        /// Body sent with initial request returned as a string
        /// </summary>
        /// <value>Body sent with initial request returned as a string</value>
        [DataMember(Name="request_body", EmitDefaultValue=false)]
        public string RequestBody { get; private set; }

        /// <summary>
        /// Authorization and access information sent with initial request
        /// </summary>
        /// <value>Authorization and access information sent with initial request</value>
        [DataMember(Name="request_headers", EmitDefaultValue=false)]
        public Dictionary<string, string> RequestHeaders { get; private set; }

        /// <summary>
        /// Status of response
        /// </summary>
        /// <value>Status of response</value>
        [DataMember(Name="response_status", EmitDefaultValue=false)]
        public string ResponseStatus { get; private set; }

        /// <summary>
        /// Full response body returned as a string
        /// </summary>
        /// <value>Full response body returned as a string</value>
        [DataMember(Name="response_body", EmitDefaultValue=false)]
        public string ResponseBody { get; private set; }

        /// <summary>
        /// Headers returned with response
        /// </summary>
        /// <value>Headers returned with response</value>
        [DataMember(Name="response_headers", EmitDefaultValue=false)]
        public Dictionary<string, string> ResponseHeaders { get; private set; }

        /// <summary>
        /// Date and time of response
        /// </summary>
        /// <value>Date and time of response</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public string CreatedAt { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiLog {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RequestMethod: ").Append(RequestMethod).Append("\n");
            sb.Append("  RequestUrl: ").Append(RequestUrl).Append("\n");
            sb.Append("  RequestBody: ").Append(RequestBody).Append("\n");
            sb.Append("  RequestHeaders: ").Append(RequestHeaders).Append("\n");
            sb.Append("  ResponseStatus: ").Append(ResponseStatus).Append("\n");
            sb.Append("  ResponseBody: ").Append(ResponseBody).Append("\n");
            sb.Append("  ResponseHeaders: ").Append(ResponseHeaders).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
            return this.Equals(input as ApiLog);
        }

        /// <summary>
        /// Returns true if ApiLog instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiLog to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiLog input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.RequestMethod == input.RequestMethod ||
                    (this.RequestMethod != null &&
                    this.RequestMethod.Equals(input.RequestMethod))
                ) && 
                (
                    this.RequestUrl == input.RequestUrl ||
                    (this.RequestUrl != null &&
                    this.RequestUrl.Equals(input.RequestUrl))
                ) && 
                (
                    this.RequestBody == input.RequestBody ||
                    (this.RequestBody != null &&
                    this.RequestBody.Equals(input.RequestBody))
                ) && 
                (
                    this.RequestHeaders == input.RequestHeaders ||
                    this.RequestHeaders != null &&
                    this.RequestHeaders.SequenceEqual(input.RequestHeaders)
                ) && 
                (
                    this.ResponseStatus == input.ResponseStatus ||
                    (this.ResponseStatus != null &&
                    this.ResponseStatus.Equals(input.ResponseStatus))
                ) && 
                (
                    this.ResponseBody == input.ResponseBody ||
                    (this.ResponseBody != null &&
                    this.ResponseBody.Equals(input.ResponseBody))
                ) && 
                (
                    this.ResponseHeaders == input.ResponseHeaders ||
                    this.ResponseHeaders != null &&
                    this.ResponseHeaders.SequenceEqual(input.ResponseHeaders)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.RequestMethod != null)
                    hashCode = hashCode * 59 + this.RequestMethod.GetHashCode();
                if (this.RequestUrl != null)
                    hashCode = hashCode * 59 + this.RequestUrl.GetHashCode();
                if (this.RequestBody != null)
                    hashCode = hashCode * 59 + this.RequestBody.GetHashCode();
                if (this.RequestHeaders != null)
                    hashCode = hashCode * 59 + this.RequestHeaders.GetHashCode();
                if (this.ResponseStatus != null)
                    hashCode = hashCode * 59 + this.ResponseStatus.GetHashCode();
                if (this.ResponseBody != null)
                    hashCode = hashCode * 59 + this.ResponseBody.GetHashCode();
                if (this.ResponseHeaders != null)
                    hashCode = hashCode * 59 + this.ResponseHeaders.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
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
