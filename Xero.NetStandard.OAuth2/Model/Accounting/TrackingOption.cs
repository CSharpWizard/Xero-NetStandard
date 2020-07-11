/* 
 * Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.2.2
 * Contact: api@xero.com
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
using OpenAPIDateConverter = Xero.NetStandard.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.NetStandard.OAuth2.Model.Accounting
{
    /// <summary>
    /// TrackingOption
    /// </summary>
    [DataContract]
    public partial class TrackingOption :  IEquatable<TrackingOption>, IValidatableObject
    {
        /// <summary>
        /// The status of a tracking option
        /// </summary>
        /// <value>The status of a tracking option</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            [EnumMember(Value = "ACTIVE")]
            ACTIVE = 1,

            /// <summary>
            /// Enum ARCHIVED for value: ARCHIVED
            /// </summary>
            [EnumMember(Value = "ARCHIVED")]
            ARCHIVED = 2,

            /// <summary>
            /// Enum DELETED for value: DELETED
            /// </summary>
            [EnumMember(Value = "DELETED")]
            DELETED = 3

        }

        /// <summary>
        /// The status of a tracking option
        /// </summary>
        /// <value>The status of a tracking option</value>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        
        /// <summary>
        /// The Xero identifier for a tracking optione.g. ae777a87-5ef3-4fa0-a4f0-d10e1f13073a
        /// </summary>
        /// <value>The Xero identifier for a tracking optione.g. ae777a87-5ef3-4fa0-a4f0-d10e1f13073a</value>
        [DataMember(Name="TrackingOptionID", EmitDefaultValue=false)]
        public Guid? TrackingOptionID { get; set; }

        /// <summary>
        /// The name of the tracking option e.g. Marketing, East (max length &#x3D; 50)
        /// </summary>
        /// <value>The name of the tracking option e.g. Marketing, East (max length &#x3D; 50)</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Filter by a tracking categorye.g. 297c2dc5-cc47-4afd-8ec8-74990b8761e9
        /// </summary>
        /// <value>Filter by a tracking categorye.g. 297c2dc5-cc47-4afd-8ec8-74990b8761e9</value>
        [DataMember(Name="TrackingCategoryID", EmitDefaultValue=false)]
        public Guid? TrackingCategoryID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TrackingOption {\n");
            sb.Append("  TrackingOptionID: ").Append(TrackingOptionID).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TrackingCategoryID: ").Append(TrackingCategoryID).Append("\n");
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
            return this.Equals(input as TrackingOption);
        }

        /// <summary>
        /// Returns true if TrackingOption instances are equal
        /// </summary>
        /// <param name="input">Instance of TrackingOption to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TrackingOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TrackingOptionID == input.TrackingOptionID ||
                    (this.TrackingOptionID != null &&
                    this.TrackingOptionID.Equals(input.TrackingOptionID))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.TrackingCategoryID == input.TrackingCategoryID ||
                    (this.TrackingCategoryID != null &&
                    this.TrackingCategoryID.Equals(input.TrackingCategoryID))
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
                if (this.TrackingOptionID != null)
                    hashCode = hashCode * 59 + this.TrackingOptionID.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TrackingCategoryID != null)
                    hashCode = hashCode * 59 + this.TrackingCategoryID.GetHashCode();
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
            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 50.", new [] { "Name" });
            }

            yield break;
        }
    }

}
