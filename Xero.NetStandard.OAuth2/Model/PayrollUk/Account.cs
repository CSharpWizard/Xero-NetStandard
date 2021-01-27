/* 
 * Xero Payroll UK
 *
 * This is the Xero Payroll API for orgs in the UK region.
 *
 * The version of the OpenAPI document: 2.8.3
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
    /// Account
    /// </summary>
    [DataContract]
    public partial class Account :  IEquatable<Account>, IValidatableObject
    {
        /// <summary>
        /// The assigned AccountType
        /// </summary>
        /// <value>The assigned AccountType</value>
        [JsonConverter(typeof(Client.CustomStringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum BANK for value: BANK
            /// </summary>
            [EnumMember(Value = "BANK")]
            BANK = 1,

            /// <summary>
            /// Enum EMPLOYERSNIC for value: EMPLOYERSNIC
            /// </summary>
            [EnumMember(Value = "EMPLOYERSNIC")]
            EMPLOYERSNIC = 2,

            /// <summary>
            /// Enum NICLIABILITY for value: NICLIABILITY
            /// </summary>
            [EnumMember(Value = "NICLIABILITY")]
            NICLIABILITY = 3,

            /// <summary>
            /// Enum PAYEECONTRIBUTION for value: PAYEECONTRIBUTION
            /// </summary>
            [EnumMember(Value = "PAYEECONTRIBUTION")]
            PAYEECONTRIBUTION = 4,

            /// <summary>
            /// Enum PAYELIABILITY for value: PAYELIABILITY
            /// </summary>
            [EnumMember(Value = "PAYELIABILITY")]
            PAYELIABILITY = 5,

            /// <summary>
            /// Enum WAGESPAYABLE for value: WAGESPAYABLE
            /// </summary>
            [EnumMember(Value = "WAGESPAYABLE")]
            WAGESPAYABLE = 6,

            /// <summary>
            /// Enum WAGESEXPENSE for value: WAGESEXPENSE
            /// </summary>
            [EnumMember(Value = "WAGESEXPENSE")]
            WAGESEXPENSE = 7

        }

        /// <summary>
        /// The assigned AccountType
        /// </summary>
        /// <value>The assigned AccountType</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        
        /// <summary>
        /// The Xero identifier for Settings.
        /// </summary>
        /// <value>The Xero identifier for Settings.</value>
        [DataMember(Name="accountID", EmitDefaultValue=false)]
        public Guid? AccountID { get; set; }

        /// <summary>
        /// A unique 3 digit number for each Account
        /// </summary>
        /// <value>A unique 3 digit number for each Account</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Name of the Account.
        /// </summary>
        /// <value>Name of the Account.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Account {\n");
            sb.Append("  AccountID: ").Append(AccountID).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as Account);
        }

        /// <summary>
        /// Returns true if Account instances are equal
        /// </summary>
        /// <param name="input">Instance of Account to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Account input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AccountID == input.AccountID ||
                    (this.AccountID != null &&
                    this.AccountID.Equals(input.AccountID))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.AccountID != null)
                    hashCode = hashCode * 59 + this.AccountID.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
