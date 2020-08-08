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
    /// Line amounts are exclusive of tax by default if you don’t specify this element. See Line Amount Types
    /// </summary>
    /// <value>Line amounts are exclusive of tax by default if you don’t specify this element. See Line Amount Types</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum QuoteLineAmountTypes
    {
        /// <summary>
        /// Enum EXCLUSIVE for value: EXCLUSIVE
        /// </summary>
        [EnumMember(Value = "EXCLUSIVE")]
        EXCLUSIVE = 1,

        /// <summary>
        /// Enum INCLUSIVE for value: INCLUSIVE
        /// </summary>
        [EnumMember(Value = "INCLUSIVE")]
        INCLUSIVE = 2,

        /// <summary>
        /// Enum NOTAX for value: NOTAX
        /// </summary>
        [EnumMember(Value = "NOTAX")]
        NOTAX = 3

    }

}
