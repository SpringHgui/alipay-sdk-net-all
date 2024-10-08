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
    /// AlipayEcoMycarParkingConfigSetModel
    /// </summary>
    [DataContract(Name = "AlipayEcoMycarParkingConfigSetModel")]
    public partial class AlipayEcoMycarParkingConfigSetModel : IEquatable<AlipayEcoMycarParkingConfigSetModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEcoMycarParkingConfigSetModel" /> class.
        /// </summary>
        /// <param name="accountNo">签约支付宝账号.</param>
        /// <param name="interfaceInfoList">接口信息列表，停车业务需要配置的接口列表，该值为JSON数据格式的LIST对象，现阶段只需要配置一个页面接口即可 。每次请将所有的接口配置信息都传入，未传的接口信息将会被置空。.</param>
        /// <param name="merchantLogo">商户在停车平台首页露出的LOGO。 注意： *该图片为PNG格式，内容为BASE64的字符串，建议图片尺寸27px*27px，大小不要超过60K。 *若为空则停车平台首页将不露出商户LOGO。.</param>
        /// <param name="merchantName">商户简称，由开发者提供.</param>
        /// <param name="merchantServicePhone">商户客服电话.</param>
        public AlipayEcoMycarParkingConfigSetModel(string accountNo = default(string), List<InterfaceInfoList> interfaceInfoList = default(List<InterfaceInfoList>), string merchantLogo = default(string), string merchantName = default(string), string merchantServicePhone = default(string))
        {
            this.AccountNo = accountNo;
            this.InterfaceInfoList = interfaceInfoList;
            this.MerchantLogo = merchantLogo;
            this.MerchantName = merchantName;
            this.MerchantServicePhone = merchantServicePhone;
        }

        /// <summary>
        /// 签约支付宝账号
        /// </summary>
        /// <value>签约支付宝账号</value>
        [DataMember(Name = "account_no", EmitDefaultValue = false)]
        public string AccountNo { get; set; }

        /// <summary>
        /// 接口信息列表，停车业务需要配置的接口列表，该值为JSON数据格式的LIST对象，现阶段只需要配置一个页面接口即可 。每次请将所有的接口配置信息都传入，未传的接口信息将会被置空。
        /// </summary>
        /// <value>接口信息列表，停车业务需要配置的接口列表，该值为JSON数据格式的LIST对象，现阶段只需要配置一个页面接口即可 。每次请将所有的接口配置信息都传入，未传的接口信息将会被置空。</value>
        [DataMember(Name = "interface_info_list", EmitDefaultValue = false)]
        public List<InterfaceInfoList> InterfaceInfoList { get; set; }

        /// <summary>
        /// 商户在停车平台首页露出的LOGO。 注意： *该图片为PNG格式，内容为BASE64的字符串，建议图片尺寸27px*27px，大小不要超过60K。 *若为空则停车平台首页将不露出商户LOGO。
        /// </summary>
        /// <value>商户在停车平台首页露出的LOGO。 注意： *该图片为PNG格式，内容为BASE64的字符串，建议图片尺寸27px*27px，大小不要超过60K。 *若为空则停车平台首页将不露出商户LOGO。</value>
        [DataMember(Name = "merchant_logo", EmitDefaultValue = false)]
        public string MerchantLogo { get; set; }

        /// <summary>
        /// 商户简称，由开发者提供
        /// </summary>
        /// <value>商户简称，由开发者提供</value>
        [DataMember(Name = "merchant_name", EmitDefaultValue = false)]
        public string MerchantName { get; set; }

        /// <summary>
        /// 商户客服电话
        /// </summary>
        /// <value>商户客服电话</value>
        [DataMember(Name = "merchant_service_phone", EmitDefaultValue = false)]
        public string MerchantServicePhone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEcoMycarParkingConfigSetModel {\n");
            sb.Append("  AccountNo: ").Append(AccountNo).Append("\n");
            sb.Append("  InterfaceInfoList: ").Append(InterfaceInfoList).Append("\n");
            sb.Append("  MerchantLogo: ").Append(MerchantLogo).Append("\n");
            sb.Append("  MerchantName: ").Append(MerchantName).Append("\n");
            sb.Append("  MerchantServicePhone: ").Append(MerchantServicePhone).Append("\n");
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
            return this.Equals(input as AlipayEcoMycarParkingConfigSetModel);
        }

        /// <summary>
        /// Returns true if AlipayEcoMycarParkingConfigSetModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEcoMycarParkingConfigSetModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEcoMycarParkingConfigSetModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountNo == input.AccountNo ||
                    (this.AccountNo != null &&
                    this.AccountNo.Equals(input.AccountNo))
                ) && 
                (
                    this.InterfaceInfoList == input.InterfaceInfoList ||
                    this.InterfaceInfoList != null &&
                    input.InterfaceInfoList != null &&
                    this.InterfaceInfoList.SequenceEqual(input.InterfaceInfoList)
                ) && 
                (
                    this.MerchantLogo == input.MerchantLogo ||
                    (this.MerchantLogo != null &&
                    this.MerchantLogo.Equals(input.MerchantLogo))
                ) && 
                (
                    this.MerchantName == input.MerchantName ||
                    (this.MerchantName != null &&
                    this.MerchantName.Equals(input.MerchantName))
                ) && 
                (
                    this.MerchantServicePhone == input.MerchantServicePhone ||
                    (this.MerchantServicePhone != null &&
                    this.MerchantServicePhone.Equals(input.MerchantServicePhone))
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
                if (this.AccountNo != null)
                {
                    hashCode = (hashCode * 59) + this.AccountNo.GetHashCode();
                }
                if (this.InterfaceInfoList != null)
                {
                    hashCode = (hashCode * 59) + this.InterfaceInfoList.GetHashCode();
                }
                if (this.MerchantLogo != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantLogo.GetHashCode();
                }
                if (this.MerchantName != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantName.GetHashCode();
                }
                if (this.MerchantServicePhone != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantServicePhone.GetHashCode();
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
