/* 
 * Xero Payroll AU
 *
 * This is the Xero Payroll API for orgs in Australia region.
 *
 * The version of the OpenAPI document: 2.2.2
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
    /// PayRun
    /// </summary>
    [DataContract]
    public partial class PayRun :  IEquatable<PayRun>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets PayRunStatus
        /// </summary>
        [DataMember(Name="PayRunStatus", EmitDefaultValue=false)]
        public PayRunStatus PayRunStatus { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PayRun" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PayRun() 
        {  
          Payslips = new List<PayslipSummary>();  
          ValidationErrors = new List<ValidationError>(); 
        }
        
        /// <summary>
        /// Xero identifier for pay run
        /// </summary>
        /// <value>Xero identifier for pay run</value>
        [DataMember(Name="PayrollCalendarID", EmitDefaultValue=false)]
        public Guid? PayrollCalendarID { get; set; }

        /// <summary>
        /// Xero identifier for pay run
        /// </summary>
        /// <value>Xero identifier for pay run</value>
        [DataMember(Name="PayRunID", EmitDefaultValue=false)]
        public Guid? PayRunID { get; set; }

        /// <summary>
        /// Period Start Date for the PayRun (YYYY-MM-DD)
        /// </summary>
        /// <value>Period Start Date for the PayRun (YYYY-MM-DD)</value>
        [DataMember(Name="PayRunPeriodStartDate", EmitDefaultValue=false)]
        public DateTime? PayRunPeriodStartDate { get; set; }

        /// <summary>
        /// Period End Date for the PayRun (YYYY-MM-DD)
        /// </summary>
        /// <value>Period End Date for the PayRun (YYYY-MM-DD)</value>
        [DataMember(Name="PayRunPeriodEndDate", EmitDefaultValue=false)]
        public DateTime? PayRunPeriodEndDate { get; set; }

        /// <summary>
        /// Payment Date for the PayRun (YYYY-MM-DD)
        /// </summary>
        /// <value>Payment Date for the PayRun (YYYY-MM-DD)</value>
        [DataMember(Name="PaymentDate", EmitDefaultValue=false)]
        public DateTime? PaymentDate { get; set; }

        /// <summary>
        /// Payslip message for the PayRun
        /// </summary>
        /// <value>Payslip message for the PayRun</value>
        [DataMember(Name="PayslipMessage", EmitDefaultValue=false)]
        public string PayslipMessage { get; set; }

        /// <summary>
        /// Last modified timestamp
        /// </summary>
        /// <value>Last modified timestamp</value>
        [DataMember(Name="UpdatedDateUTC", EmitDefaultValue=false)]
        public DateTime? UpdatedDateUTC { get; private set; }

        /// <summary>
        /// The payslips in the payrun
        /// </summary>
        /// <value>The payslips in the payrun</value>
        [DataMember(Name="Payslips", EmitDefaultValue=false)]
        public List<PayslipSummary> Payslips { get; set; }

        /// <summary>
        /// The total Wages for the Payrun
        /// </summary>
        /// <value>The total Wages for the Payrun</value>
        [DataMember(Name="Wages", EmitDefaultValue=false)]
        public decimal? Wages { get; set; }

        /// <summary>
        /// The total Deductions for the Payrun
        /// </summary>
        /// <value>The total Deductions for the Payrun</value>
        [DataMember(Name="Deductions", EmitDefaultValue=false)]
        public decimal? Deductions { get; set; }

        /// <summary>
        /// The total Tax for the Payrun
        /// </summary>
        /// <value>The total Tax for the Payrun</value>
        [DataMember(Name="Tax", EmitDefaultValue=false)]
        public decimal? Tax { get; set; }

        /// <summary>
        /// The total Super for the Payrun
        /// </summary>
        /// <value>The total Super for the Payrun</value>
        [DataMember(Name="Super", EmitDefaultValue=false)]
        public decimal? Super { get; set; }

        /// <summary>
        /// The total Reimbursements for the Payrun
        /// </summary>
        /// <value>The total Reimbursements for the Payrun</value>
        [DataMember(Name="Reimbursement", EmitDefaultValue=false)]
        public decimal? Reimbursement { get; set; }

        /// <summary>
        /// The total NetPay for the Payrun
        /// </summary>
        /// <value>The total NetPay for the Payrun</value>
        [DataMember(Name="NetPay", EmitDefaultValue=false)]
        public decimal? NetPay { get; set; }

        /// <summary>
        /// Displays array of validation error messages from the API
        /// </summary>
        /// <value>Displays array of validation error messages from the API</value>
        [DataMember(Name="ValidationErrors", EmitDefaultValue=false)]
        public List<ValidationError> ValidationErrors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayRun {\n");
            sb.Append("  PayrollCalendarID: ").Append(PayrollCalendarID).Append("\n");
            sb.Append("  PayRunID: ").Append(PayRunID).Append("\n");
            sb.Append("  PayRunPeriodStartDate: ").Append(PayRunPeriodStartDate).Append("\n");
            sb.Append("  PayRunPeriodEndDate: ").Append(PayRunPeriodEndDate).Append("\n");
            sb.Append("  PayRunStatus: ").Append(PayRunStatus).Append("\n");
            sb.Append("  PaymentDate: ").Append(PaymentDate).Append("\n");
            sb.Append("  PayslipMessage: ").Append(PayslipMessage).Append("\n");
            sb.Append("  UpdatedDateUTC: ").Append(UpdatedDateUTC).Append("\n");
            sb.Append("  Payslips: ").Append(Payslips).Append("\n");
            sb.Append("  Wages: ").Append(Wages).Append("\n");
            sb.Append("  Deductions: ").Append(Deductions).Append("\n");
            sb.Append("  Tax: ").Append(Tax).Append("\n");
            sb.Append("  Super: ").Append(Super).Append("\n");
            sb.Append("  Reimbursement: ").Append(Reimbursement).Append("\n");
            sb.Append("  NetPay: ").Append(NetPay).Append("\n");
            sb.Append("  ValidationErrors: ").Append(ValidationErrors).Append("\n");
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
            return this.Equals(input as PayRun);
        }

        /// <summary>
        /// Returns true if PayRun instances are equal
        /// </summary>
        /// <param name="input">Instance of PayRun to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayRun input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PayrollCalendarID == input.PayrollCalendarID ||
                    (this.PayrollCalendarID != null &&
                    this.PayrollCalendarID.Equals(input.PayrollCalendarID))
                ) && 
                (
                    this.PayRunID == input.PayRunID ||
                    (this.PayRunID != null &&
                    this.PayRunID.Equals(input.PayRunID))
                ) && 
                (
                    this.PayRunPeriodStartDate == input.PayRunPeriodStartDate ||
                    (this.PayRunPeriodStartDate != null &&
                    this.PayRunPeriodStartDate.Equals(input.PayRunPeriodStartDate))
                ) && 
                (
                    this.PayRunPeriodEndDate == input.PayRunPeriodEndDate ||
                    (this.PayRunPeriodEndDate != null &&
                    this.PayRunPeriodEndDate.Equals(input.PayRunPeriodEndDate))
                ) && 
                (
                    this.PayRunStatus == input.PayRunStatus ||
                    this.PayRunStatus.Equals(input.PayRunStatus)
                ) && 
                (
                    this.PaymentDate == input.PaymentDate ||
                    (this.PaymentDate != null &&
                    this.PaymentDate.Equals(input.PaymentDate))
                ) && 
                (
                    this.PayslipMessage == input.PayslipMessage ||
                    (this.PayslipMessage != null &&
                    this.PayslipMessage.Equals(input.PayslipMessage))
                ) && 
                (
                    this.UpdatedDateUTC == input.UpdatedDateUTC ||
                    (this.UpdatedDateUTC != null &&
                    this.UpdatedDateUTC.Equals(input.UpdatedDateUTC))
                ) && 
                (
                    this.Payslips == input.Payslips ||
                    this.Payslips != null &&
                    input.Payslips != null &&
                    this.Payslips.SequenceEqual(input.Payslips)
                ) && 
                (
                    this.Wages == input.Wages ||
                    this.Wages.Equals(input.Wages)
                ) && 
                (
                    this.Deductions == input.Deductions ||
                    this.Deductions.Equals(input.Deductions)
                ) && 
                (
                    this.Tax == input.Tax ||
                    this.Tax.Equals(input.Tax)
                ) && 
                (
                    this.Super == input.Super ||
                    this.Super.Equals(input.Super)
                ) && 
                (
                    this.Reimbursement == input.Reimbursement ||
                    this.Reimbursement.Equals(input.Reimbursement)
                ) && 
                (
                    this.NetPay == input.NetPay ||
                    this.NetPay.Equals(input.NetPay)
                ) && 
                (
                    this.ValidationErrors == input.ValidationErrors ||
                    this.ValidationErrors != null &&
                    input.ValidationErrors != null &&
                    this.ValidationErrors.SequenceEqual(input.ValidationErrors)
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
                if (this.PayrollCalendarID != null)
                    hashCode = hashCode * 59 + this.PayrollCalendarID.GetHashCode();
                if (this.PayRunID != null)
                    hashCode = hashCode * 59 + this.PayRunID.GetHashCode();
                if (this.PayRunPeriodStartDate != null)
                    hashCode = hashCode * 59 + this.PayRunPeriodStartDate.GetHashCode();
                if (this.PayRunPeriodEndDate != null)
                    hashCode = hashCode * 59 + this.PayRunPeriodEndDate.GetHashCode();
                hashCode = hashCode * 59 + this.PayRunStatus.GetHashCode();
                if (this.PaymentDate != null)
                    hashCode = hashCode * 59 + this.PaymentDate.GetHashCode();
                if (this.PayslipMessage != null)
                    hashCode = hashCode * 59 + this.PayslipMessage.GetHashCode();
                if (this.UpdatedDateUTC != null)
                    hashCode = hashCode * 59 + this.UpdatedDateUTC.GetHashCode();
                if (this.Payslips != null)
                    hashCode = hashCode * 59 + this.Payslips.GetHashCode();
                hashCode = hashCode * 59 + this.Wages.GetHashCode();
                hashCode = hashCode * 59 + this.Deductions.GetHashCode();
                hashCode = hashCode * 59 + this.Tax.GetHashCode();
                hashCode = hashCode * 59 + this.Super.GetHashCode();
                hashCode = hashCode * 59 + this.Reimbursement.GetHashCode();
                hashCode = hashCode * 59 + this.NetPay.GetHashCode();
                if (this.ValidationErrors != null)
                    hashCode = hashCode * 59 + this.ValidationErrors.GetHashCode();
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
