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
    /// AlipayEbppBillGetResponseModel
    /// </summary>
    [DataContract(Name = "AlipayEbppBillGetResponseModel")]
    public partial class AlipayEbppBillGetResponseModel : IEquatable<AlipayEbppBillGetResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppBillGetResponseModel" /> class.
        /// </summary>
        /// <param name="alipayOrderNo">支付宝的业务订单号，具有唯一性。.</param>
        /// <param name="billDate">账单的账期，例如201203表示2012年3月的账单。.</param>
        /// <param name="billKey">账单单据号，例如水费单号，手机号，电费号，信用卡卡号。没有唯一性要求。.</param>
        /// <param name="chargeInst">支付宝给每个出账机构指定了一个对应的英文短名称来唯一表示该收费单位。.</param>
        /// <param name="chargeInstName">出账机构中文名称。.</param>
        /// <param name="merchantOrderNo">输出机构的业务流水号，需要保证唯一性。.</param>
        /// <param name="orderStatus">账单的状态。 INIT:等待付款，SUCCESS:成功,FAILED:失败。.</param>
        /// <param name="orderType">支付宝订单类型。公共事业缴纳JF,信用卡还款HK.</param>
        /// <param name="ownerName">拥有该账单的用户姓名.</param>
        /// <param name="payAmount">缴费金额。用户支付的总金额。单位为：RMB Yuan。取值范围为[0.01，100000000.00]，精确到小数点后两位。.</param>
        /// <param name="payTime">付款时间.</param>
        /// <param name="serviceAmount">账单的服务费.</param>
        /// <param name="subOrderType">子业务类型是业务类型的下一级概念，例如：WATER表示JF下面的水费，ELECTRIC表示JF下面的电费，GAS表示JF下面的燃气费。.</param>
        /// <param name="trafficLocation">交通违章地点，sub_order_type&#x3D;TRAFFIC时有值.</param>
        /// <param name="trafficRegulations">违章行为，sub_order_type&#x3D;TRAFFIC时有值。.</param>
        public AlipayEbppBillGetResponseModel(string alipayOrderNo = default(string), string billDate = default(string), string billKey = default(string), string chargeInst = default(string), string chargeInstName = default(string), string merchantOrderNo = default(string), string orderStatus = default(string), string orderType = default(string), string ownerName = default(string), string payAmount = default(string), string payTime = default(string), string serviceAmount = default(string), string subOrderType = default(string), string trafficLocation = default(string), string trafficRegulations = default(string))
        {
            this.AlipayOrderNo = alipayOrderNo;
            this.BillDate = billDate;
            this.BillKey = billKey;
            this.ChargeInst = chargeInst;
            this.ChargeInstName = chargeInstName;
            this.MerchantOrderNo = merchantOrderNo;
            this.OrderStatus = orderStatus;
            this.OrderType = orderType;
            this.OwnerName = ownerName;
            this.PayAmount = payAmount;
            this.PayTime = payTime;
            this.ServiceAmount = serviceAmount;
            this.SubOrderType = subOrderType;
            this.TrafficLocation = trafficLocation;
            this.TrafficRegulations = trafficRegulations;
        }

        /// <summary>
        /// 支付宝的业务订单号，具有唯一性。
        /// </summary>
        /// <value>支付宝的业务订单号，具有唯一性。</value>
        [DataMember(Name = "alipay_order_no", EmitDefaultValue = false)]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 账单的账期，例如201203表示2012年3月的账单。
        /// </summary>
        /// <value>账单的账期，例如201203表示2012年3月的账单。</value>
        [DataMember(Name = "bill_date", EmitDefaultValue = false)]
        public string BillDate { get; set; }

        /// <summary>
        /// 账单单据号，例如水费单号，手机号，电费号，信用卡卡号。没有唯一性要求。
        /// </summary>
        /// <value>账单单据号，例如水费单号，手机号，电费号，信用卡卡号。没有唯一性要求。</value>
        [DataMember(Name = "bill_key", EmitDefaultValue = false)]
        public string BillKey { get; set; }

        /// <summary>
        /// 支付宝给每个出账机构指定了一个对应的英文短名称来唯一表示该收费单位。
        /// </summary>
        /// <value>支付宝给每个出账机构指定了一个对应的英文短名称来唯一表示该收费单位。</value>
        [DataMember(Name = "charge_inst", EmitDefaultValue = false)]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 出账机构中文名称。
        /// </summary>
        /// <value>出账机构中文名称。</value>
        [DataMember(Name = "charge_inst_name", EmitDefaultValue = false)]
        public string ChargeInstName { get; set; }

        /// <summary>
        /// 输出机构的业务流水号，需要保证唯一性。
        /// </summary>
        /// <value>输出机构的业务流水号，需要保证唯一性。</value>
        [DataMember(Name = "merchant_order_no", EmitDefaultValue = false)]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 账单的状态。 INIT:等待付款，SUCCESS:成功,FAILED:失败。
        /// </summary>
        /// <value>账单的状态。 INIT:等待付款，SUCCESS:成功,FAILED:失败。</value>
        [DataMember(Name = "order_status", EmitDefaultValue = false)]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 支付宝订单类型。公共事业缴纳JF,信用卡还款HK
        /// </summary>
        /// <value>支付宝订单类型。公共事业缴纳JF,信用卡还款HK</value>
        [DataMember(Name = "order_type", EmitDefaultValue = false)]
        public string OrderType { get; set; }

        /// <summary>
        /// 拥有该账单的用户姓名
        /// </summary>
        /// <value>拥有该账单的用户姓名</value>
        [DataMember(Name = "owner_name", EmitDefaultValue = false)]
        public string OwnerName { get; set; }

        /// <summary>
        /// 缴费金额。用户支付的总金额。单位为：RMB Yuan。取值范围为[0.01，100000000.00]，精确到小数点后两位。
        /// </summary>
        /// <value>缴费金额。用户支付的总金额。单位为：RMB Yuan。取值范围为[0.01，100000000.00]，精确到小数点后两位。</value>
        [DataMember(Name = "pay_amount", EmitDefaultValue = false)]
        public string PayAmount { get; set; }

        /// <summary>
        /// 付款时间
        /// </summary>
        /// <value>付款时间</value>
        [DataMember(Name = "pay_time", EmitDefaultValue = false)]
        public string PayTime { get; set; }

        /// <summary>
        /// 账单的服务费
        /// </summary>
        /// <value>账单的服务费</value>
        [DataMember(Name = "service_amount", EmitDefaultValue = false)]
        public string ServiceAmount { get; set; }

        /// <summary>
        /// 子业务类型是业务类型的下一级概念，例如：WATER表示JF下面的水费，ELECTRIC表示JF下面的电费，GAS表示JF下面的燃气费。
        /// </summary>
        /// <value>子业务类型是业务类型的下一级概念，例如：WATER表示JF下面的水费，ELECTRIC表示JF下面的电费，GAS表示JF下面的燃气费。</value>
        [DataMember(Name = "sub_order_type", EmitDefaultValue = false)]
        public string SubOrderType { get; set; }

        /// <summary>
        /// 交通违章地点，sub_order_type&#x3D;TRAFFIC时有值
        /// </summary>
        /// <value>交通违章地点，sub_order_type&#x3D;TRAFFIC时有值</value>
        [DataMember(Name = "traffic_location", EmitDefaultValue = false)]
        public string TrafficLocation { get; set; }

        /// <summary>
        /// 违章行为，sub_order_type&#x3D;TRAFFIC时有值。
        /// </summary>
        /// <value>违章行为，sub_order_type&#x3D;TRAFFIC时有值。</value>
        [DataMember(Name = "traffic_regulations", EmitDefaultValue = false)]
        public string TrafficRegulations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppBillGetResponseModel {\n");
            sb.Append("  AlipayOrderNo: ").Append(AlipayOrderNo).Append("\n");
            sb.Append("  BillDate: ").Append(BillDate).Append("\n");
            sb.Append("  BillKey: ").Append(BillKey).Append("\n");
            sb.Append("  ChargeInst: ").Append(ChargeInst).Append("\n");
            sb.Append("  ChargeInstName: ").Append(ChargeInstName).Append("\n");
            sb.Append("  MerchantOrderNo: ").Append(MerchantOrderNo).Append("\n");
            sb.Append("  OrderStatus: ").Append(OrderStatus).Append("\n");
            sb.Append("  OrderType: ").Append(OrderType).Append("\n");
            sb.Append("  OwnerName: ").Append(OwnerName).Append("\n");
            sb.Append("  PayAmount: ").Append(PayAmount).Append("\n");
            sb.Append("  PayTime: ").Append(PayTime).Append("\n");
            sb.Append("  ServiceAmount: ").Append(ServiceAmount).Append("\n");
            sb.Append("  SubOrderType: ").Append(SubOrderType).Append("\n");
            sb.Append("  TrafficLocation: ").Append(TrafficLocation).Append("\n");
            sb.Append("  TrafficRegulations: ").Append(TrafficRegulations).Append("\n");
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
            return this.Equals(input as AlipayEbppBillGetResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppBillGetResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppBillGetResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppBillGetResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AlipayOrderNo == input.AlipayOrderNo ||
                    (this.AlipayOrderNo != null &&
                    this.AlipayOrderNo.Equals(input.AlipayOrderNo))
                ) && 
                (
                    this.BillDate == input.BillDate ||
                    (this.BillDate != null &&
                    this.BillDate.Equals(input.BillDate))
                ) && 
                (
                    this.BillKey == input.BillKey ||
                    (this.BillKey != null &&
                    this.BillKey.Equals(input.BillKey))
                ) && 
                (
                    this.ChargeInst == input.ChargeInst ||
                    (this.ChargeInst != null &&
                    this.ChargeInst.Equals(input.ChargeInst))
                ) && 
                (
                    this.ChargeInstName == input.ChargeInstName ||
                    (this.ChargeInstName != null &&
                    this.ChargeInstName.Equals(input.ChargeInstName))
                ) && 
                (
                    this.MerchantOrderNo == input.MerchantOrderNo ||
                    (this.MerchantOrderNo != null &&
                    this.MerchantOrderNo.Equals(input.MerchantOrderNo))
                ) && 
                (
                    this.OrderStatus == input.OrderStatus ||
                    (this.OrderStatus != null &&
                    this.OrderStatus.Equals(input.OrderStatus))
                ) && 
                (
                    this.OrderType == input.OrderType ||
                    (this.OrderType != null &&
                    this.OrderType.Equals(input.OrderType))
                ) && 
                (
                    this.OwnerName == input.OwnerName ||
                    (this.OwnerName != null &&
                    this.OwnerName.Equals(input.OwnerName))
                ) && 
                (
                    this.PayAmount == input.PayAmount ||
                    (this.PayAmount != null &&
                    this.PayAmount.Equals(input.PayAmount))
                ) && 
                (
                    this.PayTime == input.PayTime ||
                    (this.PayTime != null &&
                    this.PayTime.Equals(input.PayTime))
                ) && 
                (
                    this.ServiceAmount == input.ServiceAmount ||
                    (this.ServiceAmount != null &&
                    this.ServiceAmount.Equals(input.ServiceAmount))
                ) && 
                (
                    this.SubOrderType == input.SubOrderType ||
                    (this.SubOrderType != null &&
                    this.SubOrderType.Equals(input.SubOrderType))
                ) && 
                (
                    this.TrafficLocation == input.TrafficLocation ||
                    (this.TrafficLocation != null &&
                    this.TrafficLocation.Equals(input.TrafficLocation))
                ) && 
                (
                    this.TrafficRegulations == input.TrafficRegulations ||
                    (this.TrafficRegulations != null &&
                    this.TrafficRegulations.Equals(input.TrafficRegulations))
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
                if (this.AlipayOrderNo != null)
                {
                    hashCode = (hashCode * 59) + this.AlipayOrderNo.GetHashCode();
                }
                if (this.BillDate != null)
                {
                    hashCode = (hashCode * 59) + this.BillDate.GetHashCode();
                }
                if (this.BillKey != null)
                {
                    hashCode = (hashCode * 59) + this.BillKey.GetHashCode();
                }
                if (this.ChargeInst != null)
                {
                    hashCode = (hashCode * 59) + this.ChargeInst.GetHashCode();
                }
                if (this.ChargeInstName != null)
                {
                    hashCode = (hashCode * 59) + this.ChargeInstName.GetHashCode();
                }
                if (this.MerchantOrderNo != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantOrderNo.GetHashCode();
                }
                if (this.OrderStatus != null)
                {
                    hashCode = (hashCode * 59) + this.OrderStatus.GetHashCode();
                }
                if (this.OrderType != null)
                {
                    hashCode = (hashCode * 59) + this.OrderType.GetHashCode();
                }
                if (this.OwnerName != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerName.GetHashCode();
                }
                if (this.PayAmount != null)
                {
                    hashCode = (hashCode * 59) + this.PayAmount.GetHashCode();
                }
                if (this.PayTime != null)
                {
                    hashCode = (hashCode * 59) + this.PayTime.GetHashCode();
                }
                if (this.ServiceAmount != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceAmount.GetHashCode();
                }
                if (this.SubOrderType != null)
                {
                    hashCode = (hashCode * 59) + this.SubOrderType.GetHashCode();
                }
                if (this.TrafficLocation != null)
                {
                    hashCode = (hashCode * 59) + this.TrafficLocation.GetHashCode();
                }
                if (this.TrafficRegulations != null)
                {
                    hashCode = (hashCode * 59) + this.TrafficRegulations.GetHashCode();
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
