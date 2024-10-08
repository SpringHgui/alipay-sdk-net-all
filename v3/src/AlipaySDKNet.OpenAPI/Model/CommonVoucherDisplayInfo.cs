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
    /// CommonVoucherDisplayInfo
    /// </summary>
    [DataContract(Name = "CommonVoucherDisplayInfo")]
    public partial class CommonVoucherDisplayInfo : IEquatable<CommonVoucherDisplayInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonVoucherDisplayInfo" /> class.
        /// </summary>
        /// <param name="brandLogo">商家品牌 logo 链接.</param>
        /// <param name="brandName">商户品牌名称。.</param>
        /// <param name="voucherDescription">用于说明详细的活动规则，会展示在支付宝卡包券详情页。.</param>
        /// <param name="voucherDetailImages">券详情图片链接。.</param>
        /// <param name="voucherImage">券封面图链接。.</param>
        public CommonVoucherDisplayInfo(string brandLogo = default(string), string brandName = default(string), string voucherDescription = default(string), List<string> voucherDetailImages = default(List<string>), string voucherImage = default(string))
        {
            this.BrandLogo = brandLogo;
            this.BrandName = brandName;
            this.VoucherDescription = voucherDescription;
            this.VoucherDetailImages = voucherDetailImages;
            this.VoucherImage = voucherImage;
        }

        /// <summary>
        /// 商家品牌 logo 链接
        /// </summary>
        /// <value>商家品牌 logo 链接</value>
        [DataMember(Name = "brand_logo", EmitDefaultValue = false)]
        public string BrandLogo { get; set; }

        /// <summary>
        /// 商户品牌名称。
        /// </summary>
        /// <value>商户品牌名称。</value>
        [DataMember(Name = "brand_name", EmitDefaultValue = false)]
        public string BrandName { get; set; }

        /// <summary>
        /// 用于说明详细的活动规则，会展示在支付宝卡包券详情页。
        /// </summary>
        /// <value>用于说明详细的活动规则，会展示在支付宝卡包券详情页。</value>
        [DataMember(Name = "voucher_description", EmitDefaultValue = false)]
        public string VoucherDescription { get; set; }

        /// <summary>
        /// 券详情图片链接。
        /// </summary>
        /// <value>券详情图片链接。</value>
        [DataMember(Name = "voucher_detail_images", EmitDefaultValue = false)]
        public List<string> VoucherDetailImages { get; set; }

        /// <summary>
        /// 券封面图链接。
        /// </summary>
        /// <value>券封面图链接。</value>
        [DataMember(Name = "voucher_image", EmitDefaultValue = false)]
        public string VoucherImage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CommonVoucherDisplayInfo {\n");
            sb.Append("  BrandLogo: ").Append(BrandLogo).Append("\n");
            sb.Append("  BrandName: ").Append(BrandName).Append("\n");
            sb.Append("  VoucherDescription: ").Append(VoucherDescription).Append("\n");
            sb.Append("  VoucherDetailImages: ").Append(VoucherDetailImages).Append("\n");
            sb.Append("  VoucherImage: ").Append(VoucherImage).Append("\n");
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
            return this.Equals(input as CommonVoucherDisplayInfo);
        }

        /// <summary>
        /// Returns true if CommonVoucherDisplayInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of CommonVoucherDisplayInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonVoucherDisplayInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BrandLogo == input.BrandLogo ||
                    (this.BrandLogo != null &&
                    this.BrandLogo.Equals(input.BrandLogo))
                ) && 
                (
                    this.BrandName == input.BrandName ||
                    (this.BrandName != null &&
                    this.BrandName.Equals(input.BrandName))
                ) && 
                (
                    this.VoucherDescription == input.VoucherDescription ||
                    (this.VoucherDescription != null &&
                    this.VoucherDescription.Equals(input.VoucherDescription))
                ) && 
                (
                    this.VoucherDetailImages == input.VoucherDetailImages ||
                    this.VoucherDetailImages != null &&
                    input.VoucherDetailImages != null &&
                    this.VoucherDetailImages.SequenceEqual(input.VoucherDetailImages)
                ) && 
                (
                    this.VoucherImage == input.VoucherImage ||
                    (this.VoucherImage != null &&
                    this.VoucherImage.Equals(input.VoucherImage))
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
                if (this.BrandLogo != null)
                {
                    hashCode = (hashCode * 59) + this.BrandLogo.GetHashCode();
                }
                if (this.BrandName != null)
                {
                    hashCode = (hashCode * 59) + this.BrandName.GetHashCode();
                }
                if (this.VoucherDescription != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherDescription.GetHashCode();
                }
                if (this.VoucherDetailImages != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherDetailImages.GetHashCode();
                }
                if (this.VoucherImage != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherImage.GetHashCode();
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
