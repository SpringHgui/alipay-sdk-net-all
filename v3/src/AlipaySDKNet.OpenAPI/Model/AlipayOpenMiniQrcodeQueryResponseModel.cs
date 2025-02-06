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
    /// AlipayOpenMiniQrcodeQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniQrcodeQueryResponseModel")]
    public partial class AlipayOpenMiniQrcodeQueryResponseModel : IEquatable<AlipayOpenMiniQrcodeQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniQrcodeQueryResponseModel" /> class.
        /// </summary>
        /// <param name="qrCodeRouteGroups">规则路由数据列表.</param>
        /// <param name="totalItems">数据总数.</param>
        public AlipayOpenMiniQrcodeQueryResponseModel(List<QrCodeRouteGroup> qrCodeRouteGroups = default(List<QrCodeRouteGroup>), int totalItems = default(int))
        {
            this.QrCodeRouteGroups = qrCodeRouteGroups;
            this.TotalItems = totalItems;
        }

        /// <summary>
        /// 规则路由数据列表
        /// </summary>
        /// <value>规则路由数据列表</value>
        [DataMember(Name = "qr_code_route_groups", EmitDefaultValue = false)]
        public List<QrCodeRouteGroup> QrCodeRouteGroups { get; set; }

        /// <summary>
        /// 数据总数
        /// </summary>
        /// <value>数据总数</value>
        [DataMember(Name = "total_items", EmitDefaultValue = false)]
        public int TotalItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniQrcodeQueryResponseModel {\n");
            sb.Append("  QrCodeRouteGroups: ").Append(QrCodeRouteGroups).Append("\n");
            sb.Append("  TotalItems: ").Append(TotalItems).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniQrcodeQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniQrcodeQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniQrcodeQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniQrcodeQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.QrCodeRouteGroups == input.QrCodeRouteGroups ||
                    this.QrCodeRouteGroups != null &&
                    input.QrCodeRouteGroups != null &&
                    this.QrCodeRouteGroups.SequenceEqual(input.QrCodeRouteGroups)
                ) && 
                (
                    this.TotalItems == input.TotalItems ||
                    this.TotalItems.Equals(input.TotalItems)
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
                if (this.QrCodeRouteGroups != null)
                {
                    hashCode = (hashCode * 59) + this.QrCodeRouteGroups.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalItems.GetHashCode();
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
