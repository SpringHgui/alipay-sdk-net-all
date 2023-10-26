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
    /// RefundRoyaltyResult
    /// </summary>
    [DataContract(Name = "RefundRoyaltyResult")]
    public partial class RefundRoyaltyResult : IEquatable<RefundRoyaltyResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundRoyaltyResult" /> class.
        /// </summary>
        /// <param name="refundAmount">退分账金额。单位：元。.</param>
        /// <param name="resultCode">退分账结果码.</param>
        /// <param name="royaltyType">分账类型. 字段为空默认为普通分账类型transfer.</param>
        /// <param name="transIn">转入人支付宝账号对应用户ID.</param>
        /// <param name="transInEmail">转入人支付宝账号.</param>
        /// <param name="transOut">转出人支付宝账号对应用户ID.</param>
        /// <param name="transOutEmail">转出人支付宝账号.</param>
        public RefundRoyaltyResult(string refundAmount = default(string), string resultCode = default(string), string royaltyType = default(string), string transIn = default(string), string transInEmail = default(string), string transOut = default(string), string transOutEmail = default(string))
        {
            this.RefundAmount = refundAmount;
            this.ResultCode = resultCode;
            this.RoyaltyType = royaltyType;
            this.TransIn = transIn;
            this.TransInEmail = transInEmail;
            this.TransOut = transOut;
            this.TransOutEmail = transOutEmail;
        }

        /// <summary>
        /// 退分账金额。单位：元。
        /// </summary>
        /// <value>退分账金额。单位：元。</value>
        [DataMember(Name = "refund_amount", EmitDefaultValue = false)]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 退分账结果码
        /// </summary>
        /// <value>退分账结果码</value>
        [DataMember(Name = "result_code", EmitDefaultValue = false)]
        public string ResultCode { get; set; }

        /// <summary>
        /// 分账类型. 字段为空默认为普通分账类型transfer
        /// </summary>
        /// <value>分账类型. 字段为空默认为普通分账类型transfer</value>
        [DataMember(Name = "royalty_type", EmitDefaultValue = false)]
        public string RoyaltyType { get; set; }

        /// <summary>
        /// 转入人支付宝账号对应用户ID
        /// </summary>
        /// <value>转入人支付宝账号对应用户ID</value>
        [DataMember(Name = "trans_in", EmitDefaultValue = false)]
        public string TransIn { get; set; }

        /// <summary>
        /// 转入人支付宝账号
        /// </summary>
        /// <value>转入人支付宝账号</value>
        [DataMember(Name = "trans_in_email", EmitDefaultValue = false)]
        public string TransInEmail { get; set; }

        /// <summary>
        /// 转出人支付宝账号对应用户ID
        /// </summary>
        /// <value>转出人支付宝账号对应用户ID</value>
        [DataMember(Name = "trans_out", EmitDefaultValue = false)]
        public string TransOut { get; set; }

        /// <summary>
        /// 转出人支付宝账号
        /// </summary>
        /// <value>转出人支付宝账号</value>
        [DataMember(Name = "trans_out_email", EmitDefaultValue = false)]
        public string TransOutEmail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RefundRoyaltyResult {\n");
            sb.Append("  RefundAmount: ").Append(RefundAmount).Append("\n");
            sb.Append("  ResultCode: ").Append(ResultCode).Append("\n");
            sb.Append("  RoyaltyType: ").Append(RoyaltyType).Append("\n");
            sb.Append("  TransIn: ").Append(TransIn).Append("\n");
            sb.Append("  TransInEmail: ").Append(TransInEmail).Append("\n");
            sb.Append("  TransOut: ").Append(TransOut).Append("\n");
            sb.Append("  TransOutEmail: ").Append(TransOutEmail).Append("\n");
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
            return this.Equals(input as RefundRoyaltyResult);
        }

        /// <summary>
        /// Returns true if RefundRoyaltyResult instances are equal
        /// </summary>
        /// <param name="input">Instance of RefundRoyaltyResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RefundRoyaltyResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RefundAmount == input.RefundAmount ||
                    (this.RefundAmount != null &&
                    this.RefundAmount.Equals(input.RefundAmount))
                ) && 
                (
                    this.ResultCode == input.ResultCode ||
                    (this.ResultCode != null &&
                    this.ResultCode.Equals(input.ResultCode))
                ) && 
                (
                    this.RoyaltyType == input.RoyaltyType ||
                    (this.RoyaltyType != null &&
                    this.RoyaltyType.Equals(input.RoyaltyType))
                ) && 
                (
                    this.TransIn == input.TransIn ||
                    (this.TransIn != null &&
                    this.TransIn.Equals(input.TransIn))
                ) && 
                (
                    this.TransInEmail == input.TransInEmail ||
                    (this.TransInEmail != null &&
                    this.TransInEmail.Equals(input.TransInEmail))
                ) && 
                (
                    this.TransOut == input.TransOut ||
                    (this.TransOut != null &&
                    this.TransOut.Equals(input.TransOut))
                ) && 
                (
                    this.TransOutEmail == input.TransOutEmail ||
                    (this.TransOutEmail != null &&
                    this.TransOutEmail.Equals(input.TransOutEmail))
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
                if (this.RefundAmount != null)
                {
                    hashCode = (hashCode * 59) + this.RefundAmount.GetHashCode();
                }
                if (this.ResultCode != null)
                {
                    hashCode = (hashCode * 59) + this.ResultCode.GetHashCode();
                }
                if (this.RoyaltyType != null)
                {
                    hashCode = (hashCode * 59) + this.RoyaltyType.GetHashCode();
                }
                if (this.TransIn != null)
                {
                    hashCode = (hashCode * 59) + this.TransIn.GetHashCode();
                }
                if (this.TransInEmail != null)
                {
                    hashCode = (hashCode * 59) + this.TransInEmail.GetHashCode();
                }
                if (this.TransOut != null)
                {
                    hashCode = (hashCode * 59) + this.TransOut.GetHashCode();
                }
                if (this.TransOutEmail != null)
                {
                    hashCode = (hashCode * 59) + this.TransOutEmail.GetHashCode();
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
