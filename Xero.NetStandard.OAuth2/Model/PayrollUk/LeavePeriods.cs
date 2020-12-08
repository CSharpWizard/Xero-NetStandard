/* 
 * Xero Payroll UK
 *
 * This is the Xero Payroll API for orgs in the UK region.
 *
 * The version of the OpenAPI document: 2.6.1
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

namespace Xero.NetStandard.OAuth2.Model.PayrollUk
{
    /// <summary>
    /// LeavePeriods
    /// </summary>
    [DataContract]
    public partial class LeavePeriods :  IEquatable<LeavePeriods>, IValidatableObject
    {
        
        /// <summary>
        /// Gets or Sets Pagination
        /// </summary>
        [DataMember(Name="pagination", EmitDefaultValue=false)]
        public Pagination Pagination { get; set; }

        /// <summary>
        /// Gets or Sets Problem
        /// </summary>
        [DataMember(Name="problem", EmitDefaultValue=false)]
        public Problem Problem { get; set; }

        /// <summary>
        /// Gets or Sets Periods
        /// </summary>
        [DataMember(Name="periods", EmitDefaultValue=false)]
        public List<LeavePeriod> Periods { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LeavePeriods {\n");
            sb.Append("  Pagination: ").Append(Pagination).Append("\n");
            sb.Append("  Problem: ").Append(Problem).Append("\n");
            sb.Append("  Periods: ").Append(Periods).Append("\n");
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
            return this.Equals(input as LeavePeriods);
        }

        /// <summary>
        /// Returns true if LeavePeriods instances are equal
        /// </summary>
        /// <param name="input">Instance of LeavePeriods to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LeavePeriods input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Pagination == input.Pagination ||
                    (this.Pagination != null &&
                    this.Pagination.Equals(input.Pagination))
                ) && 
                (
                    this.Problem == input.Problem ||
                    (this.Problem != null &&
                    this.Problem.Equals(input.Problem))
                ) && 
                (
                    this.Periods == input.Periods ||
                    this.Periods != null &&
                    input.Periods != null &&
                    this.Periods.SequenceEqual(input.Periods)
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
                if (this.Pagination != null)
                    hashCode = hashCode * 59 + this.Pagination.GetHashCode();
                if (this.Problem != null)
                    hashCode = hashCode * 59 + this.Problem.GetHashCode();
                if (this.Periods != null)
                    hashCode = hashCode * 59 + this.Periods.GetHashCode();
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
