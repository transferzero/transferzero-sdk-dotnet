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
    ///  Class for testing PoliticallyExposedPeopleApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PoliticallyExposedPeopleApiTests
    {
        private PoliticallyExposedPeopleApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PoliticallyExposedPeopleApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PoliticallyExposedPeopleApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PoliticallyExposedPeopleApi
            //Assert.IsInstanceOfType(typeof(PoliticallyExposedPeopleApi), instance, "instance is a PoliticallyExposedPeopleApi");
        }

        
        /// <summary>
        /// Test DeletePoliticallyExposedPerson
        /// </summary>
        [Test]
        public void DeletePoliticallyExposedPersonTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? politicallyExposedPersonID = null;
            //instance.DeletePoliticallyExposedPerson(politicallyExposedPersonID);
            
        }
        
        /// <summary>
        /// Test GetPoliticallyExposedPeople
        /// </summary>
        [Test]
        public void GetPoliticallyExposedPeopleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? senderId = null;
            //var response = instance.GetPoliticallyExposedPeople(senderId);
            //Assert.IsInstanceOf<PoliticallyExposedPersonListResponse> (response, "response is PoliticallyExposedPersonListResponse");
        }
        
        /// <summary>
        /// Test GetPoliticallyExposedPerson
        /// </summary>
        [Test]
        public void GetPoliticallyExposedPersonTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? politicallyExposedPersonID = null;
            //Guid? senderId = null;
            //var response = instance.GetPoliticallyExposedPerson(politicallyExposedPersonID, senderId);
            //Assert.IsInstanceOf<PoliticallyExposedPersonResponse> (response, "response is PoliticallyExposedPersonResponse");
        }
        
        /// <summary>
        /// Test PatchPoliticallyExposedPerson
        /// </summary>
        [Test]
        public void PatchPoliticallyExposedPersonTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? politicallyExposedPersonID = null;
            //PoliticallyExposedPerson politicallyExposedPerson = null;
            //var response = instance.PatchPoliticallyExposedPerson(politicallyExposedPersonID, politicallyExposedPerson);
            //Assert.IsInstanceOf<PoliticallyExposedPersonResponse> (response, "response is PoliticallyExposedPersonResponse");
        }
        
        /// <summary>
        /// Test PostPoliticallyExposedPeople
        /// </summary>
        [Test]
        public void PostPoliticallyExposedPeopleTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PoliticallyExposedPerson politicallyExposedPerson = null;
            //var response = instance.PostPoliticallyExposedPeople(politicallyExposedPerson);
            //Assert.IsInstanceOf<PoliticallyExposedPersonResponse> (response, "response is PoliticallyExposedPersonResponse");
        }
        
    }

}