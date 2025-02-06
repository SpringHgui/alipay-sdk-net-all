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
    /// AlipayOpenSearchAppkeywordQuerystatusResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenSearchAppkeywordQuerystatusResponseModel")]
    public partial class AlipayOpenSearchAppkeywordQuerystatusResponseModel : IEquatable<AlipayOpenSearchAppkeywordQuerystatusResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenSearchAppkeywordQuerystatusResponseModel" /> class.
        /// </summary>
        /// <param name="keyWords">关键词工单审核状态返回值.</param>
        public AlipayOpenSearchAppkeywordQuerystatusResponseModel(List<KeyWordInfo> keyWords = default(List<KeyWordInfo>))
        {
            this.KeyWords = keyWords;
        }

        /// <summary>
        /// 关键词工单审核状态返回值
        /// </summary>
        /// <value>关键词工单审核状态返回值</value>
        [DataMember(Name = "key_words", EmitDefaultValue = false)]
        public List<KeyWordInfo> KeyWords { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenSearchAppkeywordQuerystatusResponseModel {\n");
            sb.Append("  KeyWords: ").Append(KeyWords).Append("\n");
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
            return this.Equals(input as AlipayOpenSearchAppkeywordQuerystatusResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenSearchAppkeywordQuerystatusResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenSearchAppkeywordQuerystatusResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenSearchAppkeywordQuerystatusResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.KeyWords == input.KeyWords ||
                    this.KeyWords != null &&
                    input.KeyWords != null &&
                    this.KeyWords.SequenceEqual(input.KeyWords)
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
                if (this.KeyWords != null)
                {
                    hashCode = (hashCode * 59) + this.KeyWords.GetHashCode();
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
