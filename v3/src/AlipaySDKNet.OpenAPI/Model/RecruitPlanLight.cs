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
    /// RecruitPlanLight
    /// </summary>
    [DataContract(Name = "RecruitPlanLight")]
    public partial class RecruitPlanLight : IEquatable<RecruitPlanLight>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecruitPlanLight" /> class.
        /// </summary>
        /// <param name="description">招商方案描述：富文本内容，可能包含html标签.</param>
        /// <param name="enrollEndTime">报名结束时间.</param>
        /// <param name="enrollSceneType">招商方案所属报名场景 枚举值： VOUCHER：券报名场景； MINI_APP：小程序报名场景；.</param>
        /// <param name="enrollStartTime">报名开始时间.</param>
        /// <param name="logo">方案头图链接，150x150 以上尺寸的方形图片.</param>
        /// <param name="planId">招商方案ID.</param>
        /// <param name="planName">招商方案名称.</param>
        /// <param name="status">招商方案状态.</param>
        public RecruitPlanLight(string description = default(string), string enrollEndTime = default(string), string enrollSceneType = default(string), string enrollStartTime = default(string), string logo = default(string), string planId = default(string), string planName = default(string), string status = default(string))
        {
            this.Description = description;
            this.EnrollEndTime = enrollEndTime;
            this.EnrollSceneType = enrollSceneType;
            this.EnrollStartTime = enrollStartTime;
            this.Logo = logo;
            this.PlanId = planId;
            this.PlanName = planName;
            this.Status = status;
        }

        /// <summary>
        /// 招商方案描述：富文本内容，可能包含html标签
        /// </summary>
        /// <value>招商方案描述：富文本内容，可能包含html标签</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// 报名结束时间
        /// </summary>
        /// <value>报名结束时间</value>
        [DataMember(Name = "enroll_end_time", EmitDefaultValue = false)]
        public string EnrollEndTime { get; set; }

        /// <summary>
        /// 招商方案所属报名场景 枚举值： VOUCHER：券报名场景； MINI_APP：小程序报名场景；
        /// </summary>
        /// <value>招商方案所属报名场景 枚举值： VOUCHER：券报名场景； MINI_APP：小程序报名场景；</value>
        [DataMember(Name = "enroll_scene_type", EmitDefaultValue = false)]
        public string EnrollSceneType { get; set; }

        /// <summary>
        /// 报名开始时间
        /// </summary>
        /// <value>报名开始时间</value>
        [DataMember(Name = "enroll_start_time", EmitDefaultValue = false)]
        public string EnrollStartTime { get; set; }

        /// <summary>
        /// 方案头图链接，150x150 以上尺寸的方形图片
        /// </summary>
        /// <value>方案头图链接，150x150 以上尺寸的方形图片</value>
        [DataMember(Name = "logo", EmitDefaultValue = false)]
        public string Logo { get; set; }

        /// <summary>
        /// 招商方案ID
        /// </summary>
        /// <value>招商方案ID</value>
        [DataMember(Name = "plan_id", EmitDefaultValue = false)]
        public string PlanId { get; set; }

        /// <summary>
        /// 招商方案名称
        /// </summary>
        /// <value>招商方案名称</value>
        [DataMember(Name = "plan_name", EmitDefaultValue = false)]
        public string PlanName { get; set; }

        /// <summary>
        /// 招商方案状态
        /// </summary>
        /// <value>招商方案状态</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RecruitPlanLight {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EnrollEndTime: ").Append(EnrollEndTime).Append("\n");
            sb.Append("  EnrollSceneType: ").Append(EnrollSceneType).Append("\n");
            sb.Append("  EnrollStartTime: ").Append(EnrollStartTime).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  PlanId: ").Append(PlanId).Append("\n");
            sb.Append("  PlanName: ").Append(PlanName).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as RecruitPlanLight);
        }

        /// <summary>
        /// Returns true if RecruitPlanLight instances are equal
        /// </summary>
        /// <param name="input">Instance of RecruitPlanLight to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecruitPlanLight input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.EnrollEndTime == input.EnrollEndTime ||
                    (this.EnrollEndTime != null &&
                    this.EnrollEndTime.Equals(input.EnrollEndTime))
                ) && 
                (
                    this.EnrollSceneType == input.EnrollSceneType ||
                    (this.EnrollSceneType != null &&
                    this.EnrollSceneType.Equals(input.EnrollSceneType))
                ) && 
                (
                    this.EnrollStartTime == input.EnrollStartTime ||
                    (this.EnrollStartTime != null &&
                    this.EnrollStartTime.Equals(input.EnrollStartTime))
                ) && 
                (
                    this.Logo == input.Logo ||
                    (this.Logo != null &&
                    this.Logo.Equals(input.Logo))
                ) && 
                (
                    this.PlanId == input.PlanId ||
                    (this.PlanId != null &&
                    this.PlanId.Equals(input.PlanId))
                ) && 
                (
                    this.PlanName == input.PlanName ||
                    (this.PlanName != null &&
                    this.PlanName.Equals(input.PlanName))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.EnrollEndTime != null)
                {
                    hashCode = (hashCode * 59) + this.EnrollEndTime.GetHashCode();
                }
                if (this.EnrollSceneType != null)
                {
                    hashCode = (hashCode * 59) + this.EnrollSceneType.GetHashCode();
                }
                if (this.EnrollStartTime != null)
                {
                    hashCode = (hashCode * 59) + this.EnrollStartTime.GetHashCode();
                }
                if (this.Logo != null)
                {
                    hashCode = (hashCode * 59) + this.Logo.GetHashCode();
                }
                if (this.PlanId != null)
                {
                    hashCode = (hashCode * 59) + this.PlanId.GetHashCode();
                }
                if (this.PlanName != null)
                {
                    hashCode = (hashCode * 59) + this.PlanName.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
