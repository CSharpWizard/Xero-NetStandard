/* 
 * Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.2.11
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
    /// Defines PaymentTermType
    /// </summary>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PaymentTermType
    {
        /// <summary>
        /// Enum DAYSAFTERBILLDATE for value: DAYSAFTERBILLDATE
        /// </summary>
        [EnumMember(Value = "DAYSAFTERBILLDATE")]
        DAYSAFTERBILLDATE = 1,

        /// <summary>
        /// Enum DAYSAFTERBILLMONTH for value: DAYSAFTERBILLMONTH
        /// </summary>
        [EnumMember(Value = "DAYSAFTERBILLMONTH")]
        DAYSAFTERBILLMONTH = 2,

        /// <summary>
        /// Enum OFCURRENTMONTH for value: OFCURRENTMONTH
        /// </summary>
        [EnumMember(Value = "OFCURRENTMONTH")]
        OFCURRENTMONTH = 3,

        /// <summary>
        /// Enum OFFOLLOWINGMONTH for value: OFFOLLOWINGMONTH
        /// </summary>
        [EnumMember(Value = "OFFOLLOWINGMONTH")]
        OFFOLLOWINGMONTH = 4

    }

}
