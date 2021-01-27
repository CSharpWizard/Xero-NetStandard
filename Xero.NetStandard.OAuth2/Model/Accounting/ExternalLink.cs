/* 
 * Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.8.3
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
    /// ExternalLink
    /// </summary>
    [DataContract]
    public partial class ExternalLink :  IEquatable<ExternalLink>, IValidatableObject
    {
        /// <summary>
        /// See External link types
        /// </summary>
        /// <value>See External link types</value>
        [JsonConverter(typeof(Client.CustomStringEnumConverter))]
        public enum LinkTypeEnum
        {
            /// <summary>
            /// Enum Facebook for value: Facebook
            /// </summary>
            [EnumMember(Value = "Facebook")]
            Facebook = 1,

            /// <summary>
            /// Enum GooglePlus for value: GooglePlus
            /// </summary>
            [EnumMember(Value = "GooglePlus")]
            GooglePlus = 2,

            /// <summary>
            /// Enum LinkedIn for value: LinkedIn
            /// </summary>
            [EnumMember(Value = "LinkedIn")]
            LinkedIn = 3,

            /// <summary>
            /// Enum Twitter for value: Twitter
            /// </summary>
            [EnumMember(Value = "Twitter")]
            Twitter = 4,

            /// <summary>
            /// Enum Website for value: Website
            /// </summary>
            [EnumMember(Value = "Website")]
            Website = 5

        }

        /// <summary>
        /// See External link types
        /// </summary>
        /// <value>See External link types</value>
        [DataMember(Name="LinkType", EmitDefaultValue=false)]
        public LinkTypeEnum LinkType { get; set; }
        
        /// <summary>
        /// URL for service e.g. http://twitter.com/xeroapi
        /// </summary>
        /// <value>URL for service e.g. http://twitter.com/xeroapi</value>
        [DataMember(Name="Url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalLink {\n");
            sb.Append("  LinkType: ").Append(LinkType).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as ExternalLink);
        }

        /// <summary>
        /// Returns true if ExternalLink instances are equal
        /// </summary>
        /// <param name="input">Instance of ExternalLink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExternalLink input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LinkType == input.LinkType ||
                    this.LinkType.Equals(input.LinkType)
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                hashCode = hashCode * 59 + this.LinkType.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
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
