/* 
 * Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.2.13
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
    /// RepeatingInvoice
    /// </summary>
    [DataContract]
    public partial class RepeatingInvoice :  IEquatable<RepeatingInvoice>, IValidatableObject
    {
        /// <summary>
        /// See Invoice Types
        /// </summary>
        /// <value>See Invoice Types</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum ACCPAY for value: ACCPAY
            /// </summary>
            [EnumMember(Value = "ACCPAY")]
            ACCPAY = 1,

            /// <summary>
            /// Enum ACCREC for value: ACCREC
            /// </summary>
            [EnumMember(Value = "ACCREC")]
            ACCREC = 2

        }

        /// <summary>
        /// See Invoice Types
        /// </summary>
        /// <value>See Invoice Types</value>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Gets or Sets LineAmountTypes
        /// </summary>
        [DataMember(Name="LineAmountTypes", EmitDefaultValue=false)]
        public LineAmountTypes LineAmountTypes { get; set; }
        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        [DataMember(Name="CurrencyCode", EmitDefaultValue=false)]
        public CurrencyCode CurrencyCode { get; set; }
        /// <summary>
        /// One of the following - DRAFT or AUTHORISED – See Invoice Status Codes
        /// </summary>
        /// <value>One of the following - DRAFT or AUTHORISED – See Invoice Status Codes</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum DRAFT for value: DRAFT
            /// </summary>
            [EnumMember(Value = "DRAFT")]
            DRAFT = 1,

            /// <summary>
            /// Enum AUTHORISED for value: AUTHORISED
            /// </summary>
            [EnumMember(Value = "AUTHORISED")]
            AUTHORISED = 2,

            /// <summary>
            /// Enum DELETED for value: DELETED
            /// </summary>
            [EnumMember(Value = "DELETED")]
            DELETED = 3

        }

        /// <summary>
        /// One of the following - DRAFT or AUTHORISED – See Invoice Status Codes
        /// </summary>
        /// <value>One of the following - DRAFT or AUTHORISED – See Invoice Status Codes</value>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        
        /// <summary>
        /// Gets or Sets Contact
        /// </summary>
        [DataMember(Name="Contact", EmitDefaultValue=false)]
        public Contact Contact { get; set; }

        /// <summary>
        /// Gets or Sets Schedule
        /// </summary>
        [DataMember(Name="Schedule", EmitDefaultValue=false)]
        public Schedule Schedule { get; set; }

        /// <summary>
        /// See LineItems
        /// </summary>
        /// <value>See LineItems</value>
        [DataMember(Name="LineItems", EmitDefaultValue=false)]
        public List<LineItem> LineItems { get; set; }

        /// <summary>
        /// ACCREC only – additional reference number
        /// </summary>
        /// <value>ACCREC only – additional reference number</value>
        [DataMember(Name="Reference", EmitDefaultValue=false)]
        public string Reference { get; set; }

        /// <summary>
        /// See BrandingThemes
        /// </summary>
        /// <value>See BrandingThemes</value>
        [DataMember(Name="BrandingThemeID", EmitDefaultValue=false)]
        public Guid? BrandingThemeID { get; set; }

        /// <summary>
        /// Total of invoice excluding taxes
        /// </summary>
        /// <value>Total of invoice excluding taxes</value>
        [DataMember(Name="SubTotal", EmitDefaultValue=false)]
        public decimal? SubTotal { get; set; }

        /// <summary>
        /// Total tax on invoice
        /// </summary>
        /// <value>Total tax on invoice</value>
        [DataMember(Name="TotalTax", EmitDefaultValue=false)]
        public decimal? TotalTax { get; set; }

        /// <summary>
        /// Total of Invoice tax inclusive (i.e. SubTotal + TotalTax)
        /// </summary>
        /// <value>Total of Invoice tax inclusive (i.e. SubTotal + TotalTax)</value>
        [DataMember(Name="Total", EmitDefaultValue=false)]
        public decimal? Total { get; set; }

        /// <summary>
        /// Xero generated unique identifier for repeating invoice template
        /// </summary>
        /// <value>Xero generated unique identifier for repeating invoice template</value>
        [DataMember(Name="RepeatingInvoiceID", EmitDefaultValue=false)]
        public Guid? RepeatingInvoiceID { get; set; }

        /// <summary>
        /// Xero generated unique identifier for repeating invoice template
        /// </summary>
        /// <value>Xero generated unique identifier for repeating invoice template</value>
        [DataMember(Name="ID", EmitDefaultValue=false)]
        public Guid? ID { get; set; }

        /// <summary>
        /// boolean to indicate if an invoice has an attachment
        /// </summary>
        /// <value>boolean to indicate if an invoice has an attachment</value>
        [DataMember(Name="HasAttachments", EmitDefaultValue=false)]
        public bool? HasAttachments { get; private set; }

        /// <summary>
        /// Displays array of attachments from the API
        /// </summary>
        /// <value>Displays array of attachments from the API</value>
        [DataMember(Name="Attachments", EmitDefaultValue=false)]
        public List<Attachment> Attachments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RepeatingInvoice {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  Schedule: ").Append(Schedule).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  LineAmountTypes: ").Append(LineAmountTypes).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  BrandingThemeID: ").Append(BrandingThemeID).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SubTotal: ").Append(SubTotal).Append("\n");
            sb.Append("  TotalTax: ").Append(TotalTax).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  RepeatingInvoiceID: ").Append(RepeatingInvoiceID).Append("\n");
            sb.Append("  ID: ").Append(ID).Append("\n");
            sb.Append("  HasAttachments: ").Append(HasAttachments).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
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
            return this.Equals(input as RepeatingInvoice);
        }

        /// <summary>
        /// Returns true if RepeatingInvoice instances are equal
        /// </summary>
        /// <param name="input">Instance of RepeatingInvoice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RepeatingInvoice input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Contact == input.Contact ||
                    (this.Contact != null &&
                    this.Contact.Equals(input.Contact))
                ) && 
                (
                    this.Schedule == input.Schedule ||
                    (this.Schedule != null &&
                    this.Schedule.Equals(input.Schedule))
                ) && 
                (
                    this.LineItems == input.LineItems ||
                    this.LineItems != null &&
                    input.LineItems != null &&
                    this.LineItems.SequenceEqual(input.LineItems)
                ) && 
                (
                    this.LineAmountTypes == input.LineAmountTypes ||
                    this.LineAmountTypes.Equals(input.LineAmountTypes)
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.BrandingThemeID == input.BrandingThemeID ||
                    (this.BrandingThemeID != null &&
                    this.BrandingThemeID.Equals(input.BrandingThemeID))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    this.CurrencyCode.Equals(input.CurrencyCode)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.SubTotal == input.SubTotal ||
                    this.SubTotal.Equals(input.SubTotal)
                ) && 
                (
                    this.TotalTax == input.TotalTax ||
                    this.TotalTax.Equals(input.TotalTax)
                ) && 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
                ) && 
                (
                    this.RepeatingInvoiceID == input.RepeatingInvoiceID ||
                    (this.RepeatingInvoiceID != null &&
                    this.RepeatingInvoiceID.Equals(input.RepeatingInvoiceID))
                ) && 
                (
                    this.ID == input.ID ||
                    (this.ID != null &&
                    this.ID.Equals(input.ID))
                ) && 
                (
                    this.HasAttachments == input.HasAttachments ||
                    this.HasAttachments.Equals(input.HasAttachments)
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
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
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Contact != null)
                    hashCode = hashCode * 59 + this.Contact.GetHashCode();
                if (this.Schedule != null)
                    hashCode = hashCode * 59 + this.Schedule.GetHashCode();
                if (this.LineItems != null)
                    hashCode = hashCode * 59 + this.LineItems.GetHashCode();
                hashCode = hashCode * 59 + this.LineAmountTypes.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.BrandingThemeID != null)
                    hashCode = hashCode * 59 + this.BrandingThemeID.GetHashCode();
                hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.SubTotal.GetHashCode();
                hashCode = hashCode * 59 + this.TotalTax.GetHashCode();
                hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.RepeatingInvoiceID != null)
                    hashCode = hashCode * 59 + this.RepeatingInvoiceID.GetHashCode();
                if (this.ID != null)
                    hashCode = hashCode * 59 + this.ID.GetHashCode();
                hashCode = hashCode * 59 + this.HasAttachments.GetHashCode();
                if (this.Attachments != null)
                    hashCode = hashCode * 59 + this.Attachments.GetHashCode();
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
