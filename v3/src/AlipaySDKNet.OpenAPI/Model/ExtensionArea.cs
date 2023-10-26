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
    /// ExtensionArea
    /// </summary>
    [DataContract(Name = "ExtensionArea")]
    public partial class ExtensionArea : IEquatable<ExtensionArea>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtensionArea" /> class.
        /// </summary>
        /// <param name="gotoUrl">跳转链接，当type为\&quot;image\&quot;时必传，必须是https或alipays开头的url链接。已废弃.</param>
        /// <param name="height">扩展区高度，当type值为\&quot;h5\&quot;时必填，取值范围为200-500的整数.</param>
        /// <param name="name">扩展区名字.</param>
        /// <param name="type">扩展区类型，当前支持的值为h5，表示扩展区内容类型为h5。.</param>
        /// <param name="url">扩展区url，传入h5页面url，必须是https开头的链接.</param>
        public ExtensionArea(string gotoUrl = default(string), int height = default(int), string name = default(string), string type = default(string), string url = default(string))
        {
            this.GotoUrl = gotoUrl;
            this.Height = height;
            this.Name = name;
            this.Type = type;
            this.Url = url;
        }

        /// <summary>
        /// 跳转链接，当type为\&quot;image\&quot;时必传，必须是https或alipays开头的url链接。已废弃
        /// </summary>
        /// <value>跳转链接，当type为\&quot;image\&quot;时必传，必须是https或alipays开头的url链接。已废弃</value>
        [DataMember(Name = "goto_url", EmitDefaultValue = false)]
        public string GotoUrl { get; set; }

        /// <summary>
        /// 扩展区高度，当type值为\&quot;h5\&quot;时必填，取值范围为200-500的整数
        /// </summary>
        /// <value>扩展区高度，当type值为\&quot;h5\&quot;时必填，取值范围为200-500的整数</value>
        [DataMember(Name = "height", EmitDefaultValue = false)]
        public int Height { get; set; }

        /// <summary>
        /// 扩展区名字
        /// </summary>
        /// <value>扩展区名字</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// 扩展区类型，当前支持的值为h5，表示扩展区内容类型为h5。
        /// </summary>
        /// <value>扩展区类型，当前支持的值为h5，表示扩展区内容类型为h5。</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// 扩展区url，传入h5页面url，必须是https开头的链接
        /// </summary>
        /// <value>扩展区url，传入h5页面url，必须是https开头的链接</value>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExtensionArea {\n");
            sb.Append("  GotoUrl: ").Append(GotoUrl).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as ExtensionArea);
        }

        /// <summary>
        /// Returns true if ExtensionArea instances are equal
        /// </summary>
        /// <param name="input">Instance of ExtensionArea to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtensionArea input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GotoUrl == input.GotoUrl ||
                    (this.GotoUrl != null &&
                    this.GotoUrl.Equals(input.GotoUrl))
                ) && 
                (
                    this.Height == input.Height ||
                    this.Height.Equals(input.Height)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.GotoUrl != null)
                {
                    hashCode = (hashCode * 59) + this.GotoUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Height.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
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
