/* 
 * Xero oAuth 2 identity service
 *
 * This specifing endpoints related to managing authentication tokens and identity for Xero API
 *
 * The version of the OpenAPI document: 2.1.4
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
    /// AccessToken
    /// </summary>
    [DataContract]
    public partial class AccessToken :  IEquatable<AccessToken>, IValidatableObject
    {
        
        /// <summary>
        /// Xero unique identifier
        /// </summary>
        /// <value>Xero unique identifier</value>
        [DataMember(Name="id_token", EmitDefaultValue=false)]
        public string IdToken { get; set; }

        /// <summary>
        /// access token provided during authentication flow
        /// </summary>
        /// <value>access token provided during authentication flow</value>
        [DataMember(Name="access_token", EmitDefaultValue=false)]
        public string _AccessToken { get; set; }

        /// <summary>
        /// time in milliseconds until access token expires.
        /// </summary>
        /// <value>time in milliseconds until access token expires.</value>
        [DataMember(Name="expires_in", EmitDefaultValue=false)]
        public decimal? ExpiresIn { get; set; }

        /// <summary>
        /// type of token i.e. Bearer
        /// </summary>
        /// <value>type of token i.e. Bearer</value>
        [DataMember(Name="token_type", EmitDefaultValue=false)]
        public string TokenType { get; set; }

        /// <summary>
        /// token used to refresh an expired access token
        /// </summary>
        /// <value>token used to refresh an expired access token</value>
        [DataMember(Name="refresh_token", EmitDefaultValue=false)]
        public string RefreshToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessToken {\n");
            sb.Append("  IdToken: ").Append(IdToken).Append("\n");
            sb.Append("  _AccessToken: ").Append(_AccessToken).Append("\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
            sb.Append("  TokenType: ").Append(TokenType).Append("\n");
            sb.Append("  RefreshToken: ").Append(RefreshToken).Append("\n");
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
            return this.Equals(input as AccessToken);
        }

        /// <summary>
        /// Returns true if AccessToken instances are equal
        /// </summary>
        /// <param name="input">Instance of AccessToken to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccessToken input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IdToken == input.IdToken ||
                    (this.IdToken != null &&
                    this.IdToken.Equals(input.IdToken))
                ) && 
                (
                    this._AccessToken == input._AccessToken ||
                    (this._AccessToken != null &&
                    this._AccessToken.Equals(input._AccessToken))
                ) && 
                (
                    this.ExpiresIn == input.ExpiresIn ||
                    this.ExpiresIn.Equals(input.ExpiresIn)
                ) && 
                (
                    this.TokenType == input.TokenType ||
                    (this.TokenType != null &&
                    this.TokenType.Equals(input.TokenType))
                ) && 
                (
                    this.RefreshToken == input.RefreshToken ||
                    (this.RefreshToken != null &&
                    this.RefreshToken.Equals(input.RefreshToken))
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
                if (this.IdToken != null)
                    hashCode = hashCode * 59 + this.IdToken.GetHashCode();
                if (this._AccessToken != null)
                    hashCode = hashCode * 59 + this._AccessToken.GetHashCode();
                hashCode = hashCode * 59 + this.ExpiresIn.GetHashCode();
                if (this.TokenType != null)
                    hashCode = hashCode * 59 + this.TokenType.GetHashCode();
                if (this.RefreshToken != null)
                    hashCode = hashCode * 59 + this.RefreshToken.GetHashCode();
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
