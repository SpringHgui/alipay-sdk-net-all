/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2025-02-06
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
    /// AlipayFundAgreementQuotaModifyResponseModel
    /// </summary>
    [DataContract(Name = "AlipayFundAgreementQuotaModifyResponseModel")]
    public partial class AlipayFundAgreementQuotaModifyResponseModel : IEquatable<AlipayFundAgreementQuotaModifyResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundAgreementQuotaModifyResponseModel" /> class.
        /// </summary>
        /// <param name="quotaModifyDetailList">额度变更结果集合.</param>
        public AlipayFundAgreementQuotaModifyResponseModel(List<QuotaModifyDetail> quotaModifyDetailList = default(List<QuotaModifyDetail>))
        {
            this.QuotaModifyDetailList = quotaModifyDetailList;
        }

        /// <summary>
        /// 额度变更结果集合
        /// </summary>
        /// <value>额度变更结果集合</value>
        [DataMember(Name = "quota_modify_detail_list", EmitDefaultValue = false)]
        public List<QuotaModifyDetail> QuotaModifyDetailList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayFundAgreementQuotaModifyResponseModel {\n");
            sb.Append("  QuotaModifyDetailList: ").Append(QuotaModifyDetailList).Append("\n");
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
            return this.Equals(input as AlipayFundAgreementQuotaModifyResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayFundAgreementQuotaModifyResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayFundAgreementQuotaModifyResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayFundAgreementQuotaModifyResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.QuotaModifyDetailList == input.QuotaModifyDetailList ||
                    this.QuotaModifyDetailList != null &&
                    input.QuotaModifyDetailList != null &&
                    this.QuotaModifyDetailList.SequenceEqual(input.QuotaModifyDetailList)
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
                if (this.QuotaModifyDetailList != null)
                {
                    hashCode = (hashCode * 59) + this.QuotaModifyDetailList.GetHashCode();
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
