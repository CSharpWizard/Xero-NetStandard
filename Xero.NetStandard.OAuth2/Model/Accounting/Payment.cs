/* 
 * Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.2.15
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
    /// Payment
    /// </summary>
    [DataContract]
    public partial class Payment :  IEquatable<Payment>, IValidatableObject
    {
        /// <summary>
        /// The status of the payment.
        /// </summary>
        /// <value>The status of the payment.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum AUTHORISED for value: AUTHORISED
            /// </summary>
            [EnumMember(Value = "AUTHORISED")]
            AUTHORISED = 1,

            /// <summary>
            /// Enum DELETED for value: DELETED
            /// </summary>
            [EnumMember(Value = "DELETED")]
            DELETED = 2

        }

        /// <summary>
        /// The status of the payment.
        /// </summary>
        /// <value>The status of the payment.</value>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// See Payment Types.
        /// </summary>
        /// <value>See Payment Types.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PaymentTypeEnum
        {
            /// <summary>
            /// Enum ACCRECPAYMENT for value: ACCRECPAYMENT
            /// </summary>
            [EnumMember(Value = "ACCRECPAYMENT")]
            ACCRECPAYMENT = 1,

            /// <summary>
            /// Enum ACCPAYPAYMENT for value: ACCPAYPAYMENT
            /// </summary>
            [EnumMember(Value = "ACCPAYPAYMENT")]
            ACCPAYPAYMENT = 2,

            /// <summary>
            /// Enum ARCREDITPAYMENT for value: ARCREDITPAYMENT
            /// </summary>
            [EnumMember(Value = "ARCREDITPAYMENT")]
            ARCREDITPAYMENT = 3,

            /// <summary>
            /// Enum APCREDITPAYMENT for value: APCREDITPAYMENT
            /// </summary>
            [EnumMember(Value = "APCREDITPAYMENT")]
            APCREDITPAYMENT = 4,

            /// <summary>
            /// Enum AROVERPAYMENTPAYMENT for value: AROVERPAYMENTPAYMENT
            /// </summary>
            [EnumMember(Value = "AROVERPAYMENTPAYMENT")]
            AROVERPAYMENTPAYMENT = 5,

            /// <summary>
            /// Enum ARPREPAYMENTPAYMENT for value: ARPREPAYMENTPAYMENT
            /// </summary>
            [EnumMember(Value = "ARPREPAYMENTPAYMENT")]
            ARPREPAYMENTPAYMENT = 6,

            /// <summary>
            /// Enum APPREPAYMENTPAYMENT for value: APPREPAYMENTPAYMENT
            /// </summary>
            [EnumMember(Value = "APPREPAYMENTPAYMENT")]
            APPREPAYMENTPAYMENT = 7,

            /// <summary>
            /// Enum APOVERPAYMENTPAYMENT for value: APOVERPAYMENTPAYMENT
            /// </summary>
            [EnumMember(Value = "APOVERPAYMENTPAYMENT")]
            APOVERPAYMENTPAYMENT = 8

        }

        /// <summary>
        /// See Payment Types.
        /// </summary>
        /// <value>See Payment Types.</value>
        [DataMember(Name="PaymentType", EmitDefaultValue=false)]
        public PaymentTypeEnum PaymentType { get; set; }
        
        /// <summary>
        /// Gets or Sets Invoice
        /// </summary>
        [DataMember(Name="Invoice", EmitDefaultValue=false)]
        public Invoice Invoice { get; set; }

        /// <summary>
        /// Gets or Sets CreditNote
        /// </summary>
        [DataMember(Name="CreditNote", EmitDefaultValue=false)]
        public CreditNote CreditNote { get; set; }

        /// <summary>
        /// Gets or Sets Prepayment
        /// </summary>
        [DataMember(Name="Prepayment", EmitDefaultValue=false)]
        public Prepayment Prepayment { get; set; }

        /// <summary>
        /// Gets or Sets Overpayment
        /// </summary>
        [DataMember(Name="Overpayment", EmitDefaultValue=false)]
        public Overpayment Overpayment { get; set; }

        /// <summary>
        /// Number of invoice or credit note you are applying payment to e.g.INV-4003
        /// </summary>
        /// <value>Number of invoice or credit note you are applying payment to e.g.INV-4003</value>
        [DataMember(Name="InvoiceNumber", EmitDefaultValue=false)]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// Number of invoice or credit note you are applying payment to e.g. INV-4003
        /// </summary>
        /// <value>Number of invoice or credit note you are applying payment to e.g. INV-4003</value>
        [DataMember(Name="CreditNoteNumber", EmitDefaultValue=false)]
        public string CreditNoteNumber { get; set; }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name="Account", EmitDefaultValue=false)]
        public Account Account { get; set; }

        /// <summary>
        /// Code of account you are using to make the payment e.g. 001 (note- not all accounts have a code value)
        /// </summary>
        /// <value>Code of account you are using to make the payment e.g. 001 (note- not all accounts have a code value)</value>
        [DataMember(Name="Code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Date the payment is being made (YYYY-MM-DD) e.g. 2009-09-06
        /// </summary>
        /// <value>Date the payment is being made (YYYY-MM-DD) e.g. 2009-09-06</value>
        [DataMember(Name="Date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// Exchange rate when payment is received. Only used for non base currency invoices and credit notes e.g. 0.7500
        /// </summary>
        /// <value>Exchange rate when payment is received. Only used for non base currency invoices and credit notes e.g. 0.7500</value>
        [DataMember(Name="CurrencyRate", EmitDefaultValue=false)]
        public decimal? CurrencyRate { get; set; }

        /// <summary>
        /// The amount of the payment. Must be less than or equal to the outstanding amount owing on the invoice e.g. 200.00
        /// </summary>
        /// <value>The amount of the payment. Must be less than or equal to the outstanding amount owing on the invoice e.g. 200.00</value>
        [DataMember(Name="Amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// An optional description for the payment e.g. Direct Debit
        /// </summary>
        /// <value>An optional description for the payment e.g. Direct Debit</value>
        [DataMember(Name="Reference", EmitDefaultValue=false)]
        public string Reference { get; set; }

        /// <summary>
        /// An optional parameter for the payment. A boolean indicating whether you would like the payment to be created as reconciled when using PUT, or whether a payment has been reconciled when using GET
        /// </summary>
        /// <value>An optional parameter for the payment. A boolean indicating whether you would like the payment to be created as reconciled when using PUT, or whether a payment has been reconciled when using GET</value>
        [DataMember(Name="IsReconciled", EmitDefaultValue=false)]
        public bool? IsReconciled { get; set; }

        /// <summary>
        /// UTC timestamp of last update to the payment
        /// </summary>
        /// <value>UTC timestamp of last update to the payment</value>
        [DataMember(Name="UpdatedDateUTC", EmitDefaultValue=false)]
        public DateTime? UpdatedDateUTC { get; private set; }

        /// <summary>
        /// The Xero identifier for an Payment e.g. 297c2dc5-cc47-4afd-8ec8-74990b8761e9
        /// </summary>
        /// <value>The Xero identifier for an Payment e.g. 297c2dc5-cc47-4afd-8ec8-74990b8761e9</value>
        [DataMember(Name="PaymentID", EmitDefaultValue=false)]
        public Guid? PaymentID { get; set; }

        /// <summary>
        /// The suppliers bank account number the payment is being made to
        /// </summary>
        /// <value>The suppliers bank account number the payment is being made to</value>
        [DataMember(Name="BankAccountNumber", EmitDefaultValue=false)]
        public string BankAccountNumber { get; set; }

        /// <summary>
        /// The suppliers bank account number the payment is being made to
        /// </summary>
        /// <value>The suppliers bank account number the payment is being made to</value>
        [DataMember(Name="Particulars", EmitDefaultValue=false)]
        public string Particulars { get; set; }

        /// <summary>
        /// The information to appear on the supplier&#39;s bank account
        /// </summary>
        /// <value>The information to appear on the supplier&#39;s bank account</value>
        [DataMember(Name="Details", EmitDefaultValue=false)]
        public string Details { get; set; }

        /// <summary>
        /// A boolean to indicate if a contact has an validation errors
        /// </summary>
        /// <value>A boolean to indicate if a contact has an validation errors</value>
        [DataMember(Name="HasAccount", EmitDefaultValue=false)]
        public bool? HasAccount { get; set; }

        /// <summary>
        /// A boolean to indicate if a contact has an validation errors
        /// </summary>
        /// <value>A boolean to indicate if a contact has an validation errors</value>
        [DataMember(Name="HasValidationErrors", EmitDefaultValue=false)]
        public bool? HasValidationErrors { get; set; }

        /// <summary>
        /// A string to indicate if a invoice status
        /// </summary>
        /// <value>A string to indicate if a invoice status</value>
        [DataMember(Name="StatusAttributeString", EmitDefaultValue=false)]
        public string StatusAttributeString { get; set; }

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
            sb.Append("class Payment {\n");
            sb.Append("  Invoice: ").Append(Invoice).Append("\n");
            sb.Append("  CreditNote: ").Append(CreditNote).Append("\n");
            sb.Append("  Prepayment: ").Append(Prepayment).Append("\n");
            sb.Append("  Overpayment: ").Append(Overpayment).Append("\n");
            sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
            sb.Append("  CreditNoteNumber: ").Append(CreditNoteNumber).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  CurrencyRate: ").Append(CurrencyRate).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  IsReconciled: ").Append(IsReconciled).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  PaymentType: ").Append(PaymentType).Append("\n");
            sb.Append("  UpdatedDateUTC: ").Append(UpdatedDateUTC).Append("\n");
            sb.Append("  PaymentID: ").Append(PaymentID).Append("\n");
            sb.Append("  BankAccountNumber: ").Append(BankAccountNumber).Append("\n");
            sb.Append("  Particulars: ").Append(Particulars).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  HasAccount: ").Append(HasAccount).Append("\n");
            sb.Append("  HasValidationErrors: ").Append(HasValidationErrors).Append("\n");
            sb.Append("  StatusAttributeString: ").Append(StatusAttributeString).Append("\n");
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
            return this.Equals(input as Payment);
        }

        /// <summary>
        /// Returns true if Payment instances are equal
        /// </summary>
        /// <param name="input">Instance of Payment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Payment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Invoice == input.Invoice ||
                    (this.Invoice != null &&
                    this.Invoice.Equals(input.Invoice))
                ) && 
                (
                    this.CreditNote == input.CreditNote ||
                    (this.CreditNote != null &&
                    this.CreditNote.Equals(input.CreditNote))
                ) && 
                (
                    this.Prepayment == input.Prepayment ||
                    (this.Prepayment != null &&
                    this.Prepayment.Equals(input.Prepayment))
                ) && 
                (
                    this.Overpayment == input.Overpayment ||
                    (this.Overpayment != null &&
                    this.Overpayment.Equals(input.Overpayment))
                ) && 
                (
                    this.InvoiceNumber == input.InvoiceNumber ||
                    (this.InvoiceNumber != null &&
                    this.InvoiceNumber.Equals(input.InvoiceNumber))
                ) && 
                (
                    this.CreditNoteNumber == input.CreditNoteNumber ||
                    (this.CreditNoteNumber != null &&
                    this.CreditNoteNumber.Equals(input.CreditNoteNumber))
                ) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.CurrencyRate == input.CurrencyRate ||
                    this.CurrencyRate.Equals(input.CurrencyRate)
                ) && 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.IsReconciled == input.IsReconciled ||
                    this.IsReconciled.Equals(input.IsReconciled)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.PaymentType == input.PaymentType ||
                    this.PaymentType.Equals(input.PaymentType)
                ) && 
                (
                    this.UpdatedDateUTC == input.UpdatedDateUTC ||
                    (this.UpdatedDateUTC != null &&
                    this.UpdatedDateUTC.Equals(input.UpdatedDateUTC))
                ) && 
                (
                    this.PaymentID == input.PaymentID ||
                    (this.PaymentID != null &&
                    this.PaymentID.Equals(input.PaymentID))
                ) && 
                (
                    this.BankAccountNumber == input.BankAccountNumber ||
                    (this.BankAccountNumber != null &&
                    this.BankAccountNumber.Equals(input.BankAccountNumber))
                ) && 
                (
                    this.Particulars == input.Particulars ||
                    (this.Particulars != null &&
                    this.Particulars.Equals(input.Particulars))
                ) && 
                (
                    this.Details == input.Details ||
                    (this.Details != null &&
                    this.Details.Equals(input.Details))
                ) && 
                (
                    this.HasAccount == input.HasAccount ||
                    this.HasAccount.Equals(input.HasAccount)
                ) && 
                (
                    this.HasValidationErrors == input.HasValidationErrors ||
                    this.HasValidationErrors.Equals(input.HasValidationErrors)
                ) && 
                (
                    this.StatusAttributeString == input.StatusAttributeString ||
                    (this.StatusAttributeString != null &&
                    this.StatusAttributeString.Equals(input.StatusAttributeString))
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
                if (this.Invoice != null)
                    hashCode = hashCode * 59 + this.Invoice.GetHashCode();
                if (this.CreditNote != null)
                    hashCode = hashCode * 59 + this.CreditNote.GetHashCode();
                if (this.Prepayment != null)
                    hashCode = hashCode * 59 + this.Prepayment.GetHashCode();
                if (this.Overpayment != null)
                    hashCode = hashCode * 59 + this.Overpayment.GetHashCode();
                if (this.InvoiceNumber != null)
                    hashCode = hashCode * 59 + this.InvoiceNumber.GetHashCode();
                if (this.CreditNoteNumber != null)
                    hashCode = hashCode * 59 + this.CreditNoteNumber.GetHashCode();
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                hashCode = hashCode * 59 + this.CurrencyRate.GetHashCode();
                hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                hashCode = hashCode * 59 + this.IsReconciled.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                hashCode = hashCode * 59 + this.PaymentType.GetHashCode();
                if (this.UpdatedDateUTC != null)
                    hashCode = hashCode * 59 + this.UpdatedDateUTC.GetHashCode();
                if (this.PaymentID != null)
                    hashCode = hashCode * 59 + this.PaymentID.GetHashCode();
                if (this.BankAccountNumber != null)
                    hashCode = hashCode * 59 + this.BankAccountNumber.GetHashCode();
                if (this.Particulars != null)
                    hashCode = hashCode * 59 + this.Particulars.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                hashCode = hashCode * 59 + this.HasAccount.GetHashCode();
                hashCode = hashCode * 59 + this.HasValidationErrors.GetHashCode();
                if (this.StatusAttributeString != null)
                    hashCode = hashCode * 59 + this.StatusAttributeString.GetHashCode();
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
