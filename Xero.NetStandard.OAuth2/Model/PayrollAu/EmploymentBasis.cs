/* 
 * Xero Payroll AU
 *
 * This is the Xero Payroll API for orgs in Australia region.
 *
 * The version of the OpenAPI document: 2.5.0
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
    /// Defines EmploymentBasis
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum EmploymentBasis
    {
        /// <summary>
        /// Enum FULLTIME for value: FULLTIME
        /// </summary>
        [EnumMember(Value = "FULLTIME")]
        FULLTIME = 1,

        /// <summary>
        /// Enum PARTTIME for value: PARTTIME
        /// </summary>
        [EnumMember(Value = "PARTTIME")]
        PARTTIME = 2,

        /// <summary>
        /// Enum CASUAL for value: CASUAL
        /// </summary>
        [EnumMember(Value = "CASUAL")]
        CASUAL = 3,

        /// <summary>
        /// Enum LABOURHIRE for value: LABOURHIRE
        /// </summary>
        [EnumMember(Value = "LABOURHIRE")]
        LABOURHIRE = 4,

        /// <summary>
        /// Enum SUPERINCOMESTREAM for value: SUPERINCOMESTREAM
        /// </summary>
        [EnumMember(Value = "SUPERINCOMESTREAM")]
        SUPERINCOMESTREAM = 5

    }

}
