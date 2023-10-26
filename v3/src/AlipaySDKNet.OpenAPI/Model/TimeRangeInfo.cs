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
    /// TimeRangeInfo
    /// </summary>
    [DataContract(Name = "TimeRangeInfo")]
    public partial class TimeRangeInfo : IEquatable<TimeRangeInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeRangeInfo" /> class.
        /// </summary>
        /// <param name="beginTime">开始时间  格式：HH:mm:ss.</param>
        /// <param name="endTimeInfo">endTimeInfo.</param>
        public TimeRangeInfo(string beginTime = default(string), EndTimeInfo endTimeInfo = default(EndTimeInfo))
        {
            this.BeginTime = beginTime;
            this.EndTimeInfo = endTimeInfo;
        }

        /// <summary>
        /// 开始时间  格式：HH:mm:ss
        /// </summary>
        /// <value>开始时间  格式：HH:mm:ss</value>
        [DataMember(Name = "begin_time", EmitDefaultValue = false)]
        public string BeginTime { get; set; }

        /// <summary>
        /// Gets or Sets EndTimeInfo
        /// </summary>
        [DataMember(Name = "end_time_info", EmitDefaultValue = false)]
        public EndTimeInfo EndTimeInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TimeRangeInfo {\n");
            sb.Append("  BeginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  EndTimeInfo: ").Append(EndTimeInfo).Append("\n");
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
            return this.Equals(input as TimeRangeInfo);
        }

        /// <summary>
        /// Returns true if TimeRangeInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of TimeRangeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeRangeInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BeginTime == input.BeginTime ||
                    (this.BeginTime != null &&
                    this.BeginTime.Equals(input.BeginTime))
                ) && 
                (
                    this.EndTimeInfo == input.EndTimeInfo ||
                    (this.EndTimeInfo != null &&
                    this.EndTimeInfo.Equals(input.EndTimeInfo))
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
                if (this.BeginTime != null)
                {
                    hashCode = (hashCode * 59) + this.BeginTime.GetHashCode();
                }
                if (this.EndTimeInfo != null)
                {
                    hashCode = (hashCode * 59) + this.EndTimeInfo.GetHashCode();
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
