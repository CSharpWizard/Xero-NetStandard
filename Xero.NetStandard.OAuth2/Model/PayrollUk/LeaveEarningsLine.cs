/* 
 * Xero Payroll UK
 *
 * This is the Xero Payroll API for orgs in the UK region.
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

namespace Xero.NetStandard.OAuth2.Model.PayrollUk
{
    /// <summary>
    /// LeaveEarningsLine
    /// </summary>
    [DataContract]
    public partial class LeaveEarningsLine :  IEquatable<LeaveEarningsLine>, IValidatableObject
    {
        
        /// <summary>
        /// Xero identifier for payroll leave earnings rate
        /// </summary>
        /// <value>Xero identifier for payroll leave earnings rate</value>
        [DataMember(Name="earningsRateID", EmitDefaultValue=false)]
        public Guid? EarningsRateID { get; set; }

        /// <summary>
        /// Rate per unit for leave earnings line
        /// </summary>
        /// <value>Rate per unit for leave earnings line</value>
        [DataMember(Name="ratePerUnit", EmitDefaultValue=false)]
        public double? RatePerUnit { get; set; }

        /// <summary>
        /// Leave earnings number of units
        /// </summary>
        /// <value>Leave earnings number of units</value>
        [DataMember(Name="numberOfUnits", EmitDefaultValue=false)]
        public double? NumberOfUnits { get; set; }

        /// <summary>
        /// Leave earnings fixed amount. Only applicable if the EarningsRate RateType is Fixed
        /// </summary>
        /// <value>Leave earnings fixed amount. Only applicable if the EarningsRate RateType is Fixed</value>
        [DataMember(Name="fixedAmount", EmitDefaultValue=false)]
        public double? FixedAmount { get; set; }

        /// <summary>
        /// The amount of the earnings line.
        /// </summary>
        /// <value>The amount of the earnings line.</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public double? Amount { get; set; }

        /// <summary>
        /// Identifies if the leave earnings is taken from the timesheet. False for leave earnings line
        /// </summary>
        /// <value>Identifies if the leave earnings is taken from the timesheet. False for leave earnings line</value>
        [DataMember(Name="isLinkedToTimesheet", EmitDefaultValue=false)]
        public bool? IsLinkedToTimesheet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LeaveEarningsLine {\n");
            sb.Append("  EarningsRateID: ").Append(EarningsRateID).Append("\n");
            sb.Append("  RatePerUnit: ").Append(RatePerUnit).Append("\n");
            sb.Append("  NumberOfUnits: ").Append(NumberOfUnits).Append("\n");
            sb.Append("  FixedAmount: ").Append(FixedAmount).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  IsLinkedToTimesheet: ").Append(IsLinkedToTimesheet).Append("\n");
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
            return this.Equals(input as LeaveEarningsLine);
        }

        /// <summary>
        /// Returns true if LeaveEarningsLine instances are equal
        /// </summary>
        /// <param name="input">Instance of LeaveEarningsLine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LeaveEarningsLine input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EarningsRateID == input.EarningsRateID ||
                    (this.EarningsRateID != null &&
                    this.EarningsRateID.Equals(input.EarningsRateID))
                ) && 
                (
                    this.RatePerUnit == input.RatePerUnit ||
                    this.RatePerUnit.Equals(input.RatePerUnit)
                ) && 
                (
                    this.NumberOfUnits == input.NumberOfUnits ||
                    this.NumberOfUnits.Equals(input.NumberOfUnits)
                ) && 
                (
                    this.FixedAmount == input.FixedAmount ||
                    this.FixedAmount.Equals(input.FixedAmount)
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.IsLinkedToTimesheet == input.IsLinkedToTimesheet ||
                    this.IsLinkedToTimesheet.Equals(input.IsLinkedToTimesheet)
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
                if (this.EarningsRateID != null)
                    hashCode = hashCode * 59 + this.EarningsRateID.GetHashCode();
                hashCode = hashCode * 59 + this.RatePerUnit.GetHashCode();
                hashCode = hashCode * 59 + this.NumberOfUnits.GetHashCode();
                hashCode = hashCode * 59 + this.FixedAmount.GetHashCode();
                hashCode = hashCode * 59 + this.Amount.GetHashCode();
                hashCode = hashCode * 59 + this.IsLinkedToTimesheet.GetHashCode();
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
