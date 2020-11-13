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
    /// Journal
    /// </summary>
    [DataContract]
    public partial class Journal :  IEquatable<Journal>, IValidatableObject
    {
        /// <summary>
        /// The journal source type. The type of transaction that created the journal
        /// </summary>
        /// <value>The journal source type. The type of transaction that created the journal</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SourceTypeEnum
        {
            /// <summary>
            /// Enum ACCREC for value: ACCREC
            /// </summary>
            [EnumMember(Value = "ACCREC")]
            ACCREC = 1,

            /// <summary>
            /// Enum ACCPAY for value: ACCPAY
            /// </summary>
            [EnumMember(Value = "ACCPAY")]
            ACCPAY = 2,

            /// <summary>
            /// Enum ACCRECCREDIT for value: ACCRECCREDIT
            /// </summary>
            [EnumMember(Value = "ACCRECCREDIT")]
            ACCRECCREDIT = 3,

            /// <summary>
            /// Enum ACCPAYCREDIT for value: ACCPAYCREDIT
            /// </summary>
            [EnumMember(Value = "ACCPAYCREDIT")]
            ACCPAYCREDIT = 4,

            /// <summary>
            /// Enum ACCRECPAYMENT for value: ACCRECPAYMENT
            /// </summary>
            [EnumMember(Value = "ACCRECPAYMENT")]
            ACCRECPAYMENT = 5,

            /// <summary>
            /// Enum ACCPAYPAYMENT for value: ACCPAYPAYMENT
            /// </summary>
            [EnumMember(Value = "ACCPAYPAYMENT")]
            ACCPAYPAYMENT = 6,

            /// <summary>
            /// Enum ARCREDITPAYMENT for value: ARCREDITPAYMENT
            /// </summary>
            [EnumMember(Value = "ARCREDITPAYMENT")]
            ARCREDITPAYMENT = 7,

            /// <summary>
            /// Enum APCREDITPAYMENT for value: APCREDITPAYMENT
            /// </summary>
            [EnumMember(Value = "APCREDITPAYMENT")]
            APCREDITPAYMENT = 8,

            /// <summary>
            /// Enum CASHREC for value: CASHREC
            /// </summary>
            [EnumMember(Value = "CASHREC")]
            CASHREC = 9,

            /// <summary>
            /// Enum CASHPAID for value: CASHPAID
            /// </summary>
            [EnumMember(Value = "CASHPAID")]
            CASHPAID = 10,

            /// <summary>
            /// Enum TRANSFER for value: TRANSFER
            /// </summary>
            [EnumMember(Value = "TRANSFER")]
            TRANSFER = 11,

            /// <summary>
            /// Enum ARPREPAYMENT for value: ARPREPAYMENT
            /// </summary>
            [EnumMember(Value = "ARPREPAYMENT")]
            ARPREPAYMENT = 12,

            /// <summary>
            /// Enum APPREPAYMENT for value: APPREPAYMENT
            /// </summary>
            [EnumMember(Value = "APPREPAYMENT")]
            APPREPAYMENT = 13,

            /// <summary>
            /// Enum AROVERPAYMENT for value: AROVERPAYMENT
            /// </summary>
            [EnumMember(Value = "AROVERPAYMENT")]
            AROVERPAYMENT = 14,

            /// <summary>
            /// Enum APOVERPAYMENT for value: APOVERPAYMENT
            /// </summary>
            [EnumMember(Value = "APOVERPAYMENT")]
            APOVERPAYMENT = 15,

            /// <summary>
            /// Enum EXPCLAIM for value: EXPCLAIM
            /// </summary>
            [EnumMember(Value = "EXPCLAIM")]
            EXPCLAIM = 16,

            /// <summary>
            /// Enum EXPPAYMENT for value: EXPPAYMENT
            /// </summary>
            [EnumMember(Value = "EXPPAYMENT")]
            EXPPAYMENT = 17,

            /// <summary>
            /// Enum MANJOURNAL for value: MANJOURNAL
            /// </summary>
            [EnumMember(Value = "MANJOURNAL")]
            MANJOURNAL = 18,

            /// <summary>
            /// Enum PAYSLIP for value: PAYSLIP
            /// </summary>
            [EnumMember(Value = "PAYSLIP")]
            PAYSLIP = 19,

            /// <summary>
            /// Enum WAGEPAYABLE for value: WAGEPAYABLE
            /// </summary>
            [EnumMember(Value = "WAGEPAYABLE")]
            WAGEPAYABLE = 20,

            /// <summary>
            /// Enum INTEGRATEDPAYROLLPE for value: INTEGRATEDPAYROLLPE
            /// </summary>
            [EnumMember(Value = "INTEGRATEDPAYROLLPE")]
            INTEGRATEDPAYROLLPE = 21,

            /// <summary>
            /// Enum INTEGRATEDPAYROLLPT for value: INTEGRATEDPAYROLLPT
            /// </summary>
            [EnumMember(Value = "INTEGRATEDPAYROLLPT")]
            INTEGRATEDPAYROLLPT = 22,

            /// <summary>
            /// Enum EXTERNALSPENDMONEY for value: EXTERNALSPENDMONEY
            /// </summary>
            [EnumMember(Value = "EXTERNALSPENDMONEY")]
            EXTERNALSPENDMONEY = 23,

            /// <summary>
            /// Enum INTEGRATEDPAYROLLPTPAYMENT for value: INTEGRATEDPAYROLLPTPAYMENT
            /// </summary>
            [EnumMember(Value = "INTEGRATEDPAYROLLPTPAYMENT")]
            INTEGRATEDPAYROLLPTPAYMENT = 24,

            /// <summary>
            /// Enum INTEGRATEDPAYROLLCN for value: INTEGRATEDPAYROLLCN
            /// </summary>
            [EnumMember(Value = "INTEGRATEDPAYROLLCN")]
            INTEGRATEDPAYROLLCN = 25

        }

        /// <summary>
        /// The journal source type. The type of transaction that created the journal
        /// </summary>
        /// <value>The journal source type. The type of transaction that created the journal</value>
        [DataMember(Name="SourceType", EmitDefaultValue=false)]
        public SourceTypeEnum SourceType { get; set; }
        
        /// <summary>
        /// Xero identifier
        /// </summary>
        /// <value>Xero identifier</value>
        [DataMember(Name="JournalID", EmitDefaultValue=false)]
        public Guid? JournalID { get; set; }

        /// <summary>
        /// Date the journal was posted
        /// </summary>
        /// <value>Date the journal was posted</value>
        [DataMember(Name="JournalDate", EmitDefaultValue=false)]
        public DateTime? JournalDate { get; set; }

        /// <summary>
        /// Xero generated journal number
        /// </summary>
        /// <value>Xero generated journal number</value>
        [DataMember(Name="JournalNumber", EmitDefaultValue=false)]
        public int? JournalNumber { get; set; }

        /// <summary>
        /// Created date UTC format
        /// </summary>
        /// <value>Created date UTC format</value>
        [DataMember(Name="CreatedDateUTC", EmitDefaultValue=false)]
        public DateTime? CreatedDateUTC { get; private set; }

        /// <summary>
        /// reference field for additional indetifying information
        /// </summary>
        /// <value>reference field for additional indetifying information</value>
        [DataMember(Name="Reference", EmitDefaultValue=false)]
        public string Reference { get; set; }

        /// <summary>
        /// The identifier for the source transaction (e.g. InvoiceID)
        /// </summary>
        /// <value>The identifier for the source transaction (e.g. InvoiceID)</value>
        [DataMember(Name="SourceID", EmitDefaultValue=false)]
        public Guid? SourceID { get; set; }

        /// <summary>
        /// See JournalLines
        /// </summary>
        /// <value>See JournalLines</value>
        [DataMember(Name="JournalLines", EmitDefaultValue=false)]
        public List<JournalLine> JournalLines { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Journal {\n");
            sb.Append("  JournalID: ").Append(JournalID).Append("\n");
            sb.Append("  JournalDate: ").Append(JournalDate).Append("\n");
            sb.Append("  JournalNumber: ").Append(JournalNumber).Append("\n");
            sb.Append("  CreatedDateUTC: ").Append(CreatedDateUTC).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  SourceID: ").Append(SourceID).Append("\n");
            sb.Append("  SourceType: ").Append(SourceType).Append("\n");
            sb.Append("  JournalLines: ").Append(JournalLines).Append("\n");
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
            return this.Equals(input as Journal);
        }

        /// <summary>
        /// Returns true if Journal instances are equal
        /// </summary>
        /// <param name="input">Instance of Journal to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Journal input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.JournalID == input.JournalID ||
                    (this.JournalID != null &&
                    this.JournalID.Equals(input.JournalID))
                ) && 
                (
                    this.JournalDate == input.JournalDate ||
                    (this.JournalDate != null &&
                    this.JournalDate.Equals(input.JournalDate))
                ) && 
                (
                    this.JournalNumber == input.JournalNumber ||
                    this.JournalNumber.Equals(input.JournalNumber)
                ) && 
                (
                    this.CreatedDateUTC == input.CreatedDateUTC ||
                    (this.CreatedDateUTC != null &&
                    this.CreatedDateUTC.Equals(input.CreatedDateUTC))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.SourceID == input.SourceID ||
                    (this.SourceID != null &&
                    this.SourceID.Equals(input.SourceID))
                ) && 
                (
                    this.SourceType == input.SourceType ||
                    this.SourceType.Equals(input.SourceType)
                ) && 
                (
                    this.JournalLines == input.JournalLines ||
                    this.JournalLines != null &&
                    input.JournalLines != null &&
                    this.JournalLines.SequenceEqual(input.JournalLines)
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
                if (this.JournalID != null)
                    hashCode = hashCode * 59 + this.JournalID.GetHashCode();
                if (this.JournalDate != null)
                    hashCode = hashCode * 59 + this.JournalDate.GetHashCode();
                hashCode = hashCode * 59 + this.JournalNumber.GetHashCode();
                if (this.CreatedDateUTC != null)
                    hashCode = hashCode * 59 + this.CreatedDateUTC.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.SourceID != null)
                    hashCode = hashCode * 59 + this.SourceID.GetHashCode();
                hashCode = hashCode * 59 + this.SourceType.GetHashCode();
                if (this.JournalLines != null)
                    hashCode = hashCode * 59 + this.JournalLines.GetHashCode();
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
