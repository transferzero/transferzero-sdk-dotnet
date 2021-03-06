/* 
 * TransferZero API
 *
 * Reference documentation for the TransferZero API V1
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
    ///  Class for testing AccountValidationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AccountValidationApiTests
    {
        private AccountValidationApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AccountValidationApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AccountValidationApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AccountValidationApi
            //Assert.IsInstanceOfType(typeof(AccountValidationApi), instance, "instance is a AccountValidationApi");
        }

        
        /// <summary>
        /// Test PostAccountValidations
        /// </summary>
        [Test]
        public void PostAccountValidationsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AccountValidationRequest accountValidationRequest = null;
            //var response = instance.PostAccountValidations(accountValidationRequest);
            //Assert.IsInstanceOf<AccountValidationResponse> (response, "response is AccountValidationResponse");
        }
        
    }

}
