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
    /// OrderJourneyElement
    /// </summary>
    [DataContract(Name = "OrderJourneyElement")]
    public partial class OrderJourneyElement : IEquatable<OrderJourneyElement>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderJourneyElement" /> class.
        /// </summary>
        /// <param name="arrival">arrival.</param>
        /// <param name="departure">departure.</param>
        /// <param name="duration">行程时长.</param>
        /// <param name="endTime">结束时间.</param>
        /// <param name="endTimeDesc">结束时间描述（非结构化）.</param>
        /// <param name="extInfo">扩展信息.</param>
        /// <param name="functionalServices">功能服务列表.</param>
        /// <param name="passagers">出行人.</param>
        /// <param name="serviceChangeInfo">serviceChangeInfo.</param>
        /// <param name="serviceProvider">serviceProvider.</param>
        /// <param name="startTime">开始时间.</param>
        /// <param name="startTimeDesc">开始时间描述（非结构化）.</param>
        public OrderJourneyElement(JourneyLocation arrival = default(JourneyLocation), JourneyLocation departure = default(JourneyLocation), string duration = default(string), string endTime = default(string), string endTimeDesc = default(string), List<OrderExtInfo> extInfo = default(List<OrderExtInfo>), List<FunctionalService> functionalServices = default(List<FunctionalService>), List<UserInfomation> passagers = default(List<UserInfomation>), JourneyServiceChangeInfo serviceChangeInfo = default(JourneyServiceChangeInfo), JourneyMerchantInfo serviceProvider = default(JourneyMerchantInfo), string startTime = default(string), string startTimeDesc = default(string))
        {
            this.Arrival = arrival;
            this.Departure = departure;
            this.Duration = duration;
            this.EndTime = endTime;
            this.EndTimeDesc = endTimeDesc;
            this.ExtInfo = extInfo;
            this.FunctionalServices = functionalServices;
            this.Passagers = passagers;
            this.ServiceChangeInfo = serviceChangeInfo;
            this.ServiceProvider = serviceProvider;
            this.StartTime = startTime;
            this.StartTimeDesc = startTimeDesc;
        }

        /// <summary>
        /// Gets or Sets Arrival
        /// </summary>
        [DataMember(Name = "arrival", EmitDefaultValue = false)]
        public JourneyLocation Arrival { get; set; }

        /// <summary>
        /// Gets or Sets Departure
        /// </summary>
        [DataMember(Name = "departure", EmitDefaultValue = false)]
        public JourneyLocation Departure { get; set; }

        /// <summary>
        /// 行程时长
        /// </summary>
        /// <value>行程时长</value>
        [DataMember(Name = "duration", EmitDefaultValue = false)]
        public string Duration { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        /// <value>结束时间</value>
        [DataMember(Name = "end_time", EmitDefaultValue = false)]
        public string EndTime { get; set; }

        /// <summary>
        /// 结束时间描述（非结构化）
        /// </summary>
        /// <value>结束时间描述（非结构化）</value>
        [DataMember(Name = "end_time_desc", EmitDefaultValue = false)]
        public string EndTimeDesc { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        /// <value>扩展信息</value>
        [DataMember(Name = "ext_info", EmitDefaultValue = false)]
        public List<OrderExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 功能服务列表
        /// </summary>
        /// <value>功能服务列表</value>
        [DataMember(Name = "functional_services", EmitDefaultValue = false)]
        public List<FunctionalService> FunctionalServices { get; set; }

        /// <summary>
        /// 出行人
        /// </summary>
        /// <value>出行人</value>
        [DataMember(Name = "passagers", EmitDefaultValue = false)]
        public List<UserInfomation> Passagers { get; set; }

        /// <summary>
        /// Gets or Sets ServiceChangeInfo
        /// </summary>
        [DataMember(Name = "service_change_info", EmitDefaultValue = false)]
        public JourneyServiceChangeInfo ServiceChangeInfo { get; set; }

        /// <summary>
        /// Gets or Sets ServiceProvider
        /// </summary>
        [DataMember(Name = "service_provider", EmitDefaultValue = false)]
        public JourneyMerchantInfo ServiceProvider { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        /// <value>开始时间</value>
        [DataMember(Name = "start_time", EmitDefaultValue = false)]
        public string StartTime { get; set; }

        /// <summary>
        /// 开始时间描述（非结构化）
        /// </summary>
        /// <value>开始时间描述（非结构化）</value>
        [DataMember(Name = "start_time_desc", EmitDefaultValue = false)]
        public string StartTimeDesc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderJourneyElement {\n");
            sb.Append("  Arrival: ").Append(Arrival).Append("\n");
            sb.Append("  Departure: ").Append(Departure).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  EndTimeDesc: ").Append(EndTimeDesc).Append("\n");
            sb.Append("  ExtInfo: ").Append(ExtInfo).Append("\n");
            sb.Append("  FunctionalServices: ").Append(FunctionalServices).Append("\n");
            sb.Append("  Passagers: ").Append(Passagers).Append("\n");
            sb.Append("  ServiceChangeInfo: ").Append(ServiceChangeInfo).Append("\n");
            sb.Append("  ServiceProvider: ").Append(ServiceProvider).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  StartTimeDesc: ").Append(StartTimeDesc).Append("\n");
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
            return this.Equals(input as OrderJourneyElement);
        }

        /// <summary>
        /// Returns true if OrderJourneyElement instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderJourneyElement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderJourneyElement input)
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
                    this.Departure == input.Departure ||
                    (this.Departure != null &&
                    this.Departure.Equals(input.Departure))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.EndTimeDesc == input.EndTimeDesc ||
                    (this.EndTimeDesc != null &&
                    this.EndTimeDesc.Equals(input.EndTimeDesc))
                ) && 
                (
                    this.ExtInfo == input.ExtInfo ||
                    this.ExtInfo != null &&
                    input.ExtInfo != null &&
                    this.ExtInfo.SequenceEqual(input.ExtInfo)
                ) && 
                (
                    this.FunctionalServices == input.FunctionalServices ||
                    this.FunctionalServices != null &&
                    input.FunctionalServices != null &&
                    this.FunctionalServices.SequenceEqual(input.FunctionalServices)
                ) && 
                (
                    this.Passagers == input.Passagers ||
                    this.Passagers != null &&
                    input.Passagers != null &&
                    this.Passagers.SequenceEqual(input.Passagers)
                ) && 
                (
                    this.ServiceChangeInfo == input.ServiceChangeInfo ||
                    (this.ServiceChangeInfo != null &&
                    this.ServiceChangeInfo.Equals(input.ServiceChangeInfo))
                ) && 
                (
                    this.ServiceProvider == input.ServiceProvider ||
                    (this.ServiceProvider != null &&
                    this.ServiceProvider.Equals(input.ServiceProvider))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.StartTimeDesc == input.StartTimeDesc ||
                    (this.StartTimeDesc != null &&
                    this.StartTimeDesc.Equals(input.StartTimeDesc))
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
                if (this.Departure != null)
                {
                    hashCode = (hashCode * 59) + this.Departure.GetHashCode();
                }
                if (this.Duration != null)
                {
                    hashCode = (hashCode * 59) + this.Duration.GetHashCode();
                }
                if (this.EndTime != null)
                {
                    hashCode = (hashCode * 59) + this.EndTime.GetHashCode();
                }
                if (this.EndTimeDesc != null)
                {
                    hashCode = (hashCode * 59) + this.EndTimeDesc.GetHashCode();
                }
                if (this.ExtInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ExtInfo.GetHashCode();
                }
                if (this.FunctionalServices != null)
                {
                    hashCode = (hashCode * 59) + this.FunctionalServices.GetHashCode();
                }
                if (this.Passagers != null)
                {
                    hashCode = (hashCode * 59) + this.Passagers.GetHashCode();
                }
                if (this.ServiceChangeInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceChangeInfo.GetHashCode();
                }
                if (this.ServiceProvider != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceProvider.GetHashCode();
                }
                if (this.StartTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartTime.GetHashCode();
                }
                if (this.StartTimeDesc != null)
                {
                    hashCode = (hashCode * 59) + this.StartTimeDesc.GetHashCode();
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
