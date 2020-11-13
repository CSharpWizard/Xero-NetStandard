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
    /// EmployeeOpeningBalances
    /// </summary>
    [DataContract]
    public partial class EmployeeOpeningBalances :  IEquatable<EmployeeOpeningBalances>, IValidatableObject
    {
        
        /// <summary>
        /// The total accumulated statutory adoption pay amount received by the employee for current fiscal year to date
        /// </summary>
        /// <value>The total accumulated statutory adoption pay amount received by the employee for current fiscal year to date</value>
        [DataMember(Name="statutoryAdoptionPay", EmitDefaultValue=false)]
        public decimal? StatutoryAdoptionPay { get; set; }

        /// <summary>
        /// The total accumulated statutory maternity pay amount received by the employee for current fiscal year to date
        /// </summary>
        /// <value>The total accumulated statutory maternity pay amount received by the employee for current fiscal year to date</value>
        [DataMember(Name="statutoryMaternityPay", EmitDefaultValue=false)]
        public decimal? StatutoryMaternityPay { get; set; }

        /// <summary>
        /// The total accumulated statutory paternity pay amount received by the employee for current fiscal year to date
        /// </summary>
        /// <value>The total accumulated statutory paternity pay amount received by the employee for current fiscal year to date</value>
        [DataMember(Name="statutoryPaternityPay", EmitDefaultValue=false)]
        public decimal? StatutoryPaternityPay { get; set; }

        /// <summary>
        /// The total accumulated statutory shared parental pay amount received by the employee for current fiscal year to date
        /// </summary>
        /// <value>The total accumulated statutory shared parental pay amount received by the employee for current fiscal year to date</value>
        [DataMember(Name="statutorySharedParentalPay", EmitDefaultValue=false)]
        public decimal? StatutorySharedParentalPay { get; set; }

        /// <summary>
        /// The total accumulated statutory sick pay amount received by the employee for current fiscal year to date
        /// </summary>
        /// <value>The total accumulated statutory sick pay amount received by the employee for current fiscal year to date</value>
        [DataMember(Name="statutorySickPay", EmitDefaultValue=false)]
        public decimal? StatutorySickPay { get; set; }

        /// <summary>
        /// The unique employee number issued by the employee&#39;s former employer
        /// </summary>
        /// <value>The unique employee number issued by the employee&#39;s former employer</value>
        [DataMember(Name="priorEmployeeNumber", EmitDefaultValue=false)]
        public double? PriorEmployeeNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmployeeOpeningBalances {\n");
            sb.Append("  StatutoryAdoptionPay: ").Append(StatutoryAdoptionPay).Append("\n");
            sb.Append("  StatutoryMaternityPay: ").Append(StatutoryMaternityPay).Append("\n");
            sb.Append("  StatutoryPaternityPay: ").Append(StatutoryPaternityPay).Append("\n");
            sb.Append("  StatutorySharedParentalPay: ").Append(StatutorySharedParentalPay).Append("\n");
            sb.Append("  StatutorySickPay: ").Append(StatutorySickPay).Append("\n");
            sb.Append("  PriorEmployeeNumber: ").Append(PriorEmployeeNumber).Append("\n");
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
            return this.Equals(input as EmployeeOpeningBalances);
        }

        /// <summary>
        /// Returns true if EmployeeOpeningBalances instances are equal
        /// </summary>
        /// <param name="input">Instance of EmployeeOpeningBalances to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmployeeOpeningBalances input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StatutoryAdoptionPay == input.StatutoryAdoptionPay ||
                    this.StatutoryAdoptionPay.Equals(input.StatutoryAdoptionPay)
                ) && 
                (
                    this.StatutoryMaternityPay == input.StatutoryMaternityPay ||
                    this.StatutoryMaternityPay.Equals(input.StatutoryMaternityPay)
                ) && 
                (
                    this.StatutoryPaternityPay == input.StatutoryPaternityPay ||
                    this.StatutoryPaternityPay.Equals(input.StatutoryPaternityPay)
                ) && 
                (
                    this.StatutorySharedParentalPay == input.StatutorySharedParentalPay ||
                    this.StatutorySharedParentalPay.Equals(input.StatutorySharedParentalPay)
                ) && 
                (
                    this.StatutorySickPay == input.StatutorySickPay ||
                    this.StatutorySickPay.Equals(input.StatutorySickPay)
                ) && 
                (
                    this.PriorEmployeeNumber == input.PriorEmployeeNumber ||
                    this.PriorEmployeeNumber.Equals(input.PriorEmployeeNumber)
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
                hashCode = hashCode * 59 + this.StatutoryAdoptionPay.GetHashCode();
                hashCode = hashCode * 59 + this.StatutoryMaternityPay.GetHashCode();
                hashCode = hashCode * 59 + this.StatutoryPaternityPay.GetHashCode();
                hashCode = hashCode * 59 + this.StatutorySharedParentalPay.GetHashCode();
                hashCode = hashCode * 59 + this.StatutorySickPay.GetHashCode();
                hashCode = hashCode * 59 + this.PriorEmployeeNumber.GetHashCode();
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
