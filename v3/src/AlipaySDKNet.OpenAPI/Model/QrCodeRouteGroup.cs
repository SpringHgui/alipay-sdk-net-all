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
    /// QrCodeRouteGroup
    /// </summary>
    [DataContract(Name = "QrCodeRouteGroup")]
    public partial class QrCodeRouteGroup : IEquatable<QrCodeRouteGroup>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QrCodeRouteGroup" /> class.
        /// </summary>
        /// <param name="mode">匹配规则，EXACT（精确匹配）、FUZZY（模糊匹配）、PATTERN（模式匹配）\\\\（如：配置二维码地址为https://www.alipay.com/my?id&#x3D;123，当用户扫这个地址的二维码可唤起小程序）。 模糊匹配：根据填写的二维码地址模糊匹配，只要地址前缀匹配即可唤起小程序（如：配置二维码地址为https://www.alipay.com/my/，当用户扫的二维码地址为https://www.alipay.com/my/id&#x3D;123,可唤起小程序）。 。 模式匹配：根据填写的二维码地址可变变量进行匹配，只要地址的变量位置自定义，变量之外的部分匹配即可唤起小程序(如：配置的二维码地址为https://www.alipay.com/{0}/my/{1},当用户扫的二维码地址为：https://www.alipay.com/user/my/scan，可唤起小程序).</param>
        /// <param name="routeGroup">路由组id（参数说明：该参数可用于alipay.open.mini.qrcode.unbind接口入参route_group，进行二维码解绑）.</param>
        /// <param name="routeUrl">规则路由地址.</param>
        public QrCodeRouteGroup(string mode = default(string), string routeGroup = default(string), string routeUrl = default(string))
        {
            this.Mode = mode;
            this.RouteGroup = routeGroup;
            this.RouteUrl = routeUrl;
        }

        /// <summary>
        /// 匹配规则，EXACT（精确匹配）、FUZZY（模糊匹配）、PATTERN（模式匹配）\\\\（如：配置二维码地址为https://www.alipay.com/my?id&#x3D;123，当用户扫这个地址的二维码可唤起小程序）。 模糊匹配：根据填写的二维码地址模糊匹配，只要地址前缀匹配即可唤起小程序（如：配置二维码地址为https://www.alipay.com/my/，当用户扫的二维码地址为https://www.alipay.com/my/id&#x3D;123,可唤起小程序）。 。 模式匹配：根据填写的二维码地址可变变量进行匹配，只要地址的变量位置自定义，变量之外的部分匹配即可唤起小程序(如：配置的二维码地址为https://www.alipay.com/{0}/my/{1},当用户扫的二维码地址为：https://www.alipay.com/user/my/scan，可唤起小程序)
        /// </summary>
        /// <value>匹配规则，EXACT（精确匹配）、FUZZY（模糊匹配）、PATTERN（模式匹配）\\\\（如：配置二维码地址为https://www.alipay.com/my?id&#x3D;123，当用户扫这个地址的二维码可唤起小程序）。 模糊匹配：根据填写的二维码地址模糊匹配，只要地址前缀匹配即可唤起小程序（如：配置二维码地址为https://www.alipay.com/my/，当用户扫的二维码地址为https://www.alipay.com/my/id&#x3D;123,可唤起小程序）。 。 模式匹配：根据填写的二维码地址可变变量进行匹配，只要地址的变量位置自定义，变量之外的部分匹配即可唤起小程序(如：配置的二维码地址为https://www.alipay.com/{0}/my/{1},当用户扫的二维码地址为：https://www.alipay.com/user/my/scan，可唤起小程序)</value>
        [DataMember(Name = "mode", EmitDefaultValue = false)]
        public string Mode { get; set; }

        /// <summary>
        /// 路由组id（参数说明：该参数可用于alipay.open.mini.qrcode.unbind接口入参route_group，进行二维码解绑）
        /// </summary>
        /// <value>路由组id（参数说明：该参数可用于alipay.open.mini.qrcode.unbind接口入参route_group，进行二维码解绑）</value>
        [DataMember(Name = "route_group", EmitDefaultValue = false)]
        public string RouteGroup { get; set; }

        /// <summary>
        /// 规则路由地址
        /// </summary>
        /// <value>规则路由地址</value>
        [DataMember(Name = "route_url", EmitDefaultValue = false)]
        public string RouteUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class QrCodeRouteGroup {\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  RouteGroup: ").Append(RouteGroup).Append("\n");
            sb.Append("  RouteUrl: ").Append(RouteUrl).Append("\n");
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
            return this.Equals(input as QrCodeRouteGroup);
        }

        /// <summary>
        /// Returns true if QrCodeRouteGroup instances are equal
        /// </summary>
        /// <param name="input">Instance of QrCodeRouteGroup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(QrCodeRouteGroup input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
                ) && 
                (
                    this.RouteGroup == input.RouteGroup ||
                    (this.RouteGroup != null &&
                    this.RouteGroup.Equals(input.RouteGroup))
                ) && 
                (
                    this.RouteUrl == input.RouteUrl ||
                    (this.RouteUrl != null &&
                    this.RouteUrl.Equals(input.RouteUrl))
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
                if (this.Mode != null)
                {
                    hashCode = (hashCode * 59) + this.Mode.GetHashCode();
                }
                if (this.RouteGroup != null)
                {
                    hashCode = (hashCode * 59) + this.RouteGroup.GetHashCode();
                }
                if (this.RouteUrl != null)
                {
                    hashCode = (hashCode * 59) + this.RouteUrl.GetHashCode();
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
