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
    /// AlipayEbppInvoiceEnterpriseMerchantrelationCreateResponseModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceEnterpriseMerchantrelationCreateResponseModel")]
    public partial class AlipayEbppInvoiceEnterpriseMerchantrelationCreateResponseModel : IEquatable<AlipayEbppInvoiceEnterpriseMerchantrelationCreateResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceEnterpriseMerchantrelationCreateResponseModel" /> class.
        /// </summary>
        /// <param name="pid">门店收单pid.</param>
        /// <param name="roleType">门店直间连类型.</param>
        /// <param name="shopId">门店ID.</param>
        /// <param name="success">是否成功.</param>
        public AlipayEbppInvoiceEnterpriseMerchantrelationCreateResponseModel(string pid = default(string), string roleType = default(string), string shopId = default(string), bool success = default(bool))
        {
            this.Pid = pid;
            this.RoleType = roleType;
            this.ShopId = shopId;
            this.Success = success;
        }

        /// <summary>
        /// 门店收单pid
        /// </summary>
        /// <value>门店收单pid</value>
        [DataMember(Name = "pid", EmitDefaultValue = false)]
        public string Pid { get; set; }

        /// <summary>
        /// 门店直间连类型
        /// </summary>
        /// <value>门店直间连类型</value>
        [DataMember(Name = "role_type", EmitDefaultValue = false)]
        public string RoleType { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        /// <value>门店ID</value>
        [DataMember(Name = "shop_id", EmitDefaultValue = false)]
        public string ShopId { get; set; }

        /// <summary>
        /// 是否成功
        /// </summary>
        /// <value>是否成功</value>
        [DataMember(Name = "success", EmitDefaultValue = true)]
        public bool Success { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceEnterpriseMerchantrelationCreateResponseModel {\n");
            sb.Append("  Pid: ").Append(Pid).Append("\n");
            sb.Append("  RoleType: ").Append(RoleType).Append("\n");
            sb.Append("  ShopId: ").Append(ShopId).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceEnterpriseMerchantrelationCreateResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceEnterpriseMerchantrelationCreateResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceEnterpriseMerchantrelationCreateResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceEnterpriseMerchantrelationCreateResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Pid == input.Pid ||
                    (this.Pid != null &&
                    this.Pid.Equals(input.Pid))
                ) && 
                (
                    this.RoleType == input.RoleType ||
                    (this.RoleType != null &&
                    this.RoleType.Equals(input.RoleType))
                ) && 
                (
                    this.ShopId == input.ShopId ||
                    (this.ShopId != null &&
                    this.ShopId.Equals(input.ShopId))
                ) && 
                (
                    this.Success == input.Success ||
                    this.Success.Equals(input.Success)
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
                if (this.Pid != null)
                {
                    hashCode = (hashCode * 59) + this.Pid.GetHashCode();
                }
                if (this.RoleType != null)
                {
                    hashCode = (hashCode * 59) + this.RoleType.GetHashCode();
                }
                if (this.ShopId != null)
                {
                    hashCode = (hashCode * 59) + this.ShopId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Success.GetHashCode();
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
