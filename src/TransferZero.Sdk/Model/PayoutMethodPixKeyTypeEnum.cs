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
    /// The type of pix key used by the recipient - &#x60;cpf&#x60;: Natural person register number - &#x60;cnpj&#x60;: Company registration number - &#x60;phone&#x60;: Phone number - &#x60;email&#x60;: Email address - &#x60;evp&#x60;: Virtual payment address
    /// </summary>
    /// <value>The type of pix key used by the recipient - &#x60;cpf&#x60;: Natural person register number - &#x60;cnpj&#x60;: Company registration number - &#x60;phone&#x60;: Phone number - &#x60;email&#x60;: Email address - &#x60;evp&#x60;: Virtual payment address</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PayoutMethodPixKeyTypeEnum
    {
        /// <summary>
        /// Enum Cpf for value: cpf
        /// </summary>
        [EnumMember(Value = "cpf")]
        Cpf = 1,

        /// <summary>
        /// Enum Cnpj for value: cnpj
        /// </summary>
        [EnumMember(Value = "cnpj")]
        Cnpj = 2,

        /// <summary>
        /// Enum Phone for value: phone
        /// </summary>
        [EnumMember(Value = "phone")]
        Phone = 3,

        /// <summary>
        /// Enum Email for value: email
        /// </summary>
        [EnumMember(Value = "email")]
        Email = 4,

        /// <summary>
        /// Enum Evp for value: evp
        /// </summary>
        [EnumMember(Value = "evp")]
        Evp = 5

    }

}
