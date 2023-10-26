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
    /// AnttechOceanbaseTestplatformTaskQueryModel
    /// </summary>
    [DataContract(Name = "AnttechOceanbaseTestplatformTaskQueryModel")]
    public partial class AnttechOceanbaseTestplatformTaskQueryModel : IEquatable<AnttechOceanbaseTestplatformTaskQueryModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AnttechOceanbaseTestplatformTaskQueryModel" /> class.
        /// </summary>
        /// <param name="endTime">筛选结束时间.</param>
        /// <param name="palyer">参赛选手的名字.</param>
        /// <param name="runTaskRetry">允许超时任务的重试次数.</param>
        /// <param name="runTaskTimeOutMinutes">获取任务时先获取超时任务，这里传入的是超时的分钟数。默认30分钟。.</param>
        /// <param name="startTime">获取任务的筛选条件.</param>
        /// <param name="testCases">二级提测题目.</param>
        /// <param name="testInfo">测试结果描述、备注信息.</param>
        /// <param name="testSuite">一级提测题目.</param>
        public AnttechOceanbaseTestplatformTaskQueryModel(string endTime = default(string), string palyer = default(string), int runTaskRetry = default(int), int runTaskTimeOutMinutes = default(int), string startTime = default(string), string testCases = default(string), string testInfo = default(string), string testSuite = default(string))
        {
            this.EndTime = endTime;
            this.Palyer = palyer;
            this.RunTaskRetry = runTaskRetry;
            this.RunTaskTimeOutMinutes = runTaskTimeOutMinutes;
            this.StartTime = startTime;
            this.TestCases = testCases;
            this.TestInfo = testInfo;
            this.TestSuite = testSuite;
        }

        /// <summary>
        /// 筛选结束时间
        /// </summary>
        /// <value>筛选结束时间</value>
        [DataMember(Name = "end_time", EmitDefaultValue = false)]
        public string EndTime { get; set; }

        /// <summary>
        /// 参赛选手的名字
        /// </summary>
        /// <value>参赛选手的名字</value>
        [DataMember(Name = "palyer", EmitDefaultValue = false)]
        public string Palyer { get; set; }

        /// <summary>
        /// 允许超时任务的重试次数
        /// </summary>
        /// <value>允许超时任务的重试次数</value>
        [DataMember(Name = "run_task_retry", EmitDefaultValue = false)]
        public int RunTaskRetry { get; set; }

        /// <summary>
        /// 获取任务时先获取超时任务，这里传入的是超时的分钟数。默认30分钟。
        /// </summary>
        /// <value>获取任务时先获取超时任务，这里传入的是超时的分钟数。默认30分钟。</value>
        [DataMember(Name = "run_task_time_out_minutes", EmitDefaultValue = false)]
        public int RunTaskTimeOutMinutes { get; set; }

        /// <summary>
        /// 获取任务的筛选条件
        /// </summary>
        /// <value>获取任务的筛选条件</value>
        [DataMember(Name = "start_time", EmitDefaultValue = false)]
        public string StartTime { get; set; }

        /// <summary>
        /// 二级提测题目
        /// </summary>
        /// <value>二级提测题目</value>
        [DataMember(Name = "test_cases", EmitDefaultValue = false)]
        public string TestCases { get; set; }

        /// <summary>
        /// 测试结果描述、备注信息
        /// </summary>
        /// <value>测试结果描述、备注信息</value>
        [DataMember(Name = "test_info", EmitDefaultValue = false)]
        public string TestInfo { get; set; }

        /// <summary>
        /// 一级提测题目
        /// </summary>
        /// <value>一级提测题目</value>
        [DataMember(Name = "test_suite", EmitDefaultValue = false)]
        public string TestSuite { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AnttechOceanbaseTestplatformTaskQueryModel {\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  Palyer: ").Append(Palyer).Append("\n");
            sb.Append("  RunTaskRetry: ").Append(RunTaskRetry).Append("\n");
            sb.Append("  RunTaskTimeOutMinutes: ").Append(RunTaskTimeOutMinutes).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  TestCases: ").Append(TestCases).Append("\n");
            sb.Append("  TestInfo: ").Append(TestInfo).Append("\n");
            sb.Append("  TestSuite: ").Append(TestSuite).Append("\n");
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
            return this.Equals(input as AnttechOceanbaseTestplatformTaskQueryModel);
        }

        /// <summary>
        /// Returns true if AnttechOceanbaseTestplatformTaskQueryModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AnttechOceanbaseTestplatformTaskQueryModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AnttechOceanbaseTestplatformTaskQueryModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.Palyer == input.Palyer ||
                    (this.Palyer != null &&
                    this.Palyer.Equals(input.Palyer))
                ) && 
                (
                    this.RunTaskRetry == input.RunTaskRetry ||
                    this.RunTaskRetry.Equals(input.RunTaskRetry)
                ) && 
                (
                    this.RunTaskTimeOutMinutes == input.RunTaskTimeOutMinutes ||
                    this.RunTaskTimeOutMinutes.Equals(input.RunTaskTimeOutMinutes)
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.TestCases == input.TestCases ||
                    (this.TestCases != null &&
                    this.TestCases.Equals(input.TestCases))
                ) && 
                (
                    this.TestInfo == input.TestInfo ||
                    (this.TestInfo != null &&
                    this.TestInfo.Equals(input.TestInfo))
                ) && 
                (
                    this.TestSuite == input.TestSuite ||
                    (this.TestSuite != null &&
                    this.TestSuite.Equals(input.TestSuite))
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
                if (this.EndTime != null)
                {
                    hashCode = (hashCode * 59) + this.EndTime.GetHashCode();
                }
                if (this.Palyer != null)
                {
                    hashCode = (hashCode * 59) + this.Palyer.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RunTaskRetry.GetHashCode();
                hashCode = (hashCode * 59) + this.RunTaskTimeOutMinutes.GetHashCode();
                if (this.StartTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartTime.GetHashCode();
                }
                if (this.TestCases != null)
                {
                    hashCode = (hashCode * 59) + this.TestCases.GetHashCode();
                }
                if (this.TestInfo != null)
                {
                    hashCode = (hashCode * 59) + this.TestInfo.GetHashCode();
                }
                if (this.TestSuite != null)
                {
                    hashCode = (hashCode * 59) + this.TestSuite.GetHashCode();
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
