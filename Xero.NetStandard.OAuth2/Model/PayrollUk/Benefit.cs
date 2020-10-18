/* 
 * Xero Payroll UK
 *
 * This is the Xero Payroll API for orgs in the UK region.
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

namespace Xero.NetStandard.OAuth2.Model.PayrollUk
{
    /// <summary>
    /// Benefit
    /// </summary>
    [DataContract]
    public partial class Benefit :  IEquatable<Benefit>, IValidatableObject
    {
        /// <summary>
        /// Category type of the employer pension
        /// </summary>
        /// <value>Category type of the employer pension</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CategoryEnum
        {
            /// <summary>
            /// Enum StakeholderPension for value: StakeholderPension
            /// </summary>
            [EnumMember(Value = "StakeholderPension")]
            StakeholderPension = 1,

            /// <summary>
            /// Enum Other for value: Other
            /// </summary>
            [EnumMember(Value = "Other")]
            Other = 2

        }

        /// <summary>
        /// Category type of the employer pension
        /// </summary>
        /// <value>Category type of the employer pension</value>
        [DataMember(Name="category", EmitDefaultValue=false)]
        public CategoryEnum Category { get; set; }
        /// <summary>
        /// Calculation Type of the employer pension (FixedAmount or PercentageOfGross).
        /// </summary>
        /// <value>Calculation Type of the employer pension (FixedAmount or PercentageOfGross).</value>
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
        /// Calculation Type of the employer pension (FixedAmount or PercentageOfGross).
        /// </summary>
        /// <value>Calculation Type of the employer pension (FixedAmount or PercentageOfGross).</value>
        [DataMember(Name="calculationType", EmitDefaultValue=false)]
        public CalculationTypeEnum CalculationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Benefit" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Benefit() 
        { 
        }
        
        /// <summary>
        /// unique identifier in Xero
        /// </summary>
        /// <value>unique identifier in Xero</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Name of the employer pension
        /// </summary>
        /// <value>Name of the employer pension</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Xero identifier for Liability Account
        /// </summary>
        /// <value>Xero identifier for Liability Account</value>
        [DataMember(Name="liabilityAccountId", EmitDefaultValue=false)]
        public Guid? LiabilityAccountId { get; set; }

        /// <summary>
        /// Xero identifier for Expense Account
        /// </summary>
        /// <value>Xero identifier for Expense Account</value>
        [DataMember(Name="expenseAccountId", EmitDefaultValue=false)]
        public Guid? ExpenseAccountId { get; set; }

        /// <summary>
        /// Standard amount of the employer pension
        /// </summary>
        /// <value>Standard amount of the employer pension</value>
        [DataMember(Name="standardAmount", EmitDefaultValue=false)]
        public decimal? StandardAmount { get; set; }

        /// <summary>
        /// Percentage of gross of the employer pension
        /// </summary>
        /// <value>Percentage of gross of the employer pension</value>
        [DataMember(Name="percentage", EmitDefaultValue=false)]
        public decimal? Percentage { get; set; }

        /// <summary>
        /// Identifier of a record is active or not.
        /// </summary>
        /// <value>Identifier of a record is active or not.</value>
        [DataMember(Name="currentRecord", EmitDefaultValue=false)]
        public bool? CurrentRecord { get; set; }

        /// <summary>
        /// Identifier of subject To NIC
        /// </summary>
        /// <value>Identifier of subject To NIC</value>
        [DataMember(Name="subjectToNIC", EmitDefaultValue=false)]
        public bool? SubjectToNIC { get; set; }

        /// <summary>
        /// Identifier of subject To pension
        /// </summary>
        /// <value>Identifier of subject To pension</value>
        [DataMember(Name="subjectToPension", EmitDefaultValue=false)]
        public bool? SubjectToPension { get; set; }

        /// <summary>
        /// Identifier of subject To Tax
        /// </summary>
        /// <value>Identifier of subject To Tax</value>
        [DataMember(Name="subjectToTax", EmitDefaultValue=false)]
        public bool? SubjectToTax { get; set; }

        /// <summary>
        /// Identifier of calculating on qualifying earnings
        /// </summary>
        /// <value>Identifier of calculating on qualifying earnings</value>
        [DataMember(Name="isCalculatingOnQualifyingEarnings", EmitDefaultValue=false)]
        public bool? IsCalculatingOnQualifyingEarnings { get; set; }

        /// <summary>
        /// display the balance to employee
        /// </summary>
        /// <value>display the balance to employee</value>
        [DataMember(Name="showBalanceToEmployee", EmitDefaultValue=false)]
        public bool? ShowBalanceToEmployee { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Benefit {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  LiabilityAccountId: ").Append(LiabilityAccountId).Append("\n");
            sb.Append("  ExpenseAccountId: ").Append(ExpenseAccountId).Append("\n");
            sb.Append("  StandardAmount: ").Append(StandardAmount).Append("\n");
            sb.Append("  Percentage: ").Append(Percentage).Append("\n");
            sb.Append("  CalculationType: ").Append(CalculationType).Append("\n");
            sb.Append("  CurrentRecord: ").Append(CurrentRecord).Append("\n");
            sb.Append("  SubjectToNIC: ").Append(SubjectToNIC).Append("\n");
            sb.Append("  SubjectToPension: ").Append(SubjectToPension).Append("\n");
            sb.Append("  SubjectToTax: ").Append(SubjectToTax).Append("\n");
            sb.Append("  IsCalculatingOnQualifyingEarnings: ").Append(IsCalculatingOnQualifyingEarnings).Append("\n");
            sb.Append("  ShowBalanceToEmployee: ").Append(ShowBalanceToEmployee).Append("\n");
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
            return this.Equals(input as Benefit);
        }

        /// <summary>
        /// Returns true if Benefit instances are equal
        /// </summary>
        /// <param name="input">Instance of Benefit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Benefit input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Category == input.Category ||
                    this.Category.Equals(input.Category)
                ) && 
                (
                    this.LiabilityAccountId == input.LiabilityAccountId ||
                    (this.LiabilityAccountId != null &&
                    this.LiabilityAccountId.Equals(input.LiabilityAccountId))
                ) && 
                (
                    this.ExpenseAccountId == input.ExpenseAccountId ||
                    (this.ExpenseAccountId != null &&
                    this.ExpenseAccountId.Equals(input.ExpenseAccountId))
                ) && 
                (
                    this.StandardAmount == input.StandardAmount ||
                    this.StandardAmount.Equals(input.StandardAmount)
                ) && 
                (
                    this.Percentage == input.Percentage ||
                    this.Percentage.Equals(input.Percentage)
                ) && 
                (
                    this.CalculationType == input.CalculationType ||
                    this.CalculationType.Equals(input.CalculationType)
                ) && 
                (
                    this.CurrentRecord == input.CurrentRecord ||
                    this.CurrentRecord.Equals(input.CurrentRecord)
                ) && 
                (
                    this.SubjectToNIC == input.SubjectToNIC ||
                    this.SubjectToNIC.Equals(input.SubjectToNIC)
                ) && 
                (
                    this.SubjectToPension == input.SubjectToPension ||
                    this.SubjectToPension.Equals(input.SubjectToPension)
                ) && 
                (
                    this.SubjectToTax == input.SubjectToTax ||
                    this.SubjectToTax.Equals(input.SubjectToTax)
                ) && 
                (
                    this.IsCalculatingOnQualifyingEarnings == input.IsCalculatingOnQualifyingEarnings ||
                    this.IsCalculatingOnQualifyingEarnings.Equals(input.IsCalculatingOnQualifyingEarnings)
                ) && 
                (
                    this.ShowBalanceToEmployee == input.ShowBalanceToEmployee ||
                    this.ShowBalanceToEmployee.Equals(input.ShowBalanceToEmployee)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Category.GetHashCode();
                if (this.LiabilityAccountId != null)
                    hashCode = hashCode * 59 + this.LiabilityAccountId.GetHashCode();
                if (this.ExpenseAccountId != null)
                    hashCode = hashCode * 59 + this.ExpenseAccountId.GetHashCode();
                hashCode = hashCode * 59 + this.StandardAmount.GetHashCode();
                hashCode = hashCode * 59 + this.Percentage.GetHashCode();
                hashCode = hashCode * 59 + this.CalculationType.GetHashCode();
                hashCode = hashCode * 59 + this.CurrentRecord.GetHashCode();
                hashCode = hashCode * 59 + this.SubjectToNIC.GetHashCode();
                hashCode = hashCode * 59 + this.SubjectToPension.GetHashCode();
                hashCode = hashCode * 59 + this.SubjectToTax.GetHashCode();
                hashCode = hashCode * 59 + this.IsCalculatingOnQualifyingEarnings.GetHashCode();
                hashCode = hashCode * 59 + this.ShowBalanceToEmployee.GetHashCode();
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
