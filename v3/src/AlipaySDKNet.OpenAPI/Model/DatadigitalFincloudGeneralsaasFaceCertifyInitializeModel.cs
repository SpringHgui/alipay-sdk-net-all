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
    /// DatadigitalFincloudGeneralsaasFaceCertifyInitializeModel
    /// </summary>
    [DataContract(Name = "DatadigitalFincloudGeneralsaasFaceCertifyInitializeModel")]
    public partial class DatadigitalFincloudGeneralsaasFaceCertifyInitializeModel : IEquatable<DatadigitalFincloudGeneralsaasFaceCertifyInitializeModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatadigitalFincloudGeneralsaasFaceCertifyInitializeModel" /> class.
        /// </summary>
        /// <param name="bizCode">H5人脸核身场景码。入参支持的场景码。.</param>
        /// <param name="faceContrastPicture">自定义人脸比对图片的base64编码格式的string字符串.</param>
        /// <param name="identityParam">identityParam.</param>
        /// <param name="merchantConfig">merchantConfig.</param>
        /// <param name="outerOrderNo">商户请求的唯一标识，商户要保证其唯一性，值为32位长度的字母数字组合。建议：前面几位字符是商户自定义的简称，中间可以使用一段时间，后段可以使用一个随机或递增序列.</param>
        public DatadigitalFincloudGeneralsaasFaceCertifyInitializeModel(string bizCode = default(string), string faceContrastPicture = default(string), OpenCertifyIdentifyInfo identityParam = default(OpenCertifyIdentifyInfo), OpenCertifyMerchantConfigs merchantConfig = default(OpenCertifyMerchantConfigs), string outerOrderNo = default(string))
        {
            this.BizCode = bizCode;
            this.FaceContrastPicture = faceContrastPicture;
            this.IdentityParam = identityParam;
            this.MerchantConfig = merchantConfig;
            this.OuterOrderNo = outerOrderNo;
        }

        /// <summary>
        /// H5人脸核身场景码。入参支持的场景码。
        /// </summary>
        /// <value>H5人脸核身场景码。入参支持的场景码。</value>
        [DataMember(Name = "biz_code", EmitDefaultValue = false)]
        public string BizCode { get; set; }

        /// <summary>
        /// 自定义人脸比对图片的base64编码格式的string字符串
        /// </summary>
        /// <value>自定义人脸比对图片的base64编码格式的string字符串</value>
        [DataMember(Name = "face_contrast_picture", EmitDefaultValue = false)]
        public string FaceContrastPicture { get; set; }

        /// <summary>
        /// Gets or Sets IdentityParam
        /// </summary>
        [DataMember(Name = "identity_param", EmitDefaultValue = false)]
        public OpenCertifyIdentifyInfo IdentityParam { get; set; }

        /// <summary>
        /// Gets or Sets MerchantConfig
        /// </summary>
        [DataMember(Name = "merchant_config", EmitDefaultValue = false)]
        public OpenCertifyMerchantConfigs MerchantConfig { get; set; }

        /// <summary>
        /// 商户请求的唯一标识，商户要保证其唯一性，值为32位长度的字母数字组合。建议：前面几位字符是商户自定义的简称，中间可以使用一段时间，后段可以使用一个随机或递增序列
        /// </summary>
        /// <value>商户请求的唯一标识，商户要保证其唯一性，值为32位长度的字母数字组合。建议：前面几位字符是商户自定义的简称，中间可以使用一段时间，后段可以使用一个随机或递增序列</value>
        [DataMember(Name = "outer_order_no", EmitDefaultValue = false)]
        public string OuterOrderNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DatadigitalFincloudGeneralsaasFaceCertifyInitializeModel {\n");
            sb.Append("  BizCode: ").Append(BizCode).Append("\n");
            sb.Append("  FaceContrastPicture: ").Append(FaceContrastPicture).Append("\n");
            sb.Append("  IdentityParam: ").Append(IdentityParam).Append("\n");
            sb.Append("  MerchantConfig: ").Append(MerchantConfig).Append("\n");
            sb.Append("  OuterOrderNo: ").Append(OuterOrderNo).Append("\n");
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
            return this.Equals(input as DatadigitalFincloudGeneralsaasFaceCertifyInitializeModel);
        }

        /// <summary>
        /// Returns true if DatadigitalFincloudGeneralsaasFaceCertifyInitializeModel instances are equal
        /// </summary>
        /// <param name="input">Instance of DatadigitalFincloudGeneralsaasFaceCertifyInitializeModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DatadigitalFincloudGeneralsaasFaceCertifyInitializeModel input)
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
                    this.FaceContrastPicture == input.FaceContrastPicture ||
                    (this.FaceContrastPicture != null &&
                    this.FaceContrastPicture.Equals(input.FaceContrastPicture))
                ) && 
                (
                    this.IdentityParam == input.IdentityParam ||
                    (this.IdentityParam != null &&
                    this.IdentityParam.Equals(input.IdentityParam))
                ) && 
                (
                    this.MerchantConfig == input.MerchantConfig ||
                    (this.MerchantConfig != null &&
                    this.MerchantConfig.Equals(input.MerchantConfig))
                ) && 
                (
                    this.OuterOrderNo == input.OuterOrderNo ||
                    (this.OuterOrderNo != null &&
                    this.OuterOrderNo.Equals(input.OuterOrderNo))
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
                if (this.FaceContrastPicture != null)
                {
                    hashCode = (hashCode * 59) + this.FaceContrastPicture.GetHashCode();
                }
                if (this.IdentityParam != null)
                {
                    hashCode = (hashCode * 59) + this.IdentityParam.GetHashCode();
                }
                if (this.MerchantConfig != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantConfig.GetHashCode();
                }
                if (this.OuterOrderNo != null)
                {
                    hashCode = (hashCode * 59) + this.OuterOrderNo.GetHashCode();
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
