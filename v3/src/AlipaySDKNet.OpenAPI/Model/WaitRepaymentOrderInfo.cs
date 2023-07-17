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
    /// WaitRepaymentOrderInfo
    /// </summary>
    [DataContract(Name = "WaitRepaymentOrderInfo")]
    public partial class WaitRepaymentOrderInfo : IEquatable<WaitRepaymentOrderInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WaitRepaymentOrderInfo" /> class.
        /// </summary>
        /// <param name="advanceOrderId">垫资单id.</param>
        /// <param name="alipayUserId">买家的支付宝用户id.</param>
        /// <param name="bizProduct">通常为商户签约的收单产品码.</param>
        /// <param name="openId">买家的支付宝用户id.</param>
        /// <param name="origBizOrderId">原始的业务单号，通常为支付宝交易号.</param>
        /// <param name="waitRepaymentAmount">垫资金额.</param>
        public WaitRepaymentOrderInfo(string advanceOrderId = default(string), string alipayUserId = default(string), string bizProduct = default(string), string openId = default(string), string origBizOrderId = default(string), int waitRepaymentAmount = default(int))
        {
            this.AdvanceOrderId = advanceOrderId;
            this.AlipayUserId = alipayUserId;
            this.BizProduct = bizProduct;
            this.OpenId = openId;
            this.OrigBizOrderId = origBizOrderId;
            this.WaitRepaymentAmount = waitRepaymentAmount;
        }

        /// <summary>
        /// 垫资单id
        /// </summary>
        /// <value>垫资单id</value>
        [DataMember(Name = "advance_order_id", EmitDefaultValue = false)]
        public string AdvanceOrderId { get; set; }

        /// <summary>
        /// 买家的支付宝用户id
        /// </summary>
        /// <value>买家的支付宝用户id</value>
        [DataMember(Name = "alipay_user_id", EmitDefaultValue = false)]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 通常为商户签约的收单产品码
        /// </summary>
        /// <value>通常为商户签约的收单产品码</value>
        [DataMember(Name = "biz_product", EmitDefaultValue = false)]
        public string BizProduct { get; set; }

        /// <summary>
        /// 买家的支付宝用户id
        /// </summary>
        /// <value>买家的支付宝用户id</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 原始的业务单号，通常为支付宝交易号
        /// </summary>
        /// <value>原始的业务单号，通常为支付宝交易号</value>
        [DataMember(Name = "orig_biz_order_id", EmitDefaultValue = false)]
        public string OrigBizOrderId { get; set; }

        /// <summary>
        /// 垫资金额
        /// </summary>
        /// <value>垫资金额</value>
        [DataMember(Name = "wait_repayment_amount", EmitDefaultValue = false)]
        public int WaitRepaymentAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WaitRepaymentOrderInfo {\n");
            sb.Append("  AdvanceOrderId: ").Append(AdvanceOrderId).Append("\n");
            sb.Append("  AlipayUserId: ").Append(AlipayUserId).Append("\n");
            sb.Append("  BizProduct: ").Append(BizProduct).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  OrigBizOrderId: ").Append(OrigBizOrderId).Append("\n");
            sb.Append("  WaitRepaymentAmount: ").Append(WaitRepaymentAmount).Append("\n");
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
            return this.Equals(input as WaitRepaymentOrderInfo);
        }

        /// <summary>
        /// Returns true if WaitRepaymentOrderInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of WaitRepaymentOrderInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WaitRepaymentOrderInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AdvanceOrderId == input.AdvanceOrderId ||
                    (this.AdvanceOrderId != null &&
                    this.AdvanceOrderId.Equals(input.AdvanceOrderId))
                ) && 
                (
                    this.AlipayUserId == input.AlipayUserId ||
                    (this.AlipayUserId != null &&
                    this.AlipayUserId.Equals(input.AlipayUserId))
                ) && 
                (
                    this.BizProduct == input.BizProduct ||
                    (this.BizProduct != null &&
                    this.BizProduct.Equals(input.BizProduct))
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.OrigBizOrderId == input.OrigBizOrderId ||
                    (this.OrigBizOrderId != null &&
                    this.OrigBizOrderId.Equals(input.OrigBizOrderId))
                ) && 
                (
                    this.WaitRepaymentAmount == input.WaitRepaymentAmount ||
                    this.WaitRepaymentAmount.Equals(input.WaitRepaymentAmount)
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
                if (this.AdvanceOrderId != null)
                {
                    hashCode = (hashCode * 59) + this.AdvanceOrderId.GetHashCode();
                }
                if (this.AlipayUserId != null)
                {
                    hashCode = (hashCode * 59) + this.AlipayUserId.GetHashCode();
                }
                if (this.BizProduct != null)
                {
                    hashCode = (hashCode * 59) + this.BizProduct.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.OrigBizOrderId != null)
                {
                    hashCode = (hashCode * 59) + this.OrigBizOrderId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.WaitRepaymentAmount.GetHashCode();
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
