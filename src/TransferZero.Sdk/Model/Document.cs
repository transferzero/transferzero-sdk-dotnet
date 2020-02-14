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
    /// Document
    /// </summary>
    [DataContract]
    public partial class Document :  IEquatable<Document>, IValidatableObject
    {
        /// <summary>
        /// The side of the KYC ID. One of &#39;front&#39; or &#39;back&#39;
        /// </summary>
        /// <value>The side of the KYC ID. One of &#39;front&#39; or &#39;back&#39;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SideEnum
        {
            /// <summary>
            /// Enum Front for value: front
            /// </summary>
            [EnumMember(Value = "front")]
            Front = 1,

            /// <summary>
            /// Enum Back for value: back
            /// </summary>
            [EnumMember(Value = "back")]
            Back = 2

        }

        /// <summary>
        /// The side of the KYC ID. One of &#39;front&#39; or &#39;back&#39;
        /// </summary>
        /// <value>The side of the KYC ID. One of &#39;front&#39; or &#39;back&#39;</value>
        [DataMember(Name="side", EmitDefaultValue=false)]
        public SideEnum? Side { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Document" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Document() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Document" /> class.
        /// </summary>
        /// <param name="senderId">senderId.</param>
        /// <param name="upload">Base64 encoded data uri of an image/pdf file or a fully qualified url (required).</param>
        /// <param name="uploadFileName">Name of the upload (required).</param>
        /// <param name="metadata">Metadata of document.</param>
        public Document(Guid? senderId = default(Guid?), string upload = default(string), string uploadFileName = default(string), Object metadata = default(Object))
        {
            this.Upload = upload;
            this.UploadFileName = uploadFileName;
            this.SenderId = senderId;
            this.Metadata = metadata;
        }
        
        /// <summary>
        /// Gets or Sets SenderId
        /// </summary>
        [DataMember(Name="sender_id", EmitDefaultValue=false)]
        public Guid? SenderId { get; set; }

        /// <summary>
        /// Base64 encoded data uri of an image/pdf file or a fully qualified url
        /// </summary>
        /// <value>Base64 encoded data uri of an image/pdf file or a fully qualified url</value>
        [DataMember(Name="upload", EmitDefaultValue=false)]
        public string Upload { get; set; }

        /// <summary>
        /// Name of the upload
        /// </summary>
        /// <value>Name of the upload</value>
        [DataMember(Name="upload_file_name", EmitDefaultValue=false)]
        public string UploadFileName { get; set; }

        /// <summary>
        /// Metadata of document
        /// </summary>
        /// <value>Metadata of document</value>
        [DataMember(Name="metadata", EmitDefaultValue=false)]
        public Object Metadata { get; set; }

        /// <summary>
        /// Gets or Sets UploadContentType
        /// </summary>
        [DataMember(Name="upload_content_type", EmitDefaultValue=false)]
        public string UploadContentType { get; private set; }

        /// <summary>
        /// Gets or Sets UploadFileSize
        /// </summary>
        [DataMember(Name="upload_file_size", EmitDefaultValue=false)]
        public int? UploadFileSize { get; private set; }

        /// <summary>
        /// uncategorised
        /// </summary>
        /// <value>uncategorised</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public string Category { get; private set; }


        /// <summary>
        /// This is a brief description of the document type
        /// </summary>
        /// <value>This is a brief description of the document type</value>
        [DataMember(Name="document_type", EmitDefaultValue=false)]
        public string DocumentType { get; private set; }

        /// <summary>
        /// Issuing country of ID in 2-character alpha ISO 3166-2 country format
        /// </summary>
        /// <value>Issuing country of ID in 2-character alpha ISO 3166-2 country format</value>
        [DataMember(Name="issuing_country", EmitDefaultValue=false)]
        public string IssuingCountry { get; private set; }

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
            sb.Append("class Document {\n");
            sb.Append("  SenderId: ").Append(SenderId).Append("\n");
            sb.Append("  Upload: ").Append(Upload).Append("\n");
            sb.Append("  UploadFileName: ").Append(UploadFileName).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  UploadContentType: ").Append(UploadContentType).Append("\n");
            sb.Append("  UploadFileSize: ").Append(UploadFileSize).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Side: ").Append(Side).Append("\n");
            sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
            sb.Append("  IssuingCountry: ").Append(IssuingCountry).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as Document);
        }

        /// <summary>
        /// Returns true if Document instances are equal
        /// </summary>
        /// <param name="input">Instance of Document to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Document input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SenderId == input.SenderId ||
                    (this.SenderId != null &&
                    this.SenderId.Equals(input.SenderId))
                ) && 
                (
                    this.Upload == input.Upload ||
                    (this.Upload != null &&
                    this.Upload.Equals(input.Upload))
                ) && 
                (
                    this.UploadFileName == input.UploadFileName ||
                    (this.UploadFileName != null &&
                    this.UploadFileName.Equals(input.UploadFileName))
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    (this.Metadata != null &&
                    this.Metadata.Equals(input.Metadata))
                ) && 
                (
                    this.UploadContentType == input.UploadContentType ||
                    (this.UploadContentType != null &&
                    this.UploadContentType.Equals(input.UploadContentType))
                ) && 
                (
                    this.UploadFileSize == input.UploadFileSize ||
                    (this.UploadFileSize != null &&
                    this.UploadFileSize.Equals(input.UploadFileSize))
                ) && 
                (
                    this.Category == input.Category ||
                    (this.Category != null &&
                    this.Category.Equals(input.Category))
                ) && 
                (
                    this.Side == input.Side ||
                    (this.Side != null &&
                    this.Side.Equals(input.Side))
                ) && 
                (
                    this.DocumentType == input.DocumentType ||
                    (this.DocumentType != null &&
                    this.DocumentType.Equals(input.DocumentType))
                ) && 
                (
                    this.IssuingCountry == input.IssuingCountry ||
                    (this.IssuingCountry != null &&
                    this.IssuingCountry.Equals(input.IssuingCountry))
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
                if (this.SenderId != null)
                    hashCode = hashCode * 59 + this.SenderId.GetHashCode();
                if (this.Upload != null)
                    hashCode = hashCode * 59 + this.Upload.GetHashCode();
                if (this.UploadFileName != null)
                    hashCode = hashCode * 59 + this.UploadFileName.GetHashCode();
                if (this.Metadata != null)
                    hashCode = hashCode * 59 + this.Metadata.GetHashCode();
                if (this.UploadContentType != null)
                    hashCode = hashCode * 59 + this.UploadContentType.GetHashCode();
                if (this.UploadFileSize != null)
                    hashCode = hashCode * 59 + this.UploadFileSize.GetHashCode();
                if (this.Category != null)
                    hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.Side != null)
                    hashCode = hashCode * 59 + this.Side.GetHashCode();
                if (this.DocumentType != null)
                    hashCode = hashCode * 59 + this.DocumentType.GetHashCode();
                if (this.IssuingCountry != null)
                    hashCode = hashCode * 59 + this.IssuingCountry.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
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
