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
    /// AdvertItem
    /// </summary>
    [DataContract(Name = "AdvertItem")]
    public partial class AdvertItem : IEquatable<AdvertItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdvertItem" /> class.
        /// </summary>
        /// <param name="imgUrl">广告图片url, 尺寸为996*240，最大不超过5M，支持格式:.jpg、.png ，请先调用&lt;a href&#x3D;\&quot;https://docs.open.alipay.com/api_3/alipay.offline.material.image.upload\&quot;&gt; 图片上传接口&lt;/a&gt;获得图片url.</param>
        /// <param name="linkType">跳转类型，网页:HTTP、小程序:APP，不传默认HTTP.</param>
        /// <param name="linkUrl">跳转链接，点击广告图片跳到的链接url.</param>
        /// <param name="name">广告帧名称，可选.</param>
        public AdvertItem(string imgUrl = default(string), string linkType = default(string), string linkUrl = default(string), string name = default(string))
        {
            this.ImgUrl = imgUrl;
            this.LinkType = linkType;
            this.LinkUrl = linkUrl;
            this.Name = name;
        }

        /// <summary>
        /// 广告图片url, 尺寸为996*240，最大不超过5M，支持格式:.jpg、.png ，请先调用&lt;a href&#x3D;\&quot;https://docs.open.alipay.com/api_3/alipay.offline.material.image.upload\&quot;&gt; 图片上传接口&lt;/a&gt;获得图片url
        /// </summary>
        /// <value>广告图片url, 尺寸为996*240，最大不超过5M，支持格式:.jpg、.png ，请先调用&lt;a href&#x3D;\&quot;https://docs.open.alipay.com/api_3/alipay.offline.material.image.upload\&quot;&gt; 图片上传接口&lt;/a&gt;获得图片url</value>
        [DataMember(Name = "img_url", EmitDefaultValue = false)]
        public string ImgUrl { get; set; }

        /// <summary>
        /// 跳转类型，网页:HTTP、小程序:APP，不传默认HTTP
        /// </summary>
        /// <value>跳转类型，网页:HTTP、小程序:APP，不传默认HTTP</value>
        [DataMember(Name = "link_type", EmitDefaultValue = false)]
        public string LinkType { get; set; }

        /// <summary>
        /// 跳转链接，点击广告图片跳到的链接url
        /// </summary>
        /// <value>跳转链接，点击广告图片跳到的链接url</value>
        [DataMember(Name = "link_url", EmitDefaultValue = false)]
        public string LinkUrl { get; set; }

        /// <summary>
        /// 广告帧名称，可选
        /// </summary>
        /// <value>广告帧名称，可选</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdvertItem {\n");
            sb.Append("  ImgUrl: ").Append(ImgUrl).Append("\n");
            sb.Append("  LinkType: ").Append(LinkType).Append("\n");
            sb.Append("  LinkUrl: ").Append(LinkUrl).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as AdvertItem);
        }

        /// <summary>
        /// Returns true if AdvertItem instances are equal
        /// </summary>
        /// <param name="input">Instance of AdvertItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdvertItem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ImgUrl == input.ImgUrl ||
                    (this.ImgUrl != null &&
                    this.ImgUrl.Equals(input.ImgUrl))
                ) && 
                (
                    this.LinkType == input.LinkType ||
                    (this.LinkType != null &&
                    this.LinkType.Equals(input.LinkType))
                ) && 
                (
                    this.LinkUrl == input.LinkUrl ||
                    (this.LinkUrl != null &&
                    this.LinkUrl.Equals(input.LinkUrl))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.ImgUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ImgUrl.GetHashCode();
                }
                if (this.LinkType != null)
                {
                    hashCode = (hashCode * 59) + this.LinkType.GetHashCode();
                }
                if (this.LinkUrl != null)
                {
                    hashCode = (hashCode * 59) + this.LinkUrl.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
