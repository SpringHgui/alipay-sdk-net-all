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
    /// AlipayOpenMiniIsvFastregisterQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniIsvFastregisterQueryResponseModel")]
    public partial class AlipayOpenMiniIsvFastregisterQueryResponseModel : IEquatable<AlipayOpenMiniIsvFastregisterQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniIsvFastregisterQueryResponseModel" /> class.
        /// </summary>
        /// <param name="appName">小程序应用名.</param>
        /// <param name="isvAppId">服务商appid.</param>
        /// <param name="miniAppId">小程序appid.</param>
        /// <param name="orderNo">代创建试用小程序单号.</param>
        /// <param name="outOrderNo">商户传入的外部订单号.</param>
        /// <param name="status">WAIT_CONFIRM待确认创建， CONFIRM_TIMEOUT待创建确认授权超时， CREATE_MINI_APP_SUCCESS创建应用成功，CREATE_MINI_APP_FAILED创建应用失败，CANCELLED已注销，CERTIFY_SUCCESS认证成功，CERTIFY_FAILED认证失败，CERTIFY_OPERATOR管理员认证中，CERTIFY_MERCHANT法人认证中.</param>
        public AlipayOpenMiniIsvFastregisterQueryResponseModel(string appName = default(string), string isvAppId = default(string), string miniAppId = default(string), string orderNo = default(string), string outOrderNo = default(string), string status = default(string))
        {
            this.AppName = appName;
            this.IsvAppId = isvAppId;
            this.MiniAppId = miniAppId;
            this.OrderNo = orderNo;
            this.OutOrderNo = outOrderNo;
            this.Status = status;
        }

        /// <summary>
        /// 小程序应用名
        /// </summary>
        /// <value>小程序应用名</value>
        [DataMember(Name = "app_name", EmitDefaultValue = false)]
        public string AppName { get; set; }

        /// <summary>
        /// 服务商appid
        /// </summary>
        /// <value>服务商appid</value>
        [DataMember(Name = "isv_app_id", EmitDefaultValue = false)]
        public string IsvAppId { get; set; }

        /// <summary>
        /// 小程序appid
        /// </summary>
        /// <value>小程序appid</value>
        [DataMember(Name = "mini_app_id", EmitDefaultValue = false)]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 代创建试用小程序单号
        /// </summary>
        /// <value>代创建试用小程序单号</value>
        [DataMember(Name = "order_no", EmitDefaultValue = false)]
        public string OrderNo { get; set; }

        /// <summary>
        /// 商户传入的外部订单号
        /// </summary>
        /// <value>商户传入的外部订单号</value>
        [DataMember(Name = "out_order_no", EmitDefaultValue = false)]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// WAIT_CONFIRM待确认创建， CONFIRM_TIMEOUT待创建确认授权超时， CREATE_MINI_APP_SUCCESS创建应用成功，CREATE_MINI_APP_FAILED创建应用失败，CANCELLED已注销，CERTIFY_SUCCESS认证成功，CERTIFY_FAILED认证失败，CERTIFY_OPERATOR管理员认证中，CERTIFY_MERCHANT法人认证中
        /// </summary>
        /// <value>WAIT_CONFIRM待确认创建， CONFIRM_TIMEOUT待创建确认授权超时， CREATE_MINI_APP_SUCCESS创建应用成功，CREATE_MINI_APP_FAILED创建应用失败，CANCELLED已注销，CERTIFY_SUCCESS认证成功，CERTIFY_FAILED认证失败，CERTIFY_OPERATOR管理员认证中，CERTIFY_MERCHANT法人认证中</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniIsvFastregisterQueryResponseModel {\n");
            sb.Append("  AppName: ").Append(AppName).Append("\n");
            sb.Append("  IsvAppId: ").Append(IsvAppId).Append("\n");
            sb.Append("  MiniAppId: ").Append(MiniAppId).Append("\n");
            sb.Append("  OrderNo: ").Append(OrderNo).Append("\n");
            sb.Append("  OutOrderNo: ").Append(OutOrderNo).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniIsvFastregisterQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniIsvFastregisterQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniIsvFastregisterQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniIsvFastregisterQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AppName == input.AppName ||
                    (this.AppName != null &&
                    this.AppName.Equals(input.AppName))
                ) && 
                (
                    this.IsvAppId == input.IsvAppId ||
                    (this.IsvAppId != null &&
                    this.IsvAppId.Equals(input.IsvAppId))
                ) && 
                (
                    this.MiniAppId == input.MiniAppId ||
                    (this.MiniAppId != null &&
                    this.MiniAppId.Equals(input.MiniAppId))
                ) && 
                (
                    this.OrderNo == input.OrderNo ||
                    (this.OrderNo != null &&
                    this.OrderNo.Equals(input.OrderNo))
                ) && 
                (
                    this.OutOrderNo == input.OutOrderNo ||
                    (this.OutOrderNo != null &&
                    this.OutOrderNo.Equals(input.OutOrderNo))
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
                if (this.AppName != null)
                {
                    hashCode = (hashCode * 59) + this.AppName.GetHashCode();
                }
                if (this.IsvAppId != null)
                {
                    hashCode = (hashCode * 59) + this.IsvAppId.GetHashCode();
                }
                if (this.MiniAppId != null)
                {
                    hashCode = (hashCode * 59) + this.MiniAppId.GetHashCode();
                }
                if (this.OrderNo != null)
                {
                    hashCode = (hashCode * 59) + this.OrderNo.GetHashCode();
                }
                if (this.OutOrderNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutOrderNo.GetHashCode();
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
