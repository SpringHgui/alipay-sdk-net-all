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
    /// AlipayEbppInvoiceInfoSendResponseModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceInfoSendResponseModel")]
    public partial class AlipayEbppInvoiceInfoSendResponseModel : IEquatable<AlipayEbppInvoiceInfoSendResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceInfoSendResponseModel" /> class.
        /// </summary>
        /// <param name="url">发票访问地址，同步红票的情况下不返回该字段，同步蓝票的情况下如果同步单张发票，返回发票详情链接地址，如果同步的是多张发票，返回发票列表地址.</param>
        public AlipayEbppInvoiceInfoSendResponseModel(string url = default(string))
        {
            this.Url = url;
        }

        /// <summary>
        /// 发票访问地址，同步红票的情况下不返回该字段，同步蓝票的情况下如果同步单张发票，返回发票详情链接地址，如果同步的是多张发票，返回发票列表地址
        /// </summary>
        /// <value>发票访问地址，同步红票的情况下不返回该字段，同步蓝票的情况下如果同步单张发票，返回发票详情链接地址，如果同步的是多张发票，返回发票列表地址</value>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceInfoSendResponseModel {\n");
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
            return this.Equals(input as AlipayEbppInvoiceInfoSendResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceInfoSendResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceInfoSendResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceInfoSendResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
