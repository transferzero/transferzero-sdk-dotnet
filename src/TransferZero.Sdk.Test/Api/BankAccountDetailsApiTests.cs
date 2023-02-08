/* 
 * BitPesa Private API
 *
 * API specification used for internal BitPesa endpoints
 *
 * OpenAPI spec version: 1.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using TransferZero.Sdk.Client;
using TransferZero.Sdk.Api;
using TransferZero.Sdk.Model;

namespace TransferZero.Sdk.Test
{
    /// <summary>
    ///  Class for testing BankAccountDetailsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class BankAccountDetailsApiTests
    {
        private BankAccountDetailsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BankAccountDetailsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BankAccountDetailsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' BankAccountDetailsApi
            //Assert.IsInstanceOfType(typeof(BankAccountDetailsApi), instance, "instance is a BankAccountDetailsApi");
        }

        
        /// <summary>
        /// Test GetBankAccountDetails
        /// </summary>
        [Test]
        public void GetBankAccountDetailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string currency = null;
            //var response = instance.GetBankAccountDetails(currency);
            //Assert.IsInstanceOf<BankAccountDetailsResponse> (response, "response is BankAccountDetailsResponse");
        }
        
    }

}
