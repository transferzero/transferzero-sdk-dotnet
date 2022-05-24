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
    /// The country for the pickup or mobile payout.  For USD cash pickup in Nigeria, valid options are: - &#x60;NG&#x60;: Nigeria  For XOF cash pickup, valid options are: - &#x60;CI&#x60;: Ivory Coast - &#x60;ML&#x60;: Mali - &#x60;SN&#x60;: Senegal  For XOF mobile payout, valid options are: - &#x60;CI&#x60;: Ivory Coast - &#x60;SN&#x60;: Senegal - &#x60;BF&#x60;: Burkina Faso - &#x60;ML&#x60;: Mali  For XAF mobile payout, valid options are: - &#x60;CM&#x60;: Cameroon
    /// </summary>
    /// <value>The country for the pickup or mobile payout.  For USD cash pickup in Nigeria, valid options are: - &#x60;NG&#x60;: Nigeria  For XOF cash pickup, valid options are: - &#x60;CI&#x60;: Ivory Coast - &#x60;ML&#x60;: Mali - &#x60;SN&#x60;: Senegal  For XOF mobile payout, valid options are: - &#x60;CI&#x60;: Ivory Coast - &#x60;SN&#x60;: Senegal - &#x60;BF&#x60;: Burkina Faso - &#x60;ML&#x60;: Mali  For XAF mobile payout, valid options are: - &#x60;CM&#x60;: Cameroon</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PayoutMethodCountryEnum
    {
        /// <summary>
        /// Enum AF for value: AF
        /// </summary>
        [EnumMember(Value = "AF")]
        AF = 1,

        /// <summary>
        /// Enum AL for value: AL
        /// </summary>
        [EnumMember(Value = "AL")]
        AL = 2,

        /// <summary>
        /// Enum DZ for value: DZ
        /// </summary>
        [EnumMember(Value = "DZ")]
        DZ = 3,

        /// <summary>
        /// Enum AS for value: AS
        /// </summary>
        [EnumMember(Value = "AS")]
        AS = 4,

        /// <summary>
        /// Enum AD for value: AD
        /// </summary>
        [EnumMember(Value = "AD")]
        AD = 5,

        /// <summary>
        /// Enum AO for value: AO
        /// </summary>
        [EnumMember(Value = "AO")]
        AO = 6,

        /// <summary>
        /// Enum AI for value: AI
        /// </summary>
        [EnumMember(Value = "AI")]
        AI = 7,

        /// <summary>
        /// Enum AQ for value: AQ
        /// </summary>
        [EnumMember(Value = "AQ")]
        AQ = 8,

        /// <summary>
        /// Enum AG for value: AG
        /// </summary>
        [EnumMember(Value = "AG")]
        AG = 9,

        /// <summary>
        /// Enum AR for value: AR
        /// </summary>
        [EnumMember(Value = "AR")]
        AR = 10,

        /// <summary>
        /// Enum AM for value: AM
        /// </summary>
        [EnumMember(Value = "AM")]
        AM = 11,

        /// <summary>
        /// Enum AW for value: AW
        /// </summary>
        [EnumMember(Value = "AW")]
        AW = 12,

        /// <summary>
        /// Enum AU for value: AU
        /// </summary>
        [EnumMember(Value = "AU")]
        AU = 13,

        /// <summary>
        /// Enum AT for value: AT
        /// </summary>
        [EnumMember(Value = "AT")]
        AT = 14,

        /// <summary>
        /// Enum AZ for value: AZ
        /// </summary>
        [EnumMember(Value = "AZ")]
        AZ = 15,

        /// <summary>
        /// Enum BS for value: BS
        /// </summary>
        [EnumMember(Value = "BS")]
        BS = 16,

        /// <summary>
        /// Enum BH for value: BH
        /// </summary>
        [EnumMember(Value = "BH")]
        BH = 17,

        /// <summary>
        /// Enum BD for value: BD
        /// </summary>
        [EnumMember(Value = "BD")]
        BD = 18,

        /// <summary>
        /// Enum BB for value: BB
        /// </summary>
        [EnumMember(Value = "BB")]
        BB = 19,

        /// <summary>
        /// Enum BY for value: BY
        /// </summary>
        [EnumMember(Value = "BY")]
        BY = 20,

        /// <summary>
        /// Enum BE for value: BE
        /// </summary>
        [EnumMember(Value = "BE")]
        BE = 21,

        /// <summary>
        /// Enum BZ for value: BZ
        /// </summary>
        [EnumMember(Value = "BZ")]
        BZ = 22,

        /// <summary>
        /// Enum BJ for value: BJ
        /// </summary>
        [EnumMember(Value = "BJ")]
        BJ = 23,

        /// <summary>
        /// Enum BM for value: BM
        /// </summary>
        [EnumMember(Value = "BM")]
        BM = 24,

        /// <summary>
        /// Enum BT for value: BT
        /// </summary>
        [EnumMember(Value = "BT")]
        BT = 25,

        /// <summary>
        /// Enum BO for value: BO
        /// </summary>
        [EnumMember(Value = "BO")]
        BO = 26,

        /// <summary>
        /// Enum BA for value: BA
        /// </summary>
        [EnumMember(Value = "BA")]
        BA = 27,

        /// <summary>
        /// Enum BW for value: BW
        /// </summary>
        [EnumMember(Value = "BW")]
        BW = 28,

        /// <summary>
        /// Enum BV for value: BV
        /// </summary>
        [EnumMember(Value = "BV")]
        BV = 29,

        /// <summary>
        /// Enum BR for value: BR
        /// </summary>
        [EnumMember(Value = "BR")]
        BR = 30,

        /// <summary>
        /// Enum IO for value: IO
        /// </summary>
        [EnumMember(Value = "IO")]
        IO = 31,

        /// <summary>
        /// Enum BN for value: BN
        /// </summary>
        [EnumMember(Value = "BN")]
        BN = 32,

        /// <summary>
        /// Enum BG for value: BG
        /// </summary>
        [EnumMember(Value = "BG")]
        BG = 33,

        /// <summary>
        /// Enum BF for value: BF
        /// </summary>
        [EnumMember(Value = "BF")]
        BF = 34,

        /// <summary>
        /// Enum BI for value: BI
        /// </summary>
        [EnumMember(Value = "BI")]
        BI = 35,

        /// <summary>
        /// Enum KH for value: KH
        /// </summary>
        [EnumMember(Value = "KH")]
        KH = 36,

        /// <summary>
        /// Enum CM for value: CM
        /// </summary>
        [EnumMember(Value = "CM")]
        CM = 37,

        /// <summary>
        /// Enum CA for value: CA
        /// </summary>
        [EnumMember(Value = "CA")]
        CA = 38,

        /// <summary>
        /// Enum CV for value: CV
        /// </summary>
        [EnumMember(Value = "CV")]
        CV = 39,

        /// <summary>
        /// Enum KY for value: KY
        /// </summary>
        [EnumMember(Value = "KY")]
        KY = 40,

        /// <summary>
        /// Enum CF for value: CF
        /// </summary>
        [EnumMember(Value = "CF")]
        CF = 41,

        /// <summary>
        /// Enum TD for value: TD
        /// </summary>
        [EnumMember(Value = "TD")]
        TD = 42,

        /// <summary>
        /// Enum CL for value: CL
        /// </summary>
        [EnumMember(Value = "CL")]
        CL = 43,

        /// <summary>
        /// Enum CN for value: CN
        /// </summary>
        [EnumMember(Value = "CN")]
        CN = 44,

        /// <summary>
        /// Enum CX for value: CX
        /// </summary>
        [EnumMember(Value = "CX")]
        CX = 45,

        /// <summary>
        /// Enum CC for value: CC
        /// </summary>
        [EnumMember(Value = "CC")]
        CC = 46,

        /// <summary>
        /// Enum CO for value: CO
        /// </summary>
        [EnumMember(Value = "CO")]
        CO = 47,

        /// <summary>
        /// Enum KM for value: KM
        /// </summary>
        [EnumMember(Value = "KM")]
        KM = 48,

        /// <summary>
        /// Enum CG for value: CG
        /// </summary>
        [EnumMember(Value = "CG")]
        CG = 49,

        /// <summary>
        /// Enum CD for value: CD
        /// </summary>
        [EnumMember(Value = "CD")]
        CD = 50,

        /// <summary>
        /// Enum CK for value: CK
        /// </summary>
        [EnumMember(Value = "CK")]
        CK = 51,

        /// <summary>
        /// Enum CR for value: CR
        /// </summary>
        [EnumMember(Value = "CR")]
        CR = 52,

        /// <summary>
        /// Enum CI for value: CI
        /// </summary>
        [EnumMember(Value = "CI")]
        CI = 53,

        /// <summary>
        /// Enum HR for value: HR
        /// </summary>
        [EnumMember(Value = "HR")]
        HR = 54,

        /// <summary>
        /// Enum CU for value: CU
        /// </summary>
        [EnumMember(Value = "CU")]
        CU = 55,

        /// <summary>
        /// Enum CY for value: CY
        /// </summary>
        [EnumMember(Value = "CY")]
        CY = 56,

        /// <summary>
        /// Enum CZ for value: CZ
        /// </summary>
        [EnumMember(Value = "CZ")]
        CZ = 57,

        /// <summary>
        /// Enum DK for value: DK
        /// </summary>
        [EnumMember(Value = "DK")]
        DK = 58,

        /// <summary>
        /// Enum DJ for value: DJ
        /// </summary>
        [EnumMember(Value = "DJ")]
        DJ = 59,

        /// <summary>
        /// Enum DM for value: DM
        /// </summary>
        [EnumMember(Value = "DM")]
        DM = 60,

        /// <summary>
        /// Enum DO for value: DO
        /// </summary>
        [EnumMember(Value = "DO")]
        DO = 61,

        /// <summary>
        /// Enum TP for value: TP
        /// </summary>
        [EnumMember(Value = "TP")]
        TP = 62,

        /// <summary>
        /// Enum EC for value: EC
        /// </summary>
        [EnumMember(Value = "EC")]
        EC = 63,

        /// <summary>
        /// Enum EG for value: EG
        /// </summary>
        [EnumMember(Value = "EG")]
        EG = 64,

        /// <summary>
        /// Enum SV for value: SV
        /// </summary>
        [EnumMember(Value = "SV")]
        SV = 65,

        /// <summary>
        /// Enum GQ for value: GQ
        /// </summary>
        [EnumMember(Value = "GQ")]
        GQ = 66,

        /// <summary>
        /// Enum ER for value: ER
        /// </summary>
        [EnumMember(Value = "ER")]
        ER = 67,

        /// <summary>
        /// Enum EE for value: EE
        /// </summary>
        [EnumMember(Value = "EE")]
        EE = 68,

        /// <summary>
        /// Enum ET for value: ET
        /// </summary>
        [EnumMember(Value = "ET")]
        ET = 69,

        /// <summary>
        /// Enum FK for value: FK
        /// </summary>
        [EnumMember(Value = "FK")]
        FK = 70,

        /// <summary>
        /// Enum FO for value: FO
        /// </summary>
        [EnumMember(Value = "FO")]
        FO = 71,

        /// <summary>
        /// Enum FJ for value: FJ
        /// </summary>
        [EnumMember(Value = "FJ")]
        FJ = 72,

        /// <summary>
        /// Enum FI for value: FI
        /// </summary>
        [EnumMember(Value = "FI")]
        FI = 73,

        /// <summary>
        /// Enum FR for value: FR
        /// </summary>
        [EnumMember(Value = "FR")]
        FR = 74,

        /// <summary>
        /// Enum GF for value: GF
        /// </summary>
        [EnumMember(Value = "GF")]
        GF = 75,

        /// <summary>
        /// Enum PF for value: PF
        /// </summary>
        [EnumMember(Value = "PF")]
        PF = 76,

        /// <summary>
        /// Enum TF for value: TF
        /// </summary>
        [EnumMember(Value = "TF")]
        TF = 77,

        /// <summary>
        /// Enum GA for value: GA
        /// </summary>
        [EnumMember(Value = "GA")]
        GA = 78,

        /// <summary>
        /// Enum GM for value: GM
        /// </summary>
        [EnumMember(Value = "GM")]
        GM = 79,

        /// <summary>
        /// Enum GE for value: GE
        /// </summary>
        [EnumMember(Value = "GE")]
        GE = 80,

        /// <summary>
        /// Enum DE for value: DE
        /// </summary>
        [EnumMember(Value = "DE")]
        DE = 81,

        /// <summary>
        /// Enum GH for value: GH
        /// </summary>
        [EnumMember(Value = "GH")]
        GH = 82,

        /// <summary>
        /// Enum GI for value: GI
        /// </summary>
        [EnumMember(Value = "GI")]
        GI = 83,

        /// <summary>
        /// Enum GR for value: GR
        /// </summary>
        [EnumMember(Value = "GR")]
        GR = 84,

        /// <summary>
        /// Enum GL for value: GL
        /// </summary>
        [EnumMember(Value = "GL")]
        GL = 85,

        /// <summary>
        /// Enum GD for value: GD
        /// </summary>
        [EnumMember(Value = "GD")]
        GD = 86,

        /// <summary>
        /// Enum GP for value: GP
        /// </summary>
        [EnumMember(Value = "GP")]
        GP = 87,

        /// <summary>
        /// Enum GU for value: GU
        /// </summary>
        [EnumMember(Value = "GU")]
        GU = 88,

        /// <summary>
        /// Enum GT for value: GT
        /// </summary>
        [EnumMember(Value = "GT")]
        GT = 89,

        /// <summary>
        /// Enum GN for value: GN
        /// </summary>
        [EnumMember(Value = "GN")]
        GN = 90,

        /// <summary>
        /// Enum GW for value: GW
        /// </summary>
        [EnumMember(Value = "GW")]
        GW = 91,

        /// <summary>
        /// Enum GY for value: GY
        /// </summary>
        [EnumMember(Value = "GY")]
        GY = 92,

        /// <summary>
        /// Enum HT for value: HT
        /// </summary>
        [EnumMember(Value = "HT")]
        HT = 93,

        /// <summary>
        /// Enum HM for value: HM
        /// </summary>
        [EnumMember(Value = "HM")]
        HM = 94,

        /// <summary>
        /// Enum VA for value: VA
        /// </summary>
        [EnumMember(Value = "VA")]
        VA = 95,

        /// <summary>
        /// Enum HN for value: HN
        /// </summary>
        [EnumMember(Value = "HN")]
        HN = 96,

        /// <summary>
        /// Enum HK for value: HK
        /// </summary>
        [EnumMember(Value = "HK")]
        HK = 97,

        /// <summary>
        /// Enum HU for value: HU
        /// </summary>
        [EnumMember(Value = "HU")]
        HU = 98,

        /// <summary>
        /// Enum IS for value: IS
        /// </summary>
        [EnumMember(Value = "IS")]
        IS = 99,

        /// <summary>
        /// Enum IN for value: IN
        /// </summary>
        [EnumMember(Value = "IN")]
        IN = 100,

        /// <summary>
        /// Enum ID for value: ID
        /// </summary>
        [EnumMember(Value = "ID")]
        ID = 101,

        /// <summary>
        /// Enum IR for value: IR
        /// </summary>
        [EnumMember(Value = "IR")]
        IR = 102,

        /// <summary>
        /// Enum IQ for value: IQ
        /// </summary>
        [EnumMember(Value = "IQ")]
        IQ = 103,

        /// <summary>
        /// Enum IE for value: IE
        /// </summary>
        [EnumMember(Value = "IE")]
        IE = 104,

        /// <summary>
        /// Enum IL for value: IL
        /// </summary>
        [EnumMember(Value = "IL")]
        IL = 105,

        /// <summary>
        /// Enum IT for value: IT
        /// </summary>
        [EnumMember(Value = "IT")]
        IT = 106,

        /// <summary>
        /// Enum JM for value: JM
        /// </summary>
        [EnumMember(Value = "JM")]
        JM = 107,

        /// <summary>
        /// Enum JP for value: JP
        /// </summary>
        [EnumMember(Value = "JP")]
        JP = 108,

        /// <summary>
        /// Enum JO for value: JO
        /// </summary>
        [EnumMember(Value = "JO")]
        JO = 109,

        /// <summary>
        /// Enum KZ for value: KZ
        /// </summary>
        [EnumMember(Value = "KZ")]
        KZ = 110,

        /// <summary>
        /// Enum KE for value: KE
        /// </summary>
        [EnumMember(Value = "KE")]
        KE = 111,

        /// <summary>
        /// Enum KI for value: KI
        /// </summary>
        [EnumMember(Value = "KI")]
        KI = 112,

        /// <summary>
        /// Enum KP for value: KP
        /// </summary>
        [EnumMember(Value = "KP")]
        KP = 113,

        /// <summary>
        /// Enum KR for value: KR
        /// </summary>
        [EnumMember(Value = "KR")]
        KR = 114,

        /// <summary>
        /// Enum KV for value: KV
        /// </summary>
        [EnumMember(Value = "KV")]
        KV = 115,

        /// <summary>
        /// Enum KW for value: KW
        /// </summary>
        [EnumMember(Value = "KW")]
        KW = 116,

        /// <summary>
        /// Enum KG for value: KG
        /// </summary>
        [EnumMember(Value = "KG")]
        KG = 117,

        /// <summary>
        /// Enum LA for value: LA
        /// </summary>
        [EnumMember(Value = "LA")]
        LA = 118,

        /// <summary>
        /// Enum LV for value: LV
        /// </summary>
        [EnumMember(Value = "LV")]
        LV = 119,

        /// <summary>
        /// Enum LB for value: LB
        /// </summary>
        [EnumMember(Value = "LB")]
        LB = 120,

        /// <summary>
        /// Enum LS for value: LS
        /// </summary>
        [EnumMember(Value = "LS")]
        LS = 121,

        /// <summary>
        /// Enum LR for value: LR
        /// </summary>
        [EnumMember(Value = "LR")]
        LR = 122,

        /// <summary>
        /// Enum LY for value: LY
        /// </summary>
        [EnumMember(Value = "LY")]
        LY = 123,

        /// <summary>
        /// Enum LI for value: LI
        /// </summary>
        [EnumMember(Value = "LI")]
        LI = 124,

        /// <summary>
        /// Enum LT for value: LT
        /// </summary>
        [EnumMember(Value = "LT")]
        LT = 125,

        /// <summary>
        /// Enum LU for value: LU
        /// </summary>
        [EnumMember(Value = "LU")]
        LU = 126,

        /// <summary>
        /// Enum MO for value: MO
        /// </summary>
        [EnumMember(Value = "MO")]
        MO = 127,

        /// <summary>
        /// Enum MK for value: MK
        /// </summary>
        [EnumMember(Value = "MK")]
        MK = 128,

        /// <summary>
        /// Enum MG for value: MG
        /// </summary>
        [EnumMember(Value = "MG")]
        MG = 129,

        /// <summary>
        /// Enum MW for value: MW
        /// </summary>
        [EnumMember(Value = "MW")]
        MW = 130,

        /// <summary>
        /// Enum MY for value: MY
        /// </summary>
        [EnumMember(Value = "MY")]
        MY = 131,

        /// <summary>
        /// Enum MV for value: MV
        /// </summary>
        [EnumMember(Value = "MV")]
        MV = 132,

        /// <summary>
        /// Enum ML for value: ML
        /// </summary>
        [EnumMember(Value = "ML")]
        ML = 133,

        /// <summary>
        /// Enum MT for value: MT
        /// </summary>
        [EnumMember(Value = "MT")]
        MT = 134,

        /// <summary>
        /// Enum MH for value: MH
        /// </summary>
        [EnumMember(Value = "MH")]
        MH = 135,

        /// <summary>
        /// Enum MQ for value: MQ
        /// </summary>
        [EnumMember(Value = "MQ")]
        MQ = 136,

        /// <summary>
        /// Enum MR for value: MR
        /// </summary>
        [EnumMember(Value = "MR")]
        MR = 137,

        /// <summary>
        /// Enum MU for value: MU
        /// </summary>
        [EnumMember(Value = "MU")]
        MU = 138,

        /// <summary>
        /// Enum YT for value: YT
        /// </summary>
        [EnumMember(Value = "YT")]
        YT = 139,

        /// <summary>
        /// Enum MX for value: MX
        /// </summary>
        [EnumMember(Value = "MX")]
        MX = 140,

        /// <summary>
        /// Enum FM for value: FM
        /// </summary>
        [EnumMember(Value = "FM")]
        FM = 141,

        /// <summary>
        /// Enum MD for value: MD
        /// </summary>
        [EnumMember(Value = "MD")]
        MD = 142,

        /// <summary>
        /// Enum MC for value: MC
        /// </summary>
        [EnumMember(Value = "MC")]
        MC = 143,

        /// <summary>
        /// Enum MN for value: MN
        /// </summary>
        [EnumMember(Value = "MN")]
        MN = 144,

        /// <summary>
        /// Enum MS for value: MS
        /// </summary>
        [EnumMember(Value = "MS")]
        MS = 145,

        /// <summary>
        /// Enum ME for value: ME
        /// </summary>
        [EnumMember(Value = "ME")]
        ME = 146,

        /// <summary>
        /// Enum MA for value: MA
        /// </summary>
        [EnumMember(Value = "MA")]
        MA = 147,

        /// <summary>
        /// Enum MZ for value: MZ
        /// </summary>
        [EnumMember(Value = "MZ")]
        MZ = 148,

        /// <summary>
        /// Enum MM for value: MM
        /// </summary>
        [EnumMember(Value = "MM")]
        MM = 149,

        /// <summary>
        /// Enum NA for value: NA
        /// </summary>
        [EnumMember(Value = "NA")]
        NA = 150,

        /// <summary>
        /// Enum NR for value: NR
        /// </summary>
        [EnumMember(Value = "NR")]
        NR = 151,

        /// <summary>
        /// Enum NP for value: NP
        /// </summary>
        [EnumMember(Value = "NP")]
        NP = 152,

        /// <summary>
        /// Enum NL for value: NL
        /// </summary>
        [EnumMember(Value = "NL")]
        NL = 153,

        /// <summary>
        /// Enum AN for value: AN
        /// </summary>
        [EnumMember(Value = "AN")]
        AN = 154,

        /// <summary>
        /// Enum NC for value: NC
        /// </summary>
        [EnumMember(Value = "NC")]
        NC = 155,

        /// <summary>
        /// Enum NZ for value: NZ
        /// </summary>
        [EnumMember(Value = "NZ")]
        NZ = 156,

        /// <summary>
        /// Enum NI for value: NI
        /// </summary>
        [EnumMember(Value = "NI")]
        NI = 157,

        /// <summary>
        /// Enum NE for value: NE
        /// </summary>
        [EnumMember(Value = "NE")]
        NE = 158,

        /// <summary>
        /// Enum NG for value: NG
        /// </summary>
        [EnumMember(Value = "NG")]
        NG = 159,

        /// <summary>
        /// Enum NU for value: NU
        /// </summary>
        [EnumMember(Value = "NU")]
        NU = 160,

        /// <summary>
        /// Enum NF for value: NF
        /// </summary>
        [EnumMember(Value = "NF")]
        NF = 161,

        /// <summary>
        /// Enum MP for value: MP
        /// </summary>
        [EnumMember(Value = "MP")]
        MP = 162,

        /// <summary>
        /// Enum NO for value: NO
        /// </summary>
        [EnumMember(Value = "NO")]
        NO = 163,

        /// <summary>
        /// Enum OM for value: OM
        /// </summary>
        [EnumMember(Value = "OM")]
        OM = 164,

        /// <summary>
        /// Enum PK for value: PK
        /// </summary>
        [EnumMember(Value = "PK")]
        PK = 165,

        /// <summary>
        /// Enum PW for value: PW
        /// </summary>
        [EnumMember(Value = "PW")]
        PW = 166,

        /// <summary>
        /// Enum PS for value: PS
        /// </summary>
        [EnumMember(Value = "PS")]
        PS = 167,

        /// <summary>
        /// Enum PA for value: PA
        /// </summary>
        [EnumMember(Value = "PA")]
        PA = 168,

        /// <summary>
        /// Enum PG for value: PG
        /// </summary>
        [EnumMember(Value = "PG")]
        PG = 169,

        /// <summary>
        /// Enum PY for value: PY
        /// </summary>
        [EnumMember(Value = "PY")]
        PY = 170,

        /// <summary>
        /// Enum PE for value: PE
        /// </summary>
        [EnumMember(Value = "PE")]
        PE = 171,

        /// <summary>
        /// Enum PH for value: PH
        /// </summary>
        [EnumMember(Value = "PH")]
        PH = 172,

        /// <summary>
        /// Enum PN for value: PN
        /// </summary>
        [EnumMember(Value = "PN")]
        PN = 173,

        /// <summary>
        /// Enum PL for value: PL
        /// </summary>
        [EnumMember(Value = "PL")]
        PL = 174,

        /// <summary>
        /// Enum PT for value: PT
        /// </summary>
        [EnumMember(Value = "PT")]
        PT = 175,

        /// <summary>
        /// Enum PR for value: PR
        /// </summary>
        [EnumMember(Value = "PR")]
        PR = 176,

        /// <summary>
        /// Enum QA for value: QA
        /// </summary>
        [EnumMember(Value = "QA")]
        QA = 177,

        /// <summary>
        /// Enum RE for value: RE
        /// </summary>
        [EnumMember(Value = "RE")]
        RE = 178,

        /// <summary>
        /// Enum RO for value: RO
        /// </summary>
        [EnumMember(Value = "RO")]
        RO = 179,

        /// <summary>
        /// Enum RU for value: RU
        /// </summary>
        [EnumMember(Value = "RU")]
        RU = 180,

        /// <summary>
        /// Enum RW for value: RW
        /// </summary>
        [EnumMember(Value = "RW")]
        RW = 181,

        /// <summary>
        /// Enum SH for value: SH
        /// </summary>
        [EnumMember(Value = "SH")]
        SH = 182,

        /// <summary>
        /// Enum KN for value: KN
        /// </summary>
        [EnumMember(Value = "KN")]
        KN = 183,

        /// <summary>
        /// Enum LC for value: LC
        /// </summary>
        [EnumMember(Value = "LC")]
        LC = 184,

        /// <summary>
        /// Enum PM for value: PM
        /// </summary>
        [EnumMember(Value = "PM")]
        PM = 185,

        /// <summary>
        /// Enum VC for value: VC
        /// </summary>
        [EnumMember(Value = "VC")]
        VC = 186,

        /// <summary>
        /// Enum WS for value: WS
        /// </summary>
        [EnumMember(Value = "WS")]
        WS = 187,

        /// <summary>
        /// Enum SM for value: SM
        /// </summary>
        [EnumMember(Value = "SM")]
        SM = 188,

        /// <summary>
        /// Enum ST for value: ST
        /// </summary>
        [EnumMember(Value = "ST")]
        ST = 189,

        /// <summary>
        /// Enum SA for value: SA
        /// </summary>
        [EnumMember(Value = "SA")]
        SA = 190,

        /// <summary>
        /// Enum SN for value: SN
        /// </summary>
        [EnumMember(Value = "SN")]
        SN = 191,

        /// <summary>
        /// Enum RS for value: RS
        /// </summary>
        [EnumMember(Value = "RS")]
        RS = 192,

        /// <summary>
        /// Enum SC for value: SC
        /// </summary>
        [EnumMember(Value = "SC")]
        SC = 193,

        /// <summary>
        /// Enum SL for value: SL
        /// </summary>
        [EnumMember(Value = "SL")]
        SL = 194,

        /// <summary>
        /// Enum SG for value: SG
        /// </summary>
        [EnumMember(Value = "SG")]
        SG = 195,

        /// <summary>
        /// Enum SK for value: SK
        /// </summary>
        [EnumMember(Value = "SK")]
        SK = 196,

        /// <summary>
        /// Enum SI for value: SI
        /// </summary>
        [EnumMember(Value = "SI")]
        SI = 197,

        /// <summary>
        /// Enum SB for value: SB
        /// </summary>
        [EnumMember(Value = "SB")]
        SB = 198,

        /// <summary>
        /// Enum SO for value: SO
        /// </summary>
        [EnumMember(Value = "SO")]
        SO = 199,

        /// <summary>
        /// Enum ZA for value: ZA
        /// </summary>
        [EnumMember(Value = "ZA")]
        ZA = 200,

        /// <summary>
        /// Enum GS for value: GS
        /// </summary>
        [EnumMember(Value = "GS")]
        GS = 201,

        /// <summary>
        /// Enum ES for value: ES
        /// </summary>
        [EnumMember(Value = "ES")]
        ES = 202,

        /// <summary>
        /// Enum LK for value: LK
        /// </summary>
        [EnumMember(Value = "LK")]
        LK = 203,

        /// <summary>
        /// Enum SD for value: SD
        /// </summary>
        [EnumMember(Value = "SD")]
        SD = 204,

        /// <summary>
        /// Enum SR for value: SR
        /// </summary>
        [EnumMember(Value = "SR")]
        SR = 205,

        /// <summary>
        /// Enum SJ for value: SJ
        /// </summary>
        [EnumMember(Value = "SJ")]
        SJ = 206,

        /// <summary>
        /// Enum SZ for value: SZ
        /// </summary>
        [EnumMember(Value = "SZ")]
        SZ = 207,

        /// <summary>
        /// Enum SE for value: SE
        /// </summary>
        [EnumMember(Value = "SE")]
        SE = 208,

        /// <summary>
        /// Enum CH for value: CH
        /// </summary>
        [EnumMember(Value = "CH")]
        CH = 209,

        /// <summary>
        /// Enum SY for value: SY
        /// </summary>
        [EnumMember(Value = "SY")]
        SY = 210,

        /// <summary>
        /// Enum TW for value: TW
        /// </summary>
        [EnumMember(Value = "TW")]
        TW = 211,

        /// <summary>
        /// Enum TJ for value: TJ
        /// </summary>
        [EnumMember(Value = "TJ")]
        TJ = 212,

        /// <summary>
        /// Enum TZ for value: TZ
        /// </summary>
        [EnumMember(Value = "TZ")]
        TZ = 213,

        /// <summary>
        /// Enum TH for value: TH
        /// </summary>
        [EnumMember(Value = "TH")]
        TH = 214,

        /// <summary>
        /// Enum TG for value: TG
        /// </summary>
        [EnumMember(Value = "TG")]
        TG = 215,

        /// <summary>
        /// Enum TK for value: TK
        /// </summary>
        [EnumMember(Value = "TK")]
        TK = 216,

        /// <summary>
        /// Enum TO for value: TO
        /// </summary>
        [EnumMember(Value = "TO")]
        TO = 217,

        /// <summary>
        /// Enum TT for value: TT
        /// </summary>
        [EnumMember(Value = "TT")]
        TT = 218,

        /// <summary>
        /// Enum TN for value: TN
        /// </summary>
        [EnumMember(Value = "TN")]
        TN = 219,

        /// <summary>
        /// Enum TR for value: TR
        /// </summary>
        [EnumMember(Value = "TR")]
        TR = 220,

        /// <summary>
        /// Enum TM for value: TM
        /// </summary>
        [EnumMember(Value = "TM")]
        TM = 221,

        /// <summary>
        /// Enum TC for value: TC
        /// </summary>
        [EnumMember(Value = "TC")]
        TC = 222,

        /// <summary>
        /// Enum TV for value: TV
        /// </summary>
        [EnumMember(Value = "TV")]
        TV = 223,

        /// <summary>
        /// Enum UG for value: UG
        /// </summary>
        [EnumMember(Value = "UG")]
        UG = 224,

        /// <summary>
        /// Enum UA for value: UA
        /// </summary>
        [EnumMember(Value = "UA")]
        UA = 225,

        /// <summary>
        /// Enum AE for value: AE
        /// </summary>
        [EnumMember(Value = "AE")]
        AE = 226,

        /// <summary>
        /// Enum GB for value: GB
        /// </summary>
        [EnumMember(Value = "GB")]
        GB = 227,

        /// <summary>
        /// Enum US for value: US
        /// </summary>
        [EnumMember(Value = "US")]
        US = 228,

        /// <summary>
        /// Enum UM for value: UM
        /// </summary>
        [EnumMember(Value = "UM")]
        UM = 229,

        /// <summary>
        /// Enum UY for value: UY
        /// </summary>
        [EnumMember(Value = "UY")]
        UY = 230,

        /// <summary>
        /// Enum UZ for value: UZ
        /// </summary>
        [EnumMember(Value = "UZ")]
        UZ = 231,

        /// <summary>
        /// Enum VU for value: VU
        /// </summary>
        [EnumMember(Value = "VU")]
        VU = 232,

        /// <summary>
        /// Enum VE for value: VE
        /// </summary>
        [EnumMember(Value = "VE")]
        VE = 233,

        /// <summary>
        /// Enum VN for value: VN
        /// </summary>
        [EnumMember(Value = "VN")]
        VN = 234,

        /// <summary>
        /// Enum VG for value: VG
        /// </summary>
        [EnumMember(Value = "VG")]
        VG = 235,

        /// <summary>
        /// Enum VI for value: VI
        /// </summary>
        [EnumMember(Value = "VI")]
        VI = 236,

        /// <summary>
        /// Enum WF for value: WF
        /// </summary>
        [EnumMember(Value = "WF")]
        WF = 237,

        /// <summary>
        /// Enum EH for value: EH
        /// </summary>
        [EnumMember(Value = "EH")]
        EH = 238,

        /// <summary>
        /// Enum YE for value: YE
        /// </summary>
        [EnumMember(Value = "YE")]
        YE = 239,

        /// <summary>
        /// Enum ZM for value: ZM
        /// </summary>
        [EnumMember(Value = "ZM")]
        ZM = 240

    }

}
