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
    /// ZhimaCreditPeZmgoSettleRefundModel
    /// </summary>
    [DataContract(Name = "ZhimaCreditPeZmgoSettleRefundModel")]
    public partial class ZhimaCreditPeZmgoSettleRefundModel : IEquatable<ZhimaCreditPeZmgoSettleRefundModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaCreditPeZmgoSettleRefundModel" /> class.
        /// </summary>
        /// <param name="agreementId">签约芝麻GO的业务协议号，在签约成功、结算成功等通知中回回传给商户。.</param>
        /// <param name="alipayOpenId">支付宝用户ID.</param>
        /// <param name="alipayUserId">支付宝用户ID.</param>
        /// <param name="memo">本次退款说明.</param>
        /// <param name="outRequestNo">外部请求号.</param>
        /// <param name="partnerId">商户ID.</param>
        /// <param name="refundAmount">退款金额，单位为：元（人民币），精确到小数点后两位.</param>
        /// <param name="refundType">退款类型： MEMBER_FEE_REFUND 会员费结算退款 ，WITHHOLD_FEE_REFUND 周期扣款金额退款。 不填写默认为 MEMBER_FEE_REFUND.</param>
        /// <param name="withholdPlanNo">芝麻侧扣款计划单据号，在结算扣款成功的通知消息中会回传。.</param>
        public ZhimaCreditPeZmgoSettleRefundModel(string agreementId = default(string), string alipayOpenId = default(string), string alipayUserId = default(string), string memo = default(string), string outRequestNo = default(string), string partnerId = default(string), string refundAmount = default(string), string refundType = default(string), string withholdPlanNo = default(string))
        {
            this.AgreementId = agreementId;
            this.AlipayOpenId = alipayOpenId;
            this.AlipayUserId = alipayUserId;
            this.Memo = memo;
            this.OutRequestNo = outRequestNo;
            this.PartnerId = partnerId;
            this.RefundAmount = refundAmount;
            this.RefundType = refundType;
            this.WithholdPlanNo = withholdPlanNo;
        }

        /// <summary>
        /// 签约芝麻GO的业务协议号，在签约成功、结算成功等通知中回回传给商户。
        /// </summary>
        /// <value>签约芝麻GO的业务协议号，在签约成功、结算成功等通知中回回传给商户。</value>
        [DataMember(Name = "agreement_id", EmitDefaultValue = false)]
        public string AgreementId { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        /// <value>支付宝用户ID</value>
        [DataMember(Name = "alipay_open_id", EmitDefaultValue = false)]
        public string AlipayOpenId { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        /// <value>支付宝用户ID</value>
        [DataMember(Name = "alipay_user_id", EmitDefaultValue = false)]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 本次退款说明
        /// </summary>
        /// <value>本次退款说明</value>
        [DataMember(Name = "memo", EmitDefaultValue = false)]
        public string Memo { get; set; }

        /// <summary>
        /// 外部请求号
        /// </summary>
        /// <value>外部请求号</value>
        [DataMember(Name = "out_request_no", EmitDefaultValue = false)]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        /// <value>商户ID</value>
        [DataMember(Name = "partner_id", EmitDefaultValue = false)]
        public string PartnerId { get; set; }

        /// <summary>
        /// 退款金额，单位为：元（人民币），精确到小数点后两位
        /// </summary>
        /// <value>退款金额，单位为：元（人民币），精确到小数点后两位</value>
        [DataMember(Name = "refund_amount", EmitDefaultValue = false)]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退款类型： MEMBER_FEE_REFUND 会员费结算退款 ，WITHHOLD_FEE_REFUND 周期扣款金额退款。 不填写默认为 MEMBER_FEE_REFUND
        /// </summary>
        /// <value>退款类型： MEMBER_FEE_REFUND 会员费结算退款 ，WITHHOLD_FEE_REFUND 周期扣款金额退款。 不填写默认为 MEMBER_FEE_REFUND</value>
        [DataMember(Name = "refund_type", EmitDefaultValue = false)]
        public string RefundType { get; set; }

        /// <summary>
        /// 芝麻侧扣款计划单据号，在结算扣款成功的通知消息中会回传。
        /// </summary>
        /// <value>芝麻侧扣款计划单据号，在结算扣款成功的通知消息中会回传。</value>
        [DataMember(Name = "withhold_plan_no", EmitDefaultValue = false)]
        public string WithholdPlanNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZhimaCreditPeZmgoSettleRefundModel {\n");
            sb.Append("  AgreementId: ").Append(AgreementId).Append("\n");
            sb.Append("  AlipayOpenId: ").Append(AlipayOpenId).Append("\n");
            sb.Append("  AlipayUserId: ").Append(AlipayUserId).Append("\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
            sb.Append("  OutRequestNo: ").Append(OutRequestNo).Append("\n");
            sb.Append("  PartnerId: ").Append(PartnerId).Append("\n");
            sb.Append("  RefundAmount: ").Append(RefundAmount).Append("\n");
            sb.Append("  RefundType: ").Append(RefundType).Append("\n");
            sb.Append("  WithholdPlanNo: ").Append(WithholdPlanNo).Append("\n");
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
            return this.Equals(input as ZhimaCreditPeZmgoSettleRefundModel);
        }

        /// <summary>
        /// Returns true if ZhimaCreditPeZmgoSettleRefundModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ZhimaCreditPeZmgoSettleRefundModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZhimaCreditPeZmgoSettleRefundModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AgreementId == input.AgreementId ||
                    (this.AgreementId != null &&
                    this.AgreementId.Equals(input.AgreementId))
                ) && 
                (
                    this.AlipayOpenId == input.AlipayOpenId ||
                    (this.AlipayOpenId != null &&
                    this.AlipayOpenId.Equals(input.AlipayOpenId))
                ) && 
                (
                    this.AlipayUserId == input.AlipayUserId ||
                    (this.AlipayUserId != null &&
                    this.AlipayUserId.Equals(input.AlipayUserId))
                ) && 
                (
                    this.Memo == input.Memo ||
                    (this.Memo != null &&
                    this.Memo.Equals(input.Memo))
                ) && 
                (
                    this.OutRequestNo == input.OutRequestNo ||
                    (this.OutRequestNo != null &&
                    this.OutRequestNo.Equals(input.OutRequestNo))
                ) && 
                (
                    this.PartnerId == input.PartnerId ||
                    (this.PartnerId != null &&
                    this.PartnerId.Equals(input.PartnerId))
                ) && 
                (
                    this.RefundAmount == input.RefundAmount ||
                    (this.RefundAmount != null &&
                    this.RefundAmount.Equals(input.RefundAmount))
                ) && 
                (
                    this.RefundType == input.RefundType ||
                    (this.RefundType != null &&
                    this.RefundType.Equals(input.RefundType))
                ) && 
                (
                    this.WithholdPlanNo == input.WithholdPlanNo ||
                    (this.WithholdPlanNo != null &&
                    this.WithholdPlanNo.Equals(input.WithholdPlanNo))
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
                if (this.AgreementId != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementId.GetHashCode();
                }
                if (this.AlipayOpenId != null)
                {
                    hashCode = (hashCode * 59) + this.AlipayOpenId.GetHashCode();
                }
                if (this.AlipayUserId != null)
                {
                    hashCode = (hashCode * 59) + this.AlipayUserId.GetHashCode();
                }
                if (this.Memo != null)
                {
                    hashCode = (hashCode * 59) + this.Memo.GetHashCode();
                }
                if (this.OutRequestNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutRequestNo.GetHashCode();
                }
                if (this.PartnerId != null)
                {
                    hashCode = (hashCode * 59) + this.PartnerId.GetHashCode();
                }
                if (this.RefundAmount != null)
                {
                    hashCode = (hashCode * 59) + this.RefundAmount.GetHashCode();
                }
                if (this.RefundType != null)
                {
                    hashCode = (hashCode * 59) + this.RefundType.GetHashCode();
                }
                if (this.WithholdPlanNo != null)
                {
                    hashCode = (hashCode * 59) + this.WithholdPlanNo.GetHashCode();
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
