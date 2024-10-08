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
    /// AlipayOpenServicemarketCommodityShopOnlineModel
    /// </summary>
    [DataContract(Name = "AlipayOpenServicemarketCommodityShopOnlineModel")]
    public partial class AlipayOpenServicemarketCommodityShopOnlineModel : IEquatable<AlipayOpenServicemarketCommodityShopOnlineModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenServicemarketCommodityShopOnlineModel" /> class.
        /// </summary>
        /// <param name="commodityId">服务插件ID.</param>
        /// <param name="shopId">店铺ID.</param>
        public AlipayOpenServicemarketCommodityShopOnlineModel(string commodityId = default(string), string shopId = default(string))
        {
            this.CommodityId = commodityId;
            this.ShopId = shopId;
        }

        /// <summary>
        /// 服务插件ID
        /// </summary>
        /// <value>服务插件ID</value>
        [DataMember(Name = "commodity_id", EmitDefaultValue = false)]
        public string CommodityId { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        /// <value>店铺ID</value>
        [DataMember(Name = "shop_id", EmitDefaultValue = false)]
        public string ShopId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenServicemarketCommodityShopOnlineModel {\n");
            sb.Append("  CommodityId: ").Append(CommodityId).Append("\n");
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
            return this.Equals(input as AlipayOpenServicemarketCommodityShopOnlineModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenServicemarketCommodityShopOnlineModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenServicemarketCommodityShopOnlineModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenServicemarketCommodityShopOnlineModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CommodityId == input.CommodityId ||
                    (this.CommodityId != null &&
                    this.CommodityId.Equals(input.CommodityId))
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
                if (this.CommodityId != null)
                {
                    hashCode = (hashCode * 59) + this.CommodityId.GetHashCode();
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
