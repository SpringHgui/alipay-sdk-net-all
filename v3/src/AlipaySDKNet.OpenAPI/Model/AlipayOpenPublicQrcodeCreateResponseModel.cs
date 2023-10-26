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
    /// AlipayOpenPublicQrcodeCreateResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenPublicQrcodeCreateResponseModel")]
    public partial class AlipayOpenPublicQrcodeCreateResponseModel : IEquatable<AlipayOpenPublicQrcodeCreateResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicQrcodeCreateResponseModel" /> class.
        /// </summary>
        /// <param name="codeImg">二维码图片地址，可跳转到实际图片.</param>
        /// <param name="expireSecond">二维码有效时间，单位（秒）。永久码暂时忽略该信息.</param>
        public AlipayOpenPublicQrcodeCreateResponseModel(string codeImg = default(string), string expireSecond = default(string))
        {
            this.CodeImg = codeImg;
            this.ExpireSecond = expireSecond;
        }

        /// <summary>
        /// 二维码图片地址，可跳转到实际图片
        /// </summary>
        /// <value>二维码图片地址，可跳转到实际图片</value>
        [DataMember(Name = "code_img", EmitDefaultValue = false)]
        public string CodeImg { get; set; }

        /// <summary>
        /// 二维码有效时间，单位（秒）。永久码暂时忽略该信息
        /// </summary>
        /// <value>二维码有效时间，单位（秒）。永久码暂时忽略该信息</value>
        [DataMember(Name = "expire_second", EmitDefaultValue = false)]
        public string ExpireSecond { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenPublicQrcodeCreateResponseModel {\n");
            sb.Append("  CodeImg: ").Append(CodeImg).Append("\n");
            sb.Append("  ExpireSecond: ").Append(ExpireSecond).Append("\n");
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
            return this.Equals(input as AlipayOpenPublicQrcodeCreateResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenPublicQrcodeCreateResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenPublicQrcodeCreateResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenPublicQrcodeCreateResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CodeImg == input.CodeImg ||
                    (this.CodeImg != null &&
                    this.CodeImg.Equals(input.CodeImg))
                ) && 
                (
                    this.ExpireSecond == input.ExpireSecond ||
                    (this.ExpireSecond != null &&
                    this.ExpireSecond.Equals(input.ExpireSecond))
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
                if (this.CodeImg != null)
                {
                    hashCode = (hashCode * 59) + this.CodeImg.GetHashCode();
                }
                if (this.ExpireSecond != null)
                {
                    hashCode = (hashCode * 59) + this.ExpireSecond.GetHashCode();
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
