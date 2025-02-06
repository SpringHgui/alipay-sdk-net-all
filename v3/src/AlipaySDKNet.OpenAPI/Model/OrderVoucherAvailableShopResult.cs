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
    /// OrderVoucherAvailableShopResult
    /// </summary>
    [DataContract(Name = "OrderVoucherAvailableShopResult")]
    public partial class OrderVoucherAvailableShopResult : IEquatable<OrderVoucherAvailableShopResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderVoucherAvailableShopResult" /> class.
        /// </summary>
        /// <param name="orderVoucherMerchantAllShopResult">orderVoucherMerchantAllShopResult.</param>
        /// <param name="realShopFailInfos">请求失败的代运营商业关系门店详情.</param>
        /// <param name="shopFailInfos">请求失败的支付宝门店详情。.</param>
        /// <param name="successRealShopIds">请求成功的代运营商业关系门店.</param>
        /// <param name="successShopIds">请求成功的支付宝门店。.</param>
        public OrderVoucherAvailableShopResult(OrderVoucherMerchantAllShopResult orderVoucherMerchantAllShopResult = default(OrderVoucherMerchantAllShopResult), List<OrderVoucherRealShopFailInfo> realShopFailInfos = default(List<OrderVoucherRealShopFailInfo>), List<OrderVoucherShopFailInfo> shopFailInfos = default(List<OrderVoucherShopFailInfo>), List<string> successRealShopIds = default(List<string>), List<string> successShopIds = default(List<string>))
        {
            this.OrderVoucherMerchantAllShopResult = orderVoucherMerchantAllShopResult;
            this.RealShopFailInfos = realShopFailInfos;
            this.ShopFailInfos = shopFailInfos;
            this.SuccessRealShopIds = successRealShopIds;
            this.SuccessShopIds = successShopIds;
        }

        /// <summary>
        /// Gets or Sets OrderVoucherMerchantAllShopResult
        /// </summary>
        [DataMember(Name = "order_voucher_merchant_all_shop_result", EmitDefaultValue = false)]
        public OrderVoucherMerchantAllShopResult OrderVoucherMerchantAllShopResult { get; set; }

        /// <summary>
        /// 请求失败的代运营商业关系门店详情
        /// </summary>
        /// <value>请求失败的代运营商业关系门店详情</value>
        [DataMember(Name = "real_shop_fail_infos", EmitDefaultValue = false)]
        public List<OrderVoucherRealShopFailInfo> RealShopFailInfos { get; set; }

        /// <summary>
        /// 请求失败的支付宝门店详情。
        /// </summary>
        /// <value>请求失败的支付宝门店详情。</value>
        [DataMember(Name = "shop_fail_infos", EmitDefaultValue = false)]
        public List<OrderVoucherShopFailInfo> ShopFailInfos { get; set; }

        /// <summary>
        /// 请求成功的代运营商业关系门店
        /// </summary>
        /// <value>请求成功的代运营商业关系门店</value>
        [DataMember(Name = "success_real_shop_ids", EmitDefaultValue = false)]
        public List<string> SuccessRealShopIds { get; set; }

        /// <summary>
        /// 请求成功的支付宝门店。
        /// </summary>
        /// <value>请求成功的支付宝门店。</value>
        [DataMember(Name = "success_shop_ids", EmitDefaultValue = false)]
        public List<string> SuccessShopIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderVoucherAvailableShopResult {\n");
            sb.Append("  OrderVoucherMerchantAllShopResult: ").Append(OrderVoucherMerchantAllShopResult).Append("\n");
            sb.Append("  RealShopFailInfos: ").Append(RealShopFailInfos).Append("\n");
            sb.Append("  ShopFailInfos: ").Append(ShopFailInfos).Append("\n");
            sb.Append("  SuccessRealShopIds: ").Append(SuccessRealShopIds).Append("\n");
            sb.Append("  SuccessShopIds: ").Append(SuccessShopIds).Append("\n");
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
            return this.Equals(input as OrderVoucherAvailableShopResult);
        }

        /// <summary>
        /// Returns true if OrderVoucherAvailableShopResult instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderVoucherAvailableShopResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderVoucherAvailableShopResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OrderVoucherMerchantAllShopResult == input.OrderVoucherMerchantAllShopResult ||
                    (this.OrderVoucherMerchantAllShopResult != null &&
                    this.OrderVoucherMerchantAllShopResult.Equals(input.OrderVoucherMerchantAllShopResult))
                ) && 
                (
                    this.RealShopFailInfos == input.RealShopFailInfos ||
                    this.RealShopFailInfos != null &&
                    input.RealShopFailInfos != null &&
                    this.RealShopFailInfos.SequenceEqual(input.RealShopFailInfos)
                ) && 
                (
                    this.ShopFailInfos == input.ShopFailInfos ||
                    this.ShopFailInfos != null &&
                    input.ShopFailInfos != null &&
                    this.ShopFailInfos.SequenceEqual(input.ShopFailInfos)
                ) && 
                (
                    this.SuccessRealShopIds == input.SuccessRealShopIds ||
                    this.SuccessRealShopIds != null &&
                    input.SuccessRealShopIds != null &&
                    this.SuccessRealShopIds.SequenceEqual(input.SuccessRealShopIds)
                ) && 
                (
                    this.SuccessShopIds == input.SuccessShopIds ||
                    this.SuccessShopIds != null &&
                    input.SuccessShopIds != null &&
                    this.SuccessShopIds.SequenceEqual(input.SuccessShopIds)
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
                if (this.OrderVoucherMerchantAllShopResult != null)
                {
                    hashCode = (hashCode * 59) + this.OrderVoucherMerchantAllShopResult.GetHashCode();
                }
                if (this.RealShopFailInfos != null)
                {
                    hashCode = (hashCode * 59) + this.RealShopFailInfos.GetHashCode();
                }
                if (this.ShopFailInfos != null)
                {
                    hashCode = (hashCode * 59) + this.ShopFailInfos.GetHashCode();
                }
                if (this.SuccessRealShopIds != null)
                {
                    hashCode = (hashCode * 59) + this.SuccessRealShopIds.GetHashCode();
                }
                if (this.SuccessShopIds != null)
                {
                    hashCode = (hashCode * 59) + this.SuccessShopIds.GetHashCode();
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
