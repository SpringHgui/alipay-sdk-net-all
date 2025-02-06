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
    /// AuthorizedRuleDTO
    /// </summary>
    [DataContract(Name = "AuthorizedRuleDTO")]
    public partial class AuthorizedRuleDTO : IEquatable<AuthorizedRuleDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizedRuleDTO" /> class.
        /// </summary>
        /// <param name="authorizedDetailList">授权商户列表.</param>
        /// <param name="authorizedType">WHITELIST-白名单 ALL-全部.</param>
        public AuthorizedRuleDTO(List<AuthorizeDetailDTO> authorizedDetailList = default(List<AuthorizeDetailDTO>), string authorizedType = default(string))
        {
            this.AuthorizedDetailList = authorizedDetailList;
            this.AuthorizedType = authorizedType;
        }

        /// <summary>
        /// 授权商户列表
        /// </summary>
        /// <value>授权商户列表</value>
        [DataMember(Name = "authorized_detail_list", EmitDefaultValue = false)]
        public List<AuthorizeDetailDTO> AuthorizedDetailList { get; set; }

        /// <summary>
        /// WHITELIST-白名单 ALL-全部
        /// </summary>
        /// <value>WHITELIST-白名单 ALL-全部</value>
        [DataMember(Name = "authorized_type", EmitDefaultValue = false)]
        public string AuthorizedType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuthorizedRuleDTO {\n");
            sb.Append("  AuthorizedDetailList: ").Append(AuthorizedDetailList).Append("\n");
            sb.Append("  AuthorizedType: ").Append(AuthorizedType).Append("\n");
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
            return this.Equals(input as AuthorizedRuleDTO);
        }

        /// <summary>
        /// Returns true if AuthorizedRuleDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthorizedRuleDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthorizedRuleDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AuthorizedDetailList == input.AuthorizedDetailList ||
                    this.AuthorizedDetailList != null &&
                    input.AuthorizedDetailList != null &&
                    this.AuthorizedDetailList.SequenceEqual(input.AuthorizedDetailList)
                ) && 
                (
                    this.AuthorizedType == input.AuthorizedType ||
                    (this.AuthorizedType != null &&
                    this.AuthorizedType.Equals(input.AuthorizedType))
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
                if (this.AuthorizedDetailList != null)
                {
                    hashCode = (hashCode * 59) + this.AuthorizedDetailList.GetHashCode();
                }
                if (this.AuthorizedType != null)
                {
                    hashCode = (hashCode * 59) + this.AuthorizedType.GetHashCode();
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
