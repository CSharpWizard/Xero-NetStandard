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
    /// PayrollCalendar
    /// </summary>
    [DataContract]
    public partial class PayrollCalendar :  IEquatable<PayrollCalendar>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets CalendarType
        /// </summary>
        [DataMember(Name="CalendarType", EmitDefaultValue=false)]
        public CalendarType CalendarType { get; set; }
        
        /// <summary>
        /// Name of the Payroll Calendar
        /// </summary>
        /// <value>Name of the Payroll Calendar</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The start date of the upcoming pay period. The end date will be calculated based upon this date, and the calendar type selected (YYYY-MM-DD)
        /// </summary>
        /// <value>The start date of the upcoming pay period. The end date will be calculated based upon this date, and the calendar type selected (YYYY-MM-DD)</value>
        [DataMember(Name="StartDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The date on which employees will be paid for the upcoming pay period (YYYY-MM-DD)
        /// </summary>
        /// <value>The date on which employees will be paid for the upcoming pay period (YYYY-MM-DD)</value>
        [DataMember(Name="PaymentDate", EmitDefaultValue=false)]
        public DateTime? PaymentDate { get; set; }

        /// <summary>
        /// Xero identifier
        /// </summary>
        /// <value>Xero identifier</value>
        [DataMember(Name="PayrollCalendarID", EmitDefaultValue=false)]
        public Guid? PayrollCalendarID { get; set; }

        /// <summary>
        /// Last modified timestamp
        /// </summary>
        /// <value>Last modified timestamp</value>
        [DataMember(Name="UpdatedDateUTC", EmitDefaultValue=false)]
        public DateTime? UpdatedDateUTC { get; private set; }

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
            sb.Append("class PayrollCalendar {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CalendarType: ").Append(CalendarType).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  PaymentDate: ").Append(PaymentDate).Append("\n");
            sb.Append("  PayrollCalendarID: ").Append(PayrollCalendarID).Append("\n");
            sb.Append("  UpdatedDateUTC: ").Append(UpdatedDateUTC).Append("\n");
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
            return this.Equals(input as PayrollCalendar);
        }

        /// <summary>
        /// Returns true if PayrollCalendar instances are equal
        /// </summary>
        /// <param name="input">Instance of PayrollCalendar to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayrollCalendar input)
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
                    this.CalendarType == input.CalendarType ||
                    this.CalendarType.Equals(input.CalendarType)
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.PaymentDate == input.PaymentDate ||
                    (this.PaymentDate != null &&
                    this.PaymentDate.Equals(input.PaymentDate))
                ) && 
                (
                    this.PayrollCalendarID == input.PayrollCalendarID ||
                    (this.PayrollCalendarID != null &&
                    this.PayrollCalendarID.Equals(input.PayrollCalendarID))
                ) && 
                (
                    this.UpdatedDateUTC == input.UpdatedDateUTC ||
                    (this.UpdatedDateUTC != null &&
                    this.UpdatedDateUTC.Equals(input.UpdatedDateUTC))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.CalendarType.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.PaymentDate != null)
                    hashCode = hashCode * 59 + this.PaymentDate.GetHashCode();
                if (this.PayrollCalendarID != null)
                    hashCode = hashCode * 59 + this.PayrollCalendarID.GetHashCode();
                if (this.UpdatedDateUTC != null)
                    hashCode = hashCode * 59 + this.UpdatedDateUTC.GetHashCode();
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
