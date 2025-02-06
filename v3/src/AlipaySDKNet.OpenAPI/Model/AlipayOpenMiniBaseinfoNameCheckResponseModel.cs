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
    /// AlipayOpenMiniBaseinfoNameCheckResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniBaseinfoNameCheckResponseModel")]
    public partial class AlipayOpenMiniBaseinfoNameCheckResponseModel : IEquatable<AlipayOpenMiniBaseinfoNameCheckResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniBaseinfoNameCheckResponseModel" /> class.
        /// </summary>
        /// <param name="checkCode">校验结果code.</param>
        /// <param name="checkMemo">名称校验结果详细说明.</param>
        public AlipayOpenMiniBaseinfoNameCheckResponseModel(string checkCode = default(string), string checkMemo = default(string))
        {
            this.CheckCode = checkCode;
            this.CheckMemo = checkMemo;
        }

        /// <summary>
        /// 校验结果code
        /// </summary>
        /// <value>校验结果code</value>
        [DataMember(Name = "check_code", EmitDefaultValue = false)]
        public string CheckCode { get; set; }

        /// <summary>
        /// 名称校验结果详细说明
        /// </summary>
        /// <value>名称校验结果详细说明</value>
        [DataMember(Name = "check_memo", EmitDefaultValue = false)]
        public string CheckMemo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniBaseinfoNameCheckResponseModel {\n");
            sb.Append("  CheckCode: ").Append(CheckCode).Append("\n");
            sb.Append("  CheckMemo: ").Append(CheckMemo).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniBaseinfoNameCheckResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniBaseinfoNameCheckResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniBaseinfoNameCheckResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniBaseinfoNameCheckResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CheckCode == input.CheckCode ||
                    (this.CheckCode != null &&
                    this.CheckCode.Equals(input.CheckCode))
                ) && 
                (
                    this.CheckMemo == input.CheckMemo ||
                    (this.CheckMemo != null &&
                    this.CheckMemo.Equals(input.CheckMemo))
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
                if (this.CheckCode != null)
                {
                    hashCode = (hashCode * 59) + this.CheckCode.GetHashCode();
                }
                if (this.CheckMemo != null)
                {
                    hashCode = (hashCode * 59) + this.CheckMemo.GetHashCode();
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
