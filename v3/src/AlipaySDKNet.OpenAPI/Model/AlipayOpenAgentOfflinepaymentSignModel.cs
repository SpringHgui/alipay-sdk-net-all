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
    /// AlipayOpenAgentOfflinepaymentSignModel
    /// </summary>
    [DataContract(Name = "AlipayOpenAgentOfflinepaymentSignModel")]
    public partial class AlipayOpenAgentOfflinepaymentSignModel : IEquatable<AlipayOpenAgentOfflinepaymentSignModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenAgentOfflinepaymentSignModel" /> class.
        /// </summary>
        /// <param name="batchNo">代商户操作事务编号，通过alipay.open.agent.create接口进行创建。.</param>
        /// <param name="businessLicenseMobile">被邀请授权的营业执照法人手机号码，上传非同人营业执照时必填.</param>
        /// <param name="businessLicenseNo">营业执照号码。若填写，请与以下营业执照图片、期限、一起提供。.</param>
        /// <param name="dateLimitation">营业期限.</param>
        /// <param name="deliveryAddress">deliveryAddress.</param>
        /// <param name="longTerm">营业期限是否长期有效.</param>
        /// <param name="mccCode">所属MCCCode，可参考 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/01n22g#%E5%95%86%E5%AE%B6%E7%BB%8F%E8%90%A5%E7%B1%BB%E7%9B%AE\&quot;&gt;商家经营类目&lt;/a&gt; 中的“经营类目编码”.</param>
        /// <param name="rate">服务费率（%），0.38~3之间，精确到0.01.</param>
        /// <param name="shopAddress">shopAddress.</param>
        /// <param name="shopName">店铺名称.</param>
        public AlipayOpenAgentOfflinepaymentSignModel(string batchNo = default(string), string businessLicenseMobile = default(string), string businessLicenseNo = default(string), string dateLimitation = default(string), SignAddressInfo deliveryAddress = default(SignAddressInfo), bool longTerm = default(bool), string mccCode = default(string), string rate = default(string), SignAddressInfo shopAddress = default(SignAddressInfo), string shopName = default(string))
        {
            this.BatchNo = batchNo;
            this.BusinessLicenseMobile = businessLicenseMobile;
            this.BusinessLicenseNo = businessLicenseNo;
            this.DateLimitation = dateLimitation;
            this.DeliveryAddress = deliveryAddress;
            this.LongTerm = longTerm;
            this.MccCode = mccCode;
            this.Rate = rate;
            this.ShopAddress = shopAddress;
            this.ShopName = shopName;
        }

        /// <summary>
        /// 代商户操作事务编号，通过alipay.open.agent.create接口进行创建。
        /// </summary>
        /// <value>代商户操作事务编号，通过alipay.open.agent.create接口进行创建。</value>
        [DataMember(Name = "batch_no", EmitDefaultValue = false)]
        public string BatchNo { get; set; }

        /// <summary>
        /// 被邀请授权的营业执照法人手机号码，上传非同人营业执照时必填
        /// </summary>
        /// <value>被邀请授权的营业执照法人手机号码，上传非同人营业执照时必填</value>
        [DataMember(Name = "business_license_mobile", EmitDefaultValue = false)]
        public string BusinessLicenseMobile { get; set; }

        /// <summary>
        /// 营业执照号码。若填写，请与以下营业执照图片、期限、一起提供。
        /// </summary>
        /// <value>营业执照号码。若填写，请与以下营业执照图片、期限、一起提供。</value>
        [DataMember(Name = "business_license_no", EmitDefaultValue = false)]
        public string BusinessLicenseNo { get; set; }

        /// <summary>
        /// 营业期限
        /// </summary>
        /// <value>营业期限</value>
        [DataMember(Name = "date_limitation", EmitDefaultValue = false)]
        public string DateLimitation { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryAddress
        /// </summary>
        [DataMember(Name = "delivery_address", EmitDefaultValue = false)]
        public SignAddressInfo DeliveryAddress { get; set; }

        /// <summary>
        /// 营业期限是否长期有效
        /// </summary>
        /// <value>营业期限是否长期有效</value>
        [DataMember(Name = "long_term", EmitDefaultValue = true)]
        public bool LongTerm { get; set; }

        /// <summary>
        /// 所属MCCCode，可参考 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/01n22g#%E5%95%86%E5%AE%B6%E7%BB%8F%E8%90%A5%E7%B1%BB%E7%9B%AE\&quot;&gt;商家经营类目&lt;/a&gt; 中的“经营类目编码”
        /// </summary>
        /// <value>所属MCCCode，可参考 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/01n22g#%E5%95%86%E5%AE%B6%E7%BB%8F%E8%90%A5%E7%B1%BB%E7%9B%AE\&quot;&gt;商家经营类目&lt;/a&gt; 中的“经营类目编码”</value>
        [DataMember(Name = "mcc_code", EmitDefaultValue = false)]
        public string MccCode { get; set; }

        /// <summary>
        /// 服务费率（%），0.38~3之间，精确到0.01
        /// </summary>
        /// <value>服务费率（%），0.38~3之间，精确到0.01</value>
        [DataMember(Name = "rate", EmitDefaultValue = false)]
        public string Rate { get; set; }

        /// <summary>
        /// Gets or Sets ShopAddress
        /// </summary>
        [DataMember(Name = "shop_address", EmitDefaultValue = false)]
        public SignAddressInfo ShopAddress { get; set; }

        /// <summary>
        /// 店铺名称
        /// </summary>
        /// <value>店铺名称</value>
        [DataMember(Name = "shop_name", EmitDefaultValue = false)]
        public string ShopName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenAgentOfflinepaymentSignModel {\n");
            sb.Append("  BatchNo: ").Append(BatchNo).Append("\n");
            sb.Append("  BusinessLicenseMobile: ").Append(BusinessLicenseMobile).Append("\n");
            sb.Append("  BusinessLicenseNo: ").Append(BusinessLicenseNo).Append("\n");
            sb.Append("  DateLimitation: ").Append(DateLimitation).Append("\n");
            sb.Append("  DeliveryAddress: ").Append(DeliveryAddress).Append("\n");
            sb.Append("  LongTerm: ").Append(LongTerm).Append("\n");
            sb.Append("  MccCode: ").Append(MccCode).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  ShopAddress: ").Append(ShopAddress).Append("\n");
            sb.Append("  ShopName: ").Append(ShopName).Append("\n");
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
            return this.Equals(input as AlipayOpenAgentOfflinepaymentSignModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenAgentOfflinepaymentSignModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenAgentOfflinepaymentSignModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenAgentOfflinepaymentSignModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BatchNo == input.BatchNo ||
                    (this.BatchNo != null &&
                    this.BatchNo.Equals(input.BatchNo))
                ) && 
                (
                    this.BusinessLicenseMobile == input.BusinessLicenseMobile ||
                    (this.BusinessLicenseMobile != null &&
                    this.BusinessLicenseMobile.Equals(input.BusinessLicenseMobile))
                ) && 
                (
                    this.BusinessLicenseNo == input.BusinessLicenseNo ||
                    (this.BusinessLicenseNo != null &&
                    this.BusinessLicenseNo.Equals(input.BusinessLicenseNo))
                ) && 
                (
                    this.DateLimitation == input.DateLimitation ||
                    (this.DateLimitation != null &&
                    this.DateLimitation.Equals(input.DateLimitation))
                ) && 
                (
                    this.DeliveryAddress == input.DeliveryAddress ||
                    (this.DeliveryAddress != null &&
                    this.DeliveryAddress.Equals(input.DeliveryAddress))
                ) && 
                (
                    this.LongTerm == input.LongTerm ||
                    this.LongTerm.Equals(input.LongTerm)
                ) && 
                (
                    this.MccCode == input.MccCode ||
                    (this.MccCode != null &&
                    this.MccCode.Equals(input.MccCode))
                ) && 
                (
                    this.Rate == input.Rate ||
                    (this.Rate != null &&
                    this.Rate.Equals(input.Rate))
                ) && 
                (
                    this.ShopAddress == input.ShopAddress ||
                    (this.ShopAddress != null &&
                    this.ShopAddress.Equals(input.ShopAddress))
                ) && 
                (
                    this.ShopName == input.ShopName ||
                    (this.ShopName != null &&
                    this.ShopName.Equals(input.ShopName))
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
                if (this.BatchNo != null)
                {
                    hashCode = (hashCode * 59) + this.BatchNo.GetHashCode();
                }
                if (this.BusinessLicenseMobile != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessLicenseMobile.GetHashCode();
                }
                if (this.BusinessLicenseNo != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessLicenseNo.GetHashCode();
                }
                if (this.DateLimitation != null)
                {
                    hashCode = (hashCode * 59) + this.DateLimitation.GetHashCode();
                }
                if (this.DeliveryAddress != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryAddress.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LongTerm.GetHashCode();
                if (this.MccCode != null)
                {
                    hashCode = (hashCode * 59) + this.MccCode.GetHashCode();
                }
                if (this.Rate != null)
                {
                    hashCode = (hashCode * 59) + this.Rate.GetHashCode();
                }
                if (this.ShopAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ShopAddress.GetHashCode();
                }
                if (this.ShopName != null)
                {
                    hashCode = (hashCode * 59) + this.ShopName.GetHashCode();
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
