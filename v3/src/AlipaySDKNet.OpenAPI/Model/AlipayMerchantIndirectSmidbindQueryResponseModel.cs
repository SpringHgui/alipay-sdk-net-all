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
    /// AlipayMerchantIndirectSmidbindQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayMerchantIndirectSmidbindQueryResponseModel")]
    public partial class AlipayMerchantIndirectSmidbindQueryResponseModel : IEquatable<AlipayMerchantIndirectSmidbindQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMerchantIndirectSmidbindQueryResponseModel" /> class.
        /// </summary>
        /// <param name="checkResult">确认状态，枚举：已确认（AUTHORIZED）/未确认（UNAUTHORIZED）/已销户（CLOSED）/smid不存在（SMID_NOT_EXIST）.</param>
        public AlipayMerchantIndirectSmidbindQueryResponseModel(string checkResult = default(string))
        {
            this.CheckResult = checkResult;
        }

        /// <summary>
        /// 确认状态，枚举：已确认（AUTHORIZED）/未确认（UNAUTHORIZED）/已销户（CLOSED）/smid不存在（SMID_NOT_EXIST）
        /// </summary>
        /// <value>确认状态，枚举：已确认（AUTHORIZED）/未确认（UNAUTHORIZED）/已销户（CLOSED）/smid不存在（SMID_NOT_EXIST）</value>
        [DataMember(Name = "check_result", EmitDefaultValue = false)]
        public string CheckResult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMerchantIndirectSmidbindQueryResponseModel {\n");
            sb.Append("  CheckResult: ").Append(CheckResult).Append("\n");
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
            return this.Equals(input as AlipayMerchantIndirectSmidbindQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayMerchantIndirectSmidbindQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMerchantIndirectSmidbindQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMerchantIndirectSmidbindQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CheckResult == input.CheckResult ||
                    (this.CheckResult != null &&
                    this.CheckResult.Equals(input.CheckResult))
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
                if (this.CheckResult != null)
                {
                    hashCode = (hashCode * 59) + this.CheckResult.GetHashCode();
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
