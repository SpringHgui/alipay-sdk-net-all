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
    /// AlipayTradeOrderSettleResponseModel
    /// </summary>
    [DataContract(Name = "AlipayTradeOrderSettleResponseModel")]
    public partial class AlipayTradeOrderSettleResponseModel : IEquatable<AlipayTradeOrderSettleResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayTradeOrderSettleResponseModel" /> class.
        /// </summary>
        /// <param name="settleNo">支付宝分账单号，可以根据该单号查询单次分账请求执行结果.</param>
        /// <param name="tradeNo">支付宝交易号.</param>
        public AlipayTradeOrderSettleResponseModel(string settleNo = default(string), string tradeNo = default(string))
        {
            this.SettleNo = settleNo;
            this.TradeNo = tradeNo;
        }

        /// <summary>
        /// 支付宝分账单号，可以根据该单号查询单次分账请求执行结果
        /// </summary>
        /// <value>支付宝分账单号，可以根据该单号查询单次分账请求执行结果</value>
        [DataMember(Name = "settle_no", EmitDefaultValue = false)]
        public string SettleNo { get; set; }

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
            sb.Append("class AlipayTradeOrderSettleResponseModel {\n");
            sb.Append("  SettleNo: ").Append(SettleNo).Append("\n");
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
            return this.Equals(input as AlipayTradeOrderSettleResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayTradeOrderSettleResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayTradeOrderSettleResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayTradeOrderSettleResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SettleNo == input.SettleNo ||
                    (this.SettleNo != null &&
                    this.SettleNo.Equals(input.SettleNo))
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
                if (this.SettleNo != null)
                {
                    hashCode = (hashCode * 59) + this.SettleNo.GetHashCode();
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
