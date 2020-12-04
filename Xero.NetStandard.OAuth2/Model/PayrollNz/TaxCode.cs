/* 
 * Xero Payroll NZ
 *
 * This is the Xero Payroll API for orgs in the NZ region.
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

namespace Xero.NetStandard.OAuth2.Model.PayrollNz
{
    /// <summary>
    /// Tax codes used for employee tax
    /// </summary>
    /// <value>Tax codes used for employee tax</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum TaxCode
    {
        /// <summary>
        /// Enum ND for value: ND
        /// </summary>
        [EnumMember(Value = "ND")]
        ND = 1,

        /// <summary>
        /// Enum M for value: M
        /// </summary>
        [EnumMember(Value = "M")]
        M = 2,

        /// <summary>
        /// Enum ME for value: ME
        /// </summary>
        [EnumMember(Value = "ME")]
        ME = 3,

        /// <summary>
        /// Enum MSL for value: MSL
        /// </summary>
        [EnumMember(Value = "MSL")]
        MSL = 4,

        /// <summary>
        /// Enum MESL for value: MESL
        /// </summary>
        [EnumMember(Value = "MESL")]
        MESL = 5,

        /// <summary>
        /// Enum SB for value: SB
        /// </summary>
        [EnumMember(Value = "SB")]
        SB = 6,

        /// <summary>
        /// Enum S for value: S
        /// </summary>
        [EnumMember(Value = "S")]
        S = 7,

        /// <summary>
        /// Enum SH for value: SH
        /// </summary>
        [EnumMember(Value = "SH")]
        SH = 8,

        /// <summary>
        /// Enum ST for value: ST
        /// </summary>
        [EnumMember(Value = "ST")]
        ST = 9,

        /// <summary>
        /// Enum SBSL for value: SBSL
        /// </summary>
        [EnumMember(Value = "SBSL")]
        SBSL = 10,

        /// <summary>
        /// Enum SSL for value: SSL
        /// </summary>
        [EnumMember(Value = "SSL")]
        SSL = 11,

        /// <summary>
        /// Enum SHSL for value: SHSL
        /// </summary>
        [EnumMember(Value = "SHSL")]
        SHSL = 12,

        /// <summary>
        /// Enum STSL for value: STSL
        /// </summary>
        [EnumMember(Value = "STSL")]
        STSL = 13,

        /// <summary>
        /// Enum WT for value: WT
        /// </summary>
        [EnumMember(Value = "WT")]
        WT = 14,

        /// <summary>
        /// Enum CAE for value: CAE
        /// </summary>
        [EnumMember(Value = "CAE")]
        CAE = 15,

        /// <summary>
        /// Enum EDW for value: EDW
        /// </summary>
        [EnumMember(Value = "EDW")]
        EDW = 16,

        /// <summary>
        /// Enum NSW for value: NSW
        /// </summary>
        [EnumMember(Value = "NSW")]
        NSW = 17,

        /// <summary>
        /// Enum STC for value: STC
        /// </summary>
        [EnumMember(Value = "STC")]
        STC = 18,

        /// <summary>
        /// Enum STCSL for value: STCSL
        /// </summary>
        [EnumMember(Value = "STCSL")]
        STCSL = 19

    }

}
