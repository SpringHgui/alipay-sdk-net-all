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
    /// QueryGroup
    /// </summary>
    [DataContract(Name = "QueryGroup")]
    public partial class QueryGroup : IEquatable<QueryGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryGroup" /> class.
        /// </summary>
        /// <param name="count">人群中包含人数.</param>
        /// <param name="id">分组id.</param>
        /// <param name="labelRule">分组中的圈人规则.</param>
        /// <param name="name">用户分组名称.</param>
        public QueryGroup(int count = default(int), string id = default(string), List<QueryComplexLabelRule> labelRule = default(List<QueryComplexLabelRule>), string name = default(string))
        {
            this.Count = count;
            this.Id = id;
            this.LabelRule = labelRule;
            this.Name = name;
        }

        /// <summary>
        /// 人群中包含人数
        /// </summary>
        /// <value>人群中包含人数</value>
        [DataMember(Name = "count", EmitDefaultValue = false)]
        public int Count { get; set; }

        /// <summary>
        /// 分组id
        /// </summary>
        /// <value>分组id</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// 分组中的圈人规则
        /// </summary>
        /// <value>分组中的圈人规则</value>
        [DataMember(Name = "label_rule", EmitDefaultValue = false)]
        public List<QueryComplexLabelRule> LabelRule { get; set; }

        /// <summary>
        /// 用户分组名称
        /// </summary>
        /// <value>用户分组名称</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QueryGroup {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  LabelRule: ").Append(LabelRule).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as QueryGroup);
        }

        /// <summary>
        /// Returns true if QueryGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of QueryGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryGroup input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Count == input.Count ||
                    this.Count.Equals(input.Count)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.LabelRule == input.LabelRule ||
                    this.LabelRule != null &&
                    input.LabelRule != null &&
                    this.LabelRule.SequenceEqual(input.LabelRule)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                hashCode = (hashCode * 59) + this.Count.GetHashCode();
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.LabelRule != null)
                {
                    hashCode = (hashCode * 59) + this.LabelRule.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
