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
    /// ContactFollower
    /// </summary>
    [DataContract(Name = "ContactFollower")]
    public partial class ContactFollower : IEquatable<ContactFollower>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactFollower" /> class.
        /// </summary>
        /// <param name="avatar">支付宝头像.</param>
        /// <param name="defaultAvatar">默认头像.</param>
        /// <param name="eachRecordFlag">false.</param>
        /// <param name="userId">用户id.</param>
        public ContactFollower(string avatar = default(string), string defaultAvatar = default(string), string eachRecordFlag = default(string), string userId = default(string))
        {
            this.Avatar = avatar;
            this.DefaultAvatar = defaultAvatar;
            this.EachRecordFlag = eachRecordFlag;
            this.UserId = userId;
        }

        /// <summary>
        /// 支付宝头像
        /// </summary>
        /// <value>支付宝头像</value>
        [DataMember(Name = "avatar", EmitDefaultValue = false)]
        public string Avatar { get; set; }

        /// <summary>
        /// 默认头像
        /// </summary>
        /// <value>默认头像</value>
        [DataMember(Name = "default_avatar", EmitDefaultValue = false)]
        public string DefaultAvatar { get; set; }

        /// <summary>
        /// false
        /// </summary>
        /// <value>false</value>
        [DataMember(Name = "each_record_flag", EmitDefaultValue = false)]
        public string EachRecordFlag { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        /// <value>用户id</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ContactFollower {\n");
            sb.Append("  Avatar: ").Append(Avatar).Append("\n");
            sb.Append("  DefaultAvatar: ").Append(DefaultAvatar).Append("\n");
            sb.Append("  EachRecordFlag: ").Append(EachRecordFlag).Append("\n");
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
            return this.Equals(input as ContactFollower);
        }

        /// <summary>
        /// Returns true if ContactFollower instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactFollower to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactFollower input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Avatar == input.Avatar ||
                    (this.Avatar != null &&
                    this.Avatar.Equals(input.Avatar))
                ) && 
                (
                    this.DefaultAvatar == input.DefaultAvatar ||
                    (this.DefaultAvatar != null &&
                    this.DefaultAvatar.Equals(input.DefaultAvatar))
                ) && 
                (
                    this.EachRecordFlag == input.EachRecordFlag ||
                    (this.EachRecordFlag != null &&
                    this.EachRecordFlag.Equals(input.EachRecordFlag))
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
                if (this.Avatar != null)
                {
                    hashCode = (hashCode * 59) + this.Avatar.GetHashCode();
                }
                if (this.DefaultAvatar != null)
                {
                    hashCode = (hashCode * 59) + this.DefaultAvatar.GetHashCode();
                }
                if (this.EachRecordFlag != null)
                {
                    hashCode = (hashCode * 59) + this.EachRecordFlag.GetHashCode();
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
