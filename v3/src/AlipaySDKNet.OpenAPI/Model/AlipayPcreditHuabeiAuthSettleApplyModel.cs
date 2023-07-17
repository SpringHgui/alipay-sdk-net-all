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
    /// AlipayPcreditHuabeiAuthSettleApplyModel
    /// </summary>
    [DataContract(Name = "AlipayPcreditHuabeiAuthSettleApplyModel")]
    public partial class AlipayPcreditHuabeiAuthSettleApplyModel : IEquatable<AlipayPcreditHuabeiAuthSettleApplyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayPcreditHuabeiAuthSettleApplyModel" /> class.
        /// </summary>
        /// <param name="actionType">操作类型，默认为 MERCHANT_SETTLE（结算）。枚举值如下： *  MERCHANT_SETTLE：结算（需要主动退出在发起结算）; *  QUIT_SETTLE：退出协议（解约协议）; *  PERIOD_SETTLE：分阶段结算（不解约协议）。.</param>
        /// <param name="agreementNo">支付宝系统中用以唯一标识用户签约记录的编号。.</param>
        /// <param name="alipayUserId">用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。.</param>
        /// <param name="extendParams">extendParams.</param>
        /// <param name="needTerminated">是否解约，该参数控制结算完成之后的操作，为空则表示结算后解约。枚举值如下： *  true：代表解约，默认为true。 *  false：代表不解约。.</param>
        /// <param name="openId">用户在支付宝的唯一标识.</param>
        /// <param name="outRequestNo">商户本次操作的请求流水号，用于标示请求流水的唯一性，不能包含除中文、英文、数字以外的字符，需要保证在商户端不重复。.</param>
        /// <param name="payAmount">需要支付的金额，单位为：元（人民币），精确到小数点后两位.</param>
        /// <param name="sellerId">支付宝商家ID，即商家账号在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 说明：若该值为空，则默认为商户签约账号对应的支付宝用户ID。.</param>
        public AlipayPcreditHuabeiAuthSettleApplyModel(string actionType = default(string), string agreementNo = default(string), string alipayUserId = default(string), ExtraParams extendParams = default(ExtraParams), string needTerminated = default(string), string openId = default(string), string outRequestNo = default(string), string payAmount = default(string), string sellerId = default(string))
        {
            this.ActionType = actionType;
            this.AgreementNo = agreementNo;
            this.AlipayUserId = alipayUserId;
            this.ExtendParams = extendParams;
            this.NeedTerminated = needTerminated;
            this.OpenId = openId;
            this.OutRequestNo = outRequestNo;
            this.PayAmount = payAmount;
            this.SellerId = sellerId;
        }

        /// <summary>
        /// 操作类型，默认为 MERCHANT_SETTLE（结算）。枚举值如下： *  MERCHANT_SETTLE：结算（需要主动退出在发起结算）; *  QUIT_SETTLE：退出协议（解约协议）; *  PERIOD_SETTLE：分阶段结算（不解约协议）。
        /// </summary>
        /// <value>操作类型，默认为 MERCHANT_SETTLE（结算）。枚举值如下： *  MERCHANT_SETTLE：结算（需要主动退出在发起结算）; *  QUIT_SETTLE：退出协议（解约协议）; *  PERIOD_SETTLE：分阶段结算（不解约协议）。</value>
        [DataMember(Name = "action_type", EmitDefaultValue = false)]
        public string ActionType { get; set; }

        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号。
        /// </summary>
        /// <value>支付宝系统中用以唯一标识用户签约记录的编号。</value>
        [DataMember(Name = "agreement_no", EmitDefaultValue = false)]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。
        /// </summary>
        /// <value>用户在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。</value>
        [DataMember(Name = "alipay_user_id", EmitDefaultValue = false)]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// Gets or Sets ExtendParams
        /// </summary>
        [DataMember(Name = "extend_params", EmitDefaultValue = false)]
        public ExtraParams ExtendParams { get; set; }

        /// <summary>
        /// 是否解约，该参数控制结算完成之后的操作，为空则表示结算后解约。枚举值如下： *  true：代表解约，默认为true。 *  false：代表不解约。
        /// </summary>
        /// <value>是否解约，该参数控制结算完成之后的操作，为空则表示结算后解约。枚举值如下： *  true：代表解约，默认为true。 *  false：代表不解约。</value>
        [DataMember(Name = "need_terminated", EmitDefaultValue = false)]
        public string NeedTerminated { get; set; }

        /// <summary>
        /// 用户在支付宝的唯一标识
        /// </summary>
        /// <value>用户在支付宝的唯一标识</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户本次操作的请求流水号，用于标示请求流水的唯一性，不能包含除中文、英文、数字以外的字符，需要保证在商户端不重复。
        /// </summary>
        /// <value>商户本次操作的请求流水号，用于标示请求流水的唯一性，不能包含除中文、英文、数字以外的字符，需要保证在商户端不重复。</value>
        [DataMember(Name = "out_request_no", EmitDefaultValue = false)]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 需要支付的金额，单位为：元（人民币），精确到小数点后两位
        /// </summary>
        /// <value>需要支付的金额，单位为：元（人民币），精确到小数点后两位</value>
        [DataMember(Name = "pay_amount", EmitDefaultValue = false)]
        public string PayAmount { get; set; }

        /// <summary>
        /// 支付宝商家ID，即商家账号在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 说明：若该值为空，则默认为商户签约账号对应的支付宝用户ID。
        /// </summary>
        /// <value>支付宝商家ID，即商家账号在支付宝的唯一标识，以 2088 开头的 16 位纯数字组成。 说明：若该值为空，则默认为商户签约账号对应的支付宝用户ID。</value>
        [DataMember(Name = "seller_id", EmitDefaultValue = false)]
        public string SellerId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayPcreditHuabeiAuthSettleApplyModel {\n");
            sb.Append("  ActionType: ").Append(ActionType).Append("\n");
            sb.Append("  AgreementNo: ").Append(AgreementNo).Append("\n");
            sb.Append("  AlipayUserId: ").Append(AlipayUserId).Append("\n");
            sb.Append("  ExtendParams: ").Append(ExtendParams).Append("\n");
            sb.Append("  NeedTerminated: ").Append(NeedTerminated).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  OutRequestNo: ").Append(OutRequestNo).Append("\n");
            sb.Append("  PayAmount: ").Append(PayAmount).Append("\n");
            sb.Append("  SellerId: ").Append(SellerId).Append("\n");
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
            return this.Equals(input as AlipayPcreditHuabeiAuthSettleApplyModel);
        }

        /// <summary>
        /// Returns true if AlipayPcreditHuabeiAuthSettleApplyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayPcreditHuabeiAuthSettleApplyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayPcreditHuabeiAuthSettleApplyModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ActionType == input.ActionType ||
                    (this.ActionType != null &&
                    this.ActionType.Equals(input.ActionType))
                ) && 
                (
                    this.AgreementNo == input.AgreementNo ||
                    (this.AgreementNo != null &&
                    this.AgreementNo.Equals(input.AgreementNo))
                ) && 
                (
                    this.AlipayUserId == input.AlipayUserId ||
                    (this.AlipayUserId != null &&
                    this.AlipayUserId.Equals(input.AlipayUserId))
                ) && 
                (
                    this.ExtendParams == input.ExtendParams ||
                    (this.ExtendParams != null &&
                    this.ExtendParams.Equals(input.ExtendParams))
                ) && 
                (
                    this.NeedTerminated == input.NeedTerminated ||
                    (this.NeedTerminated != null &&
                    this.NeedTerminated.Equals(input.NeedTerminated))
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.OutRequestNo == input.OutRequestNo ||
                    (this.OutRequestNo != null &&
                    this.OutRequestNo.Equals(input.OutRequestNo))
                ) && 
                (
                    this.PayAmount == input.PayAmount ||
                    (this.PayAmount != null &&
                    this.PayAmount.Equals(input.PayAmount))
                ) && 
                (
                    this.SellerId == input.SellerId ||
                    (this.SellerId != null &&
                    this.SellerId.Equals(input.SellerId))
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
                if (this.ActionType != null)
                {
                    hashCode = (hashCode * 59) + this.ActionType.GetHashCode();
                }
                if (this.AgreementNo != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementNo.GetHashCode();
                }
                if (this.AlipayUserId != null)
                {
                    hashCode = (hashCode * 59) + this.AlipayUserId.GetHashCode();
                }
                if (this.ExtendParams != null)
                {
                    hashCode = (hashCode * 59) + this.ExtendParams.GetHashCode();
                }
                if (this.NeedTerminated != null)
                {
                    hashCode = (hashCode * 59) + this.NeedTerminated.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.OutRequestNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutRequestNo.GetHashCode();
                }
                if (this.PayAmount != null)
                {
                    hashCode = (hashCode * 59) + this.PayAmount.GetHashCode();
                }
                if (this.SellerId != null)
                {
                    hashCode = (hashCode * 59) + this.SellerId.GetHashCode();
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
