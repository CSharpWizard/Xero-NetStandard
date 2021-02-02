/* 
 * Xero Payroll AU
 *
 * This is the Xero Payroll API for orgs in Australia region.
 *
 * The version of the OpenAPI document: 2.8.3
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
    /// TaxDeclaration
    /// </summary>
    [DataContract]
    public partial class TaxDeclaration :  IEquatable<TaxDeclaration>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets EmploymentBasis
        /// </summary>
        [DataMember(Name="EmploymentBasis", EmitDefaultValue=false)]
        public EmploymentBasis EmploymentBasis { get; set; }
        /// <summary>
        /// Gets or Sets TFNExemptionType
        /// </summary>
        [DataMember(Name="TFNExemptionType", EmitDefaultValue=false)]
        public TFNExemptionType TFNExemptionType { get; set; }
        /// <summary>
        /// Gets or Sets ResidencyStatus
        /// </summary>
        [DataMember(Name="ResidencyStatus", EmitDefaultValue=false)]
        public ResidencyStatus ResidencyStatus { get; set; }
        
        /// <summary>
        /// Address line 1 for employee home address
        /// </summary>
        /// <value>Address line 1 for employee home address</value>
        [DataMember(Name="EmployeeID", EmitDefaultValue=false)]
        public Guid? EmployeeID { get; set; }

        /// <summary>
        /// The tax file number e.g 123123123.
        /// </summary>
        /// <value>The tax file number e.g 123123123.</value>
        [DataMember(Name="TaxFileNumber", EmitDefaultValue=false)]
        public string TaxFileNumber { get; set; }

        /// <summary>
        /// If the employee is Australian resident for tax purposes. e.g true or false
        /// </summary>
        /// <value>If the employee is Australian resident for tax purposes. e.g true or false</value>
        [DataMember(Name="AustralianResidentForTaxPurposes", EmitDefaultValue=false)]
        public bool? AustralianResidentForTaxPurposes { get; set; }

        /// <summary>
        /// If tax free threshold claimed. e.g true or false
        /// </summary>
        /// <value>If tax free threshold claimed. e.g true or false</value>
        [DataMember(Name="TaxFreeThresholdClaimed", EmitDefaultValue=false)]
        public bool? TaxFreeThresholdClaimed { get; set; }

        /// <summary>
        /// If has tax offset estimated then the tax offset estimated amount. e.g 100
        /// </summary>
        /// <value>If has tax offset estimated then the tax offset estimated amount. e.g 100</value>
        [DataMember(Name="TaxOffsetEstimatedAmount", EmitDefaultValue=false)]
        public decimal? TaxOffsetEstimatedAmount { get; set; }

        /// <summary>
        /// If employee has HECS or HELP debt. e.g true or false
        /// </summary>
        /// <value>If employee has HECS or HELP debt. e.g true or false</value>
        [DataMember(Name="HasHELPDebt", EmitDefaultValue=false)]
        public bool? HasHELPDebt { get; set; }

        /// <summary>
        /// If employee has financial supplement debt. e.g true or false
        /// </summary>
        /// <value>If employee has financial supplement debt. e.g true or false</value>
        [DataMember(Name="HasSFSSDebt", EmitDefaultValue=false)]
        public bool? HasSFSSDebt { get; set; }

        /// <summary>
        /// If employee has trade support loan. e.g true or false
        /// </summary>
        /// <value>If employee has trade support loan. e.g true or false</value>
        [DataMember(Name="HasTradeSupportLoanDebt", EmitDefaultValue=false)]
        public bool? HasTradeSupportLoanDebt { get; set; }

        /// <summary>
        /// If the employee has requested that additional tax be withheld each pay run. e.g 50
        /// </summary>
        /// <value>If the employee has requested that additional tax be withheld each pay run. e.g 50</value>
        [DataMember(Name="UpwardVariationTaxWithholdingAmount", EmitDefaultValue=false)]
        public decimal? UpwardVariationTaxWithholdingAmount { get; set; }

        /// <summary>
        /// If the employee is eligible to receive an additional percentage on top of ordinary earnings when they take leave (typically 17.5%). e.g true or false
        /// </summary>
        /// <value>If the employee is eligible to receive an additional percentage on top of ordinary earnings when they take leave (typically 17.5%). e.g true or false</value>
        [DataMember(Name="EligibleToReceiveLeaveLoading", EmitDefaultValue=false)]
        public bool? EligibleToReceiveLeaveLoading { get; set; }

        /// <summary>
        /// If the employee has approved withholding variation. e.g (0 - 100)
        /// </summary>
        /// <value>If the employee has approved withholding variation. e.g (0 - 100)</value>
        [DataMember(Name="ApprovedWithholdingVariationPercentage", EmitDefaultValue=false)]
        public decimal? ApprovedWithholdingVariationPercentage { get; set; }

        /// <summary>
        /// If the employee is eligible for student startup loan rules
        /// </summary>
        /// <value>If the employee is eligible for student startup loan rules</value>
        [DataMember(Name="HasStudentStartupLoan", EmitDefaultValue=false)]
        public bool? HasStudentStartupLoan { get; set; }

        /// <summary>
        /// Last modified timestamp
        /// </summary>
        /// <value>Last modified timestamp</value>
        [DataMember(Name="UpdatedDateUTC", EmitDefaultValue=false)]
        public DateTime? UpdatedDateUTC { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxDeclaration {\n");
            sb.Append("  EmployeeID: ").Append(EmployeeID).Append("\n");
            sb.Append("  EmploymentBasis: ").Append(EmploymentBasis).Append("\n");
            sb.Append("  TFNExemptionType: ").Append(TFNExemptionType).Append("\n");
            sb.Append("  TaxFileNumber: ").Append(TaxFileNumber).Append("\n");
            sb.Append("  AustralianResidentForTaxPurposes: ").Append(AustralianResidentForTaxPurposes).Append("\n");
            sb.Append("  ResidencyStatus: ").Append(ResidencyStatus).Append("\n");
            sb.Append("  TaxFreeThresholdClaimed: ").Append(TaxFreeThresholdClaimed).Append("\n");
            sb.Append("  TaxOffsetEstimatedAmount: ").Append(TaxOffsetEstimatedAmount).Append("\n");
            sb.Append("  HasHELPDebt: ").Append(HasHELPDebt).Append("\n");
            sb.Append("  HasSFSSDebt: ").Append(HasSFSSDebt).Append("\n");
            sb.Append("  HasTradeSupportLoanDebt: ").Append(HasTradeSupportLoanDebt).Append("\n");
            sb.Append("  UpwardVariationTaxWithholdingAmount: ").Append(UpwardVariationTaxWithholdingAmount).Append("\n");
            sb.Append("  EligibleToReceiveLeaveLoading: ").Append(EligibleToReceiveLeaveLoading).Append("\n");
            sb.Append("  ApprovedWithholdingVariationPercentage: ").Append(ApprovedWithholdingVariationPercentage).Append("\n");
            sb.Append("  HasStudentStartupLoan: ").Append(HasStudentStartupLoan).Append("\n");
            sb.Append("  UpdatedDateUTC: ").Append(UpdatedDateUTC).Append("\n");
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
            return this.Equals(input as TaxDeclaration);
        }

        /// <summary>
        /// Returns true if TaxDeclaration instances are equal
        /// </summary>
        /// <param name="input">Instance of TaxDeclaration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxDeclaration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EmployeeID == input.EmployeeID ||
                    (this.EmployeeID != null &&
                    this.EmployeeID.Equals(input.EmployeeID))
                ) && 
                (
                    this.EmploymentBasis == input.EmploymentBasis ||
                    this.EmploymentBasis.Equals(input.EmploymentBasis)
                ) && 
                (
                    this.TFNExemptionType == input.TFNExemptionType ||
                    this.TFNExemptionType.Equals(input.TFNExemptionType)
                ) && 
                (
                    this.TaxFileNumber == input.TaxFileNumber ||
                    (this.TaxFileNumber != null &&
                    this.TaxFileNumber.Equals(input.TaxFileNumber))
                ) && 
                (
                    this.AustralianResidentForTaxPurposes == input.AustralianResidentForTaxPurposes ||
                    this.AustralianResidentForTaxPurposes.Equals(input.AustralianResidentForTaxPurposes)
                ) && 
                (
                    this.ResidencyStatus == input.ResidencyStatus ||
                    this.ResidencyStatus.Equals(input.ResidencyStatus)
                ) && 
                (
                    this.TaxFreeThresholdClaimed == input.TaxFreeThresholdClaimed ||
                    this.TaxFreeThresholdClaimed.Equals(input.TaxFreeThresholdClaimed)
                ) && 
                (
                    this.TaxOffsetEstimatedAmount == input.TaxOffsetEstimatedAmount ||
                    this.TaxOffsetEstimatedAmount.Equals(input.TaxOffsetEstimatedAmount)
                ) && 
                (
                    this.HasHELPDebt == input.HasHELPDebt ||
                    this.HasHELPDebt.Equals(input.HasHELPDebt)
                ) && 
                (
                    this.HasSFSSDebt == input.HasSFSSDebt ||
                    this.HasSFSSDebt.Equals(input.HasSFSSDebt)
                ) && 
                (
                    this.HasTradeSupportLoanDebt == input.HasTradeSupportLoanDebt ||
                    this.HasTradeSupportLoanDebt.Equals(input.HasTradeSupportLoanDebt)
                ) && 
                (
                    this.UpwardVariationTaxWithholdingAmount == input.UpwardVariationTaxWithholdingAmount ||
                    this.UpwardVariationTaxWithholdingAmount.Equals(input.UpwardVariationTaxWithholdingAmount)
                ) && 
                (
                    this.EligibleToReceiveLeaveLoading == input.EligibleToReceiveLeaveLoading ||
                    this.EligibleToReceiveLeaveLoading.Equals(input.EligibleToReceiveLeaveLoading)
                ) && 
                (
                    this.ApprovedWithholdingVariationPercentage == input.ApprovedWithholdingVariationPercentage ||
                    this.ApprovedWithholdingVariationPercentage.Equals(input.ApprovedWithholdingVariationPercentage)
                ) && 
                (
                    this.HasStudentStartupLoan == input.HasStudentStartupLoan ||
                    this.HasStudentStartupLoan.Equals(input.HasStudentStartupLoan)
                ) && 
                (
                    this.UpdatedDateUTC == input.UpdatedDateUTC ||
                    (this.UpdatedDateUTC != null &&
                    this.UpdatedDateUTC.Equals(input.UpdatedDateUTC))
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
                if (this.EmployeeID != null)
                    hashCode = hashCode * 59 + this.EmployeeID.GetHashCode();
                hashCode = hashCode * 59 + this.EmploymentBasis.GetHashCode();
                hashCode = hashCode * 59 + this.TFNExemptionType.GetHashCode();
                if (this.TaxFileNumber != null)
                    hashCode = hashCode * 59 + this.TaxFileNumber.GetHashCode();
                hashCode = hashCode * 59 + this.AustralianResidentForTaxPurposes.GetHashCode();
                hashCode = hashCode * 59 + this.ResidencyStatus.GetHashCode();
                hashCode = hashCode * 59 + this.TaxFreeThresholdClaimed.GetHashCode();
                hashCode = hashCode * 59 + this.TaxOffsetEstimatedAmount.GetHashCode();
                hashCode = hashCode * 59 + this.HasHELPDebt.GetHashCode();
                hashCode = hashCode * 59 + this.HasSFSSDebt.GetHashCode();
                hashCode = hashCode * 59 + this.HasTradeSupportLoanDebt.GetHashCode();
                hashCode = hashCode * 59 + this.UpwardVariationTaxWithholdingAmount.GetHashCode();
                hashCode = hashCode * 59 + this.EligibleToReceiveLeaveLoading.GetHashCode();
                hashCode = hashCode * 59 + this.ApprovedWithholdingVariationPercentage.GetHashCode();
                hashCode = hashCode * 59 + this.HasStudentStartupLoan.GetHashCode();
                if (this.UpdatedDateUTC != null)
                    hashCode = hashCode * 59 + this.UpdatedDateUTC.GetHashCode();
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
