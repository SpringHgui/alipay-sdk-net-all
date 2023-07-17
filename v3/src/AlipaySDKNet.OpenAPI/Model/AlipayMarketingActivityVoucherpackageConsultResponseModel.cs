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
    /// AlipayMarketingActivityVoucherpackageConsultResponseModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingActivityVoucherpackageConsultResponseModel")]
    public partial class AlipayMarketingActivityVoucherpackageConsultResponseModel : IEquatable<AlipayMarketingActivityVoucherpackageConsultResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingActivityVoucherpackageConsultResponseModel" /> class.
        /// </summary>
        /// <param name="voucherPackageConsultResult">券包购买咨询结果.</param>
        public AlipayMarketingActivityVoucherpackageConsultResponseModel(List<VoucherPackageConsultResult> voucherPackageConsultResult = default(List<VoucherPackageConsultResult>))
        {
            this.VoucherPackageConsultResult = voucherPackageConsultResult;
        }

        /// <summary>
        /// 券包购买咨询结果
        /// </summary>
        /// <value>券包购买咨询结果</value>
        [DataMember(Name = "voucher_package_consult_result", EmitDefaultValue = false)]
        public List<VoucherPackageConsultResult> VoucherPackageConsultResult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingActivityVoucherpackageConsultResponseModel {\n");
            sb.Append("  VoucherPackageConsultResult: ").Append(VoucherPackageConsultResult).Append("\n");
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
            return this.Equals(input as AlipayMarketingActivityVoucherpackageConsultResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingActivityVoucherpackageConsultResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingActivityVoucherpackageConsultResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingActivityVoucherpackageConsultResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VoucherPackageConsultResult == input.VoucherPackageConsultResult ||
                    this.VoucherPackageConsultResult != null &&
                    input.VoucherPackageConsultResult != null &&
                    this.VoucherPackageConsultResult.SequenceEqual(input.VoucherPackageConsultResult)
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
                if (this.VoucherPackageConsultResult != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherPackageConsultResult.GetHashCode();
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
