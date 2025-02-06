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
    /// AlipayOpenPublicMessageTotalSendModel
    /// </summary>
    [DataContract(Name = "AlipayOpenPublicMessageTotalSendModel")]
    public partial class AlipayOpenPublicMessageTotalSendModel : IEquatable<AlipayOpenPublicMessageTotalSendModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicMessageTotalSendModel" /> class.
        /// </summary>
        /// <param name="articles">图文消息，当 msg_type为image-text，本参数必填。 .</param>
        /// <param name="msgType">消息类型。枚举支持： * text：表示文本消息； * image-text：表示图文消息。.</param>
        /// <param name="text">text.</param>
        public AlipayOpenPublicMessageTotalSendModel(List<Article> articles = default(List<Article>), string msgType = default(string), Text text = default(Text))
        {
            this.Articles = articles;
            this.MsgType = msgType;
            this.Text = text;
        }

        /// <summary>
        /// 图文消息，当 msg_type为image-text，本参数必填。 
        /// </summary>
        /// <value>图文消息，当 msg_type为image-text，本参数必填。 </value>
        [DataMember(Name = "articles", EmitDefaultValue = false)]
        public List<Article> Articles { get; set; }

        /// <summary>
        /// 消息类型。枚举支持： * text：表示文本消息； * image-text：表示图文消息。
        /// </summary>
        /// <value>消息类型。枚举支持： * text：表示文本消息； * image-text：表示图文消息。</value>
        [DataMember(Name = "msg_type", EmitDefaultValue = false)]
        public string MsgType { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name = "text", EmitDefaultValue = false)]
        public Text Text { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenPublicMessageTotalSendModel {\n");
            sb.Append("  Articles: ").Append(Articles).Append("\n");
            sb.Append("  MsgType: ").Append(MsgType).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
            return this.Equals(input as AlipayOpenPublicMessageTotalSendModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenPublicMessageTotalSendModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenPublicMessageTotalSendModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenPublicMessageTotalSendModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Articles == input.Articles ||
                    this.Articles != null &&
                    input.Articles != null &&
                    this.Articles.SequenceEqual(input.Articles)
                ) && 
                (
                    this.MsgType == input.MsgType ||
                    (this.MsgType != null &&
                    this.MsgType.Equals(input.MsgType))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
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
                if (this.Articles != null)
                {
                    hashCode = (hashCode * 59) + this.Articles.GetHashCode();
                }
                if (this.MsgType != null)
                {
                    hashCode = (hashCode * 59) + this.MsgType.GetHashCode();
                }
                if (this.Text != null)
                {
                    hashCode = (hashCode * 59) + this.Text.GetHashCode();
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
