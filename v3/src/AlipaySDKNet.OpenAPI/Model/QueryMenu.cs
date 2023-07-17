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
    /// QueryMenu
    /// </summary>
    [DataContract(Name = "QueryMenu")]
    public partial class QueryMenu : IEquatable<QueryMenu>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QueryMenu" /> class.
        /// </summary>
        /// <param name="button">一级菜单列表.</param>
        /// <param name="labelRule">标签规则项列表.</param>
        /// <param name="menuKey">菜单唯一id.</param>
        /// <param name="type">菜单类型，icon：icon型菜单，text：文本型菜单.</param>
        public QueryMenu(List<ButtonObject> button = default(List<ButtonObject>), List<QueryLabelRule> labelRule = default(List<QueryLabelRule>), string menuKey = default(string), string type = default(string))
        {
            this.Button = button;
            this.LabelRule = labelRule;
            this.MenuKey = menuKey;
            this.Type = type;
        }

        /// <summary>
        /// 一级菜单列表
        /// </summary>
        /// <value>一级菜单列表</value>
        [DataMember(Name = "button", EmitDefaultValue = false)]
        public List<ButtonObject> Button { get; set; }

        /// <summary>
        /// 标签规则项列表
        /// </summary>
        /// <value>标签规则项列表</value>
        [DataMember(Name = "label_rule", EmitDefaultValue = false)]
        public List<QueryLabelRule> LabelRule { get; set; }

        /// <summary>
        /// 菜单唯一id
        /// </summary>
        /// <value>菜单唯一id</value>
        [DataMember(Name = "menu_key", EmitDefaultValue = false)]
        public string MenuKey { get; set; }

        /// <summary>
        /// 菜单类型，icon：icon型菜单，text：文本型菜单
        /// </summary>
        /// <value>菜单类型，icon：icon型菜单，text：文本型菜单</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QueryMenu {\n");
            sb.Append("  Button: ").Append(Button).Append("\n");
            sb.Append("  LabelRule: ").Append(LabelRule).Append("\n");
            sb.Append("  MenuKey: ").Append(MenuKey).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as QueryMenu);
        }

        /// <summary>
        /// Returns true if QueryMenu instances are equal
        /// </summary>
        /// <param name="input">Instance of QueryMenu to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QueryMenu input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Button == input.Button ||
                    this.Button != null &&
                    input.Button != null &&
                    this.Button.SequenceEqual(input.Button)
                ) && 
                (
                    this.LabelRule == input.LabelRule ||
                    this.LabelRule != null &&
                    input.LabelRule != null &&
                    this.LabelRule.SequenceEqual(input.LabelRule)
                ) && 
                (
                    this.MenuKey == input.MenuKey ||
                    (this.MenuKey != null &&
                    this.MenuKey.Equals(input.MenuKey))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Button != null)
                {
                    hashCode = (hashCode * 59) + this.Button.GetHashCode();
                }
                if (this.LabelRule != null)
                {
                    hashCode = (hashCode * 59) + this.LabelRule.GetHashCode();
                }
                if (this.MenuKey != null)
                {
                    hashCode = (hashCode * 59) + this.MenuKey.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
