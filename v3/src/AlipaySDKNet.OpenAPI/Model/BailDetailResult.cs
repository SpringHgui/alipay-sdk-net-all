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
    /// BailDetailResult
    /// </summary>
    [DataContract(Name = "BailDetailResult")]
    public partial class BailDetailResult : IEquatable<BailDetailResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BailDetailResult" /> class.
        /// </summary>
        /// <param name="amount">保证金收支金额.</param>
        /// <param name="bailType">保证金类型描述，仅供参考.</param>
        /// <param name="balance">本次操作后的保证金余额。字段数据展示为\&quot;- -\&quot;，表明数据暂未更新，请稍等1分钟后重试。.</param>
        /// <param name="bizDesc">业务描述，资金收支对应的详细业务场景信息.</param>
        /// <param name="bizOrigNo">业务基础订单号，资金收支对应的原始业务订单唯一识别编号.</param>
        /// <param name="memo">保证金说明.</param>
        /// <param name="transDt">业务发生时间.</param>
        /// <param name="transLogId">保证金业务流水号.</param>
        public BailDetailResult(string amount = default(string), string bailType = default(string), string balance = default(string), string bizDesc = default(string), string bizOrigNo = default(string), string memo = default(string), string transDt = default(string), string transLogId = default(string))
        {
            this.Amount = amount;
            this.BailType = bailType;
            this.Balance = balance;
            this.BizDesc = bizDesc;
            this.BizOrigNo = bizOrigNo;
            this.Memo = memo;
            this.TransDt = transDt;
            this.TransLogId = transLogId;
        }

        /// <summary>
        /// 保证金收支金额
        /// </summary>
        /// <value>保证金收支金额</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// 保证金类型描述，仅供参考
        /// </summary>
        /// <value>保证金类型描述，仅供参考</value>
        [DataMember(Name = "bail_type", EmitDefaultValue = false)]
        public string BailType { get; set; }

        /// <summary>
        /// 本次操作后的保证金余额。字段数据展示为\&quot;- -\&quot;，表明数据暂未更新，请稍等1分钟后重试。
        /// </summary>
        /// <value>本次操作后的保证金余额。字段数据展示为\&quot;- -\&quot;，表明数据暂未更新，请稍等1分钟后重试。</value>
        [DataMember(Name = "balance", EmitDefaultValue = false)]
        public string Balance { get; set; }

        /// <summary>
        /// 业务描述，资金收支对应的详细业务场景信息
        /// </summary>
        /// <value>业务描述，资金收支对应的详细业务场景信息</value>
        [DataMember(Name = "biz_desc", EmitDefaultValue = false)]
        public string BizDesc { get; set; }

        /// <summary>
        /// 业务基础订单号，资金收支对应的原始业务订单唯一识别编号
        /// </summary>
        /// <value>业务基础订单号，资金收支对应的原始业务订单唯一识别编号</value>
        [DataMember(Name = "biz_orig_no", EmitDefaultValue = false)]
        public string BizOrigNo { get; set; }

        /// <summary>
        /// 保证金说明
        /// </summary>
        /// <value>保证金说明</value>
        [DataMember(Name = "memo", EmitDefaultValue = false)]
        public string Memo { get; set; }

        /// <summary>
        /// 业务发生时间
        /// </summary>
        /// <value>业务发生时间</value>
        [DataMember(Name = "trans_dt", EmitDefaultValue = false)]
        public string TransDt { get; set; }

        /// <summary>
        /// 保证金业务流水号
        /// </summary>
        /// <value>保证金业务流水号</value>
        [DataMember(Name = "trans_log_id", EmitDefaultValue = false)]
        public string TransLogId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BailDetailResult {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BailType: ").Append(BailType).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  BizDesc: ").Append(BizDesc).Append("\n");
            sb.Append("  BizOrigNo: ").Append(BizOrigNo).Append("\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
            sb.Append("  TransDt: ").Append(TransDt).Append("\n");
            sb.Append("  TransLogId: ").Append(TransLogId).Append("\n");
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
            return this.Equals(input as BailDetailResult);
        }

        /// <summary>
        /// Returns true if BailDetailResult instances are equal
        /// </summary>
        /// <param name="input">Instance of BailDetailResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BailDetailResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.BailType == input.BailType ||
                    (this.BailType != null &&
                    this.BailType.Equals(input.BailType))
                ) && 
                (
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
                ) && 
                (
                    this.BizDesc == input.BizDesc ||
                    (this.BizDesc != null &&
                    this.BizDesc.Equals(input.BizDesc))
                ) && 
                (
                    this.BizOrigNo == input.BizOrigNo ||
                    (this.BizOrigNo != null &&
                    this.BizOrigNo.Equals(input.BizOrigNo))
                ) && 
                (
                    this.Memo == input.Memo ||
                    (this.Memo != null &&
                    this.Memo.Equals(input.Memo))
                ) && 
                (
                    this.TransDt == input.TransDt ||
                    (this.TransDt != null &&
                    this.TransDt.Equals(input.TransDt))
                ) && 
                (
                    this.TransLogId == input.TransLogId ||
                    (this.TransLogId != null &&
                    this.TransLogId.Equals(input.TransLogId))
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
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.BailType != null)
                {
                    hashCode = (hashCode * 59) + this.BailType.GetHashCode();
                }
                if (this.Balance != null)
                {
                    hashCode = (hashCode * 59) + this.Balance.GetHashCode();
                }
                if (this.BizDesc != null)
                {
                    hashCode = (hashCode * 59) + this.BizDesc.GetHashCode();
                }
                if (this.BizOrigNo != null)
                {
                    hashCode = (hashCode * 59) + this.BizOrigNo.GetHashCode();
                }
                if (this.Memo != null)
                {
                    hashCode = (hashCode * 59) + this.Memo.GetHashCode();
                }
                if (this.TransDt != null)
                {
                    hashCode = (hashCode * 59) + this.TransDt.GetHashCode();
                }
                if (this.TransLogId != null)
                {
                    hashCode = (hashCode * 59) + this.TransLogId.GetHashCode();
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
