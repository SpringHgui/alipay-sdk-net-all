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
    /// AlipayOpenAppMembersCreateModel
    /// </summary>
    [DataContract(Name = "AlipayOpenAppMembersCreateModel")]
    public partial class AlipayOpenAppMembersCreateModel : IEquatable<AlipayOpenAppMembersCreateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenAppMembersCreateModel" /> class.
        /// </summary>
        /// <param name="logonId">支付宝登录账号。.</param>
        /// <param name="role">为成员添加的角色类型.</param>
        public AlipayOpenAppMembersCreateModel(string logonId = default(string), string role = default(string))
        {
            this.LogonId = logonId;
            this.Role = role;
        }

        /// <summary>
        /// 支付宝登录账号。
        /// </summary>
        /// <value>支付宝登录账号。</value>
        [DataMember(Name = "logon_id", EmitDefaultValue = false)]
        public string LogonId { get; set; }

        /// <summary>
        /// 为成员添加的角色类型
        /// </summary>
        /// <value>为成员添加的角色类型</value>
        [DataMember(Name = "role", EmitDefaultValue = false)]
        public string Role { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenAppMembersCreateModel {\n");
            sb.Append("  LogonId: ").Append(LogonId).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
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
            return this.Equals(input as AlipayOpenAppMembersCreateModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenAppMembersCreateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenAppMembersCreateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenAppMembersCreateModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LogonId == input.LogonId ||
                    (this.LogonId != null &&
                    this.LogonId.Equals(input.LogonId))
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
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
                if (this.LogonId != null)
                {
                    hashCode = (hashCode * 59) + this.LogonId.GetHashCode();
                }
                if (this.Role != null)
                {
                    hashCode = (hashCode * 59) + this.Role.GetHashCode();
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
