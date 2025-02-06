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
    /// DeliveryBaseInfo
    /// </summary>
    [DataContract(Name = "DeliveryBaseInfo")]
    public partial class DeliveryBaseInfo : IEquatable<DeliveryBaseInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryBaseInfo" /> class.
        /// </summary>
        /// <param name="deliveryBeginTime">投放计划开始时间。 格式为：yyyy-MM-dd HH:mm:ss。.</param>
        /// <param name="deliveryEndTime">投放计划结束时间。 格式为：yyyy-MM-dd HH:mm:ss。.</param>
        /// <param name="deliveryMaterial">deliveryMaterial.</param>
        /// <param name="deliveryName">投放计划名称。 投放计划名称不会对用户进行表达，只用于商户管理使用。长度需要大于等于3，小于20。.</param>
        public DeliveryBaseInfo(string deliveryBeginTime = default(string), string deliveryEndTime = default(string), DeliveryMaterial deliveryMaterial = default(DeliveryMaterial), string deliveryName = default(string))
        {
            this.DeliveryBeginTime = deliveryBeginTime;
            this.DeliveryEndTime = deliveryEndTime;
            this.DeliveryMaterial = deliveryMaterial;
            this.DeliveryName = deliveryName;
        }

        /// <summary>
        /// 投放计划开始时间。 格式为：yyyy-MM-dd HH:mm:ss。
        /// </summary>
        /// <value>投放计划开始时间。 格式为：yyyy-MM-dd HH:mm:ss。</value>
        [DataMember(Name = "delivery_begin_time", EmitDefaultValue = false)]
        public string DeliveryBeginTime { get; set; }

        /// <summary>
        /// 投放计划结束时间。 格式为：yyyy-MM-dd HH:mm:ss。
        /// </summary>
        /// <value>投放计划结束时间。 格式为：yyyy-MM-dd HH:mm:ss。</value>
        [DataMember(Name = "delivery_end_time", EmitDefaultValue = false)]
        public string DeliveryEndTime { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryMaterial
        /// </summary>
        [DataMember(Name = "delivery_material", EmitDefaultValue = false)]
        public DeliveryMaterial DeliveryMaterial { get; set; }

        /// <summary>
        /// 投放计划名称。 投放计划名称不会对用户进行表达，只用于商户管理使用。长度需要大于等于3，小于20。
        /// </summary>
        /// <value>投放计划名称。 投放计划名称不会对用户进行表达，只用于商户管理使用。长度需要大于等于3，小于20。</value>
        [DataMember(Name = "delivery_name", EmitDefaultValue = false)]
        public string DeliveryName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeliveryBaseInfo {\n");
            sb.Append("  DeliveryBeginTime: ").Append(DeliveryBeginTime).Append("\n");
            sb.Append("  DeliveryEndTime: ").Append(DeliveryEndTime).Append("\n");
            sb.Append("  DeliveryMaterial: ").Append(DeliveryMaterial).Append("\n");
            sb.Append("  DeliveryName: ").Append(DeliveryName).Append("\n");
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
            return this.Equals(input as DeliveryBaseInfo);
        }

        /// <summary>
        /// Returns true if DeliveryBaseInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of DeliveryBaseInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeliveryBaseInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DeliveryBeginTime == input.DeliveryBeginTime ||
                    (this.DeliveryBeginTime != null &&
                    this.DeliveryBeginTime.Equals(input.DeliveryBeginTime))
                ) && 
                (
                    this.DeliveryEndTime == input.DeliveryEndTime ||
                    (this.DeliveryEndTime != null &&
                    this.DeliveryEndTime.Equals(input.DeliveryEndTime))
                ) && 
                (
                    this.DeliveryMaterial == input.DeliveryMaterial ||
                    (this.DeliveryMaterial != null &&
                    this.DeliveryMaterial.Equals(input.DeliveryMaterial))
                ) && 
                (
                    this.DeliveryName == input.DeliveryName ||
                    (this.DeliveryName != null &&
                    this.DeliveryName.Equals(input.DeliveryName))
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
                if (this.DeliveryBeginTime != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryBeginTime.GetHashCode();
                }
                if (this.DeliveryEndTime != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryEndTime.GetHashCode();
                }
                if (this.DeliveryMaterial != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryMaterial.GetHashCode();
                }
                if (this.DeliveryName != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryName.GetHashCode();
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
