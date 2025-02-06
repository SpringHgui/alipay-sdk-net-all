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
    /// AuthFieldDTO
    /// </summary>
    [DataContract(Name = "AuthFieldDTO")]
    public partial class AuthFieldDTO : IEquatable<AuthFieldDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthFieldDTO" /> class.
        /// </summary>
        /// <param name="apiName">接口英文名称.</param>
        /// <param name="fieldName">接口字段英文名称.</param>
        /// <param name="packageCode">接口归属的功能code.</param>
        /// <param name="reason">驳回原因.</param>
        /// <param name="status">AUDIT 审核中，AGREE通过，REJECT驳回，INVALID无效（isv代申请场景).</param>
        /// <param name="userAppId">用户应用app_id.</param>
        public AuthFieldDTO(string apiName = default(string), string fieldName = default(string), string packageCode = default(string), string reason = default(string), string status = default(string), string userAppId = default(string))
        {
            this.ApiName = apiName;
            this.FieldName = fieldName;
            this.PackageCode = packageCode;
            this.Reason = reason;
            this.Status = status;
            this.UserAppId = userAppId;
        }

        /// <summary>
        /// 接口英文名称
        /// </summary>
        /// <value>接口英文名称</value>
        [DataMember(Name = "api_name", EmitDefaultValue = false)]
        public string ApiName { get; set; }

        /// <summary>
        /// 接口字段英文名称
        /// </summary>
        /// <value>接口字段英文名称</value>
        [DataMember(Name = "field_name", EmitDefaultValue = false)]
        public string FieldName { get; set; }

        /// <summary>
        /// 接口归属的功能code
        /// </summary>
        /// <value>接口归属的功能code</value>
        [DataMember(Name = "package_code", EmitDefaultValue = false)]
        public string PackageCode { get; set; }

        /// <summary>
        /// 驳回原因
        /// </summary>
        /// <value>驳回原因</value>
        [DataMember(Name = "reason", EmitDefaultValue = false)]
        public string Reason { get; set; }

        /// <summary>
        /// AUDIT 审核中，AGREE通过，REJECT驳回，INVALID无效（isv代申请场景)
        /// </summary>
        /// <value>AUDIT 审核中，AGREE通过，REJECT驳回，INVALID无效（isv代申请场景)</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// 用户应用app_id
        /// </summary>
        /// <value>用户应用app_id</value>
        [DataMember(Name = "user_app_id", EmitDefaultValue = false)]
        public string UserAppId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuthFieldDTO {\n");
            sb.Append("  ApiName: ").Append(ApiName).Append("\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  PackageCode: ").Append(PackageCode).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UserAppId: ").Append(UserAppId).Append("\n");
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
            return this.Equals(input as AuthFieldDTO);
        }

        /// <summary>
        /// Returns true if AuthFieldDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthFieldDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthFieldDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ApiName == input.ApiName ||
                    (this.ApiName != null &&
                    this.ApiName.Equals(input.ApiName))
                ) && 
                (
                    this.FieldName == input.FieldName ||
                    (this.FieldName != null &&
                    this.FieldName.Equals(input.FieldName))
                ) && 
                (
                    this.PackageCode == input.PackageCode ||
                    (this.PackageCode != null &&
                    this.PackageCode.Equals(input.PackageCode))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.UserAppId == input.UserAppId ||
                    (this.UserAppId != null &&
                    this.UserAppId.Equals(input.UserAppId))
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
                if (this.ApiName != null)
                {
                    hashCode = (hashCode * 59) + this.ApiName.GetHashCode();
                }
                if (this.FieldName != null)
                {
                    hashCode = (hashCode * 59) + this.FieldName.GetHashCode();
                }
                if (this.PackageCode != null)
                {
                    hashCode = (hashCode * 59) + this.PackageCode.GetHashCode();
                }
                if (this.Reason != null)
                {
                    hashCode = (hashCode * 59) + this.Reason.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.UserAppId != null)
                {
                    hashCode = (hashCode * 59) + this.UserAppId.GetHashCode();
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
