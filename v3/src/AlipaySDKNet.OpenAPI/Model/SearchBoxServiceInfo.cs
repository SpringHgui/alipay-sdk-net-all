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
    /// SearchBoxServiceInfo
    /// </summary>
    [DataContract(Name = "SearchBoxServiceInfo")]
    public partial class SearchBoxServiceInfo : IEquatable<SearchBoxServiceInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchBoxServiceInfo" /> class.
        /// </summary>
        /// <param name="serviceCategoryCode">服务类目编码.</param>
        /// <param name="serviceCategoryName">服务类目名称.</param>
        /// <param name="serviceCode">服务编码.</param>
        /// <param name="serviceName">服务名称.</param>
        public SearchBoxServiceInfo(string serviceCategoryCode = default(string), string serviceCategoryName = default(string), string serviceCode = default(string), string serviceName = default(string))
        {
            this.ServiceCategoryCode = serviceCategoryCode;
            this.ServiceCategoryName = serviceCategoryName;
            this.ServiceCode = serviceCode;
            this.ServiceName = serviceName;
        }

        /// <summary>
        /// 服务类目编码
        /// </summary>
        /// <value>服务类目编码</value>
        [DataMember(Name = "service_category_code", EmitDefaultValue = false)]
        public string ServiceCategoryCode { get; set; }

        /// <summary>
        /// 服务类目名称
        /// </summary>
        /// <value>服务类目名称</value>
        [DataMember(Name = "service_category_name", EmitDefaultValue = false)]
        public string ServiceCategoryName { get; set; }

        /// <summary>
        /// 服务编码
        /// </summary>
        /// <value>服务编码</value>
        [DataMember(Name = "service_code", EmitDefaultValue = false)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        /// <value>服务名称</value>
        [DataMember(Name = "service_name", EmitDefaultValue = false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchBoxServiceInfo {\n");
            sb.Append("  ServiceCategoryCode: ").Append(ServiceCategoryCode).Append("\n");
            sb.Append("  ServiceCategoryName: ").Append(ServiceCategoryName).Append("\n");
            sb.Append("  ServiceCode: ").Append(ServiceCode).Append("\n");
            sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
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
            return this.Equals(input as SearchBoxServiceInfo);
        }

        /// <summary>
        /// Returns true if SearchBoxServiceInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchBoxServiceInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchBoxServiceInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ServiceCategoryCode == input.ServiceCategoryCode ||
                    (this.ServiceCategoryCode != null &&
                    this.ServiceCategoryCode.Equals(input.ServiceCategoryCode))
                ) && 
                (
                    this.ServiceCategoryName == input.ServiceCategoryName ||
                    (this.ServiceCategoryName != null &&
                    this.ServiceCategoryName.Equals(input.ServiceCategoryName))
                ) && 
                (
                    this.ServiceCode == input.ServiceCode ||
                    (this.ServiceCode != null &&
                    this.ServiceCode.Equals(input.ServiceCode))
                ) && 
                (
                    this.ServiceName == input.ServiceName ||
                    (this.ServiceName != null &&
                    this.ServiceName.Equals(input.ServiceName))
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
                if (this.ServiceCategoryCode != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceCategoryCode.GetHashCode();
                }
                if (this.ServiceCategoryName != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceCategoryName.GetHashCode();
                }
                if (this.ServiceCode != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceCode.GetHashCode();
                }
                if (this.ServiceName != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceName.GetHashCode();
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
