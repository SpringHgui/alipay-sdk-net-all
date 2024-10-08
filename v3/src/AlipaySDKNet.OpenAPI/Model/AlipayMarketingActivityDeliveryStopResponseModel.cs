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
    /// AlipayMarketingActivityDeliveryStopResponseModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingActivityDeliveryStopResponseModel")]
    public partial class AlipayMarketingActivityDeliveryStopResponseModel : IEquatable<AlipayMarketingActivityDeliveryStopResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingActivityDeliveryStopResponseModel" /> class.
        /// </summary>
        /// <param name="deliveryId">推广计划id。.</param>
        /// <param name="errorDeliveryConfigList">停止失败的投放配置列表.</param>
        /// <param name="successDeliveryConfigList">停止成功的投放配置列表.</param>
        public AlipayMarketingActivityDeliveryStopResponseModel(string deliveryId = default(string), List<ErrorDeliveryConfig> errorDeliveryConfigList = default(List<ErrorDeliveryConfig>), List<SuccessDeliveryConfig> successDeliveryConfigList = default(List<SuccessDeliveryConfig>))
        {
            this.DeliveryId = deliveryId;
            this.ErrorDeliveryConfigList = errorDeliveryConfigList;
            this.SuccessDeliveryConfigList = successDeliveryConfigList;
        }

        /// <summary>
        /// 推广计划id。
        /// </summary>
        /// <value>推广计划id。</value>
        [DataMember(Name = "delivery_id", EmitDefaultValue = false)]
        public string DeliveryId { get; set; }

        /// <summary>
        /// 停止失败的投放配置列表
        /// </summary>
        /// <value>停止失败的投放配置列表</value>
        [DataMember(Name = "error_delivery_config_list", EmitDefaultValue = false)]
        public List<ErrorDeliveryConfig> ErrorDeliveryConfigList { get; set; }

        /// <summary>
        /// 停止成功的投放配置列表
        /// </summary>
        /// <value>停止成功的投放配置列表</value>
        [DataMember(Name = "success_delivery_config_list", EmitDefaultValue = false)]
        public List<SuccessDeliveryConfig> SuccessDeliveryConfigList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingActivityDeliveryStopResponseModel {\n");
            sb.Append("  DeliveryId: ").Append(DeliveryId).Append("\n");
            sb.Append("  ErrorDeliveryConfigList: ").Append(ErrorDeliveryConfigList).Append("\n");
            sb.Append("  SuccessDeliveryConfigList: ").Append(SuccessDeliveryConfigList).Append("\n");
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
            return this.Equals(input as AlipayMarketingActivityDeliveryStopResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingActivityDeliveryStopResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingActivityDeliveryStopResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingActivityDeliveryStopResponseModel input)
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
                    this.ErrorDeliveryConfigList == input.ErrorDeliveryConfigList ||
                    this.ErrorDeliveryConfigList != null &&
                    input.ErrorDeliveryConfigList != null &&
                    this.ErrorDeliveryConfigList.SequenceEqual(input.ErrorDeliveryConfigList)
                ) && 
                (
                    this.SuccessDeliveryConfigList == input.SuccessDeliveryConfigList ||
                    this.SuccessDeliveryConfigList != null &&
                    input.SuccessDeliveryConfigList != null &&
                    this.SuccessDeliveryConfigList.SequenceEqual(input.SuccessDeliveryConfigList)
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
                if (this.ErrorDeliveryConfigList != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorDeliveryConfigList.GetHashCode();
                }
                if (this.SuccessDeliveryConfigList != null)
                {
                    hashCode = (hashCode * 59) + this.SuccessDeliveryConfigList.GetHashCode();
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
