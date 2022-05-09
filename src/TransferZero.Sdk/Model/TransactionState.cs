/* 
 * TransferZero API
 *
 * Reference documentation for the TransferZero API V1
 *
 * The version of the OpenAPI document: 1.0
 * 
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
using OpenAPIDateConverter = TransferZero.Sdk.Client.OpenAPIDateConverter;

namespace TransferZero.Sdk.Model
{
    /// <summary>
    /// The state of the transaction, which can be one of the following:  * &#x60;initial&#x60;: Transaction is created, but not yet ready to receive payments (waiting for Sender to be KYC&#39;d and approved). * &#x60;approved&#x60;: Transaction is created and the sender is approved. Payment can be received * &#x60;pending&#x60;: There&#39;s an active collection to fund the transaction that needs to clear. * &#x60;received&#x60;: Transaction has received the correct payin amount and will start processing the payouts. * &#x60;mispaid&#x60;: Transaction received funds, but not the requested amount. The transaction will be resized, and will start payout based on the received funds. * &#x60;manual&#x60;: Some of the payments to the recipients have run into issues. Please check the recipient statuses for more information. * &#x60;paid&#x60;: Transaction has received correct payins and has performed payouts to all recipients. No further steps required * &#x60;canceled&#x60;: The transaction has been cancelled. Transactions are cancelled automatically after one hour if there was no funds received. Once transactions are funded they can be cancelled by the API user unless the recipients have been paid out. * &#x60;refunded&#x60;: The transaction has been cancelled after it has been funded, but the funds have been returned now to the sender either partially or fully. * &#x60;processing&#x60;: Transaction has received a payin, it&#39;s processing. * &#x60;exception&#x60;: An exception happened during the processing of the transaction. Please contact TransferZero
    /// </summary>
    /// <value>The state of the transaction, which can be one of the following:  * &#x60;initial&#x60;: Transaction is created, but not yet ready to receive payments (waiting for Sender to be KYC&#39;d and approved). * &#x60;approved&#x60;: Transaction is created and the sender is approved. Payment can be received * &#x60;pending&#x60;: There&#39;s an active collection to fund the transaction that needs to clear. * &#x60;received&#x60;: Transaction has received the correct payin amount and will start processing the payouts. * &#x60;mispaid&#x60;: Transaction received funds, but not the requested amount. The transaction will be resized, and will start payout based on the received funds. * &#x60;manual&#x60;: Some of the payments to the recipients have run into issues. Please check the recipient statuses for more information. * &#x60;paid&#x60;: Transaction has received correct payins and has performed payouts to all recipients. No further steps required * &#x60;canceled&#x60;: The transaction has been cancelled. Transactions are cancelled automatically after one hour if there was no funds received. Once transactions are funded they can be cancelled by the API user unless the recipients have been paid out. * &#x60;refunded&#x60;: The transaction has been cancelled after it has been funded, but the funds have been returned now to the sender either partially or fully. * &#x60;processing&#x60;: Transaction has received a payin, it&#39;s processing. * &#x60;exception&#x60;: An exception happened during the processing of the transaction. Please contact TransferZero</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum TransactionState
    {
        /// <summary>
        /// Enum Initial for value: initial
        /// </summary>
        [EnumMember(Value = "initial")]
        Initial = 1,

        /// <summary>
        /// Enum Approved for value: approved
        /// </summary>
        [EnumMember(Value = "approved")]
        Approved = 2,

        /// <summary>
        /// Enum Pending for value: pending
        /// </summary>
        [EnumMember(Value = "pending")]
        Pending = 3,

        /// <summary>
        /// Enum Received for value: received
        /// </summary>
        [EnumMember(Value = "received")]
        Received = 4,

        /// <summary>
        /// Enum Mispaid for value: mispaid
        /// </summary>
        [EnumMember(Value = "mispaid")]
        Mispaid = 5,

        /// <summary>
        /// Enum Manual for value: manual
        /// </summary>
        [EnumMember(Value = "manual")]
        Manual = 6,

        /// <summary>
        /// Enum Paid for value: paid
        /// </summary>
        [EnumMember(Value = "paid")]
        Paid = 7,

        /// <summary>
        /// Enum Canceled for value: canceled
        /// </summary>
        [EnumMember(Value = "canceled")]
        Canceled = 8,

        /// <summary>
        /// Enum Refunded for value: refunded
        /// </summary>
        [EnumMember(Value = "refunded")]
        Refunded = 9,

        /// <summary>
        /// Enum Processing for value: processing
        /// </summary>
        [EnumMember(Value = "processing")]
        Processing = 10,

        /// <summary>
        /// Enum Exception for value: exception
        /// </summary>
        [EnumMember(Value = "exception")]
        Exception = 11

    }

}
