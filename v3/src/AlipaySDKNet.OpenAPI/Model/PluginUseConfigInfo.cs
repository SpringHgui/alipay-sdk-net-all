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
    /// PluginUseConfigInfo
    /// </summary>
    [DataContract(Name = "PluginUseConfigInfo")]
    public partial class PluginUseConfigInfo : IEquatable<PluginUseConfigInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PluginUseConfigInfo" /> class.
        /// </summary>
        /// <param name="bundleId">端.</param>
        /// <param name="grayCode">灰度策略.</param>
        /// <param name="pluginDevelopVersion">插件研发版本.</param>
        /// <param name="status">GRAY(灰度中)/RELEASE(在线状态).</param>
        public PluginUseConfigInfo(string bundleId = default(string), string grayCode = default(string), string pluginDevelopVersion = default(string), string status = default(string))
        {
            this.BundleId = bundleId;
            this.GrayCode = grayCode;
            this.PluginDevelopVersion = pluginDevelopVersion;
            this.Status = status;
        }

        /// <summary>
        /// 端
        /// </summary>
        /// <value>端</value>
        [DataMember(Name = "bundle_id", EmitDefaultValue = false)]
        public string BundleId { get; set; }

        /// <summary>
        /// 灰度策略
        /// </summary>
        /// <value>灰度策略</value>
        [DataMember(Name = "gray_code", EmitDefaultValue = false)]
        public string GrayCode { get; set; }

        /// <summary>
        /// 插件研发版本
        /// </summary>
        /// <value>插件研发版本</value>
        [DataMember(Name = "plugin_develop_version", EmitDefaultValue = false)]
        public string PluginDevelopVersion { get; set; }

        /// <summary>
        /// GRAY(灰度中)/RELEASE(在线状态)
        /// </summary>
        /// <value>GRAY(灰度中)/RELEASE(在线状态)</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PluginUseConfigInfo {\n");
            sb.Append("  BundleId: ").Append(BundleId).Append("\n");
            sb.Append("  GrayCode: ").Append(GrayCode).Append("\n");
            sb.Append("  PluginDevelopVersion: ").Append(PluginDevelopVersion).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as PluginUseConfigInfo);
        }

        /// <summary>
        /// Returns true if PluginUseConfigInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of PluginUseConfigInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PluginUseConfigInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BundleId == input.BundleId ||
                    (this.BundleId != null &&
                    this.BundleId.Equals(input.BundleId))
                ) && 
                (
                    this.GrayCode == input.GrayCode ||
                    (this.GrayCode != null &&
                    this.GrayCode.Equals(input.GrayCode))
                ) && 
                (
                    this.PluginDevelopVersion == input.PluginDevelopVersion ||
                    (this.PluginDevelopVersion != null &&
                    this.PluginDevelopVersion.Equals(input.PluginDevelopVersion))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.BundleId != null)
                {
                    hashCode = (hashCode * 59) + this.BundleId.GetHashCode();
                }
                if (this.GrayCode != null)
                {
                    hashCode = (hashCode * 59) + this.GrayCode.GetHashCode();
                }
                if (this.PluginDevelopVersion != null)
                {
                    hashCode = (hashCode * 59) + this.PluginDevelopVersion.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
