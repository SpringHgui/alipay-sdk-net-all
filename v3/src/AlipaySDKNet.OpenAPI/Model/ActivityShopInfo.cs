/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2023-10-26
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
    /// ActivityShopInfo
    /// </summary>
    [DataContract(Name = "ActivityShopInfo")]
    public partial class ActivityShopInfo : IEquatable<ActivityShopInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActivityShopInfo" /> class.
        /// </summary>
        /// <param name="latitude">纬度，浮点型,小数点后最多保留6位.</param>
        /// <param name="longitude">经度，浮点型, 小数点后最多保留6位。.</param>
        /// <param name="shopId">支付宝侧蚂蚁店铺 id。.</param>
        /// <param name="shopName">店铺名称。.</param>
        /// <param name="shopType">门店类型 PAYMENT_SHOP 支付门店 REAL_SHOP 代运营商业关系门店.</param>
        public ActivityShopInfo(string latitude = default(string), string longitude = default(string), string shopId = default(string), string shopName = default(string), string shopType = default(string))
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.ShopId = shopId;
            this.ShopName = shopName;
            this.ShopType = shopType;
        }

        /// <summary>
        /// 纬度，浮点型,小数点后最多保留6位
        /// </summary>
        /// <value>纬度，浮点型,小数点后最多保留6位</value>
        [DataMember(Name = "latitude", EmitDefaultValue = false)]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度，浮点型, 小数点后最多保留6位。
        /// </summary>
        /// <value>经度，浮点型, 小数点后最多保留6位。</value>
        [DataMember(Name = "longitude", EmitDefaultValue = false)]
        public string Longitude { get; set; }

        /// <summary>
        /// 支付宝侧蚂蚁店铺 id。
        /// </summary>
        /// <value>支付宝侧蚂蚁店铺 id。</value>
        [DataMember(Name = "shop_id", EmitDefaultValue = false)]
        public string ShopId { get; set; }

        /// <summary>
        /// 店铺名称。
        /// </summary>
        /// <value>店铺名称。</value>
        [DataMember(Name = "shop_name", EmitDefaultValue = false)]
        public string ShopName { get; set; }

        /// <summary>
        /// 门店类型 PAYMENT_SHOP 支付门店 REAL_SHOP 代运营商业关系门店
        /// </summary>
        /// <value>门店类型 PAYMENT_SHOP 支付门店 REAL_SHOP 代运营商业关系门店</value>
        [DataMember(Name = "shop_type", EmitDefaultValue = false)]
        public string ShopType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ActivityShopInfo {\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  ShopId: ").Append(ShopId).Append("\n");
            sb.Append("  ShopName: ").Append(ShopName).Append("\n");
            sb.Append("  ShopType: ").Append(ShopType).Append("\n");
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
            return this.Equals(input as ActivityShopInfo);
        }

        /// <summary>
        /// Returns true if ActivityShopInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ActivityShopInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ActivityShopInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Latitude == input.Latitude ||
                    (this.Latitude != null &&
                    this.Latitude.Equals(input.Latitude))
                ) && 
                (
                    this.Longitude == input.Longitude ||
                    (this.Longitude != null &&
                    this.Longitude.Equals(input.Longitude))
                ) && 
                (
                    this.ShopId == input.ShopId ||
                    (this.ShopId != null &&
                    this.ShopId.Equals(input.ShopId))
                ) && 
                (
                    this.ShopName == input.ShopName ||
                    (this.ShopName != null &&
                    this.ShopName.Equals(input.ShopName))
                ) && 
                (
                    this.ShopType == input.ShopType ||
                    (this.ShopType != null &&
                    this.ShopType.Equals(input.ShopType))
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
                if (this.Latitude != null)
                {
                    hashCode = (hashCode * 59) + this.Latitude.GetHashCode();
                }
                if (this.Longitude != null)
                {
                    hashCode = (hashCode * 59) + this.Longitude.GetHashCode();
                }
                if (this.ShopId != null)
                {
                    hashCode = (hashCode * 59) + this.ShopId.GetHashCode();
                }
                if (this.ShopName != null)
                {
                    hashCode = (hashCode * 59) + this.ShopName.GetHashCode();
                }
                if (this.ShopType != null)
                {
                    hashCode = (hashCode * 59) + this.ShopType.GetHashCode();
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
