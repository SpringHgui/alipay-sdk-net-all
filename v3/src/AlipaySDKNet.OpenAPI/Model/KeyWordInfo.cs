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
    /// KeyWordInfo
    /// </summary>
    [DataContract(Name = "KeyWordInfo")]
    public partial class KeyWordInfo : IEquatable<KeyWordInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="KeyWordInfo" /> class.
        /// </summary>
        /// <param name="applyNo">审核单号.</param>
        /// <param name="auditKeyWord">审核中的关键词.</param>
        /// <param name="auditReason">审核人的备注信息.</param>
        /// <param name="auditTime">审核时间.</param>
        /// <param name="configId">关键词配置ID.</param>
        /// <param name="gmtCreate">创建时间.</param>
        /// <param name="keyWord">审核完成的关键词.</param>
        /// <param name="status">关键词当前状态.</param>
        public KeyWordInfo(string applyNo = default(string), string auditKeyWord = default(string), string auditReason = default(string), string auditTime = default(string), string configId = default(string), string gmtCreate = default(string), string keyWord = default(string), string status = default(string))
        {
            this.ApplyNo = applyNo;
            this.AuditKeyWord = auditKeyWord;
            this.AuditReason = auditReason;
            this.AuditTime = auditTime;
            this.ConfigId = configId;
            this.GmtCreate = gmtCreate;
            this.KeyWord = keyWord;
            this.Status = status;
        }

        /// <summary>
        /// 审核单号
        /// </summary>
        /// <value>审核单号</value>
        [DataMember(Name = "apply_no", EmitDefaultValue = false)]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 审核中的关键词
        /// </summary>
        /// <value>审核中的关键词</value>
        [DataMember(Name = "audit_key_word", EmitDefaultValue = false)]
        public string AuditKeyWord { get; set; }

        /// <summary>
        /// 审核人的备注信息
        /// </summary>
        /// <value>审核人的备注信息</value>
        [DataMember(Name = "audit_reason", EmitDefaultValue = false)]
        public string AuditReason { get; set; }

        /// <summary>
        /// 审核时间
        /// </summary>
        /// <value>审核时间</value>
        [DataMember(Name = "audit_time", EmitDefaultValue = false)]
        public string AuditTime { get; set; }

        /// <summary>
        /// 关键词配置ID
        /// </summary>
        /// <value>关键词配置ID</value>
        [DataMember(Name = "config_id", EmitDefaultValue = false)]
        public string ConfigId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        /// <value>创建时间</value>
        [DataMember(Name = "gmt_create", EmitDefaultValue = false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 审核完成的关键词
        /// </summary>
        /// <value>审核完成的关键词</value>
        [DataMember(Name = "key_word", EmitDefaultValue = false)]
        public string KeyWord { get; set; }

        /// <summary>
        /// 关键词当前状态
        /// </summary>
        /// <value>关键词当前状态</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class KeyWordInfo {\n");
            sb.Append("  ApplyNo: ").Append(ApplyNo).Append("\n");
            sb.Append("  AuditKeyWord: ").Append(AuditKeyWord).Append("\n");
            sb.Append("  AuditReason: ").Append(AuditReason).Append("\n");
            sb.Append("  AuditTime: ").Append(AuditTime).Append("\n");
            sb.Append("  ConfigId: ").Append(ConfigId).Append("\n");
            sb.Append("  GmtCreate: ").Append(GmtCreate).Append("\n");
            sb.Append("  KeyWord: ").Append(KeyWord).Append("\n");
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
            return this.Equals(input as KeyWordInfo);
        }

        /// <summary>
        /// Returns true if KeyWordInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of KeyWordInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(KeyWordInfo input)
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
                    this.AuditKeyWord == input.AuditKeyWord ||
                    (this.AuditKeyWord != null &&
                    this.AuditKeyWord.Equals(input.AuditKeyWord))
                ) && 
                (
                    this.AuditReason == input.AuditReason ||
                    (this.AuditReason != null &&
                    this.AuditReason.Equals(input.AuditReason))
                ) && 
                (
                    this.AuditTime == input.AuditTime ||
                    (this.AuditTime != null &&
                    this.AuditTime.Equals(input.AuditTime))
                ) && 
                (
                    this.ConfigId == input.ConfigId ||
                    (this.ConfigId != null &&
                    this.ConfigId.Equals(input.ConfigId))
                ) && 
                (
                    this.GmtCreate == input.GmtCreate ||
                    (this.GmtCreate != null &&
                    this.GmtCreate.Equals(input.GmtCreate))
                ) && 
                (
                    this.KeyWord == input.KeyWord ||
                    (this.KeyWord != null &&
                    this.KeyWord.Equals(input.KeyWord))
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
                if (this.AuditKeyWord != null)
                {
                    hashCode = (hashCode * 59) + this.AuditKeyWord.GetHashCode();
                }
                if (this.AuditReason != null)
                {
                    hashCode = (hashCode * 59) + this.AuditReason.GetHashCode();
                }
                if (this.AuditTime != null)
                {
                    hashCode = (hashCode * 59) + this.AuditTime.GetHashCode();
                }
                if (this.ConfigId != null)
                {
                    hashCode = (hashCode * 59) + this.ConfigId.GetHashCode();
                }
                if (this.GmtCreate != null)
                {
                    hashCode = (hashCode * 59) + this.GmtCreate.GetHashCode();
                }
                if (this.KeyWord != null)
                {
                    hashCode = (hashCode * 59) + this.KeyWord.GetHashCode();
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
