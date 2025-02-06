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
    /// AlipayCommerceEcEnterpriseAddressQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayCommerceEcEnterpriseAddressQueryResponseModel")]
    public partial class AlipayCommerceEcEnterpriseAddressQueryResponseModel : IEquatable<AlipayCommerceEcEnterpriseAddressQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceEcEnterpriseAddressQueryResponseModel" /> class.
        /// </summary>
        /// <param name="currentPage">页码.</param>
        /// <param name="enterpriseAddressInfoList">地址列表.</param>
        /// <param name="totalNum">总数量.</param>
        /// <param name="totalPages">总页数.</param>
        public AlipayCommerceEcEnterpriseAddressQueryResponseModel(int currentPage = default(int), List<AddressInfoDTO> enterpriseAddressInfoList = default(List<AddressInfoDTO>), int totalNum = default(int), int totalPages = default(int))
        {
            this.CurrentPage = currentPage;
            this.EnterpriseAddressInfoList = enterpriseAddressInfoList;
            this.TotalNum = totalNum;
            this.TotalPages = totalPages;
        }

        /// <summary>
        /// 页码
        /// </summary>
        /// <value>页码</value>
        [DataMember(Name = "current_page", EmitDefaultValue = false)]
        public int CurrentPage { get; set; }

        /// <summary>
        /// 地址列表
        /// </summary>
        /// <value>地址列表</value>
        [DataMember(Name = "enterprise_address_info_list", EmitDefaultValue = false)]
        public List<AddressInfoDTO> EnterpriseAddressInfoList { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        /// <value>总数量</value>
        [DataMember(Name = "total_num", EmitDefaultValue = false)]
        public int TotalNum { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        /// <value>总页数</value>
        [DataMember(Name = "total_pages", EmitDefaultValue = false)]
        public int TotalPages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayCommerceEcEnterpriseAddressQueryResponseModel {\n");
            sb.Append("  CurrentPage: ").Append(CurrentPage).Append("\n");
            sb.Append("  EnterpriseAddressInfoList: ").Append(EnterpriseAddressInfoList).Append("\n");
            sb.Append("  TotalNum: ").Append(TotalNum).Append("\n");
            sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
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
            return this.Equals(input as AlipayCommerceEcEnterpriseAddressQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayCommerceEcEnterpriseAddressQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayCommerceEcEnterpriseAddressQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayCommerceEcEnterpriseAddressQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CurrentPage == input.CurrentPage ||
                    this.CurrentPage.Equals(input.CurrentPage)
                ) && 
                (
                    this.EnterpriseAddressInfoList == input.EnterpriseAddressInfoList ||
                    this.EnterpriseAddressInfoList != null &&
                    input.EnterpriseAddressInfoList != null &&
                    this.EnterpriseAddressInfoList.SequenceEqual(input.EnterpriseAddressInfoList)
                ) && 
                (
                    this.TotalNum == input.TotalNum ||
                    this.TotalNum.Equals(input.TotalNum)
                ) && 
                (
                    this.TotalPages == input.TotalPages ||
                    this.TotalPages.Equals(input.TotalPages)
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
                hashCode = (hashCode * 59) + this.CurrentPage.GetHashCode();
                if (this.EnterpriseAddressInfoList != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseAddressInfoList.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalNum.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalPages.GetHashCode();
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
