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
    /// AlipayMerchantIndirectAuthorderCloseModel
    /// </summary>
    [DataContract(Name = "AlipayMerchantIndirectAuthorderCloseModel")]
    public partial class AlipayMerchantIndirectAuthorderCloseModel : IEquatable<AlipayMerchantIndirectAuthorderCloseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMerchantIndirectAuthorderCloseModel" /> class.
        /// </summary>
        /// <param name="orderNo">意愿申请单号，参数二选一.</param>
        /// <param name="outBizNo">外部业务号，参数二选一，业务自定义，保证唯一.</param>
        public AlipayMerchantIndirectAuthorderCloseModel(string orderNo = default(string), string outBizNo = default(string))
        {
            this.OrderNo = orderNo;
            this.OutBizNo = outBizNo;
        }

        /// <summary>
        /// 意愿申请单号，参数二选一
        /// </summary>
        /// <value>意愿申请单号，参数二选一</value>
        [DataMember(Name = "order_no", EmitDefaultValue = false)]
        public string OrderNo { get; set; }

        /// <summary>
        /// 外部业务号，参数二选一，业务自定义，保证唯一
        /// </summary>
        /// <value>外部业务号，参数二选一，业务自定义，保证唯一</value>
        [DataMember(Name = "out_biz_no", EmitDefaultValue = false)]
        public string OutBizNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMerchantIndirectAuthorderCloseModel {\n");
            sb.Append("  OrderNo: ").Append(OrderNo).Append("\n");
            sb.Append("  OutBizNo: ").Append(OutBizNo).Append("\n");
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
            return this.Equals(input as AlipayMerchantIndirectAuthorderCloseModel);
        }

        /// <summary>
        /// Returns true if AlipayMerchantIndirectAuthorderCloseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMerchantIndirectAuthorderCloseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMerchantIndirectAuthorderCloseModel input)
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
                ) && 
                (
                    this.OutBizNo == input.OutBizNo ||
                    (this.OutBizNo != null &&
                    this.OutBizNo.Equals(input.OutBizNo))
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
                if (this.OutBizNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutBizNo.GetHashCode();
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
