/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2024-10-08
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
    /// TicketOrderInfo
    /// </summary>
    [DataContract(Name = "TicketOrderInfo")]
    public partial class TicketOrderInfo : IEquatable<TicketOrderInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TicketOrderInfo" /> class.
        /// </summary>
        /// <param name="arrival">arrival.</param>
        /// <param name="content">凭证内容.</param>
        /// <param name="departure">departure.</param>
        /// <param name="effectiveNum">凭证有效数.</param>
        /// <param name="endTime">凭证结束时间.</param>
        /// <param name="extInfo">扩展信息.</param>
        /// <param name="faceValue">票面价.</param>
        /// <param name="functionalServices">功能服务信息.</param>
        /// <param name="invalidReason">凭证失效原因.</param>
        /// <param name="locations">凭证可使用地点.</param>
        /// <param name="merchantTicketNo">商户侧凭证ID或核销码.</param>
        /// <param name="seatInfos">座位信息.</param>
        /// <param name="serviceProvider">serviceProvider.</param>
        /// <param name="shops">凭证可使用门店列表.</param>
        /// <param name="startTime">凭证开始时间.</param>
        /// <param name="status">凭证状态.</param>
        /// <param name="ticketCreateTime">凭证创建时间.</param>
        /// <param name="ticketModifyTime">凭证修改时间.</param>
        /// <param name="ticketNum">凭证购买数.</param>
        /// <param name="ticketUsers">凭证使用者信息.</param>
        /// <param name="title">凭证标题.</param>
        /// <param name="vehicleInfo">vehicleInfo.</param>
        public TicketOrderInfo(JourneyLocation arrival = default(JourneyLocation), string content = default(string), JourneyLocation departure = default(JourneyLocation), int effectiveNum = default(int), string endTime = default(string), List<OrderExtInfo> extInfo = default(List<OrderExtInfo>), string faceValue = default(string), List<FunctionalService> functionalServices = default(List<FunctionalService>), string invalidReason = default(string), List<JourneyLocation> locations = default(List<JourneyLocation>), string merchantTicketNo = default(string), List<SeatInfo> seatInfos = default(List<SeatInfo>), OrderParticipantInfo serviceProvider = default(OrderParticipantInfo), List<OrderShopInfo> shops = default(List<OrderShopInfo>), string startTime = default(string), string status = default(string), string ticketCreateTime = default(string), string ticketModifyTime = default(string), int ticketNum = default(int), List<UserInfomation> ticketUsers = default(List<UserInfomation>), string title = default(string), OrderVehicleInfo vehicleInfo = default(OrderVehicleInfo))
        {
            this.Arrival = arrival;
            this.Content = content;
            this.Departure = departure;
            this.EffectiveNum = effectiveNum;
            this.EndTime = endTime;
            this.ExtInfo = extInfo;
            this.FaceValue = faceValue;
            this.FunctionalServices = functionalServices;
            this.InvalidReason = invalidReason;
            this.Locations = locations;
            this.MerchantTicketNo = merchantTicketNo;
            this.SeatInfos = seatInfos;
            this.ServiceProvider = serviceProvider;
            this.Shops = shops;
            this.StartTime = startTime;
            this.Status = status;
            this.TicketCreateTime = ticketCreateTime;
            this.TicketModifyTime = ticketModifyTime;
            this.TicketNum = ticketNum;
            this.TicketUsers = ticketUsers;
            this.Title = title;
            this.VehicleInfo = vehicleInfo;
        }

        /// <summary>
        /// Gets or Sets Arrival
        /// </summary>
        [DataMember(Name = "arrival", EmitDefaultValue = false)]
        public JourneyLocation Arrival { get; set; }

        /// <summary>
        /// 凭证内容
        /// </summary>
        /// <value>凭证内容</value>
        [DataMember(Name = "content", EmitDefaultValue = false)]
        public string Content { get; set; }

        /// <summary>
        /// Gets or Sets Departure
        /// </summary>
        [DataMember(Name = "departure", EmitDefaultValue = false)]
        public JourneyLocation Departure { get; set; }

        /// <summary>
        /// 凭证有效数
        /// </summary>
        /// <value>凭证有效数</value>
        [DataMember(Name = "effective_num", EmitDefaultValue = false)]
        public int EffectiveNum { get; set; }

        /// <summary>
        /// 凭证结束时间
        /// </summary>
        /// <value>凭证结束时间</value>
        [DataMember(Name = "end_time", EmitDefaultValue = false)]
        public string EndTime { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        /// <value>扩展信息</value>
        [DataMember(Name = "ext_info", EmitDefaultValue = false)]
        public List<OrderExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 票面价
        /// </summary>
        /// <value>票面价</value>
        [DataMember(Name = "face_value", EmitDefaultValue = false)]
        public string FaceValue { get; set; }

        /// <summary>
        /// 功能服务信息
        /// </summary>
        /// <value>功能服务信息</value>
        [DataMember(Name = "functional_services", EmitDefaultValue = false)]
        public List<FunctionalService> FunctionalServices { get; set; }

        /// <summary>
        /// 凭证失效原因
        /// </summary>
        /// <value>凭证失效原因</value>
        [DataMember(Name = "invalid_reason", EmitDefaultValue = false)]
        public string InvalidReason { get; set; }

        /// <summary>
        /// 凭证可使用地点
        /// </summary>
        /// <value>凭证可使用地点</value>
        [DataMember(Name = "locations", EmitDefaultValue = false)]
        public List<JourneyLocation> Locations { get; set; }

        /// <summary>
        /// 商户侧凭证ID或核销码
        /// </summary>
        /// <value>商户侧凭证ID或核销码</value>
        [DataMember(Name = "merchant_ticket_no", EmitDefaultValue = false)]
        public string MerchantTicketNo { get; set; }

        /// <summary>
        /// 座位信息
        /// </summary>
        /// <value>座位信息</value>
        [DataMember(Name = "seat_infos", EmitDefaultValue = false)]
        public List<SeatInfo> SeatInfos { get; set; }

        /// <summary>
        /// Gets or Sets ServiceProvider
        /// </summary>
        [DataMember(Name = "service_provider", EmitDefaultValue = false)]
        public OrderParticipantInfo ServiceProvider { get; set; }

        /// <summary>
        /// 凭证可使用门店列表
        /// </summary>
        /// <value>凭证可使用门店列表</value>
        [DataMember(Name = "shops", EmitDefaultValue = false)]
        public List<OrderShopInfo> Shops { get; set; }

        /// <summary>
        /// 凭证开始时间
        /// </summary>
        /// <value>凭证开始时间</value>
        [DataMember(Name = "start_time", EmitDefaultValue = false)]
        public string StartTime { get; set; }

        /// <summary>
        /// 凭证状态
        /// </summary>
        /// <value>凭证状态</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// 凭证创建时间
        /// </summary>
        /// <value>凭证创建时间</value>
        [DataMember(Name = "ticket_create_time", EmitDefaultValue = false)]
        public string TicketCreateTime { get; set; }

        /// <summary>
        /// 凭证修改时间
        /// </summary>
        /// <value>凭证修改时间</value>
        [DataMember(Name = "ticket_modify_time", EmitDefaultValue = false)]
        public string TicketModifyTime { get; set; }

        /// <summary>
        /// 凭证购买数
        /// </summary>
        /// <value>凭证购买数</value>
        [DataMember(Name = "ticket_num", EmitDefaultValue = false)]
        public int TicketNum { get; set; }

        /// <summary>
        /// 凭证使用者信息
        /// </summary>
        /// <value>凭证使用者信息</value>
        [DataMember(Name = "ticket_users", EmitDefaultValue = false)]
        public List<UserInfomation> TicketUsers { get; set; }

        /// <summary>
        /// 凭证标题
        /// </summary>
        /// <value>凭证标题</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets VehicleInfo
        /// </summary>
        [DataMember(Name = "vehicle_info", EmitDefaultValue = false)]
        public OrderVehicleInfo VehicleInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TicketOrderInfo {\n");
            sb.Append("  Arrival: ").Append(Arrival).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Departure: ").Append(Departure).Append("\n");
            sb.Append("  EffectiveNum: ").Append(EffectiveNum).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  ExtInfo: ").Append(ExtInfo).Append("\n");
            sb.Append("  FaceValue: ").Append(FaceValue).Append("\n");
            sb.Append("  FunctionalServices: ").Append(FunctionalServices).Append("\n");
            sb.Append("  InvalidReason: ").Append(InvalidReason).Append("\n");
            sb.Append("  Locations: ").Append(Locations).Append("\n");
            sb.Append("  MerchantTicketNo: ").Append(MerchantTicketNo).Append("\n");
            sb.Append("  SeatInfos: ").Append(SeatInfos).Append("\n");
            sb.Append("  ServiceProvider: ").Append(ServiceProvider).Append("\n");
            sb.Append("  Shops: ").Append(Shops).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TicketCreateTime: ").Append(TicketCreateTime).Append("\n");
            sb.Append("  TicketModifyTime: ").Append(TicketModifyTime).Append("\n");
            sb.Append("  TicketNum: ").Append(TicketNum).Append("\n");
            sb.Append("  TicketUsers: ").Append(TicketUsers).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  VehicleInfo: ").Append(VehicleInfo).Append("\n");
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
            return this.Equals(input as TicketOrderInfo);
        }

        /// <summary>
        /// Returns true if TicketOrderInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of TicketOrderInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TicketOrderInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Arrival == input.Arrival ||
                    (this.Arrival != null &&
                    this.Arrival.Equals(input.Arrival))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.Departure == input.Departure ||
                    (this.Departure != null &&
                    this.Departure.Equals(input.Departure))
                ) && 
                (
                    this.EffectiveNum == input.EffectiveNum ||
                    this.EffectiveNum.Equals(input.EffectiveNum)
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.ExtInfo == input.ExtInfo ||
                    this.ExtInfo != null &&
                    input.ExtInfo != null &&
                    this.ExtInfo.SequenceEqual(input.ExtInfo)
                ) && 
                (
                    this.FaceValue == input.FaceValue ||
                    (this.FaceValue != null &&
                    this.FaceValue.Equals(input.FaceValue))
                ) && 
                (
                    this.FunctionalServices == input.FunctionalServices ||
                    this.FunctionalServices != null &&
                    input.FunctionalServices != null &&
                    this.FunctionalServices.SequenceEqual(input.FunctionalServices)
                ) && 
                (
                    this.InvalidReason == input.InvalidReason ||
                    (this.InvalidReason != null &&
                    this.InvalidReason.Equals(input.InvalidReason))
                ) && 
                (
                    this.Locations == input.Locations ||
                    this.Locations != null &&
                    input.Locations != null &&
                    this.Locations.SequenceEqual(input.Locations)
                ) && 
                (
                    this.MerchantTicketNo == input.MerchantTicketNo ||
                    (this.MerchantTicketNo != null &&
                    this.MerchantTicketNo.Equals(input.MerchantTicketNo))
                ) && 
                (
                    this.SeatInfos == input.SeatInfos ||
                    this.SeatInfos != null &&
                    input.SeatInfos != null &&
                    this.SeatInfos.SequenceEqual(input.SeatInfos)
                ) && 
                (
                    this.ServiceProvider == input.ServiceProvider ||
                    (this.ServiceProvider != null &&
                    this.ServiceProvider.Equals(input.ServiceProvider))
                ) && 
                (
                    this.Shops == input.Shops ||
                    this.Shops != null &&
                    input.Shops != null &&
                    this.Shops.SequenceEqual(input.Shops)
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.TicketCreateTime == input.TicketCreateTime ||
                    (this.TicketCreateTime != null &&
                    this.TicketCreateTime.Equals(input.TicketCreateTime))
                ) && 
                (
                    this.TicketModifyTime == input.TicketModifyTime ||
                    (this.TicketModifyTime != null &&
                    this.TicketModifyTime.Equals(input.TicketModifyTime))
                ) && 
                (
                    this.TicketNum == input.TicketNum ||
                    this.TicketNum.Equals(input.TicketNum)
                ) && 
                (
                    this.TicketUsers == input.TicketUsers ||
                    this.TicketUsers != null &&
                    input.TicketUsers != null &&
                    this.TicketUsers.SequenceEqual(input.TicketUsers)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.VehicleInfo == input.VehicleInfo ||
                    (this.VehicleInfo != null &&
                    this.VehicleInfo.Equals(input.VehicleInfo))
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
                if (this.Arrival != null)
                {
                    hashCode = (hashCode * 59) + this.Arrival.GetHashCode();
                }
                if (this.Content != null)
                {
                    hashCode = (hashCode * 59) + this.Content.GetHashCode();
                }
                if (this.Departure != null)
                {
                    hashCode = (hashCode * 59) + this.Departure.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EffectiveNum.GetHashCode();
                if (this.EndTime != null)
                {
                    hashCode = (hashCode * 59) + this.EndTime.GetHashCode();
                }
                if (this.ExtInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ExtInfo.GetHashCode();
                }
                if (this.FaceValue != null)
                {
                    hashCode = (hashCode * 59) + this.FaceValue.GetHashCode();
                }
                if (this.FunctionalServices != null)
                {
                    hashCode = (hashCode * 59) + this.FunctionalServices.GetHashCode();
                }
                if (this.InvalidReason != null)
                {
                    hashCode = (hashCode * 59) + this.InvalidReason.GetHashCode();
                }
                if (this.Locations != null)
                {
                    hashCode = (hashCode * 59) + this.Locations.GetHashCode();
                }
                if (this.MerchantTicketNo != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantTicketNo.GetHashCode();
                }
                if (this.SeatInfos != null)
                {
                    hashCode = (hashCode * 59) + this.SeatInfos.GetHashCode();
                }
                if (this.ServiceProvider != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceProvider.GetHashCode();
                }
                if (this.Shops != null)
                {
                    hashCode = (hashCode * 59) + this.Shops.GetHashCode();
                }
                if (this.StartTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartTime.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.TicketCreateTime != null)
                {
                    hashCode = (hashCode * 59) + this.TicketCreateTime.GetHashCode();
                }
                if (this.TicketModifyTime != null)
                {
                    hashCode = (hashCode * 59) + this.TicketModifyTime.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TicketNum.GetHashCode();
                if (this.TicketUsers != null)
                {
                    hashCode = (hashCode * 59) + this.TicketUsers.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.VehicleInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VehicleInfo.GetHashCode();
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
