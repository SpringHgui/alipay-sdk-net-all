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
    /// AlipaySecurityRiskVerifyidentityMiniappConfirmResponseModel
    /// </summary>
    [DataContract(Name = "AlipaySecurityRiskVerifyidentityMiniappConfirmResponseModel")]
    public partial class AlipaySecurityRiskVerifyidentityMiniappConfirmResponseModel : IEquatable<AlipaySecurityRiskVerifyidentityMiniappConfirmResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipaySecurityRiskVerifyidentityMiniappConfirmResponseModel" /> class.
        /// </summary>
        /// <param name="errorCode">身份核实校验结果失败时，返回的失败错误码.</param>
        /// <param name="errorMsg">身份核实校验结果失败时，返回的失败错误原因说明.</param>
        /// <param name="verifyResult">身份核验结果.</param>
        public AlipaySecurityRiskVerifyidentityMiniappConfirmResponseModel(string errorCode = default(string), string errorMsg = default(string), bool verifyResult = default(bool))
        {
            this.ErrorCode = errorCode;
            this.ErrorMsg = errorMsg;
            this.VerifyResult = verifyResult;
        }

        /// <summary>
        /// 身份核实校验结果失败时，返回的失败错误码
        /// </summary>
        /// <value>身份核实校验结果失败时，返回的失败错误码</value>
        [DataMember(Name = "error_code", EmitDefaultValue = false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 身份核实校验结果失败时，返回的失败错误原因说明
        /// </summary>
        /// <value>身份核实校验结果失败时，返回的失败错误原因说明</value>
        [DataMember(Name = "error_msg", EmitDefaultValue = false)]
        public string ErrorMsg { get; set; }

        /// <summary>
        /// 身份核验结果
        /// </summary>
        /// <value>身份核验结果</value>
        [DataMember(Name = "verify_result", EmitDefaultValue = true)]
        public bool VerifyResult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipaySecurityRiskVerifyidentityMiniappConfirmResponseModel {\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorMsg: ").Append(ErrorMsg).Append("\n");
            sb.Append("  VerifyResult: ").Append(VerifyResult).Append("\n");
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
            return this.Equals(input as AlipaySecurityRiskVerifyidentityMiniappConfirmResponseModel);
        }

        /// <summary>
        /// Returns true if AlipaySecurityRiskVerifyidentityMiniappConfirmResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipaySecurityRiskVerifyidentityMiniappConfirmResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipaySecurityRiskVerifyidentityMiniappConfirmResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.ErrorMsg == input.ErrorMsg ||
                    (this.ErrorMsg != null &&
                    this.ErrorMsg.Equals(input.ErrorMsg))
                ) && 
                (
                    this.VerifyResult == input.VerifyResult ||
                    this.VerifyResult.Equals(input.VerifyResult)
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
                if (this.ErrorCode != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorCode.GetHashCode();
                }
                if (this.ErrorMsg != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorMsg.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.VerifyResult.GetHashCode();
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
