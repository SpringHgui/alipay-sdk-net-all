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
    /// AlipayUserAgreementExecutionplanModifyResponseModel
    /// </summary>
    [DataContract(Name = "AlipayUserAgreementExecutionplanModifyResponseModel")]
    public partial class AlipayUserAgreementExecutionplanModifyResponseModel : IEquatable<AlipayUserAgreementExecutionplanModifyResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayUserAgreementExecutionplanModifyResponseModel" /> class.
        /// </summary>
        /// <param name="agreementNo">周期性扣款产品，授权免密支付协议号.</param>
        /// <param name="deductTime">商户下一次扣款时间，格式 \&quot;yyyy-MM-dd\&quot;。 例如：用户在1月1日开通了连续包月，使用了10天又另行购买了“季度包”，如果此时商户希望“季度包”立即优先生效，在季度包结束后能继续使用连续包月，那么原定的周期就被延后了。此时可以通过本接口将预计扣款时间推后“季度包”的时长。.</param>
        public AlipayUserAgreementExecutionplanModifyResponseModel(string agreementNo = default(string), string deductTime = default(string))
        {
            this.AgreementNo = agreementNo;
            this.DeductTime = deductTime;
        }

        /// <summary>
        /// 周期性扣款产品，授权免密支付协议号
        /// </summary>
        /// <value>周期性扣款产品，授权免密支付协议号</value>
        [DataMember(Name = "agreement_no", EmitDefaultValue = false)]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 商户下一次扣款时间，格式 \&quot;yyyy-MM-dd\&quot;。 例如：用户在1月1日开通了连续包月，使用了10天又另行购买了“季度包”，如果此时商户希望“季度包”立即优先生效，在季度包结束后能继续使用连续包月，那么原定的周期就被延后了。此时可以通过本接口将预计扣款时间推后“季度包”的时长。
        /// </summary>
        /// <value>商户下一次扣款时间，格式 \&quot;yyyy-MM-dd\&quot;。 例如：用户在1月1日开通了连续包月，使用了10天又另行购买了“季度包”，如果此时商户希望“季度包”立即优先生效，在季度包结束后能继续使用连续包月，那么原定的周期就被延后了。此时可以通过本接口将预计扣款时间推后“季度包”的时长。</value>
        [DataMember(Name = "deduct_time", EmitDefaultValue = false)]
        public string DeductTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayUserAgreementExecutionplanModifyResponseModel {\n");
            sb.Append("  AgreementNo: ").Append(AgreementNo).Append("\n");
            sb.Append("  DeductTime: ").Append(DeductTime).Append("\n");
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
            return this.Equals(input as AlipayUserAgreementExecutionplanModifyResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayUserAgreementExecutionplanModifyResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayUserAgreementExecutionplanModifyResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayUserAgreementExecutionplanModifyResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AgreementNo == input.AgreementNo ||
                    (this.AgreementNo != null &&
                    this.AgreementNo.Equals(input.AgreementNo))
                ) && 
                (
                    this.DeductTime == input.DeductTime ||
                    (this.DeductTime != null &&
                    this.DeductTime.Equals(input.DeductTime))
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
                if (this.AgreementNo != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementNo.GetHashCode();
                }
                if (this.DeductTime != null)
                {
                    hashCode = (hashCode * 59) + this.DeductTime.GetHashCode();
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
