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
    /// AlipayMobileStdPublicMessageCustomSendModel
    /// </summary>
    [DataContract(Name = "AlipayMobileStdPublicMessageCustomSendModel")]
    public partial class AlipayMobileStdPublicMessageCustomSendModel : IEquatable<AlipayMobileStdPublicMessageCustomSendModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMobileStdPublicMessageCustomSendModel" /> class.
        /// </summary>
        /// <param name="bizContent">业务内容，其中包括消息类型msgType、消息体和消息接受人toUserId三大块，具体参见“表1-2 服务窗单发客服消息的biz_content参数说明”。.</param>
        public AlipayMobileStdPublicMessageCustomSendModel(string bizContent = default(string))
        {
            this.BizContent = bizContent;
        }

        /// <summary>
        /// 业务内容，其中包括消息类型msgType、消息体和消息接受人toUserId三大块，具体参见“表1-2 服务窗单发客服消息的biz_content参数说明”。
        /// </summary>
        /// <value>业务内容，其中包括消息类型msgType、消息体和消息接受人toUserId三大块，具体参见“表1-2 服务窗单发客服消息的biz_content参数说明”。</value>
        [DataMember(Name = "biz_content", EmitDefaultValue = false)]
        public string BizContent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMobileStdPublicMessageCustomSendModel {\n");
            sb.Append("  BizContent: ").Append(BizContent).Append("\n");
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
            return this.Equals(input as AlipayMobileStdPublicMessageCustomSendModel);
        }

        /// <summary>
        /// Returns true if AlipayMobileStdPublicMessageCustomSendModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMobileStdPublicMessageCustomSendModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMobileStdPublicMessageCustomSendModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BizContent == input.BizContent ||
                    (this.BizContent != null &&
                    this.BizContent.Equals(input.BizContent))
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
                if (this.BizContent != null)
                {
                    hashCode = (hashCode * 59) + this.BizContent.GetHashCode();
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
