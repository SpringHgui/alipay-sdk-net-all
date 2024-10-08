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
    /// VoucherFailShopInfo
    /// </summary>
    [DataContract(Name = "VoucherFailShopInfo")]
    public partial class VoucherFailShopInfo : IEquatable<VoucherFailShopInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherFailShopInfo" /> class.
        /// </summary>
        /// <param name="failMessage">请求失败提示信息。.</param>
        /// <param name="failReasons">请求失败的原因。.</param>
        /// <param name="realShopId">请求失败的物理门店 id。.</param>
        /// <param name="shopId">支付宝侧蚂蚁店铺 id。.</param>
        public VoucherFailShopInfo(string failMessage = default(string), List<string> failReasons = default(List<string>), string realShopId = default(string), string shopId = default(string))
        {
            this.FailMessage = failMessage;
            this.FailReasons = failReasons;
            this.RealShopId = realShopId;
            this.ShopId = shopId;
        }

        /// <summary>
        /// 请求失败提示信息。
        /// </summary>
        /// <value>请求失败提示信息。</value>
        [DataMember(Name = "fail_message", EmitDefaultValue = false)]
        public string FailMessage { get; set; }

        /// <summary>
        /// 请求失败的原因。
        /// </summary>
        /// <value>请求失败的原因。</value>
        [DataMember(Name = "fail_reasons", EmitDefaultValue = false)]
        public List<string> FailReasons { get; set; }

        /// <summary>
        /// 请求失败的物理门店 id。
        /// </summary>
        /// <value>请求失败的物理门店 id。</value>
        [DataMember(Name = "real_shop_id", EmitDefaultValue = false)]
        public string RealShopId { get; set; }

        /// <summary>
        /// 支付宝侧蚂蚁店铺 id。
        /// </summary>
        /// <value>支付宝侧蚂蚁店铺 id。</value>
        [DataMember(Name = "shop_id", EmitDefaultValue = false)]
        public string ShopId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoucherFailShopInfo {\n");
            sb.Append("  FailMessage: ").Append(FailMessage).Append("\n");
            sb.Append("  FailReasons: ").Append(FailReasons).Append("\n");
            sb.Append("  RealShopId: ").Append(RealShopId).Append("\n");
            sb.Append("  ShopId: ").Append(ShopId).Append("\n");
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
            return this.Equals(input as VoucherFailShopInfo);
        }

        /// <summary>
        /// Returns true if VoucherFailShopInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VoucherFailShopInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoucherFailShopInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FailMessage == input.FailMessage ||
                    (this.FailMessage != null &&
                    this.FailMessage.Equals(input.FailMessage))
                ) && 
                (
                    this.FailReasons == input.FailReasons ||
                    this.FailReasons != null &&
                    input.FailReasons != null &&
                    this.FailReasons.SequenceEqual(input.FailReasons)
                ) && 
                (
                    this.RealShopId == input.RealShopId ||
                    (this.RealShopId != null &&
                    this.RealShopId.Equals(input.RealShopId))
                ) && 
                (
                    this.ShopId == input.ShopId ||
                    (this.ShopId != null &&
                    this.ShopId.Equals(input.ShopId))
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
                if (this.FailMessage != null)
                {
                    hashCode = (hashCode * 59) + this.FailMessage.GetHashCode();
                }
                if (this.FailReasons != null)
                {
                    hashCode = (hashCode * 59) + this.FailReasons.GetHashCode();
                }
                if (this.RealShopId != null)
                {
                    hashCode = (hashCode * 59) + this.RealShopId.GetHashCode();
                }
                if (this.ShopId != null)
                {
                    hashCode = (hashCode * 59) + this.ShopId.GetHashCode();
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
