/* 
 * BitPesa Private API
 *
 * API specification used for internal BitPesa endpoints
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
    /// This contains the details of the entity. The first time a specific entity is used the full details should be provided.  Entity Example: &#x60;&#x60;&#x60;json {   \&quot;id\&quot;: 39,   \&quot;total_score\&quot;: 35,   \&quot;rating\&quot;: \&quot;Extremely High\&quot;   \&quot;state\&quot;: \&quot;incomplete\&quot;,   \&quot;entity_id\&quot;: \&quot;86912555-272a-48f7-bdbb-eab653150e01\&quot;,   \&quot;entity_type\&quot;: \&quot;Sender\&quot;,   \&quot;remarks\&quot;: \&quot;ready to be reviewed\&quot;,   \&quot;created_at\&quot;: \&quot;2020-05-05T10:55:44.051Z\&quot;,   \&quot;updated_at\&quot;: \&quot;2020-05-05T10:55:44.051Z\&quot; } &#x60;&#x60;&#x60;
    /// </summary>
    [DataContract]
    public partial class Entity :  IEquatable<Entity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Entity" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="totalScore">Total score of risk assessment.</param>
        /// <param name="rating">rating.</param>
        /// <param name="state">state.</param>
        /// <param name="entityId">Id of linked entity.</param>
        /// <param name="entityType">Type of entity to create eg. Sender, Company .</param>
        /// <param name="remarks">Notes about entity.</param>
        public Entity(int? id = default(int?), int? totalScore = default(int?), EntityRating rating = default(EntityRating), EntityState state = default(EntityState), Guid? entityId = default(Guid?), string entityType = default(string), string remarks = default(string))
        {
            this.Id = id;
            this.TotalScore = totalScore;
            this.Rating = rating;
            this.State = state;
            this.EntityId = entityId;
            this.EntityType = entityType;
            this.Remarks = remarks;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Total score of risk assessment
        /// </summary>
        /// <value>Total score of risk assessment</value>
        [DataMember(Name="total_score", EmitDefaultValue=false)]
        public int? TotalScore { get; set; }

        /// <summary>
        /// Gets or Sets Rating
        /// </summary>
        [DataMember(Name="rating", EmitDefaultValue=false)]
        public EntityRating Rating { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public EntityState State { get; set; }

        /// <summary>
        /// Id of linked entity
        /// </summary>
        /// <value>Id of linked entity</value>
        [DataMember(Name="entity_id", EmitDefaultValue=false)]
        public Guid? EntityId { get; set; }

        /// <summary>
        /// Type of entity to create eg. Sender, Company 
        /// </summary>
        /// <value>Type of entity to create eg. Sender, Company </value>
        [DataMember(Name="entity_type", EmitDefaultValue=false)]
        public string EntityType { get; set; }

        /// <summary>
        /// Notes about entity
        /// </summary>
        /// <value>Notes about entity</value>
        [DataMember(Name="remarks", EmitDefaultValue=false)]
        public string Remarks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Entity {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TotalScore: ").Append(TotalScore).Append("\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  EntityType: ").Append(EntityType).Append("\n");
            sb.Append("  Remarks: ").Append(Remarks).Append("\n");
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
            return this.Equals(input as Entity);
        }

        /// <summary>
        /// Returns true if Entity instances are equal
        /// </summary>
        /// <param name="input">Instance of Entity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Entity input)
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
                    this.TotalScore == input.TotalScore ||
                    (this.TotalScore != null &&
                    this.TotalScore.Equals(input.TotalScore))
                ) && 
                (
                    this.Rating == input.Rating ||
                    (this.Rating != null &&
                    this.Rating.Equals(input.Rating))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.EntityId == input.EntityId ||
                    (this.EntityId != null &&
                    this.EntityId.Equals(input.EntityId))
                ) && 
                (
                    this.EntityType == input.EntityType ||
                    (this.EntityType != null &&
                    this.EntityType.Equals(input.EntityType))
                ) && 
                (
                    this.Remarks == input.Remarks ||
                    (this.Remarks != null &&
                    this.Remarks.Equals(input.Remarks))
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
                if (this.TotalScore != null)
                    hashCode = hashCode * 59 + this.TotalScore.GetHashCode();
                if (this.Rating != null)
                    hashCode = hashCode * 59 + this.Rating.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.EntityId != null)
                    hashCode = hashCode * 59 + this.EntityId.GetHashCode();
                if (this.EntityType != null)
                    hashCode = hashCode * 59 + this.EntityType.GetHashCode();
                if (this.Remarks != null)
                    hashCode = hashCode * 59 + this.Remarks.GetHashCode();
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
