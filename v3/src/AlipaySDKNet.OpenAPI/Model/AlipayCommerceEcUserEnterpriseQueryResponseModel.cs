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
    /// AlipayCommerceEcUserEnterpriseQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayCommerceEcUserEnterpriseQueryResponseModel")]
    public partial class AlipayCommerceEcUserEnterpriseQueryResponseModel : IEquatable<AlipayCommerceEcUserEnterpriseQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceEcUserEnterpriseQueryResponseModel" /> class.
        /// </summary>
        /// <param name="enterpriseInfoList">用户所属企业列表.</param>
        public AlipayCommerceEcUserEnterpriseQueryResponseModel(List<EnterpriseInfoDTO> enterpriseInfoList = default(List<EnterpriseInfoDTO>))
        {
            this.EnterpriseInfoList = enterpriseInfoList;
        }

        /// <summary>
        /// 用户所属企业列表
        /// </summary>
        /// <value>用户所属企业列表</value>
        [DataMember(Name = "enterprise_info_list", EmitDefaultValue = false)]
        public List<EnterpriseInfoDTO> EnterpriseInfoList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayCommerceEcUserEnterpriseQueryResponseModel {\n");
            sb.Append("  EnterpriseInfoList: ").Append(EnterpriseInfoList).Append("\n");
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
            return this.Equals(input as AlipayCommerceEcUserEnterpriseQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayCommerceEcUserEnterpriseQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayCommerceEcUserEnterpriseQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayCommerceEcUserEnterpriseQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EnterpriseInfoList == input.EnterpriseInfoList ||
                    this.EnterpriseInfoList != null &&
                    input.EnterpriseInfoList != null &&
                    this.EnterpriseInfoList.SequenceEqual(input.EnterpriseInfoList)
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
                if (this.EnterpriseInfoList != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseInfoList.GetHashCode();
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
