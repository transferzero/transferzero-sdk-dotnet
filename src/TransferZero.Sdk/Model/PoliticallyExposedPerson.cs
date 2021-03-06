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
    /// PoliticallyExposedPerson
    /// </summary>
    [DataContract]
    public partial class PoliticallyExposedPerson :  IEquatable<PoliticallyExposedPerson>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PoliticallyExposedPerson" /> class.
        /// </summary>
        /// <param name="name">Full name of the politically exposed person .</param>
        /// <param name="position">The office held by the politically exposed person .</param>
        /// <param name="startedDate">The date on which the person started holding the office .</param>
        /// <param name="endedDate">The date on which the person ended holding the office .</param>
        /// <param name="senderId">The ID of the Sender to whom the person is attached to .</param>
        public PoliticallyExposedPerson(string name = default(string), string position = default(string), DateTime? startedDate = default(DateTime?), DateTime? endedDate = default(DateTime?), Guid? senderId = default(Guid?))
        {
            this.Name = name;
            this.Position = position;
            this.StartedDate = startedDate;
            this.EndedDate = endedDate;
            this.SenderId = senderId;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; private set; }

        /// <summary>
        /// Full name of the politically exposed person 
        /// </summary>
        /// <value>Full name of the politically exposed person </value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The office held by the politically exposed person 
        /// </summary>
        /// <value>The office held by the politically exposed person </value>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public string Position { get; set; }

        /// <summary>
        /// The date on which the person started holding the office 
        /// </summary>
        /// <value>The date on which the person started holding the office </value>
        [DataMember(Name="started_date", EmitDefaultValue=false)]
        public DateTime? StartedDate { get; set; }

        /// <summary>
        /// The date on which the person ended holding the office 
        /// </summary>
        /// <value>The date on which the person ended holding the office </value>
        [DataMember(Name="ended_date", EmitDefaultValue=false)]
        public DateTime? EndedDate { get; set; }

        /// <summary>
        /// The ID of the Sender to whom the person is attached to 
        /// </summary>
        /// <value>The ID of the Sender to whom the person is attached to </value>
        [DataMember(Name="sender_id", EmitDefaultValue=false)]
        public Guid? SenderId { get; set; }

        /// <summary>
        /// Date and time the person was created
        /// </summary>
        /// <value>Date and time the person was created</value>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; private set; }

        /// <summary>
        /// Date and time the person was updated
        /// </summary>
        /// <value>Date and time the person was updated</value>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoliticallyExposedPerson {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  StartedDate: ").Append(StartedDate).Append("\n");
            sb.Append("  EndedDate: ").Append(EndedDate).Append("\n");
            sb.Append("  SenderId: ").Append(SenderId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as PoliticallyExposedPerson);
        }

        /// <summary>
        /// Returns true if PoliticallyExposedPerson instances are equal
        /// </summary>
        /// <param name="input">Instance of PoliticallyExposedPerson to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PoliticallyExposedPerson input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
                ) && 
                (
                    this.StartedDate == input.StartedDate ||
                    (this.StartedDate != null &&
                    this.StartedDate.Equals(input.StartedDate))
                ) && 
                (
                    this.EndedDate == input.EndedDate ||
                    (this.EndedDate != null &&
                    this.EndedDate.Equals(input.EndedDate))
                ) && 
                (
                    this.SenderId == input.SenderId ||
                    (this.SenderId != null &&
                    this.SenderId.Equals(input.SenderId))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.StartedDate != null)
                    hashCode = hashCode * 59 + this.StartedDate.GetHashCode();
                if (this.EndedDate != null)
                    hashCode = hashCode * 59 + this.EndedDate.GetHashCode();
                if (this.SenderId != null)
                    hashCode = hashCode * 59 + this.SenderId.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
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
