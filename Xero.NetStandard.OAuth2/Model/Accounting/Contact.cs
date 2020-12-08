/* 
 * Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.6.1
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
    /// Contact
    /// </summary>
    [DataContract]
    public partial class Contact :  IEquatable<Contact>, IValidatableObject
    {
        /// <summary>
        /// Current status of a contact – see contact status types
        /// </summary>
        /// <value>Current status of a contact – see contact status types</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ContactStatusEnum
        {
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            [EnumMember(Value = "ACTIVE")]
            ACTIVE = 1,

            /// <summary>
            /// Enum ARCHIVED for value: ARCHIVED
            /// </summary>
            [EnumMember(Value = "ARCHIVED")]
            ARCHIVED = 2,

            /// <summary>
            /// Enum GDPRREQUEST for value: GDPRREQUEST
            /// </summary>
            [EnumMember(Value = "GDPRREQUEST")]
            GDPRREQUEST = 3

        }

        /// <summary>
        /// Current status of a contact – see contact status types
        /// </summary>
        /// <value>Current status of a contact – see contact status types</value>
        [DataMember(Name="ContactStatus", EmitDefaultValue=false)]
        public ContactStatusEnum ContactStatus { get; set; }
        /// <summary>
        /// Gets or Sets DefaultCurrency
        /// </summary>
        [DataMember(Name="DefaultCurrency", EmitDefaultValue=false)]
        public CurrencyCode DefaultCurrency { get; set; }
        
        /// <summary>
        /// Xero identifier
        /// </summary>
        /// <value>Xero identifier</value>
        [DataMember(Name="ContactID", EmitDefaultValue=false)]
        public Guid? ContactID { get; set; }

        /// <summary>
        /// This can be updated via the API only i.e. This field is read only on the Xero contact screen, used to identify contacts in external systems (max length &#x3D; 50). If the Contact Number is used, this is displayed as Contact Code in the Contacts UI in Xero.
        /// </summary>
        /// <value>This can be updated via the API only i.e. This field is read only on the Xero contact screen, used to identify contacts in external systems (max length &#x3D; 50). If the Contact Number is used, this is displayed as Contact Code in the Contacts UI in Xero.</value>
        [DataMember(Name="ContactNumber", EmitDefaultValue=false)]
        public string ContactNumber { get; set; }

        /// <summary>
        /// A user defined account number. This can be updated via the API and the Xero UI (max length &#x3D; 50)
        /// </summary>
        /// <value>A user defined account number. This can be updated via the API and the Xero UI (max length &#x3D; 50)</value>
        [DataMember(Name="AccountNumber", EmitDefaultValue=false)]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Full name of contact/organisation (max length &#x3D; 255)
        /// </summary>
        /// <value>Full name of contact/organisation (max length &#x3D; 255)</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// First name of contact person (max length &#x3D; 255)
        /// </summary>
        /// <value>First name of contact person (max length &#x3D; 255)</value>
        [DataMember(Name="FirstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of contact person (max length &#x3D; 255)
        /// </summary>
        /// <value>Last name of contact person (max length &#x3D; 255)</value>
        [DataMember(Name="LastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Email address of contact person (umlauts not supported) (max length  &#x3D; 255)
        /// </summary>
        /// <value>Email address of contact person (umlauts not supported) (max length  &#x3D; 255)</value>
        [DataMember(Name="EmailAddress", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Skype user name of contact
        /// </summary>
        /// <value>Skype user name of contact</value>
        [DataMember(Name="SkypeUserName", EmitDefaultValue=false)]
        public string SkypeUserName { get; set; }

        /// <summary>
        /// See contact persons
        /// </summary>
        /// <value>See contact persons</value>
        [DataMember(Name="ContactPersons", EmitDefaultValue=false)]
        public List<ContactPerson> ContactPersons { get; set; }

        /// <summary>
        /// Bank account number of contact
        /// </summary>
        /// <value>Bank account number of contact</value>
        [DataMember(Name="BankAccountDetails", EmitDefaultValue=false)]
        public string BankAccountDetails { get; set; }

        /// <summary>
        /// Tax number of contact – this is also known as the ABN (Australia), GST Number (New Zealand), VAT Number (UK) or Tax ID Number (US and global) in the Xero UI depending on which regionalized version of Xero you are using (max length &#x3D; 50)
        /// </summary>
        /// <value>Tax number of contact – this is also known as the ABN (Australia), GST Number (New Zealand), VAT Number (UK) or Tax ID Number (US and global) in the Xero UI depending on which regionalized version of Xero you are using (max length &#x3D; 50)</value>
        [DataMember(Name="TaxNumber", EmitDefaultValue=false)]
        public string TaxNumber { get; set; }

        /// <summary>
        /// The tax type from TaxRates
        /// </summary>
        /// <value>The tax type from TaxRates</value>
        [DataMember(Name="AccountsReceivableTaxType", EmitDefaultValue=false)]
        public string AccountsReceivableTaxType { get; set; }

        /// <summary>
        /// The tax type from TaxRates
        /// </summary>
        /// <value>The tax type from TaxRates</value>
        [DataMember(Name="AccountsPayableTaxType", EmitDefaultValue=false)]
        public string AccountsPayableTaxType { get; set; }

        /// <summary>
        /// Store certain address types for a contact – see address types
        /// </summary>
        /// <value>Store certain address types for a contact – see address types</value>
        [DataMember(Name="Addresses", EmitDefaultValue=false)]
        public List<Address> Addresses { get; set; }

        /// <summary>
        /// Store certain phone types for a contact – see phone types
        /// </summary>
        /// <value>Store certain phone types for a contact – see phone types</value>
        [DataMember(Name="Phones", EmitDefaultValue=false)]
        public List<Phone> Phones { get; set; }

        /// <summary>
        /// true or false – Boolean that describes if a contact that has any AP  invoices entered against them. Cannot be set via PUT or POST – it is automatically set when an accounts payable invoice is generated against this contact.
        /// </summary>
        /// <value>true or false – Boolean that describes if a contact that has any AP  invoices entered against them. Cannot be set via PUT or POST – it is automatically set when an accounts payable invoice is generated against this contact.</value>
        [DataMember(Name="IsSupplier", EmitDefaultValue=false)]
        public bool? IsSupplier { get; set; }

        /// <summary>
        /// true or false – Boolean that describes if a contact has any AR invoices entered against them. Cannot be set via PUT or POST – it is automatically set when an accounts receivable invoice is generated against this contact.
        /// </summary>
        /// <value>true or false – Boolean that describes if a contact has any AR invoices entered against them. Cannot be set via PUT or POST – it is automatically set when an accounts receivable invoice is generated against this contact.</value>
        [DataMember(Name="IsCustomer", EmitDefaultValue=false)]
        public bool? IsCustomer { get; set; }

        /// <summary>
        /// Store XeroNetworkKey for contacts.
        /// </summary>
        /// <value>Store XeroNetworkKey for contacts.</value>
        [DataMember(Name="XeroNetworkKey", EmitDefaultValue=false)]
        public string XeroNetworkKey { get; set; }

        /// <summary>
        /// The default sales account code for contacts
        /// </summary>
        /// <value>The default sales account code for contacts</value>
        [DataMember(Name="SalesDefaultAccountCode", EmitDefaultValue=false)]
        public string SalesDefaultAccountCode { get; set; }

        /// <summary>
        /// The default purchases account code for contacts
        /// </summary>
        /// <value>The default purchases account code for contacts</value>
        [DataMember(Name="PurchasesDefaultAccountCode", EmitDefaultValue=false)]
        public string PurchasesDefaultAccountCode { get; set; }

        /// <summary>
        /// The default sales tracking categories for contacts
        /// </summary>
        /// <value>The default sales tracking categories for contacts</value>
        [DataMember(Name="SalesTrackingCategories", EmitDefaultValue=false)]
        public List<SalesTrackingCategory> SalesTrackingCategories { get; set; }

        /// <summary>
        /// The default purchases tracking categories for contacts
        /// </summary>
        /// <value>The default purchases tracking categories for contacts</value>
        [DataMember(Name="PurchasesTrackingCategories", EmitDefaultValue=false)]
        public List<SalesTrackingCategory> PurchasesTrackingCategories { get; set; }

        /// <summary>
        /// The name of the Tracking Category assigned to the contact under SalesTrackingCategories and PurchasesTrackingCategories
        /// </summary>
        /// <value>The name of the Tracking Category assigned to the contact under SalesTrackingCategories and PurchasesTrackingCategories</value>
        [DataMember(Name="TrackingCategoryName", EmitDefaultValue=false)]
        public string TrackingCategoryName { get; set; }

        /// <summary>
        /// The name of the Tracking Option assigned to the contact under SalesTrackingCategories and PurchasesTrackingCategories
        /// </summary>
        /// <value>The name of the Tracking Option assigned to the contact under SalesTrackingCategories and PurchasesTrackingCategories</value>
        [DataMember(Name="TrackingCategoryOption", EmitDefaultValue=false)]
        public string TrackingCategoryOption { get; set; }

        /// <summary>
        /// Gets or Sets PaymentTerms
        /// </summary>
        [DataMember(Name="PaymentTerms", EmitDefaultValue=false)]
        public PaymentTerm PaymentTerms { get; set; }

        /// <summary>
        /// UTC timestamp of last update to contact
        /// </summary>
        /// <value>UTC timestamp of last update to contact</value>
        [DataMember(Name="UpdatedDateUTC", EmitDefaultValue=false)]
        public DateTime? UpdatedDateUTC { get; private set; }

        /// <summary>
        /// Displays which contact groups a contact is included in
        /// </summary>
        /// <value>Displays which contact groups a contact is included in</value>
        [DataMember(Name="ContactGroups", EmitDefaultValue=false)]
        public List<ContactGroup> ContactGroups { get; set; }

        /// <summary>
        /// Website address for contact (read only)
        /// </summary>
        /// <value>Website address for contact (read only)</value>
        [DataMember(Name="Website", EmitDefaultValue=false)]
        public string Website { get; private set; }

        /// <summary>
        /// Gets or Sets BrandingTheme
        /// </summary>
        [DataMember(Name="BrandingTheme", EmitDefaultValue=false)]
        public BrandingTheme BrandingTheme { get; set; }

        /// <summary>
        /// Gets or Sets BatchPayments
        /// </summary>
        [DataMember(Name="BatchPayments", EmitDefaultValue=false)]
        public BatchPaymentDetails BatchPayments { get; set; }

        /// <summary>
        /// The default discount rate for the contact (read only)
        /// </summary>
        /// <value>The default discount rate for the contact (read only)</value>
        [DataMember(Name="Discount", EmitDefaultValue=false)]
        public decimal? Discount { get; private set; }

        /// <summary>
        /// Gets or Sets Balances
        /// </summary>
        [DataMember(Name="Balances", EmitDefaultValue=false)]
        public Balances Balances { get; set; }

        /// <summary>
        /// Displays array of attachments from the API
        /// </summary>
        /// <value>Displays array of attachments from the API</value>
        [DataMember(Name="Attachments", EmitDefaultValue=false)]
        public List<Attachment> Attachments { get; set; }

        /// <summary>
        /// A boolean to indicate if a contact has an attachment
        /// </summary>
        /// <value>A boolean to indicate if a contact has an attachment</value>
        [DataMember(Name="HasAttachments", EmitDefaultValue=false)]
        public bool? HasAttachments { get; set; }

        /// <summary>
        /// Displays validation errors returned from the API
        /// </summary>
        /// <value>Displays validation errors returned from the API</value>
        [DataMember(Name="ValidationErrors", EmitDefaultValue=false)]
        public List<ValidationError> ValidationErrors { get; set; }

        /// <summary>
        /// A boolean to indicate if a contact has an validation errors
        /// </summary>
        /// <value>A boolean to indicate if a contact has an validation errors</value>
        [DataMember(Name="HasValidationErrors", EmitDefaultValue=false)]
        public bool? HasValidationErrors { get; set; }

        /// <summary>
        /// Status of object
        /// </summary>
        /// <value>Status of object</value>
        [DataMember(Name="StatusAttributeString", EmitDefaultValue=false)]
        public string StatusAttributeString { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Contact {\n");
            sb.Append("  ContactID: ").Append(ContactID).Append("\n");
            sb.Append("  ContactNumber: ").Append(ContactNumber).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  ContactStatus: ").Append(ContactStatus).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  SkypeUserName: ").Append(SkypeUserName).Append("\n");
            sb.Append("  ContactPersons: ").Append(ContactPersons).Append("\n");
            sb.Append("  BankAccountDetails: ").Append(BankAccountDetails).Append("\n");
            sb.Append("  TaxNumber: ").Append(TaxNumber).Append("\n");
            sb.Append("  AccountsReceivableTaxType: ").Append(AccountsReceivableTaxType).Append("\n");
            sb.Append("  AccountsPayableTaxType: ").Append(AccountsPayableTaxType).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  Phones: ").Append(Phones).Append("\n");
            sb.Append("  IsSupplier: ").Append(IsSupplier).Append("\n");
            sb.Append("  IsCustomer: ").Append(IsCustomer).Append("\n");
            sb.Append("  DefaultCurrency: ").Append(DefaultCurrency).Append("\n");
            sb.Append("  XeroNetworkKey: ").Append(XeroNetworkKey).Append("\n");
            sb.Append("  SalesDefaultAccountCode: ").Append(SalesDefaultAccountCode).Append("\n");
            sb.Append("  PurchasesDefaultAccountCode: ").Append(PurchasesDefaultAccountCode).Append("\n");
            sb.Append("  SalesTrackingCategories: ").Append(SalesTrackingCategories).Append("\n");
            sb.Append("  PurchasesTrackingCategories: ").Append(PurchasesTrackingCategories).Append("\n");
            sb.Append("  TrackingCategoryName: ").Append(TrackingCategoryName).Append("\n");
            sb.Append("  TrackingCategoryOption: ").Append(TrackingCategoryOption).Append("\n");
            sb.Append("  PaymentTerms: ").Append(PaymentTerms).Append("\n");
            sb.Append("  UpdatedDateUTC: ").Append(UpdatedDateUTC).Append("\n");
            sb.Append("  ContactGroups: ").Append(ContactGroups).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
            sb.Append("  BrandingTheme: ").Append(BrandingTheme).Append("\n");
            sb.Append("  BatchPayments: ").Append(BatchPayments).Append("\n");
            sb.Append("  Discount: ").Append(Discount).Append("\n");
            sb.Append("  Balances: ").Append(Balances).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  HasAttachments: ").Append(HasAttachments).Append("\n");
            sb.Append("  ValidationErrors: ").Append(ValidationErrors).Append("\n");
            sb.Append("  HasValidationErrors: ").Append(HasValidationErrors).Append("\n");
            sb.Append("  StatusAttributeString: ").Append(StatusAttributeString).Append("\n");
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
            return this.Equals(input as Contact);
        }

        /// <summary>
        /// Returns true if Contact instances are equal
        /// </summary>
        /// <param name="input">Instance of Contact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Contact input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ContactID == input.ContactID ||
                    (this.ContactID != null &&
                    this.ContactID.Equals(input.ContactID))
                ) && 
                (
                    this.ContactNumber == input.ContactNumber ||
                    (this.ContactNumber != null &&
                    this.ContactNumber.Equals(input.ContactNumber))
                ) && 
                (
                    this.AccountNumber == input.AccountNumber ||
                    (this.AccountNumber != null &&
                    this.AccountNumber.Equals(input.AccountNumber))
                ) && 
                (
                    this.ContactStatus == input.ContactStatus ||
                    this.ContactStatus.Equals(input.ContactStatus)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.SkypeUserName == input.SkypeUserName ||
                    (this.SkypeUserName != null &&
                    this.SkypeUserName.Equals(input.SkypeUserName))
                ) && 
                (
                    this.ContactPersons == input.ContactPersons ||
                    this.ContactPersons != null &&
                    input.ContactPersons != null &&
                    this.ContactPersons.SequenceEqual(input.ContactPersons)
                ) && 
                (
                    this.BankAccountDetails == input.BankAccountDetails ||
                    (this.BankAccountDetails != null &&
                    this.BankAccountDetails.Equals(input.BankAccountDetails))
                ) && 
                (
                    this.TaxNumber == input.TaxNumber ||
                    (this.TaxNumber != null &&
                    this.TaxNumber.Equals(input.TaxNumber))
                ) && 
                (
                    this.AccountsReceivableTaxType == input.AccountsReceivableTaxType ||
                    (this.AccountsReceivableTaxType != null &&
                    this.AccountsReceivableTaxType.Equals(input.AccountsReceivableTaxType))
                ) && 
                (
                    this.AccountsPayableTaxType == input.AccountsPayableTaxType ||
                    (this.AccountsPayableTaxType != null &&
                    this.AccountsPayableTaxType.Equals(input.AccountsPayableTaxType))
                ) && 
                (
                    this.Addresses == input.Addresses ||
                    this.Addresses != null &&
                    input.Addresses != null &&
                    this.Addresses.SequenceEqual(input.Addresses)
                ) && 
                (
                    this.Phones == input.Phones ||
                    this.Phones != null &&
                    input.Phones != null &&
                    this.Phones.SequenceEqual(input.Phones)
                ) && 
                (
                    this.IsSupplier == input.IsSupplier ||
                    this.IsSupplier.Equals(input.IsSupplier)
                ) && 
                (
                    this.IsCustomer == input.IsCustomer ||
                    this.IsCustomer.Equals(input.IsCustomer)
                ) && 
                (
                    this.DefaultCurrency == input.DefaultCurrency ||
                    this.DefaultCurrency.Equals(input.DefaultCurrency)
                ) && 
                (
                    this.XeroNetworkKey == input.XeroNetworkKey ||
                    (this.XeroNetworkKey != null &&
                    this.XeroNetworkKey.Equals(input.XeroNetworkKey))
                ) && 
                (
                    this.SalesDefaultAccountCode == input.SalesDefaultAccountCode ||
                    (this.SalesDefaultAccountCode != null &&
                    this.SalesDefaultAccountCode.Equals(input.SalesDefaultAccountCode))
                ) && 
                (
                    this.PurchasesDefaultAccountCode == input.PurchasesDefaultAccountCode ||
                    (this.PurchasesDefaultAccountCode != null &&
                    this.PurchasesDefaultAccountCode.Equals(input.PurchasesDefaultAccountCode))
                ) && 
                (
                    this.SalesTrackingCategories == input.SalesTrackingCategories ||
                    this.SalesTrackingCategories != null &&
                    input.SalesTrackingCategories != null &&
                    this.SalesTrackingCategories.SequenceEqual(input.SalesTrackingCategories)
                ) && 
                (
                    this.PurchasesTrackingCategories == input.PurchasesTrackingCategories ||
                    this.PurchasesTrackingCategories != null &&
                    input.PurchasesTrackingCategories != null &&
                    this.PurchasesTrackingCategories.SequenceEqual(input.PurchasesTrackingCategories)
                ) && 
                (
                    this.TrackingCategoryName == input.TrackingCategoryName ||
                    (this.TrackingCategoryName != null &&
                    this.TrackingCategoryName.Equals(input.TrackingCategoryName))
                ) && 
                (
                    this.TrackingCategoryOption == input.TrackingCategoryOption ||
                    (this.TrackingCategoryOption != null &&
                    this.TrackingCategoryOption.Equals(input.TrackingCategoryOption))
                ) && 
                (
                    this.PaymentTerms == input.PaymentTerms ||
                    (this.PaymentTerms != null &&
                    this.PaymentTerms.Equals(input.PaymentTerms))
                ) && 
                (
                    this.UpdatedDateUTC == input.UpdatedDateUTC ||
                    (this.UpdatedDateUTC != null &&
                    this.UpdatedDateUTC.Equals(input.UpdatedDateUTC))
                ) && 
                (
                    this.ContactGroups == input.ContactGroups ||
                    this.ContactGroups != null &&
                    input.ContactGroups != null &&
                    this.ContactGroups.SequenceEqual(input.ContactGroups)
                ) && 
                (
                    this.Website == input.Website ||
                    (this.Website != null &&
                    this.Website.Equals(input.Website))
                ) && 
                (
                    this.BrandingTheme == input.BrandingTheme ||
                    (this.BrandingTheme != null &&
                    this.BrandingTheme.Equals(input.BrandingTheme))
                ) && 
                (
                    this.BatchPayments == input.BatchPayments ||
                    (this.BatchPayments != null &&
                    this.BatchPayments.Equals(input.BatchPayments))
                ) && 
                (
                    this.Discount == input.Discount ||
                    this.Discount.Equals(input.Discount)
                ) && 
                (
                    this.Balances == input.Balances ||
                    (this.Balances != null &&
                    this.Balances.Equals(input.Balances))
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
                ) && 
                (
                    this.HasAttachments == input.HasAttachments ||
                    this.HasAttachments.Equals(input.HasAttachments)
                ) && 
                (
                    this.ValidationErrors == input.ValidationErrors ||
                    this.ValidationErrors != null &&
                    input.ValidationErrors != null &&
                    this.ValidationErrors.SequenceEqual(input.ValidationErrors)
                ) && 
                (
                    this.HasValidationErrors == input.HasValidationErrors ||
                    this.HasValidationErrors.Equals(input.HasValidationErrors)
                ) && 
                (
                    this.StatusAttributeString == input.StatusAttributeString ||
                    (this.StatusAttributeString != null &&
                    this.StatusAttributeString.Equals(input.StatusAttributeString))
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
                if (this.ContactID != null)
                    hashCode = hashCode * 59 + this.ContactID.GetHashCode();
                if (this.ContactNumber != null)
                    hashCode = hashCode * 59 + this.ContactNumber.GetHashCode();
                if (this.AccountNumber != null)
                    hashCode = hashCode * 59 + this.AccountNumber.GetHashCode();
                hashCode = hashCode * 59 + this.ContactStatus.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.SkypeUserName != null)
                    hashCode = hashCode * 59 + this.SkypeUserName.GetHashCode();
                if (this.ContactPersons != null)
                    hashCode = hashCode * 59 + this.ContactPersons.GetHashCode();
                if (this.BankAccountDetails != null)
                    hashCode = hashCode * 59 + this.BankAccountDetails.GetHashCode();
                if (this.TaxNumber != null)
                    hashCode = hashCode * 59 + this.TaxNumber.GetHashCode();
                if (this.AccountsReceivableTaxType != null)
                    hashCode = hashCode * 59 + this.AccountsReceivableTaxType.GetHashCode();
                if (this.AccountsPayableTaxType != null)
                    hashCode = hashCode * 59 + this.AccountsPayableTaxType.GetHashCode();
                if (this.Addresses != null)
                    hashCode = hashCode * 59 + this.Addresses.GetHashCode();
                if (this.Phones != null)
                    hashCode = hashCode * 59 + this.Phones.GetHashCode();
                hashCode = hashCode * 59 + this.IsSupplier.GetHashCode();
                hashCode = hashCode * 59 + this.IsCustomer.GetHashCode();
                hashCode = hashCode * 59 + this.DefaultCurrency.GetHashCode();
                if (this.XeroNetworkKey != null)
                    hashCode = hashCode * 59 + this.XeroNetworkKey.GetHashCode();
                if (this.SalesDefaultAccountCode != null)
                    hashCode = hashCode * 59 + this.SalesDefaultAccountCode.GetHashCode();
                if (this.PurchasesDefaultAccountCode != null)
                    hashCode = hashCode * 59 + this.PurchasesDefaultAccountCode.GetHashCode();
                if (this.SalesTrackingCategories != null)
                    hashCode = hashCode * 59 + this.SalesTrackingCategories.GetHashCode();
                if (this.PurchasesTrackingCategories != null)
                    hashCode = hashCode * 59 + this.PurchasesTrackingCategories.GetHashCode();
                if (this.TrackingCategoryName != null)
                    hashCode = hashCode * 59 + this.TrackingCategoryName.GetHashCode();
                if (this.TrackingCategoryOption != null)
                    hashCode = hashCode * 59 + this.TrackingCategoryOption.GetHashCode();
                if (this.PaymentTerms != null)
                    hashCode = hashCode * 59 + this.PaymentTerms.GetHashCode();
                if (this.UpdatedDateUTC != null)
                    hashCode = hashCode * 59 + this.UpdatedDateUTC.GetHashCode();
                if (this.ContactGroups != null)
                    hashCode = hashCode * 59 + this.ContactGroups.GetHashCode();
                if (this.Website != null)
                    hashCode = hashCode * 59 + this.Website.GetHashCode();
                if (this.BrandingTheme != null)
                    hashCode = hashCode * 59 + this.BrandingTheme.GetHashCode();
                if (this.BatchPayments != null)
                    hashCode = hashCode * 59 + this.BatchPayments.GetHashCode();
                hashCode = hashCode * 59 + this.Discount.GetHashCode();
                if (this.Balances != null)
                    hashCode = hashCode * 59 + this.Balances.GetHashCode();
                if (this.Attachments != null)
                    hashCode = hashCode * 59 + this.Attachments.GetHashCode();
                hashCode = hashCode * 59 + this.HasAttachments.GetHashCode();
                if (this.ValidationErrors != null)
                    hashCode = hashCode * 59 + this.ValidationErrors.GetHashCode();
                hashCode = hashCode * 59 + this.HasValidationErrors.GetHashCode();
                if (this.StatusAttributeString != null)
                    hashCode = hashCode * 59 + this.StatusAttributeString.GetHashCode();
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
            // ContactNumber (string) maxLength
            if(this.ContactNumber != null && this.ContactNumber.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ContactNumber, length must be less than 50.", new [] { "ContactNumber" });
            }

            // AccountNumber (string) maxLength
            if(this.AccountNumber != null && this.AccountNumber.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AccountNumber, length must be less than 50.", new [] { "AccountNumber" });
            }

            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 255.", new [] { "Name" });
            }

            // FirstName (string) maxLength
            if(this.FirstName != null && this.FirstName.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FirstName, length must be less than 255.", new [] { "FirstName" });
            }

            // LastName (string) maxLength
            if(this.LastName != null && this.LastName.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastName, length must be less than 255.", new [] { "LastName" });
            }

            // EmailAddress (string) maxLength
            if(this.EmailAddress != null && this.EmailAddress.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for EmailAddress, length must be less than 255.", new [] { "EmailAddress" });
            }

            // TaxNumber (string) maxLength
            if(this.TaxNumber != null && this.TaxNumber.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TaxNumber, length must be less than 50.", new [] { "TaxNumber" });
            }

            yield break;
        }
    }

}
