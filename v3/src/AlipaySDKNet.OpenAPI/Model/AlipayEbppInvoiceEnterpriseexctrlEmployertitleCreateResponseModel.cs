/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2025-02-06
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
    /// AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateResponseModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateResponseModel")]
    public partial class AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateResponseModel : IEquatable<AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateResponseModel" /> class.
        /// </summary>
        /// <param name="code">返回码 10000-成功 其他都是失败.</param>
        /// <param name="msg">返回消息.</param>
        /// <param name="success">是否成功.</param>
        /// <param name="titleId">抬头ID.</param>
        public AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateResponseModel(string code = default(string), string msg = default(string), bool success = default(bool), string titleId = default(string))
        {
            this.Code = code;
            this.Msg = msg;
            this.Success = success;
            this.TitleId = titleId;
        }

        /// <summary>
        /// 返回码 10000-成功 其他都是失败
        /// </summary>
        /// <value>返回码 10000-成功 其他都是失败</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// 返回消息
        /// </summary>
        /// <value>返回消息</value>
        [DataMember(Name = "msg", EmitDefaultValue = false)]
        public string Msg { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        /// <value>是否成功</value>
        [DataMember(Name = "success", EmitDefaultValue = true)]
        public bool Success { get; set; }

        /// <summary>
        /// 抬头ID
        /// </summary>
        /// <value>抬头ID</value>
        [DataMember(Name = "title_id", EmitDefaultValue = false)]
        public string TitleId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateResponseModel {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Msg: ").Append(Msg).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  TitleId: ").Append(TitleId).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Msg == input.Msg ||
                    (this.Msg != null &&
                    this.Msg.Equals(input.Msg))
                ) && 
                (
                    this.Success == input.Success ||
                    this.Success.Equals(input.Success)
                ) && 
                (
                    this.TitleId == input.TitleId ||
                    (this.TitleId != null &&
                    this.TitleId.Equals(input.TitleId))
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
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.Msg != null)
                {
                    hashCode = (hashCode * 59) + this.Msg.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Success.GetHashCode();
                if (this.TitleId != null)
                {
                    hashCode = (hashCode * 59) + this.TitleId.GetHashCode();
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
