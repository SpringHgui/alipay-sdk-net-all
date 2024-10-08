/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2024-10-08
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
    /// OrderVoucherMerchantAllShopResult
    /// </summary>
    [DataContract(Name = "OrderVoucherMerchantAllShopResult")]
    public partial class OrderVoucherMerchantAllShopResult : IEquatable<OrderVoucherMerchantAllShopResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderVoucherMerchantAllShopResult" /> class.
        /// </summary>
        /// <param name="excludeShopFailInfos">请求失败的不可用门店详情。.</param>
        /// <param name="successExcludeShopIds">请求成功的不可用门店列表。.</param>
        public OrderVoucherMerchantAllShopResult(List<OrderVoucherShopFailInfo> excludeShopFailInfos = default(List<OrderVoucherShopFailInfo>), List<string> successExcludeShopIds = default(List<string>))
        {
            this.ExcludeShopFailInfos = excludeShopFailInfos;
            this.SuccessExcludeShopIds = successExcludeShopIds;
        }

        /// <summary>
        /// 请求失败的不可用门店详情。
        /// </summary>
        /// <value>请求失败的不可用门店详情。</value>
        [DataMember(Name = "exclude_shop_fail_infos", EmitDefaultValue = false)]
        public List<OrderVoucherShopFailInfo> ExcludeShopFailInfos { get; set; }

        /// <summary>
        /// 请求成功的不可用门店列表。
        /// </summary>
        /// <value>请求成功的不可用门店列表。</value>
        [DataMember(Name = "success_exclude_shop_ids", EmitDefaultValue = false)]
        public List<string> SuccessExcludeShopIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderVoucherMerchantAllShopResult {\n");
            sb.Append("  ExcludeShopFailInfos: ").Append(ExcludeShopFailInfos).Append("\n");
            sb.Append("  SuccessExcludeShopIds: ").Append(SuccessExcludeShopIds).Append("\n");
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
            return this.Equals(input as OrderVoucherMerchantAllShopResult);
        }

        /// <summary>
        /// Returns true if OrderVoucherMerchantAllShopResult instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderVoucherMerchantAllShopResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderVoucherMerchantAllShopResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ExcludeShopFailInfos == input.ExcludeShopFailInfos ||
                    this.ExcludeShopFailInfos != null &&
                    input.ExcludeShopFailInfos != null &&
                    this.ExcludeShopFailInfos.SequenceEqual(input.ExcludeShopFailInfos)
                ) && 
                (
                    this.SuccessExcludeShopIds == input.SuccessExcludeShopIds ||
                    this.SuccessExcludeShopIds != null &&
                    input.SuccessExcludeShopIds != null &&
                    this.SuccessExcludeShopIds.SequenceEqual(input.SuccessExcludeShopIds)
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
                if (this.ExcludeShopFailInfos != null)
                {
                    hashCode = (hashCode * 59) + this.ExcludeShopFailInfos.GetHashCode();
                }
                if (this.SuccessExcludeShopIds != null)
                {
                    hashCode = (hashCode * 59) + this.SuccessExcludeShopIds.GetHashCode();
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
