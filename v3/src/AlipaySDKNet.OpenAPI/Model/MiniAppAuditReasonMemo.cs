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
    /// MiniAppAuditReasonMemo
    /// </summary>
    [DataContract(Name = "MiniAppAuditReasonMemo")]
    public partial class MiniAppAuditReasonMemo : IEquatable<MiniAppAuditReasonMemo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MiniAppAuditReasonMemo" /> class.
        /// </summary>
        /// <param name="memo">驳回原因.</param>
        /// <param name="memoImageList">规则图片链接.</param>
        public MiniAppAuditReasonMemo(string memo = default(string), List<string> memoImageList = default(List<string>))
        {
            this.Memo = memo;
            this.MemoImageList = memoImageList;
        }

        /// <summary>
        /// 驳回原因
        /// </summary>
        /// <value>驳回原因</value>
        [DataMember(Name = "memo", EmitDefaultValue = false)]
        public string Memo { get; set; }

        /// <summary>
        /// 规则图片链接
        /// </summary>
        /// <value>规则图片链接</value>
        [DataMember(Name = "memo_image_list", EmitDefaultValue = false)]
        public List<string> MemoImageList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MiniAppAuditReasonMemo {\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
            sb.Append("  MemoImageList: ").Append(MemoImageList).Append("\n");
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
            return this.Equals(input as MiniAppAuditReasonMemo);
        }

        /// <summary>
        /// Returns true if MiniAppAuditReasonMemo instances are equal
        /// </summary>
        /// <param name="input">Instance of MiniAppAuditReasonMemo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MiniAppAuditReasonMemo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Memo == input.Memo ||
                    (this.Memo != null &&
                    this.Memo.Equals(input.Memo))
                ) && 
                (
                    this.MemoImageList == input.MemoImageList ||
                    this.MemoImageList != null &&
                    input.MemoImageList != null &&
                    this.MemoImageList.SequenceEqual(input.MemoImageList)
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
                if (this.Memo != null)
                {
                    hashCode = (hashCode * 59) + this.Memo.GetHashCode();
                }
                if (this.MemoImageList != null)
                {
                    hashCode = (hashCode * 59) + this.MemoImageList.GetHashCode();
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
