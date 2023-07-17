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
    /// AlipayOpenMiniInnerversionNobuildUploadModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniInnerversionNobuildUploadModel")]
    public partial class AlipayOpenMiniInnerversionNobuildUploadModel : IEquatable<AlipayOpenMiniInnerversionNobuildUploadModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniInnerversionNobuildUploadModel" /> class.
        /// </summary>
        /// <param name="buildExtraInfo">扩展信息，比如adaptorName、tinycliVersion、tinycliName、import-module、allowPrecompile、extJson、allowInstallDependency、aggregationMainAppId，如果没有特殊要求，tinycliVersion版本请用最新的： https://registry.npm.alibaba-inc.com/@alipay/tiny-cli/huoban-prod.</param>
        /// <param name="buildJsPermission">jsapi权限文件.</param>
        /// <param name="buildMainUrl">小程序页面主入口。/index.html#page/component/index，该值需要和extendInfo中的page参数保持一致.</param>
        /// <param name="buildQcloudInfo">打包平台扩展信息.</param>
        /// <param name="buildVersion">小程序版本.</param>
        /// <param name="buildedPackageSize">已经构建过的amr包大小，单位是字节，建议如实填写.</param>
        /// <param name="buildedPackageUrl">已经构建的包地址，目前主要自行构建的场景使用.</param>
        /// <param name="buildedPluginSize">构建好的插件包amr大小.</param>
        /// <param name="buildedPluginUrl">构建好的插件包地址.</param>
        /// <param name="bundleId">一个端的标识，用于区分不同的客户端，每接入一个客户端，都需要向小程序应用中心申请bundleId入驻.</param>
        /// <param name="components">组件参数.</param>
        /// <param name="instCode">上传调试版的接入租户类型.</param>
        /// <param name="miniAppId">小程序id.</param>
        /// <param name="newBuildedPackageSize">2.0已经构建过的amr包大小，单位是字节，主要是给自行构建的场景使用.</param>
        /// <param name="newBuildedPackageUrl">2.0产物包地址.</param>
        /// <param name="newBuildedPluginSize">构建好的插件包amr大小.</param>
        /// <param name="newBuildedPluginUrl">构建好的插件包地址.</param>
        /// <param name="noSign">否免加签, true的时候代表传过来的是加签后的包地址.</param>
        /// <param name="pluginRefs">小程序代码中引用的插件列表，包含插件id和插件版本信息，业务方需要自行解析源码包的app.json里面的plugins信息.</param>
        /// <param name="subPackages">构建好的分包信息.</param>
        public AlipayOpenMiniInnerversionNobuildUploadModel(string buildExtraInfo = default(string), string buildJsPermission = default(string), string buildMainUrl = default(string), string buildQcloudInfo = default(string), string buildVersion = default(string), string buildedPackageSize = default(string), string buildedPackageUrl = default(string), string buildedPluginSize = default(string), string buildedPluginUrl = default(string), string bundleId = default(string), string components = default(string), string instCode = default(string), string miniAppId = default(string), string newBuildedPackageSize = default(string), string newBuildedPackageUrl = default(string), string newBuildedPluginSize = default(string), string newBuildedPluginUrl = default(string), bool noSign = default(bool), List<MiniAppPluginReference> pluginRefs = default(List<MiniAppPluginReference>), List<SubPackageInfo> subPackages = default(List<SubPackageInfo>))
        {
            this.BuildExtraInfo = buildExtraInfo;
            this.BuildJsPermission = buildJsPermission;
            this.BuildMainUrl = buildMainUrl;
            this.BuildQcloudInfo = buildQcloudInfo;
            this.BuildVersion = buildVersion;
            this.BuildedPackageSize = buildedPackageSize;
            this.BuildedPackageUrl = buildedPackageUrl;
            this.BuildedPluginSize = buildedPluginSize;
            this.BuildedPluginUrl = buildedPluginUrl;
            this.BundleId = bundleId;
            this.Components = components;
            this.InstCode = instCode;
            this.MiniAppId = miniAppId;
            this.NewBuildedPackageSize = newBuildedPackageSize;
            this.NewBuildedPackageUrl = newBuildedPackageUrl;
            this.NewBuildedPluginSize = newBuildedPluginSize;
            this.NewBuildedPluginUrl = newBuildedPluginUrl;
            this.NoSign = noSign;
            this.PluginRefs = pluginRefs;
            this.SubPackages = subPackages;
        }

        /// <summary>
        /// 扩展信息，比如adaptorName、tinycliVersion、tinycliName、import-module、allowPrecompile、extJson、allowInstallDependency、aggregationMainAppId，如果没有特殊要求，tinycliVersion版本请用最新的： https://registry.npm.alibaba-inc.com/@alipay/tiny-cli/huoban-prod
        /// </summary>
        /// <value>扩展信息，比如adaptorName、tinycliVersion、tinycliName、import-module、allowPrecompile、extJson、allowInstallDependency、aggregationMainAppId，如果没有特殊要求，tinycliVersion版本请用最新的： https://registry.npm.alibaba-inc.com/@alipay/tiny-cli/huoban-prod</value>
        [DataMember(Name = "build_extra_info", EmitDefaultValue = false)]
        public string BuildExtraInfo { get; set; }

        /// <summary>
        /// jsapi权限文件
        /// </summary>
        /// <value>jsapi权限文件</value>
        [DataMember(Name = "build_js_permission", EmitDefaultValue = false)]
        public string BuildJsPermission { get; set; }

        /// <summary>
        /// 小程序页面主入口。/index.html#page/component/index，该值需要和extendInfo中的page参数保持一致
        /// </summary>
        /// <value>小程序页面主入口。/index.html#page/component/index，该值需要和extendInfo中的page参数保持一致</value>
        [DataMember(Name = "build_main_url", EmitDefaultValue = false)]
        public string BuildMainUrl { get; set; }

        /// <summary>
        /// 打包平台扩展信息
        /// </summary>
        /// <value>打包平台扩展信息</value>
        [DataMember(Name = "build_qcloud_info", EmitDefaultValue = false)]
        public string BuildQcloudInfo { get; set; }

        /// <summary>
        /// 小程序版本
        /// </summary>
        /// <value>小程序版本</value>
        [DataMember(Name = "build_version", EmitDefaultValue = false)]
        public string BuildVersion { get; set; }

        /// <summary>
        /// 已经构建过的amr包大小，单位是字节，建议如实填写
        /// </summary>
        /// <value>已经构建过的amr包大小，单位是字节，建议如实填写</value>
        [DataMember(Name = "builded_package_size", EmitDefaultValue = false)]
        public string BuildedPackageSize { get; set; }

        /// <summary>
        /// 已经构建的包地址，目前主要自行构建的场景使用
        /// </summary>
        /// <value>已经构建的包地址，目前主要自行构建的场景使用</value>
        [DataMember(Name = "builded_package_url", EmitDefaultValue = false)]
        public string BuildedPackageUrl { get; set; }

        /// <summary>
        /// 构建好的插件包amr大小
        /// </summary>
        /// <value>构建好的插件包amr大小</value>
        [DataMember(Name = "builded_plugin_size", EmitDefaultValue = false)]
        public string BuildedPluginSize { get; set; }

        /// <summary>
        /// 构建好的插件包地址
        /// </summary>
        /// <value>构建好的插件包地址</value>
        [DataMember(Name = "builded_plugin_url", EmitDefaultValue = false)]
        public string BuildedPluginUrl { get; set; }

        /// <summary>
        /// 一个端的标识，用于区分不同的客户端，每接入一个客户端，都需要向小程序应用中心申请bundleId入驻
        /// </summary>
        /// <value>一个端的标识，用于区分不同的客户端，每接入一个客户端，都需要向小程序应用中心申请bundleId入驻</value>
        [DataMember(Name = "bundle_id", EmitDefaultValue = false)]
        public string BundleId { get; set; }

        /// <summary>
        /// 组件参数
        /// </summary>
        /// <value>组件参数</value>
        [DataMember(Name = "components", EmitDefaultValue = false)]
        public string Components { get; set; }

        /// <summary>
        /// 上传调试版的接入租户类型
        /// </summary>
        /// <value>上传调试版的接入租户类型</value>
        [DataMember(Name = "inst_code", EmitDefaultValue = false)]
        public string InstCode { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        /// <value>小程序id</value>
        [DataMember(Name = "mini_app_id", EmitDefaultValue = false)]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 2.0已经构建过的amr包大小，单位是字节，主要是给自行构建的场景使用
        /// </summary>
        /// <value>2.0已经构建过的amr包大小，单位是字节，主要是给自行构建的场景使用</value>
        [DataMember(Name = "new_builded_package_size", EmitDefaultValue = false)]
        public string NewBuildedPackageSize { get; set; }

        /// <summary>
        /// 2.0产物包地址
        /// </summary>
        /// <value>2.0产物包地址</value>
        [DataMember(Name = "new_builded_package_url", EmitDefaultValue = false)]
        public string NewBuildedPackageUrl { get; set; }

        /// <summary>
        /// 构建好的插件包amr大小
        /// </summary>
        /// <value>构建好的插件包amr大小</value>
        [DataMember(Name = "new_builded_plugin_size", EmitDefaultValue = false)]
        public string NewBuildedPluginSize { get; set; }

        /// <summary>
        /// 构建好的插件包地址
        /// </summary>
        /// <value>构建好的插件包地址</value>
        [DataMember(Name = "new_builded_plugin_url", EmitDefaultValue = false)]
        public string NewBuildedPluginUrl { get; set; }

        /// <summary>
        /// 否免加签, true的时候代表传过来的是加签后的包地址
        /// </summary>
        /// <value>否免加签, true的时候代表传过来的是加签后的包地址</value>
        [DataMember(Name = "no_sign", EmitDefaultValue = true)]
        public bool NoSign { get; set; }

        /// <summary>
        /// 小程序代码中引用的插件列表，包含插件id和插件版本信息，业务方需要自行解析源码包的app.json里面的plugins信息
        /// </summary>
        /// <value>小程序代码中引用的插件列表，包含插件id和插件版本信息，业务方需要自行解析源码包的app.json里面的plugins信息</value>
        [DataMember(Name = "plugin_refs", EmitDefaultValue = false)]
        public List<MiniAppPluginReference> PluginRefs { get; set; }

        /// <summary>
        /// 构建好的分包信息
        /// </summary>
        /// <value>构建好的分包信息</value>
        [DataMember(Name = "sub_packages", EmitDefaultValue = false)]
        public List<SubPackageInfo> SubPackages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniInnerversionNobuildUploadModel {\n");
            sb.Append("  BuildExtraInfo: ").Append(BuildExtraInfo).Append("\n");
            sb.Append("  BuildJsPermission: ").Append(BuildJsPermission).Append("\n");
            sb.Append("  BuildMainUrl: ").Append(BuildMainUrl).Append("\n");
            sb.Append("  BuildQcloudInfo: ").Append(BuildQcloudInfo).Append("\n");
            sb.Append("  BuildVersion: ").Append(BuildVersion).Append("\n");
            sb.Append("  BuildedPackageSize: ").Append(BuildedPackageSize).Append("\n");
            sb.Append("  BuildedPackageUrl: ").Append(BuildedPackageUrl).Append("\n");
            sb.Append("  BuildedPluginSize: ").Append(BuildedPluginSize).Append("\n");
            sb.Append("  BuildedPluginUrl: ").Append(BuildedPluginUrl).Append("\n");
            sb.Append("  BundleId: ").Append(BundleId).Append("\n");
            sb.Append("  Components: ").Append(Components).Append("\n");
            sb.Append("  InstCode: ").Append(InstCode).Append("\n");
            sb.Append("  MiniAppId: ").Append(MiniAppId).Append("\n");
            sb.Append("  NewBuildedPackageSize: ").Append(NewBuildedPackageSize).Append("\n");
            sb.Append("  NewBuildedPackageUrl: ").Append(NewBuildedPackageUrl).Append("\n");
            sb.Append("  NewBuildedPluginSize: ").Append(NewBuildedPluginSize).Append("\n");
            sb.Append("  NewBuildedPluginUrl: ").Append(NewBuildedPluginUrl).Append("\n");
            sb.Append("  NoSign: ").Append(NoSign).Append("\n");
            sb.Append("  PluginRefs: ").Append(PluginRefs).Append("\n");
            sb.Append("  SubPackages: ").Append(SubPackages).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniInnerversionNobuildUploadModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniInnerversionNobuildUploadModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniInnerversionNobuildUploadModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniInnerversionNobuildUploadModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BuildExtraInfo == input.BuildExtraInfo ||
                    (this.BuildExtraInfo != null &&
                    this.BuildExtraInfo.Equals(input.BuildExtraInfo))
                ) && 
                (
                    this.BuildJsPermission == input.BuildJsPermission ||
                    (this.BuildJsPermission != null &&
                    this.BuildJsPermission.Equals(input.BuildJsPermission))
                ) && 
                (
                    this.BuildMainUrl == input.BuildMainUrl ||
                    (this.BuildMainUrl != null &&
                    this.BuildMainUrl.Equals(input.BuildMainUrl))
                ) && 
                (
                    this.BuildQcloudInfo == input.BuildQcloudInfo ||
                    (this.BuildQcloudInfo != null &&
                    this.BuildQcloudInfo.Equals(input.BuildQcloudInfo))
                ) && 
                (
                    this.BuildVersion == input.BuildVersion ||
                    (this.BuildVersion != null &&
                    this.BuildVersion.Equals(input.BuildVersion))
                ) && 
                (
                    this.BuildedPackageSize == input.BuildedPackageSize ||
                    (this.BuildedPackageSize != null &&
                    this.BuildedPackageSize.Equals(input.BuildedPackageSize))
                ) && 
                (
                    this.BuildedPackageUrl == input.BuildedPackageUrl ||
                    (this.BuildedPackageUrl != null &&
                    this.BuildedPackageUrl.Equals(input.BuildedPackageUrl))
                ) && 
                (
                    this.BuildedPluginSize == input.BuildedPluginSize ||
                    (this.BuildedPluginSize != null &&
                    this.BuildedPluginSize.Equals(input.BuildedPluginSize))
                ) && 
                (
                    this.BuildedPluginUrl == input.BuildedPluginUrl ||
                    (this.BuildedPluginUrl != null &&
                    this.BuildedPluginUrl.Equals(input.BuildedPluginUrl))
                ) && 
                (
                    this.BundleId == input.BundleId ||
                    (this.BundleId != null &&
                    this.BundleId.Equals(input.BundleId))
                ) && 
                (
                    this.Components == input.Components ||
                    (this.Components != null &&
                    this.Components.Equals(input.Components))
                ) && 
                (
                    this.InstCode == input.InstCode ||
                    (this.InstCode != null &&
                    this.InstCode.Equals(input.InstCode))
                ) && 
                (
                    this.MiniAppId == input.MiniAppId ||
                    (this.MiniAppId != null &&
                    this.MiniAppId.Equals(input.MiniAppId))
                ) && 
                (
                    this.NewBuildedPackageSize == input.NewBuildedPackageSize ||
                    (this.NewBuildedPackageSize != null &&
                    this.NewBuildedPackageSize.Equals(input.NewBuildedPackageSize))
                ) && 
                (
                    this.NewBuildedPackageUrl == input.NewBuildedPackageUrl ||
                    (this.NewBuildedPackageUrl != null &&
                    this.NewBuildedPackageUrl.Equals(input.NewBuildedPackageUrl))
                ) && 
                (
                    this.NewBuildedPluginSize == input.NewBuildedPluginSize ||
                    (this.NewBuildedPluginSize != null &&
                    this.NewBuildedPluginSize.Equals(input.NewBuildedPluginSize))
                ) && 
                (
                    this.NewBuildedPluginUrl == input.NewBuildedPluginUrl ||
                    (this.NewBuildedPluginUrl != null &&
                    this.NewBuildedPluginUrl.Equals(input.NewBuildedPluginUrl))
                ) && 
                (
                    this.NoSign == input.NoSign ||
                    this.NoSign.Equals(input.NoSign)
                ) && 
                (
                    this.PluginRefs == input.PluginRefs ||
                    this.PluginRefs != null &&
                    input.PluginRefs != null &&
                    this.PluginRefs.SequenceEqual(input.PluginRefs)
                ) && 
                (
                    this.SubPackages == input.SubPackages ||
                    this.SubPackages != null &&
                    input.SubPackages != null &&
                    this.SubPackages.SequenceEqual(input.SubPackages)
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
                if (this.BuildExtraInfo != null)
                {
                    hashCode = (hashCode * 59) + this.BuildExtraInfo.GetHashCode();
                }
                if (this.BuildJsPermission != null)
                {
                    hashCode = (hashCode * 59) + this.BuildJsPermission.GetHashCode();
                }
                if (this.BuildMainUrl != null)
                {
                    hashCode = (hashCode * 59) + this.BuildMainUrl.GetHashCode();
                }
                if (this.BuildQcloudInfo != null)
                {
                    hashCode = (hashCode * 59) + this.BuildQcloudInfo.GetHashCode();
                }
                if (this.BuildVersion != null)
                {
                    hashCode = (hashCode * 59) + this.BuildVersion.GetHashCode();
                }
                if (this.BuildedPackageSize != null)
                {
                    hashCode = (hashCode * 59) + this.BuildedPackageSize.GetHashCode();
                }
                if (this.BuildedPackageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.BuildedPackageUrl.GetHashCode();
                }
                if (this.BuildedPluginSize != null)
                {
                    hashCode = (hashCode * 59) + this.BuildedPluginSize.GetHashCode();
                }
                if (this.BuildedPluginUrl != null)
                {
                    hashCode = (hashCode * 59) + this.BuildedPluginUrl.GetHashCode();
                }
                if (this.BundleId != null)
                {
                    hashCode = (hashCode * 59) + this.BundleId.GetHashCode();
                }
                if (this.Components != null)
                {
                    hashCode = (hashCode * 59) + this.Components.GetHashCode();
                }
                if (this.InstCode != null)
                {
                    hashCode = (hashCode * 59) + this.InstCode.GetHashCode();
                }
                if (this.MiniAppId != null)
                {
                    hashCode = (hashCode * 59) + this.MiniAppId.GetHashCode();
                }
                if (this.NewBuildedPackageSize != null)
                {
                    hashCode = (hashCode * 59) + this.NewBuildedPackageSize.GetHashCode();
                }
                if (this.NewBuildedPackageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.NewBuildedPackageUrl.GetHashCode();
                }
                if (this.NewBuildedPluginSize != null)
                {
                    hashCode = (hashCode * 59) + this.NewBuildedPluginSize.GetHashCode();
                }
                if (this.NewBuildedPluginUrl != null)
                {
                    hashCode = (hashCode * 59) + this.NewBuildedPluginUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.NoSign.GetHashCode();
                if (this.PluginRefs != null)
                {
                    hashCode = (hashCode * 59) + this.PluginRefs.GetHashCode();
                }
                if (this.SubPackages != null)
                {
                    hashCode = (hashCode * 59) + this.SubPackages.GetHashCode();
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
