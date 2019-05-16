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
    ///  Class for testing DocumentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class DocumentsApiTests
    {
        private DocumentsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DocumentsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of DocumentsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' DocumentsApi
            //Assert.IsInstanceOfType(typeof(DocumentsApi), instance, "instance is a DocumentsApi");
        }

        
        /// <summary>
        /// Test GetDocument
        /// </summary>
        [Test]
        public void GetDocumentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? documentID = null;
            //var response = instance.GetDocument(documentID);
            //Assert.IsInstanceOf<DocumentResponse> (response, "response is DocumentResponse");
        }
        
        /// <summary>
        /// Test GetDocuments
        /// </summary>
        [Test]
        public void GetDocumentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? per = null;
            //var response = instance.GetDocuments(page, per);
            //Assert.IsInstanceOf<DocumentListResponse> (response, "response is DocumentListResponse");
        }
        
        /// <summary>
        /// Test PostDocuments
        /// </summary>
        [Test]
        public void PostDocumentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DocumentRequest documentRequest = null;
            //var response = instance.PostDocuments(documentRequest);
            //Assert.IsInstanceOf<DocumentResponse> (response, "response is DocumentResponse");
        }
        
    }

}
