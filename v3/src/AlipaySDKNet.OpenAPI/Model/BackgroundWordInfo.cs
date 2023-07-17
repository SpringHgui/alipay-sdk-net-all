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
    /// BackgroundWordInfo
    /// </summary>
    [DataContract(Name = "BackgroundWordInfo")]
    public partial class BackgroundWordInfo : IEquatable<BackgroundWordInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BackgroundWordInfo" /> class.
        /// </summary>
        /// <param name="backgroundWord">底纹词.</param>
        /// <param name="failReason">审核失败原因.</param>
        /// <param name="status">底纹词状态.</param>
        public BackgroundWordInfo(string backgroundWord = default(string), string failReason = default(string), string status = default(string))
        {
            this.BackgroundWord = backgroundWord;
            this.FailReason = failReason;
            this.Status = status;
        }

        /// <summary>
        /// 底纹词
        /// </summary>
        /// <value>底纹词</value>
        [DataMember(Name = "background_word", EmitDefaultValue = false)]
        public string BackgroundWord { get; set; }

        /// <summary>
        /// 审核失败原因
        /// </summary>
        /// <value>审核失败原因</value>
        [DataMember(Name = "fail_reason", EmitDefaultValue = false)]
        public string FailReason { get; set; }

        /// <summary>
        /// 底纹词状态
        /// </summary>
        /// <value>底纹词状态</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BackgroundWordInfo {\n");
            sb.Append("  BackgroundWord: ").Append(BackgroundWord).Append("\n");
            sb.Append("  FailReason: ").Append(FailReason).Append("\n");
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
            return this.Equals(input as BackgroundWordInfo);
        }

        /// <summary>
        /// Returns true if BackgroundWordInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of BackgroundWordInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BackgroundWordInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BackgroundWord == input.BackgroundWord ||
                    (this.BackgroundWord != null &&
                    this.BackgroundWord.Equals(input.BackgroundWord))
                ) && 
                (
                    this.FailReason == input.FailReason ||
                    (this.FailReason != null &&
                    this.FailReason.Equals(input.FailReason))
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
                if (this.BackgroundWord != null)
                {
                    hashCode = (hashCode * 59) + this.BackgroundWord.GetHashCode();
                }
                if (this.FailReason != null)
                {
                    hashCode = (hashCode * 59) + this.FailReason.GetHashCode();
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
