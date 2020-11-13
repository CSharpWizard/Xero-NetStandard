/* 
 * Xero Payroll UK
 *
 * This is the Xero Payroll API for orgs in the UK region.
 *
 * The version of the OpenAPI document: 2.4.4
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
    /// Deduction
    /// </summary>
    [DataContract]
    public partial class Deduction :  IEquatable<Deduction>, IValidatableObject
    {
        /// <summary>
        /// Deduction Category type
        /// </summary>
        /// <value>Deduction Category type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DeductionCategoryEnum
        {
            /// <summary>
            /// Enum CapitalContributions for value: CapitalContributions
            /// </summary>
            [EnumMember(Value = "CapitalContributions")]
            CapitalContributions = 1,

            /// <summary>
            /// Enum ChildCareVoucher for value: ChildCareVoucher
            /// </summary>
            [EnumMember(Value = "ChildCareVoucher")]
            ChildCareVoucher = 2,

            /// <summary>
            /// Enum MakingGood for value: MakingGood
            /// </summary>
            [EnumMember(Value = "MakingGood")]
            MakingGood = 3,

            /// <summary>
            /// Enum PostgraduateLoanDeductions for value: PostgraduateLoanDeductions
            /// </summary>
            [EnumMember(Value = "PostgraduateLoanDeductions")]
            PostgraduateLoanDeductions = 4,

            /// <summary>
            /// Enum PrivateUsePayments for value: PrivateUsePayments
            /// </summary>
            [EnumMember(Value = "PrivateUsePayments")]
            PrivateUsePayments = 5,

            /// <summary>
            /// Enum SalarySacrifice for value: SalarySacrifice
            /// </summary>
            [EnumMember(Value = "SalarySacrifice")]
            SalarySacrifice = 6,

            /// <summary>
            /// Enum StakeholderPension for value: StakeholderPension
            /// </summary>
            [EnumMember(Value = "StakeholderPension")]
            StakeholderPension = 7,

            /// <summary>
            /// Enum StakeholderPensionPostTax for value: StakeholderPensionPostTax
            /// </summary>
            [EnumMember(Value = "StakeholderPensionPostTax")]
            StakeholderPensionPostTax = 8,

            /// <summary>
            /// Enum StudentLoanDeductions for value: StudentLoanDeductions
            /// </summary>
            [EnumMember(Value = "StudentLoanDeductions")]
            StudentLoanDeductions = 9,

            /// <summary>
            /// Enum UkOther for value: UkOther
            /// </summary>
            [EnumMember(Value = "UkOther")]
            UkOther = 10

        }

        /// <summary>
        /// Deduction Category type
        /// </summary>
        /// <value>Deduction Category type</value>
        [DataMember(Name="deductionCategory", EmitDefaultValue=false)]
        public DeductionCategoryEnum DeductionCategory { get; set; }
        /// <summary>
        /// determine the calculation type whether fixed amount or percentage of gross
        /// </summary>
        /// <value>determine the calculation type whether fixed amount or percentage of gross</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CalculationTypeEnum
        {
            /// <summary>
            /// Enum FixedAmount for value: FixedAmount
            /// </summary>
            [EnumMember(Value = "FixedAmount")]
            FixedAmount = 1,

            /// <summary>
            /// Enum PercentageOfGross for value: PercentageOfGross
            /// </summary>
            [EnumMember(Value = "PercentageOfGross")]
            PercentageOfGross = 2

        }

        /// <summary>
        /// determine the calculation type whether fixed amount or percentage of gross
        /// </summary>
        /// <value>determine the calculation type whether fixed amount or percentage of gross</value>
        [DataMember(Name="calculationType", EmitDefaultValue=false)]
        public CalculationTypeEnum CalculationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Deduction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Deduction() 
        { 
        }
        
        /// <summary>
        /// The Xero identifier for Deduction
        /// </summary>
        /// <value>The Xero identifier for Deduction</value>
        [DataMember(Name="deductionId", EmitDefaultValue=false)]
        public Guid? DeductionId { get; set; }

        /// <summary>
        /// Name of the deduction
        /// </summary>
        /// <value>Name of the deduction</value>
        [DataMember(Name="deductionName", EmitDefaultValue=false)]
        public string DeductionName { get; set; }

        /// <summary>
        /// Xero identifier for Liability Account
        /// </summary>
        /// <value>Xero identifier for Liability Account</value>
        [DataMember(Name="liabilityAccountId", EmitDefaultValue=false)]
        public Guid? LiabilityAccountId { get; set; }

        /// <summary>
        /// Identifier of a record is active or not.
        /// </summary>
        /// <value>Identifier of a record is active or not.</value>
        [DataMember(Name="currentRecord", EmitDefaultValue=false)]
        public bool? CurrentRecord { get; set; }

        /// <summary>
        /// Standard amount of the deduction
        /// </summary>
        /// <value>Standard amount of the deduction</value>
        [DataMember(Name="standardAmount", EmitDefaultValue=false)]
        public decimal? StandardAmount { get; set; }

        /// <summary>
        /// Identifier of reduces super liability
        /// </summary>
        /// <value>Identifier of reduces super liability</value>
        [DataMember(Name="reducesSuperLiability", EmitDefaultValue=false)]
        public bool? ReducesSuperLiability { get; set; }

        /// <summary>
        /// Identifier of reduces tax liability
        /// </summary>
        /// <value>Identifier of reduces tax liability</value>
        [DataMember(Name="reducesTaxLiability", EmitDefaultValue=false)]
        public bool? ReducesTaxLiability { get; set; }

        /// <summary>
        /// Percentage of gross
        /// </summary>
        /// <value>Percentage of gross</value>
        [DataMember(Name="percentage", EmitDefaultValue=false)]
        public decimal? Percentage { get; set; }

        /// <summary>
        /// Identifier of subject To NIC
        /// </summary>
        /// <value>Identifier of subject To NIC</value>
        [DataMember(Name="subjectToNIC", EmitDefaultValue=false)]
        public bool? SubjectToNIC { get; set; }

        /// <summary>
        /// Identifier of subject To Tax
        /// </summary>
        /// <value>Identifier of subject To Tax</value>
        [DataMember(Name="subjectToTax", EmitDefaultValue=false)]
        public bool? SubjectToTax { get; set; }

        /// <summary>
        /// Identifier of reduced by basic rate applicable or not
        /// </summary>
        /// <value>Identifier of reduced by basic rate applicable or not</value>
        [DataMember(Name="isReducedByBasicRate", EmitDefaultValue=false)]
        public bool? IsReducedByBasicRate { get; set; }

        /// <summary>
        /// Identifier for apply to pension calculations
        /// </summary>
        /// <value>Identifier for apply to pension calculations</value>
        [DataMember(Name="applyToPensionCalculations", EmitDefaultValue=false)]
        public bool? ApplyToPensionCalculations { get; set; }

        /// <summary>
        /// Identifier of calculating on qualifying earnings
        /// </summary>
        /// <value>Identifier of calculating on qualifying earnings</value>
        [DataMember(Name="isCalculatingOnQualifyingEarnings", EmitDefaultValue=false)]
        public bool? IsCalculatingOnQualifyingEarnings { get; set; }

        /// <summary>
        /// Identifier of applicable for pension or not
        /// </summary>
        /// <value>Identifier of applicable for pension or not</value>
        [DataMember(Name="isPension", EmitDefaultValue=false)]
        public bool? IsPension { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Deduction {\n");
            sb.Append("  DeductionId: ").Append(DeductionId).Append("\n");
            sb.Append("  DeductionName: ").Append(DeductionName).Append("\n");
            sb.Append("  DeductionCategory: ").Append(DeductionCategory).Append("\n");
            sb.Append("  LiabilityAccountId: ").Append(LiabilityAccountId).Append("\n");
            sb.Append("  CurrentRecord: ").Append(CurrentRecord).Append("\n");
            sb.Append("  StandardAmount: ").Append(StandardAmount).Append("\n");
            sb.Append("  ReducesSuperLiability: ").Append(ReducesSuperLiability).Append("\n");
            sb.Append("  ReducesTaxLiability: ").Append(ReducesTaxLiability).Append("\n");
            sb.Append("  CalculationType: ").Append(CalculationType).Append("\n");
            sb.Append("  Percentage: ").Append(Percentage).Append("\n");
            sb.Append("  SubjectToNIC: ").Append(SubjectToNIC).Append("\n");
            sb.Append("  SubjectToTax: ").Append(SubjectToTax).Append("\n");
            sb.Append("  IsReducedByBasicRate: ").Append(IsReducedByBasicRate).Append("\n");
            sb.Append("  ApplyToPensionCalculations: ").Append(ApplyToPensionCalculations).Append("\n");
            sb.Append("  IsCalculatingOnQualifyingEarnings: ").Append(IsCalculatingOnQualifyingEarnings).Append("\n");
            sb.Append("  IsPension: ").Append(IsPension).Append("\n");
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
            return this.Equals(input as Deduction);
        }

        /// <summary>
        /// Returns true if Deduction instances are equal
        /// </summary>
        /// <param name="input">Instance of Deduction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Deduction input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DeductionId == input.DeductionId ||
                    (this.DeductionId != null &&
                    this.DeductionId.Equals(input.DeductionId))
                ) && 
                (
                    this.DeductionName == input.DeductionName ||
                    (this.DeductionName != null &&
                    this.DeductionName.Equals(input.DeductionName))
                ) && 
                (
                    this.DeductionCategory == input.DeductionCategory ||
                    this.DeductionCategory.Equals(input.DeductionCategory)
                ) && 
                (
                    this.LiabilityAccountId == input.LiabilityAccountId ||
                    (this.LiabilityAccountId != null &&
                    this.LiabilityAccountId.Equals(input.LiabilityAccountId))
                ) && 
                (
                    this.CurrentRecord == input.CurrentRecord ||
                    this.CurrentRecord.Equals(input.CurrentRecord)
                ) && 
                (
                    this.StandardAmount == input.StandardAmount ||
                    this.StandardAmount.Equals(input.StandardAmount)
                ) && 
                (
                    this.ReducesSuperLiability == input.ReducesSuperLiability ||
                    this.ReducesSuperLiability.Equals(input.ReducesSuperLiability)
                ) && 
                (
                    this.ReducesTaxLiability == input.ReducesTaxLiability ||
                    this.ReducesTaxLiability.Equals(input.ReducesTaxLiability)
                ) && 
                (
                    this.CalculationType == input.CalculationType ||
                    this.CalculationType.Equals(input.CalculationType)
                ) && 
                (
                    this.Percentage == input.Percentage ||
                    this.Percentage.Equals(input.Percentage)
                ) && 
                (
                    this.SubjectToNIC == input.SubjectToNIC ||
                    this.SubjectToNIC.Equals(input.SubjectToNIC)
                ) && 
                (
                    this.SubjectToTax == input.SubjectToTax ||
                    this.SubjectToTax.Equals(input.SubjectToTax)
                ) && 
                (
                    this.IsReducedByBasicRate == input.IsReducedByBasicRate ||
                    this.IsReducedByBasicRate.Equals(input.IsReducedByBasicRate)
                ) && 
                (
                    this.ApplyToPensionCalculations == input.ApplyToPensionCalculations ||
                    this.ApplyToPensionCalculations.Equals(input.ApplyToPensionCalculations)
                ) && 
                (
                    this.IsCalculatingOnQualifyingEarnings == input.IsCalculatingOnQualifyingEarnings ||
                    this.IsCalculatingOnQualifyingEarnings.Equals(input.IsCalculatingOnQualifyingEarnings)
                ) && 
                (
                    this.IsPension == input.IsPension ||
                    this.IsPension.Equals(input.IsPension)
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
                if (this.DeductionId != null)
                    hashCode = hashCode * 59 + this.DeductionId.GetHashCode();
                if (this.DeductionName != null)
                    hashCode = hashCode * 59 + this.DeductionName.GetHashCode();
                hashCode = hashCode * 59 + this.DeductionCategory.GetHashCode();
                if (this.LiabilityAccountId != null)
                    hashCode = hashCode * 59 + this.LiabilityAccountId.GetHashCode();
                hashCode = hashCode * 59 + this.CurrentRecord.GetHashCode();
                hashCode = hashCode * 59 + this.StandardAmount.GetHashCode();
                hashCode = hashCode * 59 + this.ReducesSuperLiability.GetHashCode();
                hashCode = hashCode * 59 + this.ReducesTaxLiability.GetHashCode();
                hashCode = hashCode * 59 + this.CalculationType.GetHashCode();
                hashCode = hashCode * 59 + this.Percentage.GetHashCode();
                hashCode = hashCode * 59 + this.SubjectToNIC.GetHashCode();
                hashCode = hashCode * 59 + this.SubjectToTax.GetHashCode();
                hashCode = hashCode * 59 + this.IsReducedByBasicRate.GetHashCode();
                hashCode = hashCode * 59 + this.ApplyToPensionCalculations.GetHashCode();
                hashCode = hashCode * 59 + this.IsCalculatingOnQualifyingEarnings.GetHashCode();
                hashCode = hashCode * 59 + this.IsPension.GetHashCode();
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
