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
    /// AlipayOpenAppMembersQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenAppMembersQueryResponseModel")]
    public partial class AlipayOpenAppMembersQueryResponseModel : IEquatable<AlipayOpenAppMembersQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenAppMembersQueryResponseModel" /> class.
        /// </summary>
        /// <param name="appMemberInfoList">小程序成员模型.</param>
        public AlipayOpenAppMembersQueryResponseModel(List<AppMemberInfo> appMemberInfoList = default(List<AppMemberInfo>))
        {
            this.AppMemberInfoList = appMemberInfoList;
        }

        /// <summary>
        /// 小程序成员模型
        /// </summary>
        /// <value>小程序成员模型</value>
        [DataMember(Name = "app_member_info_list", EmitDefaultValue = false)]
        public List<AppMemberInfo> AppMemberInfoList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenAppMembersQueryResponseModel {\n");
            sb.Append("  AppMemberInfoList: ").Append(AppMemberInfoList).Append("\n");
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
            return this.Equals(input as AlipayOpenAppMembersQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenAppMembersQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenAppMembersQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenAppMembersQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AppMemberInfoList == input.AppMemberInfoList ||
                    this.AppMemberInfoList != null &&
                    input.AppMemberInfoList != null &&
                    this.AppMemberInfoList.SequenceEqual(input.AppMemberInfoList)
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
                if (this.AppMemberInfoList != null)
                {
                    hashCode = (hashCode * 59) + this.AppMemberInfoList.GetHashCode();
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
