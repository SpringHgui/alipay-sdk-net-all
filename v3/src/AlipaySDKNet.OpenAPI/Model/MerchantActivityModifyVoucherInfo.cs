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
    /// MerchantActivityModifyVoucherInfo
    /// </summary>
    [DataContract(Name = "MerchantActivityModifyVoucherInfo")]
    public partial class MerchantActivityModifyVoucherInfo : IEquatable<MerchantActivityModifyVoucherInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantActivityModifyVoucherInfo" /> class.
        /// </summary>
        /// <param name="logo">券logo  券logo最大字符数不能超过64.</param>
        /// <param name="userIntroductions">使用须知  券使用须知最大字符数不能超过256.</param>
        /// <param name="validDaysRangeTo">领取后, 第几天失效  valid_time_type&#x3D;RELATIVE时有效且必填  只允许增加领取后可用天数.</param>
        /// <param name="validTimeRangeTo">有效期截止时间  valid_time_type&#x3D;FIXED时有效且必填  券有效结束时间格式必须为yyyy-MM-dd HH:mm:ss  只允许延长固定时间的结束时间（支持到分）.</param>
        /// <param name="validTimeType">有效期类型：  枚举值：RELATIVE/FIXED.</param>
        public MerchantActivityModifyVoucherInfo(string logo = default(string), string userIntroductions = default(string), int validDaysRangeTo = default(int), string validTimeRangeTo = default(string), string validTimeType = default(string))
        {
            this.Logo = logo;
            this.UserIntroductions = userIntroductions;
            this.ValidDaysRangeTo = validDaysRangeTo;
            this.ValidTimeRangeTo = validTimeRangeTo;
            this.ValidTimeType = validTimeType;
        }

        /// <summary>
        /// 券logo  券logo最大字符数不能超过64
        /// </summary>
        /// <value>券logo  券logo最大字符数不能超过64</value>
        [DataMember(Name = "logo", EmitDefaultValue = false)]
        public string Logo { get; set; }

        /// <summary>
        /// 使用须知  券使用须知最大字符数不能超过256
        /// </summary>
        /// <value>使用须知  券使用须知最大字符数不能超过256</value>
        [DataMember(Name = "user_introductions", EmitDefaultValue = false)]
        public string UserIntroductions { get; set; }

        /// <summary>
        /// 领取后, 第几天失效  valid_time_type&#x3D;RELATIVE时有效且必填  只允许增加领取后可用天数
        /// </summary>
        /// <value>领取后, 第几天失效  valid_time_type&#x3D;RELATIVE时有效且必填  只允许增加领取后可用天数</value>
        [DataMember(Name = "valid_days_range_to", EmitDefaultValue = false)]
        public int ValidDaysRangeTo { get; set; }

        /// <summary>
        /// 有效期截止时间  valid_time_type&#x3D;FIXED时有效且必填  券有效结束时间格式必须为yyyy-MM-dd HH:mm:ss  只允许延长固定时间的结束时间（支持到分）
        /// </summary>
        /// <value>有效期截止时间  valid_time_type&#x3D;FIXED时有效且必填  券有效结束时间格式必须为yyyy-MM-dd HH:mm:ss  只允许延长固定时间的结束时间（支持到分）</value>
        [DataMember(Name = "valid_time_range_to", EmitDefaultValue = false)]
        public string ValidTimeRangeTo { get; set; }

        /// <summary>
        /// 有效期类型：  枚举值：RELATIVE/FIXED
        /// </summary>
        /// <value>有效期类型：  枚举值：RELATIVE/FIXED</value>
        [DataMember(Name = "valid_time_type", EmitDefaultValue = false)]
        public string ValidTimeType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MerchantActivityModifyVoucherInfo {\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  UserIntroductions: ").Append(UserIntroductions).Append("\n");
            sb.Append("  ValidDaysRangeTo: ").Append(ValidDaysRangeTo).Append("\n");
            sb.Append("  ValidTimeRangeTo: ").Append(ValidTimeRangeTo).Append("\n");
            sb.Append("  ValidTimeType: ").Append(ValidTimeType).Append("\n");
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
            return this.Equals(input as MerchantActivityModifyVoucherInfo);
        }

        /// <summary>
        /// Returns true if MerchantActivityModifyVoucherInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantActivityModifyVoucherInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantActivityModifyVoucherInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Logo == input.Logo ||
                    (this.Logo != null &&
                    this.Logo.Equals(input.Logo))
                ) && 
                (
                    this.UserIntroductions == input.UserIntroductions ||
                    (this.UserIntroductions != null &&
                    this.UserIntroductions.Equals(input.UserIntroductions))
                ) && 
                (
                    this.ValidDaysRangeTo == input.ValidDaysRangeTo ||
                    this.ValidDaysRangeTo.Equals(input.ValidDaysRangeTo)
                ) && 
                (
                    this.ValidTimeRangeTo == input.ValidTimeRangeTo ||
                    (this.ValidTimeRangeTo != null &&
                    this.ValidTimeRangeTo.Equals(input.ValidTimeRangeTo))
                ) && 
                (
                    this.ValidTimeType == input.ValidTimeType ||
                    (this.ValidTimeType != null &&
                    this.ValidTimeType.Equals(input.ValidTimeType))
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
                if (this.Logo != null)
                {
                    hashCode = (hashCode * 59) + this.Logo.GetHashCode();
                }
                if (this.UserIntroductions != null)
                {
                    hashCode = (hashCode * 59) + this.UserIntroductions.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ValidDaysRangeTo.GetHashCode();
                if (this.ValidTimeRangeTo != null)
                {
                    hashCode = (hashCode * 59) + this.ValidTimeRangeTo.GetHashCode();
                }
                if (this.ValidTimeType != null)
                {
                    hashCode = (hashCode * 59) + this.ValidTimeType.GetHashCode();
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
