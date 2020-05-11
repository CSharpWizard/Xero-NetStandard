/* 
 * Xero Payroll AU
 *
 * This is the Xero Payroll API for orgs in Australia region.
 *
 * The version of the OpenAPI document: 2.1.2
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
    /// OpeningBalances
    /// </summary>
    [DataContract]
    public partial class OpeningBalances :  IEquatable<OpeningBalances>, IValidatableObject
    {
        
        /// <summary>
        /// Opening Balance Date. (YYYY-MM-DD)
        /// </summary>
        /// <value>Opening Balance Date. (YYYY-MM-DD)</value>
        [DataMember(Name="OpeningBalanceDate", EmitDefaultValue=false)]
        public DateTime? OpeningBalanceDate { get; set; }

        /// <summary>
        /// Opening Balance tax
        /// </summary>
        /// <value>Opening Balance tax</value>
        [DataMember(Name="Tax", EmitDefaultValue=false)]
        public string Tax { get; set; }

        /// <summary>
        /// Gets or Sets EarningsLines
        /// </summary>
        [DataMember(Name="EarningsLines", EmitDefaultValue=false)]
        public List<EarningsLine> EarningsLines { get; set; }

        /// <summary>
        /// Gets or Sets DeductionLines
        /// </summary>
        [DataMember(Name="DeductionLines", EmitDefaultValue=false)]
        public List<DeductionLine> DeductionLines { get; set; }

        /// <summary>
        /// Gets or Sets SuperLines
        /// </summary>
        [DataMember(Name="SuperLines", EmitDefaultValue=false)]
        public List<SuperLine> SuperLines { get; set; }

        /// <summary>
        /// Gets or Sets ReimbursementLines
        /// </summary>
        [DataMember(Name="ReimbursementLines", EmitDefaultValue=false)]
        public List<ReimbursementLine> ReimbursementLines { get; set; }

        /// <summary>
        /// Gets or Sets LeaveLines
        /// </summary>
        [DataMember(Name="LeaveLines", EmitDefaultValue=false)]
        public List<LeaveLine> LeaveLines { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpeningBalances {\n");
            sb.Append("  OpeningBalanceDate: ").Append(OpeningBalanceDate).Append("\n");
            sb.Append("  Tax: ").Append(Tax).Append("\n");
            sb.Append("  EarningsLines: ").Append(EarningsLines).Append("\n");
            sb.Append("  DeductionLines: ").Append(DeductionLines).Append("\n");
            sb.Append("  SuperLines: ").Append(SuperLines).Append("\n");
            sb.Append("  ReimbursementLines: ").Append(ReimbursementLines).Append("\n");
            sb.Append("  LeaveLines: ").Append(LeaveLines).Append("\n");
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
            return this.Equals(input as OpeningBalances);
        }

        /// <summary>
        /// Returns true if OpeningBalances instances are equal
        /// </summary>
        /// <param name="input">Instance of OpeningBalances to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpeningBalances input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OpeningBalanceDate == input.OpeningBalanceDate ||
                    (this.OpeningBalanceDate != null &&
                    this.OpeningBalanceDate.Equals(input.OpeningBalanceDate))
                ) && 
                (
                    this.Tax == input.Tax ||
                    (this.Tax != null &&
                    this.Tax.Equals(input.Tax))
                ) && 
                (
                    this.EarningsLines == input.EarningsLines ||
                    this.EarningsLines != null &&
                    input.EarningsLines != null &&
                    this.EarningsLines.SequenceEqual(input.EarningsLines)
                ) && 
                (
                    this.DeductionLines == input.DeductionLines ||
                    this.DeductionLines != null &&
                    input.DeductionLines != null &&
                    this.DeductionLines.SequenceEqual(input.DeductionLines)
                ) && 
                (
                    this.SuperLines == input.SuperLines ||
                    this.SuperLines != null &&
                    input.SuperLines != null &&
                    this.SuperLines.SequenceEqual(input.SuperLines)
                ) && 
                (
                    this.ReimbursementLines == input.ReimbursementLines ||
                    this.ReimbursementLines != null &&
                    input.ReimbursementLines != null &&
                    this.ReimbursementLines.SequenceEqual(input.ReimbursementLines)
                ) && 
                (
                    this.LeaveLines == input.LeaveLines ||
                    this.LeaveLines != null &&
                    input.LeaveLines != null &&
                    this.LeaveLines.SequenceEqual(input.LeaveLines)
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
                if (this.OpeningBalanceDate != null)
                    hashCode = hashCode * 59 + this.OpeningBalanceDate.GetHashCode();
                if (this.Tax != null)
                    hashCode = hashCode * 59 + this.Tax.GetHashCode();
                if (this.EarningsLines != null)
                    hashCode = hashCode * 59 + this.EarningsLines.GetHashCode();
                if (this.DeductionLines != null)
                    hashCode = hashCode * 59 + this.DeductionLines.GetHashCode();
                if (this.SuperLines != null)
                    hashCode = hashCode * 59 + this.SuperLines.GetHashCode();
                if (this.ReimbursementLines != null)
                    hashCode = hashCode * 59 + this.ReimbursementLines.GetHashCode();
                if (this.LeaveLines != null)
                    hashCode = hashCode * 59 + this.LeaveLines.GetHashCode();
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
