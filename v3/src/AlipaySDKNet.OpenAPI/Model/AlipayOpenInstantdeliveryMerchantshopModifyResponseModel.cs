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
    /// AlipayOpenInstantdeliveryMerchantshopModifyResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenInstantdeliveryMerchantshopModifyResponseModel")]
    public partial class AlipayOpenInstantdeliveryMerchantshopModifyResponseModel : IEquatable<AlipayOpenInstantdeliveryMerchantshopModifyResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenInstantdeliveryMerchantshopModifyResponseModel" /> class.
        /// </summary>
        /// <param name="logisticsShopStatus">门店创建返回的结果.</param>
        public AlipayOpenInstantdeliveryMerchantshopModifyResponseModel(List<LogisticsShopStatusDTO> logisticsShopStatus = default(List<LogisticsShopStatusDTO>))
        {
            this.LogisticsShopStatus = logisticsShopStatus;
        }

        /// <summary>
        /// 门店创建返回的结果
        /// </summary>
        /// <value>门店创建返回的结果</value>
        [DataMember(Name = "logistics_shop_status", EmitDefaultValue = false)]
        public List<LogisticsShopStatusDTO> LogisticsShopStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenInstantdeliveryMerchantshopModifyResponseModel {\n");
            sb.Append("  LogisticsShopStatus: ").Append(LogisticsShopStatus).Append("\n");
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
            return this.Equals(input as AlipayOpenInstantdeliveryMerchantshopModifyResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenInstantdeliveryMerchantshopModifyResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenInstantdeliveryMerchantshopModifyResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenInstantdeliveryMerchantshopModifyResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LogisticsShopStatus == input.LogisticsShopStatus ||
                    this.LogisticsShopStatus != null &&
                    input.LogisticsShopStatus != null &&
                    this.LogisticsShopStatus.SequenceEqual(input.LogisticsShopStatus)
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
                if (this.LogisticsShopStatus != null)
                {
                    hashCode = (hashCode * 59) + this.LogisticsShopStatus.GetHashCode();
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
