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
    ///  Class for testing SanctionedCountriesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SanctionedCountriesApiTests
    {
        private SanctionedCountriesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SanctionedCountriesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SanctionedCountriesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SanctionedCountriesApi
            //Assert.IsInstanceOfType(typeof(SanctionedCountriesApi), instance, "instance is a SanctionedCountriesApi");
        }

        
        /// <summary>
        /// Test GetSanctionedCountries
        /// </summary>
        [Test]
        public void GetSanctionedCountriesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetSanctionedCountries();
            //Assert.IsInstanceOf<SanctionedCountryListResponse> (response, "response is SanctionedCountryListResponse");
        }
        
    }

}
