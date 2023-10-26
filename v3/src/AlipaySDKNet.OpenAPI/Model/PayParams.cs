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
    /// PayParams
    /// </summary>
    [DataContract(Name = "PayParams")]
    public partial class PayParams : IEquatable<PayParams>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayParams" /> class.
        /// </summary>
        /// <param name="asyncType">普通异步支付, 传入该参数时，如果满足受理条件，会先同步受理支付，然后在异步调度推进支付  NORMAL_ASYNC: 普通异步，受理成功之后，会在交易关单之前通过一定的策略重试  NEAR_REAL_TIME_ASYNC: 准实时异步，受理成功之后，会准实时发起1次调度.</param>
        /// <param name="retryType">重试类型，当async_type传入NORMAL_ASYNC时，可以设置该参数，选择是否要重试，retry_type 可选，不设置时，可重试。 ● NONE_AND_CLOSETRADE：不重试，支付请求只会被执行1次，执行完成后如果交易未成功，会关闭交易 ● NONE：不重试，支付请求只会被执行1次，执行完成后，不做任何处理。交易到达了timeout_express指定的时间后，关闭交易。 ● RETY: 重试，支付请求在超时关单前，会按照策略重试.</param>
        public PayParams(string asyncType = default(string), string retryType = default(string))
        {
            this.AsyncType = asyncType;
            this.RetryType = retryType;
        }

        /// <summary>
        /// 普通异步支付, 传入该参数时，如果满足受理条件，会先同步受理支付，然后在异步调度推进支付  NORMAL_ASYNC: 普通异步，受理成功之后，会在交易关单之前通过一定的策略重试  NEAR_REAL_TIME_ASYNC: 准实时异步，受理成功之后，会准实时发起1次调度
        /// </summary>
        /// <value>普通异步支付, 传入该参数时，如果满足受理条件，会先同步受理支付，然后在异步调度推进支付  NORMAL_ASYNC: 普通异步，受理成功之后，会在交易关单之前通过一定的策略重试  NEAR_REAL_TIME_ASYNC: 准实时异步，受理成功之后，会准实时发起1次调度</value>
        [DataMember(Name = "async_type", EmitDefaultValue = false)]
        public string AsyncType { get; set; }

        /// <summary>
        /// 重试类型，当async_type传入NORMAL_ASYNC时，可以设置该参数，选择是否要重试，retry_type 可选，不设置时，可重试。 ● NONE_AND_CLOSETRADE：不重试，支付请求只会被执行1次，执行完成后如果交易未成功，会关闭交易 ● NONE：不重试，支付请求只会被执行1次，执行完成后，不做任何处理。交易到达了timeout_express指定的时间后，关闭交易。 ● RETY: 重试，支付请求在超时关单前，会按照策略重试
        /// </summary>
        /// <value>重试类型，当async_type传入NORMAL_ASYNC时，可以设置该参数，选择是否要重试，retry_type 可选，不设置时，可重试。 ● NONE_AND_CLOSETRADE：不重试，支付请求只会被执行1次，执行完成后如果交易未成功，会关闭交易 ● NONE：不重试，支付请求只会被执行1次，执行完成后，不做任何处理。交易到达了timeout_express指定的时间后，关闭交易。 ● RETY: 重试，支付请求在超时关单前，会按照策略重试</value>
        [DataMember(Name = "retry_type", EmitDefaultValue = false)]
        public string RetryType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PayParams {\n");
            sb.Append("  AsyncType: ").Append(AsyncType).Append("\n");
            sb.Append("  RetryType: ").Append(RetryType).Append("\n");
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
            return this.Equals(input as PayParams);
        }

        /// <summary>
        /// Returns true if PayParams instances are equal
        /// </summary>
        /// <param name="input">Instance of PayParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayParams input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AsyncType == input.AsyncType ||
                    (this.AsyncType != null &&
                    this.AsyncType.Equals(input.AsyncType))
                ) && 
                (
                    this.RetryType == input.RetryType ||
                    (this.RetryType != null &&
                    this.RetryType.Equals(input.RetryType))
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
                if (this.AsyncType != null)
                {
                    hashCode = (hashCode * 59) + this.AsyncType.GetHashCode();
                }
                if (this.RetryType != null)
                {
                    hashCode = (hashCode * 59) + this.RetryType.GetHashCode();
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
