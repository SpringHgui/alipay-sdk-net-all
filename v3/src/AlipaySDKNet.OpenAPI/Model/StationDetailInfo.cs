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
    /// StationDetailInfo
    /// </summary>
    [DataContract(Name = "StationDetailInfo")]
    public partial class StationDetailInfo : IEquatable<StationDetailInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StationDetailInfo" /> class.
        /// </summary>
        /// <param name="code">站点编码.</param>
        /// <param name="extCode">站点外部编码.</param>
        /// <param name="name">站点中文名称.</param>
        public StationDetailInfo(string code = default(string), string extCode = default(string), string name = default(string))
        {
            this.Code = code;
            this.ExtCode = extCode;
            this.Name = name;
        }

        /// <summary>
        /// 站点编码
        /// </summary>
        /// <value>站点编码</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// 站点外部编码
        /// </summary>
        /// <value>站点外部编码</value>
        [DataMember(Name = "ext_code", EmitDefaultValue = false)]
        public string ExtCode { get; set; }

        /// <summary>
        /// 站点中文名称
        /// </summary>
        /// <value>站点中文名称</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StationDetailInfo {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  ExtCode: ").Append(ExtCode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as StationDetailInfo);
        }

        /// <summary>
        /// Returns true if StationDetailInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of StationDetailInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StationDetailInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.ExtCode == input.ExtCode ||
                    (this.ExtCode != null &&
                    this.ExtCode.Equals(input.ExtCode))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.ExtCode != null)
                {
                    hashCode = (hashCode * 59) + this.ExtCode.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
