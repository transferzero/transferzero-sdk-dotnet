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
    /// The Mobile Wallet provider of the recipient:  For XOF (Senegal) valid options are: - &#x60;orange&#x60;: Orange - &#x60;tigo&#x60;: Tigo - &#x60;emoney&#x60;: Emoney - &#x60;free&#x60;: Free - &#x60;wave&#x60;: Wave  For XOF (Ivory Coast) valid options are: - &#x60;orange&#x60;: Orange - &#x60;moov&#x60;: Moov - &#x60;mtn&#x60;: MTN  For XOF (Burkina Faso) valid options are: - &#x60;orange&#x60;: Orange - &#x60;mobicash&#x60;: Mobicash  For XOF (Mali) valid options are: - &#x60;orange&#x60;: Orange - &#x60;mobicash&#x60;: Mobicash  For GHS valid options are: - &#x60;mtn&#x60;: MTN - &#x60;airtel&#x60;: Airtel - &#x60;tigo&#x60;: Tigo - &#x60;vodafone&#x60;: Vodafone  For KES valid options are: - &#x60;mpesa&#x60;: MPESA  For UGX valid options are: - &#x60;africell&#x60;: Africell - &#x60;airtel&#x60;: Airtel - &#x60;mtn&#x60;: MTN - &#x60;telecom&#x60;: Telecom  For XAF (Cameroon) valid options are: - &#x60;orange&#x60;: Orange - &#x60;mtn&#x60;: MTN  For GNF (Guinea) valid options are: - &#x60;mtn&#x60;: MTN
    /// </summary>
    /// <value>The Mobile Wallet provider of the recipient:  For XOF (Senegal) valid options are: - &#x60;orange&#x60;: Orange - &#x60;tigo&#x60;: Tigo - &#x60;emoney&#x60;: Emoney - &#x60;free&#x60;: Free - &#x60;wave&#x60;: Wave  For XOF (Ivory Coast) valid options are: - &#x60;orange&#x60;: Orange - &#x60;moov&#x60;: Moov - &#x60;mtn&#x60;: MTN  For XOF (Burkina Faso) valid options are: - &#x60;orange&#x60;: Orange - &#x60;mobicash&#x60;: Mobicash  For XOF (Mali) valid options are: - &#x60;orange&#x60;: Orange - &#x60;mobicash&#x60;: Mobicash  For GHS valid options are: - &#x60;mtn&#x60;: MTN - &#x60;airtel&#x60;: Airtel - &#x60;tigo&#x60;: Tigo - &#x60;vodafone&#x60;: Vodafone  For KES valid options are: - &#x60;mpesa&#x60;: MPESA  For UGX valid options are: - &#x60;africell&#x60;: Africell - &#x60;airtel&#x60;: Airtel - &#x60;mtn&#x60;: MTN - &#x60;telecom&#x60;: Telecom  For XAF (Cameroon) valid options are: - &#x60;orange&#x60;: Orange - &#x60;mtn&#x60;: MTN  For GNF (Guinea) valid options are: - &#x60;mtn&#x60;: MTN</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PayoutMethodMobileProviderEnum
    {
        /// <summary>
        /// Enum Orange for value: orange
        /// </summary>
        [EnumMember(Value = "orange")]
        Orange = 1,

        /// <summary>
        /// Enum Tigo for value: tigo
        /// </summary>
        [EnumMember(Value = "tigo")]
        Tigo = 2,

        /// <summary>
        /// Enum Moov for value: moov
        /// </summary>
        [EnumMember(Value = "moov")]
        Moov = 3,

        /// <summary>
        /// Enum Mtn for value: mtn
        /// </summary>
        [EnumMember(Value = "mtn")]
        Mtn = 4,

        /// <summary>
        /// Enum Airtel for value: airtel
        /// </summary>
        [EnumMember(Value = "airtel")]
        Airtel = 5,

        /// <summary>
        /// Enum Vodafone for value: vodafone
        /// </summary>
        [EnumMember(Value = "vodafone")]
        Vodafone = 6,

        /// <summary>
        /// Enum Mpesa for value: mpesa
        /// </summary>
        [EnumMember(Value = "mpesa")]
        Mpesa = 7,

        /// <summary>
        /// Enum Africell for value: africell
        /// </summary>
        [EnumMember(Value = "africell")]
        Africell = 8,

        /// <summary>
        /// Enum Telecom for value: telecom
        /// </summary>
        [EnumMember(Value = "telecom")]
        Telecom = 9,

        /// <summary>
        /// Enum Mobicash for value: mobicash
        /// </summary>
        [EnumMember(Value = "mobicash")]
        Mobicash = 10,

        /// <summary>
        /// Enum Emoney for value: emoney
        /// </summary>
        [EnumMember(Value = "emoney")]
        Emoney = 11,

        /// <summary>
        /// Enum Free for value: free
        /// </summary>
        [EnumMember(Value = "free")]
        Free = 12,

        /// <summary>
        /// Enum Wave for value: wave
        /// </summary>
        [EnumMember(Value = "wave")]
        Wave = 13

    }

}
