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
    /// AlipayDataDataserviceBillDownloadurlQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayDataDataserviceBillDownloadurlQueryResponseModel")]
    public partial class AlipayDataDataserviceBillDownloadurlQueryResponseModel : IEquatable<AlipayDataDataserviceBillDownloadurlQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayDataDataserviceBillDownloadurlQueryResponseModel" /> class.
        /// </summary>
        /// <param name="billDownloadUrl">账单下载地址链接，获取连接后30秒后未下载，链接地址失效。.</param>
        /// <param name="billFileCode">描述本次申请的账单文件状态。 EMPTY_DATA_WITH_BILL_FILE：当天无账单业务数据&amp;&amp;可以获取到空数据账单文件。.</param>
        public AlipayDataDataserviceBillDownloadurlQueryResponseModel(string billDownloadUrl = default(string), string billFileCode = default(string))
        {
            this.BillDownloadUrl = billDownloadUrl;
            this.BillFileCode = billFileCode;
        }

        /// <summary>
        /// 账单下载地址链接，获取连接后30秒后未下载，链接地址失效。
        /// </summary>
        /// <value>账单下载地址链接，获取连接后30秒后未下载，链接地址失效。</value>
        [DataMember(Name = "bill_download_url", EmitDefaultValue = false)]
        public string BillDownloadUrl { get; set; }

        /// <summary>
        /// 描述本次申请的账单文件状态。 EMPTY_DATA_WITH_BILL_FILE：当天无账单业务数据&amp;&amp;可以获取到空数据账单文件。
        /// </summary>
        /// <value>描述本次申请的账单文件状态。 EMPTY_DATA_WITH_BILL_FILE：当天无账单业务数据&amp;&amp;可以获取到空数据账单文件。</value>
        [DataMember(Name = "bill_file_code", EmitDefaultValue = false)]
        public string BillFileCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayDataDataserviceBillDownloadurlQueryResponseModel {\n");
            sb.Append("  BillDownloadUrl: ").Append(BillDownloadUrl).Append("\n");
            sb.Append("  BillFileCode: ").Append(BillFileCode).Append("\n");
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
            return this.Equals(input as AlipayDataDataserviceBillDownloadurlQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayDataDataserviceBillDownloadurlQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayDataDataserviceBillDownloadurlQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayDataDataserviceBillDownloadurlQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BillDownloadUrl == input.BillDownloadUrl ||
                    (this.BillDownloadUrl != null &&
                    this.BillDownloadUrl.Equals(input.BillDownloadUrl))
                ) && 
                (
                    this.BillFileCode == input.BillFileCode ||
                    (this.BillFileCode != null &&
                    this.BillFileCode.Equals(input.BillFileCode))
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
                if (this.BillDownloadUrl != null)
                {
                    hashCode = (hashCode * 59) + this.BillDownloadUrl.GetHashCode();
                }
                if (this.BillFileCode != null)
                {
                    hashCode = (hashCode * 59) + this.BillFileCode.GetHashCode();
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
