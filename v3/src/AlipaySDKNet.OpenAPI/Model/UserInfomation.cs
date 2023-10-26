/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2023-10-26
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
    /// UserInfomation
    /// </summary>
    [DataContract(Name = "UserInfomation")]
    public partial class UserInfomation : IEquatable<UserInfomation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserInfomation" /> class.
        /// </summary>
        /// <param name="certNo">证件号.</param>
        /// <param name="certType">证件类型。.</param>
        /// <param name="extInfo">扩展信息.</param>
        /// <param name="mobile">手机号.</param>
        /// <param name="name">姓名.</param>
        /// <param name="openId">用户open_id.</param>
        /// <param name="userId">支付宝uid.</param>
        public UserInfomation(string certNo = default(string), string certType = default(string), List<OrderExtInfo> extInfo = default(List<OrderExtInfo>), string mobile = default(string), string name = default(string), string openId = default(string), string userId = default(string))
        {
            this.CertNo = certNo;
            this.CertType = certType;
            this.ExtInfo = extInfo;
            this.Mobile = mobile;
            this.Name = name;
            this.OpenId = openId;
            this.UserId = userId;
        }

        /// <summary>
        /// 证件号
        /// </summary>
        /// <value>证件号</value>
        [DataMember(Name = "cert_no", EmitDefaultValue = false)]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型。
        /// </summary>
        /// <value>证件类型。</value>
        [DataMember(Name = "cert_type", EmitDefaultValue = false)]
        public string CertType { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        /// <value>扩展信息</value>
        [DataMember(Name = "ext_info", EmitDefaultValue = false)]
        public List<OrderExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        /// <value>手机号</value>
        [DataMember(Name = "mobile", EmitDefaultValue = false)]
        public string Mobile { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        /// <value>姓名</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// 用户open_id
        /// </summary>
        /// <value>用户open_id</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝uid
        /// </summary>
        /// <value>支付宝uid</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserInfomation {\n");
            sb.Append("  CertNo: ").Append(CertNo).Append("\n");
            sb.Append("  CertType: ").Append(CertType).Append("\n");
            sb.Append("  ExtInfo: ").Append(ExtInfo).Append("\n");
            sb.Append("  Mobile: ").Append(Mobile).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as UserInfomation);
        }

        /// <summary>
        /// Returns true if UserInfomation instances are equal
        /// </summary>
        /// <param name="input">Instance of UserInfomation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserInfomation input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CertNo == input.CertNo ||
                    (this.CertNo != null &&
                    this.CertNo.Equals(input.CertNo))
                ) && 
                (
                    this.CertType == input.CertType ||
                    (this.CertType != null &&
                    this.CertType.Equals(input.CertType))
                ) && 
                (
                    this.ExtInfo == input.ExtInfo ||
                    this.ExtInfo != null &&
                    input.ExtInfo != null &&
                    this.ExtInfo.SequenceEqual(input.ExtInfo)
                ) && 
                (
                    this.Mobile == input.Mobile ||
                    (this.Mobile != null &&
                    this.Mobile.Equals(input.Mobile))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.CertNo != null)
                {
                    hashCode = (hashCode * 59) + this.CertNo.GetHashCode();
                }
                if (this.CertType != null)
                {
                    hashCode = (hashCode * 59) + this.CertType.GetHashCode();
                }
                if (this.ExtInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ExtInfo.GetHashCode();
                }
                if (this.Mobile != null)
                {
                    hashCode = (hashCode * 59) + this.Mobile.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
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
