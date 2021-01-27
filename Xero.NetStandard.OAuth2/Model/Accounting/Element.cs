/* 
 * Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
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

namespace Xero.NetStandard.OAuth2.Model.Accounting
{
    /// <summary>
    /// Element
    /// </summary>
    [DataContract]
    public partial class Element :  IEquatable<Element>, IValidatableObject
    {
        
        /// <summary>
        /// Array of Validation Error message
        /// </summary>
        /// <value>Array of Validation Error message</value>
        [DataMember(Name="ValidationErrors", EmitDefaultValue=false)]
        public List<ValidationError> ValidationErrors { get; set; }

        /// <summary>
        /// Unique ID for batch payment object with validation error
        /// </summary>
        /// <value>Unique ID for batch payment object with validation error</value>
        [DataMember(Name="BatchPaymentID", EmitDefaultValue=false)]
        public Guid? BatchPaymentID { get; set; }

        /// <summary>
        /// Gets or Sets BankTransactionID
        /// </summary>
        [DataMember(Name="BankTransactionID", EmitDefaultValue=false)]
        public Guid? BankTransactionID { get; set; }

        /// <summary>
        /// Gets or Sets CreditNoteID
        /// </summary>
        [DataMember(Name="CreditNoteID", EmitDefaultValue=false)]
        public Guid? CreditNoteID { get; set; }

        /// <summary>
        /// Gets or Sets ContactID
        /// </summary>
        [DataMember(Name="ContactID", EmitDefaultValue=false)]
        public Guid? ContactID { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceID
        /// </summary>
        [DataMember(Name="InvoiceID", EmitDefaultValue=false)]
        public Guid? InvoiceID { get; set; }

        /// <summary>
        /// Gets or Sets ItemID
        /// </summary>
        [DataMember(Name="ItemID", EmitDefaultValue=false)]
        public Guid? ItemID { get; set; }

        /// <summary>
        /// Gets or Sets PurchaseOrderID
        /// </summary>
        [DataMember(Name="PurchaseOrderID", EmitDefaultValue=false)]
        public Guid? PurchaseOrderID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Element {\n");
            sb.Append("  ValidationErrors: ").Append(ValidationErrors).Append("\n");
            sb.Append("  BatchPaymentID: ").Append(BatchPaymentID).Append("\n");
            sb.Append("  BankTransactionID: ").Append(BankTransactionID).Append("\n");
            sb.Append("  CreditNoteID: ").Append(CreditNoteID).Append("\n");
            sb.Append("  ContactID: ").Append(ContactID).Append("\n");
            sb.Append("  InvoiceID: ").Append(InvoiceID).Append("\n");
            sb.Append("  ItemID: ").Append(ItemID).Append("\n");
            sb.Append("  PurchaseOrderID: ").Append(PurchaseOrderID).Append("\n");
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
            return this.Equals(input as Element);
        }

        /// <summary>
        /// Returns true if Element instances are equal
        /// </summary>
        /// <param name="input">Instance of Element to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Element input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ValidationErrors == input.ValidationErrors ||
                    this.ValidationErrors != null &&
                    input.ValidationErrors != null &&
                    this.ValidationErrors.SequenceEqual(input.ValidationErrors)
                ) && 
                (
                    this.BatchPaymentID == input.BatchPaymentID ||
                    (this.BatchPaymentID != null &&
                    this.BatchPaymentID.Equals(input.BatchPaymentID))
                ) && 
                (
                    this.BankTransactionID == input.BankTransactionID ||
                    (this.BankTransactionID != null &&
                    this.BankTransactionID.Equals(input.BankTransactionID))
                ) && 
                (
                    this.CreditNoteID == input.CreditNoteID ||
                    (this.CreditNoteID != null &&
                    this.CreditNoteID.Equals(input.CreditNoteID))
                ) && 
                (
                    this.ContactID == input.ContactID ||
                    (this.ContactID != null &&
                    this.ContactID.Equals(input.ContactID))
                ) && 
                (
                    this.InvoiceID == input.InvoiceID ||
                    (this.InvoiceID != null &&
                    this.InvoiceID.Equals(input.InvoiceID))
                ) && 
                (
                    this.ItemID == input.ItemID ||
                    (this.ItemID != null &&
                    this.ItemID.Equals(input.ItemID))
                ) && 
                (
                    this.PurchaseOrderID == input.PurchaseOrderID ||
                    (this.PurchaseOrderID != null &&
                    this.PurchaseOrderID.Equals(input.PurchaseOrderID))
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
                if (this.ValidationErrors != null)
                    hashCode = hashCode * 59 + this.ValidationErrors.GetHashCode();
                if (this.BatchPaymentID != null)
                    hashCode = hashCode * 59 + this.BatchPaymentID.GetHashCode();
                if (this.BankTransactionID != null)
                    hashCode = hashCode * 59 + this.BankTransactionID.GetHashCode();
                if (this.CreditNoteID != null)
                    hashCode = hashCode * 59 + this.CreditNoteID.GetHashCode();
                if (this.ContactID != null)
                    hashCode = hashCode * 59 + this.ContactID.GetHashCode();
                if (this.InvoiceID != null)
                    hashCode = hashCode * 59 + this.InvoiceID.GetHashCode();
                if (this.ItemID != null)
                    hashCode = hashCode * 59 + this.ItemID.GetHashCode();
                if (this.PurchaseOrderID != null)
                    hashCode = hashCode * 59 + this.PurchaseOrderID.GetHashCode();
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
