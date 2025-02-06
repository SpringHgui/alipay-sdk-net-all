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
    /// AlipayCommerceLogisticsOrderInstantdeliveryCancelModel
    /// </summary>
    [DataContract(Name = "AlipayCommerceLogisticsOrderInstantdeliveryCancelModel")]
    public partial class AlipayCommerceLogisticsOrderInstantdeliveryCancelModel : IEquatable<AlipayCommerceLogisticsOrderInstantdeliveryCancelModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceLogisticsOrderInstantdeliveryCancelModel" /> class.
        /// </summary>
        /// <param name="cancelReason">取消原因，取消原因id为i_6时必填.</param>
        /// <param name="cancelReasonId">取消原因id.</param>
        /// <param name="logisticsCode">即时配送公司编码.</param>
        /// <param name="orderNo">支付宝订单流水号.</param>
        /// <param name="outOrderNo">商家订单号，与order_no不能同时为空.</param>
        /// <param name="waybillNo">即时配送运单编号.</param>
        public AlipayCommerceLogisticsOrderInstantdeliveryCancelModel(string cancelReason = default(string), string cancelReasonId = default(string), string logisticsCode = default(string), string orderNo = default(string), string outOrderNo = default(string), string waybillNo = default(string))
        {
            this.CancelReason = cancelReason;
            this.CancelReasonId = cancelReasonId;
            this.LogisticsCode = logisticsCode;
            this.OrderNo = orderNo;
            this.OutOrderNo = outOrderNo;
            this.WaybillNo = waybillNo;
        }

        /// <summary>
        /// 取消原因，取消原因id为i_6时必填
        /// </summary>
        /// <value>取消原因，取消原因id为i_6时必填</value>
        [DataMember(Name = "cancel_reason", EmitDefaultValue = false)]
        public string CancelReason { get; set; }

        /// <summary>
        /// 取消原因id
        /// </summary>
        /// <value>取消原因id</value>
        [DataMember(Name = "cancel_reason_id", EmitDefaultValue = false)]
        public string CancelReasonId { get; set; }

        /// <summary>
        /// 即时配送公司编码
        /// </summary>
        /// <value>即时配送公司编码</value>
        [DataMember(Name = "logistics_code", EmitDefaultValue = false)]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 支付宝订单流水号
        /// </summary>
        /// <value>支付宝订单流水号</value>
        [DataMember(Name = "order_no", EmitDefaultValue = false)]
        public string OrderNo { get; set; }

        /// <summary>
        /// 商家订单号，与order_no不能同时为空
        /// </summary>
        /// <value>商家订单号，与order_no不能同时为空</value>
        [DataMember(Name = "out_order_no", EmitDefaultValue = false)]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 即时配送运单编号
        /// </summary>
        /// <value>即时配送运单编号</value>
        [DataMember(Name = "waybill_no", EmitDefaultValue = false)]
        public string WaybillNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayCommerceLogisticsOrderInstantdeliveryCancelModel {\n");
            sb.Append("  CancelReason: ").Append(CancelReason).Append("\n");
            sb.Append("  CancelReasonId: ").Append(CancelReasonId).Append("\n");
            sb.Append("  LogisticsCode: ").Append(LogisticsCode).Append("\n");
            sb.Append("  OrderNo: ").Append(OrderNo).Append("\n");
            sb.Append("  OutOrderNo: ").Append(OutOrderNo).Append("\n");
            sb.Append("  WaybillNo: ").Append(WaybillNo).Append("\n");
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
            return this.Equals(input as AlipayCommerceLogisticsOrderInstantdeliveryCancelModel);
        }

        /// <summary>
        /// Returns true if AlipayCommerceLogisticsOrderInstantdeliveryCancelModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayCommerceLogisticsOrderInstantdeliveryCancelModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayCommerceLogisticsOrderInstantdeliveryCancelModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CancelReason == input.CancelReason ||
                    (this.CancelReason != null &&
                    this.CancelReason.Equals(input.CancelReason))
                ) && 
                (
                    this.CancelReasonId == input.CancelReasonId ||
                    (this.CancelReasonId != null &&
                    this.CancelReasonId.Equals(input.CancelReasonId))
                ) && 
                (
                    this.LogisticsCode == input.LogisticsCode ||
                    (this.LogisticsCode != null &&
                    this.LogisticsCode.Equals(input.LogisticsCode))
                ) && 
                (
                    this.OrderNo == input.OrderNo ||
                    (this.OrderNo != null &&
                    this.OrderNo.Equals(input.OrderNo))
                ) && 
                (
                    this.OutOrderNo == input.OutOrderNo ||
                    (this.OutOrderNo != null &&
                    this.OutOrderNo.Equals(input.OutOrderNo))
                ) && 
                (
                    this.WaybillNo == input.WaybillNo ||
                    (this.WaybillNo != null &&
                    this.WaybillNo.Equals(input.WaybillNo))
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
                if (this.CancelReason != null)
                {
                    hashCode = (hashCode * 59) + this.CancelReason.GetHashCode();
                }
                if (this.CancelReasonId != null)
                {
                    hashCode = (hashCode * 59) + this.CancelReasonId.GetHashCode();
                }
                if (this.LogisticsCode != null)
                {
                    hashCode = (hashCode * 59) + this.LogisticsCode.GetHashCode();
                }
                if (this.OrderNo != null)
                {
                    hashCode = (hashCode * 59) + this.OrderNo.GetHashCode();
                }
                if (this.OutOrderNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutOrderNo.GetHashCode();
                }
                if (this.WaybillNo != null)
                {
                    hashCode = (hashCode * 59) + this.WaybillNo.GetHashCode();
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
