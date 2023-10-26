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
    /// AlipayFundTransRefundModel
    /// </summary>
    [DataContract(Name = "AlipayFundTransRefundModel")]
    public partial class AlipayFundTransRefundModel : IEquatable<AlipayFundTransRefundModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundTransRefundModel" /> class.
        /// </summary>
        /// <param name="businessParams">JSON格式，传递业务扩展参数，使用前请与支付宝工程师联系！.</param>
        /// <param name="orderId">发红包时支付宝返回的支付宝订单号order_id。.</param>
        /// <param name="outRequestNo">标识一次资金退回请求，一笔资金退回失败后重新提交，要采用原来的资金退回单号。总退款金额不能超过用户实际支付金额。.</param>
        /// <param name="passbackParams">公用回传参数，如果请求时传递了该参数，则异步通知商户时会回传该参数。.</param>
        /// <param name="refundAmount">需要退款的金额，该金额不能大于订单金额,单位为元，支持两位小数.</param>
        /// <param name="remark">资金退回备注.</param>
        public AlipayFundTransRefundModel(string businessParams = default(string), string orderId = default(string), string outRequestNo = default(string), string passbackParams = default(string), string refundAmount = default(string), string remark = default(string))
        {
            this.BusinessParams = businessParams;
            this.OrderId = orderId;
            this.OutRequestNo = outRequestNo;
            this.PassbackParams = passbackParams;
            this.RefundAmount = refundAmount;
            this.Remark = remark;
        }

        /// <summary>
        /// JSON格式，传递业务扩展参数，使用前请与支付宝工程师联系！
        /// </summary>
        /// <value>JSON格式，传递业务扩展参数，使用前请与支付宝工程师联系！</value>
        [DataMember(Name = "business_params", EmitDefaultValue = false)]
        public string BusinessParams { get; set; }

        /// <summary>
        /// 发红包时支付宝返回的支付宝订单号order_id。
        /// </summary>
        /// <value>发红包时支付宝返回的支付宝订单号order_id。</value>
        [DataMember(Name = "order_id", EmitDefaultValue = false)]
        public string OrderId { get; set; }

        /// <summary>
        /// 标识一次资金退回请求，一笔资金退回失败后重新提交，要采用原来的资金退回单号。总退款金额不能超过用户实际支付金额。
        /// </summary>
        /// <value>标识一次资金退回请求，一笔资金退回失败后重新提交，要采用原来的资金退回单号。总退款金额不能超过用户实际支付金额。</value>
        [DataMember(Name = "out_request_no", EmitDefaultValue = false)]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 公用回传参数，如果请求时传递了该参数，则异步通知商户时会回传该参数。
        /// </summary>
        /// <value>公用回传参数，如果请求时传递了该参数，则异步通知商户时会回传该参数。</value>
        [DataMember(Name = "passback_params", EmitDefaultValue = false)]
        public string PassbackParams { get; set; }

        /// <summary>
        /// 需要退款的金额，该金额不能大于订单金额,单位为元，支持两位小数
        /// </summary>
        /// <value>需要退款的金额，该金额不能大于订单金额,单位为元，支持两位小数</value>
        [DataMember(Name = "refund_amount", EmitDefaultValue = false)]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 资金退回备注
        /// </summary>
        /// <value>资金退回备注</value>
        [DataMember(Name = "remark", EmitDefaultValue = false)]
        public string Remark { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayFundTransRefundModel {\n");
            sb.Append("  BusinessParams: ").Append(BusinessParams).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  OutRequestNo: ").Append(OutRequestNo).Append("\n");
            sb.Append("  PassbackParams: ").Append(PassbackParams).Append("\n");
            sb.Append("  RefundAmount: ").Append(RefundAmount).Append("\n");
            sb.Append("  Remark: ").Append(Remark).Append("\n");
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
            return this.Equals(input as AlipayFundTransRefundModel);
        }

        /// <summary>
        /// Returns true if AlipayFundTransRefundModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayFundTransRefundModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayFundTransRefundModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BusinessParams == input.BusinessParams ||
                    (this.BusinessParams != null &&
                    this.BusinessParams.Equals(input.BusinessParams))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.OutRequestNo == input.OutRequestNo ||
                    (this.OutRequestNo != null &&
                    this.OutRequestNo.Equals(input.OutRequestNo))
                ) && 
                (
                    this.PassbackParams == input.PassbackParams ||
                    (this.PassbackParams != null &&
                    this.PassbackParams.Equals(input.PassbackParams))
                ) && 
                (
                    this.RefundAmount == input.RefundAmount ||
                    (this.RefundAmount != null &&
                    this.RefundAmount.Equals(input.RefundAmount))
                ) && 
                (
                    this.Remark == input.Remark ||
                    (this.Remark != null &&
                    this.Remark.Equals(input.Remark))
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
                if (this.BusinessParams != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessParams.GetHashCode();
                }
                if (this.OrderId != null)
                {
                    hashCode = (hashCode * 59) + this.OrderId.GetHashCode();
                }
                if (this.OutRequestNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutRequestNo.GetHashCode();
                }
                if (this.PassbackParams != null)
                {
                    hashCode = (hashCode * 59) + this.PassbackParams.GetHashCode();
                }
                if (this.RefundAmount != null)
                {
                    hashCode = (hashCode * 59) + this.RefundAmount.GetHashCode();
                }
                if (this.Remark != null)
                {
                    hashCode = (hashCode * 59) + this.Remark.GetHashCode();
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
