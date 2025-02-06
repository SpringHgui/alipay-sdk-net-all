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
    /// SignData
    /// </summary>
    [DataContract(Name = "SignData")]
    public partial class SignData : IEquatable<SignData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignData" /> class.
        /// </summary>
        /// <param name="oriAppId">签名商户开放平台应用APPID.</param>
        /// <param name="oriCharSet">编码类型（大小写敏感）.</param>
        /// <param name="oriOutBizNo">ori_out_biz_no_001.</param>
        /// <param name="oriSign">签名密文.</param>
        /// <param name="oriSignType">签名算法（大小写敏感）.</param>
        /// <param name="partnerId">商户支付宝账号id.</param>
        public SignData(string oriAppId = default(string), string oriCharSet = default(string), string oriOutBizNo = default(string), string oriSign = default(string), string oriSignType = default(string), string partnerId = default(string))
        {
            this.OriAppId = oriAppId;
            this.OriCharSet = oriCharSet;
            this.OriOutBizNo = oriOutBizNo;
            this.OriSign = oriSign;
            this.OriSignType = oriSignType;
            this.PartnerId = partnerId;
        }

        /// <summary>
        /// 签名商户开放平台应用APPID
        /// </summary>
        /// <value>签名商户开放平台应用APPID</value>
        [DataMember(Name = "ori_app_id", EmitDefaultValue = false)]
        public string OriAppId { get; set; }

        /// <summary>
        /// 编码类型（大小写敏感）
        /// </summary>
        /// <value>编码类型（大小写敏感）</value>
        [DataMember(Name = "ori_char_set", EmitDefaultValue = false)]
        public string OriCharSet { get; set; }

        /// <summary>
        /// ori_out_biz_no_001
        /// </summary>
        /// <value>ori_out_biz_no_001</value>
        [DataMember(Name = "ori_out_biz_no", EmitDefaultValue = false)]
        public string OriOutBizNo { get; set; }

        /// <summary>
        /// 签名密文
        /// </summary>
        /// <value>签名密文</value>
        [DataMember(Name = "ori_sign", EmitDefaultValue = false)]
        public string OriSign { get; set; }

        /// <summary>
        /// 签名算法（大小写敏感）
        /// </summary>
        /// <value>签名算法（大小写敏感）</value>
        [DataMember(Name = "ori_sign_type", EmitDefaultValue = false)]
        public string OriSignType { get; set; }

        /// <summary>
        /// 商户支付宝账号id
        /// </summary>
        /// <value>商户支付宝账号id</value>
        [DataMember(Name = "partner_id", EmitDefaultValue = false)]
        public string PartnerId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SignData {\n");
            sb.Append("  OriAppId: ").Append(OriAppId).Append("\n");
            sb.Append("  OriCharSet: ").Append(OriCharSet).Append("\n");
            sb.Append("  OriOutBizNo: ").Append(OriOutBizNo).Append("\n");
            sb.Append("  OriSign: ").Append(OriSign).Append("\n");
            sb.Append("  OriSignType: ").Append(OriSignType).Append("\n");
            sb.Append("  PartnerId: ").Append(PartnerId).Append("\n");
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
            return this.Equals(input as SignData);
        }

        /// <summary>
        /// Returns true if SignData instances are equal
        /// </summary>
        /// <param name="input">Instance of SignData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OriAppId == input.OriAppId ||
                    (this.OriAppId != null &&
                    this.OriAppId.Equals(input.OriAppId))
                ) && 
                (
                    this.OriCharSet == input.OriCharSet ||
                    (this.OriCharSet != null &&
                    this.OriCharSet.Equals(input.OriCharSet))
                ) && 
                (
                    this.OriOutBizNo == input.OriOutBizNo ||
                    (this.OriOutBizNo != null &&
                    this.OriOutBizNo.Equals(input.OriOutBizNo))
                ) && 
                (
                    this.OriSign == input.OriSign ||
                    (this.OriSign != null &&
                    this.OriSign.Equals(input.OriSign))
                ) && 
                (
                    this.OriSignType == input.OriSignType ||
                    (this.OriSignType != null &&
                    this.OriSignType.Equals(input.OriSignType))
                ) && 
                (
                    this.PartnerId == input.PartnerId ||
                    (this.PartnerId != null &&
                    this.PartnerId.Equals(input.PartnerId))
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
                if (this.OriAppId != null)
                {
                    hashCode = (hashCode * 59) + this.OriAppId.GetHashCode();
                }
                if (this.OriCharSet != null)
                {
                    hashCode = (hashCode * 59) + this.OriCharSet.GetHashCode();
                }
                if (this.OriOutBizNo != null)
                {
                    hashCode = (hashCode * 59) + this.OriOutBizNo.GetHashCode();
                }
                if (this.OriSign != null)
                {
                    hashCode = (hashCode * 59) + this.OriSign.GetHashCode();
                }
                if (this.OriSignType != null)
                {
                    hashCode = (hashCode * 59) + this.OriSignType.GetHashCode();
                }
                if (this.PartnerId != null)
                {
                    hashCode = (hashCode * 59) + this.PartnerId.GetHashCode();
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
