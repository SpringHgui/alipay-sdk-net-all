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
    /// TradeComplainQueryResponse
    /// </summary>
    [DataContract(Name = "TradeComplainQueryResponse")]
    public partial class TradeComplainQueryResponse : IEquatable<TradeComplainQueryResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradeComplainQueryResponse" /> class.
        /// </summary>
        /// <param name="complainEventId">支付宝侧投诉单号.</param>
        /// <param name="complainReason">投诉原因.</param>
        /// <param name="content">已经扣除了我的钱，为什么再次扣款？？？.</param>
        /// <param name="gmtCreate">投诉单创建时间.</param>
        /// <param name="gmtFinished">投诉单结束时间.</param>
        /// <param name="gmtModified">投诉单修改时间.</param>
        /// <param name="images">投诉图片.</param>
        /// <param name="leafCategoryName">投诉诉求.</param>
        /// <param name="merchantOrderNo">商家订单号.</param>
        /// <param name="phoneNo">投诉人电话号码.</param>
        /// <param name="status">状态 商家处理中：MERCHANT_PROCESSING 商家已反馈：MERCHANT_FEEDBACKED 投诉已完结：FINISHED 投诉已撤销：CANCELLED 平台处理中：PLATFORM_PROCESSING 平台处理完结：PLATFORM_FINISH 系统关闭：CLOSED.</param>
        /// <param name="targetId">应用id，例如小程序id、生活号id、商家pid.</param>
        /// <param name="targetType">应用类型 小程序为：APPID 生活号为：PUBLICID 商家为：PID.</param>
        /// <param name="tradeNo">支付宝交易号.</param>
        public TradeComplainQueryResponse(string complainEventId = default(string), string complainReason = default(string), string content = default(string), string gmtCreate = default(string), string gmtFinished = default(string), string gmtModified = default(string), List<string> images = default(List<string>), string leafCategoryName = default(string), string merchantOrderNo = default(string), string phoneNo = default(string), string status = default(string), string targetId = default(string), string targetType = default(string), string tradeNo = default(string))
        {
            this.ComplainEventId = complainEventId;
            this.ComplainReason = complainReason;
            this.Content = content;
            this.GmtCreate = gmtCreate;
            this.GmtFinished = gmtFinished;
            this.GmtModified = gmtModified;
            this.Images = images;
            this.LeafCategoryName = leafCategoryName;
            this.MerchantOrderNo = merchantOrderNo;
            this.PhoneNo = phoneNo;
            this.Status = status;
            this.TargetId = targetId;
            this.TargetType = targetType;
            this.TradeNo = tradeNo;
        }

        /// <summary>
        /// 支付宝侧投诉单号
        /// </summary>
        /// <value>支付宝侧投诉单号</value>
        [DataMember(Name = "complain_event_id", EmitDefaultValue = false)]
        public string ComplainEventId { get; set; }

        /// <summary>
        /// 投诉原因
        /// </summary>
        /// <value>投诉原因</value>
        [DataMember(Name = "complain_reason", EmitDefaultValue = false)]
        public string ComplainReason { get; set; }

        /// <summary>
        /// 已经扣除了我的钱，为什么再次扣款？？？
        /// </summary>
        /// <value>已经扣除了我的钱，为什么再次扣款？？？</value>
        [DataMember(Name = "content", EmitDefaultValue = false)]
        public string Content { get; set; }

        /// <summary>
        /// 投诉单创建时间
        /// </summary>
        /// <value>投诉单创建时间</value>
        [DataMember(Name = "gmt_create", EmitDefaultValue = false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 投诉单结束时间
        /// </summary>
        /// <value>投诉单结束时间</value>
        [DataMember(Name = "gmt_finished", EmitDefaultValue = false)]
        public string GmtFinished { get; set; }

        /// <summary>
        /// 投诉单修改时间
        /// </summary>
        /// <value>投诉单修改时间</value>
        [DataMember(Name = "gmt_modified", EmitDefaultValue = false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// 投诉图片
        /// </summary>
        /// <value>投诉图片</value>
        [DataMember(Name = "images", EmitDefaultValue = false)]
        public List<string> Images { get; set; }

        /// <summary>
        /// 投诉诉求
        /// </summary>
        /// <value>投诉诉求</value>
        [DataMember(Name = "leaf_category_name", EmitDefaultValue = false)]
        public string LeafCategoryName { get; set; }

        /// <summary>
        /// 商家订单号
        /// </summary>
        /// <value>商家订单号</value>
        [DataMember(Name = "merchant_order_no", EmitDefaultValue = false)]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 投诉人电话号码
        /// </summary>
        /// <value>投诉人电话号码</value>
        [DataMember(Name = "phone_no", EmitDefaultValue = false)]
        public string PhoneNo { get; set; }

        /// <summary>
        /// 状态 商家处理中：MERCHANT_PROCESSING 商家已反馈：MERCHANT_FEEDBACKED 投诉已完结：FINISHED 投诉已撤销：CANCELLED 平台处理中：PLATFORM_PROCESSING 平台处理完结：PLATFORM_FINISH 系统关闭：CLOSED
        /// </summary>
        /// <value>状态 商家处理中：MERCHANT_PROCESSING 商家已反馈：MERCHANT_FEEDBACKED 投诉已完结：FINISHED 投诉已撤销：CANCELLED 平台处理中：PLATFORM_PROCESSING 平台处理完结：PLATFORM_FINISH 系统关闭：CLOSED</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// 应用id，例如小程序id、生活号id、商家pid
        /// </summary>
        /// <value>应用id，例如小程序id、生活号id、商家pid</value>
        [DataMember(Name = "target_id", EmitDefaultValue = false)]
        public string TargetId { get; set; }

        /// <summary>
        /// 应用类型 小程序为：APPID 生活号为：PUBLICID 商家为：PID
        /// </summary>
        /// <value>应用类型 小程序为：APPID 生活号为：PUBLICID 商家为：PID</value>
        [DataMember(Name = "target_type", EmitDefaultValue = false)]
        public string TargetType { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        /// <value>支付宝交易号</value>
        [DataMember(Name = "trade_no", EmitDefaultValue = false)]
        public string TradeNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TradeComplainQueryResponse {\n");
            sb.Append("  ComplainEventId: ").Append(ComplainEventId).Append("\n");
            sb.Append("  ComplainReason: ").Append(ComplainReason).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  GmtCreate: ").Append(GmtCreate).Append("\n");
            sb.Append("  GmtFinished: ").Append(GmtFinished).Append("\n");
            sb.Append("  GmtModified: ").Append(GmtModified).Append("\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
            sb.Append("  LeafCategoryName: ").Append(LeafCategoryName).Append("\n");
            sb.Append("  MerchantOrderNo: ").Append(MerchantOrderNo).Append("\n");
            sb.Append("  PhoneNo: ").Append(PhoneNo).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TargetId: ").Append(TargetId).Append("\n");
            sb.Append("  TargetType: ").Append(TargetType).Append("\n");
            sb.Append("  TradeNo: ").Append(TradeNo).Append("\n");
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
            return this.Equals(input as TradeComplainQueryResponse);
        }

        /// <summary>
        /// Returns true if TradeComplainQueryResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TradeComplainQueryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TradeComplainQueryResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ComplainEventId == input.ComplainEventId ||
                    (this.ComplainEventId != null &&
                    this.ComplainEventId.Equals(input.ComplainEventId))
                ) && 
                (
                    this.ComplainReason == input.ComplainReason ||
                    (this.ComplainReason != null &&
                    this.ComplainReason.Equals(input.ComplainReason))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.GmtCreate == input.GmtCreate ||
                    (this.GmtCreate != null &&
                    this.GmtCreate.Equals(input.GmtCreate))
                ) && 
                (
                    this.GmtFinished == input.GmtFinished ||
                    (this.GmtFinished != null &&
                    this.GmtFinished.Equals(input.GmtFinished))
                ) && 
                (
                    this.GmtModified == input.GmtModified ||
                    (this.GmtModified != null &&
                    this.GmtModified.Equals(input.GmtModified))
                ) && 
                (
                    this.Images == input.Images ||
                    this.Images != null &&
                    input.Images != null &&
                    this.Images.SequenceEqual(input.Images)
                ) && 
                (
                    this.LeafCategoryName == input.LeafCategoryName ||
                    (this.LeafCategoryName != null &&
                    this.LeafCategoryName.Equals(input.LeafCategoryName))
                ) && 
                (
                    this.MerchantOrderNo == input.MerchantOrderNo ||
                    (this.MerchantOrderNo != null &&
                    this.MerchantOrderNo.Equals(input.MerchantOrderNo))
                ) && 
                (
                    this.PhoneNo == input.PhoneNo ||
                    (this.PhoneNo != null &&
                    this.PhoneNo.Equals(input.PhoneNo))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.TargetId == input.TargetId ||
                    (this.TargetId != null &&
                    this.TargetId.Equals(input.TargetId))
                ) && 
                (
                    this.TargetType == input.TargetType ||
                    (this.TargetType != null &&
                    this.TargetType.Equals(input.TargetType))
                ) && 
                (
                    this.TradeNo == input.TradeNo ||
                    (this.TradeNo != null &&
                    this.TradeNo.Equals(input.TradeNo))
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
                if (this.ComplainEventId != null)
                {
                    hashCode = (hashCode * 59) + this.ComplainEventId.GetHashCode();
                }
                if (this.ComplainReason != null)
                {
                    hashCode = (hashCode * 59) + this.ComplainReason.GetHashCode();
                }
                if (this.Content != null)
                {
                    hashCode = (hashCode * 59) + this.Content.GetHashCode();
                }
                if (this.GmtCreate != null)
                {
                    hashCode = (hashCode * 59) + this.GmtCreate.GetHashCode();
                }
                if (this.GmtFinished != null)
                {
                    hashCode = (hashCode * 59) + this.GmtFinished.GetHashCode();
                }
                if (this.GmtModified != null)
                {
                    hashCode = (hashCode * 59) + this.GmtModified.GetHashCode();
                }
                if (this.Images != null)
                {
                    hashCode = (hashCode * 59) + this.Images.GetHashCode();
                }
                if (this.LeafCategoryName != null)
                {
                    hashCode = (hashCode * 59) + this.LeafCategoryName.GetHashCode();
                }
                if (this.MerchantOrderNo != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantOrderNo.GetHashCode();
                }
                if (this.PhoneNo != null)
                {
                    hashCode = (hashCode * 59) + this.PhoneNo.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.TargetId != null)
                {
                    hashCode = (hashCode * 59) + this.TargetId.GetHashCode();
                }
                if (this.TargetType != null)
                {
                    hashCode = (hashCode * 59) + this.TargetType.GetHashCode();
                }
                if (this.TradeNo != null)
                {
                    hashCode = (hashCode * 59) + this.TradeNo.GetHashCode();
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
