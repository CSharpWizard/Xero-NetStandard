/* 
 * Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.0.6
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

namespace Xero.NetStandard.OAuth2.Model
{
    /// <summary>
    /// LineItemTracking
    /// </summary>
    [DataContract]
    public partial class LineItemTracking :  IEquatable<LineItemTracking>, IValidatableObject
    {
        
        /// <summary>
        /// The Xero identifier for a tracking category
        /// </summary>
        /// <value>The Xero identifier for a tracking category</value>
        [DataMember(Name="TrackingCategoryID", EmitDefaultValue=false)]
        public Guid? TrackingCategoryID { get; set; }

        /// <summary>
        /// The Xero identifier for a tracking category option
        /// </summary>
        /// <value>The Xero identifier for a tracking category option</value>
        [DataMember(Name="TrackingOptionID", EmitDefaultValue=false)]
        public Guid? TrackingOptionID { get; set; }

        /// <summary>
        /// The name of the tracking category
        /// </summary>
        /// <value>The name of the tracking category</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// See Tracking Options
        /// </summary>
        /// <value>See Tracking Options</value>
        [DataMember(Name="Option", EmitDefaultValue=false)]
        public string Option { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LineItemTracking {\n");
            sb.Append("  TrackingCategoryID: ").Append(TrackingCategoryID).Append("\n");
            sb.Append("  TrackingOptionID: ").Append(TrackingOptionID).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Option: ").Append(Option).Append("\n");
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
            return this.Equals(input as LineItemTracking);
        }

        /// <summary>
        /// Returns true if LineItemTracking instances are equal
        /// </summary>
        /// <param name="input">Instance of LineItemTracking to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LineItemTracking input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TrackingCategoryID == input.TrackingCategoryID ||
                    (this.TrackingCategoryID != null &&
                    this.TrackingCategoryID.Equals(input.TrackingCategoryID))
                ) && 
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
                    this.Option == input.Option ||
                    (this.Option != null &&
                    this.Option.Equals(input.Option))
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
                if (this.TrackingCategoryID != null)
                    hashCode = hashCode * 59 + this.TrackingCategoryID.GetHashCode();
                if (this.TrackingOptionID != null)
                    hashCode = hashCode * 59 + this.TrackingOptionID.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Option != null)
                    hashCode = hashCode * 59 + this.Option.GetHashCode();
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
            if(this.Name != null && this.Name.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 100.", new [] { "Name" });
            }

            yield break;
        }
    }

}
