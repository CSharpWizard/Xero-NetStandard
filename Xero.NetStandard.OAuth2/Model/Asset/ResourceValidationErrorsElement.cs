/* 
 * Xero Assets API
 *
 * This is the Xero Assets API
 *
 * The version of the OpenAPI document: 2.3.3
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

namespace Xero.NetStandard.OAuth2.Model.Asset
{
    /// <summary>
    /// ResourceValidationErrorsElement
    /// </summary>
    [DataContract]
    public partial class ResourceValidationErrorsElement :  IEquatable<ResourceValidationErrorsElement>, IValidatableObject
    {
        
        /// <summary>
        /// The field name of the erroneous field
        /// </summary>
        /// <value>The field name of the erroneous field</value>
        [DataMember(Name="resourceName", EmitDefaultValue=false)]
        public string ResourceName { get; set; }

        /// <summary>
        /// Explaination of the resource validation error
        /// </summary>
        /// <value>Explaination of the resource validation error</value>
        [DataMember(Name="localisedMessage", EmitDefaultValue=false)]
        public string LocalisedMessage { get; set; }

        /// <summary>
        /// Internal type of the resource error message
        /// </summary>
        /// <value>Internal type of the resource error message</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Title of the resource validation error
        /// </summary>
        /// <value>Title of the resource validation error</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Detail of the resource validation error
        /// </summary>
        /// <value>Detail of the resource validation error</value>
        [DataMember(Name="detail", EmitDefaultValue=false)]
        public string Detail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResourceValidationErrorsElement {\n");
            sb.Append("  ResourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  LocalisedMessage: ").Append(LocalisedMessage).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
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
            return this.Equals(input as ResourceValidationErrorsElement);
        }

        /// <summary>
        /// Returns true if ResourceValidationErrorsElement instances are equal
        /// </summary>
        /// <param name="input">Instance of ResourceValidationErrorsElement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResourceValidationErrorsElement input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ResourceName == input.ResourceName ||
                    (this.ResourceName != null &&
                    this.ResourceName.Equals(input.ResourceName))
                ) && 
                (
                    this.LocalisedMessage == input.LocalisedMessage ||
                    (this.LocalisedMessage != null &&
                    this.LocalisedMessage.Equals(input.LocalisedMessage))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Detail == input.Detail ||
                    (this.Detail != null &&
                    this.Detail.Equals(input.Detail))
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
                if (this.ResourceName != null)
                    hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.LocalisedMessage != null)
                    hashCode = hashCode * 59 + this.LocalisedMessage.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Detail != null)
                    hashCode = hashCode * 59 + this.Detail.GetHashCode();
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
