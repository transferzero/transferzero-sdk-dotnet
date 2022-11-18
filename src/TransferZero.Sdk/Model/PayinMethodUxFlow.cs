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
    /// Describes the collection experience that will be presented to the sender. Can be one of the following:  * &#x60;ussd_popup&#x60;: Payment prompt is pushed to the sender&#39;s phone. They can approve or decline. Supported for GHS::Mobile, UGX::Mobile * &#x60;ussd_voucher&#x60;: Sender has to request an authorization code via ussd of the mobile provider and then provide that code to initiate the transaction. Supported for XOF::Mobile(Orange)  * &#x60;ussd_menu_approval&#x60;: Sender has to dial a USSD code and navigate to a list of payments to approve. * &#x60;otp_verified_ussd_popup&#x60;: Sender receives and validates an OTP then a payment prompt is pushed if the OTP they submit is valid. * &#x60;bank_transfer&#x60;: For bank collections. Sender should send funds to the bank account details specified in out_details. Supported for EUR::Bank, GBP::Bank * &#x60;http_redirect&#x60;: The sender will be redirected to a website where they can fill in their details to initiate the collection.
    /// </summary>
    /// <value>Describes the collection experience that will be presented to the sender. Can be one of the following:  * &#x60;ussd_popup&#x60;: Payment prompt is pushed to the sender&#39;s phone. They can approve or decline. Supported for GHS::Mobile, UGX::Mobile * &#x60;ussd_voucher&#x60;: Sender has to request an authorization code via ussd of the mobile provider and then provide that code to initiate the transaction. Supported for XOF::Mobile(Orange)  * &#x60;ussd_menu_approval&#x60;: Sender has to dial a USSD code and navigate to a list of payments to approve. * &#x60;otp_verified_ussd_popup&#x60;: Sender receives and validates an OTP then a payment prompt is pushed if the OTP they submit is valid. * &#x60;bank_transfer&#x60;: For bank collections. Sender should send funds to the bank account details specified in out_details. Supported for EUR::Bank, GBP::Bank * &#x60;http_redirect&#x60;: The sender will be redirected to a website where they can fill in their details to initiate the collection.</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PayinMethodUxFlow
    {
        /// <summary>
        /// Enum Ussdpopup for value: ussd_popup
        /// </summary>
        [EnumMember(Value = "ussd_popup")]
        Ussdpopup = 1,

        /// <summary>
        /// Enum Ussdvoucher for value: ussd_voucher
        /// </summary>
        [EnumMember(Value = "ussd_voucher")]
        Ussdvoucher = 2,

        /// <summary>
        /// Enum Ussdmenuapproval for value: ussd_menu_approval
        /// </summary>
        [EnumMember(Value = "ussd_menu_approval")]
        Ussdmenuapproval = 3,

        /// <summary>
        /// Enum Otpverifiedussdpopup for value: otp_verified_ussd_popup
        /// </summary>
        [EnumMember(Value = "otp_verified_ussd_popup")]
        Otpverifiedussdpopup = 4,

        /// <summary>
        /// Enum Banktransfer for value: bank_transfer
        /// </summary>
        [EnumMember(Value = "bank_transfer")]
        Banktransfer = 5,

        /// <summary>
        /// Enum Httpredirect for value: http_redirect
        /// </summary>
        [EnumMember(Value = "http_redirect")]
        Httpredirect = 6,

        /// <summary>
        /// Enum Blockchain for value: blockchain
        /// </summary>
        [EnumMember(Value = "blockchain")]
        Blockchain = 7,

        /// <summary>
        /// Enum Unknown for value: unknown
        /// </summary>
        [EnumMember(Value = "unknown")]
        Unknown = 8

    }

}