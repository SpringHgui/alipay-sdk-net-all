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
    /// CustomerGuideModify
    /// </summary>
    [DataContract(Name = "CustomerGuideModify")]
    public partial class CustomerGuideModify : IEquatable<CustomerGuideModify>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerGuideModify" /> class.
        /// </summary>
        /// <param name="miniAppId">券可用的小程序 appId，卡包详情页可跳转到该 appId。.</param>
        /// <param name="miniAppPath">指定跳转到 mini_app_id 时的具体页面路径。.</param>
        /// <param name="realShopIds">券可使用的商业关系门店列表,列表中的门店id是调用接口alipay.business.relation.shop.create创建门店返回的real_shop_id。.</param>
        /// <param name="serviceCodes">小程序服务编码，通过 alipay.open.app.appcontent.function.create(小程序服务创建)接口创建服务后获取。.</param>
        /// <param name="shopIds">券可使用的门店列表。列表中的门店id是通过调用接口ant.merchant.expand.shop.create创建门店返回的支付宝门店 id 接口参数是列表类型。 接口参数是列表类型。.</param>
        /// <param name="storeIds">后续废弃。券可使用的门店列表。列表中的门店id是通过调用接口ant.merchant.expand.shop.create创建门店返回的支付宝门店 id 接口参数是列表类型。 接口参数是列表类型。.</param>
        /// <param name="voucherSendGuide">voucherSendGuide.</param>
        /// <param name="voucherUseGuide">voucherUseGuide.</param>
        public CustomerGuideModify(string miniAppId = default(string), string miniAppPath = default(string), List<string> realShopIds = default(List<string>), List<string> serviceCodes = default(List<string>), List<string> shopIds = default(List<string>), List<string> storeIds = default(List<string>), VoucherSendGuideModify voucherSendGuide = default(VoucherSendGuideModify), VoucherUseGuideModify voucherUseGuide = default(VoucherUseGuideModify))
        {
            this.MiniAppId = miniAppId;
            this.MiniAppPath = miniAppPath;
            this.RealShopIds = realShopIds;
            this.ServiceCodes = serviceCodes;
            this.ShopIds = shopIds;
            this.StoreIds = storeIds;
            this.VoucherSendGuide = voucherSendGuide;
            this.VoucherUseGuide = voucherUseGuide;
        }

        /// <summary>
        /// 券可用的小程序 appId，卡包详情页可跳转到该 appId。
        /// </summary>
        /// <value>券可用的小程序 appId，卡包详情页可跳转到该 appId。</value>
        [DataMember(Name = "mini_app_id", EmitDefaultValue = false)]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 指定跳转到 mini_app_id 时的具体页面路径。
        /// </summary>
        /// <value>指定跳转到 mini_app_id 时的具体页面路径。</value>
        [DataMember(Name = "mini_app_path", EmitDefaultValue = false)]
        public string MiniAppPath { get; set; }

        /// <summary>
        /// 券可使用的商业关系门店列表,列表中的门店id是调用接口alipay.business.relation.shop.create创建门店返回的real_shop_id。
        /// </summary>
        /// <value>券可使用的商业关系门店列表,列表中的门店id是调用接口alipay.business.relation.shop.create创建门店返回的real_shop_id。</value>
        [DataMember(Name = "real_shop_ids", EmitDefaultValue = false)]
        public List<string> RealShopIds { get; set; }

        /// <summary>
        /// 小程序服务编码，通过 alipay.open.app.appcontent.function.create(小程序服务创建)接口创建服务后获取。
        /// </summary>
        /// <value>小程序服务编码，通过 alipay.open.app.appcontent.function.create(小程序服务创建)接口创建服务后获取。</value>
        [DataMember(Name = "service_codes", EmitDefaultValue = false)]
        public List<string> ServiceCodes { get; set; }

        /// <summary>
        /// 券可使用的门店列表。列表中的门店id是通过调用接口ant.merchant.expand.shop.create创建门店返回的支付宝门店 id 接口参数是列表类型。 接口参数是列表类型。
        /// </summary>
        /// <value>券可使用的门店列表。列表中的门店id是通过调用接口ant.merchant.expand.shop.create创建门店返回的支付宝门店 id 接口参数是列表类型。 接口参数是列表类型。</value>
        [DataMember(Name = "shop_ids", EmitDefaultValue = false)]
        public List<string> ShopIds { get; set; }

        /// <summary>
        /// 后续废弃。券可使用的门店列表。列表中的门店id是通过调用接口ant.merchant.expand.shop.create创建门店返回的支付宝门店 id 接口参数是列表类型。 接口参数是列表类型。
        /// </summary>
        /// <value>后续废弃。券可使用的门店列表。列表中的门店id是通过调用接口ant.merchant.expand.shop.create创建门店返回的支付宝门店 id 接口参数是列表类型。 接口参数是列表类型。</value>
        [DataMember(Name = "store_ids", EmitDefaultValue = false)]
        public List<string> StoreIds { get; set; }

        /// <summary>
        /// Gets or Sets VoucherSendGuide
        /// </summary>
        [DataMember(Name = "voucher_send_guide", EmitDefaultValue = false)]
        public VoucherSendGuideModify VoucherSendGuide { get; set; }

        /// <summary>
        /// Gets or Sets VoucherUseGuide
        /// </summary>
        [DataMember(Name = "voucher_use_guide", EmitDefaultValue = false)]
        public VoucherUseGuideModify VoucherUseGuide { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomerGuideModify {\n");
            sb.Append("  MiniAppId: ").Append(MiniAppId).Append("\n");
            sb.Append("  MiniAppPath: ").Append(MiniAppPath).Append("\n");
            sb.Append("  RealShopIds: ").Append(RealShopIds).Append("\n");
            sb.Append("  ServiceCodes: ").Append(ServiceCodes).Append("\n");
            sb.Append("  ShopIds: ").Append(ShopIds).Append("\n");
            sb.Append("  StoreIds: ").Append(StoreIds).Append("\n");
            sb.Append("  VoucherSendGuide: ").Append(VoucherSendGuide).Append("\n");
            sb.Append("  VoucherUseGuide: ").Append(VoucherUseGuide).Append("\n");
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
            return this.Equals(input as CustomerGuideModify);
        }

        /// <summary>
        /// Returns true if CustomerGuideModify instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerGuideModify to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerGuideModify input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MiniAppId == input.MiniAppId ||
                    (this.MiniAppId != null &&
                    this.MiniAppId.Equals(input.MiniAppId))
                ) && 
                (
                    this.MiniAppPath == input.MiniAppPath ||
                    (this.MiniAppPath != null &&
                    this.MiniAppPath.Equals(input.MiniAppPath))
                ) && 
                (
                    this.RealShopIds == input.RealShopIds ||
                    this.RealShopIds != null &&
                    input.RealShopIds != null &&
                    this.RealShopIds.SequenceEqual(input.RealShopIds)
                ) && 
                (
                    this.ServiceCodes == input.ServiceCodes ||
                    this.ServiceCodes != null &&
                    input.ServiceCodes != null &&
                    this.ServiceCodes.SequenceEqual(input.ServiceCodes)
                ) && 
                (
                    this.ShopIds == input.ShopIds ||
                    this.ShopIds != null &&
                    input.ShopIds != null &&
                    this.ShopIds.SequenceEqual(input.ShopIds)
                ) && 
                (
                    this.StoreIds == input.StoreIds ||
                    this.StoreIds != null &&
                    input.StoreIds != null &&
                    this.StoreIds.SequenceEqual(input.StoreIds)
                ) && 
                (
                    this.VoucherSendGuide == input.VoucherSendGuide ||
                    (this.VoucherSendGuide != null &&
                    this.VoucherSendGuide.Equals(input.VoucherSendGuide))
                ) && 
                (
                    this.VoucherUseGuide == input.VoucherUseGuide ||
                    (this.VoucherUseGuide != null &&
                    this.VoucherUseGuide.Equals(input.VoucherUseGuide))
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
                if (this.MiniAppId != null)
                {
                    hashCode = (hashCode * 59) + this.MiniAppId.GetHashCode();
                }
                if (this.MiniAppPath != null)
                {
                    hashCode = (hashCode * 59) + this.MiniAppPath.GetHashCode();
                }
                if (this.RealShopIds != null)
                {
                    hashCode = (hashCode * 59) + this.RealShopIds.GetHashCode();
                }
                if (this.ServiceCodes != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceCodes.GetHashCode();
                }
                if (this.ShopIds != null)
                {
                    hashCode = (hashCode * 59) + this.ShopIds.GetHashCode();
                }
                if (this.StoreIds != null)
                {
                    hashCode = (hashCode * 59) + this.StoreIds.GetHashCode();
                }
                if (this.VoucherSendGuide != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherSendGuide.GetHashCode();
                }
                if (this.VoucherUseGuide != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherUseGuide.GetHashCode();
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
