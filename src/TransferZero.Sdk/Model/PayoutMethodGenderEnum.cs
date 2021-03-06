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
    /// The gender of the sender:  - &#x60;M&#x60;: Male - &#x60;F&#x60;: Female
    /// </summary>
    /// <value>The gender of the sender:  - &#x60;M&#x60;: Male - &#x60;F&#x60;: Female</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PayoutMethodGenderEnum
    {
        /// <summary>
        /// Enum M for value: M
        /// </summary>
        [EnumMember(Value = "M")]
        M = 1,

        /// <summary>
        /// Enum F for value: F
        /// </summary>
        [EnumMember(Value = "F")]
        F = 2

    }

}
