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
    /// AlipayOpenMiniInnerversionTemplatedUploadModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniInnerversionTemplatedUploadModel")]
    public partial class AlipayOpenMiniInnerversionTemplatedUploadModel : IEquatable<AlipayOpenMiniInnerversionTemplatedUploadModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniInnerversionTemplatedUploadModel" /> class.
        /// </summary>
        /// <param name="appOrigin">来源类型，新接入方需要向支付宝申请专用来源，否则不予接入。.</param>
        /// <param name="appVersion">格式为: x.y.z，其中x、y、z均为整型数字，版本不能重复构建，且新版本号必须高于旧版本.</param>
        /// <param name="bundleId">端id.</param>
        /// <param name="ext">模板的配置参数，完整内容请参见：https://docs.alipay.com/mini/isv/ortga1.</param>
        /// <param name="miniAppId">小程序ID，特殊场景专用，普通业务方无需关注该参数。.</param>
        /// <param name="templateId">模板id，模板必须已经处于上架/下架状态.</param>
        /// <param name="templateVersion">模板版本，必须处于上架/下架状态。如果为空，默认取当前在架，或者最新下架的版本。.</param>
        public AlipayOpenMiniInnerversionTemplatedUploadModel(string appOrigin = default(string), string appVersion = default(string), string bundleId = default(string), string ext = default(string), string miniAppId = default(string), string templateId = default(string), string templateVersion = default(string))
        {
            this.AppOrigin = appOrigin;
            this.AppVersion = appVersion;
            this.BundleId = bundleId;
            this.Ext = ext;
            this.MiniAppId = miniAppId;
            this.TemplateId = templateId;
            this.TemplateVersion = templateVersion;
        }

        /// <summary>
        /// 来源类型，新接入方需要向支付宝申请专用来源，否则不予接入。
        /// </summary>
        /// <value>来源类型，新接入方需要向支付宝申请专用来源，否则不予接入。</value>
        [DataMember(Name = "app_origin", EmitDefaultValue = false)]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 格式为: x.y.z，其中x、y、z均为整型数字，版本不能重复构建，且新版本号必须高于旧版本
        /// </summary>
        /// <value>格式为: x.y.z，其中x、y、z均为整型数字，版本不能重复构建，且新版本号必须高于旧版本</value>
        [DataMember(Name = "app_version", EmitDefaultValue = false)]
        public string AppVersion { get; set; }

        /// <summary>
        /// 端id
        /// </summary>
        /// <value>端id</value>
        [DataMember(Name = "bundle_id", EmitDefaultValue = false)]
        public string BundleId { get; set; }

        /// <summary>
        /// 模板的配置参数，完整内容请参见：https://docs.alipay.com/mini/isv/ortga1
        /// </summary>
        /// <value>模板的配置参数，完整内容请参见：https://docs.alipay.com/mini/isv/ortga1</value>
        [DataMember(Name = "ext", EmitDefaultValue = false)]
        public string Ext { get; set; }

        /// <summary>
        /// 小程序ID，特殊场景专用，普通业务方无需关注该参数。
        /// </summary>
        /// <value>小程序ID，特殊场景专用，普通业务方无需关注该参数。</value>
        [DataMember(Name = "mini_app_id", EmitDefaultValue = false)]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 模板id，模板必须已经处于上架/下架状态
        /// </summary>
        /// <value>模板id，模板必须已经处于上架/下架状态</value>
        [DataMember(Name = "template_id", EmitDefaultValue = false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 模板版本，必须处于上架/下架状态。如果为空，默认取当前在架，或者最新下架的版本。
        /// </summary>
        /// <value>模板版本，必须处于上架/下架状态。如果为空，默认取当前在架，或者最新下架的版本。</value>
        [DataMember(Name = "template_version", EmitDefaultValue = false)]
        public string TemplateVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniInnerversionTemplatedUploadModel {\n");
            sb.Append("  AppOrigin: ").Append(AppOrigin).Append("\n");
            sb.Append("  AppVersion: ").Append(AppVersion).Append("\n");
            sb.Append("  BundleId: ").Append(BundleId).Append("\n");
            sb.Append("  Ext: ").Append(Ext).Append("\n");
            sb.Append("  MiniAppId: ").Append(MiniAppId).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  TemplateVersion: ").Append(TemplateVersion).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniInnerversionTemplatedUploadModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniInnerversionTemplatedUploadModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniInnerversionTemplatedUploadModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniInnerversionTemplatedUploadModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AppOrigin == input.AppOrigin ||
                    (this.AppOrigin != null &&
                    this.AppOrigin.Equals(input.AppOrigin))
                ) && 
                (
                    this.AppVersion == input.AppVersion ||
                    (this.AppVersion != null &&
                    this.AppVersion.Equals(input.AppVersion))
                ) && 
                (
                    this.BundleId == input.BundleId ||
                    (this.BundleId != null &&
                    this.BundleId.Equals(input.BundleId))
                ) && 
                (
                    this.Ext == input.Ext ||
                    (this.Ext != null &&
                    this.Ext.Equals(input.Ext))
                ) && 
                (
                    this.MiniAppId == input.MiniAppId ||
                    (this.MiniAppId != null &&
                    this.MiniAppId.Equals(input.MiniAppId))
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.TemplateVersion == input.TemplateVersion ||
                    (this.TemplateVersion != null &&
                    this.TemplateVersion.Equals(input.TemplateVersion))
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
                if (this.AppOrigin != null)
                {
                    hashCode = (hashCode * 59) + this.AppOrigin.GetHashCode();
                }
                if (this.AppVersion != null)
                {
                    hashCode = (hashCode * 59) + this.AppVersion.GetHashCode();
                }
                if (this.BundleId != null)
                {
                    hashCode = (hashCode * 59) + this.BundleId.GetHashCode();
                }
                if (this.Ext != null)
                {
                    hashCode = (hashCode * 59) + this.Ext.GetHashCode();
                }
                if (this.MiniAppId != null)
                {
                    hashCode = (hashCode * 59) + this.MiniAppId.GetHashCode();
                }
                if (this.TemplateId != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateId.GetHashCode();
                }
                if (this.TemplateVersion != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateVersion.GetHashCode();
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
