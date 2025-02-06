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
    /// ReplyRecordResponse
    /// </summary>
    [DataContract(Name = "ReplyRecordResponse")]
    public partial class ReplyRecordResponse : IEquatable<ReplyRecordResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReplyRecordResponse" /> class.
        /// </summary>
        /// <param name="content">回复内容.</param>
        /// <param name="gmtCreate">回复时间.</param>
        /// <param name="images">回复图片.</param>
        /// <param name="replierName">回复人名称.</param>
        /// <param name="replierRole">用户：USER  商家：MERCHANT 系统：SYSTEM 审核小二：AUDITOR 政府单位：GOVERNMENT.</param>
        public ReplyRecordResponse(string content = default(string), string gmtCreate = default(string), List<string> images = default(List<string>), string replierName = default(string), string replierRole = default(string))
        {
            this.Content = content;
            this.GmtCreate = gmtCreate;
            this.Images = images;
            this.ReplierName = replierName;
            this.ReplierRole = replierRole;
        }

        /// <summary>
        /// 回复内容
        /// </summary>
        /// <value>回复内容</value>
        [DataMember(Name = "content", EmitDefaultValue = false)]
        public string Content { get; set; }

        /// <summary>
        /// 回复时间
        /// </summary>
        /// <value>回复时间</value>
        [DataMember(Name = "gmt_create", EmitDefaultValue = false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 回复图片
        /// </summary>
        /// <value>回复图片</value>
        [DataMember(Name = "images", EmitDefaultValue = false)]
        public List<string> Images { get; set; }

        /// <summary>
        /// 回复人名称
        /// </summary>
        /// <value>回复人名称</value>
        [DataMember(Name = "replier_name", EmitDefaultValue = false)]
        public string ReplierName { get; set; }

        /// <summary>
        /// 用户：USER  商家：MERCHANT 系统：SYSTEM 审核小二：AUDITOR 政府单位：GOVERNMENT
        /// </summary>
        /// <value>用户：USER  商家：MERCHANT 系统：SYSTEM 审核小二：AUDITOR 政府单位：GOVERNMENT</value>
        [DataMember(Name = "replier_role", EmitDefaultValue = false)]
        public string ReplierRole { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReplyRecordResponse {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  GmtCreate: ").Append(GmtCreate).Append("\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
            sb.Append("  ReplierName: ").Append(ReplierName).Append("\n");
            sb.Append("  ReplierRole: ").Append(ReplierRole).Append("\n");
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
            return this.Equals(input as ReplyRecordResponse);
        }

        /// <summary>
        /// Returns true if ReplyRecordResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ReplyRecordResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReplyRecordResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.GmtCreate == input.GmtCreate ||
                    (this.GmtCreate != null &&
                    this.GmtCreate.Equals(input.GmtCreate))
                ) && 
                (
                    this.Images == input.Images ||
                    this.Images != null &&
                    input.Images != null &&
                    this.Images.SequenceEqual(input.Images)
                ) && 
                (
                    this.ReplierName == input.ReplierName ||
                    (this.ReplierName != null &&
                    this.ReplierName.Equals(input.ReplierName))
                ) && 
                (
                    this.ReplierRole == input.ReplierRole ||
                    (this.ReplierRole != null &&
                    this.ReplierRole.Equals(input.ReplierRole))
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
                if (this.Content != null)
                {
                    hashCode = (hashCode * 59) + this.Content.GetHashCode();
                }
                if (this.GmtCreate != null)
                {
                    hashCode = (hashCode * 59) + this.GmtCreate.GetHashCode();
                }
                if (this.Images != null)
                {
                    hashCode = (hashCode * 59) + this.Images.GetHashCode();
                }
                if (this.ReplierName != null)
                {
                    hashCode = (hashCode * 59) + this.ReplierName.GetHashCode();
                }
                if (this.ReplierRole != null)
                {
                    hashCode = (hashCode * 59) + this.ReplierRole.GetHashCode();
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
