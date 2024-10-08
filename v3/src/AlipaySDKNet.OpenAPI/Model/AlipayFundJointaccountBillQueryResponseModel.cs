/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2024-10-08
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
    /// AlipayFundJointaccountBillQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayFundJointaccountBillQueryResponseModel")]
    public partial class AlipayFundJointaccountBillQueryResponseModel : IEquatable<AlipayFundJointaccountBillQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundJointaccountBillQueryResponseModel" /> class.
        /// </summary>
        /// <param name="billList">返回账单列表。账单列表为空时，返回为空.</param>
        /// <param name="bizScene">场景.</param>
        /// <param name="hasNextPage">是否有下一页.</param>
        /// <param name="pageNum">当期页数.</param>
        /// <param name="pageSize">当期页记录数.</param>
        /// <param name="productCode">产品码.</param>
        public AlipayFundJointaccountBillQueryResponseModel(List<JointAccountBillDetailDTO> billList = default(List<JointAccountBillDetailDTO>), string bizScene = default(string), bool hasNextPage = default(bool), string pageNum = default(string), string pageSize = default(string), string productCode = default(string))
        {
            this.BillList = billList;
            this.BizScene = bizScene;
            this.HasNextPage = hasNextPage;
            this.PageNum = pageNum;
            this.PageSize = pageSize;
            this.ProductCode = productCode;
        }

        /// <summary>
        /// 返回账单列表。账单列表为空时，返回为空
        /// </summary>
        /// <value>返回账单列表。账单列表为空时，返回为空</value>
        [DataMember(Name = "bill_list", EmitDefaultValue = false)]
        public List<JointAccountBillDetailDTO> BillList { get; set; }

        /// <summary>
        /// 场景
        /// </summary>
        /// <value>场景</value>
        [DataMember(Name = "biz_scene", EmitDefaultValue = false)]
        public string BizScene { get; set; }

        /// <summary>
        /// 是否有下一页
        /// </summary>
        /// <value>是否有下一页</value>
        [DataMember(Name = "has_next_page", EmitDefaultValue = true)]
        public bool HasNextPage { get; set; }

        /// <summary>
        /// 当期页数
        /// </summary>
        /// <value>当期页数</value>
        [DataMember(Name = "page_num", EmitDefaultValue = false)]
        public string PageNum { get; set; }

        /// <summary>
        /// 当期页记录数
        /// </summary>
        /// <value>当期页记录数</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public string PageSize { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        /// <value>产品码</value>
        [DataMember(Name = "product_code", EmitDefaultValue = false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayFundJointaccountBillQueryResponseModel {\n");
            sb.Append("  BillList: ").Append(BillList).Append("\n");
            sb.Append("  BizScene: ").Append(BizScene).Append("\n");
            sb.Append("  HasNextPage: ").Append(HasNextPage).Append("\n");
            sb.Append("  PageNum: ").Append(PageNum).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
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
            return this.Equals(input as AlipayFundJointaccountBillQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayFundJointaccountBillQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayFundJointaccountBillQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayFundJointaccountBillQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BillList == input.BillList ||
                    this.BillList != null &&
                    input.BillList != null &&
                    this.BillList.SequenceEqual(input.BillList)
                ) && 
                (
                    this.BizScene == input.BizScene ||
                    (this.BizScene != null &&
                    this.BizScene.Equals(input.BizScene))
                ) && 
                (
                    this.HasNextPage == input.HasNextPage ||
                    this.HasNextPage.Equals(input.HasNextPage)
                ) && 
                (
                    this.PageNum == input.PageNum ||
                    (this.PageNum != null &&
                    this.PageNum.Equals(input.PageNum))
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    (this.PageSize != null &&
                    this.PageSize.Equals(input.PageSize))
                ) && 
                (
                    this.ProductCode == input.ProductCode ||
                    (this.ProductCode != null &&
                    this.ProductCode.Equals(input.ProductCode))
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
                if (this.BillList != null)
                {
                    hashCode = (hashCode * 59) + this.BillList.GetHashCode();
                }
                if (this.BizScene != null)
                {
                    hashCode = (hashCode * 59) + this.BizScene.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HasNextPage.GetHashCode();
                if (this.PageNum != null)
                {
                    hashCode = (hashCode * 59) + this.PageNum.GetHashCode();
                }
                if (this.PageSize != null)
                {
                    hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                }
                if (this.ProductCode != null)
                {
                    hashCode = (hashCode * 59) + this.ProductCode.GetHashCode();
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
