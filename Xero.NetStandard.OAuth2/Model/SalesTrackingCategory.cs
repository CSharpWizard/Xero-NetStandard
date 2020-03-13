/* 
 * Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.0.4
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
    /// SalesTrackingCategory
    /// </summary>
    [DataContract]
    public partial class SalesTrackingCategory :  IEquatable<SalesTrackingCategory>, IValidatableObject
    {
        
        /// <summary>
        /// The default sales tracking category name for contacts
        /// </summary>
        /// <value>The default sales tracking category name for contacts</value>
        [DataMember(Name="TrackingCategoryName", EmitDefaultValue=false)]
        public string TrackingCategoryName { get; set; }

        /// <summary>
        /// The default purchase tracking category name for contacts
        /// </summary>
        /// <value>The default purchase tracking category name for contacts</value>
        [DataMember(Name="TrackingOptionName", EmitDefaultValue=false)]
        public string TrackingOptionName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SalesTrackingCategory {\n");
            sb.Append("  TrackingCategoryName: ").Append(TrackingCategoryName).Append("\n");
            sb.Append("  TrackingOptionName: ").Append(TrackingOptionName).Append("\n");
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
            return this.Equals(input as SalesTrackingCategory);
        }

        /// <summary>
        /// Returns true if SalesTrackingCategory instances are equal
        /// </summary>
        /// <param name="input">Instance of SalesTrackingCategory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SalesTrackingCategory input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TrackingCategoryName == input.TrackingCategoryName ||
                    (this.TrackingCategoryName != null &&
                    this.TrackingCategoryName.Equals(input.TrackingCategoryName))
                ) && 
                (
                    this.TrackingOptionName == input.TrackingOptionName ||
                    (this.TrackingOptionName != null &&
                    this.TrackingOptionName.Equals(input.TrackingOptionName))
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
                if (this.TrackingCategoryName != null)
                    hashCode = hashCode * 59 + this.TrackingCategoryName.GetHashCode();
                if (this.TrackingOptionName != null)
                    hashCode = hashCode * 59 + this.TrackingOptionName.GetHashCode();
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
