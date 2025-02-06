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
    /// TicketInfo
    /// </summary>
    [DataContract(Name = "TicketInfo")]
    public partial class TicketInfo : IEquatable<TicketInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TicketInfo" /> class.
        /// </summary>
        /// <param name="address">店铺地址.</param>
        /// <param name="endTime">截止时间.</param>
        /// <param name="resvType">凭证预约类型，一般不需要传入。可选值为INSTANT/RESERVATION，其中INSTANT代表是实时凭证，RESERVATION代表是预约凭证，不传入默认为实时凭证。区别在于预约凭证一般不是当场可取，而是用户下单后的很多天之后才可以凭借凭证提取.</param>
        /// <param name="shop">凭证可核销门店/货品自提门店，如果自提门店与购买门店不一致，可传入该字段提示用户自提门店.</param>
        /// <param name="ticketNo">单据号 不同类型下单据号含义不同。若类型为MEAL_NUM，则ticket_no表示取餐号；若类型为PICKUP_CODE，则ticket_no表示取件码；其他类型查看小程序订单产品文档.</param>
        /// <param name="time">时间.</param>
        /// <param name="type">凭证类型 具体类型查看产品文档.</param>
        public TicketInfo(string address = default(string), string endTime = default(string), string resvType = default(string), string shop = default(string), string ticketNo = default(string), string time = default(string), string type = default(string))
        {
            this.Address = address;
            this.EndTime = endTime;
            this.ResvType = resvType;
            this.Shop = shop;
            this.TicketNo = ticketNo;
            this.Time = time;
            this.Type = type;
        }

        /// <summary>
        /// 店铺地址
        /// </summary>
        /// <value>店铺地址</value>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// 截止时间
        /// </summary>
        /// <value>截止时间</value>
        [DataMember(Name = "end_time", EmitDefaultValue = false)]
        public string EndTime { get; set; }

        /// <summary>
        /// 凭证预约类型，一般不需要传入。可选值为INSTANT/RESERVATION，其中INSTANT代表是实时凭证，RESERVATION代表是预约凭证，不传入默认为实时凭证。区别在于预约凭证一般不是当场可取，而是用户下单后的很多天之后才可以凭借凭证提取
        /// </summary>
        /// <value>凭证预约类型，一般不需要传入。可选值为INSTANT/RESERVATION，其中INSTANT代表是实时凭证，RESERVATION代表是预约凭证，不传入默认为实时凭证。区别在于预约凭证一般不是当场可取，而是用户下单后的很多天之后才可以凭借凭证提取</value>
        [DataMember(Name = "resv_type", EmitDefaultValue = false)]
        public string ResvType { get; set; }

        /// <summary>
        /// 凭证可核销门店/货品自提门店，如果自提门店与购买门店不一致，可传入该字段提示用户自提门店
        /// </summary>
        /// <value>凭证可核销门店/货品自提门店，如果自提门店与购买门店不一致，可传入该字段提示用户自提门店</value>
        [DataMember(Name = "shop", EmitDefaultValue = false)]
        public string Shop { get; set; }

        /// <summary>
        /// 单据号 不同类型下单据号含义不同。若类型为MEAL_NUM，则ticket_no表示取餐号；若类型为PICKUP_CODE，则ticket_no表示取件码；其他类型查看小程序订单产品文档
        /// </summary>
        /// <value>单据号 不同类型下单据号含义不同。若类型为MEAL_NUM，则ticket_no表示取餐号；若类型为PICKUP_CODE，则ticket_no表示取件码；其他类型查看小程序订单产品文档</value>
        [DataMember(Name = "ticket_no", EmitDefaultValue = false)]
        public string TicketNo { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        /// <value>时间</value>
        [DataMember(Name = "time", EmitDefaultValue = false)]
        public string Time { get; set; }

        /// <summary>
        /// 凭证类型 具体类型查看产品文档
        /// </summary>
        /// <value>凭证类型 具体类型查看产品文档</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TicketInfo {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  ResvType: ").Append(ResvType).Append("\n");
            sb.Append("  Shop: ").Append(Shop).Append("\n");
            sb.Append("  TicketNo: ").Append(TicketNo).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as TicketInfo);
        }

        /// <summary>
        /// Returns true if TicketInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of TicketInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TicketInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.ResvType == input.ResvType ||
                    (this.ResvType != null &&
                    this.ResvType.Equals(input.ResvType))
                ) && 
                (
                    this.Shop == input.Shop ||
                    (this.Shop != null &&
                    this.Shop.Equals(input.Shop))
                ) && 
                (
                    this.TicketNo == input.TicketNo ||
                    (this.TicketNo != null &&
                    this.TicketNo.Equals(input.TicketNo))
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.EndTime != null)
                {
                    hashCode = (hashCode * 59) + this.EndTime.GetHashCode();
                }
                if (this.ResvType != null)
                {
                    hashCode = (hashCode * 59) + this.ResvType.GetHashCode();
                }
                if (this.Shop != null)
                {
                    hashCode = (hashCode * 59) + this.Shop.GetHashCode();
                }
                if (this.TicketNo != null)
                {
                    hashCode = (hashCode * 59) + this.TicketNo.GetHashCode();
                }
                if (this.Time != null)
                {
                    hashCode = (hashCode * 59) + this.Time.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
