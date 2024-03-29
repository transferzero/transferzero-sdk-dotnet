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
    ///  Class for testing RecipientsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class RecipientsApiTests
    {
        private RecipientsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RecipientsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of RecipientsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' RecipientsApi
            //Assert.IsInstanceOfType(typeof(RecipientsApi), instance, "instance is a RecipientsApi");
        }

        
        /// <summary>
        /// Test DeleteRecipient
        /// </summary>
        [Test]
        public void DeleteRecipientTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? recipientID = null;
            //var response = instance.DeleteRecipient(recipientID);
            //Assert.IsInstanceOf<RecipientResponse> (response, "response is RecipientResponse");
        }
        
        /// <summary>
        /// Test GetRecipients
        /// </summary>
        [Test]
        public void GetRecipientsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? per = null;
            //string createdAtFrom = null;
            //string createdAtTo = null;
            //string amountFrom = null;
            //string amountTo = null;
            //List<string> state = null;
            //List<string> currency = null;
            //var response = instance.GetRecipients(page, per, createdAtFrom, createdAtTo, amountFrom, amountTo, state, currency);
            //Assert.IsInstanceOf<RecipientListResponse> (response, "response is RecipientListResponse");
        }
        
        /// <summary>
        /// Test PatchRecipient
        /// </summary>
        [Test]
        public void PatchRecipientTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? recipientID = null;
            //RecipientRequest recipientRequest = null;
            //var response = instance.PatchRecipient(recipientID, recipientRequest);
            //Assert.IsInstanceOf<RecipientResponse> (response, "response is RecipientResponse");
        }
        
        /// <summary>
        /// Test ProofOfPayments
        /// </summary>
        [Test]
        public void ProofOfPaymentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? recipientID = null;
            //var response = instance.ProofOfPayments(recipientID);
            //Assert.IsInstanceOf<ProofOfPaymentListResponse> (response, "response is ProofOfPaymentListResponse");
        }
        
    }

}
