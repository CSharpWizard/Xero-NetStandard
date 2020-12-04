/* 
 * Xero Payroll UK
 *
 * This is the Xero Payroll API for orgs in the UK region.
 *
 * The version of the OpenAPI document: 2.6.0
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
    /// Reimbursement
    /// </summary>
    [DataContract]
    public partial class Reimbursement :  IEquatable<Reimbursement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Reimbursement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Reimbursement() 
        { 
        }
        
        /// <summary>
        /// Xero unique identifier for a reimbursement
        /// </summary>
        /// <value>Xero unique identifier for a reimbursement</value>
        [DataMember(Name="reimbursementID", EmitDefaultValue=false)]
        public Guid? ReimbursementID { get; set; }

        /// <summary>
        /// Name of the reimbursement
        /// </summary>
        /// <value>Name of the reimbursement</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Xero unique identifier for the account used for the reimbursement
        /// </summary>
        /// <value>Xero unique identifier for the account used for the reimbursement</value>
        [DataMember(Name="accountID", EmitDefaultValue=false)]
        public Guid? AccountID { get; set; }

        /// <summary>
        /// Indicates that whether the reimbursement is active
        /// </summary>
        /// <value>Indicates that whether the reimbursement is active</value>
        [DataMember(Name="currentRecord", EmitDefaultValue=false)]
        public bool? CurrentRecord { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Reimbursement {\n");
            sb.Append("  ReimbursementID: ").Append(ReimbursementID).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AccountID: ").Append(AccountID).Append("\n");
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
            return this.Equals(input as Reimbursement);
        }

        /// <summary>
        /// Returns true if Reimbursement instances are equal
        /// </summary>
        /// <param name="input">Instance of Reimbursement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Reimbursement input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReimbursementID == input.ReimbursementID ||
                    (this.ReimbursementID != null &&
                    this.ReimbursementID.Equals(input.ReimbursementID))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.AccountID == input.AccountID ||
                    (this.AccountID != null &&
                    this.AccountID.Equals(input.AccountID))
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
                if (this.ReimbursementID != null)
                    hashCode = hashCode * 59 + this.ReimbursementID.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AccountID != null)
                    hashCode = hashCode * 59 + this.AccountID.GetHashCode();
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
