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
    /// AlipayMarketingRecruitEnrollCreateModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingRecruitEnrollCreateModel")]
    public partial class AlipayMarketingRecruitEnrollCreateModel : IEquatable<AlipayMarketingRecruitEnrollCreateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingRecruitEnrollCreateModel" /> class.
        /// </summary>
        /// <param name="enrollInfo">enrollInfo.</param>
        /// <param name="enrollSceneType">活动报名场景配置。 枚举值： VOUCHER：券报名场景的报名； MINI_APP：小程序报名场景的报名；.</param>
        /// <param name="outBizNo">外部操作流水号。由商家/ISV 自定义，仅支持字母、数字、下划线且需保证每次操作唯一。.</param>
        /// <param name="planId">要报名的招商方案ID.</param>
        public AlipayMarketingRecruitEnrollCreateModel(RecruitEnrollInfo enrollInfo = default(RecruitEnrollInfo), string enrollSceneType = default(string), string outBizNo = default(string), string planId = default(string))
        {
            this.EnrollInfo = enrollInfo;
            this.EnrollSceneType = enrollSceneType;
            this.OutBizNo = outBizNo;
            this.PlanId = planId;
        }

        /// <summary>
        /// Gets or Sets EnrollInfo
        /// </summary>
        [DataMember(Name = "enroll_info", EmitDefaultValue = false)]
        public RecruitEnrollInfo EnrollInfo { get; set; }

        /// <summary>
        /// 活动报名场景配置。 枚举值： VOUCHER：券报名场景的报名； MINI_APP：小程序报名场景的报名；
        /// </summary>
        /// <value>活动报名场景配置。 枚举值： VOUCHER：券报名场景的报名； MINI_APP：小程序报名场景的报名；</value>
        [DataMember(Name = "enroll_scene_type", EmitDefaultValue = false)]
        public string EnrollSceneType { get; set; }

        /// <summary>
        /// 外部操作流水号。由商家/ISV 自定义，仅支持字母、数字、下划线且需保证每次操作唯一。
        /// </summary>
        /// <value>外部操作流水号。由商家/ISV 自定义，仅支持字母、数字、下划线且需保证每次操作唯一。</value>
        [DataMember(Name = "out_biz_no", EmitDefaultValue = false)]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 要报名的招商方案ID
        /// </summary>
        /// <value>要报名的招商方案ID</value>
        [DataMember(Name = "plan_id", EmitDefaultValue = false)]
        public string PlanId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingRecruitEnrollCreateModel {\n");
            sb.Append("  EnrollInfo: ").Append(EnrollInfo).Append("\n");
            sb.Append("  EnrollSceneType: ").Append(EnrollSceneType).Append("\n");
            sb.Append("  OutBizNo: ").Append(OutBizNo).Append("\n");
            sb.Append("  PlanId: ").Append(PlanId).Append("\n");
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
            return this.Equals(input as AlipayMarketingRecruitEnrollCreateModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingRecruitEnrollCreateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingRecruitEnrollCreateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingRecruitEnrollCreateModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EnrollInfo == input.EnrollInfo ||
                    (this.EnrollInfo != null &&
                    this.EnrollInfo.Equals(input.EnrollInfo))
                ) && 
                (
                    this.EnrollSceneType == input.EnrollSceneType ||
                    (this.EnrollSceneType != null &&
                    this.EnrollSceneType.Equals(input.EnrollSceneType))
                ) && 
                (
                    this.OutBizNo == input.OutBizNo ||
                    (this.OutBizNo != null &&
                    this.OutBizNo.Equals(input.OutBizNo))
                ) && 
                (
                    this.PlanId == input.PlanId ||
                    (this.PlanId != null &&
                    this.PlanId.Equals(input.PlanId))
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
                if (this.EnrollInfo != null)
                {
                    hashCode = (hashCode * 59) + this.EnrollInfo.GetHashCode();
                }
                if (this.EnrollSceneType != null)
                {
                    hashCode = (hashCode * 59) + this.EnrollSceneType.GetHashCode();
                }
                if (this.OutBizNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutBizNo.GetHashCode();
                }
                if (this.PlanId != null)
                {
                    hashCode = (hashCode * 59) + this.PlanId.GetHashCode();
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
