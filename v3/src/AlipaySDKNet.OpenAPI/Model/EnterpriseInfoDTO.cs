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
    /// EnterpriseInfoDTO
    /// </summary>
    [DataContract(Name = "EnterpriseInfoDTO")]
    public partial class EnterpriseInfoDTO : IEquatable<EnterpriseInfoDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnterpriseInfoDTO" /> class.
        /// </summary>
        /// <param name="accountId">账户id.</param>
        /// <param name="activate">因公签约状态 UNACTIVATED:未激活 ACTIVATED:已激活 说明：表示签约资金因公付.</param>
        /// <param name="authLevel">企业认证等级 10初级认证  30 高级认证.</param>
        /// <param name="authStatus">认证状态  NO_AUTH：未认证 IN_AUTH：认证中 HAS_AUTH：已认证.</param>
        /// <param name="authTime">认证时间.</param>
        /// <param name="enterpriseAlias">企业名称.</param>
        /// <param name="enterpriseCode">统一社会信用码.</param>
        /// <param name="enterpriseEmail">企业邮箱.</param>
        /// <param name="enterpriseId">企业id.</param>
        /// <param name="enterpriseName">企业名称.</param>
        /// <param name="gmtCreate">创建时间.</param>
        /// <param name="gmtModified">更新时间.</param>
        /// <param name="iotGroupId">封闭场景（如班车）的人脸库id.</param>
        /// <param name="iotLogicGroupId">开放场景（如团餐）的人脸库id.</param>
        /// <param name="platformCode">外部平台code.</param>
        /// <param name="platformOutId">外部平台id.</param>
        /// <param name="signStatus">企业服务协议状态 UNSIGNED:未签约 SIGNED:已签约 TERMINATED:已解约 说明：表示签约企业码服务协议.</param>
        /// <param name="status">企业当前状态 SYNC：数据同步中 NORMAL：正常 WITHDRAW：注销.</param>
        public EnterpriseInfoDTO(string accountId = default(string), string activate = default(string), string authLevel = default(string), string authStatus = default(string), string authTime = default(string), string enterpriseAlias = default(string), string enterpriseCode = default(string), string enterpriseEmail = default(string), string enterpriseId = default(string), string enterpriseName = default(string), string gmtCreate = default(string), string gmtModified = default(string), string iotGroupId = default(string), string iotLogicGroupId = default(string), string platformCode = default(string), string platformOutId = default(string), string signStatus = default(string), string status = default(string))
        {
            this.AccountId = accountId;
            this.Activate = activate;
            this.AuthLevel = authLevel;
            this.AuthStatus = authStatus;
            this.AuthTime = authTime;
            this.EnterpriseAlias = enterpriseAlias;
            this.EnterpriseCode = enterpriseCode;
            this.EnterpriseEmail = enterpriseEmail;
            this.EnterpriseId = enterpriseId;
            this.EnterpriseName = enterpriseName;
            this.GmtCreate = gmtCreate;
            this.GmtModified = gmtModified;
            this.IotGroupId = iotGroupId;
            this.IotLogicGroupId = iotLogicGroupId;
            this.PlatformCode = platformCode;
            this.PlatformOutId = platformOutId;
            this.SignStatus = signStatus;
            this.Status = status;
        }

        /// <summary>
        /// 账户id
        /// </summary>
        /// <value>账户id</value>
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// 因公签约状态 UNACTIVATED:未激活 ACTIVATED:已激活 说明：表示签约资金因公付
        /// </summary>
        /// <value>因公签约状态 UNACTIVATED:未激活 ACTIVATED:已激活 说明：表示签约资金因公付</value>
        [DataMember(Name = "activate", EmitDefaultValue = false)]
        public string Activate { get; set; }

        /// <summary>
        /// 企业认证等级 10初级认证  30 高级认证
        /// </summary>
        /// <value>企业认证等级 10初级认证  30 高级认证</value>
        [DataMember(Name = "auth_level", EmitDefaultValue = false)]
        public string AuthLevel { get; set; }

        /// <summary>
        /// 认证状态  NO_AUTH：未认证 IN_AUTH：认证中 HAS_AUTH：已认证
        /// </summary>
        /// <value>认证状态  NO_AUTH：未认证 IN_AUTH：认证中 HAS_AUTH：已认证</value>
        [DataMember(Name = "auth_status", EmitDefaultValue = false)]
        public string AuthStatus { get; set; }

        /// <summary>
        /// 认证时间
        /// </summary>
        /// <value>认证时间</value>
        [DataMember(Name = "auth_time", EmitDefaultValue = false)]
        public string AuthTime { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        /// <value>企业名称</value>
        [DataMember(Name = "enterprise_alias", EmitDefaultValue = false)]
        public string EnterpriseAlias { get; set; }

        /// <summary>
        /// 统一社会信用码
        /// </summary>
        /// <value>统一社会信用码</value>
        [DataMember(Name = "enterprise_code", EmitDefaultValue = false)]
        public string EnterpriseCode { get; set; }

        /// <summary>
        /// 企业邮箱
        /// </summary>
        /// <value>企业邮箱</value>
        [DataMember(Name = "enterprise_email", EmitDefaultValue = false)]
        public string EnterpriseEmail { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        /// <value>企业id</value>
        [DataMember(Name = "enterprise_id", EmitDefaultValue = false)]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        /// <value>企业名称</value>
        [DataMember(Name = "enterprise_name", EmitDefaultValue = false)]
        public string EnterpriseName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        /// <value>创建时间</value>
        [DataMember(Name = "gmt_create", EmitDefaultValue = false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        /// <value>更新时间</value>
        [DataMember(Name = "gmt_modified", EmitDefaultValue = false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// 封闭场景（如班车）的人脸库id
        /// </summary>
        /// <value>封闭场景（如班车）的人脸库id</value>
        [DataMember(Name = "iot_group_id", EmitDefaultValue = false)]
        public string IotGroupId { get; set; }

        /// <summary>
        /// 开放场景（如团餐）的人脸库id
        /// </summary>
        /// <value>开放场景（如团餐）的人脸库id</value>
        [DataMember(Name = "iot_logic_group_id", EmitDefaultValue = false)]
        public string IotLogicGroupId { get; set; }

        /// <summary>
        /// 外部平台code
        /// </summary>
        /// <value>外部平台code</value>
        [DataMember(Name = "platform_code", EmitDefaultValue = false)]
        public string PlatformCode { get; set; }

        /// <summary>
        /// 外部平台id
        /// </summary>
        /// <value>外部平台id</value>
        [DataMember(Name = "platform_out_id", EmitDefaultValue = false)]
        public string PlatformOutId { get; set; }

        /// <summary>
        /// 企业服务协议状态 UNSIGNED:未签约 SIGNED:已签约 TERMINATED:已解约 说明：表示签约企业码服务协议
        /// </summary>
        /// <value>企业服务协议状态 UNSIGNED:未签约 SIGNED:已签约 TERMINATED:已解约 说明：表示签约企业码服务协议</value>
        [DataMember(Name = "sign_status", EmitDefaultValue = false)]
        public string SignStatus { get; set; }

        /// <summary>
        /// 企业当前状态 SYNC：数据同步中 NORMAL：正常 WITHDRAW：注销
        /// </summary>
        /// <value>企业当前状态 SYNC：数据同步中 NORMAL：正常 WITHDRAW：注销</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EnterpriseInfoDTO {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Activate: ").Append(Activate).Append("\n");
            sb.Append("  AuthLevel: ").Append(AuthLevel).Append("\n");
            sb.Append("  AuthStatus: ").Append(AuthStatus).Append("\n");
            sb.Append("  AuthTime: ").Append(AuthTime).Append("\n");
            sb.Append("  EnterpriseAlias: ").Append(EnterpriseAlias).Append("\n");
            sb.Append("  EnterpriseCode: ").Append(EnterpriseCode).Append("\n");
            sb.Append("  EnterpriseEmail: ").Append(EnterpriseEmail).Append("\n");
            sb.Append("  EnterpriseId: ").Append(EnterpriseId).Append("\n");
            sb.Append("  EnterpriseName: ").Append(EnterpriseName).Append("\n");
            sb.Append("  GmtCreate: ").Append(GmtCreate).Append("\n");
            sb.Append("  GmtModified: ").Append(GmtModified).Append("\n");
            sb.Append("  IotGroupId: ").Append(IotGroupId).Append("\n");
            sb.Append("  IotLogicGroupId: ").Append(IotLogicGroupId).Append("\n");
            sb.Append("  PlatformCode: ").Append(PlatformCode).Append("\n");
            sb.Append("  PlatformOutId: ").Append(PlatformOutId).Append("\n");
            sb.Append("  SignStatus: ").Append(SignStatus).Append("\n");
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
            return this.Equals(input as EnterpriseInfoDTO);
        }

        /// <summary>
        /// Returns true if EnterpriseInfoDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of EnterpriseInfoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnterpriseInfoDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.Activate == input.Activate ||
                    (this.Activate != null &&
                    this.Activate.Equals(input.Activate))
                ) && 
                (
                    this.AuthLevel == input.AuthLevel ||
                    (this.AuthLevel != null &&
                    this.AuthLevel.Equals(input.AuthLevel))
                ) && 
                (
                    this.AuthStatus == input.AuthStatus ||
                    (this.AuthStatus != null &&
                    this.AuthStatus.Equals(input.AuthStatus))
                ) && 
                (
                    this.AuthTime == input.AuthTime ||
                    (this.AuthTime != null &&
                    this.AuthTime.Equals(input.AuthTime))
                ) && 
                (
                    this.EnterpriseAlias == input.EnterpriseAlias ||
                    (this.EnterpriseAlias != null &&
                    this.EnterpriseAlias.Equals(input.EnterpriseAlias))
                ) && 
                (
                    this.EnterpriseCode == input.EnterpriseCode ||
                    (this.EnterpriseCode != null &&
                    this.EnterpriseCode.Equals(input.EnterpriseCode))
                ) && 
                (
                    this.EnterpriseEmail == input.EnterpriseEmail ||
                    (this.EnterpriseEmail != null &&
                    this.EnterpriseEmail.Equals(input.EnterpriseEmail))
                ) && 
                (
                    this.EnterpriseId == input.EnterpriseId ||
                    (this.EnterpriseId != null &&
                    this.EnterpriseId.Equals(input.EnterpriseId))
                ) && 
                (
                    this.EnterpriseName == input.EnterpriseName ||
                    (this.EnterpriseName != null &&
                    this.EnterpriseName.Equals(input.EnterpriseName))
                ) && 
                (
                    this.GmtCreate == input.GmtCreate ||
                    (this.GmtCreate != null &&
                    this.GmtCreate.Equals(input.GmtCreate))
                ) && 
                (
                    this.GmtModified == input.GmtModified ||
                    (this.GmtModified != null &&
                    this.GmtModified.Equals(input.GmtModified))
                ) && 
                (
                    this.IotGroupId == input.IotGroupId ||
                    (this.IotGroupId != null &&
                    this.IotGroupId.Equals(input.IotGroupId))
                ) && 
                (
                    this.IotLogicGroupId == input.IotLogicGroupId ||
                    (this.IotLogicGroupId != null &&
                    this.IotLogicGroupId.Equals(input.IotLogicGroupId))
                ) && 
                (
                    this.PlatformCode == input.PlatformCode ||
                    (this.PlatformCode != null &&
                    this.PlatformCode.Equals(input.PlatformCode))
                ) && 
                (
                    this.PlatformOutId == input.PlatformOutId ||
                    (this.PlatformOutId != null &&
                    this.PlatformOutId.Equals(input.PlatformOutId))
                ) && 
                (
                    this.SignStatus == input.SignStatus ||
                    (this.SignStatus != null &&
                    this.SignStatus.Equals(input.SignStatus))
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
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.Activate != null)
                {
                    hashCode = (hashCode * 59) + this.Activate.GetHashCode();
                }
                if (this.AuthLevel != null)
                {
                    hashCode = (hashCode * 59) + this.AuthLevel.GetHashCode();
                }
                if (this.AuthStatus != null)
                {
                    hashCode = (hashCode * 59) + this.AuthStatus.GetHashCode();
                }
                if (this.AuthTime != null)
                {
                    hashCode = (hashCode * 59) + this.AuthTime.GetHashCode();
                }
                if (this.EnterpriseAlias != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseAlias.GetHashCode();
                }
                if (this.EnterpriseCode != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseCode.GetHashCode();
                }
                if (this.EnterpriseEmail != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseEmail.GetHashCode();
                }
                if (this.EnterpriseId != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseId.GetHashCode();
                }
                if (this.EnterpriseName != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseName.GetHashCode();
                }
                if (this.GmtCreate != null)
                {
                    hashCode = (hashCode * 59) + this.GmtCreate.GetHashCode();
                }
                if (this.GmtModified != null)
                {
                    hashCode = (hashCode * 59) + this.GmtModified.GetHashCode();
                }
                if (this.IotGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.IotGroupId.GetHashCode();
                }
                if (this.IotLogicGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.IotLogicGroupId.GetHashCode();
                }
                if (this.PlatformCode != null)
                {
                    hashCode = (hashCode * 59) + this.PlatformCode.GetHashCode();
                }
                if (this.PlatformOutId != null)
                {
                    hashCode = (hashCode * 59) + this.PlatformOutId.GetHashCode();
                }
                if (this.SignStatus != null)
                {
                    hashCode = (hashCode * 59) + this.SignStatus.GetHashCode();
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
