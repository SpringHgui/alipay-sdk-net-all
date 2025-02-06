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
    /// AlipayFundAuthOperationCancelModel
    /// </summary>
    [DataContract(Name = "AlipayFundAuthOperationCancelModel")]
    public partial class AlipayFundAuthOperationCancelModel : IEquatable<AlipayFundAuthOperationCancelModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundAuthOperationCancelModel" /> class.
        /// </summary>
        /// <param name="authNo">支付宝授权资金订单号。 与商户的授权资金订单号不能同时为空，二者都传入时，以支付宝资金授权订单号为准，该参数与支付宝授权资金操作流水号配对使用。.</param>
        /// <param name="notifyUrl">通知地址.</param>
        /// <param name="operationId">支付宝的授权资金操作流水号。 与商户的授权资金操作流水号不能同时为空，二者都传入时，以支付宝的授权资金操作流水号为准，该参数与支付宝授权资金订单号配对使用。.</param>
        /// <param name="outOrderNo">商户的授权资金订单号。 与支付宝的授权资金订单号不能同时为空，二者都传入时，以支付宝的授权资金订单号为准，该参数与商户的授权资金操作流水号配对使用。 该值与资金冻结时 out_order_no一致。.</param>
        /// <param name="outRequestNo">商户的授权资金操作流水号。 与支付宝的授权资金操作流水号不能同时为空，二者都传入时，以支付宝的授权资金操作流水号为准，该参数与商户的授权资金订单号配对使用。 该值与资金冻结时out_request_no一致.</param>
        /// <param name="remark">商户对本次撤销操作的附言描述。 长度不超过100个字母或50个汉字。.</param>
        public AlipayFundAuthOperationCancelModel(string authNo = default(string), string notifyUrl = default(string), string operationId = default(string), string outOrderNo = default(string), string outRequestNo = default(string), string remark = default(string))
        {
            this.AuthNo = authNo;
            this.NotifyUrl = notifyUrl;
            this.OperationId = operationId;
            this.OutOrderNo = outOrderNo;
            this.OutRequestNo = outRequestNo;
            this.Remark = remark;
        }

        /// <summary>
        /// 支付宝授权资金订单号。 与商户的授权资金订单号不能同时为空，二者都传入时，以支付宝资金授权订单号为准，该参数与支付宝授权资金操作流水号配对使用。
        /// </summary>
        /// <value>支付宝授权资金订单号。 与商户的授权资金订单号不能同时为空，二者都传入时，以支付宝资金授权订单号为准，该参数与支付宝授权资金操作流水号配对使用。</value>
        [DataMember(Name = "auth_no", EmitDefaultValue = false)]
        public string AuthNo { get; set; }

        /// <summary>
        /// 通知地址
        /// </summary>
        /// <value>通知地址</value>
        [DataMember(Name = "notify_url", EmitDefaultValue = false)]
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 支付宝的授权资金操作流水号。 与商户的授权资金操作流水号不能同时为空，二者都传入时，以支付宝的授权资金操作流水号为准，该参数与支付宝授权资金订单号配对使用。
        /// </summary>
        /// <value>支付宝的授权资金操作流水号。 与商户的授权资金操作流水号不能同时为空，二者都传入时，以支付宝的授权资金操作流水号为准，该参数与支付宝授权资金订单号配对使用。</value>
        [DataMember(Name = "operation_id", EmitDefaultValue = false)]
        public string OperationId { get; set; }

        /// <summary>
        /// 商户的授权资金订单号。 与支付宝的授权资金订单号不能同时为空，二者都传入时，以支付宝的授权资金订单号为准，该参数与商户的授权资金操作流水号配对使用。 该值与资金冻结时 out_order_no一致。
        /// </summary>
        /// <value>商户的授权资金订单号。 与支付宝的授权资金订单号不能同时为空，二者都传入时，以支付宝的授权资金订单号为准，该参数与商户的授权资金操作流水号配对使用。 该值与资金冻结时 out_order_no一致。</value>
        [DataMember(Name = "out_order_no", EmitDefaultValue = false)]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 商户的授权资金操作流水号。 与支付宝的授权资金操作流水号不能同时为空，二者都传入时，以支付宝的授权资金操作流水号为准，该参数与商户的授权资金订单号配对使用。 该值与资金冻结时out_request_no一致
        /// </summary>
        /// <value>商户的授权资金操作流水号。 与支付宝的授权资金操作流水号不能同时为空，二者都传入时，以支付宝的授权资金操作流水号为准，该参数与商户的授权资金订单号配对使用。 该值与资金冻结时out_request_no一致</value>
        [DataMember(Name = "out_request_no", EmitDefaultValue = false)]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户对本次撤销操作的附言描述。 长度不超过100个字母或50个汉字。
        /// </summary>
        /// <value>商户对本次撤销操作的附言描述。 长度不超过100个字母或50个汉字。</value>
        [DataMember(Name = "remark", EmitDefaultValue = false)]
        public string Remark { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayFundAuthOperationCancelModel {\n");
            sb.Append("  AuthNo: ").Append(AuthNo).Append("\n");
            sb.Append("  NotifyUrl: ").Append(NotifyUrl).Append("\n");
            sb.Append("  OperationId: ").Append(OperationId).Append("\n");
            sb.Append("  OutOrderNo: ").Append(OutOrderNo).Append("\n");
            sb.Append("  OutRequestNo: ").Append(OutRequestNo).Append("\n");
            sb.Append("  Remark: ").Append(Remark).Append("\n");
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
            return this.Equals(input as AlipayFundAuthOperationCancelModel);
        }

        /// <summary>
        /// Returns true if AlipayFundAuthOperationCancelModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayFundAuthOperationCancelModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayFundAuthOperationCancelModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AuthNo == input.AuthNo ||
                    (this.AuthNo != null &&
                    this.AuthNo.Equals(input.AuthNo))
                ) && 
                (
                    this.NotifyUrl == input.NotifyUrl ||
                    (this.NotifyUrl != null &&
                    this.NotifyUrl.Equals(input.NotifyUrl))
                ) && 
                (
                    this.OperationId == input.OperationId ||
                    (this.OperationId != null &&
                    this.OperationId.Equals(input.OperationId))
                ) && 
                (
                    this.OutOrderNo == input.OutOrderNo ||
                    (this.OutOrderNo != null &&
                    this.OutOrderNo.Equals(input.OutOrderNo))
                ) && 
                (
                    this.OutRequestNo == input.OutRequestNo ||
                    (this.OutRequestNo != null &&
                    this.OutRequestNo.Equals(input.OutRequestNo))
                ) && 
                (
                    this.Remark == input.Remark ||
                    (this.Remark != null &&
                    this.Remark.Equals(input.Remark))
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
                if (this.AuthNo != null)
                {
                    hashCode = (hashCode * 59) + this.AuthNo.GetHashCode();
                }
                if (this.NotifyUrl != null)
                {
                    hashCode = (hashCode * 59) + this.NotifyUrl.GetHashCode();
                }
                if (this.OperationId != null)
                {
                    hashCode = (hashCode * 59) + this.OperationId.GetHashCode();
                }
                if (this.OutOrderNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutOrderNo.GetHashCode();
                }
                if (this.OutRequestNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutRequestNo.GetHashCode();
                }
                if (this.Remark != null)
                {
                    hashCode = (hashCode * 59) + this.Remark.GetHashCode();
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
