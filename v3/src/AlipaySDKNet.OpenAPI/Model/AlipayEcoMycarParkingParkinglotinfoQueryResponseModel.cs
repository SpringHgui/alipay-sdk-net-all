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
    /// AlipayEcoMycarParkingParkinglotinfoQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayEcoMycarParkingParkinglotinfoQueryResponseModel")]
    public partial class AlipayEcoMycarParkingParkinglotinfoQueryResponseModel : IEquatable<AlipayEcoMycarParkingParkinglotinfoQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEcoMycarParkingParkinglotinfoQueryResponseModel" /> class.
        /// </summary>
        /// <param name="addressId">地区编码.</param>
        /// <param name="agentId">服务商ID（2088开头的16位纯数字），由服务商提供给ISV.</param>
        /// <param name="businessIsv">车场业务归属列表.</param>
        /// <param name="cityId">城市编码.</param>
        /// <param name="mapPoiAddress">高德检索地址.</param>
        /// <param name="mapPoiName">高德检索名称.</param>
        /// <param name="mchntId">收款方ID（2088开头的16位纯数字），由停车场收款的业主方提供给ISV，该字段暂用于机具和物料申领.</param>
        /// <param name="outParkingId">ISV停车场ID，由ISV提供，同一个isv或商户范围内唯一.</param>
        /// <param name="parkingAddress">停车场地址.</param>
        /// <param name="parkingFeeDescription">收费说明.</param>
        /// <param name="parkingFeeDescriptionImg">停车场价格明细图片.</param>
        /// <param name="parkingId">支付宝返回停车场id，系统唯一.</param>
        /// <param name="parkingLatitude">停车场位置经度（优先高德坐标获取结果）.</param>
        /// <param name="parkingLongitude">停车场位置经度（优先高德坐标获取结果）.</param>
        /// <param name="parkingLotType">停车场类型，1为居民小区、2为商圈停车场（购物中心商业广场商场等）、3为路侧停车、4为公园景点（景点乐园公园老街古镇等）、5为商务楼宇（酒店写字楼商务楼园区等）、6为其他、7为交通枢纽（机场火车站汽车站码头港口等）、8为市政设施（体育场博物图书馆医院学校等）.</param>
        /// <param name="parkingMobile">停车场客服电话.</param>
        /// <param name="parkingName">停车场名称，由ISV定义，尽量与高德地图上的一致.</param>
        /// <param name="parkingPoiid">高德地图唯一标识.</param>
        /// <param name="payType">支付方式（1为支付宝在线缴费，2为支付宝代扣缴费，3当面付)，如支持多种方式以&#39;,&#39;进行间隔.</param>
        /// <param name="provinceId">省份编码.</param>
        /// <param name="shopingmallId">商圈id.</param>
        /// <param name="timeOut">用户支付未离场的超时时间(以分钟为单位).</param>
        public AlipayEcoMycarParkingParkinglotinfoQueryResponseModel(string addressId = default(string), string agentId = default(string), List<BusinessItem> businessIsv = default(List<BusinessItem>), string cityId = default(string), string mapPoiAddress = default(string), string mapPoiName = default(string), string mchntId = default(string), string outParkingId = default(string), string parkingAddress = default(string), string parkingFeeDescription = default(string), string parkingFeeDescriptionImg = default(string), string parkingId = default(string), string parkingLatitude = default(string), string parkingLongitude = default(string), string parkingLotType = default(string), string parkingMobile = default(string), string parkingName = default(string), string parkingPoiid = default(string), string payType = default(string), string provinceId = default(string), string shopingmallId = default(string), string timeOut = default(string))
        {
            this.AddressId = addressId;
            this.AgentId = agentId;
            this.BusinessIsv = businessIsv;
            this.CityId = cityId;
            this.MapPoiAddress = mapPoiAddress;
            this.MapPoiName = mapPoiName;
            this.MchntId = mchntId;
            this.OutParkingId = outParkingId;
            this.ParkingAddress = parkingAddress;
            this.ParkingFeeDescription = parkingFeeDescription;
            this.ParkingFeeDescriptionImg = parkingFeeDescriptionImg;
            this.ParkingId = parkingId;
            this.ParkingLatitude = parkingLatitude;
            this.ParkingLongitude = parkingLongitude;
            this.ParkingLotType = parkingLotType;
            this.ParkingMobile = parkingMobile;
            this.ParkingName = parkingName;
            this.ParkingPoiid = parkingPoiid;
            this.PayType = payType;
            this.ProvinceId = provinceId;
            this.ShopingmallId = shopingmallId;
            this.TimeOut = timeOut;
        }

        /// <summary>
        /// 地区编码
        /// </summary>
        /// <value>地区编码</value>
        [DataMember(Name = "address_id", EmitDefaultValue = false)]
        public string AddressId { get; set; }

        /// <summary>
        /// 服务商ID（2088开头的16位纯数字），由服务商提供给ISV
        /// </summary>
        /// <value>服务商ID（2088开头的16位纯数字），由服务商提供给ISV</value>
        [DataMember(Name = "agent_id", EmitDefaultValue = false)]
        public string AgentId { get; set; }

        /// <summary>
        /// 车场业务归属列表
        /// </summary>
        /// <value>车场业务归属列表</value>
        [DataMember(Name = "business_isv", EmitDefaultValue = false)]
        public List<BusinessItem> BusinessIsv { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        /// <value>城市编码</value>
        [DataMember(Name = "city_id", EmitDefaultValue = false)]
        public string CityId { get; set; }

        /// <summary>
        /// 高德检索地址
        /// </summary>
        /// <value>高德检索地址</value>
        [DataMember(Name = "map_poi_address", EmitDefaultValue = false)]
        public string MapPoiAddress { get; set; }

        /// <summary>
        /// 高德检索名称
        /// </summary>
        /// <value>高德检索名称</value>
        [DataMember(Name = "map_poi_name", EmitDefaultValue = false)]
        public string MapPoiName { get; set; }

        /// <summary>
        /// 收款方ID（2088开头的16位纯数字），由停车场收款的业主方提供给ISV，该字段暂用于机具和物料申领
        /// </summary>
        /// <value>收款方ID（2088开头的16位纯数字），由停车场收款的业主方提供给ISV，该字段暂用于机具和物料申领</value>
        [DataMember(Name = "mchnt_id", EmitDefaultValue = false)]
        public string MchntId { get; set; }

        /// <summary>
        /// ISV停车场ID，由ISV提供，同一个isv或商户范围内唯一
        /// </summary>
        /// <value>ISV停车场ID，由ISV提供，同一个isv或商户范围内唯一</value>
        [DataMember(Name = "out_parking_id", EmitDefaultValue = false)]
        public string OutParkingId { get; set; }

        /// <summary>
        /// 停车场地址
        /// </summary>
        /// <value>停车场地址</value>
        [DataMember(Name = "parking_address", EmitDefaultValue = false)]
        public string ParkingAddress { get; set; }

        /// <summary>
        /// 收费说明
        /// </summary>
        /// <value>收费说明</value>
        [DataMember(Name = "parking_fee_description", EmitDefaultValue = false)]
        public string ParkingFeeDescription { get; set; }

        /// <summary>
        /// 停车场价格明细图片
        /// </summary>
        /// <value>停车场价格明细图片</value>
        [DataMember(Name = "parking_fee_description_img", EmitDefaultValue = false)]
        public string ParkingFeeDescriptionImg { get; set; }

        /// <summary>
        /// 支付宝返回停车场id，系统唯一
        /// </summary>
        /// <value>支付宝返回停车场id，系统唯一</value>
        [DataMember(Name = "parking_id", EmitDefaultValue = false)]
        public string ParkingId { get; set; }

        /// <summary>
        /// 停车场位置经度（优先高德坐标获取结果）
        /// </summary>
        /// <value>停车场位置经度（优先高德坐标获取结果）</value>
        [DataMember(Name = "parking_latitude", EmitDefaultValue = false)]
        public string ParkingLatitude { get; set; }

        /// <summary>
        /// 停车场位置经度（优先高德坐标获取结果）
        /// </summary>
        /// <value>停车场位置经度（优先高德坐标获取结果）</value>
        [DataMember(Name = "parking_longitude", EmitDefaultValue = false)]
        public string ParkingLongitude { get; set; }

        /// <summary>
        /// 停车场类型，1为居民小区、2为商圈停车场（购物中心商业广场商场等）、3为路侧停车、4为公园景点（景点乐园公园老街古镇等）、5为商务楼宇（酒店写字楼商务楼园区等）、6为其他、7为交通枢纽（机场火车站汽车站码头港口等）、8为市政设施（体育场博物图书馆医院学校等）
        /// </summary>
        /// <value>停车场类型，1为居民小区、2为商圈停车场（购物中心商业广场商场等）、3为路侧停车、4为公园景点（景点乐园公园老街古镇等）、5为商务楼宇（酒店写字楼商务楼园区等）、6为其他、7为交通枢纽（机场火车站汽车站码头港口等）、8为市政设施（体育场博物图书馆医院学校等）</value>
        [DataMember(Name = "parking_lot_type", EmitDefaultValue = false)]
        public string ParkingLotType { get; set; }

        /// <summary>
        /// 停车场客服电话
        /// </summary>
        /// <value>停车场客服电话</value>
        [DataMember(Name = "parking_mobile", EmitDefaultValue = false)]
        public string ParkingMobile { get; set; }

        /// <summary>
        /// 停车场名称，由ISV定义，尽量与高德地图上的一致
        /// </summary>
        /// <value>停车场名称，由ISV定义，尽量与高德地图上的一致</value>
        [DataMember(Name = "parking_name", EmitDefaultValue = false)]
        public string ParkingName { get; set; }

        /// <summary>
        /// 高德地图唯一标识
        /// </summary>
        /// <value>高德地图唯一标识</value>
        [DataMember(Name = "parking_poiid", EmitDefaultValue = false)]
        public string ParkingPoiid { get; set; }

        /// <summary>
        /// 支付方式（1为支付宝在线缴费，2为支付宝代扣缴费，3当面付)，如支持多种方式以&#39;,&#39;进行间隔
        /// </summary>
        /// <value>支付方式（1为支付宝在线缴费，2为支付宝代扣缴费，3当面付)，如支持多种方式以&#39;,&#39;进行间隔</value>
        [DataMember(Name = "pay_type", EmitDefaultValue = false)]
        public string PayType { get; set; }

        /// <summary>
        /// 省份编码
        /// </summary>
        /// <value>省份编码</value>
        [DataMember(Name = "province_id", EmitDefaultValue = false)]
        public string ProvinceId { get; set; }

        /// <summary>
        /// 商圈id
        /// </summary>
        /// <value>商圈id</value>
        [DataMember(Name = "shopingmall_id", EmitDefaultValue = false)]
        public string ShopingmallId { get; set; }

        /// <summary>
        /// 用户支付未离场的超时时间(以分钟为单位)
        /// </summary>
        /// <value>用户支付未离场的超时时间(以分钟为单位)</value>
        [DataMember(Name = "time_out", EmitDefaultValue = false)]
        public string TimeOut { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEcoMycarParkingParkinglotinfoQueryResponseModel {\n");
            sb.Append("  AddressId: ").Append(AddressId).Append("\n");
            sb.Append("  AgentId: ").Append(AgentId).Append("\n");
            sb.Append("  BusinessIsv: ").Append(BusinessIsv).Append("\n");
            sb.Append("  CityId: ").Append(CityId).Append("\n");
            sb.Append("  MapPoiAddress: ").Append(MapPoiAddress).Append("\n");
            sb.Append("  MapPoiName: ").Append(MapPoiName).Append("\n");
            sb.Append("  MchntId: ").Append(MchntId).Append("\n");
            sb.Append("  OutParkingId: ").Append(OutParkingId).Append("\n");
            sb.Append("  ParkingAddress: ").Append(ParkingAddress).Append("\n");
            sb.Append("  ParkingFeeDescription: ").Append(ParkingFeeDescription).Append("\n");
            sb.Append("  ParkingFeeDescriptionImg: ").Append(ParkingFeeDescriptionImg).Append("\n");
            sb.Append("  ParkingId: ").Append(ParkingId).Append("\n");
            sb.Append("  ParkingLatitude: ").Append(ParkingLatitude).Append("\n");
            sb.Append("  ParkingLongitude: ").Append(ParkingLongitude).Append("\n");
            sb.Append("  ParkingLotType: ").Append(ParkingLotType).Append("\n");
            sb.Append("  ParkingMobile: ").Append(ParkingMobile).Append("\n");
            sb.Append("  ParkingName: ").Append(ParkingName).Append("\n");
            sb.Append("  ParkingPoiid: ").Append(ParkingPoiid).Append("\n");
            sb.Append("  PayType: ").Append(PayType).Append("\n");
            sb.Append("  ProvinceId: ").Append(ProvinceId).Append("\n");
            sb.Append("  ShopingmallId: ").Append(ShopingmallId).Append("\n");
            sb.Append("  TimeOut: ").Append(TimeOut).Append("\n");
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
            return this.Equals(input as AlipayEcoMycarParkingParkinglotinfoQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayEcoMycarParkingParkinglotinfoQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEcoMycarParkingParkinglotinfoQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEcoMycarParkingParkinglotinfoQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AddressId == input.AddressId ||
                    (this.AddressId != null &&
                    this.AddressId.Equals(input.AddressId))
                ) && 
                (
                    this.AgentId == input.AgentId ||
                    (this.AgentId != null &&
                    this.AgentId.Equals(input.AgentId))
                ) && 
                (
                    this.BusinessIsv == input.BusinessIsv ||
                    this.BusinessIsv != null &&
                    input.BusinessIsv != null &&
                    this.BusinessIsv.SequenceEqual(input.BusinessIsv)
                ) && 
                (
                    this.CityId == input.CityId ||
                    (this.CityId != null &&
                    this.CityId.Equals(input.CityId))
                ) && 
                (
                    this.MapPoiAddress == input.MapPoiAddress ||
                    (this.MapPoiAddress != null &&
                    this.MapPoiAddress.Equals(input.MapPoiAddress))
                ) && 
                (
                    this.MapPoiName == input.MapPoiName ||
                    (this.MapPoiName != null &&
                    this.MapPoiName.Equals(input.MapPoiName))
                ) && 
                (
                    this.MchntId == input.MchntId ||
                    (this.MchntId != null &&
                    this.MchntId.Equals(input.MchntId))
                ) && 
                (
                    this.OutParkingId == input.OutParkingId ||
                    (this.OutParkingId != null &&
                    this.OutParkingId.Equals(input.OutParkingId))
                ) && 
                (
                    this.ParkingAddress == input.ParkingAddress ||
                    (this.ParkingAddress != null &&
                    this.ParkingAddress.Equals(input.ParkingAddress))
                ) && 
                (
                    this.ParkingFeeDescription == input.ParkingFeeDescription ||
                    (this.ParkingFeeDescription != null &&
                    this.ParkingFeeDescription.Equals(input.ParkingFeeDescription))
                ) && 
                (
                    this.ParkingFeeDescriptionImg == input.ParkingFeeDescriptionImg ||
                    (this.ParkingFeeDescriptionImg != null &&
                    this.ParkingFeeDescriptionImg.Equals(input.ParkingFeeDescriptionImg))
                ) && 
                (
                    this.ParkingId == input.ParkingId ||
                    (this.ParkingId != null &&
                    this.ParkingId.Equals(input.ParkingId))
                ) && 
                (
                    this.ParkingLatitude == input.ParkingLatitude ||
                    (this.ParkingLatitude != null &&
                    this.ParkingLatitude.Equals(input.ParkingLatitude))
                ) && 
                (
                    this.ParkingLongitude == input.ParkingLongitude ||
                    (this.ParkingLongitude != null &&
                    this.ParkingLongitude.Equals(input.ParkingLongitude))
                ) && 
                (
                    this.ParkingLotType == input.ParkingLotType ||
                    (this.ParkingLotType != null &&
                    this.ParkingLotType.Equals(input.ParkingLotType))
                ) && 
                (
                    this.ParkingMobile == input.ParkingMobile ||
                    (this.ParkingMobile != null &&
                    this.ParkingMobile.Equals(input.ParkingMobile))
                ) && 
                (
                    this.ParkingName == input.ParkingName ||
                    (this.ParkingName != null &&
                    this.ParkingName.Equals(input.ParkingName))
                ) && 
                (
                    this.ParkingPoiid == input.ParkingPoiid ||
                    (this.ParkingPoiid != null &&
                    this.ParkingPoiid.Equals(input.ParkingPoiid))
                ) && 
                (
                    this.PayType == input.PayType ||
                    (this.PayType != null &&
                    this.PayType.Equals(input.PayType))
                ) && 
                (
                    this.ProvinceId == input.ProvinceId ||
                    (this.ProvinceId != null &&
                    this.ProvinceId.Equals(input.ProvinceId))
                ) && 
                (
                    this.ShopingmallId == input.ShopingmallId ||
                    (this.ShopingmallId != null &&
                    this.ShopingmallId.Equals(input.ShopingmallId))
                ) && 
                (
                    this.TimeOut == input.TimeOut ||
                    (this.TimeOut != null &&
                    this.TimeOut.Equals(input.TimeOut))
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
                if (this.AddressId != null)
                {
                    hashCode = (hashCode * 59) + this.AddressId.GetHashCode();
                }
                if (this.AgentId != null)
                {
                    hashCode = (hashCode * 59) + this.AgentId.GetHashCode();
                }
                if (this.BusinessIsv != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessIsv.GetHashCode();
                }
                if (this.CityId != null)
                {
                    hashCode = (hashCode * 59) + this.CityId.GetHashCode();
                }
                if (this.MapPoiAddress != null)
                {
                    hashCode = (hashCode * 59) + this.MapPoiAddress.GetHashCode();
                }
                if (this.MapPoiName != null)
                {
                    hashCode = (hashCode * 59) + this.MapPoiName.GetHashCode();
                }
                if (this.MchntId != null)
                {
                    hashCode = (hashCode * 59) + this.MchntId.GetHashCode();
                }
                if (this.OutParkingId != null)
                {
                    hashCode = (hashCode * 59) + this.OutParkingId.GetHashCode();
                }
                if (this.ParkingAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ParkingAddress.GetHashCode();
                }
                if (this.ParkingFeeDescription != null)
                {
                    hashCode = (hashCode * 59) + this.ParkingFeeDescription.GetHashCode();
                }
                if (this.ParkingFeeDescriptionImg != null)
                {
                    hashCode = (hashCode * 59) + this.ParkingFeeDescriptionImg.GetHashCode();
                }
                if (this.ParkingId != null)
                {
                    hashCode = (hashCode * 59) + this.ParkingId.GetHashCode();
                }
                if (this.ParkingLatitude != null)
                {
                    hashCode = (hashCode * 59) + this.ParkingLatitude.GetHashCode();
                }
                if (this.ParkingLongitude != null)
                {
                    hashCode = (hashCode * 59) + this.ParkingLongitude.GetHashCode();
                }
                if (this.ParkingLotType != null)
                {
                    hashCode = (hashCode * 59) + this.ParkingLotType.GetHashCode();
                }
                if (this.ParkingMobile != null)
                {
                    hashCode = (hashCode * 59) + this.ParkingMobile.GetHashCode();
                }
                if (this.ParkingName != null)
                {
                    hashCode = (hashCode * 59) + this.ParkingName.GetHashCode();
                }
                if (this.ParkingPoiid != null)
                {
                    hashCode = (hashCode * 59) + this.ParkingPoiid.GetHashCode();
                }
                if (this.PayType != null)
                {
                    hashCode = (hashCode * 59) + this.PayType.GetHashCode();
                }
                if (this.ProvinceId != null)
                {
                    hashCode = (hashCode * 59) + this.ProvinceId.GetHashCode();
                }
                if (this.ShopingmallId != null)
                {
                    hashCode = (hashCode * 59) + this.ShopingmallId.GetHashCode();
                }
                if (this.TimeOut != null)
                {
                    hashCode = (hashCode * 59) + this.TimeOut.GetHashCode();
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
