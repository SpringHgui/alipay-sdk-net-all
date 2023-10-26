/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2023-10-26
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
    /// AlipayMarketingActivityDeliveryCreateResponseModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingActivityDeliveryCreateResponseModel")]
    public partial class AlipayMarketingActivityDeliveryCreateResponseModel : IEquatable<AlipayMarketingActivityDeliveryCreateResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingActivityDeliveryCreateResponseModel" /> class.
        /// </summary>
        /// <param name="deliveryGuidePreviewUrl">预览链接。 可用于预览用户在承接页面领券的流程。.</param>
        /// <param name="deliveryId">推广计划id.</param>
        /// <param name="errorDeliveryConfigList">[已废弃] 创建失败的投放信息列表  失败的投放配置列表中，会返回对应的deliveryConfig对象。.</param>
        /// <param name="successDeliveryConfigList">[已废弃] 创建成功的投放信息列表  成功的投放配置列表中，会返回对应的deliveryConfig对象。.</param>
        public AlipayMarketingActivityDeliveryCreateResponseModel(string deliveryGuidePreviewUrl = default(string), string deliveryId = default(string), List<ErrorDeliveryConfig> errorDeliveryConfigList = default(List<ErrorDeliveryConfig>), List<SuccessDeliveryConfig> successDeliveryConfigList = default(List<SuccessDeliveryConfig>))
        {
            this.DeliveryGuidePreviewUrl = deliveryGuidePreviewUrl;
            this.DeliveryId = deliveryId;
            this.ErrorDeliveryConfigList = errorDeliveryConfigList;
            this.SuccessDeliveryConfigList = successDeliveryConfigList;
        }

        /// <summary>
        /// 预览链接。 可用于预览用户在承接页面领券的流程。
        /// </summary>
        /// <value>预览链接。 可用于预览用户在承接页面领券的流程。</value>
        [DataMember(Name = "delivery_guide_preview_url", EmitDefaultValue = false)]
        public string DeliveryGuidePreviewUrl { get; set; }

        /// <summary>
        /// 推广计划id
        /// </summary>
        /// <value>推广计划id</value>
        [DataMember(Name = "delivery_id", EmitDefaultValue = false)]
        public string DeliveryId { get; set; }

        /// <summary>
        /// [已废弃] 创建失败的投放信息列表  失败的投放配置列表中，会返回对应的deliveryConfig对象。
        /// </summary>
        /// <value>[已废弃] 创建失败的投放信息列表  失败的投放配置列表中，会返回对应的deliveryConfig对象。</value>
        [DataMember(Name = "error_delivery_config_list", EmitDefaultValue = false)]
        public List<ErrorDeliveryConfig> ErrorDeliveryConfigList { get; set; }

        /// <summary>
        /// [已废弃] 创建成功的投放信息列表  成功的投放配置列表中，会返回对应的deliveryConfig对象。
        /// </summary>
        /// <value>[已废弃] 创建成功的投放信息列表  成功的投放配置列表中，会返回对应的deliveryConfig对象。</value>
        [DataMember(Name = "success_delivery_config_list", EmitDefaultValue = false)]
        public List<SuccessDeliveryConfig> SuccessDeliveryConfigList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingActivityDeliveryCreateResponseModel {\n");
            sb.Append("  DeliveryGuidePreviewUrl: ").Append(DeliveryGuidePreviewUrl).Append("\n");
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
            return this.Equals(input as AlipayMarketingActivityDeliveryCreateResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingActivityDeliveryCreateResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingActivityDeliveryCreateResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingActivityDeliveryCreateResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DeliveryGuidePreviewUrl == input.DeliveryGuidePreviewUrl ||
                    (this.DeliveryGuidePreviewUrl != null &&
                    this.DeliveryGuidePreviewUrl.Equals(input.DeliveryGuidePreviewUrl))
                ) && 
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
                if (this.DeliveryGuidePreviewUrl != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryGuidePreviewUrl.GetHashCode();
                }
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
