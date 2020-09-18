/* 
 * Xero Payroll NZ
 *
 * This is the Xero Payroll API for orgs in the NZ region.
 *
 * The version of the OpenAPI document: 2.3.0
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
    /// LeaveAccrualLine
    /// </summary>
    [DataContract]
    public partial class LeaveAccrualLine :  IEquatable<LeaveAccrualLine>, IValidatableObject
    {
        
        /// <summary>
        /// Xero identifier for the Leave type
        /// </summary>
        /// <value>Xero identifier for the Leave type</value>
        [DataMember(Name="leaveTypeID", EmitDefaultValue=false)]
        public Guid? LeaveTypeID { get; set; }

        /// <summary>
        /// Leave accrual number of units
        /// </summary>
        /// <value>Leave accrual number of units</value>
        [DataMember(Name="numberOfUnits", EmitDefaultValue=false)]
        public double? NumberOfUnits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LeaveAccrualLine {\n");
            sb.Append("  LeaveTypeID: ").Append(LeaveTypeID).Append("\n");
            sb.Append("  NumberOfUnits: ").Append(NumberOfUnits).Append("\n");
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
            return this.Equals(input as LeaveAccrualLine);
        }

        /// <summary>
        /// Returns true if LeaveAccrualLine instances are equal
        /// </summary>
        /// <param name="input">Instance of LeaveAccrualLine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LeaveAccrualLine input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LeaveTypeID == input.LeaveTypeID ||
                    (this.LeaveTypeID != null &&
                    this.LeaveTypeID.Equals(input.LeaveTypeID))
                ) && 
                (
                    this.NumberOfUnits == input.NumberOfUnits ||
                    this.NumberOfUnits.Equals(input.NumberOfUnits)
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
                if (this.LeaveTypeID != null)
                    hashCode = hashCode * 59 + this.LeaveTypeID.GetHashCode();
                hashCode = hashCode * 59 + this.NumberOfUnits.GetHashCode();
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
