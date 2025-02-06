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
    /// CloudResumeWorkExperience
    /// </summary>
    [DataContract(Name = "CloudResumeWorkExperience")]
    public partial class CloudResumeWorkExperience : IEquatable<CloudResumeWorkExperience>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloudResumeWorkExperience" /> class.
        /// </summary>
        /// <param name="companyName">公司名称.</param>
        /// <param name="jobId">职业id.</param>
        /// <param name="jobName">职业.</param>
        /// <param name="positionName">用户在求职意向页面自主录入.</param>
        /// <param name="professionId">行业id.</param>
        /// <param name="professionName">行业名称.</param>
        /// <param name="workDesc">工作描述.</param>
        /// <param name="workEndTime">工作结束时间.</param>
        /// <param name="workStartTime">工作开始日期.</param>
        public CloudResumeWorkExperience(string companyName = default(string), string jobId = default(string), string jobName = default(string), string positionName = default(string), string professionId = default(string), string professionName = default(string), string workDesc = default(string), int workEndTime = default(int), int workStartTime = default(int))
        {
            this.CompanyName = companyName;
            this.JobId = jobId;
            this.JobName = jobName;
            this.PositionName = positionName;
            this.ProfessionId = professionId;
            this.ProfessionName = professionName;
            this.WorkDesc = workDesc;
            this.WorkEndTime = workEndTime;
            this.WorkStartTime = workStartTime;
        }

        /// <summary>
        /// 公司名称
        /// </summary>
        /// <value>公司名称</value>
        [DataMember(Name = "company_name", EmitDefaultValue = false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// 职业id
        /// </summary>
        /// <value>职业id</value>
        [DataMember(Name = "job_id", EmitDefaultValue = false)]
        public string JobId { get; set; }

        /// <summary>
        /// 职业
        /// </summary>
        /// <value>职业</value>
        [DataMember(Name = "job_name", EmitDefaultValue = false)]
        public string JobName { get; set; }

        /// <summary>
        /// 用户在求职意向页面自主录入
        /// </summary>
        /// <value>用户在求职意向页面自主录入</value>
        [DataMember(Name = "position_name", EmitDefaultValue = false)]
        public string PositionName { get; set; }

        /// <summary>
        /// 行业id
        /// </summary>
        /// <value>行业id</value>
        [DataMember(Name = "profession_id", EmitDefaultValue = false)]
        public string ProfessionId { get; set; }

        /// <summary>
        /// 行业名称
        /// </summary>
        /// <value>行业名称</value>
        [DataMember(Name = "profession_name", EmitDefaultValue = false)]
        public string ProfessionName { get; set; }

        /// <summary>
        /// 工作描述
        /// </summary>
        /// <value>工作描述</value>
        [DataMember(Name = "work_desc", EmitDefaultValue = false)]
        public string WorkDesc { get; set; }

        /// <summary>
        /// 工作结束时间
        /// </summary>
        /// <value>工作结束时间</value>
        [DataMember(Name = "work_end_time", EmitDefaultValue = false)]
        public int WorkEndTime { get; set; }

        /// <summary>
        /// 工作开始日期
        /// </summary>
        /// <value>工作开始日期</value>
        [DataMember(Name = "work_start_time", EmitDefaultValue = false)]
        public int WorkStartTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CloudResumeWorkExperience {\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  JobName: ").Append(JobName).Append("\n");
            sb.Append("  PositionName: ").Append(PositionName).Append("\n");
            sb.Append("  ProfessionId: ").Append(ProfessionId).Append("\n");
            sb.Append("  ProfessionName: ").Append(ProfessionName).Append("\n");
            sb.Append("  WorkDesc: ").Append(WorkDesc).Append("\n");
            sb.Append("  WorkEndTime: ").Append(WorkEndTime).Append("\n");
            sb.Append("  WorkStartTime: ").Append(WorkStartTime).Append("\n");
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
            return this.Equals(input as CloudResumeWorkExperience);
        }

        /// <summary>
        /// Returns true if CloudResumeWorkExperience instances are equal
        /// </summary>
        /// <param name="input">Instance of CloudResumeWorkExperience to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloudResumeWorkExperience input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.JobName == input.JobName ||
                    (this.JobName != null &&
                    this.JobName.Equals(input.JobName))
                ) && 
                (
                    this.PositionName == input.PositionName ||
                    (this.PositionName != null &&
                    this.PositionName.Equals(input.PositionName))
                ) && 
                (
                    this.ProfessionId == input.ProfessionId ||
                    (this.ProfessionId != null &&
                    this.ProfessionId.Equals(input.ProfessionId))
                ) && 
                (
                    this.ProfessionName == input.ProfessionName ||
                    (this.ProfessionName != null &&
                    this.ProfessionName.Equals(input.ProfessionName))
                ) && 
                (
                    this.WorkDesc == input.WorkDesc ||
                    (this.WorkDesc != null &&
                    this.WorkDesc.Equals(input.WorkDesc))
                ) && 
                (
                    this.WorkEndTime == input.WorkEndTime ||
                    this.WorkEndTime.Equals(input.WorkEndTime)
                ) && 
                (
                    this.WorkStartTime == input.WorkStartTime ||
                    this.WorkStartTime.Equals(input.WorkStartTime)
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
                if (this.CompanyName != null)
                {
                    hashCode = (hashCode * 59) + this.CompanyName.GetHashCode();
                }
                if (this.JobId != null)
                {
                    hashCode = (hashCode * 59) + this.JobId.GetHashCode();
                }
                if (this.JobName != null)
                {
                    hashCode = (hashCode * 59) + this.JobName.GetHashCode();
                }
                if (this.PositionName != null)
                {
                    hashCode = (hashCode * 59) + this.PositionName.GetHashCode();
                }
                if (this.ProfessionId != null)
                {
                    hashCode = (hashCode * 59) + this.ProfessionId.GetHashCode();
                }
                if (this.ProfessionName != null)
                {
                    hashCode = (hashCode * 59) + this.ProfessionName.GetHashCode();
                }
                if (this.WorkDesc != null)
                {
                    hashCode = (hashCode * 59) + this.WorkDesc.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.WorkEndTime.GetHashCode();
                hashCode = (hashCode * 59) + this.WorkStartTime.GetHashCode();
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
