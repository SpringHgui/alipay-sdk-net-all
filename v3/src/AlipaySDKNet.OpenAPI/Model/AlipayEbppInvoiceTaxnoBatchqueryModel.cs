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
    /// AlipayEbppInvoiceTaxnoBatchqueryModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceTaxnoBatchqueryModel")]
    public partial class AlipayEbppInvoiceTaxnoBatchqueryModel : IEquatable<AlipayEbppInvoiceTaxnoBatchqueryModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceTaxnoBatchqueryModel" /> class.
        /// </summary>
        /// <param name="enableTradeOut">默认值为false。true为输出交易信息，false为不输出交易信息。.</param>
        /// <param name="endInvoiceDate">查询结束时间，精确到天（按开票日期查询） start_invoice_date和end_invoice_date传值要求 1.同时为空时，返回最近半年200条数据 2.必须同时为空 或 同时不为空 3.结束日期不能大于当前日期 4.开始时间和结束时间跨度不能超过6个月.</param>
        /// <param name="invoiceKindList">查询票种列表.</param>
        /// <param name="limitSize">查询结果上限笔数，最大值20.</param>
        /// <param name="pageNum">当前页码，为空时默认第一页.</param>
        /// <param name="scene">发票要素获取应用场景。&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/10691/bv8s88\&quot;&gt;\&quot;拉\&quot;模式报销&lt;/a&gt; 固定为 INVOICE_EXPENSE 表示发票报销。.</param>
        /// <param name="startInvoiceDate">查询起始时间，精确到天（按开票日期查询） start_invoice_date和end_invoice_date传值要求 1.同时为空时，返回最近半年200条数据 2.必须同时为空 或 同时不为空 3.结束日期不能大于当前日期 4.开始时间和结束时间跨度不能超过6个月.</param>
        /// <param name="taxNo">企业税号.</param>
        public AlipayEbppInvoiceTaxnoBatchqueryModel(string enableTradeOut = default(string), string endInvoiceDate = default(string), List<string> invoiceKindList = default(List<string>), int limitSize = default(int), int pageNum = default(int), string scene = default(string), string startInvoiceDate = default(string), string taxNo = default(string))
        {
            this.EnableTradeOut = enableTradeOut;
            this.EndInvoiceDate = endInvoiceDate;
            this.InvoiceKindList = invoiceKindList;
            this.LimitSize = limitSize;
            this.PageNum = pageNum;
            this.Scene = scene;
            this.StartInvoiceDate = startInvoiceDate;
            this.TaxNo = taxNo;
        }

        /// <summary>
        /// 默认值为false。true为输出交易信息，false为不输出交易信息。
        /// </summary>
        /// <value>默认值为false。true为输出交易信息，false为不输出交易信息。</value>
        [DataMember(Name = "enable_trade_out", EmitDefaultValue = false)]
        public string EnableTradeOut { get; set; }

        /// <summary>
        /// 查询结束时间，精确到天（按开票日期查询） start_invoice_date和end_invoice_date传值要求 1.同时为空时，返回最近半年200条数据 2.必须同时为空 或 同时不为空 3.结束日期不能大于当前日期 4.开始时间和结束时间跨度不能超过6个月
        /// </summary>
        /// <value>查询结束时间，精确到天（按开票日期查询） start_invoice_date和end_invoice_date传值要求 1.同时为空时，返回最近半年200条数据 2.必须同时为空 或 同时不为空 3.结束日期不能大于当前日期 4.开始时间和结束时间跨度不能超过6个月</value>
        [DataMember(Name = "end_invoice_date", EmitDefaultValue = false)]
        public string EndInvoiceDate { get; set; }

        /// <summary>
        /// 查询票种列表
        /// </summary>
        /// <value>查询票种列表</value>
        [DataMember(Name = "invoice_kind_list", EmitDefaultValue = false)]
        public List<string> InvoiceKindList { get; set; }

        /// <summary>
        /// 查询结果上限笔数，最大值20
        /// </summary>
        /// <value>查询结果上限笔数，最大值20</value>
        [DataMember(Name = "limit_size", EmitDefaultValue = false)]
        public int LimitSize { get; set; }

        /// <summary>
        /// 当前页码，为空时默认第一页
        /// </summary>
        /// <value>当前页码，为空时默认第一页</value>
        [DataMember(Name = "page_num", EmitDefaultValue = false)]
        public int PageNum { get; set; }

        /// <summary>
        /// 发票要素获取应用场景。&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/10691/bv8s88\&quot;&gt;\&quot;拉\&quot;模式报销&lt;/a&gt; 固定为 INVOICE_EXPENSE 表示发票报销。
        /// </summary>
        /// <value>发票要素获取应用场景。&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/10691/bv8s88\&quot;&gt;\&quot;拉\&quot;模式报销&lt;/a&gt; 固定为 INVOICE_EXPENSE 表示发票报销。</value>
        [DataMember(Name = "scene", EmitDefaultValue = false)]
        public string Scene { get; set; }

        /// <summary>
        /// 查询起始时间，精确到天（按开票日期查询） start_invoice_date和end_invoice_date传值要求 1.同时为空时，返回最近半年200条数据 2.必须同时为空 或 同时不为空 3.结束日期不能大于当前日期 4.开始时间和结束时间跨度不能超过6个月
        /// </summary>
        /// <value>查询起始时间，精确到天（按开票日期查询） start_invoice_date和end_invoice_date传值要求 1.同时为空时，返回最近半年200条数据 2.必须同时为空 或 同时不为空 3.结束日期不能大于当前日期 4.开始时间和结束时间跨度不能超过6个月</value>
        [DataMember(Name = "start_invoice_date", EmitDefaultValue = false)]
        public string StartInvoiceDate { get; set; }

        /// <summary>
        /// 企业税号
        /// </summary>
        /// <value>企业税号</value>
        [DataMember(Name = "tax_no", EmitDefaultValue = false)]
        public string TaxNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceTaxnoBatchqueryModel {\n");
            sb.Append("  EnableTradeOut: ").Append(EnableTradeOut).Append("\n");
            sb.Append("  EndInvoiceDate: ").Append(EndInvoiceDate).Append("\n");
            sb.Append("  InvoiceKindList: ").Append(InvoiceKindList).Append("\n");
            sb.Append("  LimitSize: ").Append(LimitSize).Append("\n");
            sb.Append("  PageNum: ").Append(PageNum).Append("\n");
            sb.Append("  Scene: ").Append(Scene).Append("\n");
            sb.Append("  StartInvoiceDate: ").Append(StartInvoiceDate).Append("\n");
            sb.Append("  TaxNo: ").Append(TaxNo).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceTaxnoBatchqueryModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceTaxnoBatchqueryModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceTaxnoBatchqueryModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceTaxnoBatchqueryModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EnableTradeOut == input.EnableTradeOut ||
                    (this.EnableTradeOut != null &&
                    this.EnableTradeOut.Equals(input.EnableTradeOut))
                ) && 
                (
                    this.EndInvoiceDate == input.EndInvoiceDate ||
                    (this.EndInvoiceDate != null &&
                    this.EndInvoiceDate.Equals(input.EndInvoiceDate))
                ) && 
                (
                    this.InvoiceKindList == input.InvoiceKindList ||
                    this.InvoiceKindList != null &&
                    input.InvoiceKindList != null &&
                    this.InvoiceKindList.SequenceEqual(input.InvoiceKindList)
                ) && 
                (
                    this.LimitSize == input.LimitSize ||
                    this.LimitSize.Equals(input.LimitSize)
                ) && 
                (
                    this.PageNum == input.PageNum ||
                    this.PageNum.Equals(input.PageNum)
                ) && 
                (
                    this.Scene == input.Scene ||
                    (this.Scene != null &&
                    this.Scene.Equals(input.Scene))
                ) && 
                (
                    this.StartInvoiceDate == input.StartInvoiceDate ||
                    (this.StartInvoiceDate != null &&
                    this.StartInvoiceDate.Equals(input.StartInvoiceDate))
                ) && 
                (
                    this.TaxNo == input.TaxNo ||
                    (this.TaxNo != null &&
                    this.TaxNo.Equals(input.TaxNo))
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
                if (this.EnableTradeOut != null)
                {
                    hashCode = (hashCode * 59) + this.EnableTradeOut.GetHashCode();
                }
                if (this.EndInvoiceDate != null)
                {
                    hashCode = (hashCode * 59) + this.EndInvoiceDate.GetHashCode();
                }
                if (this.InvoiceKindList != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceKindList.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LimitSize.GetHashCode();
                hashCode = (hashCode * 59) + this.PageNum.GetHashCode();
                if (this.Scene != null)
                {
                    hashCode = (hashCode * 59) + this.Scene.GetHashCode();
                }
                if (this.StartInvoiceDate != null)
                {
                    hashCode = (hashCode * 59) + this.StartInvoiceDate.GetHashCode();
                }
                if (this.TaxNo != null)
                {
                    hashCode = (hashCode * 59) + this.TaxNo.GetHashCode();
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
