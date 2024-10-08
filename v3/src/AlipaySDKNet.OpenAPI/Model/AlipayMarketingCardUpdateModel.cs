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
    /// AlipayMarketingCardUpdateModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingCardUpdateModel")]
    public partial class AlipayMarketingCardUpdateModel : IEquatable<AlipayMarketingCardUpdateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingCardUpdateModel" /> class.
        /// </summary>
        /// <param name="cardInfo">cardInfo.</param>
        /// <param name="extInfo">扩展信息(暂时无用).</param>
        /// <param name="mcardStyleInfo">mcardStyleInfo.</param>
        /// <param name="merchantCardMsgInfo">merchantCardMsgInfo.</param>
        /// <param name="notifyMessages">注意：此字段已废弃。 卡信息变更通知消息 1、在列表中定义的消息，才会发送给用户，消息格式一定。 2、根据卡信息变更情况，一次可发送多个消息.</param>
        /// <param name="occurTime">业务发生时间，时间格式为\&quot;yyyy-MM-dd HH:mm:ss\&quot;。.</param>
        /// <param name="paidOuterCardInfo">paidOuterCardInfo.</param>
        /// <param name="targetCardNo">支付宝业务卡号：1、3.0（历史版本）版本来源于alipay.marketing.card.open(会员卡开卡)接口开卡后获取的 card_info.biz_card_no 值；2、极速版来源于spi.alipay.user.opencard.get(会员卡开通，获取会员卡信息)请求参数中的biz_card_no值。.</param>
        /// <param name="targetCardNoType">卡号ID类型.</param>
        public AlipayMarketingCardUpdateModel(MerchantCard cardInfo = default(MerchantCard), string extInfo = default(string), McardStylInfo mcardStyleInfo = default(McardStylInfo), MerchantCardMsgInfo merchantCardMsgInfo = default(MerchantCardMsgInfo), List<McardNotifyMessage> notifyMessages = default(List<McardNotifyMessage>), string occurTime = default(string), PaidOuterCardExtraInfoDTO paidOuterCardInfo = default(PaidOuterCardExtraInfoDTO), string targetCardNo = default(string), string targetCardNoType = default(string))
        {
            this.CardInfo = cardInfo;
            this.ExtInfo = extInfo;
            this.McardStyleInfo = mcardStyleInfo;
            this.MerchantCardMsgInfo = merchantCardMsgInfo;
            this.NotifyMessages = notifyMessages;
            this.OccurTime = occurTime;
            this.PaidOuterCardInfo = paidOuterCardInfo;
            this.TargetCardNo = targetCardNo;
            this.TargetCardNoType = targetCardNoType;
        }

        /// <summary>
        /// Gets or Sets CardInfo
        /// </summary>
        [DataMember(Name = "card_info", EmitDefaultValue = false)]
        public MerchantCard CardInfo { get; set; }

        /// <summary>
        /// 扩展信息(暂时无用)
        /// </summary>
        /// <value>扩展信息(暂时无用)</value>
        [DataMember(Name = "ext_info", EmitDefaultValue = false)]
        public string ExtInfo { get; set; }

        /// <summary>
        /// Gets or Sets McardStyleInfo
        /// </summary>
        [DataMember(Name = "mcard_style_info", EmitDefaultValue = false)]
        public McardStylInfo McardStyleInfo { get; set; }

        /// <summary>
        /// Gets or Sets MerchantCardMsgInfo
        /// </summary>
        [DataMember(Name = "merchant_card_msg_info", EmitDefaultValue = false)]
        public MerchantCardMsgInfo MerchantCardMsgInfo { get; set; }

        /// <summary>
        /// 注意：此字段已废弃。 卡信息变更通知消息 1、在列表中定义的消息，才会发送给用户，消息格式一定。 2、根据卡信息变更情况，一次可发送多个消息
        /// </summary>
        /// <value>注意：此字段已废弃。 卡信息变更通知消息 1、在列表中定义的消息，才会发送给用户，消息格式一定。 2、根据卡信息变更情况，一次可发送多个消息</value>
        [DataMember(Name = "notify_messages", EmitDefaultValue = false)]
        public List<McardNotifyMessage> NotifyMessages { get; set; }

        /// <summary>
        /// 业务发生时间，时间格式为\&quot;yyyy-MM-dd HH:mm:ss\&quot;。
        /// </summary>
        /// <value>业务发生时间，时间格式为\&quot;yyyy-MM-dd HH:mm:ss\&quot;。</value>
        [DataMember(Name = "occur_time", EmitDefaultValue = false)]
        public string OccurTime { get; set; }

        /// <summary>
        /// Gets or Sets PaidOuterCardInfo
        /// </summary>
        [DataMember(Name = "paid_outer_card_info", EmitDefaultValue = false)]
        public PaidOuterCardExtraInfoDTO PaidOuterCardInfo { get; set; }

        /// <summary>
        /// 支付宝业务卡号：1、3.0（历史版本）版本来源于alipay.marketing.card.open(会员卡开卡)接口开卡后获取的 card_info.biz_card_no 值；2、极速版来源于spi.alipay.user.opencard.get(会员卡开通，获取会员卡信息)请求参数中的biz_card_no值。
        /// </summary>
        /// <value>支付宝业务卡号：1、3.0（历史版本）版本来源于alipay.marketing.card.open(会员卡开卡)接口开卡后获取的 card_info.biz_card_no 值；2、极速版来源于spi.alipay.user.opencard.get(会员卡开通，获取会员卡信息)请求参数中的biz_card_no值。</value>
        [DataMember(Name = "target_card_no", EmitDefaultValue = false)]
        public string TargetCardNo { get; set; }

        /// <summary>
        /// 卡号ID类型
        /// </summary>
        /// <value>卡号ID类型</value>
        [DataMember(Name = "target_card_no_type", EmitDefaultValue = false)]
        public string TargetCardNoType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingCardUpdateModel {\n");
            sb.Append("  CardInfo: ").Append(CardInfo).Append("\n");
            sb.Append("  ExtInfo: ").Append(ExtInfo).Append("\n");
            sb.Append("  McardStyleInfo: ").Append(McardStyleInfo).Append("\n");
            sb.Append("  MerchantCardMsgInfo: ").Append(MerchantCardMsgInfo).Append("\n");
            sb.Append("  NotifyMessages: ").Append(NotifyMessages).Append("\n");
            sb.Append("  OccurTime: ").Append(OccurTime).Append("\n");
            sb.Append("  PaidOuterCardInfo: ").Append(PaidOuterCardInfo).Append("\n");
            sb.Append("  TargetCardNo: ").Append(TargetCardNo).Append("\n");
            sb.Append("  TargetCardNoType: ").Append(TargetCardNoType).Append("\n");
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
            return this.Equals(input as AlipayMarketingCardUpdateModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingCardUpdateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingCardUpdateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingCardUpdateModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CardInfo == input.CardInfo ||
                    (this.CardInfo != null &&
                    this.CardInfo.Equals(input.CardInfo))
                ) && 
                (
                    this.ExtInfo == input.ExtInfo ||
                    (this.ExtInfo != null &&
                    this.ExtInfo.Equals(input.ExtInfo))
                ) && 
                (
                    this.McardStyleInfo == input.McardStyleInfo ||
                    (this.McardStyleInfo != null &&
                    this.McardStyleInfo.Equals(input.McardStyleInfo))
                ) && 
                (
                    this.MerchantCardMsgInfo == input.MerchantCardMsgInfo ||
                    (this.MerchantCardMsgInfo != null &&
                    this.MerchantCardMsgInfo.Equals(input.MerchantCardMsgInfo))
                ) && 
                (
                    this.NotifyMessages == input.NotifyMessages ||
                    this.NotifyMessages != null &&
                    input.NotifyMessages != null &&
                    this.NotifyMessages.SequenceEqual(input.NotifyMessages)
                ) && 
                (
                    this.OccurTime == input.OccurTime ||
                    (this.OccurTime != null &&
                    this.OccurTime.Equals(input.OccurTime))
                ) && 
                (
                    this.PaidOuterCardInfo == input.PaidOuterCardInfo ||
                    (this.PaidOuterCardInfo != null &&
                    this.PaidOuterCardInfo.Equals(input.PaidOuterCardInfo))
                ) && 
                (
                    this.TargetCardNo == input.TargetCardNo ||
                    (this.TargetCardNo != null &&
                    this.TargetCardNo.Equals(input.TargetCardNo))
                ) && 
                (
                    this.TargetCardNoType == input.TargetCardNoType ||
                    (this.TargetCardNoType != null &&
                    this.TargetCardNoType.Equals(input.TargetCardNoType))
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
                if (this.CardInfo != null)
                {
                    hashCode = (hashCode * 59) + this.CardInfo.GetHashCode();
                }
                if (this.ExtInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ExtInfo.GetHashCode();
                }
                if (this.McardStyleInfo != null)
                {
                    hashCode = (hashCode * 59) + this.McardStyleInfo.GetHashCode();
                }
                if (this.MerchantCardMsgInfo != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantCardMsgInfo.GetHashCode();
                }
                if (this.NotifyMessages != null)
                {
                    hashCode = (hashCode * 59) + this.NotifyMessages.GetHashCode();
                }
                if (this.OccurTime != null)
                {
                    hashCode = (hashCode * 59) + this.OccurTime.GetHashCode();
                }
                if (this.PaidOuterCardInfo != null)
                {
                    hashCode = (hashCode * 59) + this.PaidOuterCardInfo.GetHashCode();
                }
                if (this.TargetCardNo != null)
                {
                    hashCode = (hashCode * 59) + this.TargetCardNo.GetHashCode();
                }
                if (this.TargetCardNoType != null)
                {
                    hashCode = (hashCode * 59) + this.TargetCardNoType.GetHashCode();
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
