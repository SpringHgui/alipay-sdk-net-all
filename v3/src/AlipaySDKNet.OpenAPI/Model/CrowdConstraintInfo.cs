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
    /// CrowdConstraintInfo
    /// </summary>
    [DataContract(Name = "CrowdConstraintInfo")]
    public partial class CrowdConstraintInfo : IEquatable<CrowdConstraintInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CrowdConstraintInfo" /> class.
        /// </summary>
        /// <param name="crowdCondition">圈人的条件  op:表示操作符，目前支持EQ相等,GT大于,GTEQ大于等于,LT小于,LTEQ小于等于,NEQ不等,LIKE模糊匹配,IN在枚举范围内,NOTIN不在枚举范围内,BETWEEN范围比较,LEFTDAYS几天以内,RIGHTDAYS几天以外,LOCATE地理位置比较,LBS地图位置数据  tagCode:标签code，详细标签code参见附件。&lt;a href&#x3D;\&quot;http://aopsdkdownload.cn-hangzhou.alipay-pub.aliyun-inc.com/doc/tags%26usecase.zip\&quot;&gt;标签信息&lt;/a&gt;  value:标签值.</param>
        /// <param name="crowdName">圈人名称.</param>
        /// <param name="crowdRestriction">圈人约束，取值（NEWCOMER：新客人群；OFFLINE：离线人群），OFFLINE离线人群，需要传递crowd_condition圈人条件，使用方案参考crowd_condition使用说明.</param>
        public CrowdConstraintInfo(string crowdCondition = default(string), string crowdName = default(string), string crowdRestriction = default(string))
        {
            this.CrowdCondition = crowdCondition;
            this.CrowdName = crowdName;
            this.CrowdRestriction = crowdRestriction;
        }

        /// <summary>
        /// 圈人的条件  op:表示操作符，目前支持EQ相等,GT大于,GTEQ大于等于,LT小于,LTEQ小于等于,NEQ不等,LIKE模糊匹配,IN在枚举范围内,NOTIN不在枚举范围内,BETWEEN范围比较,LEFTDAYS几天以内,RIGHTDAYS几天以外,LOCATE地理位置比较,LBS地图位置数据  tagCode:标签code，详细标签code参见附件。&lt;a href&#x3D;\&quot;http://aopsdkdownload.cn-hangzhou.alipay-pub.aliyun-inc.com/doc/tags%26usecase.zip\&quot;&gt;标签信息&lt;/a&gt;  value:标签值
        /// </summary>
        /// <value>圈人的条件  op:表示操作符，目前支持EQ相等,GT大于,GTEQ大于等于,LT小于,LTEQ小于等于,NEQ不等,LIKE模糊匹配,IN在枚举范围内,NOTIN不在枚举范围内,BETWEEN范围比较,LEFTDAYS几天以内,RIGHTDAYS几天以外,LOCATE地理位置比较,LBS地图位置数据  tagCode:标签code，详细标签code参见附件。&lt;a href&#x3D;\&quot;http://aopsdkdownload.cn-hangzhou.alipay-pub.aliyun-inc.com/doc/tags%26usecase.zip\&quot;&gt;标签信息&lt;/a&gt;  value:标签值</value>
        [DataMember(Name = "crowd_condition", EmitDefaultValue = false)]
        public string CrowdCondition { get; set; }

        /// <summary>
        /// 圈人名称
        /// </summary>
        /// <value>圈人名称</value>
        [DataMember(Name = "crowd_name", EmitDefaultValue = false)]
        public string CrowdName { get; set; }

        /// <summary>
        /// 圈人约束，取值（NEWCOMER：新客人群；OFFLINE：离线人群），OFFLINE离线人群，需要传递crowd_condition圈人条件，使用方案参考crowd_condition使用说明
        /// </summary>
        /// <value>圈人约束，取值（NEWCOMER：新客人群；OFFLINE：离线人群），OFFLINE离线人群，需要传递crowd_condition圈人条件，使用方案参考crowd_condition使用说明</value>
        [DataMember(Name = "crowd_restriction", EmitDefaultValue = false)]
        public string CrowdRestriction { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CrowdConstraintInfo {\n");
            sb.Append("  CrowdCondition: ").Append(CrowdCondition).Append("\n");
            sb.Append("  CrowdName: ").Append(CrowdName).Append("\n");
            sb.Append("  CrowdRestriction: ").Append(CrowdRestriction).Append("\n");
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
            return this.Equals(input as CrowdConstraintInfo);
        }

        /// <summary>
        /// Returns true if CrowdConstraintInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of CrowdConstraintInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CrowdConstraintInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CrowdCondition == input.CrowdCondition ||
                    (this.CrowdCondition != null &&
                    this.CrowdCondition.Equals(input.CrowdCondition))
                ) && 
                (
                    this.CrowdName == input.CrowdName ||
                    (this.CrowdName != null &&
                    this.CrowdName.Equals(input.CrowdName))
                ) && 
                (
                    this.CrowdRestriction == input.CrowdRestriction ||
                    (this.CrowdRestriction != null &&
                    this.CrowdRestriction.Equals(input.CrowdRestriction))
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
                if (this.CrowdCondition != null)
                {
                    hashCode = (hashCode * 59) + this.CrowdCondition.GetHashCode();
                }
                if (this.CrowdName != null)
                {
                    hashCode = (hashCode * 59) + this.CrowdName.GetHashCode();
                }
                if (this.CrowdRestriction != null)
                {
                    hashCode = (hashCode * 59) + this.CrowdRestriction.GetHashCode();
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
