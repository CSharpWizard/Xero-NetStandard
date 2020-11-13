/* 
 * Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2.4.4
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
    /// See Tax Types – can only be used on update calls
    /// </summary>
    /// <value>See Tax Types – can only be used on update calls</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum TaxType
    {
        /// <summary>
        /// Enum OUTPUT for value: OUTPUT
        /// </summary>
        [EnumMember(Value = "OUTPUT")]
        OUTPUT = 1,

        /// <summary>
        /// Enum INPUT for value: INPUT
        /// </summary>
        [EnumMember(Value = "INPUT")]
        INPUT = 2,

        /// <summary>
        /// Enum CAPEXINPUT for value: CAPEXINPUT
        /// </summary>
        [EnumMember(Value = "CAPEXINPUT")]
        CAPEXINPUT = 3,

        /// <summary>
        /// Enum EXEMPTEXPORT for value: EXEMPTEXPORT
        /// </summary>
        [EnumMember(Value = "EXEMPTEXPORT")]
        EXEMPTEXPORT = 4,

        /// <summary>
        /// Enum EXEMPTEXPENSES for value: EXEMPTEXPENSES
        /// </summary>
        [EnumMember(Value = "EXEMPTEXPENSES")]
        EXEMPTEXPENSES = 5,

        /// <summary>
        /// Enum EXEMPTCAPITAL for value: EXEMPTCAPITAL
        /// </summary>
        [EnumMember(Value = "EXEMPTCAPITAL")]
        EXEMPTCAPITAL = 6,

        /// <summary>
        /// Enum EXEMPTOUTPUT for value: EXEMPTOUTPUT
        /// </summary>
        [EnumMember(Value = "EXEMPTOUTPUT")]
        EXEMPTOUTPUT = 7,

        /// <summary>
        /// Enum INPUTTAXED for value: INPUTTAXED
        /// </summary>
        [EnumMember(Value = "INPUTTAXED")]
        INPUTTAXED = 8,

        /// <summary>
        /// Enum BASEXCLUDED for value: BASEXCLUDED
        /// </summary>
        [EnumMember(Value = "BASEXCLUDED")]
        BASEXCLUDED = 9,

        /// <summary>
        /// Enum GSTONCAPIMPORTS for value: GSTONCAPIMPORTS
        /// </summary>
        [EnumMember(Value = "GSTONCAPIMPORTS")]
        GSTONCAPIMPORTS = 10,

        /// <summary>
        /// Enum GSTONIMPORTS for value: GSTONIMPORTS
        /// </summary>
        [EnumMember(Value = "GSTONIMPORTS")]
        GSTONIMPORTS = 11,

        /// <summary>
        /// Enum NONE for value: NONE
        /// </summary>
        [EnumMember(Value = "NONE")]
        NONE = 12,

        /// <summary>
        /// Enum INPUT2 for value: INPUT2
        /// </summary>
        [EnumMember(Value = "INPUT2")]
        INPUT2 = 13,

        /// <summary>
        /// Enum ZERORATED for value: ZERORATED
        /// </summary>
        [EnumMember(Value = "ZERORATED")]
        ZERORATED = 14,

        /// <summary>
        /// Enum OUTPUT2 for value: OUTPUT2
        /// </summary>
        [EnumMember(Value = "OUTPUT2")]
        OUTPUT2 = 15,

        /// <summary>
        /// Enum CAPEXINPUT2 for value: CAPEXINPUT2
        /// </summary>
        [EnumMember(Value = "CAPEXINPUT2")]
        CAPEXINPUT2 = 16,

        /// <summary>
        /// Enum CAPEXOUTPUT for value: CAPEXOUTPUT
        /// </summary>
        [EnumMember(Value = "CAPEXOUTPUT")]
        CAPEXOUTPUT = 17,

        /// <summary>
        /// Enum CAPEXOUTPUT2 for value: CAPEXOUTPUT2
        /// </summary>
        [EnumMember(Value = "CAPEXOUTPUT2")]
        CAPEXOUTPUT2 = 18,

        /// <summary>
        /// Enum CAPEXSRINPUT for value: CAPEXSRINPUT
        /// </summary>
        [EnumMember(Value = "CAPEXSRINPUT")]
        CAPEXSRINPUT = 19,

        /// <summary>
        /// Enum CAPEXSROUTPUT for value: CAPEXSROUTPUT
        /// </summary>
        [EnumMember(Value = "CAPEXSROUTPUT")]
        CAPEXSROUTPUT = 20,

        /// <summary>
        /// Enum ECACQUISITIONS for value: ECACQUISITIONS
        /// </summary>
        [EnumMember(Value = "ECACQUISITIONS")]
        ECACQUISITIONS = 21,

        /// <summary>
        /// Enum ECZRINPUT for value: ECZRINPUT
        /// </summary>
        [EnumMember(Value = "ECZRINPUT")]
        ECZRINPUT = 22,

        /// <summary>
        /// Enum ECZROUTPUT for value: ECZROUTPUT
        /// </summary>
        [EnumMember(Value = "ECZROUTPUT")]
        ECZROUTPUT = 23,

        /// <summary>
        /// Enum ECZROUTPUTSERVICES for value: ECZROUTPUTSERVICES
        /// </summary>
        [EnumMember(Value = "ECZROUTPUTSERVICES")]
        ECZROUTPUTSERVICES = 24,

        /// <summary>
        /// Enum EXEMPTINPUT for value: EXEMPTINPUT
        /// </summary>
        [EnumMember(Value = "EXEMPTINPUT")]
        EXEMPTINPUT = 25,

        /// <summary>
        /// Enum REVERSECHARGES for value: REVERSECHARGES
        /// </summary>
        [EnumMember(Value = "REVERSECHARGES")]
        REVERSECHARGES = 26,

        /// <summary>
        /// Enum RRINPUT for value: RRINPUT
        /// </summary>
        [EnumMember(Value = "RRINPUT")]
        RRINPUT = 27,

        /// <summary>
        /// Enum RROUTPUT for value: RROUTPUT
        /// </summary>
        [EnumMember(Value = "RROUTPUT")]
        RROUTPUT = 28,

        /// <summary>
        /// Enum SRINPUT for value: SRINPUT
        /// </summary>
        [EnumMember(Value = "SRINPUT")]
        SRINPUT = 29,

        /// <summary>
        /// Enum SROUTPUT for value: SROUTPUT
        /// </summary>
        [EnumMember(Value = "SROUTPUT")]
        SROUTPUT = 30,

        /// <summary>
        /// Enum ZERORATEDINPUT for value: ZERORATEDINPUT
        /// </summary>
        [EnumMember(Value = "ZERORATEDINPUT")]
        ZERORATEDINPUT = 31,

        /// <summary>
        /// Enum ZERORATEDOUTPUT for value: ZERORATEDOUTPUT
        /// </summary>
        [EnumMember(Value = "ZERORATEDOUTPUT")]
        ZERORATEDOUTPUT = 32,

        /// <summary>
        /// Enum BLINPUT for value: BLINPUT
        /// </summary>
        [EnumMember(Value = "BLINPUT")]
        BLINPUT = 33,

        /// <summary>
        /// Enum DSOUTPUT for value: DSOUTPUT
        /// </summary>
        [EnumMember(Value = "DSOUTPUT")]
        DSOUTPUT = 34,

        /// <summary>
        /// Enum EPINPUT for value: EPINPUT
        /// </summary>
        [EnumMember(Value = "EPINPUT")]
        EPINPUT = 35,

        /// <summary>
        /// Enum ES33OUTPUT for value: ES33OUTPUT
        /// </summary>
        [EnumMember(Value = "ES33OUTPUT")]
        ES33OUTPUT = 36,

        /// <summary>
        /// Enum ESN33OUTPUT for value: ESN33OUTPUT
        /// </summary>
        [EnumMember(Value = "ESN33OUTPUT")]
        ESN33OUTPUT = 37,

        /// <summary>
        /// Enum IGDSINPUT2 for value: IGDSINPUT2
        /// </summary>
        [EnumMember(Value = "IGDSINPUT2")]
        IGDSINPUT2 = 38,

        /// <summary>
        /// Enum IMINPUT2 for value: IMINPUT2
        /// </summary>
        [EnumMember(Value = "IMINPUT2")]
        IMINPUT2 = 39,

        /// <summary>
        /// Enum MEINPUT for value: MEINPUT
        /// </summary>
        [EnumMember(Value = "MEINPUT")]
        MEINPUT = 40,

        /// <summary>
        /// Enum NRINPUT for value: NRINPUT
        /// </summary>
        [EnumMember(Value = "NRINPUT")]
        NRINPUT = 41,

        /// <summary>
        /// Enum OPINPUT for value: OPINPUT
        /// </summary>
        [EnumMember(Value = "OPINPUT")]
        OPINPUT = 42,

        /// <summary>
        /// Enum OSOUTPUT for value: OSOUTPUT
        /// </summary>
        [EnumMember(Value = "OSOUTPUT")]
        OSOUTPUT = 43,

        /// <summary>
        /// Enum TXESSINPUT for value: TXESSINPUT
        /// </summary>
        [EnumMember(Value = "TXESSINPUT")]
        TXESSINPUT = 44,

        /// <summary>
        /// Enum TXN33INPUT for value: TXN33INPUT
        /// </summary>
        [EnumMember(Value = "TXN33INPUT")]
        TXN33INPUT = 45,

        /// <summary>
        /// Enum TXPETINPUT for value: TXPETINPUT
        /// </summary>
        [EnumMember(Value = "TXPETINPUT")]
        TXPETINPUT = 46,

        /// <summary>
        /// Enum TXREINPUT for value: TXREINPUT
        /// </summary>
        [EnumMember(Value = "TXREINPUT")]
        TXREINPUT = 47,

        /// <summary>
        /// Enum INPUT3 for value: INPUT3
        /// </summary>
        [EnumMember(Value = "INPUT3")]
        INPUT3 = 48,

        /// <summary>
        /// Enum INPUT4 for value: INPUT4
        /// </summary>
        [EnumMember(Value = "INPUT4")]
        INPUT4 = 49,

        /// <summary>
        /// Enum OUTPUT3 for value: OUTPUT3
        /// </summary>
        [EnumMember(Value = "OUTPUT3")]
        OUTPUT3 = 50,

        /// <summary>
        /// Enum OUTPUT4 for value: OUTPUT4
        /// </summary>
        [EnumMember(Value = "OUTPUT4")]
        OUTPUT4 = 51,

        /// <summary>
        /// Enum SROUTPUT2 for value: SROUTPUT2
        /// </summary>
        [EnumMember(Value = "SROUTPUT2")]
        SROUTPUT2 = 52,

        /// <summary>
        /// Enum TXCA for value: TXCA
        /// </summary>
        [EnumMember(Value = "TXCA")]
        TXCA = 53,

        /// <summary>
        /// Enum SRCAS for value: SRCAS
        /// </summary>
        [EnumMember(Value = "SRCAS")]
        SRCAS = 54,

        /// <summary>
        /// Enum BLINPUT2 for value: BLINPUT2
        /// </summary>
        [EnumMember(Value = "BLINPUT2")]
        BLINPUT2 = 55,

        /// <summary>
        /// Enum DRCHARGESUPPLY20 for value: DRCHARGESUPPLY20
        /// </summary>
        [EnumMember(Value = "DRCHARGESUPPLY20")]
        DRCHARGESUPPLY20 = 56,

        /// <summary>
        /// Enum DRCHARGE20 for value: DRCHARGE20
        /// </summary>
        [EnumMember(Value = "DRCHARGE20")]
        DRCHARGE20 = 57,

        /// <summary>
        /// Enum DRCHARGESUPPLY5 for value: DRCHARGESUPPLY5
        /// </summary>
        [EnumMember(Value = "DRCHARGESUPPLY5")]
        DRCHARGESUPPLY5 = 58,

        /// <summary>
        /// Enum DRCHARGE5 for value: DRCHARGE5
        /// </summary>
        [EnumMember(Value = "DRCHARGE5")]
        DRCHARGE5 = 59

    }

}
