/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2023-10-26
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
    /// SenderIstd
    /// </summary>
    [DataContract(Name = "SenderIstd")]
    public partial class SenderIstd : IEquatable<SenderIstd>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SenderIstd" /> class.
        /// </summary>
        /// <param name="address">地址(街道、小区、大厦等，用于定位).</param>
        /// <param name="addressDetail">地址详情(楼号、单元号、层号).</param>
        /// <param name="city">城市名称，如杭州市.</param>
        /// <param name="coordinateType">坐标类型，0：火星坐标（高德，腾讯地图均采用火星坐标） 1:百度坐标， 目前只支持0.</param>
        /// <param name="lat">纬度.</param>
        /// <param name="lng">经度.</param>
        /// <param name="mobileNo">手机号.</param>
        /// <param name="name">姓名.</param>
        public SenderIstd(string address = default(string), string addressDetail = default(string), string city = default(string), int coordinateType = default(int), string lat = default(string), string lng = default(string), string mobileNo = default(string), string name = default(string))
        {
            this.Address = address;
            this.AddressDetail = addressDetail;
            this.City = city;
            this.CoordinateType = coordinateType;
            this.Lat = lat;
            this.Lng = lng;
            this.MobileNo = mobileNo;
            this.Name = name;
        }

        /// <summary>
        /// 地址(街道、小区、大厦等，用于定位)
        /// </summary>
        /// <value>地址(街道、小区、大厦等，用于定位)</value>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// 地址详情(楼号、单元号、层号)
        /// </summary>
        /// <value>地址详情(楼号、单元号、层号)</value>
        [DataMember(Name = "address_detail", EmitDefaultValue = false)]
        public string AddressDetail { get; set; }

        /// <summary>
        /// 城市名称，如杭州市
        /// </summary>
        /// <value>城市名称，如杭州市</value>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// 坐标类型，0：火星坐标（高德，腾讯地图均采用火星坐标） 1:百度坐标， 目前只支持0
        /// </summary>
        /// <value>坐标类型，0：火星坐标（高德，腾讯地图均采用火星坐标） 1:百度坐标， 目前只支持0</value>
        [DataMember(Name = "coordinate_type", EmitDefaultValue = false)]
        public int CoordinateType { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        /// <value>纬度</value>
        [DataMember(Name = "lat", EmitDefaultValue = false)]
        public string Lat { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        /// <value>经度</value>
        [DataMember(Name = "lng", EmitDefaultValue = false)]
        public string Lng { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        /// <value>手机号</value>
        [DataMember(Name = "mobile_no", EmitDefaultValue = false)]
        public string MobileNo { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        /// <value>姓名</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SenderIstd {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  AddressDetail: ").Append(AddressDetail).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  CoordinateType: ").Append(CoordinateType).Append("\n");
            sb.Append("  Lat: ").Append(Lat).Append("\n");
            sb.Append("  Lng: ").Append(Lng).Append("\n");
            sb.Append("  MobileNo: ").Append(MobileNo).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as SenderIstd);
        }

        /// <summary>
        /// Returns true if SenderIstd instances are equal
        /// </summary>
        /// <param name="input">Instance of SenderIstd to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SenderIstd input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.AddressDetail == input.AddressDetail ||
                    (this.AddressDetail != null &&
                    this.AddressDetail.Equals(input.AddressDetail))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.CoordinateType == input.CoordinateType ||
                    this.CoordinateType.Equals(input.CoordinateType)
                ) && 
                (
                    this.Lat == input.Lat ||
                    (this.Lat != null &&
                    this.Lat.Equals(input.Lat))
                ) && 
                (
                    this.Lng == input.Lng ||
                    (this.Lng != null &&
                    this.Lng.Equals(input.Lng))
                ) && 
                (
                    this.MobileNo == input.MobileNo ||
                    (this.MobileNo != null &&
                    this.MobileNo.Equals(input.MobileNo))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.AddressDetail != null)
                {
                    hashCode = (hashCode * 59) + this.AddressDetail.GetHashCode();
                }
                if (this.City != null)
                {
                    hashCode = (hashCode * 59) + this.City.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CoordinateType.GetHashCode();
                if (this.Lat != null)
                {
                    hashCode = (hashCode * 59) + this.Lat.GetHashCode();
                }
                if (this.Lng != null)
                {
                    hashCode = (hashCode * 59) + this.Lng.GetHashCode();
                }
                if (this.MobileNo != null)
                {
                    hashCode = (hashCode * 59) + this.MobileNo.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
