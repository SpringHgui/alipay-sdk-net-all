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
    /// AlipayOpenMiniVersionOnlineModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniVersionOnlineModel")]
    public partial class AlipayOpenMiniVersionOnlineModel : IEquatable<AlipayOpenMiniVersionOnlineModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniVersionOnlineModel" /> class.
        /// </summary>
        /// <param name="appVersion">商家小程序版本号，需为审核通过状态或灰度中版本。.</param>
        /// <param name="bundleId">小程序客户端类型，默认为支付宝端。常见支持如下客户端： com.alipay.alipaywallet：支付宝端； com.alibaba.android.rimet：DINGDING端； com.amap.app：高德端； com.alibaba.ailabs.genie.webapps：天猫精灵端； com.alipay.iot.xpaas：支付宝IoT端。 如需更多端投放，请联系业务BD。.</param>
        /// <param name="downgrade">true - 性能优先； false - 覆盖优先（默认）.</param>
        /// <param name="permitRegistrationLimitRelease">如果该字段为true，在首次发版的小程序在备案未完成的情况下，允许小程序上架，但小程序上架后只可以上架可扫码进行使用，但不可被搜索、限制访问人数（50人/每天）、限制公域（无法进行商品、服务、营促销）、限制上架后90天不完成备案自动下架。 默认为false.</param>
        public AlipayOpenMiniVersionOnlineModel(string appVersion = default(string), string bundleId = default(string), bool downgrade = default(bool), bool permitRegistrationLimitRelease = default(bool))
        {
            this.AppVersion = appVersion;
            this.BundleId = bundleId;
            this.Downgrade = downgrade;
            this.PermitRegistrationLimitRelease = permitRegistrationLimitRelease;
        }

        /// <summary>
        /// 商家小程序版本号，需为审核通过状态或灰度中版本。
        /// </summary>
        /// <value>商家小程序版本号，需为审核通过状态或灰度中版本。</value>
        [DataMember(Name = "app_version", EmitDefaultValue = false)]
        public string AppVersion { get; set; }

        /// <summary>
        /// 小程序客户端类型，默认为支付宝端。常见支持如下客户端： com.alipay.alipaywallet：支付宝端； com.alibaba.android.rimet：DINGDING端； com.amap.app：高德端； com.alibaba.ailabs.genie.webapps：天猫精灵端； com.alipay.iot.xpaas：支付宝IoT端。 如需更多端投放，请联系业务BD。
        /// </summary>
        /// <value>小程序客户端类型，默认为支付宝端。常见支持如下客户端： com.alipay.alipaywallet：支付宝端； com.alibaba.android.rimet：DINGDING端； com.amap.app：高德端； com.alibaba.ailabs.genie.webapps：天猫精灵端； com.alipay.iot.xpaas：支付宝IoT端。 如需更多端投放，请联系业务BD。</value>
        [DataMember(Name = "bundle_id", EmitDefaultValue = false)]
        public string BundleId { get; set; }

        /// <summary>
        /// true - 性能优先； false - 覆盖优先（默认）
        /// </summary>
        /// <value>true - 性能优先； false - 覆盖优先（默认）</value>
        [DataMember(Name = "downgrade", EmitDefaultValue = true)]
        public bool Downgrade { get; set; }

        /// <summary>
        /// 如果该字段为true，在首次发版的小程序在备案未完成的情况下，允许小程序上架，但小程序上架后只可以上架可扫码进行使用，但不可被搜索、限制访问人数（50人/每天）、限制公域（无法进行商品、服务、营促销）、限制上架后90天不完成备案自动下架。 默认为false
        /// </summary>
        /// <value>如果该字段为true，在首次发版的小程序在备案未完成的情况下，允许小程序上架，但小程序上架后只可以上架可扫码进行使用，但不可被搜索、限制访问人数（50人/每天）、限制公域（无法进行商品、服务、营促销）、限制上架后90天不完成备案自动下架。 默认为false</value>
        [DataMember(Name = "permit_registration_limit_release", EmitDefaultValue = true)]
        public bool PermitRegistrationLimitRelease { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniVersionOnlineModel {\n");
            sb.Append("  AppVersion: ").Append(AppVersion).Append("\n");
            sb.Append("  BundleId: ").Append(BundleId).Append("\n");
            sb.Append("  Downgrade: ").Append(Downgrade).Append("\n");
            sb.Append("  PermitRegistrationLimitRelease: ").Append(PermitRegistrationLimitRelease).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniVersionOnlineModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniVersionOnlineModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniVersionOnlineModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniVersionOnlineModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AppVersion == input.AppVersion ||
                    (this.AppVersion != null &&
                    this.AppVersion.Equals(input.AppVersion))
                ) && 
                (
                    this.BundleId == input.BundleId ||
                    (this.BundleId != null &&
                    this.BundleId.Equals(input.BundleId))
                ) && 
                (
                    this.Downgrade == input.Downgrade ||
                    this.Downgrade.Equals(input.Downgrade)
                ) && 
                (
                    this.PermitRegistrationLimitRelease == input.PermitRegistrationLimitRelease ||
                    this.PermitRegistrationLimitRelease.Equals(input.PermitRegistrationLimitRelease)
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
                if (this.AppVersion != null)
                {
                    hashCode = (hashCode * 59) + this.AppVersion.GetHashCode();
                }
                if (this.BundleId != null)
                {
                    hashCode = (hashCode * 59) + this.BundleId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Downgrade.GetHashCode();
                hashCode = (hashCode * 59) + this.PermitRegistrationLimitRelease.GetHashCode();
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
