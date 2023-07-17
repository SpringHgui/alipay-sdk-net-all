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
    /// AlipayOpenMiniExperienceCancelModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniExperienceCancelModel")]
    public partial class AlipayOpenMiniExperienceCancelModel : IEquatable<AlipayOpenMiniExperienceCancelModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniExperienceCancelModel" /> class.
        /// </summary>
        /// <param name="appVersion">小程序版本号.</param>
        /// <param name="bundleId">小程序客户端类型，默认为支付宝端。支付宝端：com.alipay.alipaywallet,DINGDING端：com.alibaba.android.rimet,高德端:com.amap.app,天猫精灵端:com.alibaba.ailabs.genie.webapps,支付宝IOT:com.alipay.iot.xpaas.</param>
        public AlipayOpenMiniExperienceCancelModel(string appVersion = default(string), string bundleId = default(string))
        {
            this.AppVersion = appVersion;
            this.BundleId = bundleId;
        }

        /// <summary>
        /// 小程序版本号
        /// </summary>
        /// <value>小程序版本号</value>
        [DataMember(Name = "app_version", EmitDefaultValue = false)]
        public string AppVersion { get; set; }

        /// <summary>
        /// 小程序客户端类型，默认为支付宝端。支付宝端：com.alipay.alipaywallet,DINGDING端：com.alibaba.android.rimet,高德端:com.amap.app,天猫精灵端:com.alibaba.ailabs.genie.webapps,支付宝IOT:com.alipay.iot.xpaas
        /// </summary>
        /// <value>小程序客户端类型，默认为支付宝端。支付宝端：com.alipay.alipaywallet,DINGDING端：com.alibaba.android.rimet,高德端:com.amap.app,天猫精灵端:com.alibaba.ailabs.genie.webapps,支付宝IOT:com.alipay.iot.xpaas</value>
        [DataMember(Name = "bundle_id", EmitDefaultValue = false)]
        public string BundleId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniExperienceCancelModel {\n");
            sb.Append("  AppVersion: ").Append(AppVersion).Append("\n");
            sb.Append("  BundleId: ").Append(BundleId).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniExperienceCancelModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniExperienceCancelModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniExperienceCancelModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniExperienceCancelModel input)
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
