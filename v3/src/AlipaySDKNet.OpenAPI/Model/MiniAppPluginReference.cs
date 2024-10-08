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
    /// MiniAppPluginReference
    /// </summary>
    [DataContract(Name = "MiniAppPluginReference")]
    public partial class MiniAppPluginReference : IEquatable<MiniAppPluginReference>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MiniAppPluginReference" /> class.
        /// </summary>
        /// <param name="lazy">是否懒加载.</param>
        /// <param name="pluginId">插件id，即插件的唯一标识，形如小程序的appId.</param>
        /// <param name="pluginLazy">是否懒加载.</param>
        /// <param name="pluginVersion">小程序引用的插件版本，可以指定插件版本，如：1.0.11；也可以填*，表示引用最新的插件版本，此时，当插件发布新版本后，小程序内的插件会自动更新到最新的版本。.</param>
        public MiniAppPluginReference(bool lazy = default(bool), string pluginId = default(string), bool pluginLazy = default(bool), string pluginVersion = default(string))
        {
            this.Lazy = lazy;
            this.PluginId = pluginId;
            this.PluginLazy = pluginLazy;
            this.PluginVersion = pluginVersion;
        }

        /// <summary>
        /// 是否懒加载
        /// </summary>
        /// <value>是否懒加载</value>
        [DataMember(Name = "lazy", EmitDefaultValue = true)]
        public bool Lazy { get; set; }

        /// <summary>
        /// 插件id，即插件的唯一标识，形如小程序的appId
        /// </summary>
        /// <value>插件id，即插件的唯一标识，形如小程序的appId</value>
        [DataMember(Name = "plugin_id", EmitDefaultValue = false)]
        public string PluginId { get; set; }

        /// <summary>
        /// 是否懒加载
        /// </summary>
        /// <value>是否懒加载</value>
        [DataMember(Name = "plugin_lazy", EmitDefaultValue = true)]
        public bool PluginLazy { get; set; }

        /// <summary>
        /// 小程序引用的插件版本，可以指定插件版本，如：1.0.11；也可以填*，表示引用最新的插件版本，此时，当插件发布新版本后，小程序内的插件会自动更新到最新的版本。
        /// </summary>
        /// <value>小程序引用的插件版本，可以指定插件版本，如：1.0.11；也可以填*，表示引用最新的插件版本，此时，当插件发布新版本后，小程序内的插件会自动更新到最新的版本。</value>
        [DataMember(Name = "plugin_version", EmitDefaultValue = false)]
        public string PluginVersion { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MiniAppPluginReference {\n");
            sb.Append("  Lazy: ").Append(Lazy).Append("\n");
            sb.Append("  PluginId: ").Append(PluginId).Append("\n");
            sb.Append("  PluginLazy: ").Append(PluginLazy).Append("\n");
            sb.Append("  PluginVersion: ").Append(PluginVersion).Append("\n");
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
            return this.Equals(input as MiniAppPluginReference);
        }

        /// <summary>
        /// Returns true if MiniAppPluginReference instances are equal
        /// </summary>
        /// <param name="input">Instance of MiniAppPluginReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MiniAppPluginReference input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Lazy == input.Lazy ||
                    this.Lazy.Equals(input.Lazy)
                ) && 
                (
                    this.PluginId == input.PluginId ||
                    (this.PluginId != null &&
                    this.PluginId.Equals(input.PluginId))
                ) && 
                (
                    this.PluginLazy == input.PluginLazy ||
                    this.PluginLazy.Equals(input.PluginLazy)
                ) && 
                (
                    this.PluginVersion == input.PluginVersion ||
                    (this.PluginVersion != null &&
                    this.PluginVersion.Equals(input.PluginVersion))
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
                hashCode = (hashCode * 59) + this.Lazy.GetHashCode();
                if (this.PluginId != null)
                {
                    hashCode = (hashCode * 59) + this.PluginId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PluginLazy.GetHashCode();
                if (this.PluginVersion != null)
                {
                    hashCode = (hashCode * 59) + this.PluginVersion.GetHashCode();
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
