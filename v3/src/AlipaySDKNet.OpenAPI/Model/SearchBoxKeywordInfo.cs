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
    /// SearchBoxKeywordInfo
    /// </summary>
    [DataContract(Name = "SearchBoxKeywordInfo")]
    public partial class SearchBoxKeywordInfo : IEquatable<SearchBoxKeywordInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchBoxKeywordInfo" /> class.
        /// </summary>
        /// <param name="applyNo">申请单号.</param>
        /// <param name="failReason">审核失败原因.</param>
        /// <param name="gmtModified">修改时间.</param>
        /// <param name="keywords">关键词.</param>
        /// <param name="moduleId">模块ID.</param>
        /// <param name="status">ONLINE- -上架 REJECT- -驳回 OFFLINE-已下架.</param>
        public SearchBoxKeywordInfo(string applyNo = default(string), string failReason = default(string), string gmtModified = default(string), List<string> keywords = default(List<string>), string moduleId = default(string), string status = default(string))
        {
            this.ApplyNo = applyNo;
            this.FailReason = failReason;
            this.GmtModified = gmtModified;
            this.Keywords = keywords;
            this.ModuleId = moduleId;
            this.Status = status;
        }

        /// <summary>
        /// 申请单号
        /// </summary>
        /// <value>申请单号</value>
        [DataMember(Name = "apply_no", EmitDefaultValue = false)]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 审核失败原因
        /// </summary>
        /// <value>审核失败原因</value>
        [DataMember(Name = "fail_reason", EmitDefaultValue = false)]
        public string FailReason { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        /// <value>修改时间</value>
        [DataMember(Name = "gmt_modified", EmitDefaultValue = false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// 关键词
        /// </summary>
        /// <value>关键词</value>
        [DataMember(Name = "keywords", EmitDefaultValue = false)]
        public List<string> Keywords { get; set; }

        /// <summary>
        /// 模块ID
        /// </summary>
        /// <value>模块ID</value>
        [DataMember(Name = "module_id", EmitDefaultValue = false)]
        public string ModuleId { get; set; }

        /// <summary>
        /// ONLINE- -上架 REJECT- -驳回 OFFLINE-已下架
        /// </summary>
        /// <value>ONLINE- -上架 REJECT- -驳回 OFFLINE-已下架</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchBoxKeywordInfo {\n");
            sb.Append("  ApplyNo: ").Append(ApplyNo).Append("\n");
            sb.Append("  FailReason: ").Append(FailReason).Append("\n");
            sb.Append("  GmtModified: ").Append(GmtModified).Append("\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
            sb.Append("  ModuleId: ").Append(ModuleId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as SearchBoxKeywordInfo);
        }

        /// <summary>
        /// Returns true if SearchBoxKeywordInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchBoxKeywordInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchBoxKeywordInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ApplyNo == input.ApplyNo ||
                    (this.ApplyNo != null &&
                    this.ApplyNo.Equals(input.ApplyNo))
                ) && 
                (
                    this.FailReason == input.FailReason ||
                    (this.FailReason != null &&
                    this.FailReason.Equals(input.FailReason))
                ) && 
                (
                    this.GmtModified == input.GmtModified ||
                    (this.GmtModified != null &&
                    this.GmtModified.Equals(input.GmtModified))
                ) && 
                (
                    this.Keywords == input.Keywords ||
                    this.Keywords != null &&
                    input.Keywords != null &&
                    this.Keywords.SequenceEqual(input.Keywords)
                ) && 
                (
                    this.ModuleId == input.ModuleId ||
                    (this.ModuleId != null &&
                    this.ModuleId.Equals(input.ModuleId))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.ApplyNo != null)
                {
                    hashCode = (hashCode * 59) + this.ApplyNo.GetHashCode();
                }
                if (this.FailReason != null)
                {
                    hashCode = (hashCode * 59) + this.FailReason.GetHashCode();
                }
                if (this.GmtModified != null)
                {
                    hashCode = (hashCode * 59) + this.GmtModified.GetHashCode();
                }
                if (this.Keywords != null)
                {
                    hashCode = (hashCode * 59) + this.Keywords.GetHashCode();
                }
                if (this.ModuleId != null)
                {
                    hashCode = (hashCode * 59) + this.ModuleId.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
