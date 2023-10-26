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
    /// TemplateFieldRuleDTO
    /// </summary>
    [DataContract(Name = "TemplateFieldRuleDTO")]
    public partial class TemplateFieldRuleDTO : IEquatable<TemplateFieldRuleDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateFieldRuleDTO" /> class.
        /// </summary>
        /// <param name="fieldName">字段名称.</param>
        /// <param name="ruleName">规则名  1、ASSIGN_FROM_REQUEST:   以rule_value为key值，表示该栏位的值从会员卡开卡接口中获取，会员卡开卡接口的card_info中获取对应参数值  2、DATE_IN_FUTURE: 生成一个未来的日期（格式YYYY-MM-DD)，当选择DATE_IN_FUTURE的时候，field_name  必须是OpenDate或ValidDate， 值为(10m或10d 分别表示10个月或10天)  3、CONST: 常量，会员卡开卡接口进行开卡的时候使用模板创建时候设置的值，即取rule_value的值.</param>
        /// <param name="ruleValue">规则值，根据rule_name，采取相应取值策略  CONST：直接取rule_value作为卡属性值  DATE_IN_FUTURE：10m或10d 分别表示10个月或10天  ASSIGN_FROM_REQUEST：在开卡Reuqest请求中按rule_value取值，现在和field_name对应的为（OpenDate、ValidDate、Level、Point、Balance）.</param>
        public TemplateFieldRuleDTO(string fieldName = default(string), string ruleName = default(string), string ruleValue = default(string))
        {
            this.FieldName = fieldName;
            this.RuleName = ruleName;
            this.RuleValue = ruleValue;
        }

        /// <summary>
        /// 字段名称
        /// </summary>
        /// <value>字段名称</value>
        [DataMember(Name = "field_name", EmitDefaultValue = false)]
        public string FieldName { get; set; }

        /// <summary>
        /// 规则名  1、ASSIGN_FROM_REQUEST:   以rule_value为key值，表示该栏位的值从会员卡开卡接口中获取，会员卡开卡接口的card_info中获取对应参数值  2、DATE_IN_FUTURE: 生成一个未来的日期（格式YYYY-MM-DD)，当选择DATE_IN_FUTURE的时候，field_name  必须是OpenDate或ValidDate， 值为(10m或10d 分别表示10个月或10天)  3、CONST: 常量，会员卡开卡接口进行开卡的时候使用模板创建时候设置的值，即取rule_value的值
        /// </summary>
        /// <value>规则名  1、ASSIGN_FROM_REQUEST:   以rule_value为key值，表示该栏位的值从会员卡开卡接口中获取，会员卡开卡接口的card_info中获取对应参数值  2、DATE_IN_FUTURE: 生成一个未来的日期（格式YYYY-MM-DD)，当选择DATE_IN_FUTURE的时候，field_name  必须是OpenDate或ValidDate， 值为(10m或10d 分别表示10个月或10天)  3、CONST: 常量，会员卡开卡接口进行开卡的时候使用模板创建时候设置的值，即取rule_value的值</value>
        [DataMember(Name = "rule_name", EmitDefaultValue = false)]
        public string RuleName { get; set; }

        /// <summary>
        /// 规则值，根据rule_name，采取相应取值策略  CONST：直接取rule_value作为卡属性值  DATE_IN_FUTURE：10m或10d 分别表示10个月或10天  ASSIGN_FROM_REQUEST：在开卡Reuqest请求中按rule_value取值，现在和field_name对应的为（OpenDate、ValidDate、Level、Point、Balance）
        /// </summary>
        /// <value>规则值，根据rule_name，采取相应取值策略  CONST：直接取rule_value作为卡属性值  DATE_IN_FUTURE：10m或10d 分别表示10个月或10天  ASSIGN_FROM_REQUEST：在开卡Reuqest请求中按rule_value取值，现在和field_name对应的为（OpenDate、ValidDate、Level、Point、Balance）</value>
        [DataMember(Name = "rule_value", EmitDefaultValue = false)]
        public string RuleValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TemplateFieldRuleDTO {\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  RuleName: ").Append(RuleName).Append("\n");
            sb.Append("  RuleValue: ").Append(RuleValue).Append("\n");
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
            return this.Equals(input as TemplateFieldRuleDTO);
        }

        /// <summary>
        /// Returns true if TemplateFieldRuleDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateFieldRuleDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateFieldRuleDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FieldName == input.FieldName ||
                    (this.FieldName != null &&
                    this.FieldName.Equals(input.FieldName))
                ) && 
                (
                    this.RuleName == input.RuleName ||
                    (this.RuleName != null &&
                    this.RuleName.Equals(input.RuleName))
                ) && 
                (
                    this.RuleValue == input.RuleValue ||
                    (this.RuleValue != null &&
                    this.RuleValue.Equals(input.RuleValue))
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
                if (this.FieldName != null)
                {
                    hashCode = (hashCode * 59) + this.FieldName.GetHashCode();
                }
                if (this.RuleName != null)
                {
                    hashCode = (hashCode * 59) + this.RuleName.GetHashCode();
                }
                if (this.RuleValue != null)
                {
                    hashCode = (hashCode * 59) + this.RuleValue.GetHashCode();
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
