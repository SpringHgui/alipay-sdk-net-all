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
    /// AlipayIserviceCcmAgentSchedulelogQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayIserviceCcmAgentSchedulelogQueryResponseModel")]
    public partial class AlipayIserviceCcmAgentSchedulelogQueryResponseModel : IEquatable<AlipayIserviceCcmAgentSchedulelogQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayIserviceCcmAgentSchedulelogQueryResponseModel" /> class.
        /// </summary>
        /// <param name="agentScheduleLogs">agentScheduleLogs.</param>
        /// <param name="pageNum">查询结果的页码.</param>
        /// <param name="pageSize">分页查询时设置的每页记录数.</param>
        /// <param name="totalCount">总条目数.</param>
        public AlipayIserviceCcmAgentSchedulelogQueryResponseModel(AgentScheduleLog agentScheduleLogs = default(AgentScheduleLog), int pageNum = default(int), int pageSize = default(int), int totalCount = default(int))
        {
            this.AgentScheduleLogs = agentScheduleLogs;
            this.PageNum = pageNum;
            this.PageSize = pageSize;
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Gets or Sets AgentScheduleLogs
        /// </summary>
        [DataMember(Name = "agent_schedule_logs", EmitDefaultValue = false)]
        public AgentScheduleLog AgentScheduleLogs { get; set; }

        /// <summary>
        /// 查询结果的页码
        /// </summary>
        /// <value>查询结果的页码</value>
        [DataMember(Name = "page_num", EmitDefaultValue = false)]
        public int PageNum { get; set; }

        /// <summary>
        /// 分页查询时设置的每页记录数
        /// </summary>
        /// <value>分页查询时设置的每页记录数</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// 总条目数
        /// </summary>
        /// <value>总条目数</value>
        [DataMember(Name = "total_count", EmitDefaultValue = false)]
        public int TotalCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayIserviceCcmAgentSchedulelogQueryResponseModel {\n");
            sb.Append("  AgentScheduleLogs: ").Append(AgentScheduleLogs).Append("\n");
            sb.Append("  PageNum: ").Append(PageNum).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
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
            return this.Equals(input as AlipayIserviceCcmAgentSchedulelogQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayIserviceCcmAgentSchedulelogQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayIserviceCcmAgentSchedulelogQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayIserviceCcmAgentSchedulelogQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AgentScheduleLogs == input.AgentScheduleLogs ||
                    (this.AgentScheduleLogs != null &&
                    this.AgentScheduleLogs.Equals(input.AgentScheduleLogs))
                ) && 
                (
                    this.PageNum == input.PageNum ||
                    this.PageNum.Equals(input.PageNum)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    this.TotalCount.Equals(input.TotalCount)
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
                if (this.AgentScheduleLogs != null)
                {
                    hashCode = (hashCode * 59) + this.AgentScheduleLogs.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PageNum.GetHashCode();
                hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalCount.GetHashCode();
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
