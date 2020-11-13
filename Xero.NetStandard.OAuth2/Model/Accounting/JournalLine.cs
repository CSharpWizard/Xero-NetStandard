/* 
 * Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
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

namespace Xero.NetStandard.OAuth2.Model.Accounting
{
    /// <summary>
    /// JournalLine
    /// </summary>
    [DataContract]
    public partial class JournalLine :  IEquatable<JournalLine>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets AccountType
        /// </summary>
        [DataMember(Name="AccountType", EmitDefaultValue=false)]
        public AccountType AccountType { get; set; }
        
        /// <summary>
        /// Xero identifier for Journal
        /// </summary>
        /// <value>Xero identifier for Journal</value>
        [DataMember(Name="JournalLineID", EmitDefaultValue=false)]
        public Guid? JournalLineID { get; set; }

        /// <summary>
        /// See Accounts
        /// </summary>
        /// <value>See Accounts</value>
        [DataMember(Name="AccountID", EmitDefaultValue=false)]
        public Guid? AccountID { get; set; }

        /// <summary>
        /// See Accounts
        /// </summary>
        /// <value>See Accounts</value>
        [DataMember(Name="AccountCode", EmitDefaultValue=false)]
        public string AccountCode { get; set; }

        /// <summary>
        /// See AccountCodes
        /// </summary>
        /// <value>See AccountCodes</value>
        [DataMember(Name="AccountName", EmitDefaultValue=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// The description from the source transaction line item. Only returned if populated.
        /// </summary>
        /// <value>The description from the source transaction line item. Only returned if populated.</value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Net amount of journal line. This will be a positive value for a debit and negative for a credit
        /// </summary>
        /// <value>Net amount of journal line. This will be a positive value for a debit and negative for a credit</value>
        [DataMember(Name="NetAmount", EmitDefaultValue=false)]
        public decimal? NetAmount { get; set; }

        /// <summary>
        /// Gross amount of journal line (NetAmount + TaxAmount).
        /// </summary>
        /// <value>Gross amount of journal line (NetAmount + TaxAmount).</value>
        [DataMember(Name="GrossAmount", EmitDefaultValue=false)]
        public decimal? GrossAmount { get; set; }

        /// <summary>
        /// Total tax on a journal line
        /// </summary>
        /// <value>Total tax on a journal line</value>
        [DataMember(Name="TaxAmount", EmitDefaultValue=false)]
        public decimal? TaxAmount { get; private set; }

        /// <summary>
        /// The tax type from TaxRates
        /// </summary>
        /// <value>The tax type from TaxRates</value>
        [DataMember(Name="TaxType", EmitDefaultValue=false)]
        public string TaxType { get; set; }

        /// <summary>
        /// see TaxRates
        /// </summary>
        /// <value>see TaxRates</value>
        [DataMember(Name="TaxName", EmitDefaultValue=false)]
        public string TaxName { get; set; }

        /// <summary>
        /// Optional Tracking Category – see Tracking. Any JournalLine can have a maximum of 2 &lt;TrackingCategory&gt; elements.
        /// </summary>
        /// <value>Optional Tracking Category – see Tracking. Any JournalLine can have a maximum of 2 &lt;TrackingCategory&gt; elements.</value>
        [DataMember(Name="TrackingCategories", EmitDefaultValue=false)]
        public List<TrackingCategory> TrackingCategories { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JournalLine {\n");
            sb.Append("  JournalLineID: ").Append(JournalLineID).Append("\n");
            sb.Append("  AccountID: ").Append(AccountID).Append("\n");
            sb.Append("  AccountCode: ").Append(AccountCode).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  NetAmount: ").Append(NetAmount).Append("\n");
            sb.Append("  GrossAmount: ").Append(GrossAmount).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  TaxType: ").Append(TaxType).Append("\n");
            sb.Append("  TaxName: ").Append(TaxName).Append("\n");
            sb.Append("  TrackingCategories: ").Append(TrackingCategories).Append("\n");
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
            return this.Equals(input as JournalLine);
        }

        /// <summary>
        /// Returns true if JournalLine instances are equal
        /// </summary>
        /// <param name="input">Instance of JournalLine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JournalLine input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JournalLineID == input.JournalLineID ||
                    (this.JournalLineID != null &&
                    this.JournalLineID.Equals(input.JournalLineID))
                ) && 
                (
                    this.AccountID == input.AccountID ||
                    (this.AccountID != null &&
                    this.AccountID.Equals(input.AccountID))
                ) && 
                (
                    this.AccountCode == input.AccountCode ||
                    (this.AccountCode != null &&
                    this.AccountCode.Equals(input.AccountCode))
                ) && 
                (
                    this.AccountType == input.AccountType ||
                    this.AccountType.Equals(input.AccountType)
                ) && 
                (
                    this.AccountName == input.AccountName ||
                    (this.AccountName != null &&
                    this.AccountName.Equals(input.AccountName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.NetAmount == input.NetAmount ||
                    this.NetAmount.Equals(input.NetAmount)
                ) && 
                (
                    this.GrossAmount == input.GrossAmount ||
                    this.GrossAmount.Equals(input.GrossAmount)
                ) && 
                (
                    this.TaxAmount == input.TaxAmount ||
                    this.TaxAmount.Equals(input.TaxAmount)
                ) && 
                (
                    this.TaxType == input.TaxType ||
                    (this.TaxType != null &&
                    this.TaxType.Equals(input.TaxType))
                ) && 
                (
                    this.TaxName == input.TaxName ||
                    (this.TaxName != null &&
                    this.TaxName.Equals(input.TaxName))
                ) && 
                (
                    this.TrackingCategories == input.TrackingCategories ||
                    this.TrackingCategories != null &&
                    input.TrackingCategories != null &&
                    this.TrackingCategories.SequenceEqual(input.TrackingCategories)
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
                if (this.JournalLineID != null)
                    hashCode = hashCode * 59 + this.JournalLineID.GetHashCode();
                if (this.AccountID != null)
                    hashCode = hashCode * 59 + this.AccountID.GetHashCode();
                if (this.AccountCode != null)
                    hashCode = hashCode * 59 + this.AccountCode.GetHashCode();
                hashCode = hashCode * 59 + this.AccountType.GetHashCode();
                if (this.AccountName != null)
                    hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.NetAmount.GetHashCode();
                hashCode = hashCode * 59 + this.GrossAmount.GetHashCode();
                hashCode = hashCode * 59 + this.TaxAmount.GetHashCode();
                if (this.TaxType != null)
                    hashCode = hashCode * 59 + this.TaxType.GetHashCode();
                if (this.TaxName != null)
                    hashCode = hashCode * 59 + this.TaxName.GetHashCode();
                if (this.TrackingCategories != null)
                    hashCode = hashCode * 59 + this.TrackingCategories.GetHashCode();
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
