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
    /// EarningsRate
    /// </summary>
    [DataContract]
    public partial class EarningsRate :  IEquatable<EarningsRate>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets EarningsType
        /// </summary>
        [DataMember(Name="EarningsType", EmitDefaultValue=false)]
        public EarningsType EarningsType { get; set; }
        /// <summary>
        /// Gets or Sets RateType
        /// </summary>
        [DataMember(Name="RateType", EmitDefaultValue=false)]
        public RateType RateType { get; set; }
        /// <summary>
        /// Gets or Sets EmploymentTerminationPaymentType
        /// </summary>
        [DataMember(Name="EmploymentTerminationPaymentType", EmitDefaultValue=false)]
        public EmploymentTerminationPaymentType EmploymentTerminationPaymentType { get; set; }
        /// <summary>
        /// Gets or Sets AllowanceType
        /// </summary>
        [DataMember(Name="AllowanceType", EmitDefaultValue=false)]
        public AllowanceType AllowanceType { get; set; }
        
        /// <summary>
        /// Name of the earnings rate (max length &#x3D; 100)
        /// </summary>
        /// <value>Name of the earnings rate (max length &#x3D; 100)</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// See Accounts
        /// </summary>
        /// <value>See Accounts</value>
        [DataMember(Name="AccountCode", EmitDefaultValue=false)]
        public string AccountCode { get; set; }

        /// <summary>
        /// Type of units used to record earnings (max length &#x3D; 50). Only When RateType is RATEPERUNIT
        /// </summary>
        /// <value>Type of units used to record earnings (max length &#x3D; 50). Only When RateType is RATEPERUNIT</value>
        [DataMember(Name="TypeOfUnits", EmitDefaultValue=false)]
        public string TypeOfUnits { get; set; }

        /// <summary>
        /// Most payments are subject to tax, so you should only set this value if you are sure that a payment is exempt from PAYG withholding
        /// </summary>
        /// <value>Most payments are subject to tax, so you should only set this value if you are sure that a payment is exempt from PAYG withholding</value>
        [DataMember(Name="IsExemptFromTax", EmitDefaultValue=false)]
        public bool? IsExemptFromTax { get; set; }

        /// <summary>
        /// See the ATO website for details of which payments are exempt from SGC
        /// </summary>
        /// <value>See the ATO website for details of which payments are exempt from SGC</value>
        [DataMember(Name="IsExemptFromSuper", EmitDefaultValue=false)]
        public bool? IsExemptFromSuper { get; set; }

        /// <summary>
        /// Boolean to determine if the earnings rate is reportable or exempt from W1
        /// </summary>
        /// <value>Boolean to determine if the earnings rate is reportable or exempt from W1</value>
        [DataMember(Name="IsReportableAsW1", EmitDefaultValue=false)]
        public bool? IsReportableAsW1 { get; set; }

        /// <summary>
        /// Xero identifier
        /// </summary>
        /// <value>Xero identifier</value>
        [DataMember(Name="EarningsRateID", EmitDefaultValue=false)]
        public Guid? EarningsRateID { get; set; }

        /// <summary>
        /// Default rate per unit (optional). Only applicable if RateType is RATEPERUNIT.
        /// </summary>
        /// <value>Default rate per unit (optional). Only applicable if RateType is RATEPERUNIT.</value>
        [DataMember(Name="RatePerUnit", EmitDefaultValue=false)]
        public string RatePerUnit { get; set; }

        /// <summary>
        /// This is the multiplier used to calculate the rate per unit, based on the employee’s ordinary earnings rate. For example, for time and a half enter 1.5. Only applicable if RateType is MULTIPLE
        /// </summary>
        /// <value>This is the multiplier used to calculate the rate per unit, based on the employee’s ordinary earnings rate. For example, for time and a half enter 1.5. Only applicable if RateType is MULTIPLE</value>
        [DataMember(Name="Multiplier", EmitDefaultValue=false)]
        public decimal? Multiplier { get; set; }

        /// <summary>
        /// Indicates that this earnings rate should accrue leave. Only applicable if RateType is MULTIPLE
        /// </summary>
        /// <value>Indicates that this earnings rate should accrue leave. Only applicable if RateType is MULTIPLE</value>
        [DataMember(Name="AccrueLeave", EmitDefaultValue=false)]
        public bool? AccrueLeave { get; set; }

        /// <summary>
        /// Optional Amount for FIXEDAMOUNT RateType EarningsRate
        /// </summary>
        /// <value>Optional Amount for FIXEDAMOUNT RateType EarningsRate</value>
        [DataMember(Name="Amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Last modified timestamp
        /// </summary>
        /// <value>Last modified timestamp</value>
        [DataMember(Name="UpdatedDateUTC", EmitDefaultValue=false)]
        public DateTime? UpdatedDateUTC { get; private set; }

        /// <summary>
        /// Is the current record
        /// </summary>
        /// <value>Is the current record</value>
        [DataMember(Name="CurrentRecord", EmitDefaultValue=false)]
        public bool? CurrentRecord { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EarningsRate {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AccountCode: ").Append(AccountCode).Append("\n");
            sb.Append("  TypeOfUnits: ").Append(TypeOfUnits).Append("\n");
            sb.Append("  IsExemptFromTax: ").Append(IsExemptFromTax).Append("\n");
            sb.Append("  IsExemptFromSuper: ").Append(IsExemptFromSuper).Append("\n");
            sb.Append("  IsReportableAsW1: ").Append(IsReportableAsW1).Append("\n");
            sb.Append("  EarningsType: ").Append(EarningsType).Append("\n");
            sb.Append("  EarningsRateID: ").Append(EarningsRateID).Append("\n");
            sb.Append("  RateType: ").Append(RateType).Append("\n");
            sb.Append("  RatePerUnit: ").Append(RatePerUnit).Append("\n");
            sb.Append("  Multiplier: ").Append(Multiplier).Append("\n");
            sb.Append("  AccrueLeave: ").Append(AccrueLeave).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  EmploymentTerminationPaymentType: ").Append(EmploymentTerminationPaymentType).Append("\n");
            sb.Append("  UpdatedDateUTC: ").Append(UpdatedDateUTC).Append("\n");
            sb.Append("  CurrentRecord: ").Append(CurrentRecord).Append("\n");
            sb.Append("  AllowanceType: ").Append(AllowanceType).Append("\n");
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
            return this.Equals(input as EarningsRate);
        }

        /// <summary>
        /// Returns true if EarningsRate instances are equal
        /// </summary>
        /// <param name="input">Instance of EarningsRate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EarningsRate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.AccountCode == input.AccountCode ||
                    (this.AccountCode != null &&
                    this.AccountCode.Equals(input.AccountCode))
                ) && 
                (
                    this.TypeOfUnits == input.TypeOfUnits ||
                    (this.TypeOfUnits != null &&
                    this.TypeOfUnits.Equals(input.TypeOfUnits))
                ) && 
                (
                    this.IsExemptFromTax == input.IsExemptFromTax ||
                    this.IsExemptFromTax.Equals(input.IsExemptFromTax)
                ) && 
                (
                    this.IsExemptFromSuper == input.IsExemptFromSuper ||
                    this.IsExemptFromSuper.Equals(input.IsExemptFromSuper)
                ) && 
                (
                    this.IsReportableAsW1 == input.IsReportableAsW1 ||
                    this.IsReportableAsW1.Equals(input.IsReportableAsW1)
                ) && 
                (
                    this.EarningsType == input.EarningsType ||
                    this.EarningsType.Equals(input.EarningsType)
                ) && 
                (
                    this.EarningsRateID == input.EarningsRateID ||
                    (this.EarningsRateID != null &&
                    this.EarningsRateID.Equals(input.EarningsRateID))
                ) && 
                (
                    this.RateType == input.RateType ||
                    this.RateType.Equals(input.RateType)
                ) && 
                (
                    this.RatePerUnit == input.RatePerUnit ||
                    (this.RatePerUnit != null &&
                    this.RatePerUnit.Equals(input.RatePerUnit))
                ) && 
                (
                    this.Multiplier == input.Multiplier ||
                    this.Multiplier.Equals(input.Multiplier)
                ) && 
                (
                    this.AccrueLeave == input.AccrueLeave ||
                    this.AccrueLeave.Equals(input.AccrueLeave)
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.EmploymentTerminationPaymentType == input.EmploymentTerminationPaymentType ||
                    this.EmploymentTerminationPaymentType.Equals(input.EmploymentTerminationPaymentType)
                ) && 
                (
                    this.UpdatedDateUTC == input.UpdatedDateUTC ||
                    (this.UpdatedDateUTC != null &&
                    this.UpdatedDateUTC.Equals(input.UpdatedDateUTC))
                ) && 
                (
                    this.CurrentRecord == input.CurrentRecord ||
                    this.CurrentRecord.Equals(input.CurrentRecord)
                ) && 
                (
                    this.AllowanceType == input.AllowanceType ||
                    this.AllowanceType.Equals(input.AllowanceType)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AccountCode != null)
                    hashCode = hashCode * 59 + this.AccountCode.GetHashCode();
                if (this.TypeOfUnits != null)
                    hashCode = hashCode * 59 + this.TypeOfUnits.GetHashCode();
                hashCode = hashCode * 59 + this.IsExemptFromTax.GetHashCode();
                hashCode = hashCode * 59 + this.IsExemptFromSuper.GetHashCode();
                hashCode = hashCode * 59 + this.IsReportableAsW1.GetHashCode();
                hashCode = hashCode * 59 + this.EarningsType.GetHashCode();
                if (this.EarningsRateID != null)
                    hashCode = hashCode * 59 + this.EarningsRateID.GetHashCode();
                hashCode = hashCode * 59 + this.RateType.GetHashCode();
                if (this.RatePerUnit != null)
                    hashCode = hashCode * 59 + this.RatePerUnit.GetHashCode();
                hashCode = hashCode * 59 + this.Multiplier.GetHashCode();
                hashCode = hashCode * 59 + this.AccrueLeave.GetHashCode();
                hashCode = hashCode * 59 + this.Amount.GetHashCode();
                hashCode = hashCode * 59 + this.EmploymentTerminationPaymentType.GetHashCode();
                if (this.UpdatedDateUTC != null)
                    hashCode = hashCode * 59 + this.UpdatedDateUTC.GetHashCode();
                hashCode = hashCode * 59 + this.CurrentRecord.GetHashCode();
                hashCode = hashCode * 59 + this.AllowanceType.GetHashCode();
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
            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 100.", new [] { "Name" });
            }

            // TypeOfUnits (string) maxLength
            if(this.TypeOfUnits != null && this.TypeOfUnits.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TypeOfUnits, length must be less than 50.", new [] { "TypeOfUnits" });
            }

            yield break;
        }
    }

}
