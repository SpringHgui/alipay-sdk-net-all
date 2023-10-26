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
    /// UseTime
    /// </summary>
    [DataContract(Name = "UseTime")]
    public partial class UseTime : IEquatable<UseTime>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UseTime" /> class.
        /// </summary>
        /// <param name="dimension">券可用时段时间维度，目前支持周(W).</param>
        /// <param name="times">券可用时间段  可用时间段起止时间用逗号分隔，多个时间段之间用^分隔  如, \&quot;16:00:00,20:00:00^21:00:00,22:00:00\&quot;表示16点至20点，21点至22点可用  时间段不可重叠.</param>
        /// <param name="values">券可用时间维度值  周维度的取值范围1-7(周一至周日)，多个可用时段用逗号分隔  如\&quot;1,3,5\&quot;，对应周一，周三，周五可用.</param>
        public UseTime(string dimension = default(string), string times = default(string), string values = default(string))
        {
            this.Dimension = dimension;
            this.Times = times;
            this.Values = values;
        }

        /// <summary>
        /// 券可用时段时间维度，目前支持周(W)
        /// </summary>
        /// <value>券可用时段时间维度，目前支持周(W)</value>
        [DataMember(Name = "dimension", EmitDefaultValue = false)]
        public string Dimension { get; set; }

        /// <summary>
        /// 券可用时间段  可用时间段起止时间用逗号分隔，多个时间段之间用^分隔  如, \&quot;16:00:00,20:00:00^21:00:00,22:00:00\&quot;表示16点至20点，21点至22点可用  时间段不可重叠
        /// </summary>
        /// <value>券可用时间段  可用时间段起止时间用逗号分隔，多个时间段之间用^分隔  如, \&quot;16:00:00,20:00:00^21:00:00,22:00:00\&quot;表示16点至20点，21点至22点可用  时间段不可重叠</value>
        [DataMember(Name = "times", EmitDefaultValue = false)]
        public string Times { get; set; }

        /// <summary>
        /// 券可用时间维度值  周维度的取值范围1-7(周一至周日)，多个可用时段用逗号分隔  如\&quot;1,3,5\&quot;，对应周一，周三，周五可用
        /// </summary>
        /// <value>券可用时间维度值  周维度的取值范围1-7(周一至周日)，多个可用时段用逗号分隔  如\&quot;1,3,5\&quot;，对应周一，周三，周五可用</value>
        [DataMember(Name = "values", EmitDefaultValue = false)]
        public string Values { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UseTime {\n");
            sb.Append("  Dimension: ").Append(Dimension).Append("\n");
            sb.Append("  Times: ").Append(Times).Append("\n");
            sb.Append("  Values: ").Append(Values).Append("\n");
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
            return this.Equals(input as UseTime);
        }

        /// <summary>
        /// Returns true if UseTime instances are equal
        /// </summary>
        /// <param name="input">Instance of UseTime to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UseTime input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Dimension == input.Dimension ||
                    (this.Dimension != null &&
                    this.Dimension.Equals(input.Dimension))
                ) && 
                (
                    this.Times == input.Times ||
                    (this.Times != null &&
                    this.Times.Equals(input.Times))
                ) && 
                (
                    this.Values == input.Values ||
                    (this.Values != null &&
                    this.Values.Equals(input.Values))
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
                if (this.Dimension != null)
                {
                    hashCode = (hashCode * 59) + this.Dimension.GetHashCode();
                }
                if (this.Times != null)
                {
                    hashCode = (hashCode * 59) + this.Times.GetHashCode();
                }
                if (this.Values != null)
                {
                    hashCode = (hashCode * 59) + this.Values.GetHashCode();
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
