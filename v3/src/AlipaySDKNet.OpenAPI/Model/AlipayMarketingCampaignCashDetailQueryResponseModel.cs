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
    /// AlipayMarketingCampaignCashDetailQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingCampaignCashDetailQueryResponseModel")]
    public partial class AlipayMarketingCampaignCashDetailQueryResponseModel : IEquatable<AlipayMarketingCampaignCashDetailQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingCampaignCashDetailQueryResponseModel" /> class.
        /// </summary>
        /// <param name="campStatus">活动状态，CREATED: 已创建未打款 PAID:已打款 READY:活动已开始 PAUSE:活动已暂停 CLOSED:活动已结束 SETTLED:活动已清算.</param>
        /// <param name="couponName">红包名称.</param>
        /// <param name="crowdNo">活动号.</param>
        /// <param name="endTime">活动结束时间.</param>
        /// <param name="originCrowdNo">原始活动号,商户排查问题时提供的活动依据.</param>
        /// <param name="prizeMsg">活动文案,用户在账单中看到的红包描述.</param>
        /// <param name="prizeType">现金红包的发放形式, fixed为固定金额,random为随机金额.</param>
        /// <param name="sendAmount">活动已发放金额.</param>
        /// <param name="startTime">活动开始时间.</param>
        /// <param name="totalAmount">活动总金额.</param>
        /// <param name="totalCount">红包总个数.</param>
        /// <param name="totalNum">红包总个数(废弃).</param>
        public AlipayMarketingCampaignCashDetailQueryResponseModel(string campStatus = default(string), string couponName = default(string), string crowdNo = default(string), string endTime = default(string), string originCrowdNo = default(string), string prizeMsg = default(string), string prizeType = default(string), string sendAmount = default(string), string startTime = default(string), string totalAmount = default(string), int totalCount = default(int), int totalNum = default(int))
        {
            this.CampStatus = campStatus;
            this.CouponName = couponName;
            this.CrowdNo = crowdNo;
            this.EndTime = endTime;
            this.OriginCrowdNo = originCrowdNo;
            this.PrizeMsg = prizeMsg;
            this.PrizeType = prizeType;
            this.SendAmount = sendAmount;
            this.StartTime = startTime;
            this.TotalAmount = totalAmount;
            this.TotalCount = totalCount;
            this.TotalNum = totalNum;
        }

        /// <summary>
        /// 活动状态，CREATED: 已创建未打款 PAID:已打款 READY:活动已开始 PAUSE:活动已暂停 CLOSED:活动已结束 SETTLED:活动已清算
        /// </summary>
        /// <value>活动状态，CREATED: 已创建未打款 PAID:已打款 READY:活动已开始 PAUSE:活动已暂停 CLOSED:活动已结束 SETTLED:活动已清算</value>
        [DataMember(Name = "camp_status", EmitDefaultValue = false)]
        public string CampStatus { get; set; }

        /// <summary>
        /// 红包名称
        /// </summary>
        /// <value>红包名称</value>
        [DataMember(Name = "coupon_name", EmitDefaultValue = false)]
        public string CouponName { get; set; }

        /// <summary>
        /// 活动号
        /// </summary>
        /// <value>活动号</value>
        [DataMember(Name = "crowd_no", EmitDefaultValue = false)]
        public string CrowdNo { get; set; }

        /// <summary>
        /// 活动结束时间
        /// </summary>
        /// <value>活动结束时间</value>
        [DataMember(Name = "end_time", EmitDefaultValue = false)]
        public string EndTime { get; set; }

        /// <summary>
        /// 原始活动号,商户排查问题时提供的活动依据
        /// </summary>
        /// <value>原始活动号,商户排查问题时提供的活动依据</value>
        [DataMember(Name = "origin_crowd_no", EmitDefaultValue = false)]
        public string OriginCrowdNo { get; set; }

        /// <summary>
        /// 活动文案,用户在账单中看到的红包描述
        /// </summary>
        /// <value>活动文案,用户在账单中看到的红包描述</value>
        [DataMember(Name = "prize_msg", EmitDefaultValue = false)]
        public string PrizeMsg { get; set; }

        /// <summary>
        /// 现金红包的发放形式, fixed为固定金额,random为随机金额
        /// </summary>
        /// <value>现金红包的发放形式, fixed为固定金额,random为随机金额</value>
        [DataMember(Name = "prize_type", EmitDefaultValue = false)]
        public string PrizeType { get; set; }

        /// <summary>
        /// 活动已发放金额
        /// </summary>
        /// <value>活动已发放金额</value>
        [DataMember(Name = "send_amount", EmitDefaultValue = false)]
        public string SendAmount { get; set; }

        /// <summary>
        /// 活动开始时间
        /// </summary>
        /// <value>活动开始时间</value>
        [DataMember(Name = "start_time", EmitDefaultValue = false)]
        public string StartTime { get; set; }

        /// <summary>
        /// 活动总金额
        /// </summary>
        /// <value>活动总金额</value>
        [DataMember(Name = "total_amount", EmitDefaultValue = false)]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 红包总个数
        /// </summary>
        /// <value>红包总个数</value>
        [DataMember(Name = "total_count", EmitDefaultValue = false)]
        public int TotalCount { get; set; }

        /// <summary>
        /// 红包总个数(废弃)
        /// </summary>
        /// <value>红包总个数(废弃)</value>
        [DataMember(Name = "total_num", EmitDefaultValue = false)]
        public int TotalNum { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingCampaignCashDetailQueryResponseModel {\n");
            sb.Append("  CampStatus: ").Append(CampStatus).Append("\n");
            sb.Append("  CouponName: ").Append(CouponName).Append("\n");
            sb.Append("  CrowdNo: ").Append(CrowdNo).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  OriginCrowdNo: ").Append(OriginCrowdNo).Append("\n");
            sb.Append("  PrizeMsg: ").Append(PrizeMsg).Append("\n");
            sb.Append("  PrizeType: ").Append(PrizeType).Append("\n");
            sb.Append("  SendAmount: ").Append(SendAmount).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  TotalNum: ").Append(TotalNum).Append("\n");
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
            return this.Equals(input as AlipayMarketingCampaignCashDetailQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingCampaignCashDetailQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingCampaignCashDetailQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingCampaignCashDetailQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CampStatus == input.CampStatus ||
                    (this.CampStatus != null &&
                    this.CampStatus.Equals(input.CampStatus))
                ) && 
                (
                    this.CouponName == input.CouponName ||
                    (this.CouponName != null &&
                    this.CouponName.Equals(input.CouponName))
                ) && 
                (
                    this.CrowdNo == input.CrowdNo ||
                    (this.CrowdNo != null &&
                    this.CrowdNo.Equals(input.CrowdNo))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.OriginCrowdNo == input.OriginCrowdNo ||
                    (this.OriginCrowdNo != null &&
                    this.OriginCrowdNo.Equals(input.OriginCrowdNo))
                ) && 
                (
                    this.PrizeMsg == input.PrizeMsg ||
                    (this.PrizeMsg != null &&
                    this.PrizeMsg.Equals(input.PrizeMsg))
                ) && 
                (
                    this.PrizeType == input.PrizeType ||
                    (this.PrizeType != null &&
                    this.PrizeType.Equals(input.PrizeType))
                ) && 
                (
                    this.SendAmount == input.SendAmount ||
                    (this.SendAmount != null &&
                    this.SendAmount.Equals(input.SendAmount))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.TotalAmount == input.TotalAmount ||
                    (this.TotalAmount != null &&
                    this.TotalAmount.Equals(input.TotalAmount))
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    this.TotalCount.Equals(input.TotalCount)
                ) && 
                (
                    this.TotalNum == input.TotalNum ||
                    this.TotalNum.Equals(input.TotalNum)
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
                if (this.CampStatus != null)
                {
                    hashCode = (hashCode * 59) + this.CampStatus.GetHashCode();
                }
                if (this.CouponName != null)
                {
                    hashCode = (hashCode * 59) + this.CouponName.GetHashCode();
                }
                if (this.CrowdNo != null)
                {
                    hashCode = (hashCode * 59) + this.CrowdNo.GetHashCode();
                }
                if (this.EndTime != null)
                {
                    hashCode = (hashCode * 59) + this.EndTime.GetHashCode();
                }
                if (this.OriginCrowdNo != null)
                {
                    hashCode = (hashCode * 59) + this.OriginCrowdNo.GetHashCode();
                }
                if (this.PrizeMsg != null)
                {
                    hashCode = (hashCode * 59) + this.PrizeMsg.GetHashCode();
                }
                if (this.PrizeType != null)
                {
                    hashCode = (hashCode * 59) + this.PrizeType.GetHashCode();
                }
                if (this.SendAmount != null)
                {
                    hashCode = (hashCode * 59) + this.SendAmount.GetHashCode();
                }
                if (this.StartTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartTime.GetHashCode();
                }
                if (this.TotalAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TotalAmount.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalCount.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalNum.GetHashCode();
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
