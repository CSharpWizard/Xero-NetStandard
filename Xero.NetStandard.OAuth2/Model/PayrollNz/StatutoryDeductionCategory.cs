/* 
 * Xero Payroll NZ
 *
 * This is the Xero Payroll API for orgs in the NZ region.
 *
 * The version of the OpenAPI document: 2.7.0
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
    /// Statutory Deduction Category
    /// </summary>
    /// <value>Statutory Deduction Category</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum StatutoryDeductionCategory
    {
        /// <summary>
        /// Enum PriorityOrder for value: PriorityOrder
        /// </summary>
        [EnumMember(Value = "PriorityOrder")]
        PriorityOrder = 1,

        /// <summary>
        /// Enum NonPriorityOrder for value: NonPriorityOrder
        /// </summary>
        [EnumMember(Value = "NonPriorityOrder")]
        NonPriorityOrder = 2,

        /// <summary>
        /// Enum TableBased for value: TableBased
        /// </summary>
        [EnumMember(Value = "TableBased")]
        TableBased = 3,

        /// <summary>
        /// Enum ChildSupport for value: ChildSupport
        /// </summary>
        [EnumMember(Value = "ChildSupport")]
        ChildSupport = 4,

        /// <summary>
        /// Enum CourtFines for value: CourtFines
        /// </summary>
        [EnumMember(Value = "CourtFines")]
        CourtFines = 5,

        /// <summary>
        /// Enum InlandRevenueArrears for value: InlandRevenueArrears
        /// </summary>
        [EnumMember(Value = "InlandRevenueArrears")]
        InlandRevenueArrears = 6,

        /// <summary>
        /// Enum MsdRepayments for value: MsdRepayments
        /// </summary>
        [EnumMember(Value = "MsdRepayments")]
        MsdRepayments = 7,

        /// <summary>
        /// Enum StudentLoan for value: StudentLoan
        /// </summary>
        [EnumMember(Value = "StudentLoan")]
        StudentLoan = 8,

        /// <summary>
        /// Enum AdditionalStudentLoan for value: AdditionalStudentLoan
        /// </summary>
        [EnumMember(Value = "AdditionalStudentLoan")]
        AdditionalStudentLoan = 9,

        /// <summary>
        /// Enum VoluntaryStudentLoan for value: VoluntaryStudentLoan
        /// </summary>
        [EnumMember(Value = "VoluntaryStudentLoan")]
        VoluntaryStudentLoan = 10,

        /// <summary>
        /// Enum KiwiSaver for value: KiwiSaver
        /// </summary>
        [EnumMember(Value = "KiwiSaver")]
        KiwiSaver = 11

    }

}
