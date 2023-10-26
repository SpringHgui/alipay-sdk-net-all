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
    /// AlipayEbppInvoiceExpenserulesEmployeerulesQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceExpenserulesEmployeerulesQueryResponseModel")]
    public partial class AlipayEbppInvoiceExpenserulesEmployeerulesQueryResponseModel : IEquatable<AlipayEbppInvoiceExpenserulesEmployeerulesQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceExpenserulesEmployeerulesQueryResponseModel" /> class.
        /// </summary>
        /// <param name="employeeRules">员工已绑定费控规则列表.</param>
        /// <param name="pageNum">客户端输入的页码.</param>
        /// <param name="pageSize">客户端输入的每页行数.</param>
        /// <param name="totalCount">查询到的实例总数.</param>
        public AlipayEbppInvoiceExpenserulesEmployeerulesQueryResponseModel(List<ExpenseCtrlEmployeeRuleInfo> employeeRules = default(List<ExpenseCtrlEmployeeRuleInfo>), int pageNum = default(int), int pageSize = default(int), int totalCount = default(int))
        {
            this.EmployeeRules = employeeRules;
            this.PageNum = pageNum;
            this.PageSize = pageSize;
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// 员工已绑定费控规则列表
        /// </summary>
        /// <value>员工已绑定费控规则列表</value>
        [DataMember(Name = "employee_rules", EmitDefaultValue = false)]
        public List<ExpenseCtrlEmployeeRuleInfo> EmployeeRules { get; set; }

        /// <summary>
        /// 客户端输入的页码
        /// </summary>
        /// <value>客户端输入的页码</value>
        [DataMember(Name = "page_num", EmitDefaultValue = false)]
        public int PageNum { get; set; }

        /// <summary>
        /// 客户端输入的每页行数
        /// </summary>
        /// <value>客户端输入的每页行数</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// 查询到的实例总数
        /// </summary>
        /// <value>查询到的实例总数</value>
        [DataMember(Name = "total_count", EmitDefaultValue = false)]
        public int TotalCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceExpenserulesEmployeerulesQueryResponseModel {\n");
            sb.Append("  EmployeeRules: ").Append(EmployeeRules).Append("\n");
            sb.Append("  PageNum: ").Append(PageNum).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceExpenserulesEmployeerulesQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceExpenserulesEmployeerulesQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceExpenserulesEmployeerulesQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceExpenserulesEmployeerulesQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EmployeeRules == input.EmployeeRules ||
                    this.EmployeeRules != null &&
                    input.EmployeeRules != null &&
                    this.EmployeeRules.SequenceEqual(input.EmployeeRules)
                ) && 
                (
                    this.PageNum == input.PageNum ||
                    this.PageNum.Equals(input.PageNum)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    this.TotalCount.Equals(input.TotalCount)
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
                if (this.EmployeeRules != null)
                {
                    hashCode = (hashCode * 59) + this.EmployeeRules.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PageNum.GetHashCode();
                hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalCount.GetHashCode();
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
