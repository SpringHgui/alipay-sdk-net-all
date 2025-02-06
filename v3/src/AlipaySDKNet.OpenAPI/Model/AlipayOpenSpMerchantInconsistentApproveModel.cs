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
    /// AlipayOpenSpMerchantInconsistentApproveModel
    /// </summary>
    [DataContract(Name = "AlipayOpenSpMerchantInconsistentApproveModel")]
    public partial class AlipayOpenSpMerchantInconsistentApproveModel : IEquatable<AlipayOpenSpMerchantInconsistentApproveModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenSpMerchantInconsistentApproveModel" /> class.
        /// </summary>
        /// <param name="backCard">身份证背面照，图片文件大小在 50K-5M 之间，不限制长宽，支持 png、bmp、gif、jpg、jpeg 格式。 请传入&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/01ea4t\&quot;&gt;alipay.open.sp.image.upload&lt;/a&gt;(图片上传接口) 返回的 image_id。.</param>
        /// <param name="commitmentLetter">实际经营人承诺函照片，要求证件文本信息清晰可见，图片文件大小在 50K-5M 之间，不限制长宽，支持 png、bmp、gif、jpg、jpeg 格式。 请传入&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/01ea4t\&quot;&gt;alipay.open.sp.image.upload&lt;/a&gt;(图片上传接口) 返回的 image_id。 该资质是否必传请参见报名资质要求。.</param>
        /// <param name="frontCard">身份证正面照，要求证件文本信息清晰可见，图片文件大小在 50K-5M 之间，不限制长宽，支持 png、bmp、gif、jpg、jpeg 格式. 请传&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/01ea4t\&quot;&gt;alipay.open.sp.image.upload&lt;/a&gt;(图片上传接口) 返回的 image_id。.</param>
        /// <param name="handheldBusinessLicense">手持营业执照合照，要求证件文本信息清晰可见，图片文件大小在 50K-5M 之间，不限制长宽，支持 png、bmp、gif、jpg、jpeg 格式。 请传入&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/01ea4t\&quot;&gt;alipay.open.sp.image.upload&lt;/a&gt;(图片上传接口) 返回的 image_id。 该资质是否必传请参见报名资质要求。.</param>
        /// <param name="handheldCard">手持身份证合照，要求证件文本信息清晰可见，图片文件大小在 50K-5M 之间，不限制长宽，支持 png、bmp、gif、jpg、jpeg 格式。 请传入&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/01ea4t\&quot;&gt;alipay.open.sp.image.upload&lt;/a&gt;(图片上传接口) 返回的 image_id。 该资质是否必传请参见报名资质要求。.</param>
        /// <param name="itemCode">服务优选商品编码.</param>
        /// <param name="merchantPid">商家pid.</param>
        /// <param name="miniAppid">商家小程序appId.</param>
        /// <param name="outBizNo">外部业务号，需不重复.</param>
        /// <param name="promotorPid">推广服务商(S2)pid.</param>
        public AlipayOpenSpMerchantInconsistentApproveModel(string backCard = default(string), string commitmentLetter = default(string), string frontCard = default(string), string handheldBusinessLicense = default(string), string handheldCard = default(string), string itemCode = default(string), string merchantPid = default(string), string miniAppid = default(string), string outBizNo = default(string), string promotorPid = default(string))
        {
            this.BackCard = backCard;
            this.CommitmentLetter = commitmentLetter;
            this.FrontCard = frontCard;
            this.HandheldBusinessLicense = handheldBusinessLicense;
            this.HandheldCard = handheldCard;
            this.ItemCode = itemCode;
            this.MerchantPid = merchantPid;
            this.MiniAppid = miniAppid;
            this.OutBizNo = outBizNo;
            this.PromotorPid = promotorPid;
        }

        /// <summary>
        /// 身份证背面照，图片文件大小在 50K-5M 之间，不限制长宽，支持 png、bmp、gif、jpg、jpeg 格式。 请传入&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/01ea4t\&quot;&gt;alipay.open.sp.image.upload&lt;/a&gt;(图片上传接口) 返回的 image_id。
        /// </summary>
        /// <value>身份证背面照，图片文件大小在 50K-5M 之间，不限制长宽，支持 png、bmp、gif、jpg、jpeg 格式。 请传入&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/01ea4t\&quot;&gt;alipay.open.sp.image.upload&lt;/a&gt;(图片上传接口) 返回的 image_id。</value>
        [DataMember(Name = "back_card", EmitDefaultValue = false)]
        public string BackCard { get; set; }

        /// <summary>
        /// 实际经营人承诺函照片，要求证件文本信息清晰可见，图片文件大小在 50K-5M 之间，不限制长宽，支持 png、bmp、gif、jpg、jpeg 格式。 请传入&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/01ea4t\&quot;&gt;alipay.open.sp.image.upload&lt;/a&gt;(图片上传接口) 返回的 image_id。 该资质是否必传请参见报名资质要求。
        /// </summary>
        /// <value>实际经营人承诺函照片，要求证件文本信息清晰可见，图片文件大小在 50K-5M 之间，不限制长宽，支持 png、bmp、gif、jpg、jpeg 格式。 请传入&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/01ea4t\&quot;&gt;alipay.open.sp.image.upload&lt;/a&gt;(图片上传接口) 返回的 image_id。 该资质是否必传请参见报名资质要求。</value>
        [DataMember(Name = "commitment_letter", EmitDefaultValue = false)]
        public string CommitmentLetter { get; set; }

        /// <summary>
        /// 身份证正面照，要求证件文本信息清晰可见，图片文件大小在 50K-5M 之间，不限制长宽，支持 png、bmp、gif、jpg、jpeg 格式. 请传&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/01ea4t\&quot;&gt;alipay.open.sp.image.upload&lt;/a&gt;(图片上传接口) 返回的 image_id。
        /// </summary>
        /// <value>身份证正面照，要求证件文本信息清晰可见，图片文件大小在 50K-5M 之间，不限制长宽，支持 png、bmp、gif、jpg、jpeg 格式. 请传&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/01ea4t\&quot;&gt;alipay.open.sp.image.upload&lt;/a&gt;(图片上传接口) 返回的 image_id。</value>
        [DataMember(Name = "front_card", EmitDefaultValue = false)]
        public string FrontCard { get; set; }

        /// <summary>
        /// 手持营业执照合照，要求证件文本信息清晰可见，图片文件大小在 50K-5M 之间，不限制长宽，支持 png、bmp、gif、jpg、jpeg 格式。 请传入&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/01ea4t\&quot;&gt;alipay.open.sp.image.upload&lt;/a&gt;(图片上传接口) 返回的 image_id。 该资质是否必传请参见报名资质要求。
        /// </summary>
        /// <value>手持营业执照合照，要求证件文本信息清晰可见，图片文件大小在 50K-5M 之间，不限制长宽，支持 png、bmp、gif、jpg、jpeg 格式。 请传入&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/01ea4t\&quot;&gt;alipay.open.sp.image.upload&lt;/a&gt;(图片上传接口) 返回的 image_id。 该资质是否必传请参见报名资质要求。</value>
        [DataMember(Name = "handheld_business_license", EmitDefaultValue = false)]
        public string HandheldBusinessLicense { get; set; }

        /// <summary>
        /// 手持身份证合照，要求证件文本信息清晰可见，图片文件大小在 50K-5M 之间，不限制长宽，支持 png、bmp、gif、jpg、jpeg 格式。 请传入&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/01ea4t\&quot;&gt;alipay.open.sp.image.upload&lt;/a&gt;(图片上传接口) 返回的 image_id。 该资质是否必传请参见报名资质要求。
        /// </summary>
        /// <value>手持身份证合照，要求证件文本信息清晰可见，图片文件大小在 50K-5M 之间，不限制长宽，支持 png、bmp、gif、jpg、jpeg 格式。 请传入&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/01ea4t\&quot;&gt;alipay.open.sp.image.upload&lt;/a&gt;(图片上传接口) 返回的 image_id。 该资质是否必传请参见报名资质要求。</value>
        [DataMember(Name = "handheld_card", EmitDefaultValue = false)]
        public string HandheldCard { get; set; }

        /// <summary>
        /// 服务优选商品编码
        /// </summary>
        /// <value>服务优选商品编码</value>
        [DataMember(Name = "item_code", EmitDefaultValue = false)]
        public string ItemCode { get; set; }

        /// <summary>
        /// 商家pid
        /// </summary>
        /// <value>商家pid</value>
        [DataMember(Name = "merchant_pid", EmitDefaultValue = false)]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 商家小程序appId
        /// </summary>
        /// <value>商家小程序appId</value>
        [DataMember(Name = "mini_appid", EmitDefaultValue = false)]
        public string MiniAppid { get; set; }

        /// <summary>
        /// 外部业务号，需不重复
        /// </summary>
        /// <value>外部业务号，需不重复</value>
        [DataMember(Name = "out_biz_no", EmitDefaultValue = false)]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 推广服务商(S2)pid
        /// </summary>
        /// <value>推广服务商(S2)pid</value>
        [DataMember(Name = "promotor_pid", EmitDefaultValue = false)]
        public string PromotorPid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenSpMerchantInconsistentApproveModel {\n");
            sb.Append("  BackCard: ").Append(BackCard).Append("\n");
            sb.Append("  CommitmentLetter: ").Append(CommitmentLetter).Append("\n");
            sb.Append("  FrontCard: ").Append(FrontCard).Append("\n");
            sb.Append("  HandheldBusinessLicense: ").Append(HandheldBusinessLicense).Append("\n");
            sb.Append("  HandheldCard: ").Append(HandheldCard).Append("\n");
            sb.Append("  ItemCode: ").Append(ItemCode).Append("\n");
            sb.Append("  MerchantPid: ").Append(MerchantPid).Append("\n");
            sb.Append("  MiniAppid: ").Append(MiniAppid).Append("\n");
            sb.Append("  OutBizNo: ").Append(OutBizNo).Append("\n");
            sb.Append("  PromotorPid: ").Append(PromotorPid).Append("\n");
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
            return this.Equals(input as AlipayOpenSpMerchantInconsistentApproveModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenSpMerchantInconsistentApproveModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenSpMerchantInconsistentApproveModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenSpMerchantInconsistentApproveModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BackCard == input.BackCard ||
                    (this.BackCard != null &&
                    this.BackCard.Equals(input.BackCard))
                ) && 
                (
                    this.CommitmentLetter == input.CommitmentLetter ||
                    (this.CommitmentLetter != null &&
                    this.CommitmentLetter.Equals(input.CommitmentLetter))
                ) && 
                (
                    this.FrontCard == input.FrontCard ||
                    (this.FrontCard != null &&
                    this.FrontCard.Equals(input.FrontCard))
                ) && 
                (
                    this.HandheldBusinessLicense == input.HandheldBusinessLicense ||
                    (this.HandheldBusinessLicense != null &&
                    this.HandheldBusinessLicense.Equals(input.HandheldBusinessLicense))
                ) && 
                (
                    this.HandheldCard == input.HandheldCard ||
                    (this.HandheldCard != null &&
                    this.HandheldCard.Equals(input.HandheldCard))
                ) && 
                (
                    this.ItemCode == input.ItemCode ||
                    (this.ItemCode != null &&
                    this.ItemCode.Equals(input.ItemCode))
                ) && 
                (
                    this.MerchantPid == input.MerchantPid ||
                    (this.MerchantPid != null &&
                    this.MerchantPid.Equals(input.MerchantPid))
                ) && 
                (
                    this.MiniAppid == input.MiniAppid ||
                    (this.MiniAppid != null &&
                    this.MiniAppid.Equals(input.MiniAppid))
                ) && 
                (
                    this.OutBizNo == input.OutBizNo ||
                    (this.OutBizNo != null &&
                    this.OutBizNo.Equals(input.OutBizNo))
                ) && 
                (
                    this.PromotorPid == input.PromotorPid ||
                    (this.PromotorPid != null &&
                    this.PromotorPid.Equals(input.PromotorPid))
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
                if (this.BackCard != null)
                {
                    hashCode = (hashCode * 59) + this.BackCard.GetHashCode();
                }
                if (this.CommitmentLetter != null)
                {
                    hashCode = (hashCode * 59) + this.CommitmentLetter.GetHashCode();
                }
                if (this.FrontCard != null)
                {
                    hashCode = (hashCode * 59) + this.FrontCard.GetHashCode();
                }
                if (this.HandheldBusinessLicense != null)
                {
                    hashCode = (hashCode * 59) + this.HandheldBusinessLicense.GetHashCode();
                }
                if (this.HandheldCard != null)
                {
                    hashCode = (hashCode * 59) + this.HandheldCard.GetHashCode();
                }
                if (this.ItemCode != null)
                {
                    hashCode = (hashCode * 59) + this.ItemCode.GetHashCode();
                }
                if (this.MerchantPid != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantPid.GetHashCode();
                }
                if (this.MiniAppid != null)
                {
                    hashCode = (hashCode * 59) + this.MiniAppid.GetHashCode();
                }
                if (this.OutBizNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutBizNo.GetHashCode();
                }
                if (this.PromotorPid != null)
                {
                    hashCode = (hashCode * 59) + this.PromotorPid.GetHashCode();
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
