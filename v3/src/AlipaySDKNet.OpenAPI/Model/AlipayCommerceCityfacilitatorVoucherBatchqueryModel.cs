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
    /// AlipayCommerceCityfacilitatorVoucherBatchqueryModel
    /// </summary>
    [DataContract(Name = "AlipayCommerceCityfacilitatorVoucherBatchqueryModel")]
    public partial class AlipayCommerceCityfacilitatorVoucherBatchqueryModel : IEquatable<AlipayCommerceCityfacilitatorVoucherBatchqueryModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceCityfacilitatorVoucherBatchqueryModel" /> class.
        /// </summary>
        /// <param name="cityCode">城市编码请参考查询 &lt;a href&#x3D;\&quot;http://www.mca.gov.cn/article/sj/xzqh/\&quot;&gt;中华人民共和国行政区划代码&lt;/a&gt;。 已支持城市：广州 440100，深圳 440300，杭州330100。.</param>
        /// <param name="tradeNos">支付宝交易号列表.</param>
        public AlipayCommerceCityfacilitatorVoucherBatchqueryModel(string cityCode = default(string), List<string> tradeNos = default(List<string>))
        {
            this.CityCode = cityCode;
            this.TradeNos = tradeNos;
        }

        /// <summary>
        /// 城市编码请参考查询 &lt;a href&#x3D;\&quot;http://www.mca.gov.cn/article/sj/xzqh/\&quot;&gt;中华人民共和国行政区划代码&lt;/a&gt;。 已支持城市：广州 440100，深圳 440300，杭州330100。
        /// </summary>
        /// <value>城市编码请参考查询 &lt;a href&#x3D;\&quot;http://www.mca.gov.cn/article/sj/xzqh/\&quot;&gt;中华人民共和国行政区划代码&lt;/a&gt;。 已支持城市：广州 440100，深圳 440300，杭州330100。</value>
        [DataMember(Name = "city_code", EmitDefaultValue = false)]
        public string CityCode { get; set; }

        /// <summary>
        /// 支付宝交易号列表
        /// </summary>
        /// <value>支付宝交易号列表</value>
        [DataMember(Name = "trade_nos", EmitDefaultValue = false)]
        public List<string> TradeNos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayCommerceCityfacilitatorVoucherBatchqueryModel {\n");
            sb.Append("  CityCode: ").Append(CityCode).Append("\n");
            sb.Append("  TradeNos: ").Append(TradeNos).Append("\n");
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
            return this.Equals(input as AlipayCommerceCityfacilitatorVoucherBatchqueryModel);
        }

        /// <summary>
        /// Returns true if AlipayCommerceCityfacilitatorVoucherBatchqueryModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayCommerceCityfacilitatorVoucherBatchqueryModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayCommerceCityfacilitatorVoucherBatchqueryModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CityCode == input.CityCode ||
                    (this.CityCode != null &&
                    this.CityCode.Equals(input.CityCode))
                ) && 
                (
                    this.TradeNos == input.TradeNos ||
                    this.TradeNos != null &&
                    input.TradeNos != null &&
                    this.TradeNos.SequenceEqual(input.TradeNos)
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
                if (this.CityCode != null)
                {
                    hashCode = (hashCode * 59) + this.CityCode.GetHashCode();
                }
                if (this.TradeNos != null)
                {
                    hashCode = (hashCode * 59) + this.TradeNos.GetHashCode();
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
