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
    /// BudgetInfo
    /// </summary>
    [DataContract(Name = "BudgetInfo")]
    public partial class BudgetInfo : IEquatable<BudgetInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetInfo" /> class.
        /// </summary>
        /// <param name="budgetTotal">预算数量.</param>
        /// <param name="budgetType">预算类型.</param>
        /// <param name="subBudgetDimension">设置每天的预算，如每天的预算设置为100，即该活动一天最多发放100次.</param>
        /// <param name="subValue">用于控制子纬度的预算数量.</param>
        public BudgetInfo(string budgetTotal = default(string), string budgetType = default(string), string subBudgetDimension = default(string), string subValue = default(string))
        {
            this.BudgetTotal = budgetTotal;
            this.BudgetType = budgetType;
            this.SubBudgetDimension = subBudgetDimension;
            this.SubValue = subValue;
        }

        /// <summary>
        /// 预算数量
        /// </summary>
        /// <value>预算数量</value>
        [DataMember(Name = "budget_total", EmitDefaultValue = false)]
        public string BudgetTotal { get; set; }

        /// <summary>
        /// 预算类型
        /// </summary>
        /// <value>预算类型</value>
        [DataMember(Name = "budget_type", EmitDefaultValue = false)]
        public string BudgetType { get; set; }

        /// <summary>
        /// 设置每天的预算，如每天的预算设置为100，即该活动一天最多发放100次
        /// </summary>
        /// <value>设置每天的预算，如每天的预算设置为100，即该活动一天最多发放100次</value>
        [DataMember(Name = "sub_budget_dimension", EmitDefaultValue = false)]
        public string SubBudgetDimension { get; set; }

        /// <summary>
        /// 用于控制子纬度的预算数量
        /// </summary>
        /// <value>用于控制子纬度的预算数量</value>
        [DataMember(Name = "sub_value", EmitDefaultValue = false)]
        public string SubValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BudgetInfo {\n");
            sb.Append("  BudgetTotal: ").Append(BudgetTotal).Append("\n");
            sb.Append("  BudgetType: ").Append(BudgetType).Append("\n");
            sb.Append("  SubBudgetDimension: ").Append(SubBudgetDimension).Append("\n");
            sb.Append("  SubValue: ").Append(SubValue).Append("\n");
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
            return this.Equals(input as BudgetInfo);
        }

        /// <summary>
        /// Returns true if BudgetInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of BudgetInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BudgetInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BudgetTotal == input.BudgetTotal ||
                    (this.BudgetTotal != null &&
                    this.BudgetTotal.Equals(input.BudgetTotal))
                ) && 
                (
                    this.BudgetType == input.BudgetType ||
                    (this.BudgetType != null &&
                    this.BudgetType.Equals(input.BudgetType))
                ) && 
                (
                    this.SubBudgetDimension == input.SubBudgetDimension ||
                    (this.SubBudgetDimension != null &&
                    this.SubBudgetDimension.Equals(input.SubBudgetDimension))
                ) && 
                (
                    this.SubValue == input.SubValue ||
                    (this.SubValue != null &&
                    this.SubValue.Equals(input.SubValue))
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
                if (this.BudgetTotal != null)
                {
                    hashCode = (hashCode * 59) + this.BudgetTotal.GetHashCode();
                }
                if (this.BudgetType != null)
                {
                    hashCode = (hashCode * 59) + this.BudgetType.GetHashCode();
                }
                if (this.SubBudgetDimension != null)
                {
                    hashCode = (hashCode * 59) + this.SubBudgetDimension.GetHashCode();
                }
                if (this.SubValue != null)
                {
                    hashCode = (hashCode * 59) + this.SubValue.GetHashCode();
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
