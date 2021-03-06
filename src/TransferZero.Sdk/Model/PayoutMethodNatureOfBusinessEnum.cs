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
    /// Nature of business options (used only with a Business sender)  Available values:   - personal: Personal   - agriculture_and_hunting: Agriculture and Hunting   - forestry: Forestry   - fishing: Fishing   - agricultural_by_products: Agricultural By-Products   - coal_mining: Coal Mining   - oil_mining: Oil Mining   - iron_ore_mining: Iron Ore Mining   - other_metal_and_diamond_mining: Other Metal and Diamond Mining   - other_mineral_mining: Other Mineral Mining   - manufacturing_of_food_drink_tobacco: Manufacture of Food/Drink/Tobacco   - manufacturing_of_textiles_leather_fur_furniture: Manufacture of Textiles/Leather/Fur/Furniture   - manufacture_of_wooden_products_furniture: Manufacture of Wooden Products/Furniture   - manufacture_of_paper_pulp_allied_products: Manufacture of Paper/Pulp/Allied Products   - manufacture_of_chemicals_medical_petroleum_rubber_plastic_products: Manufacture Of Chemicals Medical Petroleum Rubber Plastic Products   - manufacture_of_pottery_china_glass_stone: Manufacture Of Pottery China Glass Stone   - manufacture_of_iron_steel_non_ferrous_metals_basic_industries: Manufacture Of Iron Steel Non-Ferrous Metals Basic Industries   - manufacture_of_metal_products_electrical_and_scientific_engineering: Manufacture Of Metal Products Electrical And Scientific Engineering   - manufacture_of_jewelry_musical_instruments_toys: Manufacture Of Jewelry Musical Instruments Toys   - electricity_gas_and_water: Electricity, Gas And Water   - construction: Construction   - wholesale_trade: Wholesale Trade   - retail_trade: Retail Trade   - catering_incl_hotels: Catering Incl. Hotels   - transport_storage: Transport Storage   - communications: Communications   - finance_and_holding_companies: Finance And Holding Companies   - insurance: Insurance   - business_services: Business Services   - real_estate_development_investment: Real Estate Development Investment   - central_state_governments: Central State Governments   - community_services_defence_police_prisons_etc: Community Services Defence Police Prisons Etc   - social_services_education_health_care: Social Services Education Health Care   - personal_services_leisure_services: Personal Services - Leisure Services   - personal_services_domestic_laundry_repairs: Personal Services - Domestic Laundry Repairs   - personal_services_embassies_international_organisations: Personal Services - Embassies
    /// </summary>
    /// <value>Nature of business options (used only with a Business sender)  Available values:   - personal: Personal   - agriculture_and_hunting: Agriculture and Hunting   - forestry: Forestry   - fishing: Fishing   - agricultural_by_products: Agricultural By-Products   - coal_mining: Coal Mining   - oil_mining: Oil Mining   - iron_ore_mining: Iron Ore Mining   - other_metal_and_diamond_mining: Other Metal and Diamond Mining   - other_mineral_mining: Other Mineral Mining   - manufacturing_of_food_drink_tobacco: Manufacture of Food/Drink/Tobacco   - manufacturing_of_textiles_leather_fur_furniture: Manufacture of Textiles/Leather/Fur/Furniture   - manufacture_of_wooden_products_furniture: Manufacture of Wooden Products/Furniture   - manufacture_of_paper_pulp_allied_products: Manufacture of Paper/Pulp/Allied Products   - manufacture_of_chemicals_medical_petroleum_rubber_plastic_products: Manufacture Of Chemicals Medical Petroleum Rubber Plastic Products   - manufacture_of_pottery_china_glass_stone: Manufacture Of Pottery China Glass Stone   - manufacture_of_iron_steel_non_ferrous_metals_basic_industries: Manufacture Of Iron Steel Non-Ferrous Metals Basic Industries   - manufacture_of_metal_products_electrical_and_scientific_engineering: Manufacture Of Metal Products Electrical And Scientific Engineering   - manufacture_of_jewelry_musical_instruments_toys: Manufacture Of Jewelry Musical Instruments Toys   - electricity_gas_and_water: Electricity, Gas And Water   - construction: Construction   - wholesale_trade: Wholesale Trade   - retail_trade: Retail Trade   - catering_incl_hotels: Catering Incl. Hotels   - transport_storage: Transport Storage   - communications: Communications   - finance_and_holding_companies: Finance And Holding Companies   - insurance: Insurance   - business_services: Business Services   - real_estate_development_investment: Real Estate Development Investment   - central_state_governments: Central State Governments   - community_services_defence_police_prisons_etc: Community Services Defence Police Prisons Etc   - social_services_education_health_care: Social Services Education Health Care   - personal_services_leisure_services: Personal Services - Leisure Services   - personal_services_domestic_laundry_repairs: Personal Services - Domestic Laundry Repairs   - personal_services_embassies_international_organisations: Personal Services - Embassies</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum PayoutMethodNatureOfBusinessEnum
    {
        /// <summary>
        /// Enum Personal for value: personal
        /// </summary>
        [EnumMember(Value = "personal")]
        Personal = 1,

        /// <summary>
        /// Enum Agricultureandhunting for value: agriculture_and_hunting
        /// </summary>
        [EnumMember(Value = "agriculture_and_hunting")]
        Agricultureandhunting = 2,

        /// <summary>
        /// Enum Forestry for value: forestry
        /// </summary>
        [EnumMember(Value = "forestry")]
        Forestry = 3,

        /// <summary>
        /// Enum Fishing for value: fishing
        /// </summary>
        [EnumMember(Value = "fishing")]
        Fishing = 4,

        /// <summary>
        /// Enum Agriculturalbyproducts for value: agricultural_by_products
        /// </summary>
        [EnumMember(Value = "agricultural_by_products")]
        Agriculturalbyproducts = 5,

        /// <summary>
        /// Enum Coalmining for value: coal_mining
        /// </summary>
        [EnumMember(Value = "coal_mining")]
        Coalmining = 6,

        /// <summary>
        /// Enum Oilmining for value: oil_mining
        /// </summary>
        [EnumMember(Value = "oil_mining")]
        Oilmining = 7,

        /// <summary>
        /// Enum Ironoremining for value: iron_ore_mining
        /// </summary>
        [EnumMember(Value = "iron_ore_mining")]
        Ironoremining = 8,

        /// <summary>
        /// Enum Othermetalanddiamondmining for value: other_metal_and_diamond_mining
        /// </summary>
        [EnumMember(Value = "other_metal_and_diamond_mining")]
        Othermetalanddiamondmining = 9,

        /// <summary>
        /// Enum Othermineralmining for value: other_mineral_mining
        /// </summary>
        [EnumMember(Value = "other_mineral_mining")]
        Othermineralmining = 10,

        /// <summary>
        /// Enum Manufacturingoffooddrinktobacco for value: manufacturing_of_food_drink_tobacco
        /// </summary>
        [EnumMember(Value = "manufacturing_of_food_drink_tobacco")]
        Manufacturingoffooddrinktobacco = 11,

        /// <summary>
        /// Enum Manufacturingoftextilesleatherfurfurniture for value: manufacturing_of_textiles_leather_fur_furniture
        /// </summary>
        [EnumMember(Value = "manufacturing_of_textiles_leather_fur_furniture")]
        Manufacturingoftextilesleatherfurfurniture = 12,

        /// <summary>
        /// Enum Manufactureofwoodenproductsfurniture for value: manufacture_of_wooden_products_furniture
        /// </summary>
        [EnumMember(Value = "manufacture_of_wooden_products_furniture")]
        Manufactureofwoodenproductsfurniture = 13,

        /// <summary>
        /// Enum Manufactureofpaperpulpalliedproducts for value: manufacture_of_paper_pulp_allied_products
        /// </summary>
        [EnumMember(Value = "manufacture_of_paper_pulp_allied_products")]
        Manufactureofpaperpulpalliedproducts = 14,

        /// <summary>
        /// Enum Manufactureofchemicalsmedicalpetroleumrubberplasticproducts for value: manufacture_of_chemicals_medical_petroleum_rubber_plastic_products
        /// </summary>
        [EnumMember(Value = "manufacture_of_chemicals_medical_petroleum_rubber_plastic_products")]
        Manufactureofchemicalsmedicalpetroleumrubberplasticproducts = 15,

        /// <summary>
        /// Enum Manufactureofpotterychinaglassstone for value: manufacture_of_pottery_china_glass_stone
        /// </summary>
        [EnumMember(Value = "manufacture_of_pottery_china_glass_stone")]
        Manufactureofpotterychinaglassstone = 16,

        /// <summary>
        /// Enum Manufactureofironsteelnonferrousmetalsbasicindustries for value: manufacture_of_iron_steel_non_ferrous_metals_basic_industries
        /// </summary>
        [EnumMember(Value = "manufacture_of_iron_steel_non_ferrous_metals_basic_industries")]
        Manufactureofironsteelnonferrousmetalsbasicindustries = 17,

        /// <summary>
        /// Enum Manufactureofmetalproductselectricalandscientificengineering for value: manufacture_of_metal_products_electrical_and_scientific_engineering
        /// </summary>
        [EnumMember(Value = "manufacture_of_metal_products_electrical_and_scientific_engineering")]
        Manufactureofmetalproductselectricalandscientificengineering = 18,

        /// <summary>
        /// Enum Manufactureofjewelrymusicalinstrumentstoys for value: manufacture_of_jewelry_musical_instruments_toys
        /// </summary>
        [EnumMember(Value = "manufacture_of_jewelry_musical_instruments_toys")]
        Manufactureofjewelrymusicalinstrumentstoys = 19,

        /// <summary>
        /// Enum Electricitygasandwater for value: electricity_gas_and_water
        /// </summary>
        [EnumMember(Value = "electricity_gas_and_water")]
        Electricitygasandwater = 20,

        /// <summary>
        /// Enum Construction for value: construction
        /// </summary>
        [EnumMember(Value = "construction")]
        Construction = 21,

        /// <summary>
        /// Enum Wholesaletrade for value: wholesale_trade
        /// </summary>
        [EnumMember(Value = "wholesale_trade")]
        Wholesaletrade = 22,

        /// <summary>
        /// Enum Retailtrade for value: retail_trade
        /// </summary>
        [EnumMember(Value = "retail_trade")]
        Retailtrade = 23,

        /// <summary>
        /// Enum Cateringinclhotels for value: catering_incl_hotels
        /// </summary>
        [EnumMember(Value = "catering_incl_hotels")]
        Cateringinclhotels = 24,

        /// <summary>
        /// Enum Transportstorage for value: transport_storage
        /// </summary>
        [EnumMember(Value = "transport_storage")]
        Transportstorage = 25,

        /// <summary>
        /// Enum Communications for value: communications
        /// </summary>
        [EnumMember(Value = "communications")]
        Communications = 26,

        /// <summary>
        /// Enum Financeandholdingcompanies for value: finance_and_holding_companies
        /// </summary>
        [EnumMember(Value = "finance_and_holding_companies")]
        Financeandholdingcompanies = 27,

        /// <summary>
        /// Enum Insurance for value: insurance
        /// </summary>
        [EnumMember(Value = "insurance")]
        Insurance = 28,

        /// <summary>
        /// Enum Businessservices for value: business_services
        /// </summary>
        [EnumMember(Value = "business_services")]
        Businessservices = 29,

        /// <summary>
        /// Enum Realestatedevelopmentinvestment for value: real_estate_development_investment
        /// </summary>
        [EnumMember(Value = "real_estate_development_investment")]
        Realestatedevelopmentinvestment = 30,

        /// <summary>
        /// Enum Centralstategovernments for value: central_state_governments
        /// </summary>
        [EnumMember(Value = "central_state_governments")]
        Centralstategovernments = 31,

        /// <summary>
        /// Enum Communityservicesdefencepoliceprisonsetc for value: community_services_defence_police_prisons_etc
        /// </summary>
        [EnumMember(Value = "community_services_defence_police_prisons_etc")]
        Communityservicesdefencepoliceprisonsetc = 32,

        /// <summary>
        /// Enum Socialserviceseducationhealthcare for value: social_services_education_health_care
        /// </summary>
        [EnumMember(Value = "social_services_education_health_care")]
        Socialserviceseducationhealthcare = 33,

        /// <summary>
        /// Enum Personalservicesleisureservices for value: personal_services_leisure_services
        /// </summary>
        [EnumMember(Value = "personal_services_leisure_services")]
        Personalservicesleisureservices = 34,

        /// <summary>
        /// Enum Personalservicesdomesticlaundryrepairs for value: personal_services_domestic_laundry_repairs
        /// </summary>
        [EnumMember(Value = "personal_services_domestic_laundry_repairs")]
        Personalservicesdomesticlaundryrepairs = 35,

        /// <summary>
        /// Enum Personalservicesembassiesinternationalorganisations for value: personal_services_embassies_international_organisations
        /// </summary>
        [EnumMember(Value = "personal_services_embassies_international_organisations")]
        Personalservicesembassiesinternationalorganisations = 36

    }

}
