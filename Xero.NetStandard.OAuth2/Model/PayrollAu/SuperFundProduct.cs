/* 
 * Xero Payroll AU
 *
 * This is the Xero Payroll API for orgs in Australia region.
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

namespace Xero.NetStandard.OAuth2.Model.PayrollAu
{
    /// <summary>
    /// SuperFundProduct
    /// </summary>
    [DataContract]
    public partial class SuperFundProduct :  IEquatable<SuperFundProduct>, IValidatableObject
    {
        
        /// <summary>
        /// The ABN of the Regulated SuperFund
        /// </summary>
        /// <value>The ABN of the Regulated SuperFund</value>
        [DataMember(Name="ABN", EmitDefaultValue=false)]
        public string ABN { get; set; }

        /// <summary>
        /// The USI of the Regulated SuperFund
        /// </summary>
        /// <value>The USI of the Regulated SuperFund</value>
        [DataMember(Name="USI", EmitDefaultValue=false)]
        public string USI { get; set; }

        /// <summary>
        /// The SPIN of the Regulated SuperFund. This field has been deprecated. New superfunds will not have a SPIN value. The USI field should be used instead of SPIN
        /// </summary>
        /// <value>The SPIN of the Regulated SuperFund. This field has been deprecated. New superfunds will not have a SPIN value. The USI field should be used instead of SPIN</value>
        [DataMember(Name="SPIN", EmitDefaultValue=false)]
        public string SPIN { get; set; }

        /// <summary>
        /// The name of the Regulated SuperFund
        /// </summary>
        /// <value>The name of the Regulated SuperFund</value>
        [DataMember(Name="ProductName", EmitDefaultValue=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SuperFundProduct {\n");
            sb.Append("  ABN: ").Append(ABN).Append("\n");
            sb.Append("  USI: ").Append(USI).Append("\n");
            sb.Append("  SPIN: ").Append(SPIN).Append("\n");
            sb.Append("  ProductName: ").Append(ProductName).Append("\n");
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
            return this.Equals(input as SuperFundProduct);
        }

        /// <summary>
        /// Returns true if SuperFundProduct instances are equal
        /// </summary>
        /// <param name="input">Instance of SuperFundProduct to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SuperFundProduct input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ABN == input.ABN ||
                    (this.ABN != null &&
                    this.ABN.Equals(input.ABN))
                ) && 
                (
                    this.USI == input.USI ||
                    (this.USI != null &&
                    this.USI.Equals(input.USI))
                ) && 
                (
                    this.SPIN == input.SPIN ||
                    (this.SPIN != null &&
                    this.SPIN.Equals(input.SPIN))
                ) && 
                (
                    this.ProductName == input.ProductName ||
                    (this.ProductName != null &&
                    this.ProductName.Equals(input.ProductName))
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
                if (this.ABN != null)
                    hashCode = hashCode * 59 + this.ABN.GetHashCode();
                if (this.USI != null)
                    hashCode = hashCode * 59 + this.USI.GetHashCode();
                if (this.SPIN != null)
                    hashCode = hashCode * 59 + this.SPIN.GetHashCode();
                if (this.ProductName != null)
                    hashCode = hashCode * 59 + this.ProductName.GetHashCode();
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
