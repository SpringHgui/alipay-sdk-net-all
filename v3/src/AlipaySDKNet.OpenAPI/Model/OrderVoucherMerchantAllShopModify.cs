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
    /// OrderVoucherMerchantAllShopModify
    /// </summary>
    [DataContract(Name = "OrderVoucherMerchantAllShopModify")]
    public partial class OrderVoucherMerchantAllShopModify : IEquatable<OrderVoucherMerchantAllShopModify>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderVoucherMerchantAllShopModify" /> class.
        /// </summary>
        /// <param name="excludeShopIds">券不可使用的门店列表。列表中的门店id是通过调用接口ant.merchant.expand.shop.create创建门店返回的支付宝门店id 接口参数是列表类型。 接口参数是列表类型。.</param>
        public OrderVoucherMerchantAllShopModify(List<string> excludeShopIds = default(List<string>))
        {
            this.ExcludeShopIds = excludeShopIds;
        }

        /// <summary>
        /// 券不可使用的门店列表。列表中的门店id是通过调用接口ant.merchant.expand.shop.create创建门店返回的支付宝门店id 接口参数是列表类型。 接口参数是列表类型。
        /// </summary>
        /// <value>券不可使用的门店列表。列表中的门店id是通过调用接口ant.merchant.expand.shop.create创建门店返回的支付宝门店id 接口参数是列表类型。 接口参数是列表类型。</value>
        [DataMember(Name = "exclude_shop_ids", EmitDefaultValue = false)]
        public List<string> ExcludeShopIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderVoucherMerchantAllShopModify {\n");
            sb.Append("  ExcludeShopIds: ").Append(ExcludeShopIds).Append("\n");
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
            return this.Equals(input as OrderVoucherMerchantAllShopModify);
        }

        /// <summary>
        /// Returns true if OrderVoucherMerchantAllShopModify instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderVoucherMerchantAllShopModify to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderVoucherMerchantAllShopModify input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ExcludeShopIds == input.ExcludeShopIds ||
                    this.ExcludeShopIds != null &&
                    input.ExcludeShopIds != null &&
                    this.ExcludeShopIds.SequenceEqual(input.ExcludeShopIds)
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
                if (this.ExcludeShopIds != null)
                {
                    hashCode = (hashCode * 59) + this.ExcludeShopIds.GetHashCode();
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
