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
    /// AlipayDataBillAccountbookereceiptQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayDataBillAccountbookereceiptQueryResponseModel")]
    public partial class AlipayDataBillAccountbookereceiptQueryResponseModel : IEquatable<AlipayDataBillAccountbookereceiptQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayDataBillAccountbookereceiptQueryResponseModel" /> class.
        /// </summary>
        /// <param name="downloadUrl">下载链接。status为SUCCESS时返回。用户可以使用此http链接下载文件内容。有效时间20s。 生成的文件是zip格式。需要解压后获取电子回单pdf内容.</param>
        /// <param name="errorMessage">如果生成失败，则会返回失败原因.</param>
        /// <param name="status">处理状态   * INIT - 初始化   * PROCESS - 处理中   * SUCCESS - 成功   * FAIL - 失败.</param>
        public AlipayDataBillAccountbookereceiptQueryResponseModel(string downloadUrl = default(string), string errorMessage = default(string), string status = default(string))
        {
            this.DownloadUrl = downloadUrl;
            this.ErrorMessage = errorMessage;
            this.Status = status;
        }

        /// <summary>
        /// 下载链接。status为SUCCESS时返回。用户可以使用此http链接下载文件内容。有效时间20s。 生成的文件是zip格式。需要解压后获取电子回单pdf内容
        /// </summary>
        /// <value>下载链接。status为SUCCESS时返回。用户可以使用此http链接下载文件内容。有效时间20s。 生成的文件是zip格式。需要解压后获取电子回单pdf内容</value>
        [DataMember(Name = "download_url", EmitDefaultValue = false)]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// 如果生成失败，则会返回失败原因
        /// </summary>
        /// <value>如果生成失败，则会返回失败原因</value>
        [DataMember(Name = "error_message", EmitDefaultValue = false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 处理状态   * INIT - 初始化   * PROCESS - 处理中   * SUCCESS - 成功   * FAIL - 失败
        /// </summary>
        /// <value>处理状态   * INIT - 初始化   * PROCESS - 处理中   * SUCCESS - 成功   * FAIL - 失败</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayDataBillAccountbookereceiptQueryResponseModel {\n");
            sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as AlipayDataBillAccountbookereceiptQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayDataBillAccountbookereceiptQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayDataBillAccountbookereceiptQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayDataBillAccountbookereceiptQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DownloadUrl == input.DownloadUrl ||
                    (this.DownloadUrl != null &&
                    this.DownloadUrl.Equals(input.DownloadUrl))
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.DownloadUrl != null)
                {
                    hashCode = (hashCode * 59) + this.DownloadUrl.GetHashCode();
                }
                if (this.ErrorMessage != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorMessage.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
