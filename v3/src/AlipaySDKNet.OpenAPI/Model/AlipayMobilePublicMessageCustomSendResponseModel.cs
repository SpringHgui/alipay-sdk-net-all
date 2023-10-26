/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2023-10-26
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
    /// AlipayMobilePublicMessageCustomSendResponseModel
    /// </summary>
    [DataContract(Name = "AlipayMobilePublicMessageCustomSendResponseModel")]
    public partial class AlipayMobilePublicMessageCustomSendResponseModel : IEquatable<AlipayMobilePublicMessageCustomSendResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMobilePublicMessageCustomSendResponseModel" /> class.
        /// </summary>
        /// <param name="code">结果码.</param>
        /// <param name="msg">结果描述.</param>
        public AlipayMobilePublicMessageCustomSendResponseModel(string code = default(string), string msg = default(string))
        {
            this.Code = code;
            this.Msg = msg;
        }

        /// <summary>
        /// 结果码
        /// </summary>
        /// <value>结果码</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// 结果描述
        /// </summary>
        /// <value>结果描述</value>
        [DataMember(Name = "msg", EmitDefaultValue = false)]
        public string Msg { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMobilePublicMessageCustomSendResponseModel {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Msg: ").Append(Msg).Append("\n");
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
            return this.Equals(input as AlipayMobilePublicMessageCustomSendResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayMobilePublicMessageCustomSendResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMobilePublicMessageCustomSendResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMobilePublicMessageCustomSendResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Msg == input.Msg ||
                    (this.Msg != null &&
                    this.Msg.Equals(input.Msg))
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
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.Msg != null)
                {
                    hashCode = (hashCode * 59) + this.Msg.GetHashCode();
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
