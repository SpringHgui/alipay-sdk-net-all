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
    /// AlipayOpenMiniInnerversionContentRollbackModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniInnerversionContentRollbackModel")]
    public partial class AlipayOpenMiniInnerversionContentRollbackModel : IEquatable<AlipayOpenMiniInnerversionContentRollbackModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniInnerversionContentRollbackModel" /> class.
        /// </summary>
        /// <param name="appOrigin">业务场景来源.</param>
        /// <param name="appVersion">小程序当前上架版本号.</param>
        /// <param name="bundleId">端.</param>
        /// <param name="miniAppId">小程序ID，仅特殊场景使用，普通业务方无需关注该参数。.</param>
        /// <param name="pid">小程序所属主体.</param>
        public AlipayOpenMiniInnerversionContentRollbackModel(string appOrigin = default(string), string appVersion = default(string), string bundleId = default(string), string miniAppId = default(string), string pid = default(string))
        {
            this.AppOrigin = appOrigin;
            this.AppVersion = appVersion;
            this.BundleId = bundleId;
            this.MiniAppId = miniAppId;
            this.Pid = pid;
        }

        /// <summary>
        /// 业务场景来源
        /// </summary>
        /// <value>业务场景来源</value>
        [DataMember(Name = "app_origin", EmitDefaultValue = false)]
        public string AppOrigin { get; set; }

        /// <summary>
        /// 小程序当前上架版本号
        /// </summary>
        /// <value>小程序当前上架版本号</value>
        [DataMember(Name = "app_version", EmitDefaultValue = false)]
        public string AppVersion { get; set; }

        /// <summary>
        /// 端
        /// </summary>
        /// <value>端</value>
        [DataMember(Name = "bundle_id", EmitDefaultValue = false)]
        public string BundleId { get; set; }

        /// <summary>
        /// 小程序ID，仅特殊场景使用，普通业务方无需关注该参数。
        /// </summary>
        /// <value>小程序ID，仅特殊场景使用，普通业务方无需关注该参数。</value>
        [DataMember(Name = "mini_app_id", EmitDefaultValue = false)]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序所属主体
        /// </summary>
        /// <value>小程序所属主体</value>
        [DataMember(Name = "pid", EmitDefaultValue = false)]
        public string Pid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniInnerversionContentRollbackModel {\n");
            sb.Append("  AppOrigin: ").Append(AppOrigin).Append("\n");
            sb.Append("  AppVersion: ").Append(AppVersion).Append("\n");
            sb.Append("  BundleId: ").Append(BundleId).Append("\n");
            sb.Append("  MiniAppId: ").Append(MiniAppId).Append("\n");
            sb.Append("  Pid: ").Append(Pid).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniInnerversionContentRollbackModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniInnerversionContentRollbackModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniInnerversionContentRollbackModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniInnerversionContentRollbackModel input)
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
                    this.MiniAppId == input.MiniAppId ||
                    (this.MiniAppId != null &&
                    this.MiniAppId.Equals(input.MiniAppId))
                ) && 
                (
                    this.Pid == input.Pid ||
                    (this.Pid != null &&
                    this.Pid.Equals(input.Pid))
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
                if (this.MiniAppId != null)
                {
                    hashCode = (hashCode * 59) + this.MiniAppId.GetHashCode();
                }
                if (this.Pid != null)
                {
                    hashCode = (hashCode * 59) + this.Pid.GetHashCode();
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
