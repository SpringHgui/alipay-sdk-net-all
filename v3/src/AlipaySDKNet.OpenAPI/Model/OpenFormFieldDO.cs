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
    /// OpenFormFieldDO
    /// </summary>
    [DataContract(Name = "OpenFormFieldDO")]
    public partial class OpenFormFieldDO : IEquatable<OpenFormFieldDO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenFormFieldDO" /> class.
        /// </summary>
        /// <param name="optional">表单可选字段配置，common_fields属性定义一个表单字段数组，表单字段有效值列表与required字段有效值列表相同。  可选字段配置中不能含有必须字段配置的有效值。.</param>
        /// <param name="required">表单必填字段配置，common_fields属性定义一个表单字段数组，字段有效值如下列表所示：  OPEN_FORM_FIELD_MOBILE - - 手机号  OPEN_FORM_FIELD_GENDER - - 性别  OPEN_FORM_FIELD_NAME - - 姓名  OPEN_FORM_FIELD_BIRTHDAY - - 生日  OPEN_FORM_FIELD_IDCARD - - 身份证  OPEN_FORM_FIELD_EMAIL - - 邮箱  OPEN_FORM_FIELD_ADDRESS - - 地址  OPEN_FORM_FIELD_CITY - - 城市  OPEN_FORM_FIELD_IS_STUDENT - - 是否学生认证  OPEN_FORM_FIELD_MEMBER_GRADE - - 会员等级.</param>
        public OpenFormFieldDO(string optional = default(string), string required = default(string))
        {
            this.Optional = optional;
            this.Required = required;
        }

        /// <summary>
        /// 表单可选字段配置，common_fields属性定义一个表单字段数组，表单字段有效值列表与required字段有效值列表相同。  可选字段配置中不能含有必须字段配置的有效值。
        /// </summary>
        /// <value>表单可选字段配置，common_fields属性定义一个表单字段数组，表单字段有效值列表与required字段有效值列表相同。  可选字段配置中不能含有必须字段配置的有效值。</value>
        [DataMember(Name = "optional", EmitDefaultValue = false)]
        public string Optional { get; set; }

        /// <summary>
        /// 表单必填字段配置，common_fields属性定义一个表单字段数组，字段有效值如下列表所示：  OPEN_FORM_FIELD_MOBILE - - 手机号  OPEN_FORM_FIELD_GENDER - - 性别  OPEN_FORM_FIELD_NAME - - 姓名  OPEN_FORM_FIELD_BIRTHDAY - - 生日  OPEN_FORM_FIELD_IDCARD - - 身份证  OPEN_FORM_FIELD_EMAIL - - 邮箱  OPEN_FORM_FIELD_ADDRESS - - 地址  OPEN_FORM_FIELD_CITY - - 城市  OPEN_FORM_FIELD_IS_STUDENT - - 是否学生认证  OPEN_FORM_FIELD_MEMBER_GRADE - - 会员等级
        /// </summary>
        /// <value>表单必填字段配置，common_fields属性定义一个表单字段数组，字段有效值如下列表所示：  OPEN_FORM_FIELD_MOBILE - - 手机号  OPEN_FORM_FIELD_GENDER - - 性别  OPEN_FORM_FIELD_NAME - - 姓名  OPEN_FORM_FIELD_BIRTHDAY - - 生日  OPEN_FORM_FIELD_IDCARD - - 身份证  OPEN_FORM_FIELD_EMAIL - - 邮箱  OPEN_FORM_FIELD_ADDRESS - - 地址  OPEN_FORM_FIELD_CITY - - 城市  OPEN_FORM_FIELD_IS_STUDENT - - 是否学生认证  OPEN_FORM_FIELD_MEMBER_GRADE - - 会员等级</value>
        [DataMember(Name = "required", EmitDefaultValue = false)]
        public string Required { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OpenFormFieldDO {\n");
            sb.Append("  Optional: ").Append(Optional).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
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
            return this.Equals(input as OpenFormFieldDO);
        }

        /// <summary>
        /// Returns true if OpenFormFieldDO instances are equal
        /// </summary>
        /// <param name="input">Instance of OpenFormFieldDO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpenFormFieldDO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Optional == input.Optional ||
                    (this.Optional != null &&
                    this.Optional.Equals(input.Optional))
                ) && 
                (
                    this.Required == input.Required ||
                    (this.Required != null &&
                    this.Required.Equals(input.Required))
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
                if (this.Optional != null)
                {
                    hashCode = (hashCode * 59) + this.Optional.GetHashCode();
                }
                if (this.Required != null)
                {
                    hashCode = (hashCode * 59) + this.Required.GetHashCode();
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
