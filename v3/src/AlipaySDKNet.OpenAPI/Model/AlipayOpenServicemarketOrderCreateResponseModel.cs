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
    /// AlipayOpenServicemarketOrderCreateResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenServicemarketOrderCreateResponseModel")]
    public partial class AlipayOpenServicemarketOrderCreateResponseModel : IEquatable<AlipayOpenServicemarketOrderCreateResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenServicemarketOrderCreateResponseModel" /> class.
        /// </summary>
        /// <param name="commodityOrderId">订单号.</param>
        /// <param name="miniAppId">支付宝分配给开发者的应用ID.</param>
        public AlipayOpenServicemarketOrderCreateResponseModel(string commodityOrderId = default(string), string miniAppId = default(string))
        {
            this.CommodityOrderId = commodityOrderId;
            this.MiniAppId = miniAppId;
        }

        /// <summary>
        /// 订单号
        /// </summary>
        /// <value>订单号</value>
        [DataMember(Name = "commodity_order_id", EmitDefaultValue = false)]
        public string CommodityOrderId { get; set; }

        /// <summary>
        /// 支付宝分配给开发者的应用ID
        /// </summary>
        /// <value>支付宝分配给开发者的应用ID</value>
        [DataMember(Name = "mini_app_id", EmitDefaultValue = false)]
        public string MiniAppId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenServicemarketOrderCreateResponseModel {\n");
            sb.Append("  CommodityOrderId: ").Append(CommodityOrderId).Append("\n");
            sb.Append("  MiniAppId: ").Append(MiniAppId).Append("\n");
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
            return this.Equals(input as AlipayOpenServicemarketOrderCreateResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenServicemarketOrderCreateResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenServicemarketOrderCreateResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenServicemarketOrderCreateResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CommodityOrderId == input.CommodityOrderId ||
                    (this.CommodityOrderId != null &&
                    this.CommodityOrderId.Equals(input.CommodityOrderId))
                ) && 
                (
                    this.MiniAppId == input.MiniAppId ||
                    (this.MiniAppId != null &&
                    this.MiniAppId.Equals(input.MiniAppId))
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
                if (this.CommodityOrderId != null)
                {
                    hashCode = (hashCode * 59) + this.CommodityOrderId.GetHashCode();
                }
                if (this.MiniAppId != null)
                {
                    hashCode = (hashCode * 59) + this.MiniAppId.GetHashCode();
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
