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
    /// OrderVoucherAvailableShop
    /// </summary>
    [DataContract(Name = "OrderVoucherAvailableShop")]
    public partial class OrderVoucherAvailableShop : IEquatable<OrderVoucherAvailableShop>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderVoucherAvailableShop" /> class.
        /// </summary>
        /// <param name="orderVoucherMerchantAllShop">orderVoucherMerchantAllShop.</param>
        /// <param name="realShopIds">代运营商业关系门店列表，列表中的门店id是调用接口alipay.business.relation.shop.create创建门店返回的real_shop_id  接口参数是列表类型。.</param>
        /// <param name="shopIds">券可使用的门店列表。列表中的门店id是通过调用接口ant.merchant.expand.shop.create创建门店返回的支付宝门店id  接口参数是列表类型。.</param>
        public OrderVoucherAvailableShop(OrderVoucherMerchantAllShop orderVoucherMerchantAllShop = default(OrderVoucherMerchantAllShop), List<string> realShopIds = default(List<string>), List<string> shopIds = default(List<string>))
        {
            this.OrderVoucherMerchantAllShop = orderVoucherMerchantAllShop;
            this.RealShopIds = realShopIds;
            this.ShopIds = shopIds;
        }

        /// <summary>
        /// Gets or Sets OrderVoucherMerchantAllShop
        /// </summary>
        [DataMember(Name = "order_voucher_merchant_all_shop", EmitDefaultValue = false)]
        public OrderVoucherMerchantAllShop OrderVoucherMerchantAllShop { get; set; }

        /// <summary>
        /// 代运营商业关系门店列表，列表中的门店id是调用接口alipay.business.relation.shop.create创建门店返回的real_shop_id  接口参数是列表类型。
        /// </summary>
        /// <value>代运营商业关系门店列表，列表中的门店id是调用接口alipay.business.relation.shop.create创建门店返回的real_shop_id  接口参数是列表类型。</value>
        [DataMember(Name = "real_shop_ids", EmitDefaultValue = false)]
        public List<string> RealShopIds { get; set; }

        /// <summary>
        /// 券可使用的门店列表。列表中的门店id是通过调用接口ant.merchant.expand.shop.create创建门店返回的支付宝门店id  接口参数是列表类型。
        /// </summary>
        /// <value>券可使用的门店列表。列表中的门店id是通过调用接口ant.merchant.expand.shop.create创建门店返回的支付宝门店id  接口参数是列表类型。</value>
        [DataMember(Name = "shop_ids", EmitDefaultValue = false)]
        public List<string> ShopIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderVoucherAvailableShop {\n");
            sb.Append("  OrderVoucherMerchantAllShop: ").Append(OrderVoucherMerchantAllShop).Append("\n");
            sb.Append("  RealShopIds: ").Append(RealShopIds).Append("\n");
            sb.Append("  ShopIds: ").Append(ShopIds).Append("\n");
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
            return this.Equals(input as OrderVoucherAvailableShop);
        }

        /// <summary>
        /// Returns true if OrderVoucherAvailableShop instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderVoucherAvailableShop to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderVoucherAvailableShop input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OrderVoucherMerchantAllShop == input.OrderVoucherMerchantAllShop ||
                    (this.OrderVoucherMerchantAllShop != null &&
                    this.OrderVoucherMerchantAllShop.Equals(input.OrderVoucherMerchantAllShop))
                ) && 
                (
                    this.RealShopIds == input.RealShopIds ||
                    this.RealShopIds != null &&
                    input.RealShopIds != null &&
                    this.RealShopIds.SequenceEqual(input.RealShopIds)
                ) && 
                (
                    this.ShopIds == input.ShopIds ||
                    this.ShopIds != null &&
                    input.ShopIds != null &&
                    this.ShopIds.SequenceEqual(input.ShopIds)
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
                if (this.OrderVoucherMerchantAllShop != null)
                {
                    hashCode = (hashCode * 59) + this.OrderVoucherMerchantAllShop.GetHashCode();
                }
                if (this.RealShopIds != null)
                {
                    hashCode = (hashCode * 59) + this.RealShopIds.GetHashCode();
                }
                if (this.ShopIds != null)
                {
                    hashCode = (hashCode * 59) + this.ShopIds.GetHashCode();
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
