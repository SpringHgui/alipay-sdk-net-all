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
    /// AlipayOpenSpIsvOperationSyncModel
    /// </summary>
    [DataContract(Name = "AlipayOpenSpIsvOperationSyncModel")]
    public partial class AlipayOpenSpIsvOperationSyncModel : IEquatable<AlipayOpenSpIsvOperationSyncModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenSpIsvOperationSyncModel" /> class.
        /// </summary>
        /// <param name="customerType">客户类型，PERSONAL表示个人，ALIPAY_RECOMMEND表示支付宝推荐.</param>
        /// <param name="extInfo">extInfo.</param>
        /// <param name="implementEndTime">实施结束时间.</param>
        /// <param name="implementObjectName">实施对象名称.</param>
        /// <param name="implementPlace">实施地点.</param>
        /// <param name="implementResult">实施结果，SUCCESS表示实施成功，FAIL表示实施失败.</param>
        /// <param name="implementResultImage">实施结果的照片.</param>
        /// <param name="implementResultRemark">实施结果的备注.</param>
        /// <param name="implementStartTime">实施开始时间.</param>
        /// <param name="itemCode">服务优选商品编码.</param>
        /// <param name="itemPrice">商品价格，这里填写的是整数，单位为分，比如1元，那么输入100.</param>
        /// <param name="merchantPid">商户pid.</param>
        /// <param name="miniAppid">商品小程序appid，若推广的商品不为小程序，则不传此参数.</param>
        /// <param name="opporId">拓展助手中的商机id.</param>
        /// <param name="orderId">下单订单号.</param>
        /// <param name="outBizNo">外部业务号，传isv系统生成的账单号，需要保证唯一.</param>
        /// <param name="promotorPid">推广服务商(S2)pid.</param>
        /// <param name="shopId">店铺id.</param>
        /// <param name="subPromotorPid">推广服务商(S2)子账号pid.</param>
        public AlipayOpenSpIsvOperationSyncModel(string customerType = default(string), OperationResultExtInfo extInfo = default(OperationResultExtInfo), string implementEndTime = default(string), string implementObjectName = default(string), string implementPlace = default(string), string implementResult = default(string), string implementResultImage = default(string), string implementResultRemark = default(string), string implementStartTime = default(string), string itemCode = default(string), string itemPrice = default(string), string merchantPid = default(string), string miniAppid = default(string), string opporId = default(string), string orderId = default(string), string outBizNo = default(string), string promotorPid = default(string), string shopId = default(string), string subPromotorPid = default(string))
        {
            this.CustomerType = customerType;
            this.ExtInfo = extInfo;
            this.ImplementEndTime = implementEndTime;
            this.ImplementObjectName = implementObjectName;
            this.ImplementPlace = implementPlace;
            this.ImplementResult = implementResult;
            this.ImplementResultImage = implementResultImage;
            this.ImplementResultRemark = implementResultRemark;
            this.ImplementStartTime = implementStartTime;
            this.ItemCode = itemCode;
            this.ItemPrice = itemPrice;
            this.MerchantPid = merchantPid;
            this.MiniAppid = miniAppid;
            this.OpporId = opporId;
            this.OrderId = orderId;
            this.OutBizNo = outBizNo;
            this.PromotorPid = promotorPid;
            this.ShopId = shopId;
            this.SubPromotorPid = subPromotorPid;
        }

        /// <summary>
        /// 客户类型，PERSONAL表示个人，ALIPAY_RECOMMEND表示支付宝推荐
        /// </summary>
        /// <value>客户类型，PERSONAL表示个人，ALIPAY_RECOMMEND表示支付宝推荐</value>
        [DataMember(Name = "customer_type", EmitDefaultValue = false)]
        public string CustomerType { get; set; }

        /// <summary>
        /// Gets or Sets ExtInfo
        /// </summary>
        [DataMember(Name = "ext_info", EmitDefaultValue = false)]
        public OperationResultExtInfo ExtInfo { get; set; }

        /// <summary>
        /// 实施结束时间
        /// </summary>
        /// <value>实施结束时间</value>
        [DataMember(Name = "implement_end_time", EmitDefaultValue = false)]
        public string ImplementEndTime { get; set; }

        /// <summary>
        /// 实施对象名称
        /// </summary>
        /// <value>实施对象名称</value>
        [DataMember(Name = "implement_object_name", EmitDefaultValue = false)]
        public string ImplementObjectName { get; set; }

        /// <summary>
        /// 实施地点
        /// </summary>
        /// <value>实施地点</value>
        [DataMember(Name = "implement_place", EmitDefaultValue = false)]
        public string ImplementPlace { get; set; }

        /// <summary>
        /// 实施结果，SUCCESS表示实施成功，FAIL表示实施失败
        /// </summary>
        /// <value>实施结果，SUCCESS表示实施成功，FAIL表示实施失败</value>
        [DataMember(Name = "implement_result", EmitDefaultValue = false)]
        public string ImplementResult { get; set; }

        /// <summary>
        /// 实施结果的照片
        /// </summary>
        /// <value>实施结果的照片</value>
        [DataMember(Name = "implement_result_image", EmitDefaultValue = false)]
        public string ImplementResultImage { get; set; }

        /// <summary>
        /// 实施结果的备注
        /// </summary>
        /// <value>实施结果的备注</value>
        [DataMember(Name = "implement_result_remark", EmitDefaultValue = false)]
        public string ImplementResultRemark { get; set; }

        /// <summary>
        /// 实施开始时间
        /// </summary>
        /// <value>实施开始时间</value>
        [DataMember(Name = "implement_start_time", EmitDefaultValue = false)]
        public string ImplementStartTime { get; set; }

        /// <summary>
        /// 服务优选商品编码
        /// </summary>
        /// <value>服务优选商品编码</value>
        [DataMember(Name = "item_code", EmitDefaultValue = false)]
        public string ItemCode { get; set; }

        /// <summary>
        /// 商品价格，这里填写的是整数，单位为分，比如1元，那么输入100
        /// </summary>
        /// <value>商品价格，这里填写的是整数，单位为分，比如1元，那么输入100</value>
        [DataMember(Name = "item_price", EmitDefaultValue = false)]
        public string ItemPrice { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        /// <value>商户pid</value>
        [DataMember(Name = "merchant_pid", EmitDefaultValue = false)]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 商品小程序appid，若推广的商品不为小程序，则不传此参数
        /// </summary>
        /// <value>商品小程序appid，若推广的商品不为小程序，则不传此参数</value>
        [DataMember(Name = "mini_appid", EmitDefaultValue = false)]
        public string MiniAppid { get; set; }

        /// <summary>
        /// 拓展助手中的商机id
        /// </summary>
        /// <value>拓展助手中的商机id</value>
        [DataMember(Name = "oppor_id", EmitDefaultValue = false)]
        public string OpporId { get; set; }

        /// <summary>
        /// 下单订单号
        /// </summary>
        /// <value>下单订单号</value>
        [DataMember(Name = "order_id", EmitDefaultValue = false)]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部业务号，传isv系统生成的账单号，需要保证唯一
        /// </summary>
        /// <value>外部业务号，传isv系统生成的账单号，需要保证唯一</value>
        [DataMember(Name = "out_biz_no", EmitDefaultValue = false)]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 推广服务商(S2)pid
        /// </summary>
        /// <value>推广服务商(S2)pid</value>
        [DataMember(Name = "promotor_pid", EmitDefaultValue = false)]
        public string PromotorPid { get; set; }

        /// <summary>
        /// 店铺id
        /// </summary>
        /// <value>店铺id</value>
        [DataMember(Name = "shop_id", EmitDefaultValue = false)]
        public string ShopId { get; set; }

        /// <summary>
        /// 推广服务商(S2)子账号pid
        /// </summary>
        /// <value>推广服务商(S2)子账号pid</value>
        [DataMember(Name = "sub_promotor_pid", EmitDefaultValue = false)]
        public string SubPromotorPid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenSpIsvOperationSyncModel {\n");
            sb.Append("  CustomerType: ").Append(CustomerType).Append("\n");
            sb.Append("  ExtInfo: ").Append(ExtInfo).Append("\n");
            sb.Append("  ImplementEndTime: ").Append(ImplementEndTime).Append("\n");
            sb.Append("  ImplementObjectName: ").Append(ImplementObjectName).Append("\n");
            sb.Append("  ImplementPlace: ").Append(ImplementPlace).Append("\n");
            sb.Append("  ImplementResult: ").Append(ImplementResult).Append("\n");
            sb.Append("  ImplementResultImage: ").Append(ImplementResultImage).Append("\n");
            sb.Append("  ImplementResultRemark: ").Append(ImplementResultRemark).Append("\n");
            sb.Append("  ImplementStartTime: ").Append(ImplementStartTime).Append("\n");
            sb.Append("  ItemCode: ").Append(ItemCode).Append("\n");
            sb.Append("  ItemPrice: ").Append(ItemPrice).Append("\n");
            sb.Append("  MerchantPid: ").Append(MerchantPid).Append("\n");
            sb.Append("  MiniAppid: ").Append(MiniAppid).Append("\n");
            sb.Append("  OpporId: ").Append(OpporId).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  OutBizNo: ").Append(OutBizNo).Append("\n");
            sb.Append("  PromotorPid: ").Append(PromotorPid).Append("\n");
            sb.Append("  ShopId: ").Append(ShopId).Append("\n");
            sb.Append("  SubPromotorPid: ").Append(SubPromotorPid).Append("\n");
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
            return this.Equals(input as AlipayOpenSpIsvOperationSyncModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenSpIsvOperationSyncModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenSpIsvOperationSyncModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenSpIsvOperationSyncModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CustomerType == input.CustomerType ||
                    (this.CustomerType != null &&
                    this.CustomerType.Equals(input.CustomerType))
                ) && 
                (
                    this.ExtInfo == input.ExtInfo ||
                    (this.ExtInfo != null &&
                    this.ExtInfo.Equals(input.ExtInfo))
                ) && 
                (
                    this.ImplementEndTime == input.ImplementEndTime ||
                    (this.ImplementEndTime != null &&
                    this.ImplementEndTime.Equals(input.ImplementEndTime))
                ) && 
                (
                    this.ImplementObjectName == input.ImplementObjectName ||
                    (this.ImplementObjectName != null &&
                    this.ImplementObjectName.Equals(input.ImplementObjectName))
                ) && 
                (
                    this.ImplementPlace == input.ImplementPlace ||
                    (this.ImplementPlace != null &&
                    this.ImplementPlace.Equals(input.ImplementPlace))
                ) && 
                (
                    this.ImplementResult == input.ImplementResult ||
                    (this.ImplementResult != null &&
                    this.ImplementResult.Equals(input.ImplementResult))
                ) && 
                (
                    this.ImplementResultImage == input.ImplementResultImage ||
                    (this.ImplementResultImage != null &&
                    this.ImplementResultImage.Equals(input.ImplementResultImage))
                ) && 
                (
                    this.ImplementResultRemark == input.ImplementResultRemark ||
                    (this.ImplementResultRemark != null &&
                    this.ImplementResultRemark.Equals(input.ImplementResultRemark))
                ) && 
                (
                    this.ImplementStartTime == input.ImplementStartTime ||
                    (this.ImplementStartTime != null &&
                    this.ImplementStartTime.Equals(input.ImplementStartTime))
                ) && 
                (
                    this.ItemCode == input.ItemCode ||
                    (this.ItemCode != null &&
                    this.ItemCode.Equals(input.ItemCode))
                ) && 
                (
                    this.ItemPrice == input.ItemPrice ||
                    (this.ItemPrice != null &&
                    this.ItemPrice.Equals(input.ItemPrice))
                ) && 
                (
                    this.MerchantPid == input.MerchantPid ||
                    (this.MerchantPid != null &&
                    this.MerchantPid.Equals(input.MerchantPid))
                ) && 
                (
                    this.MiniAppid == input.MiniAppid ||
                    (this.MiniAppid != null &&
                    this.MiniAppid.Equals(input.MiniAppid))
                ) && 
                (
                    this.OpporId == input.OpporId ||
                    (this.OpporId != null &&
                    this.OpporId.Equals(input.OpporId))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.OutBizNo == input.OutBizNo ||
                    (this.OutBizNo != null &&
                    this.OutBizNo.Equals(input.OutBizNo))
                ) && 
                (
                    this.PromotorPid == input.PromotorPid ||
                    (this.PromotorPid != null &&
                    this.PromotorPid.Equals(input.PromotorPid))
                ) && 
                (
                    this.ShopId == input.ShopId ||
                    (this.ShopId != null &&
                    this.ShopId.Equals(input.ShopId))
                ) && 
                (
                    this.SubPromotorPid == input.SubPromotorPid ||
                    (this.SubPromotorPid != null &&
                    this.SubPromotorPid.Equals(input.SubPromotorPid))
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
                if (this.CustomerType != null)
                {
                    hashCode = (hashCode * 59) + this.CustomerType.GetHashCode();
                }
                if (this.ExtInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ExtInfo.GetHashCode();
                }
                if (this.ImplementEndTime != null)
                {
                    hashCode = (hashCode * 59) + this.ImplementEndTime.GetHashCode();
                }
                if (this.ImplementObjectName != null)
                {
                    hashCode = (hashCode * 59) + this.ImplementObjectName.GetHashCode();
                }
                if (this.ImplementPlace != null)
                {
                    hashCode = (hashCode * 59) + this.ImplementPlace.GetHashCode();
                }
                if (this.ImplementResult != null)
                {
                    hashCode = (hashCode * 59) + this.ImplementResult.GetHashCode();
                }
                if (this.ImplementResultImage != null)
                {
                    hashCode = (hashCode * 59) + this.ImplementResultImage.GetHashCode();
                }
                if (this.ImplementResultRemark != null)
                {
                    hashCode = (hashCode * 59) + this.ImplementResultRemark.GetHashCode();
                }
                if (this.ImplementStartTime != null)
                {
                    hashCode = (hashCode * 59) + this.ImplementStartTime.GetHashCode();
                }
                if (this.ItemCode != null)
                {
                    hashCode = (hashCode * 59) + this.ItemCode.GetHashCode();
                }
                if (this.ItemPrice != null)
                {
                    hashCode = (hashCode * 59) + this.ItemPrice.GetHashCode();
                }
                if (this.MerchantPid != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantPid.GetHashCode();
                }
                if (this.MiniAppid != null)
                {
                    hashCode = (hashCode * 59) + this.MiniAppid.GetHashCode();
                }
                if (this.OpporId != null)
                {
                    hashCode = (hashCode * 59) + this.OpporId.GetHashCode();
                }
                if (this.OrderId != null)
                {
                    hashCode = (hashCode * 59) + this.OrderId.GetHashCode();
                }
                if (this.OutBizNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutBizNo.GetHashCode();
                }
                if (this.PromotorPid != null)
                {
                    hashCode = (hashCode * 59) + this.PromotorPid.GetHashCode();
                }
                if (this.ShopId != null)
                {
                    hashCode = (hashCode * 59) + this.ShopId.GetHashCode();
                }
                if (this.SubPromotorPid != null)
                {
                    hashCode = (hashCode * 59) + this.SubPromotorPid.GetHashCode();
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
