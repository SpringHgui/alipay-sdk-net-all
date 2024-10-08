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
    /// AlipayOpenInstantdeliveryMerchantshopBatchqueryModel
    /// </summary>
    [DataContract(Name = "AlipayOpenInstantdeliveryMerchantshopBatchqueryModel")]
    public partial class AlipayOpenInstantdeliveryMerchantshopBatchqueryModel : IEquatable<AlipayOpenInstantdeliveryMerchantshopBatchqueryModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenInstantdeliveryMerchantshopBatchqueryModel" /> class.
        /// </summary>
        /// <param name="pageNo">当前页码.</param>
        /// <param name="pageSize">分页数量, 最大50。.</param>
        /// <param name="shopName">门店名称.</param>
        /// <param name="shopNo">商家门店编码。.</param>
        public AlipayOpenInstantdeliveryMerchantshopBatchqueryModel(int pageNo = default(int), int pageSize = default(int), string shopName = default(string), string shopNo = default(string))
        {
            this.PageNo = pageNo;
            this.PageSize = pageSize;
            this.ShopName = shopName;
            this.ShopNo = shopNo;
        }

        /// <summary>
        /// 当前页码
        /// </summary>
        /// <value>当前页码</value>
        [DataMember(Name = "page_no", EmitDefaultValue = false)]
        public int PageNo { get; set; }

        /// <summary>
        /// 分页数量, 最大50。
        /// </summary>
        /// <value>分页数量, 最大50。</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        /// <value>门店名称</value>
        [DataMember(Name = "shop_name", EmitDefaultValue = false)]
        public string ShopName { get; set; }

        /// <summary>
        /// 商家门店编码。
        /// </summary>
        /// <value>商家门店编码。</value>
        [DataMember(Name = "shop_no", EmitDefaultValue = false)]
        public string ShopNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenInstantdeliveryMerchantshopBatchqueryModel {\n");
            sb.Append("  PageNo: ").Append(PageNo).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  ShopName: ").Append(ShopName).Append("\n");
            sb.Append("  ShopNo: ").Append(ShopNo).Append("\n");
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
            return this.Equals(input as AlipayOpenInstantdeliveryMerchantshopBatchqueryModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenInstantdeliveryMerchantshopBatchqueryModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenInstantdeliveryMerchantshopBatchqueryModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenInstantdeliveryMerchantshopBatchqueryModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PageNo == input.PageNo ||
                    this.PageNo.Equals(input.PageNo)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
                ) && 
                (
                    this.ShopName == input.ShopName ||
                    (this.ShopName != null &&
                    this.ShopName.Equals(input.ShopName))
                ) && 
                (
                    this.ShopNo == input.ShopNo ||
                    (this.ShopNo != null &&
                    this.ShopNo.Equals(input.ShopNo))
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
                hashCode = (hashCode * 59) + this.PageNo.GetHashCode();
                hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                if (this.ShopName != null)
                {
                    hashCode = (hashCode * 59) + this.ShopName.GetHashCode();
                }
                if (this.ShopNo != null)
                {
                    hashCode = (hashCode * 59) + this.ShopNo.GetHashCode();
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
