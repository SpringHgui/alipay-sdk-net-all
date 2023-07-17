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
    /// FaceExtInfo
    /// </summary>
    [DataContract(Name = "FaceExtInfo")]
    public partial class FaceExtInfo : IEquatable<FaceExtInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FaceExtInfo" /> class.
        /// </summary>
        /// <param name="maxAge">年龄区间判断的上限，闭区间.</param>
        /// <param name="minAge">年龄区间判断的下限，闭区间.</param>
        /// <param name="queryType">query_type不填, 返回uid  query_type&#x3D;1, 返回手机号  query_type&#x3D;2, 返回图片.</param>
        public FaceExtInfo(string maxAge = default(string), string minAge = default(string), string queryType = default(string))
        {
            this.MaxAge = maxAge;
            this.MinAge = minAge;
            this.QueryType = queryType;
        }

        /// <summary>
        /// 年龄区间判断的上限，闭区间
        /// </summary>
        /// <value>年龄区间判断的上限，闭区间</value>
        [DataMember(Name = "max_age", EmitDefaultValue = false)]
        public string MaxAge { get; set; }

        /// <summary>
        /// 年龄区间判断的下限，闭区间
        /// </summary>
        /// <value>年龄区间判断的下限，闭区间</value>
        [DataMember(Name = "min_age", EmitDefaultValue = false)]
        public string MinAge { get; set; }

        /// <summary>
        /// query_type不填, 返回uid  query_type&#x3D;1, 返回手机号  query_type&#x3D;2, 返回图片
        /// </summary>
        /// <value>query_type不填, 返回uid  query_type&#x3D;1, 返回手机号  query_type&#x3D;2, 返回图片</value>
        [DataMember(Name = "query_type", EmitDefaultValue = false)]
        public string QueryType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FaceExtInfo {\n");
            sb.Append("  MaxAge: ").Append(MaxAge).Append("\n");
            sb.Append("  MinAge: ").Append(MinAge).Append("\n");
            sb.Append("  QueryType: ").Append(QueryType).Append("\n");
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
            return this.Equals(input as FaceExtInfo);
        }

        /// <summary>
        /// Returns true if FaceExtInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of FaceExtInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FaceExtInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MaxAge == input.MaxAge ||
                    (this.MaxAge != null &&
                    this.MaxAge.Equals(input.MaxAge))
                ) && 
                (
                    this.MinAge == input.MinAge ||
                    (this.MinAge != null &&
                    this.MinAge.Equals(input.MinAge))
                ) && 
                (
                    this.QueryType == input.QueryType ||
                    (this.QueryType != null &&
                    this.QueryType.Equals(input.QueryType))
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
                if (this.MaxAge != null)
                {
                    hashCode = (hashCode * 59) + this.MaxAge.GetHashCode();
                }
                if (this.MinAge != null)
                {
                    hashCode = (hashCode * 59) + this.MinAge.GetHashCode();
                }
                if (this.QueryType != null)
                {
                    hashCode = (hashCode * 59) + this.QueryType.GetHashCode();
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
