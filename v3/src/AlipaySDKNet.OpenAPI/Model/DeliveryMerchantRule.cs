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
    /// DeliveryMerchantRule
    /// </summary>
    [DataContract(Name = "DeliveryMerchantRule")]
    public partial class DeliveryMerchantRule : IEquatable<DeliveryMerchantRule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryMerchantRule" /> class.
        /// </summary>
        /// <param name="brandIdList">指定品牌id。 说明：如商户需选择某个品牌下维护的收款账号，请上传相关品牌id.</param>
        /// <param name="deliveryMerchantInfos">曝光商户选取列表。 说明：需要传入您期望曝光的商户的商户号，传入为空时默认使用投放优惠券活动的适用范围。 限制：曝光商户号需与投放归属商户号相同，或传入有跨主体授权关系的商户号或有弱绑定关系的M3账号.</param>
        /// <param name="deliveryMerchantMode">指定支付成功页模式。.</param>
        public DeliveryMerchantRule(List<string> brandIdList = default(List<string>), List<DeliveryMerchantInfo> deliveryMerchantInfos = default(List<DeliveryMerchantInfo>), string deliveryMerchantMode = default(string))
        {
            this.BrandIdList = brandIdList;
            this.DeliveryMerchantInfos = deliveryMerchantInfos;
            this.DeliveryMerchantMode = deliveryMerchantMode;
        }

        /// <summary>
        /// 指定品牌id。 说明：如商户需选择某个品牌下维护的收款账号，请上传相关品牌id
        /// </summary>
        /// <value>指定品牌id。 说明：如商户需选择某个品牌下维护的收款账号，请上传相关品牌id</value>
        [DataMember(Name = "brand_id_list", EmitDefaultValue = false)]
        public List<string> BrandIdList { get; set; }

        /// <summary>
        /// 曝光商户选取列表。 说明：需要传入您期望曝光的商户的商户号，传入为空时默认使用投放优惠券活动的适用范围。 限制：曝光商户号需与投放归属商户号相同，或传入有跨主体授权关系的商户号或有弱绑定关系的M3账号
        /// </summary>
        /// <value>曝光商户选取列表。 说明：需要传入您期望曝光的商户的商户号，传入为空时默认使用投放优惠券活动的适用范围。 限制：曝光商户号需与投放归属商户号相同，或传入有跨主体授权关系的商户号或有弱绑定关系的M3账号</value>
        [DataMember(Name = "delivery_merchant_infos", EmitDefaultValue = false)]
        public List<DeliveryMerchantInfo> DeliveryMerchantInfos { get; set; }

        /// <summary>
        /// 指定支付成功页模式。
        /// </summary>
        /// <value>指定支付成功页模式。</value>
        [DataMember(Name = "delivery_merchant_mode", EmitDefaultValue = false)]
        public string DeliveryMerchantMode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeliveryMerchantRule {\n");
            sb.Append("  BrandIdList: ").Append(BrandIdList).Append("\n");
            sb.Append("  DeliveryMerchantInfos: ").Append(DeliveryMerchantInfos).Append("\n");
            sb.Append("  DeliveryMerchantMode: ").Append(DeliveryMerchantMode).Append("\n");
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
            return this.Equals(input as DeliveryMerchantRule);
        }

        /// <summary>
        /// Returns true if DeliveryMerchantRule instances are equal
        /// </summary>
        /// <param name="input">Instance of DeliveryMerchantRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeliveryMerchantRule input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BrandIdList == input.BrandIdList ||
                    this.BrandIdList != null &&
                    input.BrandIdList != null &&
                    this.BrandIdList.SequenceEqual(input.BrandIdList)
                ) && 
                (
                    this.DeliveryMerchantInfos == input.DeliveryMerchantInfos ||
                    this.DeliveryMerchantInfos != null &&
                    input.DeliveryMerchantInfos != null &&
                    this.DeliveryMerchantInfos.SequenceEqual(input.DeliveryMerchantInfos)
                ) && 
                (
                    this.DeliveryMerchantMode == input.DeliveryMerchantMode ||
                    (this.DeliveryMerchantMode != null &&
                    this.DeliveryMerchantMode.Equals(input.DeliveryMerchantMode))
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
                if (this.BrandIdList != null)
                {
                    hashCode = (hashCode * 59) + this.BrandIdList.GetHashCode();
                }
                if (this.DeliveryMerchantInfos != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryMerchantInfos.GetHashCode();
                }
                if (this.DeliveryMerchantMode != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryMerchantMode.GetHashCode();
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
