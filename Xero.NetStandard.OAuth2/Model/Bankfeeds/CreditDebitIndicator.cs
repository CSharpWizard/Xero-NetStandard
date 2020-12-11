/* 
 * Bank Feeds API
 *
 * This specifing endpoints Xero Bank feeds API
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

namespace Xero.NetStandard.OAuth2.Model.Bankfeeds
{
    /// <summary>
    /// If the statement balances are credit or debit, the CreditDebitIndicator should be specified from the perspective of the Customer.
    /// </summary>
    /// <value>If the statement balances are credit or debit, the CreditDebitIndicator should be specified from the perspective of the Customer.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum CreditDebitIndicator
    {
        /// <summary>
        /// Enum CREDIT for value: CREDIT
        /// </summary>
        [EnumMember(Value = "CREDIT")]
        CREDIT = 1,

        /// <summary>
        /// Enum DEBIT for value: DEBIT
        /// </summary>
        [EnumMember(Value = "DEBIT")]
        DEBIT = 2

    }

}
