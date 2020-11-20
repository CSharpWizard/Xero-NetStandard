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
    /// Defines EntitlementFinalPayPayoutType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum EntitlementFinalPayPayoutType
    {
        /// <summary>
        /// Enum NOTPAIDOUT for value: NOTPAIDOUT
        /// </summary>
        [EnumMember(Value = "NOTPAIDOUT")]
        NOTPAIDOUT = 1,

        /// <summary>
        /// Enum PAIDOUT for value: PAIDOUT
        /// </summary>
        [EnumMember(Value = "PAIDOUT")]
        PAIDOUT = 2

    }

}
