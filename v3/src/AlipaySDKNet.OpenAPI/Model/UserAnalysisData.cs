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
    /// UserAnalysisData
    /// </summary>
    [DataContract(Name = "UserAnalysisData")]
    public partial class UserAnalysisData : IEquatable<UserAnalysisData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserAnalysisData" /> class.
        /// </summary>
        /// <param name="cancelUserCnt">取消关注人数.</param>
        /// <param name="cumulateUserCnt">累积关注人数.</param>
        /// <param name="date">日期.</param>
        /// <param name="growUserCnt">净增关注人数.</param>
        /// <param name="newUserCnt">新关注人数.</param>
        public UserAnalysisData(string cancelUserCnt = default(string), string cumulateUserCnt = default(string), string date = default(string), string growUserCnt = default(string), string newUserCnt = default(string))
        {
            this.CancelUserCnt = cancelUserCnt;
            this.CumulateUserCnt = cumulateUserCnt;
            this.Date = date;
            this.GrowUserCnt = growUserCnt;
            this.NewUserCnt = newUserCnt;
        }

        /// <summary>
        /// 取消关注人数
        /// </summary>
        /// <value>取消关注人数</value>
        [DataMember(Name = "cancel_user_cnt", EmitDefaultValue = false)]
        public string CancelUserCnt { get; set; }

        /// <summary>
        /// 累积关注人数
        /// </summary>
        /// <value>累积关注人数</value>
        [DataMember(Name = "cumulate_user_cnt", EmitDefaultValue = false)]
        public string CumulateUserCnt { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        /// <value>日期</value>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public string Date { get; set; }

        /// <summary>
        /// 净增关注人数
        /// </summary>
        /// <value>净增关注人数</value>
        [DataMember(Name = "grow_user_cnt", EmitDefaultValue = false)]
        public string GrowUserCnt { get; set; }

        /// <summary>
        /// 新关注人数
        /// </summary>
        /// <value>新关注人数</value>
        [DataMember(Name = "new_user_cnt", EmitDefaultValue = false)]
        public string NewUserCnt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserAnalysisData {\n");
            sb.Append("  CancelUserCnt: ").Append(CancelUserCnt).Append("\n");
            sb.Append("  CumulateUserCnt: ").Append(CumulateUserCnt).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  GrowUserCnt: ").Append(GrowUserCnt).Append("\n");
            sb.Append("  NewUserCnt: ").Append(NewUserCnt).Append("\n");
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
            return this.Equals(input as UserAnalysisData);
        }

        /// <summary>
        /// Returns true if UserAnalysisData instances are equal
        /// </summary>
        /// <param name="input">Instance of UserAnalysisData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserAnalysisData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CancelUserCnt == input.CancelUserCnt ||
                    (this.CancelUserCnt != null &&
                    this.CancelUserCnt.Equals(input.CancelUserCnt))
                ) && 
                (
                    this.CumulateUserCnt == input.CumulateUserCnt ||
                    (this.CumulateUserCnt != null &&
                    this.CumulateUserCnt.Equals(input.CumulateUserCnt))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.GrowUserCnt == input.GrowUserCnt ||
                    (this.GrowUserCnt != null &&
                    this.GrowUserCnt.Equals(input.GrowUserCnt))
                ) && 
                (
                    this.NewUserCnt == input.NewUserCnt ||
                    (this.NewUserCnt != null &&
                    this.NewUserCnt.Equals(input.NewUserCnt))
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
                if (this.CancelUserCnt != null)
                {
                    hashCode = (hashCode * 59) + this.CancelUserCnt.GetHashCode();
                }
                if (this.CumulateUserCnt != null)
                {
                    hashCode = (hashCode * 59) + this.CumulateUserCnt.GetHashCode();
                }
                if (this.Date != null)
                {
                    hashCode = (hashCode * 59) + this.Date.GetHashCode();
                }
                if (this.GrowUserCnt != null)
                {
                    hashCode = (hashCode * 59) + this.GrowUserCnt.GetHashCode();
                }
                if (this.NewUserCnt != null)
                {
                    hashCode = (hashCode * 59) + this.NewUserCnt.GetHashCode();
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
