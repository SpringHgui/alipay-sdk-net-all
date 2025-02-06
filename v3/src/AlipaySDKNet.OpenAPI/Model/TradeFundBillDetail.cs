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
    /// TradeFundBillDetail
    /// </summary>
    [DataContract(Name = "TradeFundBillDetail")]
    public partial class TradeFundBillDetail : IEquatable<TradeFundBillDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TradeFundBillDetail" /> class.
        /// </summary>
        /// <param name="amount">交易金额.</param>
        /// <param name="assetTypeCode">资产类型编码.</param>
        /// <param name="assetUserId">资产的属主.</param>
        /// <param name="assetUserOpenId">资产的属主openid.</param>
        /// <param name="bizPayType">支付业务类型  PAY-支付  REFUND-退款.</param>
        /// <param name="createTime">创建时间.</param>
        /// <param name="paymentNo">支付单据号.</param>
        public TradeFundBillDetail(string amount = default(string), string assetTypeCode = default(string), string assetUserId = default(string), string assetUserOpenId = default(string), string bizPayType = default(string), string createTime = default(string), string paymentNo = default(string))
        {
            this.Amount = amount;
            this.AssetTypeCode = assetTypeCode;
            this.AssetUserId = assetUserId;
            this.AssetUserOpenId = assetUserOpenId;
            this.BizPayType = bizPayType;
            this.CreateTime = createTime;
            this.PaymentNo = paymentNo;
        }

        /// <summary>
        /// 交易金额
        /// </summary>
        /// <value>交易金额</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// 资产类型编码
        /// </summary>
        /// <value>资产类型编码</value>
        [DataMember(Name = "asset_type_code", EmitDefaultValue = false)]
        public string AssetTypeCode { get; set; }

        /// <summary>
        /// 资产的属主
        /// </summary>
        /// <value>资产的属主</value>
        [DataMember(Name = "asset_user_id", EmitDefaultValue = false)]
        public string AssetUserId { get; set; }

        /// <summary>
        /// 资产的属主openid
        /// </summary>
        /// <value>资产的属主openid</value>
        [DataMember(Name = "asset_user_open_id", EmitDefaultValue = false)]
        public string AssetUserOpenId { get; set; }

        /// <summary>
        /// 支付业务类型  PAY-支付  REFUND-退款
        /// </summary>
        /// <value>支付业务类型  PAY-支付  REFUND-退款</value>
        [DataMember(Name = "biz_pay_type", EmitDefaultValue = false)]
        public string BizPayType { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        /// <value>创建时间</value>
        [DataMember(Name = "create_time", EmitDefaultValue = false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 支付单据号
        /// </summary>
        /// <value>支付单据号</value>
        [DataMember(Name = "payment_no", EmitDefaultValue = false)]
        public string PaymentNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TradeFundBillDetail {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  AssetTypeCode: ").Append(AssetTypeCode).Append("\n");
            sb.Append("  AssetUserId: ").Append(AssetUserId).Append("\n");
            sb.Append("  AssetUserOpenId: ").Append(AssetUserOpenId).Append("\n");
            sb.Append("  BizPayType: ").Append(BizPayType).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  PaymentNo: ").Append(PaymentNo).Append("\n");
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
            return this.Equals(input as TradeFundBillDetail);
        }

        /// <summary>
        /// Returns true if TradeFundBillDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of TradeFundBillDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TradeFundBillDetail input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.AssetTypeCode == input.AssetTypeCode ||
                    (this.AssetTypeCode != null &&
                    this.AssetTypeCode.Equals(input.AssetTypeCode))
                ) && 
                (
                    this.AssetUserId == input.AssetUserId ||
                    (this.AssetUserId != null &&
                    this.AssetUserId.Equals(input.AssetUserId))
                ) && 
                (
                    this.AssetUserOpenId == input.AssetUserOpenId ||
                    (this.AssetUserOpenId != null &&
                    this.AssetUserOpenId.Equals(input.AssetUserOpenId))
                ) && 
                (
                    this.BizPayType == input.BizPayType ||
                    (this.BizPayType != null &&
                    this.BizPayType.Equals(input.BizPayType))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.PaymentNo == input.PaymentNo ||
                    (this.PaymentNo != null &&
                    this.PaymentNo.Equals(input.PaymentNo))
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
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.AssetTypeCode != null)
                {
                    hashCode = (hashCode * 59) + this.AssetTypeCode.GetHashCode();
                }
                if (this.AssetUserId != null)
                {
                    hashCode = (hashCode * 59) + this.AssetUserId.GetHashCode();
                }
                if (this.AssetUserOpenId != null)
                {
                    hashCode = (hashCode * 59) + this.AssetUserOpenId.GetHashCode();
                }
                if (this.BizPayType != null)
                {
                    hashCode = (hashCode * 59) + this.BizPayType.GetHashCode();
                }
                if (this.CreateTime != null)
                {
                    hashCode = (hashCode * 59) + this.CreateTime.GetHashCode();
                }
                if (this.PaymentNo != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentNo.GetHashCode();
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
