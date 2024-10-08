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
    /// AppItemInfo
    /// </summary>
    [DataContract(Name = "AppItemInfo")]
    public partial class AppItemInfo : IEquatable<AppItemInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppItemInfo" /> class.
        /// </summary>
        /// <param name="itemId">小程序商品-支付宝内部商品id.</param>
        /// <param name="itemUseType">商品可用类型.</param>
        /// <param name="miniAppId">小程序id.</param>
        /// <param name="outItemId">外部商品ID.</param>
        public AppItemInfo(string itemId = default(string), string itemUseType = default(string), string miniAppId = default(string), string outItemId = default(string))
        {
            this.ItemId = itemId;
            this.ItemUseType = itemUseType;
            this.MiniAppId = miniAppId;
            this.OutItemId = outItemId;
        }

        /// <summary>
        /// 小程序商品-支付宝内部商品id
        /// </summary>
        /// <value>小程序商品-支付宝内部商品id</value>
        [DataMember(Name = "item_id", EmitDefaultValue = false)]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品可用类型
        /// </summary>
        /// <value>商品可用类型</value>
        [DataMember(Name = "item_use_type", EmitDefaultValue = false)]
        public string ItemUseType { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        /// <value>小程序id</value>
        [DataMember(Name = "mini_app_id", EmitDefaultValue = false)]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 外部商品ID
        /// </summary>
        /// <value>外部商品ID</value>
        [DataMember(Name = "out_item_id", EmitDefaultValue = false)]
        public string OutItemId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AppItemInfo {\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  ItemUseType: ").Append(ItemUseType).Append("\n");
            sb.Append("  MiniAppId: ").Append(MiniAppId).Append("\n");
            sb.Append("  OutItemId: ").Append(OutItemId).Append("\n");
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
            return this.Equals(input as AppItemInfo);
        }

        /// <summary>
        /// Returns true if AppItemInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of AppItemInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppItemInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ItemId == input.ItemId ||
                    (this.ItemId != null &&
                    this.ItemId.Equals(input.ItemId))
                ) && 
                (
                    this.ItemUseType == input.ItemUseType ||
                    (this.ItemUseType != null &&
                    this.ItemUseType.Equals(input.ItemUseType))
                ) && 
                (
                    this.MiniAppId == input.MiniAppId ||
                    (this.MiniAppId != null &&
                    this.MiniAppId.Equals(input.MiniAppId))
                ) && 
                (
                    this.OutItemId == input.OutItemId ||
                    (this.OutItemId != null &&
                    this.OutItemId.Equals(input.OutItemId))
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
                if (this.ItemId != null)
                {
                    hashCode = (hashCode * 59) + this.ItemId.GetHashCode();
                }
                if (this.ItemUseType != null)
                {
                    hashCode = (hashCode * 59) + this.ItemUseType.GetHashCode();
                }
                if (this.MiniAppId != null)
                {
                    hashCode = (hashCode * 59) + this.MiniAppId.GetHashCode();
                }
                if (this.OutItemId != null)
                {
                    hashCode = (hashCode * 59) + this.OutItemId.GetHashCode();
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
