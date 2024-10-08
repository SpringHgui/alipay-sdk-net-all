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
    /// AlipayMerchantTradecomplainReplySubmitModel
    /// </summary>
    [DataContract(Name = "AlipayMerchantTradecomplainReplySubmitModel")]
    public partial class AlipayMerchantTradecomplainReplySubmitModel : IEquatable<AlipayMerchantTradecomplainReplySubmitModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMerchantTradecomplainReplySubmitModel" /> class.
        /// </summary>
        /// <param name="complainEventId">支付宝侧投诉单号.</param>
        /// <param name="replyContent">回复留言内容.</param>
        /// <param name="replyImages">商家处理问题反馈时的回复凭证的图片id，多个逗号隔开（图片id可以通过\&quot;商户上传处理图片\&quot;接口获取）.</param>
        public AlipayMerchantTradecomplainReplySubmitModel(string complainEventId = default(string), string replyContent = default(string), string replyImages = default(string))
        {
            this.ComplainEventId = complainEventId;
            this.ReplyContent = replyContent;
            this.ReplyImages = replyImages;
        }

        /// <summary>
        /// 支付宝侧投诉单号
        /// </summary>
        /// <value>支付宝侧投诉单号</value>
        [DataMember(Name = "complain_event_id", EmitDefaultValue = false)]
        public string ComplainEventId { get; set; }

        /// <summary>
        /// 回复留言内容
        /// </summary>
        /// <value>回复留言内容</value>
        [DataMember(Name = "reply_content", EmitDefaultValue = false)]
        public string ReplyContent { get; set; }

        /// <summary>
        /// 商家处理问题反馈时的回复凭证的图片id，多个逗号隔开（图片id可以通过\&quot;商户上传处理图片\&quot;接口获取）
        /// </summary>
        /// <value>商家处理问题反馈时的回复凭证的图片id，多个逗号隔开（图片id可以通过\&quot;商户上传处理图片\&quot;接口获取）</value>
        [DataMember(Name = "reply_images", EmitDefaultValue = false)]
        public string ReplyImages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMerchantTradecomplainReplySubmitModel {\n");
            sb.Append("  ComplainEventId: ").Append(ComplainEventId).Append("\n");
            sb.Append("  ReplyContent: ").Append(ReplyContent).Append("\n");
            sb.Append("  ReplyImages: ").Append(ReplyImages).Append("\n");
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
            return this.Equals(input as AlipayMerchantTradecomplainReplySubmitModel);
        }

        /// <summary>
        /// Returns true if AlipayMerchantTradecomplainReplySubmitModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMerchantTradecomplainReplySubmitModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMerchantTradecomplainReplySubmitModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ComplainEventId == input.ComplainEventId ||
                    (this.ComplainEventId != null &&
                    this.ComplainEventId.Equals(input.ComplainEventId))
                ) && 
                (
                    this.ReplyContent == input.ReplyContent ||
                    (this.ReplyContent != null &&
                    this.ReplyContent.Equals(input.ReplyContent))
                ) && 
                (
                    this.ReplyImages == input.ReplyImages ||
                    (this.ReplyImages != null &&
                    this.ReplyImages.Equals(input.ReplyImages))
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
                if (this.ComplainEventId != null)
                {
                    hashCode = (hashCode * 59) + this.ComplainEventId.GetHashCode();
                }
                if (this.ReplyContent != null)
                {
                    hashCode = (hashCode * 59) + this.ReplyContent.GetHashCode();
                }
                if (this.ReplyImages != null)
                {
                    hashCode = (hashCode * 59) + this.ReplyImages.GetHashCode();
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
