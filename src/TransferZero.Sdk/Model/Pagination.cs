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
    /// Pagination
    /// </summary>
    [DataContract]
    public partial class Pagination :  IEquatable<Pagination>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pagination" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Pagination()
        {
        }
        
        /// <summary>
        /// The number of the current page
        /// </summary>
        /// <value>The number of the current page</value>
        [DataMember(Name="current_page", EmitDefaultValue=false)]
        public int? CurrentPage { get; private set; }

        /// <summary>
        /// The number of the next page. If no next page exists, this will be &#x60;null&#x60;
        /// </summary>
        /// <value>The number of the next page. If no next page exists, this will be &#x60;null&#x60;</value>
        [DataMember(Name="next_page", EmitDefaultValue=false)]
        public int? NextPage { get; private set; }

        /// <summary>
        /// The number of the previous page. If no previous page exists, this will be &#x60;null&#x60;
        /// </summary>
        /// <value>The number of the previous page. If no previous page exists, this will be &#x60;null&#x60;</value>
        [DataMember(Name="prev_page", EmitDefaultValue=false)]
        public int? PrevPage { get; private set; }

        /// <summary>
        /// The number of pages in the result set
        /// </summary>
        /// <value>The number of pages in the result set</value>
        [DataMember(Name="total_pages", EmitDefaultValue=false)]
        public int? TotalPages { get; private set; }

        /// <summary>
        /// The total number of results in the set
        /// </summary>
        /// <value>The total number of results in the set</value>
        [DataMember(Name="total_count", EmitDefaultValue=false)]
        public int? TotalCount { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Pagination {\n");
            sb.Append("  CurrentPage: ").Append(CurrentPage).Append("\n");
            sb.Append("  NextPage: ").Append(NextPage).Append("\n");
            sb.Append("  PrevPage: ").Append(PrevPage).Append("\n");
            sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
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
            return this.Equals(input as Pagination);
        }

        /// <summary>
        /// Returns true if Pagination instances are equal
        /// </summary>
        /// <param name="input">Instance of Pagination to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Pagination input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CurrentPage == input.CurrentPage ||
                    (this.CurrentPage != null &&
                    this.CurrentPage.Equals(input.CurrentPage))
                ) && 
                (
                    this.NextPage == input.NextPage ||
                    (this.NextPage != null &&
                    this.NextPage.Equals(input.NextPage))
                ) && 
                (
                    this.PrevPage == input.PrevPage ||
                    (this.PrevPage != null &&
                    this.PrevPage.Equals(input.PrevPage))
                ) && 
                (
                    this.TotalPages == input.TotalPages ||
                    (this.TotalPages != null &&
                    this.TotalPages.Equals(input.TotalPages))
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
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
                if (this.CurrentPage != null)
                    hashCode = hashCode * 59 + this.CurrentPage.GetHashCode();
                if (this.NextPage != null)
                    hashCode = hashCode * 59 + this.NextPage.GetHashCode();
                if (this.PrevPage != null)
                    hashCode = hashCode * 59 + this.PrevPage.GetHashCode();
                if (this.TotalPages != null)
                    hashCode = hashCode * 59 + this.TotalPages.GetHashCode();
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
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
