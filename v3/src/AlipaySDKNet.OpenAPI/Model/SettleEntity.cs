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
    /// SettleEntity
    /// </summary>
    [DataContract(Name = "SettleEntity")]
    public partial class SettleEntity : IEquatable<SettleEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SettleEntity" /> class.
        /// </summary>
        /// <param name="settleEntityId">结算主体账号 当结算主体类型为SecondMerchant，本参数为二级商户的SecondMerchantID；当结算主体类型为MerchantStore，本参数为商户门店ID。.</param>
        /// <param name="settleEntityType">结算主体类型 SecondMerchant：结算主体为二级商户；MerchantStore：结算主体为商户门店.</param>
        public SettleEntity(string settleEntityId = default(string), string settleEntityType = default(string))
        {
            this.SettleEntityId = settleEntityId;
            this.SettleEntityType = settleEntityType;
        }

        /// <summary>
        /// 结算主体账号 当结算主体类型为SecondMerchant，本参数为二级商户的SecondMerchantID；当结算主体类型为MerchantStore，本参数为商户门店ID。
        /// </summary>
        /// <value>结算主体账号 当结算主体类型为SecondMerchant，本参数为二级商户的SecondMerchantID；当结算主体类型为MerchantStore，本参数为商户门店ID。</value>
        [DataMember(Name = "settle_entity_id", EmitDefaultValue = false)]
        public string SettleEntityId { get; set; }

        /// <summary>
        /// 结算主体类型 SecondMerchant：结算主体为二级商户；MerchantStore：结算主体为商户门店
        /// </summary>
        /// <value>结算主体类型 SecondMerchant：结算主体为二级商户；MerchantStore：结算主体为商户门店</value>
        [DataMember(Name = "settle_entity_type", EmitDefaultValue = false)]
        public string SettleEntityType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SettleEntity {\n");
            sb.Append("  SettleEntityId: ").Append(SettleEntityId).Append("\n");
            sb.Append("  SettleEntityType: ").Append(SettleEntityType).Append("\n");
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
            return this.Equals(input as SettleEntity);
        }

        /// <summary>
        /// Returns true if SettleEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of SettleEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SettleEntity input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SettleEntityId == input.SettleEntityId ||
                    (this.SettleEntityId != null &&
                    this.SettleEntityId.Equals(input.SettleEntityId))
                ) && 
                (
                    this.SettleEntityType == input.SettleEntityType ||
                    (this.SettleEntityType != null &&
                    this.SettleEntityType.Equals(input.SettleEntityType))
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
                if (this.SettleEntityId != null)
                {
                    hashCode = (hashCode * 59) + this.SettleEntityId.GetHashCode();
                }
                if (this.SettleEntityType != null)
                {
                    hashCode = (hashCode * 59) + this.SettleEntityType.GetHashCode();
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
