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
    /// AlipayOpenPublicInfoModifyModel
    /// </summary>
    [DataContract(Name = "AlipayOpenPublicInfoModifyModel")]
    public partial class AlipayOpenPublicInfoModifyModel : IEquatable<AlipayOpenPublicInfoModifyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicInfoModifyModel" /> class.
        /// </summary>
        /// <param name="appName">生活号名称，2-20个字之间。注意： * 不得含有违反法律法规和公序良俗的相关信息； * 不得侵害他人名誉权、知识产权、商业秘密等合法权利； * 不得以太过广泛的、或产品、行业词组来命名，如：女装、皮革批发； * 不得以实名认证的媒体资质账号创建服务窗，或媒体相关名称命名服务窗，如：XX电视台、XX杂志等。.</param>
        /// <param name="authPic">授权运营书图片地址，企业商户若为被经营方授权，需上传加盖公章的扫描件。支持 .jpg、 .jpeg、 .png 格式，需小于1M。使用 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_3/alipay.offline.material.image.upload\&quot;&gt;alipay.offline.material.image.upload&lt;/a&gt;(上传门店照片和视频接口)上传图片后，将得到的image_url回填与此处。.</param>
        /// <param name="backgroundUrl">背景图片地址，建议尺寸 1600 x 1000px，支持.jpg .jpeg .png格式，小于1M。使用 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_3/alipay.offline.material.image.upload\&quot;&gt;alipay.offline.material.image.upload&lt;/a&gt;(上传门店照片和视频接口)上传图片后，将得到的image_url回填与此处。.</param>
        /// <param name="introduction">简介.</param>
        /// <param name="licenseUrl">营业执照地址，建议尺寸 320*320 px，支持 .jpg、 .jpeg、 .png 格式，需小于1M。 使用 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_3/alipay.offline.material.image.upload\&quot;&gt;alipay.offline.material.image.upload&lt;/a&gt;(上传门店照片和视频接口)上传图片后，将得到的image_url回填与此处。.</param>
        /// <param name="logoUrl">生活号头像地址，建议尺寸 320*320 px，支持 .jpg、 .jpeg、 .png 格式，需小于1M。 使用 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_3/alipay.offline.material.image.upload\&quot;&gt;alipay.offline.material.image.upload&lt;/a&gt;(上传门店照片和视频接口)上传图片后，将得到的image_url回填与此处。.</param>
        /// <param name="notifyUrl">通知地址.</param>
        /// <param name="publicGreeting">欢迎语.</param>
        /// <param name="shopPics">门店照片地址，支持 .jpg、 .jpeg、 .png 格式，需小于1M。 使用 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_3/alipay.offline.material.image.upload\&quot;&gt;alipay.offline.material.image.upload&lt;/a&gt;(上传门店照片和视频接口)上传图片后，将得到的image_url回填与此处。.</param>
        public AlipayOpenPublicInfoModifyModel(string appName = default(string), string authPic = default(string), string backgroundUrl = default(string), string introduction = default(string), string licenseUrl = default(string), string logoUrl = default(string), string notifyUrl = default(string), string publicGreeting = default(string), List<string> shopPics = default(List<string>))
        {
            this.AppName = appName;
            this.AuthPic = authPic;
            this.BackgroundUrl = backgroundUrl;
            this.Introduction = introduction;
            this.LicenseUrl = licenseUrl;
            this.LogoUrl = logoUrl;
            this.NotifyUrl = notifyUrl;
            this.PublicGreeting = publicGreeting;
            this.ShopPics = shopPics;
        }

        /// <summary>
        /// 生活号名称，2-20个字之间。注意： * 不得含有违反法律法规和公序良俗的相关信息； * 不得侵害他人名誉权、知识产权、商业秘密等合法权利； * 不得以太过广泛的、或产品、行业词组来命名，如：女装、皮革批发； * 不得以实名认证的媒体资质账号创建服务窗，或媒体相关名称命名服务窗，如：XX电视台、XX杂志等。
        /// </summary>
        /// <value>生活号名称，2-20个字之间。注意： * 不得含有违反法律法规和公序良俗的相关信息； * 不得侵害他人名誉权、知识产权、商业秘密等合法权利； * 不得以太过广泛的、或产品、行业词组来命名，如：女装、皮革批发； * 不得以实名认证的媒体资质账号创建服务窗，或媒体相关名称命名服务窗，如：XX电视台、XX杂志等。</value>
        [DataMember(Name = "app_name", EmitDefaultValue = false)]
        public string AppName { get; set; }

        /// <summary>
        /// 授权运营书图片地址，企业商户若为被经营方授权，需上传加盖公章的扫描件。支持 .jpg、 .jpeg、 .png 格式，需小于1M。使用 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_3/alipay.offline.material.image.upload\&quot;&gt;alipay.offline.material.image.upload&lt;/a&gt;(上传门店照片和视频接口)上传图片后，将得到的image_url回填与此处。
        /// </summary>
        /// <value>授权运营书图片地址，企业商户若为被经营方授权，需上传加盖公章的扫描件。支持 .jpg、 .jpeg、 .png 格式，需小于1M。使用 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_3/alipay.offline.material.image.upload\&quot;&gt;alipay.offline.material.image.upload&lt;/a&gt;(上传门店照片和视频接口)上传图片后，将得到的image_url回填与此处。</value>
        [DataMember(Name = "auth_pic", EmitDefaultValue = false)]
        public string AuthPic { get; set; }

        /// <summary>
        /// 背景图片地址，建议尺寸 1600 x 1000px，支持.jpg .jpeg .png格式，小于1M。使用 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_3/alipay.offline.material.image.upload\&quot;&gt;alipay.offline.material.image.upload&lt;/a&gt;(上传门店照片和视频接口)上传图片后，将得到的image_url回填与此处。
        /// </summary>
        /// <value>背景图片地址，建议尺寸 1600 x 1000px，支持.jpg .jpeg .png格式，小于1M。使用 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_3/alipay.offline.material.image.upload\&quot;&gt;alipay.offline.material.image.upload&lt;/a&gt;(上传门店照片和视频接口)上传图片后，将得到的image_url回填与此处。</value>
        [DataMember(Name = "background_url", EmitDefaultValue = false)]
        public string BackgroundUrl { get; set; }

        /// <summary>
        /// 简介
        /// </summary>
        /// <value>简介</value>
        [DataMember(Name = "introduction", EmitDefaultValue = false)]
        public string Introduction { get; set; }

        /// <summary>
        /// 营业执照地址，建议尺寸 320*320 px，支持 .jpg、 .jpeg、 .png 格式，需小于1M。 使用 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_3/alipay.offline.material.image.upload\&quot;&gt;alipay.offline.material.image.upload&lt;/a&gt;(上传门店照片和视频接口)上传图片后，将得到的image_url回填与此处。
        /// </summary>
        /// <value>营业执照地址，建议尺寸 320*320 px，支持 .jpg、 .jpeg、 .png 格式，需小于1M。 使用 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_3/alipay.offline.material.image.upload\&quot;&gt;alipay.offline.material.image.upload&lt;/a&gt;(上传门店照片和视频接口)上传图片后，将得到的image_url回填与此处。</value>
        [DataMember(Name = "license_url", EmitDefaultValue = false)]
        public string LicenseUrl { get; set; }

        /// <summary>
        /// 生活号头像地址，建议尺寸 320*320 px，支持 .jpg、 .jpeg、 .png 格式，需小于1M。 使用 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_3/alipay.offline.material.image.upload\&quot;&gt;alipay.offline.material.image.upload&lt;/a&gt;(上传门店照片和视频接口)上传图片后，将得到的image_url回填与此处。
        /// </summary>
        /// <value>生活号头像地址，建议尺寸 320*320 px，支持 .jpg、 .jpeg、 .png 格式，需小于1M。 使用 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_3/alipay.offline.material.image.upload\&quot;&gt;alipay.offline.material.image.upload&lt;/a&gt;(上传门店照片和视频接口)上传图片后，将得到的image_url回填与此处。</value>
        [DataMember(Name = "logo_url", EmitDefaultValue = false)]
        public string LogoUrl { get; set; }

        /// <summary>
        /// 通知地址
        /// </summary>
        /// <value>通知地址</value>
        [DataMember(Name = "notify_url", EmitDefaultValue = false)]
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 欢迎语
        /// </summary>
        /// <value>欢迎语</value>
        [DataMember(Name = "public_greeting", EmitDefaultValue = false)]
        public string PublicGreeting { get; set; }

        /// <summary>
        /// 门店照片地址，支持 .jpg、 .jpeg、 .png 格式，需小于1M。 使用 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_3/alipay.offline.material.image.upload\&quot;&gt;alipay.offline.material.image.upload&lt;/a&gt;(上传门店照片和视频接口)上传图片后，将得到的image_url回填与此处。
        /// </summary>
        /// <value>门店照片地址，支持 .jpg、 .jpeg、 .png 格式，需小于1M。 使用 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_3/alipay.offline.material.image.upload\&quot;&gt;alipay.offline.material.image.upload&lt;/a&gt;(上传门店照片和视频接口)上传图片后，将得到的image_url回填与此处。</value>
        [DataMember(Name = "shop_pics", EmitDefaultValue = false)]
        public List<string> ShopPics { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenPublicInfoModifyModel {\n");
            sb.Append("  AppName: ").Append(AppName).Append("\n");
            sb.Append("  AuthPic: ").Append(AuthPic).Append("\n");
            sb.Append("  BackgroundUrl: ").Append(BackgroundUrl).Append("\n");
            sb.Append("  Introduction: ").Append(Introduction).Append("\n");
            sb.Append("  LicenseUrl: ").Append(LicenseUrl).Append("\n");
            sb.Append("  LogoUrl: ").Append(LogoUrl).Append("\n");
            sb.Append("  NotifyUrl: ").Append(NotifyUrl).Append("\n");
            sb.Append("  PublicGreeting: ").Append(PublicGreeting).Append("\n");
            sb.Append("  ShopPics: ").Append(ShopPics).Append("\n");
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
            return this.Equals(input as AlipayOpenPublicInfoModifyModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenPublicInfoModifyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenPublicInfoModifyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenPublicInfoModifyModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AppName == input.AppName ||
                    (this.AppName != null &&
                    this.AppName.Equals(input.AppName))
                ) && 
                (
                    this.AuthPic == input.AuthPic ||
                    (this.AuthPic != null &&
                    this.AuthPic.Equals(input.AuthPic))
                ) && 
                (
                    this.BackgroundUrl == input.BackgroundUrl ||
                    (this.BackgroundUrl != null &&
                    this.BackgroundUrl.Equals(input.BackgroundUrl))
                ) && 
                (
                    this.Introduction == input.Introduction ||
                    (this.Introduction != null &&
                    this.Introduction.Equals(input.Introduction))
                ) && 
                (
                    this.LicenseUrl == input.LicenseUrl ||
                    (this.LicenseUrl != null &&
                    this.LicenseUrl.Equals(input.LicenseUrl))
                ) && 
                (
                    this.LogoUrl == input.LogoUrl ||
                    (this.LogoUrl != null &&
                    this.LogoUrl.Equals(input.LogoUrl))
                ) && 
                (
                    this.NotifyUrl == input.NotifyUrl ||
                    (this.NotifyUrl != null &&
                    this.NotifyUrl.Equals(input.NotifyUrl))
                ) && 
                (
                    this.PublicGreeting == input.PublicGreeting ||
                    (this.PublicGreeting != null &&
                    this.PublicGreeting.Equals(input.PublicGreeting))
                ) && 
                (
                    this.ShopPics == input.ShopPics ||
                    this.ShopPics != null &&
                    input.ShopPics != null &&
                    this.ShopPics.SequenceEqual(input.ShopPics)
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
                if (this.AppName != null)
                {
                    hashCode = (hashCode * 59) + this.AppName.GetHashCode();
                }
                if (this.AuthPic != null)
                {
                    hashCode = (hashCode * 59) + this.AuthPic.GetHashCode();
                }
                if (this.BackgroundUrl != null)
                {
                    hashCode = (hashCode * 59) + this.BackgroundUrl.GetHashCode();
                }
                if (this.Introduction != null)
                {
                    hashCode = (hashCode * 59) + this.Introduction.GetHashCode();
                }
                if (this.LicenseUrl != null)
                {
                    hashCode = (hashCode * 59) + this.LicenseUrl.GetHashCode();
                }
                if (this.LogoUrl != null)
                {
                    hashCode = (hashCode * 59) + this.LogoUrl.GetHashCode();
                }
                if (this.NotifyUrl != null)
                {
                    hashCode = (hashCode * 59) + this.NotifyUrl.GetHashCode();
                }
                if (this.PublicGreeting != null)
                {
                    hashCode = (hashCode * 59) + this.PublicGreeting.GetHashCode();
                }
                if (this.ShopPics != null)
                {
                    hashCode = (hashCode * 59) + this.ShopPics.GetHashCode();
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
