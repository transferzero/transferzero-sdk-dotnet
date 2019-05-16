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
    ///  Class for testing LogsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class LogsApiTests
    {
        private LogsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LogsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of LogsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' LogsApi
            //Assert.IsInstanceOfType(typeof(LogsApi), instance, "instance is a LogsApi");
        }

        
        /// <summary>
        /// Test GetWebhookLog
        /// </summary>
        [Test]
        public void GetWebhookLogTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? webhookLogID = null;
            //var response = instance.GetWebhookLog(webhookLogID);
            //Assert.IsInstanceOf<WebhookLogResponse> (response, "response is WebhookLogResponse");
        }
        
        /// <summary>
        /// Test GetWebhookLogs
        /// </summary>
        [Test]
        public void GetWebhookLogsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? per = null;
            //string createdAtFrom = null;
            //string createdAtTo = null;
            //var response = instance.GetWebhookLogs(page, per, createdAtFrom, createdAtTo);
            //Assert.IsInstanceOf<WebhookLogListResponse> (response, "response is WebhookLogListResponse");
        }
        
    }

}
