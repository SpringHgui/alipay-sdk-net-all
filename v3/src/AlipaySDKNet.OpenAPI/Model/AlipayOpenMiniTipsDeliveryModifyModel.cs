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
    /// AlipayOpenMiniTipsDeliveryModifyModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniTipsDeliveryModifyModel")]
    public partial class AlipayOpenMiniTipsDeliveryModifyModel : IEquatable<AlipayOpenMiniTipsDeliveryModifyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniTipsDeliveryModifyModel" /> class.
        /// </summary>
        /// <param name="deliveryId">收藏引导投放活动ID.</param>
        /// <param name="operateType">活动投放操作类型.</param>
        public AlipayOpenMiniTipsDeliveryModifyModel(string deliveryId = default(string), string operateType = default(string))
        {
            this.DeliveryId = deliveryId;
            this.OperateType = operateType;
        }

        /// <summary>
        /// 收藏引导投放活动ID
        /// </summary>
        /// <value>收藏引导投放活动ID</value>
        [DataMember(Name = "delivery_id", EmitDefaultValue = false)]
        public string DeliveryId { get; set; }

        /// <summary>
        /// 活动投放操作类型
        /// </summary>
        /// <value>活动投放操作类型</value>
        [DataMember(Name = "operate_type", EmitDefaultValue = false)]
        public string OperateType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniTipsDeliveryModifyModel {\n");
            sb.Append("  DeliveryId: ").Append(DeliveryId).Append("\n");
            sb.Append("  OperateType: ").Append(OperateType).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniTipsDeliveryModifyModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniTipsDeliveryModifyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniTipsDeliveryModifyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniTipsDeliveryModifyModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DeliveryId == input.DeliveryId ||
                    (this.DeliveryId != null &&
                    this.DeliveryId.Equals(input.DeliveryId))
                ) && 
                (
                    this.OperateType == input.OperateType ||
                    (this.OperateType != null &&
                    this.OperateType.Equals(input.OperateType))
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
                if (this.DeliveryId != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryId.GetHashCode();
                }
                if (this.OperateType != null)
                {
                    hashCode = (hashCode * 59) + this.OperateType.GetHashCode();
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
