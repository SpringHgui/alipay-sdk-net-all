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
    /// ItemLabelModifyInfo
    /// </summary>
    [DataContract(Name = "ItemLabelModifyInfo")]
    public partial class ItemLabelModifyInfo : IEquatable<ItemLabelModifyInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemLabelModifyInfo" /> class.
        /// </summary>
        /// <param name="labelKey">标签键  OIL_NUM：油号.</param>
        /// <param name="labelValue">标签值：  OIL_NUM对应的值为：95# 92# 98# 等等.</param>
        public ItemLabelModifyInfo(string labelKey = default(string), string labelValue = default(string))
        {
            this.LabelKey = labelKey;
            this.LabelValue = labelValue;
        }

        /// <summary>
        /// 标签键  OIL_NUM：油号
        /// </summary>
        /// <value>标签键  OIL_NUM：油号</value>
        [DataMember(Name = "label_key", EmitDefaultValue = false)]
        public string LabelKey { get; set; }

        /// <summary>
        /// 标签值：  OIL_NUM对应的值为：95# 92# 98# 等等
        /// </summary>
        /// <value>标签值：  OIL_NUM对应的值为：95# 92# 98# 等等</value>
        [DataMember(Name = "label_value", EmitDefaultValue = false)]
        public string LabelValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ItemLabelModifyInfo {\n");
            sb.Append("  LabelKey: ").Append(LabelKey).Append("\n");
            sb.Append("  LabelValue: ").Append(LabelValue).Append("\n");
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
            return this.Equals(input as ItemLabelModifyInfo);
        }

        /// <summary>
        /// Returns true if ItemLabelModifyInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemLabelModifyInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemLabelModifyInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LabelKey == input.LabelKey ||
                    (this.LabelKey != null &&
                    this.LabelKey.Equals(input.LabelKey))
                ) && 
                (
                    this.LabelValue == input.LabelValue ||
                    (this.LabelValue != null &&
                    this.LabelValue.Equals(input.LabelValue))
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
                if (this.LabelKey != null)
                {
                    hashCode = (hashCode * 59) + this.LabelKey.GetHashCode();
                }
                if (this.LabelValue != null)
                {
                    hashCode = (hashCode * 59) + this.LabelValue.GetHashCode();
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
