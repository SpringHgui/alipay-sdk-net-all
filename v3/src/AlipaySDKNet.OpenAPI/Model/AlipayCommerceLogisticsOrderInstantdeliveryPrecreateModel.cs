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
    /// AlipayCommerceLogisticsOrderInstantdeliveryPrecreateModel
    /// </summary>
    [DataContract(Name = "AlipayCommerceLogisticsOrderInstantdeliveryPrecreateModel")]
    public partial class AlipayCommerceLogisticsOrderInstantdeliveryPrecreateModel : IEquatable<AlipayCommerceLogisticsOrderInstantdeliveryPrecreateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceLogisticsOrderInstantdeliveryPrecreateModel" /> class.
        /// </summary>
        /// <param name="consumerId">消费者id， 如果consumer_source是alipay，则consumer_id必须是支付宝用户uid；如果consumer_source是wx，则consumer_id可以为空.</param>
        /// <param name="consumerNotify">consumerNotify.</param>
        /// <param name="consumerSource">消费者来源, 支付宝：alipay, 微信：wx.</param>
        /// <param name="goodsDetails">商品明细.</param>
        /// <param name="goodsInfo">goodsInfo.</param>
        /// <param name="logisticsCompanies">即时配送公司配置列表.</param>
        /// <param name="openId">消费者id， 如果consumer_source是alipay，则consumer_id必须是支付宝的openId；如果consumer_source是wx，则consumer_id可以为空.</param>
        /// <param name="orderExtIstd">orderExtIstd.</param>
        /// <param name="outOrderNo">商家订单号.</param>
        /// <param name="receiver">receiver.</param>
        /// <param name="sender">sender.</param>
        /// <param name="shopNo">商家门店编号.</param>
        public AlipayCommerceLogisticsOrderInstantdeliveryPrecreateModel(string consumerId = default(string), ConsumerNotifyIstd consumerNotify = default(ConsumerNotifyIstd), string consumerSource = default(string), List<GoodsDetailIstd> goodsDetails = default(List<GoodsDetailIstd>), GoodsInfoIstd goodsInfo = default(GoodsInfoIstd), List<LogisticsCompanyIstd> logisticsCompanies = default(List<LogisticsCompanyIstd>), string openId = default(string), OrderExtIstdForPreOrder orderExtIstd = default(OrderExtIstdForPreOrder), string outOrderNo = default(string), ReceiverIstd receiver = default(ReceiverIstd), SenderIstd sender = default(SenderIstd), string shopNo = default(string))
        {
            this.ConsumerId = consumerId;
            this.ConsumerNotify = consumerNotify;
            this.ConsumerSource = consumerSource;
            this.GoodsDetails = goodsDetails;
            this.GoodsInfo = goodsInfo;
            this.LogisticsCompanies = logisticsCompanies;
            this.OpenId = openId;
            this.OrderExtIstd = orderExtIstd;
            this.OutOrderNo = outOrderNo;
            this.Receiver = receiver;
            this.Sender = sender;
            this.ShopNo = shopNo;
        }

        /// <summary>
        /// 消费者id， 如果consumer_source是alipay，则consumer_id必须是支付宝用户uid；如果consumer_source是wx，则consumer_id可以为空
        /// </summary>
        /// <value>消费者id， 如果consumer_source是alipay，则consumer_id必须是支付宝用户uid；如果consumer_source是wx，则consumer_id可以为空</value>
        [DataMember(Name = "consumer_id", EmitDefaultValue = false)]
        public string ConsumerId { get; set; }

        /// <summary>
        /// Gets or Sets ConsumerNotify
        /// </summary>
        [DataMember(Name = "consumer_notify", EmitDefaultValue = false)]
        public ConsumerNotifyIstd ConsumerNotify { get; set; }

        /// <summary>
        /// 消费者来源, 支付宝：alipay, 微信：wx
        /// </summary>
        /// <value>消费者来源, 支付宝：alipay, 微信：wx</value>
        [DataMember(Name = "consumer_source", EmitDefaultValue = false)]
        public string ConsumerSource { get; set; }

        /// <summary>
        /// 商品明细
        /// </summary>
        /// <value>商品明细</value>
        [DataMember(Name = "goods_details", EmitDefaultValue = false)]
        public List<GoodsDetailIstd> GoodsDetails { get; set; }

        /// <summary>
        /// Gets or Sets GoodsInfo
        /// </summary>
        [DataMember(Name = "goods_info", EmitDefaultValue = false)]
        public GoodsInfoIstd GoodsInfo { get; set; }

        /// <summary>
        /// 即时配送公司配置列表
        /// </summary>
        /// <value>即时配送公司配置列表</value>
        [DataMember(Name = "logistics_companies", EmitDefaultValue = false)]
        public List<LogisticsCompanyIstd> LogisticsCompanies { get; set; }

        /// <summary>
        /// 消费者id， 如果consumer_source是alipay，则consumer_id必须是支付宝的openId；如果consumer_source是wx，则consumer_id可以为空
        /// </summary>
        /// <value>消费者id， 如果consumer_source是alipay，则consumer_id必须是支付宝的openId；如果consumer_source是wx，则consumer_id可以为空</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// Gets or Sets OrderExtIstd
        /// </summary>
        [DataMember(Name = "order_ext_istd", EmitDefaultValue = false)]
        public OrderExtIstdForPreOrder OrderExtIstd { get; set; }

        /// <summary>
        /// 商家订单号
        /// </summary>
        /// <value>商家订单号</value>
        [DataMember(Name = "out_order_no", EmitDefaultValue = false)]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// Gets or Sets Receiver
        /// </summary>
        [DataMember(Name = "receiver", EmitDefaultValue = false)]
        public ReceiverIstd Receiver { get; set; }

        /// <summary>
        /// Gets or Sets Sender
        /// </summary>
        [DataMember(Name = "sender", EmitDefaultValue = false)]
        public SenderIstd Sender { get; set; }

        /// <summary>
        /// 商家门店编号
        /// </summary>
        /// <value>商家门店编号</value>
        [DataMember(Name = "shop_no", EmitDefaultValue = false)]
        public string ShopNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayCommerceLogisticsOrderInstantdeliveryPrecreateModel {\n");
            sb.Append("  ConsumerId: ").Append(ConsumerId).Append("\n");
            sb.Append("  ConsumerNotify: ").Append(ConsumerNotify).Append("\n");
            sb.Append("  ConsumerSource: ").Append(ConsumerSource).Append("\n");
            sb.Append("  GoodsDetails: ").Append(GoodsDetails).Append("\n");
            sb.Append("  GoodsInfo: ").Append(GoodsInfo).Append("\n");
            sb.Append("  LogisticsCompanies: ").Append(LogisticsCompanies).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  OrderExtIstd: ").Append(OrderExtIstd).Append("\n");
            sb.Append("  OutOrderNo: ").Append(OutOrderNo).Append("\n");
            sb.Append("  Receiver: ").Append(Receiver).Append("\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  ShopNo: ").Append(ShopNo).Append("\n");
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
            return this.Equals(input as AlipayCommerceLogisticsOrderInstantdeliveryPrecreateModel);
        }

        /// <summary>
        /// Returns true if AlipayCommerceLogisticsOrderInstantdeliveryPrecreateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayCommerceLogisticsOrderInstantdeliveryPrecreateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayCommerceLogisticsOrderInstantdeliveryPrecreateModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ConsumerId == input.ConsumerId ||
                    (this.ConsumerId != null &&
                    this.ConsumerId.Equals(input.ConsumerId))
                ) && 
                (
                    this.ConsumerNotify == input.ConsumerNotify ||
                    (this.ConsumerNotify != null &&
                    this.ConsumerNotify.Equals(input.ConsumerNotify))
                ) && 
                (
                    this.ConsumerSource == input.ConsumerSource ||
                    (this.ConsumerSource != null &&
                    this.ConsumerSource.Equals(input.ConsumerSource))
                ) && 
                (
                    this.GoodsDetails == input.GoodsDetails ||
                    this.GoodsDetails != null &&
                    input.GoodsDetails != null &&
                    this.GoodsDetails.SequenceEqual(input.GoodsDetails)
                ) && 
                (
                    this.GoodsInfo == input.GoodsInfo ||
                    (this.GoodsInfo != null &&
                    this.GoodsInfo.Equals(input.GoodsInfo))
                ) && 
                (
                    this.LogisticsCompanies == input.LogisticsCompanies ||
                    this.LogisticsCompanies != null &&
                    input.LogisticsCompanies != null &&
                    this.LogisticsCompanies.SequenceEqual(input.LogisticsCompanies)
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.OrderExtIstd == input.OrderExtIstd ||
                    (this.OrderExtIstd != null &&
                    this.OrderExtIstd.Equals(input.OrderExtIstd))
                ) && 
                (
                    this.OutOrderNo == input.OutOrderNo ||
                    (this.OutOrderNo != null &&
                    this.OutOrderNo.Equals(input.OutOrderNo))
                ) && 
                (
                    this.Receiver == input.Receiver ||
                    (this.Receiver != null &&
                    this.Receiver.Equals(input.Receiver))
                ) && 
                (
                    this.Sender == input.Sender ||
                    (this.Sender != null &&
                    this.Sender.Equals(input.Sender))
                ) && 
                (
                    this.ShopNo == input.ShopNo ||
                    (this.ShopNo != null &&
                    this.ShopNo.Equals(input.ShopNo))
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
                if (this.ConsumerId != null)
                {
                    hashCode = (hashCode * 59) + this.ConsumerId.GetHashCode();
                }
                if (this.ConsumerNotify != null)
                {
                    hashCode = (hashCode * 59) + this.ConsumerNotify.GetHashCode();
                }
                if (this.ConsumerSource != null)
                {
                    hashCode = (hashCode * 59) + this.ConsumerSource.GetHashCode();
                }
                if (this.GoodsDetails != null)
                {
                    hashCode = (hashCode * 59) + this.GoodsDetails.GetHashCode();
                }
                if (this.GoodsInfo != null)
                {
                    hashCode = (hashCode * 59) + this.GoodsInfo.GetHashCode();
                }
                if (this.LogisticsCompanies != null)
                {
                    hashCode = (hashCode * 59) + this.LogisticsCompanies.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.OrderExtIstd != null)
                {
                    hashCode = (hashCode * 59) + this.OrderExtIstd.GetHashCode();
                }
                if (this.OutOrderNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutOrderNo.GetHashCode();
                }
                if (this.Receiver != null)
                {
                    hashCode = (hashCode * 59) + this.Receiver.GetHashCode();
                }
                if (this.Sender != null)
                {
                    hashCode = (hashCode * 59) + this.Sender.GetHashCode();
                }
                if (this.ShopNo != null)
                {
                    hashCode = (hashCode * 59) + this.ShopNo.GetHashCode();
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
