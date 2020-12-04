/* 
 * Xero Payroll AU
 *
 * This is the Xero Payroll API for orgs in Australia region.
 *
 * The version of the OpenAPI document: 2.6.0
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
    /// Defines TimesheetStatus
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum TimesheetStatus
    {
        /// <summary>
        /// Enum DRAFT for value: DRAFT
        /// </summary>
        [EnumMember(Value = "DRAFT")]
        DRAFT = 1,

        /// <summary>
        /// Enum PROCESSED for value: PROCESSED
        /// </summary>
        [EnumMember(Value = "PROCESSED")]
        PROCESSED = 2,

        /// <summary>
        /// Enum APPROVED for value: APPROVED
        /// </summary>
        [EnumMember(Value = "APPROVED")]
        APPROVED = 3,

        /// <summary>
        /// Enum REJECTED for value: REJECTED
        /// </summary>
        [EnumMember(Value = "REJECTED")]
        REJECTED = 4,

        /// <summary>
        /// Enum REQUESTED for value: REQUESTED
        /// </summary>
        [EnumMember(Value = "REQUESTED")]
        REQUESTED = 5

    }

}
