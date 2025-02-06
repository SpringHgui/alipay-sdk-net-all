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
    /// AlipayOpenSearchSubservicekeywordApplyResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenSearchSubservicekeywordApplyResponseModel")]
    public partial class AlipayOpenSearchSubservicekeywordApplyResponseModel : IEquatable<AlipayOpenSearchSubservicekeywordApplyResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenSearchSubservicekeywordApplyResponseModel" /> class.
        /// </summary>
        /// <param name="applyNo">审核工单id，唯一，提报服务关键词，提报服务关键词返回该id.</param>
        public AlipayOpenSearchSubservicekeywordApplyResponseModel(string applyNo = default(string))
        {
            this.ApplyNo = applyNo;
        }

        /// <summary>
        /// 审核工单id，唯一，提报服务关键词，提报服务关键词返回该id
        /// </summary>
        /// <value>审核工单id，唯一，提报服务关键词，提报服务关键词返回该id</value>
        [DataMember(Name = "apply_no", EmitDefaultValue = false)]
        public string ApplyNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenSearchSubservicekeywordApplyResponseModel {\n");
            sb.Append("  ApplyNo: ").Append(ApplyNo).Append("\n");
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
            return this.Equals(input as AlipayOpenSearchSubservicekeywordApplyResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenSearchSubservicekeywordApplyResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenSearchSubservicekeywordApplyResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenSearchSubservicekeywordApplyResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ApplyNo == input.ApplyNo ||
                    (this.ApplyNo != null &&
                    this.ApplyNo.Equals(input.ApplyNo))
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
                if (this.ApplyNo != null)
                {
                    hashCode = (hashCode * 59) + this.ApplyNo.GetHashCode();
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
