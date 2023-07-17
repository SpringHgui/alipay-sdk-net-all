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
    /// AlipayOpenMiniTemplateUsageQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniTemplateUsageQueryResponseModel")]
    public partial class AlipayOpenMiniTemplateUsageQueryResponseModel : IEquatable<AlipayOpenMiniTemplateUsageQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniTemplateUsageQueryResponseModel" /> class.
        /// </summary>
        /// <param name="appIds">小程序appId列表.</param>
        /// <param name="templateUsageInfoList">模板使用信息.</param>
        public AlipayOpenMiniTemplateUsageQueryResponseModel(List<string> appIds = default(List<string>), List<TemplateUsageInfo> templateUsageInfoList = default(List<TemplateUsageInfo>))
        {
            this.AppIds = appIds;
            this.TemplateUsageInfoList = templateUsageInfoList;
        }

        /// <summary>
        /// 小程序appId列表
        /// </summary>
        /// <value>小程序appId列表</value>
        [DataMember(Name = "app_ids", EmitDefaultValue = false)]
        public List<string> AppIds { get; set; }

        /// <summary>
        /// 模板使用信息
        /// </summary>
        /// <value>模板使用信息</value>
        [DataMember(Name = "template_usage_info_list", EmitDefaultValue = false)]
        public List<TemplateUsageInfo> TemplateUsageInfoList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniTemplateUsageQueryResponseModel {\n");
            sb.Append("  AppIds: ").Append(AppIds).Append("\n");
            sb.Append("  TemplateUsageInfoList: ").Append(TemplateUsageInfoList).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniTemplateUsageQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniTemplateUsageQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniTemplateUsageQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniTemplateUsageQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AppIds == input.AppIds ||
                    this.AppIds != null &&
                    input.AppIds != null &&
                    this.AppIds.SequenceEqual(input.AppIds)
                ) && 
                (
                    this.TemplateUsageInfoList == input.TemplateUsageInfoList ||
                    this.TemplateUsageInfoList != null &&
                    input.TemplateUsageInfoList != null &&
                    this.TemplateUsageInfoList.SequenceEqual(input.TemplateUsageInfoList)
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
                if (this.AppIds != null)
                {
                    hashCode = (hashCode * 59) + this.AppIds.GetHashCode();
                }
                if (this.TemplateUsageInfoList != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateUsageInfoList.GetHashCode();
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
