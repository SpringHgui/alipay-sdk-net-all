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
    /// AlipayOpenMiniIsvCreateResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniIsvCreateResponseModel")]
    public partial class AlipayOpenMiniIsvCreateResponseModel : IEquatable<AlipayOpenMiniIsvCreateResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniIsvCreateResponseModel" /> class.
        /// </summary>
        /// <param name="orderNo">小程序代创建订单号.</param>
        public AlipayOpenMiniIsvCreateResponseModel(string orderNo = default(string))
        {
            this.OrderNo = orderNo;
        }

        /// <summary>
        /// 小程序代创建订单号
        /// </summary>
        /// <value>小程序代创建订单号</value>
        [DataMember(Name = "order_no", EmitDefaultValue = false)]
        public string OrderNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniIsvCreateResponseModel {\n");
            sb.Append("  OrderNo: ").Append(OrderNo).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniIsvCreateResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniIsvCreateResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniIsvCreateResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniIsvCreateResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OrderNo == input.OrderNo ||
                    (this.OrderNo != null &&
                    this.OrderNo.Equals(input.OrderNo))
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
                if (this.OrderNo != null)
                {
                    hashCode = (hashCode * 59) + this.OrderNo.GetHashCode();
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
