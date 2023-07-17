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
    /// AlipayOpenMiniIsvQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniIsvQueryResponseModel")]
    public partial class AlipayOpenMiniIsvQueryResponseModel : IEquatable<AlipayOpenMiniIsvQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniIsvQueryResponseModel" /> class.
        /// </summary>
        /// <param name="minAppId">小程序appId，商家确认后非空，若商家未确认或超时返回空.</param>
        /// <param name="orderNo">订单号.</param>
        /// <param name="outOrderNo">外部订单号，开发者帐号+外部订单号维度来控制请求务幂等.</param>
        /// <param name="pid">商户pid.</param>
        /// <param name="status">PROCESS处理中，TIMEOUT超时，AGREED同意， REJECTED拒绝.</param>
        public AlipayOpenMiniIsvQueryResponseModel(string minAppId = default(string), string orderNo = default(string), string outOrderNo = default(string), string pid = default(string), string status = default(string))
        {
            this.MinAppId = minAppId;
            this.OrderNo = orderNo;
            this.OutOrderNo = outOrderNo;
            this.Pid = pid;
            this.Status = status;
        }

        /// <summary>
        /// 小程序appId，商家确认后非空，若商家未确认或超时返回空
        /// </summary>
        /// <value>小程序appId，商家确认后非空，若商家未确认或超时返回空</value>
        [DataMember(Name = "min_app_id", EmitDefaultValue = false)]
        public string MinAppId { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        /// <value>订单号</value>
        [DataMember(Name = "order_no", EmitDefaultValue = false)]
        public string OrderNo { get; set; }

        /// <summary>
        /// 外部订单号，开发者帐号+外部订单号维度来控制请求务幂等
        /// </summary>
        /// <value>外部订单号，开发者帐号+外部订单号维度来控制请求务幂等</value>
        [DataMember(Name = "out_order_no", EmitDefaultValue = false)]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        /// <value>商户pid</value>
        [DataMember(Name = "pid", EmitDefaultValue = false)]
        public string Pid { get; set; }

        /// <summary>
        /// PROCESS处理中，TIMEOUT超时，AGREED同意， REJECTED拒绝
        /// </summary>
        /// <value>PROCESS处理中，TIMEOUT超时，AGREED同意， REJECTED拒绝</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniIsvQueryResponseModel {\n");
            sb.Append("  MinAppId: ").Append(MinAppId).Append("\n");
            sb.Append("  OrderNo: ").Append(OrderNo).Append("\n");
            sb.Append("  OutOrderNo: ").Append(OutOrderNo).Append("\n");
            sb.Append("  Pid: ").Append(Pid).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniIsvQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniIsvQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniIsvQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniIsvQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MinAppId == input.MinAppId ||
                    (this.MinAppId != null &&
                    this.MinAppId.Equals(input.MinAppId))
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
                    this.Pid == input.Pid ||
                    (this.Pid != null &&
                    this.Pid.Equals(input.Pid))
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
                if (this.MinAppId != null)
                {
                    hashCode = (hashCode * 59) + this.MinAppId.GetHashCode();
                }
                if (this.OrderNo != null)
                {
                    hashCode = (hashCode * 59) + this.OrderNo.GetHashCode();
                }
                if (this.OutOrderNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutOrderNo.GetHashCode();
                }
                if (this.Pid != null)
                {
                    hashCode = (hashCode * 59) + this.Pid.GetHashCode();
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
