/* 
 * Xero Payroll NZ
 *
 * This is the Xero Payroll API for orgs in the NZ region.
 *
 * The version of the OpenAPI document: 2.7.0
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Xero.NetStandard.OAuth2.Api;
using Xero.NetStandard.OAuth2.Model.PayrollNz;
using Xero.NetStandard.OAuth2.Client;
using System.Reflection;
using Newtonsoft.Json;
using RestSharp;

namespace Xero.NetStandard.OAuth2.Test.Model.PayrollNz
{
    /// <summary>
    ///  Class for testing Employee
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class EmployeeTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Employee
        //private Employee instance;

        public EmployeeTests()
        {
            // TODO uncomment below to create an instance of Employee
            //instance = new Employee();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Employee
        /// </summary>
        [Fact]
        public void EmployeeInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Employee
            //Assert.IsInstanceOfType<Employee> (instance, "variable 'instance' is a Employee");
        }


        /// <summary>
        /// Test the property 'EmployeeID'
        /// </summary>
        [Fact]
        public void EmployeeIDTest()
        {
            // TODO unit test for the property 'EmployeeID'
        }
        /// <summary>
        /// Test the property 'Title'
        /// </summary>
        [Fact]
        public void TitleTest()
        {
            // TODO unit test for the property 'Title'
        }
        /// <summary>
        /// Test the property 'FirstName'
        /// </summary>
        [Fact]
        public void FirstNameTest()
        {
            // TODO unit test for the property 'FirstName'
        }
        /// <summary>
        /// Test the property 'LastName'
        /// </summary>
        [Fact]
        public void LastNameTest()
        {
            // TODO unit test for the property 'LastName'
        }
        /// <summary>
        /// Test the property 'DateOfBirth'
        /// </summary>
        [Fact]
        public void DateOfBirthTest()
        {
            // TODO unit test for the property 'DateOfBirth'
        }
        /// <summary>
        /// Test the property 'Address'
        /// </summary>
        [Fact]
        public void AddressTest()
        {
            // TODO unit test for the property 'Address'
        }
        /// <summary>
        /// Test the property 'Email'
        /// </summary>
        [Fact]
        public void EmailTest()
        {
            // TODO unit test for the property 'Email'
        }
        /// <summary>
        /// Test the property 'Gender'
        /// </summary>
        [Theory]
        [InlineData("F", Employee.GenderEnum.F)]
        [InlineData("M", Employee.GenderEnum.M)]
        public void GenderEnum_ValidInput_Deserialises(string input, Employee.GenderEnum expected)
        {
            var response = new RestResponse();
            response.Content = $@"""{input}""";

            var deserializer = new CustomJsonCodec(new Configuration());
            var actual = deserializer.Deserialize<Employee.GenderEnum>(response);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GenderEnum_NullInput_Deserialises(){
            var response = new RestResponse();
            response.Content = "null";

            var deserializer = new CustomJsonCodec(new Configuration());
            var actual = deserializer.Deserialize<Employee.GenderEnum>(response);

            Assert.Equal(0, (int)actual);
        }
        /// <summary>
        /// Test the property 'PhoneNumber'
        /// </summary>
        [Fact]
        public void PhoneNumberTest()
        {
            // TODO unit test for the property 'PhoneNumber'
        }
        /// <summary>
        /// Test the property 'StartDate'
        /// </summary>
        [Fact]
        public void StartDateTest()
        {
            // TODO unit test for the property 'StartDate'
        }
        /// <summary>
        /// Test the property 'EndDate'
        /// </summary>
        [Fact]
        public void EndDateTest()
        {
            // TODO unit test for the property 'EndDate'
        }
        /// <summary>
        /// Test the property 'PayrollCalendarID'
        /// </summary>
        [Fact]
        public void PayrollCalendarIDTest()
        {
            // TODO unit test for the property 'PayrollCalendarID'
        }
        /// <summary>
        /// Test the property 'UpdatedDateUTC'
        /// </summary>
        [Fact]
        public void UpdatedDateUTCTest()
        {
            // TODO unit test for the property 'UpdatedDateUTC'
        }
        /// <summary>
        /// Test the property 'CreatedDateUTC'
        /// </summary>
        [Fact]
        public void CreatedDateUTCTest()
        {
            // TODO unit test for the property 'CreatedDateUTC'
        }

    }

}
