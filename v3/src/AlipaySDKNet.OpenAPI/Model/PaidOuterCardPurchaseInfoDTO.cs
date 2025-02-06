/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2025-02-06
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
    /// PaidOuterCardPurchaseInfoDTO
    /// </summary>
    [DataContract(Name = "PaidOuterCardPurchaseInfoDTO")]
    public partial class PaidOuterCardPurchaseInfoDTO : IEquatable<PaidOuterCardPurchaseInfoDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaidOuterCardPurchaseInfoDTO" /> class.
        /// </summary>
        /// <param name="actionDate">用户购买、升级、降级、续费的操作时间。格式为：yyyy-MM-dd hh:mm:ss.</param>
        /// <param name="alipayTradeNo">支付宝交易号，由api: alipay.trade.create 返回.</param>
        /// <param name="outTradeNo">商户订单号。与创建订单api：alipay.trade.create保持一致.</param>
        /// <param name="price">用户购买金额。当购买/升级/续费场景必填，单位元，精确到小数点后2位.</param>
        /// <param name="source">用户操作来源.</param>
        public PaidOuterCardPurchaseInfoDTO(string actionDate = default(string), string alipayTradeNo = default(string), string outTradeNo = default(string), string price = default(string), string source = default(string))
        {
            this.ActionDate = actionDate;
            this.AlipayTradeNo = alipayTradeNo;
            this.OutTradeNo = outTradeNo;
            this.Price = price;
            this.Source = source;
        }

        /// <summary>
        /// 用户购买、升级、降级、续费的操作时间。格式为：yyyy-MM-dd hh:mm:ss
        /// </summary>
        /// <value>用户购买、升级、降级、续费的操作时间。格式为：yyyy-MM-dd hh:mm:ss</value>
        [DataMember(Name = "action_date", EmitDefaultValue = false)]
        public string ActionDate { get; set; }

        /// <summary>
        /// 支付宝交易号，由api: alipay.trade.create 返回
        /// </summary>
        /// <value>支付宝交易号，由api: alipay.trade.create 返回</value>
        [DataMember(Name = "alipay_trade_no", EmitDefaultValue = false)]
        public string AlipayTradeNo { get; set; }

        /// <summary>
        /// 商户订单号。与创建订单api：alipay.trade.create保持一致
        /// </summary>
        /// <value>商户订单号。与创建订单api：alipay.trade.create保持一致</value>
        [DataMember(Name = "out_trade_no", EmitDefaultValue = false)]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 用户购买金额。当购买/升级/续费场景必填，单位元，精确到小数点后2位
        /// </summary>
        /// <value>用户购买金额。当购买/升级/续费场景必填，单位元，精确到小数点后2位</value>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public string Price { get; set; }

        /// <summary>
        /// 用户操作来源
        /// </summary>
        /// <value>用户操作来源</value>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public string Source { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaidOuterCardPurchaseInfoDTO {\n");
            sb.Append("  ActionDate: ").Append(ActionDate).Append("\n");
            sb.Append("  AlipayTradeNo: ").Append(AlipayTradeNo).Append("\n");
            sb.Append("  OutTradeNo: ").Append(OutTradeNo).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
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
            return this.Equals(input as PaidOuterCardPurchaseInfoDTO);
        }

        /// <summary>
        /// Returns true if PaidOuterCardPurchaseInfoDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of PaidOuterCardPurchaseInfoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaidOuterCardPurchaseInfoDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ActionDate == input.ActionDate ||
                    (this.ActionDate != null &&
                    this.ActionDate.Equals(input.ActionDate))
                ) && 
                (
                    this.AlipayTradeNo == input.AlipayTradeNo ||
                    (this.AlipayTradeNo != null &&
                    this.AlipayTradeNo.Equals(input.AlipayTradeNo))
                ) && 
                (
                    this.OutTradeNo == input.OutTradeNo ||
                    (this.OutTradeNo != null &&
                    this.OutTradeNo.Equals(input.OutTradeNo))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
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
                if (this.ActionDate != null)
                {
                    hashCode = (hashCode * 59) + this.ActionDate.GetHashCode();
                }
                if (this.AlipayTradeNo != null)
                {
                    hashCode = (hashCode * 59) + this.AlipayTradeNo.GetHashCode();
                }
                if (this.OutTradeNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutTradeNo.GetHashCode();
                }
                if (this.Price != null)
                {
                    hashCode = (hashCode * 59) + this.Price.GetHashCode();
                }
                if (this.Source != null)
                {
                    hashCode = (hashCode * 59) + this.Source.GetHashCode();
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
