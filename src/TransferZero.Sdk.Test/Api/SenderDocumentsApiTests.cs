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
    ///  Class for testing SenderDocumentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SenderDocumentsApiTests
    {
        private SenderDocumentsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SenderDocumentsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SenderDocumentsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SenderDocumentsApi
            //Assert.IsInstanceOfType(typeof(SenderDocumentsApi), instance, "instance is a SenderDocumentsApi");
        }

        
        /// <summary>
        /// Test AddDocumentSender
        /// </summary>
        [Test]
        public void AddDocumentSenderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? senderID = null;
            //Guid? documentID = null;
            //var response = instance.AddDocumentSender(senderID, documentID);
            //Assert.IsInstanceOf<DocumentResponse> (response, "response is DocumentResponse");
        }
        
        /// <summary>
        /// Test GetSenderDocument
        /// </summary>
        [Test]
        public void GetSenderDocumentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? senderID = null;
            //Guid? documentID = null;
            //var response = instance.GetSenderDocument(senderID, documentID);
            //Assert.IsInstanceOf<DocumentResponse> (response, "response is DocumentResponse");
        }
        
        /// <summary>
        /// Test GetSenderDocuments
        /// </summary>
        [Test]
        public void GetSenderDocumentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? senderID = null;
            //int? page = null;
            //int? per = null;
            //var response = instance.GetSenderDocuments(senderID, page, per);
            //Assert.IsInstanceOf<DocumentListResponse> (response, "response is DocumentListResponse");
        }
        
        /// <summary>
        /// Test RemoveDocumentSender
        /// </summary>
        [Test]
        public void RemoveDocumentSenderTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? senderID = null;
            //Guid? documentID = null;
            //var response = instance.RemoveDocumentSender(senderID, documentID);
            //Assert.IsInstanceOf<DocumentResponse> (response, "response is DocumentResponse");
        }
        
    }

}