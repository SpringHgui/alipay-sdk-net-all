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
    /// MiniAppPluginInfo
    /// </summary>
    [DataContract(Name = "MiniAppPluginInfo")]
    public partial class MiniAppPluginInfo : IEquatable<MiniAppPluginInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MiniAppPluginInfo" /> class.
        /// </summary>
        /// <param name="packageUrl">插件包地址.</param>
        /// <param name="pluginId">插件id，即插件的唯一标识.</param>
        /// <param name="requireVersion">小程序引用的插件版本，可以指定插件版本，1.2.3。也可以使用最新版本,*。推荐使用*.</param>
        public MiniAppPluginInfo(string packageUrl = default(string), string pluginId = default(string), string requireVersion = default(string))
        {
            this.PackageUrl = packageUrl;
            this.PluginId = pluginId;
            this.RequireVersion = requireVersion;
        }

        /// <summary>
        /// 插件包地址
        /// </summary>
        /// <value>插件包地址</value>
        [DataMember(Name = "package_url", EmitDefaultValue = false)]
        public string PackageUrl { get; set; }

        /// <summary>
        /// 插件id，即插件的唯一标识
        /// </summary>
        /// <value>插件id，即插件的唯一标识</value>
        [DataMember(Name = "plugin_id", EmitDefaultValue = false)]
        public string PluginId { get; set; }

        /// <summary>
        /// 小程序引用的插件版本，可以指定插件版本，1.2.3。也可以使用最新版本,*。推荐使用*
        /// </summary>
        /// <value>小程序引用的插件版本，可以指定插件版本，1.2.3。也可以使用最新版本,*。推荐使用*</value>
        [DataMember(Name = "require_version", EmitDefaultValue = false)]
        public string RequireVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MiniAppPluginInfo {\n");
            sb.Append("  PackageUrl: ").Append(PackageUrl).Append("\n");
            sb.Append("  PluginId: ").Append(PluginId).Append("\n");
            sb.Append("  RequireVersion: ").Append(RequireVersion).Append("\n");
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
            return this.Equals(input as MiniAppPluginInfo);
        }

        /// <summary>
        /// Returns true if MiniAppPluginInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of MiniAppPluginInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MiniAppPluginInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PackageUrl == input.PackageUrl ||
                    (this.PackageUrl != null &&
                    this.PackageUrl.Equals(input.PackageUrl))
                ) && 
                (
                    this.PluginId == input.PluginId ||
                    (this.PluginId != null &&
                    this.PluginId.Equals(input.PluginId))
                ) && 
                (
                    this.RequireVersion == input.RequireVersion ||
                    (this.RequireVersion != null &&
                    this.RequireVersion.Equals(input.RequireVersion))
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
                if (this.PackageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.PackageUrl.GetHashCode();
                }
                if (this.PluginId != null)
                {
                    hashCode = (hashCode * 59) + this.PluginId.GetHashCode();
                }
                if (this.RequireVersion != null)
                {
                    hashCode = (hashCode * 59) + this.RequireVersion.GetHashCode();
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
