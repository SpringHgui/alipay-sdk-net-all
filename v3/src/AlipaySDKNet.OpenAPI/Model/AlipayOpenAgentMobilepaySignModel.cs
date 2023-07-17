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
    /// AlipayOpenAgentMobilepaySignModel
    /// </summary>
    [DataContract(Name = "AlipayOpenAgentMobilepaySignModel")]
    public partial class AlipayOpenAgentMobilepaySignModel : IEquatable<AlipayOpenAgentMobilepaySignModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenAgentMobilepaySignModel" /> class.
        /// </summary>
        /// <param name="appMarket">应用在哪些市场上架，枚举值为：苹果,应用宝,豌豆荚,其他.</param>
        /// <param name="appName">商户的APP应用名称.</param>
        /// <param name="appStatus">应用上架状态，枚举值为 已上架，未上架.</param>
        /// <param name="appTestAccount">可以登录该应用的测试账户.</param>
        /// <param name="appTestAccountPassword">可以登录此应用的账户的密码。对应app_test_account的登录密码.</param>
        /// <param name="appType">应用类型，枚举值为：IOS，安卓.</param>
        /// <param name="batchNo">代商户操作事务编号，通过alipay.open.isv.agent.create接口进行创建。.</param>
        /// <param name="businessLicenseMobile">营业执照法人手机号码.</param>
        /// <param name="businessLicenseNo">营业执照号码。.</param>
        /// <param name="dateLimitation">营业期限.</param>
        /// <param name="downloadLink">应用下载链接.</param>
        /// <param name="longTerm">营业期限是否长期有效.</param>
        /// <param name="mccCode">所属MCCCode，详情可参考 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/01n22g#%E5%95%86%E5%AE%B6%E7%BB%8F%E8%90%A5%E7%B1%BB%E7%9B%AE\&quot;&gt;商家经营类目&lt;/a&gt; 中的“经营类目编码”.</param>
        public AlipayOpenAgentMobilepaySignModel(List<string> appMarket = default(List<string>), string appName = default(string), string appStatus = default(string), string appTestAccount = default(string), string appTestAccountPassword = default(string), List<string> appType = default(List<string>), string batchNo = default(string), string businessLicenseMobile = default(string), string businessLicenseNo = default(string), string dateLimitation = default(string), string downloadLink = default(string), bool longTerm = default(bool), string mccCode = default(string))
        {
            this.AppMarket = appMarket;
            this.AppName = appName;
            this.AppStatus = appStatus;
            this.AppTestAccount = appTestAccount;
            this.AppTestAccountPassword = appTestAccountPassword;
            this.AppType = appType;
            this.BatchNo = batchNo;
            this.BusinessLicenseMobile = businessLicenseMobile;
            this.BusinessLicenseNo = businessLicenseNo;
            this.DateLimitation = dateLimitation;
            this.DownloadLink = downloadLink;
            this.LongTerm = longTerm;
            this.MccCode = mccCode;
        }

        /// <summary>
        /// 应用在哪些市场上架，枚举值为：苹果,应用宝,豌豆荚,其他
        /// </summary>
        /// <value>应用在哪些市场上架，枚举值为：苹果,应用宝,豌豆荚,其他</value>
        [DataMember(Name = "app_market", EmitDefaultValue = false)]
        public List<string> AppMarket { get; set; }

        /// <summary>
        /// 商户的APP应用名称
        /// </summary>
        /// <value>商户的APP应用名称</value>
        [DataMember(Name = "app_name", EmitDefaultValue = false)]
        public string AppName { get; set; }

        /// <summary>
        /// 应用上架状态，枚举值为 已上架，未上架
        /// </summary>
        /// <value>应用上架状态，枚举值为 已上架，未上架</value>
        [DataMember(Name = "app_status", EmitDefaultValue = false)]
        public string AppStatus { get; set; }

        /// <summary>
        /// 可以登录该应用的测试账户
        /// </summary>
        /// <value>可以登录该应用的测试账户</value>
        [DataMember(Name = "app_test_account", EmitDefaultValue = false)]
        public string AppTestAccount { get; set; }

        /// <summary>
        /// 可以登录此应用的账户的密码。对应app_test_account的登录密码
        /// </summary>
        /// <value>可以登录此应用的账户的密码。对应app_test_account的登录密码</value>
        [DataMember(Name = "app_test_account_password", EmitDefaultValue = false)]
        public string AppTestAccountPassword { get; set; }

        /// <summary>
        /// 应用类型，枚举值为：IOS，安卓
        /// </summary>
        /// <value>应用类型，枚举值为：IOS，安卓</value>
        [DataMember(Name = "app_type", EmitDefaultValue = false)]
        public List<string> AppType { get; set; }

        /// <summary>
        /// 代商户操作事务编号，通过alipay.open.isv.agent.create接口进行创建。
        /// </summary>
        /// <value>代商户操作事务编号，通过alipay.open.isv.agent.create接口进行创建。</value>
        [DataMember(Name = "batch_no", EmitDefaultValue = false)]
        public string BatchNo { get; set; }

        /// <summary>
        /// 营业执照法人手机号码
        /// </summary>
        /// <value>营业执照法人手机号码</value>
        [DataMember(Name = "business_license_mobile", EmitDefaultValue = false)]
        public string BusinessLicenseMobile { get; set; }

        /// <summary>
        /// 营业执照号码。
        /// </summary>
        /// <value>营业执照号码。</value>
        [DataMember(Name = "business_license_no", EmitDefaultValue = false)]
        public string BusinessLicenseNo { get; set; }

        /// <summary>
        /// 营业期限
        /// </summary>
        /// <value>营业期限</value>
        [DataMember(Name = "date_limitation", EmitDefaultValue = false)]
        public string DateLimitation { get; set; }

        /// <summary>
        /// 应用下载链接
        /// </summary>
        /// <value>应用下载链接</value>
        [DataMember(Name = "download_link", EmitDefaultValue = false)]
        public string DownloadLink { get; set; }

        /// <summary>
        /// 营业期限是否长期有效
        /// </summary>
        /// <value>营业期限是否长期有效</value>
        [DataMember(Name = "long_term", EmitDefaultValue = true)]
        public bool LongTerm { get; set; }

        /// <summary>
        /// 所属MCCCode，详情可参考 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/01n22g#%E5%95%86%E5%AE%B6%E7%BB%8F%E8%90%A5%E7%B1%BB%E7%9B%AE\&quot;&gt;商家经营类目&lt;/a&gt; 中的“经营类目编码”
        /// </summary>
        /// <value>所属MCCCode，详情可参考 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/01n22g#%E5%95%86%E5%AE%B6%E7%BB%8F%E8%90%A5%E7%B1%BB%E7%9B%AE\&quot;&gt;商家经营类目&lt;/a&gt; 中的“经营类目编码”</value>
        [DataMember(Name = "mcc_code", EmitDefaultValue = false)]
        public string MccCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenAgentMobilepaySignModel {\n");
            sb.Append("  AppMarket: ").Append(AppMarket).Append("\n");
            sb.Append("  AppName: ").Append(AppName).Append("\n");
            sb.Append("  AppStatus: ").Append(AppStatus).Append("\n");
            sb.Append("  AppTestAccount: ").Append(AppTestAccount).Append("\n");
            sb.Append("  AppTestAccountPassword: ").Append(AppTestAccountPassword).Append("\n");
            sb.Append("  AppType: ").Append(AppType).Append("\n");
            sb.Append("  BatchNo: ").Append(BatchNo).Append("\n");
            sb.Append("  BusinessLicenseMobile: ").Append(BusinessLicenseMobile).Append("\n");
            sb.Append("  BusinessLicenseNo: ").Append(BusinessLicenseNo).Append("\n");
            sb.Append("  DateLimitation: ").Append(DateLimitation).Append("\n");
            sb.Append("  DownloadLink: ").Append(DownloadLink).Append("\n");
            sb.Append("  LongTerm: ").Append(LongTerm).Append("\n");
            sb.Append("  MccCode: ").Append(MccCode).Append("\n");
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
            return this.Equals(input as AlipayOpenAgentMobilepaySignModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenAgentMobilepaySignModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenAgentMobilepaySignModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenAgentMobilepaySignModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AppMarket == input.AppMarket ||
                    this.AppMarket != null &&
                    input.AppMarket != null &&
                    this.AppMarket.SequenceEqual(input.AppMarket)
                ) && 
                (
                    this.AppName == input.AppName ||
                    (this.AppName != null &&
                    this.AppName.Equals(input.AppName))
                ) && 
                (
                    this.AppStatus == input.AppStatus ||
                    (this.AppStatus != null &&
                    this.AppStatus.Equals(input.AppStatus))
                ) && 
                (
                    this.AppTestAccount == input.AppTestAccount ||
                    (this.AppTestAccount != null &&
                    this.AppTestAccount.Equals(input.AppTestAccount))
                ) && 
                (
                    this.AppTestAccountPassword == input.AppTestAccountPassword ||
                    (this.AppTestAccountPassword != null &&
                    this.AppTestAccountPassword.Equals(input.AppTestAccountPassword))
                ) && 
                (
                    this.AppType == input.AppType ||
                    this.AppType != null &&
                    input.AppType != null &&
                    this.AppType.SequenceEqual(input.AppType)
                ) && 
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
                    this.DownloadLink == input.DownloadLink ||
                    (this.DownloadLink != null &&
                    this.DownloadLink.Equals(input.DownloadLink))
                ) && 
                (
                    this.LongTerm == input.LongTerm ||
                    this.LongTerm.Equals(input.LongTerm)
                ) && 
                (
                    this.MccCode == input.MccCode ||
                    (this.MccCode != null &&
                    this.MccCode.Equals(input.MccCode))
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
                if (this.AppMarket != null)
                {
                    hashCode = (hashCode * 59) + this.AppMarket.GetHashCode();
                }
                if (this.AppName != null)
                {
                    hashCode = (hashCode * 59) + this.AppName.GetHashCode();
                }
                if (this.AppStatus != null)
                {
                    hashCode = (hashCode * 59) + this.AppStatus.GetHashCode();
                }
                if (this.AppTestAccount != null)
                {
                    hashCode = (hashCode * 59) + this.AppTestAccount.GetHashCode();
                }
                if (this.AppTestAccountPassword != null)
                {
                    hashCode = (hashCode * 59) + this.AppTestAccountPassword.GetHashCode();
                }
                if (this.AppType != null)
                {
                    hashCode = (hashCode * 59) + this.AppType.GetHashCode();
                }
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
                if (this.DownloadLink != null)
                {
                    hashCode = (hashCode * 59) + this.DownloadLink.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LongTerm.GetHashCode();
                if (this.MccCode != null)
                {
                    hashCode = (hashCode * 59) + this.MccCode.GetHashCode();
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
