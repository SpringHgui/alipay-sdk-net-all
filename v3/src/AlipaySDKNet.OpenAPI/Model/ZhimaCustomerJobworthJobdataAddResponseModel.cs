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
    /// ZhimaCustomerJobworthJobdataAddResponseModel
    /// </summary>
    [DataContract(Name = "ZhimaCustomerJobworthJobdataAddResponseModel")]
    public partial class ZhimaCustomerJobworthJobdataAddResponseModel : IEquatable<ZhimaCustomerJobworthJobdataAddResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaCustomerJobworthJobdataAddResponseModel" /> class.
        /// </summary>
        /// <param name="acceptanceId">受理台单号，用来调用工作证受理台.</param>
        /// <param name="subCode">错误码.</param>
        /// <param name="subMsg">业务中文结果信息.</param>
        /// <param name="url">职得工作证跳转小程序链接.</param>
        public ZhimaCustomerJobworthJobdataAddResponseModel(string acceptanceId = default(string), string subCode = default(string), string subMsg = default(string), string url = default(string))
        {
            this.AcceptanceId = acceptanceId;
            this.SubCode = subCode;
            this.SubMsg = subMsg;
            this.Url = url;
        }

        /// <summary>
        /// 受理台单号，用来调用工作证受理台
        /// </summary>
        /// <value>受理台单号，用来调用工作证受理台</value>
        [DataMember(Name = "acceptance_id", EmitDefaultValue = false)]
        public string AcceptanceId { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "sub_code", EmitDefaultValue = false)]
        public string SubCode { get; set; }

        /// <summary>
        /// 业务中文结果信息
        /// </summary>
        /// <value>业务中文结果信息</value>
        [DataMember(Name = "sub_msg", EmitDefaultValue = false)]
        public string SubMsg { get; set; }

        /// <summary>
        /// 职得工作证跳转小程序链接
        /// </summary>
        /// <value>职得工作证跳转小程序链接</value>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZhimaCustomerJobworthJobdataAddResponseModel {\n");
            sb.Append("  AcceptanceId: ").Append(AcceptanceId).Append("\n");
            sb.Append("  SubCode: ").Append(SubCode).Append("\n");
            sb.Append("  SubMsg: ").Append(SubMsg).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as ZhimaCustomerJobworthJobdataAddResponseModel);
        }

        /// <summary>
        /// Returns true if ZhimaCustomerJobworthJobdataAddResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ZhimaCustomerJobworthJobdataAddResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZhimaCustomerJobworthJobdataAddResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AcceptanceId == input.AcceptanceId ||
                    (this.AcceptanceId != null &&
                    this.AcceptanceId.Equals(input.AcceptanceId))
                ) && 
                (
                    this.SubCode == input.SubCode ||
                    (this.SubCode != null &&
                    this.SubCode.Equals(input.SubCode))
                ) && 
                (
                    this.SubMsg == input.SubMsg ||
                    (this.SubMsg != null &&
                    this.SubMsg.Equals(input.SubMsg))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.AcceptanceId != null)
                {
                    hashCode = (hashCode * 59) + this.AcceptanceId.GetHashCode();
                }
                if (this.SubCode != null)
                {
                    hashCode = (hashCode * 59) + this.SubCode.GetHashCode();
                }
                if (this.SubMsg != null)
                {
                    hashCode = (hashCode * 59) + this.SubMsg.GetHashCode();
                }
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
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
