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
    /// EmployeeStatutoryLeaveBalance
    /// </summary>
    [DataContract]
    public partial class EmployeeStatutoryLeaveBalance :  IEquatable<EmployeeStatutoryLeaveBalance>, IValidatableObject
    {
        /// <summary>
        /// The type of statutory leave
        /// </summary>
        /// <value>The type of statutory leave</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LeaveTypeEnum
        {
            /// <summary>
            /// Enum Sick for value: Sick
            /// </summary>
            [EnumMember(Value = "Sick")]
            Sick = 1,

            /// <summary>
            /// Enum Adoption for value: Adoption
            /// </summary>
            [EnumMember(Value = "Adoption")]
            Adoption = 2,

            /// <summary>
            /// Enum Maternity for value: Maternity
            /// </summary>
            [EnumMember(Value = "Maternity")]
            Maternity = 3,

            /// <summary>
            /// Enum Paternity for value: Paternity
            /// </summary>
            [EnumMember(Value = "Paternity")]
            Paternity = 4,

            /// <summary>
            /// Enum Sharedparental for value: Sharedparental
            /// </summary>
            [EnumMember(Value = "Sharedparental")]
            Sharedparental = 5

        }

        /// <summary>
        /// The type of statutory leave
        /// </summary>
        /// <value>The type of statutory leave</value>
        [DataMember(Name="leaveType", EmitDefaultValue=false)]
        public LeaveTypeEnum LeaveType { get; set; }
        /// <summary>
        /// The units will be \&quot;Hours\&quot;
        /// </summary>
        /// <value>The units will be \&quot;Hours\&quot;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum UnitsEnum
        {
            /// <summary>
            /// Enum Hours for value: Hours
            /// </summary>
            [EnumMember(Value = "Hours")]
            Hours = 1

        }

        /// <summary>
        /// The units will be \&quot;Hours\&quot;
        /// </summary>
        /// <value>The units will be \&quot;Hours\&quot;</value>
        [DataMember(Name="units", EmitDefaultValue=false)]
        public UnitsEnum Units { get; set; }
        
        /// <summary>
        /// The balance remaining for the corresponding leave type as of specified date.
        /// </summary>
        /// <value>The balance remaining for the corresponding leave type as of specified date.</value>
        [DataMember(Name="balanceRemaining", EmitDefaultValue=false)]
        public double? BalanceRemaining { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmployeeStatutoryLeaveBalance {\n");
            sb.Append("  LeaveType: ").Append(LeaveType).Append("\n");
            sb.Append("  BalanceRemaining: ").Append(BalanceRemaining).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
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
            return this.Equals(input as EmployeeStatutoryLeaveBalance);
        }

        /// <summary>
        /// Returns true if EmployeeStatutoryLeaveBalance instances are equal
        /// </summary>
        /// <param name="input">Instance of EmployeeStatutoryLeaveBalance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmployeeStatutoryLeaveBalance input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LeaveType == input.LeaveType ||
                    this.LeaveType.Equals(input.LeaveType)
                ) && 
                (
                    this.BalanceRemaining == input.BalanceRemaining ||
                    this.BalanceRemaining.Equals(input.BalanceRemaining)
                ) && 
                (
                    this.Units == input.Units ||
                    this.Units.Equals(input.Units)
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
                hashCode = hashCode * 59 + this.LeaveType.GetHashCode();
                hashCode = hashCode * 59 + this.BalanceRemaining.GetHashCode();
                hashCode = hashCode * 59 + this.Units.GetHashCode();
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
