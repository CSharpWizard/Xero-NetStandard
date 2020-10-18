/* 
 * Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.3.6
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
    /// CreditNotes
    /// </summary>
    [DataContract]
    public partial class CreditNotes :  IEquatable<CreditNotes>, IValidatableObject
    {
        
        /// <summary>
        /// Gets or Sets _CreditNotes
        /// </summary>
        [DataMember(Name="CreditNotes", EmitDefaultValue=false)]
        public List<CreditNote> _CreditNotes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreditNotes {\n");
            sb.Append("  _CreditNotes: ").Append(_CreditNotes).Append("\n");
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
            return this.Equals(input as CreditNotes);
        }

        /// <summary>
        /// Returns true if CreditNotes instances are equal
        /// </summary>
        /// <param name="input">Instance of CreditNotes to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreditNotes input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._CreditNotes == input._CreditNotes ||
                    this._CreditNotes != null &&
                    input._CreditNotes != null &&
                    this._CreditNotes.SequenceEqual(input._CreditNotes)
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
                if (this._CreditNotes != null)
                    hashCode = hashCode * 59 + this._CreditNotes.GetHashCode();
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
