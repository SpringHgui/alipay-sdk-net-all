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
    /// DateRangeInfo
    /// </summary>
    [DataContract(Name = "DateRangeInfo")]
    public partial class DateRangeInfo : IEquatable<DateRangeInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DateRangeInfo" /> class.
        /// </summary>
        /// <param name="beginDate">开始日期  格式：yyyy-MM-dd.</param>
        /// <param name="endDate">结束日期  格式：yyyy-MM-dd.</param>
        public DateRangeInfo(string beginDate = default(string), string endDate = default(string))
        {
            this.BeginDate = beginDate;
            this.EndDate = endDate;
        }

        /// <summary>
        /// 开始日期  格式：yyyy-MM-dd
        /// </summary>
        /// <value>开始日期  格式：yyyy-MM-dd</value>
        [DataMember(Name = "begin_date", EmitDefaultValue = false)]
        public string BeginDate { get; set; }

        /// <summary>
        /// 结束日期  格式：yyyy-MM-dd
        /// </summary>
        /// <value>结束日期  格式：yyyy-MM-dd</value>
        [DataMember(Name = "end_date", EmitDefaultValue = false)]
        public string EndDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DateRangeInfo {\n");
            sb.Append("  BeginDate: ").Append(BeginDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
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
            return this.Equals(input as DateRangeInfo);
        }

        /// <summary>
        /// Returns true if DateRangeInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of DateRangeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DateRangeInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BeginDate == input.BeginDate ||
                    (this.BeginDate != null &&
                    this.BeginDate.Equals(input.BeginDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
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
                if (this.BeginDate != null)
                {
                    hashCode = (hashCode * 59) + this.BeginDate.GetHashCode();
                }
                if (this.EndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndDate.GetHashCode();
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
