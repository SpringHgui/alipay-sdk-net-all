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
    /// AlipayFundAccountbookCreateModel
    /// </summary>
    [DataContract(Name = "AlipayFundAccountbookCreateModel")]
    public partial class AlipayFundAccountbookCreateModel : IEquatable<AlipayFundAccountbookCreateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundAccountbookCreateModel" /> class.
        /// </summary>
        /// <param name="extInfo">JSON格式，传递业务扩展参数.</param>
        /// <param name="merchantUserId">外部商户系统会员的唯一标识，自定义传入.</param>
        /// <param name="merchantUserType">外部商户用户类型:BUSINESS_EMPLOYEE.</param>
        /// <param name="sceneCode">资金记账本的业务场景.</param>
        public AlipayFundAccountbookCreateModel(string extInfo = default(string), string merchantUserId = default(string), string merchantUserType = default(string), string sceneCode = default(string))
        {
            this.ExtInfo = extInfo;
            this.MerchantUserId = merchantUserId;
            this.MerchantUserType = merchantUserType;
            this.SceneCode = sceneCode;
        }

        /// <summary>
        /// JSON格式，传递业务扩展参数
        /// </summary>
        /// <value>JSON格式，传递业务扩展参数</value>
        [DataMember(Name = "ext_info", EmitDefaultValue = false)]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 外部商户系统会员的唯一标识，自定义传入
        /// </summary>
        /// <value>外部商户系统会员的唯一标识，自定义传入</value>
        [DataMember(Name = "merchant_user_id", EmitDefaultValue = false)]
        public string MerchantUserId { get; set; }

        /// <summary>
        /// 外部商户用户类型:BUSINESS_EMPLOYEE
        /// </summary>
        /// <value>外部商户用户类型:BUSINESS_EMPLOYEE</value>
        [DataMember(Name = "merchant_user_type", EmitDefaultValue = false)]
        public string MerchantUserType { get; set; }

        /// <summary>
        /// 资金记账本的业务场景
        /// </summary>
        /// <value>资金记账本的业务场景</value>
        [DataMember(Name = "scene_code", EmitDefaultValue = false)]
        public string SceneCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayFundAccountbookCreateModel {\n");
            sb.Append("  ExtInfo: ").Append(ExtInfo).Append("\n");
            sb.Append("  MerchantUserId: ").Append(MerchantUserId).Append("\n");
            sb.Append("  MerchantUserType: ").Append(MerchantUserType).Append("\n");
            sb.Append("  SceneCode: ").Append(SceneCode).Append("\n");
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
            return this.Equals(input as AlipayFundAccountbookCreateModel);
        }

        /// <summary>
        /// Returns true if AlipayFundAccountbookCreateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayFundAccountbookCreateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayFundAccountbookCreateModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ExtInfo == input.ExtInfo ||
                    (this.ExtInfo != null &&
                    this.ExtInfo.Equals(input.ExtInfo))
                ) && 
                (
                    this.MerchantUserId == input.MerchantUserId ||
                    (this.MerchantUserId != null &&
                    this.MerchantUserId.Equals(input.MerchantUserId))
                ) && 
                (
                    this.MerchantUserType == input.MerchantUserType ||
                    (this.MerchantUserType != null &&
                    this.MerchantUserType.Equals(input.MerchantUserType))
                ) && 
                (
                    this.SceneCode == input.SceneCode ||
                    (this.SceneCode != null &&
                    this.SceneCode.Equals(input.SceneCode))
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
                if (this.ExtInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ExtInfo.GetHashCode();
                }
                if (this.MerchantUserId != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantUserId.GetHashCode();
                }
                if (this.MerchantUserType != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantUserType.GetHashCode();
                }
                if (this.SceneCode != null)
                {
                    hashCode = (hashCode * 59) + this.SceneCode.GetHashCode();
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
