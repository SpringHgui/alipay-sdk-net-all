/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2023-07-17
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = AlipaySDKNet.OpenAPI.Client.OpenAPIDateConverter;

namespace AlipaySDKNet.OpenAPI.Model
{
    /// <summary>
    /// RegionInfo
    /// </summary>
    [DataContract(Name = "RegionInfo")]
    public partial class RegionInfo : IEquatable<RegionInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RegionInfo" /> class.
        /// </summary>
        /// <param name="areaCode">地址所属区代码.</param>
        /// <param name="areaName">地址所属区名称.</param>
        /// <param name="cityCode">地址所属市代码.</param>
        /// <param name="cityName">地址所属市名称.</param>
        /// <param name="provinceCode">地址所属省份代码.</param>
        /// <param name="provinceName">地址所属省份名称.</param>
        public RegionInfo(string areaCode = default(string), string areaName = default(string), string cityCode = default(string), string cityName = default(string), string provinceCode = default(string), string provinceName = default(string))
        {
            this.AreaCode = areaCode;
            this.AreaName = areaName;
            this.CityCode = cityCode;
            this.CityName = cityName;
            this.ProvinceCode = provinceCode;
            this.ProvinceName = provinceName;
        }

        /// <summary>
        /// 地址所属区代码
        /// </summary>
        /// <value>地址所属区代码</value>
        [DataMember(Name = "area_code", EmitDefaultValue = false)]
        public string AreaCode { get; set; }

        /// <summary>
        /// 地址所属区名称
        /// </summary>
        /// <value>地址所属区名称</value>
        [DataMember(Name = "area_name", EmitDefaultValue = false)]
        public string AreaName { get; set; }

        /// <summary>
        /// 地址所属市代码
        /// </summary>
        /// <value>地址所属市代码</value>
        [DataMember(Name = "city_code", EmitDefaultValue = false)]
        public string CityCode { get; set; }

        /// <summary>
        /// 地址所属市名称
        /// </summary>
        /// <value>地址所属市名称</value>
        [DataMember(Name = "city_name", EmitDefaultValue = false)]
        public string CityName { get; set; }

        /// <summary>
        /// 地址所属省份代码
        /// </summary>
        /// <value>地址所属省份代码</value>
        [DataMember(Name = "province_code", EmitDefaultValue = false)]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 地址所属省份名称
        /// </summary>
        /// <value>地址所属省份名称</value>
        [DataMember(Name = "province_name", EmitDefaultValue = false)]
        public string ProvinceName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RegionInfo {\n");
            sb.Append("  AreaCode: ").Append(AreaCode).Append("\n");
            sb.Append("  AreaName: ").Append(AreaName).Append("\n");
            sb.Append("  CityCode: ").Append(CityCode).Append("\n");
            sb.Append("  CityName: ").Append(CityName).Append("\n");
            sb.Append("  ProvinceCode: ").Append(ProvinceCode).Append("\n");
            sb.Append("  ProvinceName: ").Append(ProvinceName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as RegionInfo);
        }

        /// <summary>
        /// Returns true if RegionInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of RegionInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RegionInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AreaCode == input.AreaCode ||
                    (this.AreaCode != null &&
                    this.AreaCode.Equals(input.AreaCode))
                ) && 
                (
                    this.AreaName == input.AreaName ||
                    (this.AreaName != null &&
                    this.AreaName.Equals(input.AreaName))
                ) && 
                (
                    this.CityCode == input.CityCode ||
                    (this.CityCode != null &&
                    this.CityCode.Equals(input.CityCode))
                ) && 
                (
                    this.CityName == input.CityName ||
                    (this.CityName != null &&
                    this.CityName.Equals(input.CityName))
                ) && 
                (
                    this.ProvinceCode == input.ProvinceCode ||
                    (this.ProvinceCode != null &&
                    this.ProvinceCode.Equals(input.ProvinceCode))
                ) && 
                (
                    this.ProvinceName == input.ProvinceName ||
                    (this.ProvinceName != null &&
                    this.ProvinceName.Equals(input.ProvinceName))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AreaCode != null)
                {
                    hashCode = (hashCode * 59) + this.AreaCode.GetHashCode();
                }
                if (this.AreaName != null)
                {
                    hashCode = (hashCode * 59) + this.AreaName.GetHashCode();
                }
                if (this.CityCode != null)
                {
                    hashCode = (hashCode * 59) + this.CityCode.GetHashCode();
                }
                if (this.CityName != null)
                {
                    hashCode = (hashCode * 59) + this.CityName.GetHashCode();
                }
                if (this.ProvinceCode != null)
                {
                    hashCode = (hashCode * 59) + this.ProvinceCode.GetHashCode();
                }
                if (this.ProvinceName != null)
                {
                    hashCode = (hashCode * 59) + this.ProvinceName.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
