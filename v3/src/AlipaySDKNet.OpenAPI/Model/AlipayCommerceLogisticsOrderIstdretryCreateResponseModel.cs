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
    /// AlipayCommerceLogisticsOrderIstdretryCreateResponseModel
    /// </summary>
    [DataContract(Name = "AlipayCommerceLogisticsOrderIstdretryCreateResponseModel")]
    public partial class AlipayCommerceLogisticsOrderIstdretryCreateResponseModel : IEquatable<AlipayCommerceLogisticsOrderIstdretryCreateResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceLogisticsOrderIstdretryCreateResponseModel" /> class.
        /// </summary>
        /// <param name="couponFee">优惠券费用.</param>
        /// <param name="deliverFee">运费.</param>
        /// <param name="dispatchDuration">预计骑手还剩多久接单，单位：秒.</param>
        /// <param name="distance">配送距离(单位：米).</param>
        /// <param name="fee">实际运费.</param>
        /// <param name="finishCode">收货码，骑手必须输入收货码才能完成订单妥投.</param>
        /// <param name="insuranceFee">保价费用.</param>
        /// <param name="orderNo">支付宝订单流水号.</param>
        /// <param name="payAmount">支付金额, 实际扣减的费用以此字段为准.</param>
        /// <param name="pickupCode">取货码, 骑手必须输入取货码才能从商家取货.</param>
        /// <param name="status">即时配送运单状态.</param>
        /// <param name="waybillNo">即时配送运单编号.</param>
        public AlipayCommerceLogisticsOrderIstdretryCreateResponseModel(string couponFee = default(string), string deliverFee = default(string), int dispatchDuration = default(int), int distance = default(int), string fee = default(string), string finishCode = default(string), string insuranceFee = default(string), string orderNo = default(string), string payAmount = default(string), string pickupCode = default(string), string status = default(string), string waybillNo = default(string))
        {
            this.CouponFee = couponFee;
            this.DeliverFee = deliverFee;
            this.DispatchDuration = dispatchDuration;
            this.Distance = distance;
            this.Fee = fee;
            this.FinishCode = finishCode;
            this.InsuranceFee = insuranceFee;
            this.OrderNo = orderNo;
            this.PayAmount = payAmount;
            this.PickupCode = pickupCode;
            this.Status = status;
            this.WaybillNo = waybillNo;
        }

        /// <summary>
        /// 优惠券费用
        /// </summary>
        /// <value>优惠券费用</value>
        [DataMember(Name = "coupon_fee", EmitDefaultValue = false)]
        public string CouponFee { get; set; }

        /// <summary>
        /// 运费
        /// </summary>
        /// <value>运费</value>
        [DataMember(Name = "deliver_fee", EmitDefaultValue = false)]
        public string DeliverFee { get; set; }

        /// <summary>
        /// 预计骑手还剩多久接单，单位：秒
        /// </summary>
        /// <value>预计骑手还剩多久接单，单位：秒</value>
        [DataMember(Name = "dispatch_duration", EmitDefaultValue = false)]
        public int DispatchDuration { get; set; }

        /// <summary>
        /// 配送距离(单位：米)
        /// </summary>
        /// <value>配送距离(单位：米)</value>
        [DataMember(Name = "distance", EmitDefaultValue = false)]
        public int Distance { get; set; }

        /// <summary>
        /// 实际运费
        /// </summary>
        /// <value>实际运费</value>
        [DataMember(Name = "fee", EmitDefaultValue = false)]
        public string Fee { get; set; }

        /// <summary>
        /// 收货码，骑手必须输入收货码才能完成订单妥投
        /// </summary>
        /// <value>收货码，骑手必须输入收货码才能完成订单妥投</value>
        [DataMember(Name = "finish_code", EmitDefaultValue = false)]
        public string FinishCode { get; set; }

        /// <summary>
        /// 保价费用
        /// </summary>
        /// <value>保价费用</value>
        [DataMember(Name = "insurance_fee", EmitDefaultValue = false)]
        public string InsuranceFee { get; set; }

        /// <summary>
        /// 支付宝订单流水号
        /// </summary>
        /// <value>支付宝订单流水号</value>
        [DataMember(Name = "order_no", EmitDefaultValue = false)]
        public string OrderNo { get; set; }

        /// <summary>
        /// 支付金额, 实际扣减的费用以此字段为准
        /// </summary>
        /// <value>支付金额, 实际扣减的费用以此字段为准</value>
        [DataMember(Name = "pay_amount", EmitDefaultValue = false)]
        public string PayAmount { get; set; }

        /// <summary>
        /// 取货码, 骑手必须输入取货码才能从商家取货
        /// </summary>
        /// <value>取货码, 骑手必须输入取货码才能从商家取货</value>
        [DataMember(Name = "pickup_code", EmitDefaultValue = false)]
        public string PickupCode { get; set; }

        /// <summary>
        /// 即时配送运单状态
        /// </summary>
        /// <value>即时配送运单状态</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

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
            sb.Append("class AlipayCommerceLogisticsOrderIstdretryCreateResponseModel {\n");
            sb.Append("  CouponFee: ").Append(CouponFee).Append("\n");
            sb.Append("  DeliverFee: ").Append(DeliverFee).Append("\n");
            sb.Append("  DispatchDuration: ").Append(DispatchDuration).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  Fee: ").Append(Fee).Append("\n");
            sb.Append("  FinishCode: ").Append(FinishCode).Append("\n");
            sb.Append("  InsuranceFee: ").Append(InsuranceFee).Append("\n");
            sb.Append("  OrderNo: ").Append(OrderNo).Append("\n");
            sb.Append("  PayAmount: ").Append(PayAmount).Append("\n");
            sb.Append("  PickupCode: ").Append(PickupCode).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as AlipayCommerceLogisticsOrderIstdretryCreateResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayCommerceLogisticsOrderIstdretryCreateResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayCommerceLogisticsOrderIstdretryCreateResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayCommerceLogisticsOrderIstdretryCreateResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CouponFee == input.CouponFee ||
                    (this.CouponFee != null &&
                    this.CouponFee.Equals(input.CouponFee))
                ) && 
                (
                    this.DeliverFee == input.DeliverFee ||
                    (this.DeliverFee != null &&
                    this.DeliverFee.Equals(input.DeliverFee))
                ) && 
                (
                    this.DispatchDuration == input.DispatchDuration ||
                    this.DispatchDuration.Equals(input.DispatchDuration)
                ) && 
                (
                    this.Distance == input.Distance ||
                    this.Distance.Equals(input.Distance)
                ) && 
                (
                    this.Fee == input.Fee ||
                    (this.Fee != null &&
                    this.Fee.Equals(input.Fee))
                ) && 
                (
                    this.FinishCode == input.FinishCode ||
                    (this.FinishCode != null &&
                    this.FinishCode.Equals(input.FinishCode))
                ) && 
                (
                    this.InsuranceFee == input.InsuranceFee ||
                    (this.InsuranceFee != null &&
                    this.InsuranceFee.Equals(input.InsuranceFee))
                ) && 
                (
                    this.OrderNo == input.OrderNo ||
                    (this.OrderNo != null &&
                    this.OrderNo.Equals(input.OrderNo))
                ) && 
                (
                    this.PayAmount == input.PayAmount ||
                    (this.PayAmount != null &&
                    this.PayAmount.Equals(input.PayAmount))
                ) && 
                (
                    this.PickupCode == input.PickupCode ||
                    (this.PickupCode != null &&
                    this.PickupCode.Equals(input.PickupCode))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.CouponFee != null)
                {
                    hashCode = (hashCode * 59) + this.CouponFee.GetHashCode();
                }
                if (this.DeliverFee != null)
                {
                    hashCode = (hashCode * 59) + this.DeliverFee.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DispatchDuration.GetHashCode();
                hashCode = (hashCode * 59) + this.Distance.GetHashCode();
                if (this.Fee != null)
                {
                    hashCode = (hashCode * 59) + this.Fee.GetHashCode();
                }
                if (this.FinishCode != null)
                {
                    hashCode = (hashCode * 59) + this.FinishCode.GetHashCode();
                }
                if (this.InsuranceFee != null)
                {
                    hashCode = (hashCode * 59) + this.InsuranceFee.GetHashCode();
                }
                if (this.OrderNo != null)
                {
                    hashCode = (hashCode * 59) + this.OrderNo.GetHashCode();
                }
                if (this.PayAmount != null)
                {
                    hashCode = (hashCode * 59) + this.PayAmount.GetHashCode();
                }
                if (this.PickupCode != null)
                {
                    hashCode = (hashCode * 59) + this.PickupCode.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
