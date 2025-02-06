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
    /// MiniAppAuditReason
    /// </summary>
    [DataContract(Name = "MiniAppAuditReason")]
    public partial class MiniAppAuditReason : IEquatable<MiniAppAuditReason>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MiniAppAuditReason" /> class.
        /// </summary>
        /// <param name="auditImages">审核图片列表.</param>
        /// <param name="memos">驳回原因列表.</param>
        public MiniAppAuditReason(List<string> auditImages = default(List<string>), List<MiniAppAuditReasonMemo> memos = default(List<MiniAppAuditReasonMemo>))
        {
            this.AuditImages = auditImages;
            this.Memos = memos;
        }

        /// <summary>
        /// 审核图片列表
        /// </summary>
        /// <value>审核图片列表</value>
        [DataMember(Name = "audit_images", EmitDefaultValue = false)]
        public List<string> AuditImages { get; set; }

        /// <summary>
        /// 驳回原因列表
        /// </summary>
        /// <value>驳回原因列表</value>
        [DataMember(Name = "memos", EmitDefaultValue = false)]
        public List<MiniAppAuditReasonMemo> Memos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MiniAppAuditReason {\n");
            sb.Append("  AuditImages: ").Append(AuditImages).Append("\n");
            sb.Append("  Memos: ").Append(Memos).Append("\n");
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
            return this.Equals(input as MiniAppAuditReason);
        }

        /// <summary>
        /// Returns true if MiniAppAuditReason instances are equal
        /// </summary>
        /// <param name="input">Instance of MiniAppAuditReason to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MiniAppAuditReason input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AuditImages == input.AuditImages ||
                    this.AuditImages != null &&
                    input.AuditImages != null &&
                    this.AuditImages.SequenceEqual(input.AuditImages)
                ) && 
                (
                    this.Memos == input.Memos ||
                    this.Memos != null &&
                    input.Memos != null &&
                    this.Memos.SequenceEqual(input.Memos)
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
                if (this.AuditImages != null)
                {
                    hashCode = (hashCode * 59) + this.AuditImages.GetHashCode();
                }
                if (this.Memos != null)
                {
                    hashCode = (hashCode * 59) + this.Memos.GetHashCode();
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
