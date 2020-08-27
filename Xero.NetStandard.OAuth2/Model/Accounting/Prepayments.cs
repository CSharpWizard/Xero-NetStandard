/* 
 * Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.2.14
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
    /// Prepayments
    /// </summary>
    [DataContract]
    public partial class Prepayments :  IEquatable<Prepayments>, IValidatableObject
    {
        
        /// <summary>
        /// Gets or Sets _Prepayments
        /// </summary>
        [DataMember(Name="Prepayments", EmitDefaultValue=false)]
        public List<Prepayment> _Prepayments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Prepayments {\n");
            sb.Append("  _Prepayments: ").Append(_Prepayments).Append("\n");
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
            return this.Equals(input as Prepayments);
        }

        /// <summary>
        /// Returns true if Prepayments instances are equal
        /// </summary>
        /// <param name="input">Instance of Prepayments to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Prepayments input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._Prepayments == input._Prepayments ||
                    this._Prepayments != null &&
                    input._Prepayments != null &&
                    this._Prepayments.SequenceEqual(input._Prepayments)
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
                if (this._Prepayments != null)
                    hashCode = hashCode * 59 + this._Prepayments.GetHashCode();
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
