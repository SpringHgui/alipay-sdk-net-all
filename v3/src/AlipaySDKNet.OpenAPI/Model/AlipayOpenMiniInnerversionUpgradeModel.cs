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
    /// AlipayOpenMiniInnerversionUpgradeModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniInnerversionUpgradeModel")]
    public partial class AlipayOpenMiniInnerversionUpgradeModel : IEquatable<AlipayOpenMiniInnerversionUpgradeModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniInnerversionUpgradeModel" /> class.
        /// </summary>
        /// <param name="appOrigin">来源类型，新接入方需要向支付宝申请专用来源，否则不予接入。.</param>
        /// <param name="bundleId">端ID，多端场景下区分不同端.</param>
        /// <param name="miniAppId">小程序ID，特殊场景专用，普通业务方无需关注该参数。.</param>
        /// <param name="templateId">用于升级的模板id.</param>
        /// <param name="templateVersion">用于升级的模板版本号，版本号必须满足 x.y.z, 且均为数字.</param>
        public AlipayOpenMiniInnerversionUpgradeModel(string appOrigin = default(string), string bundleId = default(string), string miniAppId = default(string), string templateId = default(string), string templateVersion = default(string))
        {
            this.AppOrigin = appOrigin;
            this.BundleId = bundleId;
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
        /// 端ID，多端场景下区分不同端
        /// </summary>
        /// <value>端ID，多端场景下区分不同端</value>
        [DataMember(Name = "bundle_id", EmitDefaultValue = false)]
        public string BundleId { get; set; }

        /// <summary>
        /// 小程序ID，特殊场景专用，普通业务方无需关注该参数。
        /// </summary>
        /// <value>小程序ID，特殊场景专用，普通业务方无需关注该参数。</value>
        [DataMember(Name = "mini_app_id", EmitDefaultValue = false)]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 用于升级的模板id
        /// </summary>
        /// <value>用于升级的模板id</value>
        [DataMember(Name = "template_id", EmitDefaultValue = false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 用于升级的模板版本号，版本号必须满足 x.y.z, 且均为数字
        /// </summary>
        /// <value>用于升级的模板版本号，版本号必须满足 x.y.z, 且均为数字</value>
        [DataMember(Name = "template_version", EmitDefaultValue = false)]
        public string TemplateVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniInnerversionUpgradeModel {\n");
            sb.Append("  AppOrigin: ").Append(AppOrigin).Append("\n");
            sb.Append("  BundleId: ").Append(BundleId).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniInnerversionUpgradeModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniInnerversionUpgradeModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniInnerversionUpgradeModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniInnerversionUpgradeModel input)
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
                    this.BundleId == input.BundleId ||
                    (this.BundleId != null &&
                    this.BundleId.Equals(input.BundleId))
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
                if (this.BundleId != null)
                {
                    hashCode = (hashCode * 59) + this.BundleId.GetHashCode();
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
