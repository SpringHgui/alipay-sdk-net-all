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
    /// AlipayOpenPublicMenuModifyModel
    /// </summary>
    [DataContract(Name = "AlipayOpenPublicMenuModifyModel")]
    public partial class AlipayOpenPublicMenuModifyModel : IEquatable<AlipayOpenPublicMenuModifyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicMenuModifyModel" /> class.
        /// </summary>
        /// <param name="button">一级菜单列表。说明： * 如果是文本菜单，最多有4个一级菜单，若开发者在后台打开了\&quot;咨询反馈\&quot;的开关，则只能有3个一级菜单。 * 如果是 ICON 菜单信息，最多有80个一级菜单(忽略二级菜单)。.</param>
        /// <param name="type">菜单类型，不填时默认为 text（文本型菜单）。枚举值如下： * text：文本型菜单。 * icon：表示 icon 型菜单，当传值为\&quot;icon\&quot;时，菜单节点的icon字段必传。.</param>
        public AlipayOpenPublicMenuModifyModel(List<ButtonObject> button = default(List<ButtonObject>), string type = default(string))
        {
            this.Button = button;
            this.Type = type;
        }

        /// <summary>
        /// 一级菜单列表。说明： * 如果是文本菜单，最多有4个一级菜单，若开发者在后台打开了\&quot;咨询反馈\&quot;的开关，则只能有3个一级菜单。 * 如果是 ICON 菜单信息，最多有80个一级菜单(忽略二级菜单)。
        /// </summary>
        /// <value>一级菜单列表。说明： * 如果是文本菜单，最多有4个一级菜单，若开发者在后台打开了\&quot;咨询反馈\&quot;的开关，则只能有3个一级菜单。 * 如果是 ICON 菜单信息，最多有80个一级菜单(忽略二级菜单)。</value>
        [DataMember(Name = "button", EmitDefaultValue = false)]
        public List<ButtonObject> Button { get; set; }

        /// <summary>
        /// 菜单类型，不填时默认为 text（文本型菜单）。枚举值如下： * text：文本型菜单。 * icon：表示 icon 型菜单，当传值为\&quot;icon\&quot;时，菜单节点的icon字段必传。
        /// </summary>
        /// <value>菜单类型，不填时默认为 text（文本型菜单）。枚举值如下： * text：文本型菜单。 * icon：表示 icon 型菜单，当传值为\&quot;icon\&quot;时，菜单节点的icon字段必传。</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenPublicMenuModifyModel {\n");
            sb.Append("  Button: ").Append(Button).Append("\n");
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
            return this.Equals(input as AlipayOpenPublicMenuModifyModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenPublicMenuModifyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenPublicMenuModifyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenPublicMenuModifyModel input)
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
