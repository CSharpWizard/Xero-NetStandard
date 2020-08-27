/* 
 * Xero Payroll AU
 *
 * This is the Xero Payroll API for orgs in Australia region.
 *
 * The version of the OpenAPI document: 2.2.14
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

namespace Xero.NetStandard.OAuth2.Model.PayrollAu
{
    /// <summary>
    /// Employee
    /// </summary>
    [DataContract]
    public partial class Employee :  IEquatable<Employee>, IValidatableObject
    {
        /// <summary>
        /// The employee’s gender. See Employee Gender
        /// </summary>
        /// <value>The employee’s gender. See Employee Gender</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GenderEnum
        {
            /// <summary>
            /// Enum N for value: N
            /// </summary>
            [EnumMember(Value = "N")]
            N = 1,

            /// <summary>
            /// Enum M for value: M
            /// </summary>
            [EnumMember(Value = "M")]
            M = 2,

            /// <summary>
            /// Enum F for value: F
            /// </summary>
            [EnumMember(Value = "F")]
            F = 3,

            /// <summary>
            /// Enum I for value: I
            /// </summary>
            [EnumMember(Value = "I")]
            I = 4

        }

        /// <summary>
        /// The employee’s gender. See Employee Gender
        /// </summary>
        /// <value>The employee’s gender. See Employee Gender</value>
        [DataMember(Name="Gender", EmitDefaultValue=false)]
        public GenderEnum Gender { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public EmployeeStatus Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Employee" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Employee() 
        {  
          BankAccounts = new List<BankAccount>();  
          LeaveBalances = new List<LeaveBalance>();  
          LeaveLines = new List<LeaveLine>();  
          SuperMemberships = new List<SuperMembership>();  
          ValidationErrors = new List<ValidationError>(); 
        }
        
        /// <summary>
        /// First name of employee
        /// </summary>
        /// <value>First name of employee</value>
        [DataMember(Name="FirstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of employee
        /// </summary>
        /// <value>Last name of employee</value>
        [DataMember(Name="LastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Date of birth of the employee (YYYY-MM-DD)
        /// </summary>
        /// <value>Date of birth of the employee (YYYY-MM-DD)</value>
        [DataMember(Name="DateOfBirth", EmitDefaultValue=false)]
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Gets or Sets HomeAddress
        /// </summary>
        [DataMember(Name="HomeAddress", EmitDefaultValue=false)]
        public HomeAddress HomeAddress { get; set; }

        /// <summary>
        /// Start date for an employee (YYYY-MM-DD)
        /// </summary>
        /// <value>Start date for an employee (YYYY-MM-DD)</value>
        [DataMember(Name="StartDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Title of the employee
        /// </summary>
        /// <value>Title of the employee</value>
        [DataMember(Name="Title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Middle name(s) of the employee
        /// </summary>
        /// <value>Middle name(s) of the employee</value>
        [DataMember(Name="MiddleNames", EmitDefaultValue=false)]
        public string MiddleNames { get; set; }

        /// <summary>
        /// The email address for the employee
        /// </summary>
        /// <value>The email address for the employee</value>
        [DataMember(Name="Email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// Employee phone number
        /// </summary>
        /// <value>Employee phone number</value>
        [DataMember(Name="Phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// Employee mobile number
        /// </summary>
        /// <value>Employee mobile number</value>
        [DataMember(Name="Mobile", EmitDefaultValue=false)]
        public string Mobile { get; set; }

        /// <summary>
        /// Employee’s twitter name
        /// </summary>
        /// <value>Employee’s twitter name</value>
        [DataMember(Name="TwitterUserName", EmitDefaultValue=false)]
        public string TwitterUserName { get; set; }

        /// <summary>
        /// Authorised to approve other employees&#39; leave requests
        /// </summary>
        /// <value>Authorised to approve other employees&#39; leave requests</value>
        [DataMember(Name="IsAuthorisedToApproveLeave", EmitDefaultValue=false)]
        public bool? IsAuthorisedToApproveLeave { get; set; }

        /// <summary>
        /// Authorised to approve timesheets
        /// </summary>
        /// <value>Authorised to approve timesheets</value>
        [DataMember(Name="IsAuthorisedToApproveTimesheets", EmitDefaultValue=false)]
        public bool? IsAuthorisedToApproveTimesheets { get; set; }

        /// <summary>
        /// JobTitle of the employee
        /// </summary>
        /// <value>JobTitle of the employee</value>
        [DataMember(Name="JobTitle", EmitDefaultValue=false)]
        public string JobTitle { get; set; }

        /// <summary>
        /// Employees classification
        /// </summary>
        /// <value>Employees classification</value>
        [DataMember(Name="Classification", EmitDefaultValue=false)]
        public string Classification { get; set; }

        /// <summary>
        /// Xero unique identifier for earnings rate
        /// </summary>
        /// <value>Xero unique identifier for earnings rate</value>
        [DataMember(Name="OrdinaryEarningsRateID", EmitDefaultValue=false)]
        public Guid? OrdinaryEarningsRateID { get; set; }

        /// <summary>
        /// Xero unique identifier for payroll calendar for the employee
        /// </summary>
        /// <value>Xero unique identifier for payroll calendar for the employee</value>
        [DataMember(Name="PayrollCalendarID", EmitDefaultValue=false)]
        public Guid? PayrollCalendarID { get; set; }

        /// <summary>
        /// The Employee Group allows you to report on payroll expenses and liabilities for each group of employees
        /// </summary>
        /// <value>The Employee Group allows you to report on payroll expenses and liabilities for each group of employees</value>
        [DataMember(Name="EmployeeGroupName", EmitDefaultValue=false)]
        public string EmployeeGroupName { get; set; }

        /// <summary>
        /// Xero unique identifier for an Employee
        /// </summary>
        /// <value>Xero unique identifier for an Employee</value>
        [DataMember(Name="EmployeeID", EmitDefaultValue=false)]
        public Guid? EmployeeID { get; set; }

        /// <summary>
        /// Employee Termination Date (YYYY-MM-DD)
        /// </summary>
        /// <value>Employee Termination Date (YYYY-MM-DD)</value>
        [DataMember(Name="TerminationDate", EmitDefaultValue=false)]
        public DateTime? TerminationDate { get; set; }

        /// <summary>
        /// Gets or Sets BankAccounts
        /// </summary>
        [DataMember(Name="BankAccounts", EmitDefaultValue=false)]
        public List<BankAccount> BankAccounts { get; set; }

        /// <summary>
        /// Gets or Sets PayTemplate
        /// </summary>
        [DataMember(Name="PayTemplate", EmitDefaultValue=false)]
        public PayTemplate PayTemplate { get; set; }

        /// <summary>
        /// Gets or Sets OpeningBalances
        /// </summary>
        [DataMember(Name="OpeningBalances", EmitDefaultValue=false)]
        public OpeningBalances OpeningBalances { get; set; }

        /// <summary>
        /// Gets or Sets TaxDeclaration
        /// </summary>
        [DataMember(Name="TaxDeclaration", EmitDefaultValue=false)]
        public TaxDeclaration TaxDeclaration { get; set; }

        /// <summary>
        /// Gets or Sets LeaveBalances
        /// </summary>
        [DataMember(Name="LeaveBalances", EmitDefaultValue=false)]
        public List<LeaveBalance> LeaveBalances { get; set; }

        /// <summary>
        /// Gets or Sets LeaveLines
        /// </summary>
        [DataMember(Name="LeaveLines", EmitDefaultValue=false)]
        public List<LeaveLine> LeaveLines { get; set; }

        /// <summary>
        /// Gets or Sets SuperMemberships
        /// </summary>
        [DataMember(Name="SuperMemberships", EmitDefaultValue=false)]
        public List<SuperMembership> SuperMemberships { get; set; }

        /// <summary>
        /// Last modified timestamp
        /// </summary>
        /// <value>Last modified timestamp</value>
        [DataMember(Name="UpdatedDateUTC", EmitDefaultValue=false)]
        public DateTime? UpdatedDateUTC { get; private set; }

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
            sb.Append("class Employee {\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  DateOfBirth: ").Append(DateOfBirth).Append("\n");
            sb.Append("  HomeAddress: ").Append(HomeAddress).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  MiddleNames: ").Append(MiddleNames).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Mobile: ").Append(Mobile).Append("\n");
            sb.Append("  TwitterUserName: ").Append(TwitterUserName).Append("\n");
            sb.Append("  IsAuthorisedToApproveLeave: ").Append(IsAuthorisedToApproveLeave).Append("\n");
            sb.Append("  IsAuthorisedToApproveTimesheets: ").Append(IsAuthorisedToApproveTimesheets).Append("\n");
            sb.Append("  JobTitle: ").Append(JobTitle).Append("\n");
            sb.Append("  Classification: ").Append(Classification).Append("\n");
            sb.Append("  OrdinaryEarningsRateID: ").Append(OrdinaryEarningsRateID).Append("\n");
            sb.Append("  PayrollCalendarID: ").Append(PayrollCalendarID).Append("\n");
            sb.Append("  EmployeeGroupName: ").Append(EmployeeGroupName).Append("\n");
            sb.Append("  EmployeeID: ").Append(EmployeeID).Append("\n");
            sb.Append("  TerminationDate: ").Append(TerminationDate).Append("\n");
            sb.Append("  BankAccounts: ").Append(BankAccounts).Append("\n");
            sb.Append("  PayTemplate: ").Append(PayTemplate).Append("\n");
            sb.Append("  OpeningBalances: ").Append(OpeningBalances).Append("\n");
            sb.Append("  TaxDeclaration: ").Append(TaxDeclaration).Append("\n");
            sb.Append("  LeaveBalances: ").Append(LeaveBalances).Append("\n");
            sb.Append("  LeaveLines: ").Append(LeaveLines).Append("\n");
            sb.Append("  SuperMemberships: ").Append(SuperMemberships).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UpdatedDateUTC: ").Append(UpdatedDateUTC).Append("\n");
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
            return this.Equals(input as Employee);
        }

        /// <summary>
        /// Returns true if Employee instances are equal
        /// </summary>
        /// <param name="input">Instance of Employee to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Employee input)
        {
            if (input == null)
                return false;

            return 
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
                    this.DateOfBirth == input.DateOfBirth ||
                    (this.DateOfBirth != null &&
                    this.DateOfBirth.Equals(input.DateOfBirth))
                ) && 
                (
                    this.HomeAddress == input.HomeAddress ||
                    (this.HomeAddress != null &&
                    this.HomeAddress.Equals(input.HomeAddress))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.MiddleNames == input.MiddleNames ||
                    (this.MiddleNames != null &&
                    this.MiddleNames.Equals(input.MiddleNames))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Gender == input.Gender ||
                    this.Gender.Equals(input.Gender)
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.Mobile == input.Mobile ||
                    (this.Mobile != null &&
                    this.Mobile.Equals(input.Mobile))
                ) && 
                (
                    this.TwitterUserName == input.TwitterUserName ||
                    (this.TwitterUserName != null &&
                    this.TwitterUserName.Equals(input.TwitterUserName))
                ) && 
                (
                    this.IsAuthorisedToApproveLeave == input.IsAuthorisedToApproveLeave ||
                    this.IsAuthorisedToApproveLeave.Equals(input.IsAuthorisedToApproveLeave)
                ) && 
                (
                    this.IsAuthorisedToApproveTimesheets == input.IsAuthorisedToApproveTimesheets ||
                    this.IsAuthorisedToApproveTimesheets.Equals(input.IsAuthorisedToApproveTimesheets)
                ) && 
                (
                    this.JobTitle == input.JobTitle ||
                    (this.JobTitle != null &&
                    this.JobTitle.Equals(input.JobTitle))
                ) && 
                (
                    this.Classification == input.Classification ||
                    (this.Classification != null &&
                    this.Classification.Equals(input.Classification))
                ) && 
                (
                    this.OrdinaryEarningsRateID == input.OrdinaryEarningsRateID ||
                    (this.OrdinaryEarningsRateID != null &&
                    this.OrdinaryEarningsRateID.Equals(input.OrdinaryEarningsRateID))
                ) && 
                (
                    this.PayrollCalendarID == input.PayrollCalendarID ||
                    (this.PayrollCalendarID != null &&
                    this.PayrollCalendarID.Equals(input.PayrollCalendarID))
                ) && 
                (
                    this.EmployeeGroupName == input.EmployeeGroupName ||
                    (this.EmployeeGroupName != null &&
                    this.EmployeeGroupName.Equals(input.EmployeeGroupName))
                ) && 
                (
                    this.EmployeeID == input.EmployeeID ||
                    (this.EmployeeID != null &&
                    this.EmployeeID.Equals(input.EmployeeID))
                ) && 
                (
                    this.TerminationDate == input.TerminationDate ||
                    (this.TerminationDate != null &&
                    this.TerminationDate.Equals(input.TerminationDate))
                ) && 
                (
                    this.BankAccounts == input.BankAccounts ||
                    this.BankAccounts != null &&
                    input.BankAccounts != null &&
                    this.BankAccounts.SequenceEqual(input.BankAccounts)
                ) && 
                (
                    this.PayTemplate == input.PayTemplate ||
                    (this.PayTemplate != null &&
                    this.PayTemplate.Equals(input.PayTemplate))
                ) && 
                (
                    this.OpeningBalances == input.OpeningBalances ||
                    (this.OpeningBalances != null &&
                    this.OpeningBalances.Equals(input.OpeningBalances))
                ) && 
                (
                    this.TaxDeclaration == input.TaxDeclaration ||
                    (this.TaxDeclaration != null &&
                    this.TaxDeclaration.Equals(input.TaxDeclaration))
                ) && 
                (
                    this.LeaveBalances == input.LeaveBalances ||
                    this.LeaveBalances != null &&
                    input.LeaveBalances != null &&
                    this.LeaveBalances.SequenceEqual(input.LeaveBalances)
                ) && 
                (
                    this.LeaveLines == input.LeaveLines ||
                    this.LeaveLines != null &&
                    input.LeaveLines != null &&
                    this.LeaveLines.SequenceEqual(input.LeaveLines)
                ) && 
                (
                    this.SuperMemberships == input.SuperMemberships ||
                    this.SuperMemberships != null &&
                    input.SuperMemberships != null &&
                    this.SuperMemberships.SequenceEqual(input.SuperMemberships)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.UpdatedDateUTC == input.UpdatedDateUTC ||
                    (this.UpdatedDateUTC != null &&
                    this.UpdatedDateUTC.Equals(input.UpdatedDateUTC))
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
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.DateOfBirth != null)
                    hashCode = hashCode * 59 + this.DateOfBirth.GetHashCode();
                if (this.HomeAddress != null)
                    hashCode = hashCode * 59 + this.HomeAddress.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.MiddleNames != null)
                    hashCode = hashCode * 59 + this.MiddleNames.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                hashCode = hashCode * 59 + this.Gender.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Mobile != null)
                    hashCode = hashCode * 59 + this.Mobile.GetHashCode();
                if (this.TwitterUserName != null)
                    hashCode = hashCode * 59 + this.TwitterUserName.GetHashCode();
                hashCode = hashCode * 59 + this.IsAuthorisedToApproveLeave.GetHashCode();
                hashCode = hashCode * 59 + this.IsAuthorisedToApproveTimesheets.GetHashCode();
                if (this.JobTitle != null)
                    hashCode = hashCode * 59 + this.JobTitle.GetHashCode();
                if (this.Classification != null)
                    hashCode = hashCode * 59 + this.Classification.GetHashCode();
                if (this.OrdinaryEarningsRateID != null)
                    hashCode = hashCode * 59 + this.OrdinaryEarningsRateID.GetHashCode();
                if (this.PayrollCalendarID != null)
                    hashCode = hashCode * 59 + this.PayrollCalendarID.GetHashCode();
                if (this.EmployeeGroupName != null)
                    hashCode = hashCode * 59 + this.EmployeeGroupName.GetHashCode();
                if (this.EmployeeID != null)
                    hashCode = hashCode * 59 + this.EmployeeID.GetHashCode();
                if (this.TerminationDate != null)
                    hashCode = hashCode * 59 + this.TerminationDate.GetHashCode();
                if (this.BankAccounts != null)
                    hashCode = hashCode * 59 + this.BankAccounts.GetHashCode();
                if (this.PayTemplate != null)
                    hashCode = hashCode * 59 + this.PayTemplate.GetHashCode();
                if (this.OpeningBalances != null)
                    hashCode = hashCode * 59 + this.OpeningBalances.GetHashCode();
                if (this.TaxDeclaration != null)
                    hashCode = hashCode * 59 + this.TaxDeclaration.GetHashCode();
                if (this.LeaveBalances != null)
                    hashCode = hashCode * 59 + this.LeaveBalances.GetHashCode();
                if (this.LeaveLines != null)
                    hashCode = hashCode * 59 + this.LeaveLines.GetHashCode();
                if (this.SuperMemberships != null)
                    hashCode = hashCode * 59 + this.SuperMemberships.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.UpdatedDateUTC != null)
                    hashCode = hashCode * 59 + this.UpdatedDateUTC.GetHashCode();
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
