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
    /// The type of the bank account:  - &#x60;10&#x60;: Savings account - &#x60;20&#x60;: Current account - &#x60;30&#x60;: Payment account - &#x60;40&#x60;: Salary account
    /// </summary>
    /// <value>The type of the bank account:  - &#x60;10&#x60;: Savings account - &#x60;20&#x60;: Current account - &#x60;30&#x60;: Payment account - &#x60;40&#x60;: Salary account</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PayoutMethodBankAccountTypeEnum
    {
        /// <summary>
        /// Enum _10 for value: 10
        /// </summary>
        [EnumMember(Value = "10")]
        _10 = 1,

        /// <summary>
        /// Enum _20 for value: 20
        /// </summary>
        [EnumMember(Value = "20")]
        _20 = 2,

        /// <summary>
        /// Enum _30 for value: 30
        /// </summary>
        [EnumMember(Value = "30")]
        _30 = 3,

        /// <summary>
        /// Enum _40 for value: 40
        /// </summary>
        [EnumMember(Value = "40")]
        _40 = 4

    }

}
