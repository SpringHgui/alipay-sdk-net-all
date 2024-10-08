/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2024-10-08
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
    /// HSchoolInfo
    /// </summary>
    [DataContract(Name = "HSchoolInfo")]
    public partial class HSchoolInfo : IEquatable<HSchoolInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HSchoolInfo" /> class.
        /// </summary>
        /// <param name="campusNo">学号.</param>
        /// <param name="schoolStdCode">学校外标.</param>
        public HSchoolInfo(string campusNo = default(string), string schoolStdCode = default(string))
        {
            this.CampusNo = campusNo;
            this.SchoolStdCode = schoolStdCode;
        }

        /// <summary>
        /// 学号
        /// </summary>
        /// <value>学号</value>
        [DataMember(Name = "campus_no", EmitDefaultValue = false)]
        public string CampusNo { get; set; }

        /// <summary>
        /// 学校外标
        /// </summary>
        /// <value>学校外标</value>
        [DataMember(Name = "school_std_code", EmitDefaultValue = false)]
        public string SchoolStdCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HSchoolInfo {\n");
            sb.Append("  CampusNo: ").Append(CampusNo).Append("\n");
            sb.Append("  SchoolStdCode: ").Append(SchoolStdCode).Append("\n");
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
            return this.Equals(input as HSchoolInfo);
        }

        /// <summary>
        /// Returns true if HSchoolInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of HSchoolInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HSchoolInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CampusNo == input.CampusNo ||
                    (this.CampusNo != null &&
                    this.CampusNo.Equals(input.CampusNo))
                ) && 
                (
                    this.SchoolStdCode == input.SchoolStdCode ||
                    (this.SchoolStdCode != null &&
                    this.SchoolStdCode.Equals(input.SchoolStdCode))
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
                if (this.CampusNo != null)
                {
                    hashCode = (hashCode * 59) + this.CampusNo.GetHashCode();
                }
                if (this.SchoolStdCode != null)
                {
                    hashCode = (hashCode * 59) + this.SchoolStdCode.GetHashCode();
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
