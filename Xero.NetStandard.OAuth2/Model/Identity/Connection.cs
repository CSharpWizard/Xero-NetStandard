/* 
 * Xero oAuth 2 identity service
 *
 * This specifing endpoints related to managing authentication tokens and identity for Xero API
 *
 * The version of the OpenAPI document: 2.3.0
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

namespace Xero.NetStandard.OAuth2.Model.Identity
{
    /// <summary>
    /// Connection
    /// </summary>
    [DataContract]
    public partial class Connection :  IEquatable<Connection>, IValidatableObject
    {
        
        /// <summary>
        /// Xero identifier
        /// </summary>
        /// <value>Xero identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Xero identifier of organisation
        /// </summary>
        /// <value>Xero identifier of organisation</value>
        [DataMember(Name="tenantId", EmitDefaultValue=false)]
        public Guid? TenantId { get; set; }

        /// <summary>
        /// Identifier shared across connections authorised at the same time
        /// </summary>
        /// <value>Identifier shared across connections authorised at the same time</value>
        [DataMember(Name="authEventId", EmitDefaultValue=false)]
        public Guid? AuthEventId { get; set; }

        /// <summary>
        /// Xero tenant type (i.e. ORGANISATION, PRACTICE)
        /// </summary>
        /// <value>Xero tenant type (i.e. ORGANISATION, PRACTICE)</value>
        [DataMember(Name="tenantType", EmitDefaultValue=false)]
        public string TenantType { get; set; }

        /// <summary>
        /// Xero tenant name
        /// </summary>
        /// <value>Xero tenant name</value>
        [DataMember(Name="tenantName", EmitDefaultValue=false)]
        public string TenantName { get; set; }

        /// <summary>
        /// The date when the user connected this tenant to your app
        /// </summary>
        /// <value>The date when the user connected this tenant to your app</value>
        [DataMember(Name="createdDateUtc", EmitDefaultValue=false)]
        public DateTime? CreatedDateUtc { get; set; }

        /// <summary>
        /// The date when the user most recently connected this tenant to your app. May differ to the created date if the user has disconnected and subsequently reconnected this tenant to your app.
        /// </summary>
        /// <value>The date when the user most recently connected this tenant to your app. May differ to the created date if the user has disconnected and subsequently reconnected this tenant to your app.</value>
        [DataMember(Name="updatedDateUtc", EmitDefaultValue=false)]
        public DateTime? UpdatedDateUtc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Connection {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  AuthEventId: ").Append(AuthEventId).Append("\n");
            sb.Append("  TenantType: ").Append(TenantType).Append("\n");
            sb.Append("  TenantName: ").Append(TenantName).Append("\n");
            sb.Append("  CreatedDateUtc: ").Append(CreatedDateUtc).Append("\n");
            sb.Append("  UpdatedDateUtc: ").Append(UpdatedDateUtc).Append("\n");
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
            return this.Equals(input as Connection);
        }

        /// <summary>
        /// Returns true if Connection instances are equal
        /// </summary>
        /// <param name="input">Instance of Connection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Connection input)
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
                    this.TenantId == input.TenantId ||
                    (this.TenantId != null &&
                    this.TenantId.Equals(input.TenantId))
                ) && 
                (
                    this.AuthEventId == input.AuthEventId ||
                    (this.AuthEventId != null &&
                    this.AuthEventId.Equals(input.AuthEventId))
                ) && 
                (
                    this.TenantType == input.TenantType ||
                    (this.TenantType != null &&
                    this.TenantType.Equals(input.TenantType))
                ) && 
                (
                    this.TenantName == input.TenantName ||
                    (this.TenantName != null &&
                    this.TenantName.Equals(input.TenantName))
                ) && 
                (
                    this.CreatedDateUtc == input.CreatedDateUtc ||
                    (this.CreatedDateUtc != null &&
                    this.CreatedDateUtc.Equals(input.CreatedDateUtc))
                ) && 
                (
                    this.UpdatedDateUtc == input.UpdatedDateUtc ||
                    (this.UpdatedDateUtc != null &&
                    this.UpdatedDateUtc.Equals(input.UpdatedDateUtc))
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
                if (this.TenantId != null)
                    hashCode = hashCode * 59 + this.TenantId.GetHashCode();
                if (this.AuthEventId != null)
                    hashCode = hashCode * 59 + this.AuthEventId.GetHashCode();
                if (this.TenantType != null)
                    hashCode = hashCode * 59 + this.TenantType.GetHashCode();
                if (this.TenantName != null)
                    hashCode = hashCode * 59 + this.TenantName.GetHashCode();
                if (this.CreatedDateUtc != null)
                    hashCode = hashCode * 59 + this.CreatedDateUtc.GetHashCode();
                if (this.UpdatedDateUtc != null)
                    hashCode = hashCode * 59 + this.UpdatedDateUtc.GetHashCode();
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
