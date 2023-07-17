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
    /// AlipayMarketingActivityDeliveryStopModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingActivityDeliveryStopModel")]
    public partial class AlipayMarketingActivityDeliveryStopModel : IEquatable<AlipayMarketingActivityDeliveryStopModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingActivityDeliveryStopModel" /> class.
        /// </summary>
        /// <param name="belongMerchantInfo">belongMerchantInfo.</param>
        /// <param name="deliveryConfigList">[已废弃] 待停止的投放配置列表。 最大数量限制20个。.</param>
        /// <param name="merchantAccessMode">商户接入模式.</param>
        /// <param name="outBizNo">外部业务单号，用作幂等控制。 幂等作用： 再次请求返回与上一次相同的结果。 外部接入方需保证业务单号唯一。.</param>
        public AlipayMarketingActivityDeliveryStopModel(DeliveryAgencyMerchantInfo belongMerchantInfo = default(DeliveryAgencyMerchantInfo), List<DeliveryConfig> deliveryConfigList = default(List<DeliveryConfig>), string merchantAccessMode = default(string), string outBizNo = default(string))
        {
            this.BelongMerchantInfo = belongMerchantInfo;
            this.DeliveryConfigList = deliveryConfigList;
            this.MerchantAccessMode = merchantAccessMode;
            this.OutBizNo = outBizNo;
        }

        /// <summary>
        /// Gets or Sets BelongMerchantInfo
        /// </summary>
        [DataMember(Name = "belong_merchant_info", EmitDefaultValue = false)]
        public DeliveryAgencyMerchantInfo BelongMerchantInfo { get; set; }

        /// <summary>
        /// [已废弃] 待停止的投放配置列表。 最大数量限制20个。
        /// </summary>
        /// <value>[已废弃] 待停止的投放配置列表。 最大数量限制20个。</value>
        [DataMember(Name = "delivery_config_list", EmitDefaultValue = false)]
        public List<DeliveryConfig> DeliveryConfigList { get; set; }

        /// <summary>
        /// 商户接入模式
        /// </summary>
        /// <value>商户接入模式</value>
        [DataMember(Name = "merchant_access_mode", EmitDefaultValue = false)]
        public string MerchantAccessMode { get; set; }

        /// <summary>
        /// 外部业务单号，用作幂等控制。 幂等作用： 再次请求返回与上一次相同的结果。 外部接入方需保证业务单号唯一。
        /// </summary>
        /// <value>外部业务单号，用作幂等控制。 幂等作用： 再次请求返回与上一次相同的结果。 外部接入方需保证业务单号唯一。</value>
        [DataMember(Name = "out_biz_no", EmitDefaultValue = false)]
        public string OutBizNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingActivityDeliveryStopModel {\n");
            sb.Append("  BelongMerchantInfo: ").Append(BelongMerchantInfo).Append("\n");
            sb.Append("  DeliveryConfigList: ").Append(DeliveryConfigList).Append("\n");
            sb.Append("  MerchantAccessMode: ").Append(MerchantAccessMode).Append("\n");
            sb.Append("  OutBizNo: ").Append(OutBizNo).Append("\n");
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
            return this.Equals(input as AlipayMarketingActivityDeliveryStopModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingActivityDeliveryStopModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingActivityDeliveryStopModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingActivityDeliveryStopModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BelongMerchantInfo == input.BelongMerchantInfo ||
                    (this.BelongMerchantInfo != null &&
                    this.BelongMerchantInfo.Equals(input.BelongMerchantInfo))
                ) && 
                (
                    this.DeliveryConfigList == input.DeliveryConfigList ||
                    this.DeliveryConfigList != null &&
                    input.DeliveryConfigList != null &&
                    this.DeliveryConfigList.SequenceEqual(input.DeliveryConfigList)
                ) && 
                (
                    this.MerchantAccessMode == input.MerchantAccessMode ||
                    (this.MerchantAccessMode != null &&
                    this.MerchantAccessMode.Equals(input.MerchantAccessMode))
                ) && 
                (
                    this.OutBizNo == input.OutBizNo ||
                    (this.OutBizNo != null &&
                    this.OutBizNo.Equals(input.OutBizNo))
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
                if (this.BelongMerchantInfo != null)
                {
                    hashCode = (hashCode * 59) + this.BelongMerchantInfo.GetHashCode();
                }
                if (this.DeliveryConfigList != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryConfigList.GetHashCode();
                }
                if (this.MerchantAccessMode != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantAccessMode.GetHashCode();
                }
                if (this.OutBizNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutBizNo.GetHashCode();
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
