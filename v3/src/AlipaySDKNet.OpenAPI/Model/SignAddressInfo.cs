/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2025-02-06
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
    /// SignAddressInfo
    /// </summary>
    [DataContract(Name = "SignAddressInfo")]
    public partial class SignAddressInfo : IEquatable<SignAddressInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignAddressInfo" /> class.
        /// </summary>
        /// <param name="cityCode">城市编码。请按照&lt;a href&#x3D;\&quot;https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx\&quot;&gt;表格&lt;/a&gt; 中内容填写。 （参考资料： &lt;a href&#x3D;\&quot;http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/\&quot;&gt;参考资料&lt;/a&gt;）.</param>
        /// <param name="countryCode">国家编码，中国默认：156.</param>
        /// <param name="detailAddress">详细地址.</param>
        /// <param name="districtCode">区县编码。请按照&lt;a href&#x3D;\&quot;https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx\&quot;&gt;表格&lt;/a&gt; 中内容填写。 （参考资料： &lt;a href&#x3D;\&quot;http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/\&quot;&gt;参考资料&lt;/a&gt;）.</param>
        /// <param name="latitude">纬度，浮点型,小数点后最多保留6位 如需要录入经纬度，请以高德坐标系为准，录入时请确保经纬度参数准确。高德经纬度查询：&lt;a href&#x3D;\&quot;http://lbs.amap.com/console/show/picker\&quot;&gt;查询地址&lt;/a&gt;.</param>
        /// <param name="longitude">经度，浮点型, 小数点后最多保留6位。 如需要录入经纬度，请以高德坐标系为准，录入时请确保经纬度参数准确。高德经纬度查询：&lt;a href&#x3D;\&quot;http://lbs.amap.com/console/show/picker\&quot;&gt;查询地址&lt;/a&gt;.</param>
        /// <param name="provinceCode">省份编码。请按照&lt;a href&#x3D;\&quot;https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx\&quot;&gt;表格&lt;/a&gt; 中内容填写。 （参考资料： &lt;a href&#x3D;\&quot;http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/\&quot;&gt;参考资料&lt;/a&gt;）.</param>
        public SignAddressInfo(string cityCode = default(string), string countryCode = default(string), string detailAddress = default(string), string districtCode = default(string), string latitude = default(string), string longitude = default(string), string provinceCode = default(string))
        {
            this.CityCode = cityCode;
            this.CountryCode = countryCode;
            this.DetailAddress = detailAddress;
            this.DistrictCode = districtCode;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.ProvinceCode = provinceCode;
        }

        /// <summary>
        /// 城市编码。请按照&lt;a href&#x3D;\&quot;https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx\&quot;&gt;表格&lt;/a&gt; 中内容填写。 （参考资料： &lt;a href&#x3D;\&quot;http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/\&quot;&gt;参考资料&lt;/a&gt;）
        /// </summary>
        /// <value>城市编码。请按照&lt;a href&#x3D;\&quot;https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx\&quot;&gt;表格&lt;/a&gt; 中内容填写。 （参考资料： &lt;a href&#x3D;\&quot;http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/\&quot;&gt;参考资料&lt;/a&gt;）</value>
        [DataMember(Name = "city_code", EmitDefaultValue = false)]
        public string CityCode { get; set; }

        /// <summary>
        /// 国家编码，中国默认：156
        /// </summary>
        /// <value>国家编码，中国默认：156</value>
        [DataMember(Name = "country_code", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// 详细地址
        /// </summary>
        /// <value>详细地址</value>
        [DataMember(Name = "detail_address", EmitDefaultValue = false)]
        public string DetailAddress { get; set; }

        /// <summary>
        /// 区县编码。请按照&lt;a href&#x3D;\&quot;https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx\&quot;&gt;表格&lt;/a&gt; 中内容填写。 （参考资料： &lt;a href&#x3D;\&quot;http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/\&quot;&gt;参考资料&lt;/a&gt;）
        /// </summary>
        /// <value>区县编码。请按照&lt;a href&#x3D;\&quot;https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx\&quot;&gt;表格&lt;/a&gt; 中内容填写。 （参考资料： &lt;a href&#x3D;\&quot;http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/\&quot;&gt;参考资料&lt;/a&gt;）</value>
        [DataMember(Name = "district_code", EmitDefaultValue = false)]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 纬度，浮点型,小数点后最多保留6位 如需要录入经纬度，请以高德坐标系为准，录入时请确保经纬度参数准确。高德经纬度查询：&lt;a href&#x3D;\&quot;http://lbs.amap.com/console/show/picker\&quot;&gt;查询地址&lt;/a&gt;
        /// </summary>
        /// <value>纬度，浮点型,小数点后最多保留6位 如需要录入经纬度，请以高德坐标系为准，录入时请确保经纬度参数准确。高德经纬度查询：&lt;a href&#x3D;\&quot;http://lbs.amap.com/console/show/picker\&quot;&gt;查询地址&lt;/a&gt;</value>
        [DataMember(Name = "latitude", EmitDefaultValue = false)]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度，浮点型, 小数点后最多保留6位。 如需要录入经纬度，请以高德坐标系为准，录入时请确保经纬度参数准确。高德经纬度查询：&lt;a href&#x3D;\&quot;http://lbs.amap.com/console/show/picker\&quot;&gt;查询地址&lt;/a&gt;
        /// </summary>
        /// <value>经度，浮点型, 小数点后最多保留6位。 如需要录入经纬度，请以高德坐标系为准，录入时请确保经纬度参数准确。高德经纬度查询：&lt;a href&#x3D;\&quot;http://lbs.amap.com/console/show/picker\&quot;&gt;查询地址&lt;/a&gt;</value>
        [DataMember(Name = "longitude", EmitDefaultValue = false)]
        public string Longitude { get; set; }

        /// <summary>
        /// 省份编码。请按照&lt;a href&#x3D;\&quot;https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx\&quot;&gt;表格&lt;/a&gt; 中内容填写。 （参考资料： &lt;a href&#x3D;\&quot;http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/\&quot;&gt;参考资料&lt;/a&gt;）
        /// </summary>
        /// <value>省份编码。请按照&lt;a href&#x3D;\&quot;https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx\&quot;&gt;表格&lt;/a&gt; 中内容填写。 （参考资料： &lt;a href&#x3D;\&quot;http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/\&quot;&gt;参考资料&lt;/a&gt;）</value>
        [DataMember(Name = "province_code", EmitDefaultValue = false)]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SignAddressInfo {\n");
            sb.Append("  CityCode: ").Append(CityCode).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  DetailAddress: ").Append(DetailAddress).Append("\n");
            sb.Append("  DistrictCode: ").Append(DistrictCode).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  ProvinceCode: ").Append(ProvinceCode).Append("\n");
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
            return this.Equals(input as SignAddressInfo);
        }

        /// <summary>
        /// Returns true if SignAddressInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of SignAddressInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignAddressInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CityCode == input.CityCode ||
                    (this.CityCode != null &&
                    this.CityCode.Equals(input.CityCode))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.DetailAddress == input.DetailAddress ||
                    (this.DetailAddress != null &&
                    this.DetailAddress.Equals(input.DetailAddress))
                ) && 
                (
                    this.DistrictCode == input.DistrictCode ||
                    (this.DistrictCode != null &&
                    this.DistrictCode.Equals(input.DistrictCode))
                ) && 
                (
                    this.Latitude == input.Latitude ||
                    (this.Latitude != null &&
                    this.Latitude.Equals(input.Latitude))
                ) && 
                (
                    this.Longitude == input.Longitude ||
                    (this.Longitude != null &&
                    this.Longitude.Equals(input.Longitude))
                ) && 
                (
                    this.ProvinceCode == input.ProvinceCode ||
                    (this.ProvinceCode != null &&
                    this.ProvinceCode.Equals(input.ProvinceCode))
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
                if (this.CityCode != null)
                {
                    hashCode = (hashCode * 59) + this.CityCode.GetHashCode();
                }
                if (this.CountryCode != null)
                {
                    hashCode = (hashCode * 59) + this.CountryCode.GetHashCode();
                }
                if (this.DetailAddress != null)
                {
                    hashCode = (hashCode * 59) + this.DetailAddress.GetHashCode();
                }
                if (this.DistrictCode != null)
                {
                    hashCode = (hashCode * 59) + this.DistrictCode.GetHashCode();
                }
                if (this.Latitude != null)
                {
                    hashCode = (hashCode * 59) + this.Latitude.GetHashCode();
                }
                if (this.Longitude != null)
                {
                    hashCode = (hashCode * 59) + this.Longitude.GetHashCode();
                }
                if (this.ProvinceCode != null)
                {
                    hashCode = (hashCode * 59) + this.ProvinceCode.GetHashCode();
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
