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
    /// AlipayCommerceEducateCampusInstitutionsAddResponseModel
    /// </summary>
    [DataContract(Name = "AlipayCommerceEducateCampusInstitutionsAddResponseModel")]
    public partial class AlipayCommerceEducateCampusInstitutionsAddResponseModel : IEquatable<AlipayCommerceEducateCampusInstitutionsAddResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceEducateCampusInstitutionsAddResponseModel" /> class.
        /// </summary>
        /// <param name="instId">学校内标。如果入驻成功，返回学校内标；入驻失败则不返回学校内标。.</param>
        /// <param name="instStdCode">学校外标。如果入驻成功，返回学校外标；入驻失败则不返回学校外标。.</param>
        /// <param name="reason">入驻失败原因.</param>
        public AlipayCommerceEducateCampusInstitutionsAddResponseModel(string instId = default(string), string instStdCode = default(string), string reason = default(string))
        {
            this.InstId = instId;
            this.InstStdCode = instStdCode;
            this.Reason = reason;
        }

        /// <summary>
        /// 学校内标。如果入驻成功，返回学校内标；入驻失败则不返回学校内标。
        /// </summary>
        /// <value>学校内标。如果入驻成功，返回学校内标；入驻失败则不返回学校内标。</value>
        [DataMember(Name = "inst_id", EmitDefaultValue = false)]
        public string InstId { get; set; }

        /// <summary>
        /// 学校外标。如果入驻成功，返回学校外标；入驻失败则不返回学校外标。
        /// </summary>
        /// <value>学校外标。如果入驻成功，返回学校外标；入驻失败则不返回学校外标。</value>
        [DataMember(Name = "inst_std_code", EmitDefaultValue = false)]
        public string InstStdCode { get; set; }

        /// <summary>
        /// 入驻失败原因
        /// </summary>
        /// <value>入驻失败原因</value>
        [DataMember(Name = "reason", EmitDefaultValue = false)]
        public string Reason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayCommerceEducateCampusInstitutionsAddResponseModel {\n");
            sb.Append("  InstId: ").Append(InstId).Append("\n");
            sb.Append("  InstStdCode: ").Append(InstStdCode).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
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
            return this.Equals(input as AlipayCommerceEducateCampusInstitutionsAddResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayCommerceEducateCampusInstitutionsAddResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayCommerceEducateCampusInstitutionsAddResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayCommerceEducateCampusInstitutionsAddResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InstId == input.InstId ||
                    (this.InstId != null &&
                    this.InstId.Equals(input.InstId))
                ) && 
                (
                    this.InstStdCode == input.InstStdCode ||
                    (this.InstStdCode != null &&
                    this.InstStdCode.Equals(input.InstStdCode))
                ) && 
                (
                    this.Reason == input.Reason ||
                    (this.Reason != null &&
                    this.Reason.Equals(input.Reason))
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
                if (this.InstId != null)
                {
                    hashCode = (hashCode * 59) + this.InstId.GetHashCode();
                }
                if (this.InstStdCode != null)
                {
                    hashCode = (hashCode * 59) + this.InstStdCode.GetHashCode();
                }
                if (this.Reason != null)
                {
                    hashCode = (hashCode * 59) + this.Reason.GetHashCode();
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
