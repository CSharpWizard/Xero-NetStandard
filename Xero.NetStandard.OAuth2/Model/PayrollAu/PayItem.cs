/* 
 * Xero Payroll AU
 *
 * This is the Xero Payroll API for orgs in Australia region.
 *
 * The version of the OpenAPI document: 2.7.0
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

namespace Xero.NetStandard.OAuth2.Model.PayrollAu
{
    /// <summary>
    /// PayItem
    /// </summary>
    [DataContract]
    public partial class PayItem :  IEquatable<PayItem>, IValidatableObject
    {
        
        /// <summary>
        /// Gets or Sets EarningsRates
        /// </summary>
        [DataMember(Name="EarningsRates", EmitDefaultValue=false)]
        public List<EarningsRate> EarningsRates { get; set; }

        /// <summary>
        /// Gets or Sets DeductionTypes
        /// </summary>
        [DataMember(Name="DeductionTypes", EmitDefaultValue=false)]
        public List<DeductionType> DeductionTypes { get; set; }

        /// <summary>
        /// Gets or Sets LeaveTypes
        /// </summary>
        [DataMember(Name="LeaveTypes", EmitDefaultValue=false)]
        public List<LeaveType> LeaveTypes { get; set; }

        /// <summary>
        /// Gets or Sets ReimbursementTypes
        /// </summary>
        [DataMember(Name="ReimbursementTypes", EmitDefaultValue=false)]
        public List<ReimbursementType> ReimbursementTypes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayItem {\n");
            sb.Append("  EarningsRates: ").Append(EarningsRates).Append("\n");
            sb.Append("  DeductionTypes: ").Append(DeductionTypes).Append("\n");
            sb.Append("  LeaveTypes: ").Append(LeaveTypes).Append("\n");
            sb.Append("  ReimbursementTypes: ").Append(ReimbursementTypes).Append("\n");
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
            return this.Equals(input as PayItem);
        }

        /// <summary>
        /// Returns true if PayItem instances are equal
        /// </summary>
        /// <param name="input">Instance of PayItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EarningsRates == input.EarningsRates ||
                    this.EarningsRates != null &&
                    input.EarningsRates != null &&
                    this.EarningsRates.SequenceEqual(input.EarningsRates)
                ) && 
                (
                    this.DeductionTypes == input.DeductionTypes ||
                    this.DeductionTypes != null &&
                    input.DeductionTypes != null &&
                    this.DeductionTypes.SequenceEqual(input.DeductionTypes)
                ) && 
                (
                    this.LeaveTypes == input.LeaveTypes ||
                    this.LeaveTypes != null &&
                    input.LeaveTypes != null &&
                    this.LeaveTypes.SequenceEqual(input.LeaveTypes)
                ) && 
                (
                    this.ReimbursementTypes == input.ReimbursementTypes ||
                    this.ReimbursementTypes != null &&
                    input.ReimbursementTypes != null &&
                    this.ReimbursementTypes.SequenceEqual(input.ReimbursementTypes)
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
                if (this.EarningsRates != null)
                    hashCode = hashCode * 59 + this.EarningsRates.GetHashCode();
                if (this.DeductionTypes != null)
                    hashCode = hashCode * 59 + this.DeductionTypes.GetHashCode();
                if (this.LeaveTypes != null)
                    hashCode = hashCode * 59 + this.LeaveTypes.GetHashCode();
                if (this.ReimbursementTypes != null)
                    hashCode = hashCode * 59 + this.ReimbursementTypes.GetHashCode();
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
