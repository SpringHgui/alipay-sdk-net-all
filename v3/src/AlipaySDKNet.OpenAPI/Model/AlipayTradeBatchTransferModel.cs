/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2024-10-08
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
    /// AlipayTradeBatchTransferModel
    /// </summary>
    [DataContract(Name = "AlipayTradeBatchTransferModel")]
    public partial class AlipayTradeBatchTransferModel : IEquatable<AlipayTradeBatchTransferModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayTradeBatchTransferModel" /> class.
        /// </summary>
        /// <param name="extendParams">业务扩展参数.</param>
        /// <param name="outRequestNo">结算请求外部流水号，32个字符以内、可包含字母、数字、下划线；需保证在商户端不重复.</param>
        /// <param name="royaltyParameters">分账条款明细 特别注意：最好一次只传一个分账条款。 如果传多个，则要求出账方只能有一个， 举例：A分给B+A分给C+A分给D&#x3D;OK A分给B+C分给D&#x3D;不行.</param>
        public AlipayTradeBatchTransferModel(string extendParams = default(string), string outRequestNo = default(string), List<RoyaltyDetailInfo> royaltyParameters = default(List<RoyaltyDetailInfo>))
        {
            this.ExtendParams = extendParams;
            this.OutRequestNo = outRequestNo;
            this.RoyaltyParameters = royaltyParameters;
        }

        /// <summary>
        /// 业务扩展参数
        /// </summary>
        /// <value>业务扩展参数</value>
        [DataMember(Name = "extend_params", EmitDefaultValue = false)]
        public string ExtendParams { get; set; }

        /// <summary>
        /// 结算请求外部流水号，32个字符以内、可包含字母、数字、下划线；需保证在商户端不重复
        /// </summary>
        /// <value>结算请求外部流水号，32个字符以内、可包含字母、数字、下划线；需保证在商户端不重复</value>
        [DataMember(Name = "out_request_no", EmitDefaultValue = false)]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 分账条款明细 特别注意：最好一次只传一个分账条款。 如果传多个，则要求出账方只能有一个， 举例：A分给B+A分给C+A分给D&#x3D;OK A分给B+C分给D&#x3D;不行
        /// </summary>
        /// <value>分账条款明细 特别注意：最好一次只传一个分账条款。 如果传多个，则要求出账方只能有一个， 举例：A分给B+A分给C+A分给D&#x3D;OK A分给B+C分给D&#x3D;不行</value>
        [DataMember(Name = "royalty_parameters", EmitDefaultValue = false)]
        public List<RoyaltyDetailInfo> RoyaltyParameters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayTradeBatchTransferModel {\n");
            sb.Append("  ExtendParams: ").Append(ExtendParams).Append("\n");
            sb.Append("  OutRequestNo: ").Append(OutRequestNo).Append("\n");
            sb.Append("  RoyaltyParameters: ").Append(RoyaltyParameters).Append("\n");
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
            return this.Equals(input as AlipayTradeBatchTransferModel);
        }

        /// <summary>
        /// Returns true if AlipayTradeBatchTransferModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayTradeBatchTransferModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayTradeBatchTransferModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ExtendParams == input.ExtendParams ||
                    (this.ExtendParams != null &&
                    this.ExtendParams.Equals(input.ExtendParams))
                ) && 
                (
                    this.OutRequestNo == input.OutRequestNo ||
                    (this.OutRequestNo != null &&
                    this.OutRequestNo.Equals(input.OutRequestNo))
                ) && 
                (
                    this.RoyaltyParameters == input.RoyaltyParameters ||
                    this.RoyaltyParameters != null &&
                    input.RoyaltyParameters != null &&
                    this.RoyaltyParameters.SequenceEqual(input.RoyaltyParameters)
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
                if (this.ExtendParams != null)
                {
                    hashCode = (hashCode * 59) + this.ExtendParams.GetHashCode();
                }
                if (this.OutRequestNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutRequestNo.GetHashCode();
                }
                if (this.RoyaltyParameters != null)
                {
                    hashCode = (hashCode * 59) + this.RoyaltyParameters.GetHashCode();
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
