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
    /// ZhimaCreditPayafteruseCreditbizorderFinishResponseModel
    /// </summary>
    [DataContract(Name = "ZhimaCreditPayafteruseCreditbizorderFinishResponseModel")]
    public partial class ZhimaCreditPayafteruseCreditbizorderFinishResponseModel : IEquatable<ZhimaCreditPayafteruseCreditbizorderFinishResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaCreditPayafteruseCreditbizorderFinishResponseModel" /> class.
        /// </summary>
        /// <param name="creditBizOrderId">信用服务订单号.</param>
        /// <param name="orderStatus">信用服务订单状态.INIT: 下单状态; TRADE_CLOSED: 订单取消或者交易全额退款； TRADE_FINISHED：扣款成功状态.</param>
        /// <param name="outRequestNo">商户外部请求号.</param>
        public ZhimaCreditPayafteruseCreditbizorderFinishResponseModel(string creditBizOrderId = default(string), string orderStatus = default(string), string outRequestNo = default(string))
        {
            this.CreditBizOrderId = creditBizOrderId;
            this.OrderStatus = orderStatus;
            this.OutRequestNo = outRequestNo;
        }

        /// <summary>
        /// 信用服务订单号
        /// </summary>
        /// <value>信用服务订单号</value>
        [DataMember(Name = "credit_biz_order_id", EmitDefaultValue = false)]
        public string CreditBizOrderId { get; set; }

        /// <summary>
        /// 信用服务订单状态.INIT: 下单状态; TRADE_CLOSED: 订单取消或者交易全额退款； TRADE_FINISHED：扣款成功状态
        /// </summary>
        /// <value>信用服务订单状态.INIT: 下单状态; TRADE_CLOSED: 订单取消或者交易全额退款； TRADE_FINISHED：扣款成功状态</value>
        [DataMember(Name = "order_status", EmitDefaultValue = false)]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 商户外部请求号
        /// </summary>
        /// <value>商户外部请求号</value>
        [DataMember(Name = "out_request_no", EmitDefaultValue = false)]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZhimaCreditPayafteruseCreditbizorderFinishResponseModel {\n");
            sb.Append("  CreditBizOrderId: ").Append(CreditBizOrderId).Append("\n");
            sb.Append("  OrderStatus: ").Append(OrderStatus).Append("\n");
            sb.Append("  OutRequestNo: ").Append(OutRequestNo).Append("\n");
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
            return this.Equals(input as ZhimaCreditPayafteruseCreditbizorderFinishResponseModel);
        }

        /// <summary>
        /// Returns true if ZhimaCreditPayafteruseCreditbizorderFinishResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ZhimaCreditPayafteruseCreditbizorderFinishResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZhimaCreditPayafteruseCreditbizorderFinishResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CreditBizOrderId == input.CreditBizOrderId ||
                    (this.CreditBizOrderId != null &&
                    this.CreditBizOrderId.Equals(input.CreditBizOrderId))
                ) && 
                (
                    this.OrderStatus == input.OrderStatus ||
                    (this.OrderStatus != null &&
                    this.OrderStatus.Equals(input.OrderStatus))
                ) && 
                (
                    this.OutRequestNo == input.OutRequestNo ||
                    (this.OutRequestNo != null &&
                    this.OutRequestNo.Equals(input.OutRequestNo))
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
                if (this.CreditBizOrderId != null)
                {
                    hashCode = (hashCode * 59) + this.CreditBizOrderId.GetHashCode();
                }
                if (this.OrderStatus != null)
                {
                    hashCode = (hashCode * 59) + this.OrderStatus.GetHashCode();
                }
                if (this.OutRequestNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutRequestNo.GetHashCode();
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
