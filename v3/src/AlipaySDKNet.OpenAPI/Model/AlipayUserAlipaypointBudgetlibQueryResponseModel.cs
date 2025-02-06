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
    /// AlipayUserAlipaypointBudgetlibQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayUserAlipaypointBudgetlibQueryResponseModel")]
    public partial class AlipayUserAlipaypointBudgetlibQueryResponseModel : IEquatable<AlipayUserAlipaypointBudgetlibQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayUserAlipaypointBudgetlibQueryResponseModel" /> class.
        /// </summary>
        /// <param name="budgetCode">集分宝预算库编码.</param>
        /// <param name="budgetDesc">预算库的中文描述.</param>
        /// <param name="cumulativeAmount">预算库累计积分数.</param>
        /// <param name="enabled">预算库是否为生效状态标识，true-生效中，false-已失效.</param>
        /// <param name="endTime">预算库结束时间, yyyy-MM-dd HH:mm:ss.</param>
        /// <param name="remainAmount">预算库当前剩余积分数.</param>
        /// <param name="startTime">预算库开始时间, yyyy-MM-dd HH:mm:ss.</param>
        public AlipayUserAlipaypointBudgetlibQueryResponseModel(string budgetCode = default(string), string budgetDesc = default(string), int cumulativeAmount = default(int), bool enabled = default(bool), string endTime = default(string), int remainAmount = default(int), string startTime = default(string))
        {
            this.BudgetCode = budgetCode;
            this.BudgetDesc = budgetDesc;
            this.CumulativeAmount = cumulativeAmount;
            this.Enabled = enabled;
            this.EndTime = endTime;
            this.RemainAmount = remainAmount;
            this.StartTime = startTime;
        }

        /// <summary>
        /// 集分宝预算库编码
        /// </summary>
        /// <value>集分宝预算库编码</value>
        [DataMember(Name = "budget_code", EmitDefaultValue = false)]
        public string BudgetCode { get; set; }

        /// <summary>
        /// 预算库的中文描述
        /// </summary>
        /// <value>预算库的中文描述</value>
        [DataMember(Name = "budget_desc", EmitDefaultValue = false)]
        public string BudgetDesc { get; set; }

        /// <summary>
        /// 预算库累计积分数
        /// </summary>
        /// <value>预算库累计积分数</value>
        [DataMember(Name = "cumulative_amount", EmitDefaultValue = false)]
        public int CumulativeAmount { get; set; }

        /// <summary>
        /// 预算库是否为生效状态标识，true-生效中，false-已失效
        /// </summary>
        /// <value>预算库是否为生效状态标识，true-生效中，false-已失效</value>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// 预算库结束时间, yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <value>预算库结束时间, yyyy-MM-dd HH:mm:ss</value>
        [DataMember(Name = "end_time", EmitDefaultValue = false)]
        public string EndTime { get; set; }

        /// <summary>
        /// 预算库当前剩余积分数
        /// </summary>
        /// <value>预算库当前剩余积分数</value>
        [DataMember(Name = "remain_amount", EmitDefaultValue = false)]
        public int RemainAmount { get; set; }

        /// <summary>
        /// 预算库开始时间, yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <value>预算库开始时间, yyyy-MM-dd HH:mm:ss</value>
        [DataMember(Name = "start_time", EmitDefaultValue = false)]
        public string StartTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayUserAlipaypointBudgetlibQueryResponseModel {\n");
            sb.Append("  BudgetCode: ").Append(BudgetCode).Append("\n");
            sb.Append("  BudgetDesc: ").Append(BudgetDesc).Append("\n");
            sb.Append("  CumulativeAmount: ").Append(CumulativeAmount).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  RemainAmount: ").Append(RemainAmount).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
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
            return this.Equals(input as AlipayUserAlipaypointBudgetlibQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayUserAlipaypointBudgetlibQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayUserAlipaypointBudgetlibQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayUserAlipaypointBudgetlibQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BudgetCode == input.BudgetCode ||
                    (this.BudgetCode != null &&
                    this.BudgetCode.Equals(input.BudgetCode))
                ) && 
                (
                    this.BudgetDesc == input.BudgetDesc ||
                    (this.BudgetDesc != null &&
                    this.BudgetDesc.Equals(input.BudgetDesc))
                ) && 
                (
                    this.CumulativeAmount == input.CumulativeAmount ||
                    this.CumulativeAmount.Equals(input.CumulativeAmount)
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    this.Enabled.Equals(input.Enabled)
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.RemainAmount == input.RemainAmount ||
                    this.RemainAmount.Equals(input.RemainAmount)
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
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
                if (this.BudgetCode != null)
                {
                    hashCode = (hashCode * 59) + this.BudgetCode.GetHashCode();
                }
                if (this.BudgetDesc != null)
                {
                    hashCode = (hashCode * 59) + this.BudgetDesc.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CumulativeAmount.GetHashCode();
                hashCode = (hashCode * 59) + this.Enabled.GetHashCode();
                if (this.EndTime != null)
                {
                    hashCode = (hashCode * 59) + this.EndTime.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.RemainAmount.GetHashCode();
                if (this.StartTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartTime.GetHashCode();
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
