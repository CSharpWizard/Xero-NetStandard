/* 
 * Xero Payroll NZ
 *
 * This is the Xero Payroll API for orgs in the NZ region.
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

namespace Xero.NetStandard.OAuth2.Model.PayrollNz
{
    /// <summary>
    /// EmployeeTax
    /// </summary>
    [DataContract]
    public partial class EmployeeTax :  IEquatable<EmployeeTax>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets TaxCode
        /// </summary>
        [DataMember(Name="taxCode", EmitDefaultValue=false)]
        public TaxCode TaxCode { get; set; }
        /// <summary>
        /// Contribution Option which can be &#39;MakeContributions&#39; &#39;OptOut&#39;, &#39;OnAContributionsHoliday&#39;, &#39;OnASavingsSuspension&#39;, &#39;NotCurrentlyAKiwiSaverMember&#39; for employees without a KiwiSaver membership
        /// </summary>
        /// <value>Contribution Option which can be &#39;MakeContributions&#39; &#39;OptOut&#39;, &#39;OnAContributionsHoliday&#39;, &#39;OnASavingsSuspension&#39;, &#39;NotCurrentlyAKiwiSaverMember&#39; for employees without a KiwiSaver membership</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum KiwiSaverContributionsEnum
        {
            /// <summary>
            /// Enum MakeContributions for value: MakeContributions
            /// </summary>
            [EnumMember(Value = "MakeContributions")]
            MakeContributions = 1,

            /// <summary>
            /// Enum OptOut for value: OptOut
            /// </summary>
            [EnumMember(Value = "OptOut")]
            OptOut = 2,

            /// <summary>
            /// Enum OnAContributionsHoliday for value: OnAContributionsHoliday
            /// </summary>
            [EnumMember(Value = "OnAContributionsHoliday")]
            OnAContributionsHoliday = 3,

            /// <summary>
            /// Enum OnASavingsSuspension for value: OnASavingsSuspension
            /// </summary>
            [EnumMember(Value = "OnASavingsSuspension")]
            OnASavingsSuspension = 4,

            /// <summary>
            /// Enum NotCurrentlyAKiwiSaverMember for value: NotCurrentlyAKiwiSaverMember
            /// </summary>
            [EnumMember(Value = "NotCurrentlyAKiwiSaverMember")]
            NotCurrentlyAKiwiSaverMember = 5

        }

        /// <summary>
        /// Contribution Option which can be &#39;MakeContributions&#39; &#39;OptOut&#39;, &#39;OnAContributionsHoliday&#39;, &#39;OnASavingsSuspension&#39;, &#39;NotCurrentlyAKiwiSaverMember&#39; for employees without a KiwiSaver membership
        /// </summary>
        /// <value>Contribution Option which can be &#39;MakeContributions&#39; &#39;OptOut&#39;, &#39;OnAContributionsHoliday&#39;, &#39;OnASavingsSuspension&#39;, &#39;NotCurrentlyAKiwiSaverMember&#39; for employees without a KiwiSaver membership</value>
        [DataMember(Name="kiwiSaverContributions", EmitDefaultValue=false)]
        public KiwiSaverContributionsEnum KiwiSaverContributions { get; set; }
        
        /// <summary>
        /// The IRD Number.
        /// </summary>
        /// <value>The IRD Number.</value>
        [DataMember(Name="irdNumber", EmitDefaultValue=false)]
        public string IrdNumber { get; set; }

        /// <summary>
        /// Special tax rate percentage.
        /// </summary>
        /// <value>Special tax rate percentage.</value>
        [DataMember(Name="specialTaxRatePercentage", EmitDefaultValue=false)]
        public decimal? SpecialTaxRatePercentage { get; set; }

        /// <summary>
        /// Does the employee has a special student loan rate?
        /// </summary>
        /// <value>Does the employee has a special student loan rate?</value>
        [DataMember(Name="hasSpecialStudentLoanRate", EmitDefaultValue=false)]
        public bool? HasSpecialStudentLoanRate { get; set; }

        /// <summary>
        /// The employee student loan rate percentage.
        /// </summary>
        /// <value>The employee student loan rate percentage.</value>
        [DataMember(Name="specialStudentLoanRatePercentage", EmitDefaultValue=false)]
        public decimal? SpecialStudentLoanRatePercentage { get; set; }

        /// <summary>
        /// The employee eligibility for KiwiSaver.
        /// </summary>
        /// <value>The employee eligibility for KiwiSaver.</value>
        [DataMember(Name="isEligibleForKiwiSaver", EmitDefaultValue=false)]
        public bool? IsEligibleForKiwiSaver { get; set; }

        /// <summary>
        /// Employer superannuation contribution tax rate.
        /// </summary>
        /// <value>Employer superannuation contribution tax rate.</value>
        [DataMember(Name="esctRatePercentage", EmitDefaultValue=false)]
        public decimal? EsctRatePercentage { get; set; }

        /// <summary>
        /// Employee Contribution percentage.
        /// </summary>
        /// <value>Employee Contribution percentage.</value>
        [DataMember(Name="kiwiSaverEmployeeContributionRatePercentage", EmitDefaultValue=false)]
        public decimal? KiwiSaverEmployeeContributionRatePercentage { get; set; }

        /// <summary>
        /// Employer Contribution percentage.
        /// </summary>
        /// <value>Employer Contribution percentage.</value>
        [DataMember(Name="kiwiSaverEmployerContributionRatePercentage", EmitDefaultValue=false)]
        public decimal? KiwiSaverEmployerContributionRatePercentage { get; set; }

        /// <summary>
        /// Employer Contribution through Salary Sacrifice percentage.
        /// </summary>
        /// <value>Employer Contribution through Salary Sacrifice percentage.</value>
        [DataMember(Name="kiwiSaverEmployerSalarySacrificeContributionRatePercentage", EmitDefaultValue=false)]
        public decimal? KiwiSaverEmployerSalarySacrificeContributionRatePercentage { get; set; }

        /// <summary>
        /// Opt Out Date.
        /// </summary>
        /// <value>Opt Out Date.</value>
        [DataMember(Name="kiwiSaverOptOutDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? KiwiSaverOptOutDate { get; set; }

        /// <summary>
        /// Contribution holiday expiry date or end date.
        /// </summary>
        /// <value>Contribution holiday expiry date or end date.</value>
        [DataMember(Name="kiwiSaverContributionHolidayEndDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? KiwiSaverContributionHolidayEndDate { get; set; }

        /// <summary>
        /// Does the employee have a remaining student loan balance? Set a remaining balance if you have received a letter from IR.
        /// </summary>
        /// <value>Does the employee have a remaining student loan balance? Set a remaining balance if you have received a letter from IR.</value>
        [DataMember(Name="hasStudentLoanBalance", EmitDefaultValue=false)]
        public bool? HasStudentLoanBalance { get; set; }

        /// <summary>
        /// The employee&#39;s student loan balance shown on the letter from IR.
        /// </summary>
        /// <value>The employee&#39;s student loan balance shown on the letter from IR.</value>
        [DataMember(Name="studentLoanBalance", EmitDefaultValue=false)]
        public decimal? StudentLoanBalance { get; set; }

        /// <summary>
        /// The date of the letter from IR.
        /// </summary>
        /// <value>The date of the letter from IR.</value>
        [DataMember(Name="studentLoanAsAt", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? StudentLoanAsAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmployeeTax {\n");
            sb.Append("  IrdNumber: ").Append(IrdNumber).Append("\n");
            sb.Append("  TaxCode: ").Append(TaxCode).Append("\n");
            sb.Append("  SpecialTaxRatePercentage: ").Append(SpecialTaxRatePercentage).Append("\n");
            sb.Append("  HasSpecialStudentLoanRate: ").Append(HasSpecialStudentLoanRate).Append("\n");
            sb.Append("  SpecialStudentLoanRatePercentage: ").Append(SpecialStudentLoanRatePercentage).Append("\n");
            sb.Append("  IsEligibleForKiwiSaver: ").Append(IsEligibleForKiwiSaver).Append("\n");
            sb.Append("  EsctRatePercentage: ").Append(EsctRatePercentage).Append("\n");
            sb.Append("  KiwiSaverContributions: ").Append(KiwiSaverContributions).Append("\n");
            sb.Append("  KiwiSaverEmployeeContributionRatePercentage: ").Append(KiwiSaverEmployeeContributionRatePercentage).Append("\n");
            sb.Append("  KiwiSaverEmployerContributionRatePercentage: ").Append(KiwiSaverEmployerContributionRatePercentage).Append("\n");
            sb.Append("  KiwiSaverEmployerSalarySacrificeContributionRatePercentage: ").Append(KiwiSaverEmployerSalarySacrificeContributionRatePercentage).Append("\n");
            sb.Append("  KiwiSaverOptOutDate: ").Append(KiwiSaverOptOutDate).Append("\n");
            sb.Append("  KiwiSaverContributionHolidayEndDate: ").Append(KiwiSaverContributionHolidayEndDate).Append("\n");
            sb.Append("  HasStudentLoanBalance: ").Append(HasStudentLoanBalance).Append("\n");
            sb.Append("  StudentLoanBalance: ").Append(StudentLoanBalance).Append("\n");
            sb.Append("  StudentLoanAsAt: ").Append(StudentLoanAsAt).Append("\n");
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
            return this.Equals(input as EmployeeTax);
        }

        /// <summary>
        /// Returns true if EmployeeTax instances are equal
        /// </summary>
        /// <param name="input">Instance of EmployeeTax to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmployeeTax input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IrdNumber == input.IrdNumber ||
                    (this.IrdNumber != null &&
                    this.IrdNumber.Equals(input.IrdNumber))
                ) && 
                (
                    this.TaxCode == input.TaxCode ||
                    this.TaxCode.Equals(input.TaxCode)
                ) && 
                (
                    this.SpecialTaxRatePercentage == input.SpecialTaxRatePercentage ||
                    this.SpecialTaxRatePercentage.Equals(input.SpecialTaxRatePercentage)
                ) && 
                (
                    this.HasSpecialStudentLoanRate == input.HasSpecialStudentLoanRate ||
                    this.HasSpecialStudentLoanRate.Equals(input.HasSpecialStudentLoanRate)
                ) && 
                (
                    this.SpecialStudentLoanRatePercentage == input.SpecialStudentLoanRatePercentage ||
                    this.SpecialStudentLoanRatePercentage.Equals(input.SpecialStudentLoanRatePercentage)
                ) && 
                (
                    this.IsEligibleForKiwiSaver == input.IsEligibleForKiwiSaver ||
                    this.IsEligibleForKiwiSaver.Equals(input.IsEligibleForKiwiSaver)
                ) && 
                (
                    this.EsctRatePercentage == input.EsctRatePercentage ||
                    this.EsctRatePercentage.Equals(input.EsctRatePercentage)
                ) && 
                (
                    this.KiwiSaverContributions == input.KiwiSaverContributions ||
                    this.KiwiSaverContributions.Equals(input.KiwiSaverContributions)
                ) && 
                (
                    this.KiwiSaverEmployeeContributionRatePercentage == input.KiwiSaverEmployeeContributionRatePercentage ||
                    this.KiwiSaverEmployeeContributionRatePercentage.Equals(input.KiwiSaverEmployeeContributionRatePercentage)
                ) && 
                (
                    this.KiwiSaverEmployerContributionRatePercentage == input.KiwiSaverEmployerContributionRatePercentage ||
                    this.KiwiSaverEmployerContributionRatePercentage.Equals(input.KiwiSaverEmployerContributionRatePercentage)
                ) && 
                (
                    this.KiwiSaverEmployerSalarySacrificeContributionRatePercentage == input.KiwiSaverEmployerSalarySacrificeContributionRatePercentage ||
                    this.KiwiSaverEmployerSalarySacrificeContributionRatePercentage.Equals(input.KiwiSaverEmployerSalarySacrificeContributionRatePercentage)
                ) && 
                (
                    this.KiwiSaverOptOutDate == input.KiwiSaverOptOutDate ||
                    (this.KiwiSaverOptOutDate != null &&
                    this.KiwiSaverOptOutDate.Equals(input.KiwiSaverOptOutDate))
                ) && 
                (
                    this.KiwiSaverContributionHolidayEndDate == input.KiwiSaverContributionHolidayEndDate ||
                    (this.KiwiSaverContributionHolidayEndDate != null &&
                    this.KiwiSaverContributionHolidayEndDate.Equals(input.KiwiSaverContributionHolidayEndDate))
                ) && 
                (
                    this.HasStudentLoanBalance == input.HasStudentLoanBalance ||
                    this.HasStudentLoanBalance.Equals(input.HasStudentLoanBalance)
                ) && 
                (
                    this.StudentLoanBalance == input.StudentLoanBalance ||
                    this.StudentLoanBalance.Equals(input.StudentLoanBalance)
                ) && 
                (
                    this.StudentLoanAsAt == input.StudentLoanAsAt ||
                    (this.StudentLoanAsAt != null &&
                    this.StudentLoanAsAt.Equals(input.StudentLoanAsAt))
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
                if (this.IrdNumber != null)
                    hashCode = hashCode * 59 + this.IrdNumber.GetHashCode();
                hashCode = hashCode * 59 + this.TaxCode.GetHashCode();
                hashCode = hashCode * 59 + this.SpecialTaxRatePercentage.GetHashCode();
                hashCode = hashCode * 59 + this.HasSpecialStudentLoanRate.GetHashCode();
                hashCode = hashCode * 59 + this.SpecialStudentLoanRatePercentage.GetHashCode();
                hashCode = hashCode * 59 + this.IsEligibleForKiwiSaver.GetHashCode();
                hashCode = hashCode * 59 + this.EsctRatePercentage.GetHashCode();
                hashCode = hashCode * 59 + this.KiwiSaverContributions.GetHashCode();
                hashCode = hashCode * 59 + this.KiwiSaverEmployeeContributionRatePercentage.GetHashCode();
                hashCode = hashCode * 59 + this.KiwiSaverEmployerContributionRatePercentage.GetHashCode();
                hashCode = hashCode * 59 + this.KiwiSaverEmployerSalarySacrificeContributionRatePercentage.GetHashCode();
                if (this.KiwiSaverOptOutDate != null)
                    hashCode = hashCode * 59 + this.KiwiSaverOptOutDate.GetHashCode();
                if (this.KiwiSaverContributionHolidayEndDate != null)
                    hashCode = hashCode * 59 + this.KiwiSaverContributionHolidayEndDate.GetHashCode();
                hashCode = hashCode * 59 + this.HasStudentLoanBalance.GetHashCode();
                hashCode = hashCode * 59 + this.StudentLoanBalance.GetHashCode();
                if (this.StudentLoanAsAt != null)
                    hashCode = hashCode * 59 + this.StudentLoanAsAt.GetHashCode();
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
