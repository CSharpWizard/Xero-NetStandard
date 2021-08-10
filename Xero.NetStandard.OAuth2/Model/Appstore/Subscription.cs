/* 
 * Xero AppStore API
 *
 * These endpoints are for Xero Partners to interact with the App Store Billing platform
 *
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

namespace Xero.NetStandard.OAuth2.Model.Appstore
{
    /// <summary>
    /// Subscription
    /// </summary>
    [DataContract]
    public partial class Subscription :  IEquatable<Subscription>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Subscription" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Subscription() 
        {  
          Plans = new List<Plan>(); 
        }
        
        /// <summary>
        /// End of the current period that the subscription has been invoiced for. 
        /// </summary>
        /// <value>End of the current period that the subscription has been invoiced for. </value>
        [DataMember(Name="currentPeriodEnd", EmitDefaultValue=false)]
        public DateTime? CurrentPeriodEnd { get; set; }

        /// <summary>
        /// If the subscription has been canceled, this is the date when the subscription ends. If null, the subscription is active and has not been cancelled
        /// </summary>
        /// <value>If the subscription has been canceled, this is the date when the subscription ends. If null, the subscription is active and has not been cancelled</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// The unique identifier of the subscription
        /// </summary>
        /// <value>The unique identifier of the subscription</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// The Xero generated unique identifier for the organisation
        /// </summary>
        /// <value>The Xero generated unique identifier for the organisation</value>
        [DataMember(Name="organisationId", EmitDefaultValue=false)]
        public Guid? OrganisationId { get; set; }

        /// <summary>
        /// List of plans for the subscription.
        /// </summary>
        /// <value>List of plans for the subscription.</value>
        [DataMember(Name="plans", EmitDefaultValue=false)]
        public List<Plan> Plans { get; set; }

        /// <summary>
        /// Date when the subscription was first created.
        /// </summary>
        /// <value>Date when the subscription was first created.</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Status of the subscription. Available statuses are ACTIVE, CANCELED, and PAST_DUE.
        /// </summary>
        /// <value>Status of the subscription. Available statuses are ACTIVE, CANCELED, and PAST_DUE.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Boolean used to indicate if the subscription is in test mode
        /// </summary>
        /// <value>Boolean used to indicate if the subscription is in test mode</value>
        [DataMember(Name="testMode", EmitDefaultValue=false)]
        public bool? TestMode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Subscription {\n");
            sb.Append("  CurrentPeriodEnd: ").Append(CurrentPeriodEnd).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OrganisationId: ").Append(OrganisationId).Append("\n");
            sb.Append("  Plans: ").Append(Plans).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TestMode: ").Append(TestMode).Append("\n");
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
            return this.Equals(input as Subscription);
        }

        /// <summary>
        /// Returns true if Subscription instances are equal
        /// </summary>
        /// <param name="input">Instance of Subscription to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Subscription input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CurrentPeriodEnd == input.CurrentPeriodEnd ||
                    (this.CurrentPeriodEnd != null &&
                    this.CurrentPeriodEnd.Equals(input.CurrentPeriodEnd))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.OrganisationId == input.OrganisationId ||
                    (this.OrganisationId != null &&
                    this.OrganisationId.Equals(input.OrganisationId))
                ) && 
                (
                    this.Plans == input.Plans ||
                    this.Plans != null &&
                    input.Plans != null &&
                    this.Plans.SequenceEqual(input.Plans)
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.TestMode == input.TestMode ||
                    (this.TestMode != null &&
                    this.TestMode.Equals(input.TestMode))
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
                if (this.CurrentPeriodEnd != null)
                    hashCode = hashCode * 59 + this.CurrentPeriodEnd.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.OrganisationId != null)
                    hashCode = hashCode * 59 + this.OrganisationId.GetHashCode();
                if (this.Plans != null)
                    hashCode = hashCode * 59 + this.Plans.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TestMode != null)
                    hashCode = hashCode * 59 + this.TestMode.GetHashCode();
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
