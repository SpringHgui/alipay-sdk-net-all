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
    /// AlipayUserCertdocCertverifyPreconsultResponseModel
    /// </summary>
    [DataContract(Name = "AlipayUserCertdocCertverifyPreconsultResponseModel")]
    public partial class AlipayUserCertdocCertverifyPreconsultResponseModel : IEquatable<AlipayUserCertdocCertverifyPreconsultResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayUserCertdocCertverifyPreconsultResponseModel" /> class.
        /// </summary>
        /// <param name="verifyId">申请验证ID。有效期为 2 小时，过期后在校验接口使用会报错 \&quot;校验信息已过期\&quot;。.</param>
        public AlipayUserCertdocCertverifyPreconsultResponseModel(string verifyId = default(string))
        {
            this.VerifyId = verifyId;
        }

        /// <summary>
        /// 申请验证ID。有效期为 2 小时，过期后在校验接口使用会报错 \&quot;校验信息已过期\&quot;。
        /// </summary>
        /// <value>申请验证ID。有效期为 2 小时，过期后在校验接口使用会报错 \&quot;校验信息已过期\&quot;。</value>
        [DataMember(Name = "verify_id", EmitDefaultValue = false)]
        public string VerifyId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayUserCertdocCertverifyPreconsultResponseModel {\n");
            sb.Append("  VerifyId: ").Append(VerifyId).Append("\n");
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
            return this.Equals(input as AlipayUserCertdocCertverifyPreconsultResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayUserCertdocCertverifyPreconsultResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayUserCertdocCertverifyPreconsultResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayUserCertdocCertverifyPreconsultResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VerifyId == input.VerifyId ||
                    (this.VerifyId != null &&
                    this.VerifyId.Equals(input.VerifyId))
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
                if (this.VerifyId != null)
                {
                    hashCode = (hashCode * 59) + this.VerifyId.GetHashCode();
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
