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
    /// AlipayOpenMiniVersionBuildQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniVersionBuildQueryResponseModel")]
    public partial class AlipayOpenMiniVersionBuildQueryResponseModel : IEquatable<AlipayOpenMiniVersionBuildQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniVersionBuildQueryResponseModel" /> class.
        /// </summary>
        /// <param name="buildStatus">构建的状态，0-构建排队中；1-正在构建；2-构建成功；3-构建失败；5-构建超时.</param>
        /// <param name="createStatus">创建版本的状态，状态说明如下： 0：构建排队中； 1：正在构建； 2：构建成功； 3：构建失败； 5：构建超时； 6：版本创建成功。.</param>
        /// <param name="needRotation">是否需要轮询.</param>
        /// <param name="versionCreated">是否创建版本.</param>
        public AlipayOpenMiniVersionBuildQueryResponseModel(string buildStatus = default(string), string createStatus = default(string), string needRotation = default(string), string versionCreated = default(string))
        {
            this.BuildStatus = buildStatus;
            this.CreateStatus = createStatus;
            this.NeedRotation = needRotation;
            this.VersionCreated = versionCreated;
        }

        /// <summary>
        /// 构建的状态，0-构建排队中；1-正在构建；2-构建成功；3-构建失败；5-构建超时
        /// </summary>
        /// <value>构建的状态，0-构建排队中；1-正在构建；2-构建成功；3-构建失败；5-构建超时</value>
        [DataMember(Name = "build_status", EmitDefaultValue = false)]
        public string BuildStatus { get; set; }

        /// <summary>
        /// 创建版本的状态，状态说明如下： 0：构建排队中； 1：正在构建； 2：构建成功； 3：构建失败； 5：构建超时； 6：版本创建成功。
        /// </summary>
        /// <value>创建版本的状态，状态说明如下： 0：构建排队中； 1：正在构建； 2：构建成功； 3：构建失败； 5：构建超时； 6：版本创建成功。</value>
        [DataMember(Name = "create_status", EmitDefaultValue = false)]
        public string CreateStatus { get; set; }

        /// <summary>
        /// 是否需要轮询
        /// </summary>
        /// <value>是否需要轮询</value>
        [DataMember(Name = "need_rotation", EmitDefaultValue = false)]
        public string NeedRotation { get; set; }

        /// <summary>
        /// 是否创建版本
        /// </summary>
        /// <value>是否创建版本</value>
        [DataMember(Name = "version_created", EmitDefaultValue = false)]
        public string VersionCreated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniVersionBuildQueryResponseModel {\n");
            sb.Append("  BuildStatus: ").Append(BuildStatus).Append("\n");
            sb.Append("  CreateStatus: ").Append(CreateStatus).Append("\n");
            sb.Append("  NeedRotation: ").Append(NeedRotation).Append("\n");
            sb.Append("  VersionCreated: ").Append(VersionCreated).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniVersionBuildQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniVersionBuildQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniVersionBuildQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniVersionBuildQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BuildStatus == input.BuildStatus ||
                    (this.BuildStatus != null &&
                    this.BuildStatus.Equals(input.BuildStatus))
                ) && 
                (
                    this.CreateStatus == input.CreateStatus ||
                    (this.CreateStatus != null &&
                    this.CreateStatus.Equals(input.CreateStatus))
                ) && 
                (
                    this.NeedRotation == input.NeedRotation ||
                    (this.NeedRotation != null &&
                    this.NeedRotation.Equals(input.NeedRotation))
                ) && 
                (
                    this.VersionCreated == input.VersionCreated ||
                    (this.VersionCreated != null &&
                    this.VersionCreated.Equals(input.VersionCreated))
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
                if (this.BuildStatus != null)
                {
                    hashCode = (hashCode * 59) + this.BuildStatus.GetHashCode();
                }
                if (this.CreateStatus != null)
                {
                    hashCode = (hashCode * 59) + this.CreateStatus.GetHashCode();
                }
                if (this.NeedRotation != null)
                {
                    hashCode = (hashCode * 59) + this.NeedRotation.GetHashCode();
                }
                if (this.VersionCreated != null)
                {
                    hashCode = (hashCode * 59) + this.VersionCreated.GetHashCode();
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
