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
    /// StatutoryDeduction
    /// </summary>
    [DataContract]
    public partial class StatutoryDeduction :  IEquatable<StatutoryDeduction>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets StatutoryDeductionCategory
        /// </summary>
        [DataMember(Name="statutoryDeductionCategory", EmitDefaultValue=false)]
        public StatutoryDeductionCategory StatutoryDeductionCategory { get; set; }
        
        /// <summary>
        /// The Xero identifier for earnings order
        /// </summary>
        /// <value>The Xero identifier for earnings order</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Name of the earnings order
        /// </summary>
        /// <value>Name of the earnings order</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatutoryDeduction {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  StatutoryDeductionCategory: ").Append(StatutoryDeductionCategory).Append("\n");
            sb.Append("  LiabilityAccountId: ").Append(LiabilityAccountId).Append("\n");
            sb.Append("  CurrentRecord: ").Append(CurrentRecord).Append("\n");
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
            return this.Equals(input as StatutoryDeduction);
        }

        /// <summary>
        /// Returns true if StatutoryDeduction instances are equal
        /// </summary>
        /// <param name="input">Instance of StatutoryDeduction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatutoryDeduction input)
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
                    this.StatutoryDeductionCategory == input.StatutoryDeductionCategory ||
                    this.StatutoryDeductionCategory.Equals(input.StatutoryDeductionCategory)
                ) && 
                (
                    this.LiabilityAccountId == input.LiabilityAccountId ||
                    (this.LiabilityAccountId != null &&
                    this.LiabilityAccountId.Equals(input.LiabilityAccountId))
                ) && 
                (
                    this.CurrentRecord == input.CurrentRecord ||
                    this.CurrentRecord.Equals(input.CurrentRecord)
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
                hashCode = hashCode * 59 + this.StatutoryDeductionCategory.GetHashCode();
                if (this.LiabilityAccountId != null)
                    hashCode = hashCode * 59 + this.LiabilityAccountId.GetHashCode();
                hashCode = hashCode * 59 + this.CurrentRecord.GetHashCode();
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
