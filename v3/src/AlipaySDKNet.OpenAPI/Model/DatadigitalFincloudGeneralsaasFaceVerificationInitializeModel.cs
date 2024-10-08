/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2024-10-08
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
    /// DatadigitalFincloudGeneralsaasFaceVerificationInitializeModel
    /// </summary>
    [DataContract(Name = "DatadigitalFincloudGeneralsaasFaceVerificationInitializeModel")]
    public partial class DatadigitalFincloudGeneralsaasFaceVerificationInitializeModel : IEquatable<DatadigitalFincloudGeneralsaasFaceVerificationInitializeModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatadigitalFincloudGeneralsaasFaceVerificationInitializeModel" /> class.
        /// </summary>
        /// <param name="bizCode">人脸核身具体类型目前仅支持：DATA_DIGITAL_BIZ_CODE_FACE_VERIFICATION.</param>
        /// <param name="certName">真实姓名.</param>
        /// <param name="certNo">证件号.</param>
        /// <param name="certType">证件类型，当前枚举支持： IDENTITY_CARD：身份证 RESIDENCE_HK_MC：港澳居民居住证 RESIDENCE_TAIWAN：台湾居民居住证.</param>
        /// <param name="faceReserveStrategy">人脸保存策略，非必填。具体取值为：reserve(保存活体人脸)/never(不保存活体人脸)，不传默认为reserve.</param>
        /// <param name="identityType">认证类型，固定值为：CERT_INFO.</param>
        /// <param name="nation">国家地区代码，当证件类型为外国人永久居留证时必填。.</param>
        /// <param name="outerOrderNo">商户请求的唯一标识，商户要保证其唯一性，值为64位长度的字母数字组合。建议：前面几位字符是商户自定义的简称，中间可以使用一段时间，后段可以使用一个随机或递增序列.</param>
        /// <param name="phoneNo">手机号码.</param>
        public DatadigitalFincloudGeneralsaasFaceVerificationInitializeModel(string bizCode = default(string), string certName = default(string), string certNo = default(string), string certType = default(string), string faceReserveStrategy = default(string), string identityType = default(string), string nation = default(string), string outerOrderNo = default(string), string phoneNo = default(string))
        {
            this.BizCode = bizCode;
            this.CertName = certName;
            this.CertNo = certNo;
            this.CertType = certType;
            this.FaceReserveStrategy = faceReserveStrategy;
            this.IdentityType = identityType;
            this.Nation = nation;
            this.OuterOrderNo = outerOrderNo;
            this.PhoneNo = phoneNo;
        }

        /// <summary>
        /// 人脸核身具体类型目前仅支持：DATA_DIGITAL_BIZ_CODE_FACE_VERIFICATION
        /// </summary>
        /// <value>人脸核身具体类型目前仅支持：DATA_DIGITAL_BIZ_CODE_FACE_VERIFICATION</value>
        [DataMember(Name = "biz_code", EmitDefaultValue = false)]
        public string BizCode { get; set; }

        /// <summary>
        /// 真实姓名
        /// </summary>
        /// <value>真实姓名</value>
        [DataMember(Name = "cert_name", EmitDefaultValue = false)]
        public string CertName { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        /// <value>证件号</value>
        [DataMember(Name = "cert_no", EmitDefaultValue = false)]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型，当前枚举支持： IDENTITY_CARD：身份证 RESIDENCE_HK_MC：港澳居民居住证 RESIDENCE_TAIWAN：台湾居民居住证
        /// </summary>
        /// <value>证件类型，当前枚举支持： IDENTITY_CARD：身份证 RESIDENCE_HK_MC：港澳居民居住证 RESIDENCE_TAIWAN：台湾居民居住证</value>
        [DataMember(Name = "cert_type", EmitDefaultValue = false)]
        public string CertType { get; set; }

        /// <summary>
        /// 人脸保存策略，非必填。具体取值为：reserve(保存活体人脸)/never(不保存活体人脸)，不传默认为reserve
        /// </summary>
        /// <value>人脸保存策略，非必填。具体取值为：reserve(保存活体人脸)/never(不保存活体人脸)，不传默认为reserve</value>
        [DataMember(Name = "face_reserve_strategy", EmitDefaultValue = false)]
        public string FaceReserveStrategy { get; set; }

        /// <summary>
        /// 认证类型，固定值为：CERT_INFO
        /// </summary>
        /// <value>认证类型，固定值为：CERT_INFO</value>
        [DataMember(Name = "identity_type", EmitDefaultValue = false)]
        public string IdentityType { get; set; }

        /// <summary>
        /// 国家地区代码，当证件类型为外国人永久居留证时必填。
        /// </summary>
        /// <value>国家地区代码，当证件类型为外国人永久居留证时必填。</value>
        [DataMember(Name = "nation", EmitDefaultValue = false)]
        public string Nation { get; set; }

        /// <summary>
        /// 商户请求的唯一标识，商户要保证其唯一性，值为64位长度的字母数字组合。建议：前面几位字符是商户自定义的简称，中间可以使用一段时间，后段可以使用一个随机或递增序列
        /// </summary>
        /// <value>商户请求的唯一标识，商户要保证其唯一性，值为64位长度的字母数字组合。建议：前面几位字符是商户自定义的简称，中间可以使用一段时间，后段可以使用一个随机或递增序列</value>
        [DataMember(Name = "outer_order_no", EmitDefaultValue = false)]
        public string OuterOrderNo { get; set; }

        /// <summary>
        /// 手机号码
        /// </summary>
        /// <value>手机号码</value>
        [DataMember(Name = "phone_no", EmitDefaultValue = false)]
        public string PhoneNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DatadigitalFincloudGeneralsaasFaceVerificationInitializeModel {\n");
            sb.Append("  BizCode: ").Append(BizCode).Append("\n");
            sb.Append("  CertName: ").Append(CertName).Append("\n");
            sb.Append("  CertNo: ").Append(CertNo).Append("\n");
            sb.Append("  CertType: ").Append(CertType).Append("\n");
            sb.Append("  FaceReserveStrategy: ").Append(FaceReserveStrategy).Append("\n");
            sb.Append("  IdentityType: ").Append(IdentityType).Append("\n");
            sb.Append("  Nation: ").Append(Nation).Append("\n");
            sb.Append("  OuterOrderNo: ").Append(OuterOrderNo).Append("\n");
            sb.Append("  PhoneNo: ").Append(PhoneNo).Append("\n");
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
            return this.Equals(input as DatadigitalFincloudGeneralsaasFaceVerificationInitializeModel);
        }

        /// <summary>
        /// Returns true if DatadigitalFincloudGeneralsaasFaceVerificationInitializeModel instances are equal
        /// </summary>
        /// <param name="input">Instance of DatadigitalFincloudGeneralsaasFaceVerificationInitializeModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DatadigitalFincloudGeneralsaasFaceVerificationInitializeModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BizCode == input.BizCode ||
                    (this.BizCode != null &&
                    this.BizCode.Equals(input.BizCode))
                ) && 
                (
                    this.CertName == input.CertName ||
                    (this.CertName != null &&
                    this.CertName.Equals(input.CertName))
                ) && 
                (
                    this.CertNo == input.CertNo ||
                    (this.CertNo != null &&
                    this.CertNo.Equals(input.CertNo))
                ) && 
                (
                    this.CertType == input.CertType ||
                    (this.CertType != null &&
                    this.CertType.Equals(input.CertType))
                ) && 
                (
                    this.FaceReserveStrategy == input.FaceReserveStrategy ||
                    (this.FaceReserveStrategy != null &&
                    this.FaceReserveStrategy.Equals(input.FaceReserveStrategy))
                ) && 
                (
                    this.IdentityType == input.IdentityType ||
                    (this.IdentityType != null &&
                    this.IdentityType.Equals(input.IdentityType))
                ) && 
                (
                    this.Nation == input.Nation ||
                    (this.Nation != null &&
                    this.Nation.Equals(input.Nation))
                ) && 
                (
                    this.OuterOrderNo == input.OuterOrderNo ||
                    (this.OuterOrderNo != null &&
                    this.OuterOrderNo.Equals(input.OuterOrderNo))
                ) && 
                (
                    this.PhoneNo == input.PhoneNo ||
                    (this.PhoneNo != null &&
                    this.PhoneNo.Equals(input.PhoneNo))
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
                if (this.BizCode != null)
                {
                    hashCode = (hashCode * 59) + this.BizCode.GetHashCode();
                }
                if (this.CertName != null)
                {
                    hashCode = (hashCode * 59) + this.CertName.GetHashCode();
                }
                if (this.CertNo != null)
                {
                    hashCode = (hashCode * 59) + this.CertNo.GetHashCode();
                }
                if (this.CertType != null)
                {
                    hashCode = (hashCode * 59) + this.CertType.GetHashCode();
                }
                if (this.FaceReserveStrategy != null)
                {
                    hashCode = (hashCode * 59) + this.FaceReserveStrategy.GetHashCode();
                }
                if (this.IdentityType != null)
                {
                    hashCode = (hashCode * 59) + this.IdentityType.GetHashCode();
                }
                if (this.Nation != null)
                {
                    hashCode = (hashCode * 59) + this.Nation.GetHashCode();
                }
                if (this.OuterOrderNo != null)
                {
                    hashCode = (hashCode * 59) + this.OuterOrderNo.GetHashCode();
                }
                if (this.PhoneNo != null)
                {
                    hashCode = (hashCode * 59) + this.PhoneNo.GetHashCode();
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
