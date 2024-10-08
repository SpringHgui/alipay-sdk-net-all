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
    /// TemplateStyleInfoDTO
    /// </summary>
    [DataContract(Name = "TemplateStyleInfoDTO")]
    public partial class TemplateStyleInfoDTO : IEquatable<TemplateStyleInfoDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateStyleInfoDTO" /> class.
        /// </summary>
        /// <param name="backgroundId">背景图片Id，通过接口（alipay.offline.material.image.upload）上传图片    图片说明：2M以内，格式：bmp、png、jpeg、jpg、gif；  尺寸不小于1020*643px；  图片不得有圆角，不得拉伸变形.</param>
        /// <param name="bannerImgId">banner图片id。 通过接口（alipay.offline.material.image.upload）上传图片。.</param>
        /// <param name="bannerUrl">banner跳转地址。.</param>
        /// <param name="bgColor">字体颜色（非背景色），只影响卡详情中部信息区域字体颜色.</param>
        /// <param name="brandName">品牌商名称.</param>
        /// <param name="cardShowName">钱包端显示名称.</param>
        /// <param name="color">注意：此字段已废弃。.</param>
        /// <param name="columnInfoLayout">如果为空则默认为list。.</param>
        /// <param name="featureDescriptions">特色信息，用于领卡预览.</param>
        /// <param name="frontImageEnable">设置是否在卡面展示（个人头像）图片信息，默认不展示；  当前仅用于身份验证信息类型的个人头像图片；  图片id随创建卡/更新卡时传入；  详见会员卡产品文档。.</param>
        /// <param name="frontTextListEnable">设置是否在卡面展示文案信息，默认不展示；  文案信息分行展示，最多展示4行文案，每行文案分为label和value两部分；  文案实际内容随创建卡/更新卡时传入；  详见会员卡产品说明文档。.</param>
        /// <param name="logoId">logo的图片ID，通过接口（alipay.offline.material.image.upload）上传图片    图片说明：1M以内，格式bmp、png、jpeg、jpg、gif；  尺寸不小于500*500px的正方形；  请优先使用商家LOGO；.</param>
        /// <param name="slogan">标语.</param>
        /// <param name="sloganImgId">标语图片id， 通过接口（alipay.offline.material.image.upload）上传图片.</param>
        public TemplateStyleInfoDTO(string backgroundId = default(string), string bannerImgId = default(string), string bannerUrl = default(string), string bgColor = default(string), string brandName = default(string), string cardShowName = default(string), string color = default(string), string columnInfoLayout = default(string), List<string> featureDescriptions = default(List<string>), bool frontImageEnable = default(bool), bool frontTextListEnable = default(bool), string logoId = default(string), string slogan = default(string), string sloganImgId = default(string))
        {
            this.BackgroundId = backgroundId;
            this.BannerImgId = bannerImgId;
            this.BannerUrl = bannerUrl;
            this.BgColor = bgColor;
            this.BrandName = brandName;
            this.CardShowName = cardShowName;
            this.Color = color;
            this.ColumnInfoLayout = columnInfoLayout;
            this.FeatureDescriptions = featureDescriptions;
            this.FrontImageEnable = frontImageEnable;
            this.FrontTextListEnable = frontTextListEnable;
            this.LogoId = logoId;
            this.Slogan = slogan;
            this.SloganImgId = sloganImgId;
        }

        /// <summary>
        /// 背景图片Id，通过接口（alipay.offline.material.image.upload）上传图片    图片说明：2M以内，格式：bmp、png、jpeg、jpg、gif；  尺寸不小于1020*643px；  图片不得有圆角，不得拉伸变形
        /// </summary>
        /// <value>背景图片Id，通过接口（alipay.offline.material.image.upload）上传图片    图片说明：2M以内，格式：bmp、png、jpeg、jpg、gif；  尺寸不小于1020*643px；  图片不得有圆角，不得拉伸变形</value>
        [DataMember(Name = "background_id", EmitDefaultValue = false)]
        public string BackgroundId { get; set; }

        /// <summary>
        /// banner图片id。 通过接口（alipay.offline.material.image.upload）上传图片。
        /// </summary>
        /// <value>banner图片id。 通过接口（alipay.offline.material.image.upload）上传图片。</value>
        [DataMember(Name = "banner_img_id", EmitDefaultValue = false)]
        public string BannerImgId { get; set; }

        /// <summary>
        /// banner跳转地址。
        /// </summary>
        /// <value>banner跳转地址。</value>
        [DataMember(Name = "banner_url", EmitDefaultValue = false)]
        public string BannerUrl { get; set; }

        /// <summary>
        /// 字体颜色（非背景色），只影响卡详情中部信息区域字体颜色
        /// </summary>
        /// <value>字体颜色（非背景色），只影响卡详情中部信息区域字体颜色</value>
        [DataMember(Name = "bg_color", EmitDefaultValue = false)]
        public string BgColor { get; set; }

        /// <summary>
        /// 品牌商名称
        /// </summary>
        /// <value>品牌商名称</value>
        [DataMember(Name = "brand_name", EmitDefaultValue = false)]
        public string BrandName { get; set; }

        /// <summary>
        /// 钱包端显示名称
        /// </summary>
        /// <value>钱包端显示名称</value>
        [DataMember(Name = "card_show_name", EmitDefaultValue = false)]
        public string CardShowName { get; set; }

        /// <summary>
        /// 注意：此字段已废弃。
        /// </summary>
        /// <value>注意：此字段已废弃。</value>
        [DataMember(Name = "color", EmitDefaultValue = false)]
        public string Color { get; set; }

        /// <summary>
        /// 如果为空则默认为list。
        /// </summary>
        /// <value>如果为空则默认为list。</value>
        [DataMember(Name = "column_info_layout", EmitDefaultValue = false)]
        public string ColumnInfoLayout { get; set; }

        /// <summary>
        /// 特色信息，用于领卡预览
        /// </summary>
        /// <value>特色信息，用于领卡预览</value>
        [DataMember(Name = "feature_descriptions", EmitDefaultValue = false)]
        public List<string> FeatureDescriptions { get; set; }

        /// <summary>
        /// 设置是否在卡面展示（个人头像）图片信息，默认不展示；  当前仅用于身份验证信息类型的个人头像图片；  图片id随创建卡/更新卡时传入；  详见会员卡产品文档。
        /// </summary>
        /// <value>设置是否在卡面展示（个人头像）图片信息，默认不展示；  当前仅用于身份验证信息类型的个人头像图片；  图片id随创建卡/更新卡时传入；  详见会员卡产品文档。</value>
        [DataMember(Name = "front_image_enable", EmitDefaultValue = true)]
        public bool FrontImageEnable { get; set; }

        /// <summary>
        /// 设置是否在卡面展示文案信息，默认不展示；  文案信息分行展示，最多展示4行文案，每行文案分为label和value两部分；  文案实际内容随创建卡/更新卡时传入；  详见会员卡产品说明文档。
        /// </summary>
        /// <value>设置是否在卡面展示文案信息，默认不展示；  文案信息分行展示，最多展示4行文案，每行文案分为label和value两部分；  文案实际内容随创建卡/更新卡时传入；  详见会员卡产品说明文档。</value>
        [DataMember(Name = "front_text_list_enable", EmitDefaultValue = true)]
        public bool FrontTextListEnable { get; set; }

        /// <summary>
        /// logo的图片ID，通过接口（alipay.offline.material.image.upload）上传图片    图片说明：1M以内，格式bmp、png、jpeg、jpg、gif；  尺寸不小于500*500px的正方形；  请优先使用商家LOGO；
        /// </summary>
        /// <value>logo的图片ID，通过接口（alipay.offline.material.image.upload）上传图片    图片说明：1M以内，格式bmp、png、jpeg、jpg、gif；  尺寸不小于500*500px的正方形；  请优先使用商家LOGO；</value>
        [DataMember(Name = "logo_id", EmitDefaultValue = false)]
        public string LogoId { get; set; }

        /// <summary>
        /// 标语
        /// </summary>
        /// <value>标语</value>
        [DataMember(Name = "slogan", EmitDefaultValue = false)]
        public string Slogan { get; set; }

        /// <summary>
        /// 标语图片id， 通过接口（alipay.offline.material.image.upload）上传图片
        /// </summary>
        /// <value>标语图片id， 通过接口（alipay.offline.material.image.upload）上传图片</value>
        [DataMember(Name = "slogan_img_id", EmitDefaultValue = false)]
        public string SloganImgId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TemplateStyleInfoDTO {\n");
            sb.Append("  BackgroundId: ").Append(BackgroundId).Append("\n");
            sb.Append("  BannerImgId: ").Append(BannerImgId).Append("\n");
            sb.Append("  BannerUrl: ").Append(BannerUrl).Append("\n");
            sb.Append("  BgColor: ").Append(BgColor).Append("\n");
            sb.Append("  BrandName: ").Append(BrandName).Append("\n");
            sb.Append("  CardShowName: ").Append(CardShowName).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  ColumnInfoLayout: ").Append(ColumnInfoLayout).Append("\n");
            sb.Append("  FeatureDescriptions: ").Append(FeatureDescriptions).Append("\n");
            sb.Append("  FrontImageEnable: ").Append(FrontImageEnable).Append("\n");
            sb.Append("  FrontTextListEnable: ").Append(FrontTextListEnable).Append("\n");
            sb.Append("  LogoId: ").Append(LogoId).Append("\n");
            sb.Append("  Slogan: ").Append(Slogan).Append("\n");
            sb.Append("  SloganImgId: ").Append(SloganImgId).Append("\n");
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
            return this.Equals(input as TemplateStyleInfoDTO);
        }

        /// <summary>
        /// Returns true if TemplateStyleInfoDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateStyleInfoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateStyleInfoDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BackgroundId == input.BackgroundId ||
                    (this.BackgroundId != null &&
                    this.BackgroundId.Equals(input.BackgroundId))
                ) && 
                (
                    this.BannerImgId == input.BannerImgId ||
                    (this.BannerImgId != null &&
                    this.BannerImgId.Equals(input.BannerImgId))
                ) && 
                (
                    this.BannerUrl == input.BannerUrl ||
                    (this.BannerUrl != null &&
                    this.BannerUrl.Equals(input.BannerUrl))
                ) && 
                (
                    this.BgColor == input.BgColor ||
                    (this.BgColor != null &&
                    this.BgColor.Equals(input.BgColor))
                ) && 
                (
                    this.BrandName == input.BrandName ||
                    (this.BrandName != null &&
                    this.BrandName.Equals(input.BrandName))
                ) && 
                (
                    this.CardShowName == input.CardShowName ||
                    (this.CardShowName != null &&
                    this.CardShowName.Equals(input.CardShowName))
                ) && 
                (
                    this.Color == input.Color ||
                    (this.Color != null &&
                    this.Color.Equals(input.Color))
                ) && 
                (
                    this.ColumnInfoLayout == input.ColumnInfoLayout ||
                    (this.ColumnInfoLayout != null &&
                    this.ColumnInfoLayout.Equals(input.ColumnInfoLayout))
                ) && 
                (
                    this.FeatureDescriptions == input.FeatureDescriptions ||
                    this.FeatureDescriptions != null &&
                    input.FeatureDescriptions != null &&
                    this.FeatureDescriptions.SequenceEqual(input.FeatureDescriptions)
                ) && 
                (
                    this.FrontImageEnable == input.FrontImageEnable ||
                    this.FrontImageEnable.Equals(input.FrontImageEnable)
                ) && 
                (
                    this.FrontTextListEnable == input.FrontTextListEnable ||
                    this.FrontTextListEnable.Equals(input.FrontTextListEnable)
                ) && 
                (
                    this.LogoId == input.LogoId ||
                    (this.LogoId != null &&
                    this.LogoId.Equals(input.LogoId))
                ) && 
                (
                    this.Slogan == input.Slogan ||
                    (this.Slogan != null &&
                    this.Slogan.Equals(input.Slogan))
                ) && 
                (
                    this.SloganImgId == input.SloganImgId ||
                    (this.SloganImgId != null &&
                    this.SloganImgId.Equals(input.SloganImgId))
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
                if (this.BackgroundId != null)
                {
                    hashCode = (hashCode * 59) + this.BackgroundId.GetHashCode();
                }
                if (this.BannerImgId != null)
                {
                    hashCode = (hashCode * 59) + this.BannerImgId.GetHashCode();
                }
                if (this.BannerUrl != null)
                {
                    hashCode = (hashCode * 59) + this.BannerUrl.GetHashCode();
                }
                if (this.BgColor != null)
                {
                    hashCode = (hashCode * 59) + this.BgColor.GetHashCode();
                }
                if (this.BrandName != null)
                {
                    hashCode = (hashCode * 59) + this.BrandName.GetHashCode();
                }
                if (this.CardShowName != null)
                {
                    hashCode = (hashCode * 59) + this.CardShowName.GetHashCode();
                }
                if (this.Color != null)
                {
                    hashCode = (hashCode * 59) + this.Color.GetHashCode();
                }
                if (this.ColumnInfoLayout != null)
                {
                    hashCode = (hashCode * 59) + this.ColumnInfoLayout.GetHashCode();
                }
                if (this.FeatureDescriptions != null)
                {
                    hashCode = (hashCode * 59) + this.FeatureDescriptions.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FrontImageEnable.GetHashCode();
                hashCode = (hashCode * 59) + this.FrontTextListEnable.GetHashCode();
                if (this.LogoId != null)
                {
                    hashCode = (hashCode * 59) + this.LogoId.GetHashCode();
                }
                if (this.Slogan != null)
                {
                    hashCode = (hashCode * 59) + this.Slogan.GetHashCode();
                }
                if (this.SloganImgId != null)
                {
                    hashCode = (hashCode * 59) + this.SloganImgId.GetHashCode();
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
