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
    /// SearchOrderDetailDataServiceItems
    /// </summary>
    [DataContract(Name = "SearchOrderDetailDataServiceItems")]
    public partial class SearchOrderDetailDataServiceItems : IEquatable<SearchOrderDetailDataServiceItems>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchOrderDetailDataServiceItems" /> class.
        /// </summary>
        /// <param name="areaCodes">服务工单详情area_codes.</param>
        /// <param name="carrierCode">carrier_code.</param>
        /// <param name="carrierList">服务工单数据carrier_list.</param>
        /// <param name="categoryAttributeValue">服务工单category_attribute_value.</param>
        /// <param name="categoryCode">类目编码.</param>
        /// <param name="categoryIds">类目id.</param>
        /// <param name="channelType">渠道类型.</param>
        /// <param name="desc">描述信息.</param>
        /// <param name="img">img地址.</param>
        /// <param name="keyWord">关键词.</param>
        /// <param name="keyWordList">关键词列表.</param>
        /// <param name="logo">logo图片地址.</param>
        /// <param name="name">应用名称.</param>
        /// <param name="parentServiceCode">服务编码.</param>
        /// <param name="region">服务工单详情region.</param>
        /// <param name="servSearchCatalogs">serv_search_catalogs.</param>
        /// <param name="servSearchKeywords">关键词.</param>
        /// <param name="serviceCode">2020112321000021082348.</param>
        /// <param name="serviceName">服务名称.</param>
        /// <param name="serviceTimeEnd">服务结束时间.</param>
        /// <param name="serviceTimeStart">服务开始时间.</param>
        /// <param name="shortDesc">服务短描述.</param>
        /// <param name="specCode">应用标识.</param>
        /// <param name="templateId">模板id.</param>
        public SearchOrderDetailDataServiceItems(string areaCodes = default(string), string carrierCode = default(string), string carrierList = default(string), string categoryAttributeValue = default(string), string categoryCode = default(string), string categoryIds = default(string), string channelType = default(string), string desc = default(string), string img = default(string), string keyWord = default(string), string keyWordList = default(string), string logo = default(string), string name = default(string), string parentServiceCode = default(string), string region = default(string), string servSearchCatalogs = default(string), string servSearchKeywords = default(string), string serviceCode = default(string), string serviceName = default(string), string serviceTimeEnd = default(string), string serviceTimeStart = default(string), string shortDesc = default(string), string specCode = default(string), string templateId = default(string))
        {
            this.AreaCodes = areaCodes;
            this.CarrierCode = carrierCode;
            this.CarrierList = carrierList;
            this.CategoryAttributeValue = categoryAttributeValue;
            this.CategoryCode = categoryCode;
            this.CategoryIds = categoryIds;
            this.ChannelType = channelType;
            this.Desc = desc;
            this.Img = img;
            this.KeyWord = keyWord;
            this.KeyWordList = keyWordList;
            this.Logo = logo;
            this.Name = name;
            this.ParentServiceCode = parentServiceCode;
            this.Region = region;
            this.ServSearchCatalogs = servSearchCatalogs;
            this.ServSearchKeywords = servSearchKeywords;
            this.ServiceCode = serviceCode;
            this.ServiceName = serviceName;
            this.ServiceTimeEnd = serviceTimeEnd;
            this.ServiceTimeStart = serviceTimeStart;
            this.ShortDesc = shortDesc;
            this.SpecCode = specCode;
            this.TemplateId = templateId;
        }

        /// <summary>
        /// 服务工单详情area_codes
        /// </summary>
        /// <value>服务工单详情area_codes</value>
        [DataMember(Name = "area_codes", EmitDefaultValue = false)]
        public string AreaCodes { get; set; }

        /// <summary>
        /// carrier_code
        /// </summary>
        /// <value>carrier_code</value>
        [DataMember(Name = "carrier_code", EmitDefaultValue = false)]
        public string CarrierCode { get; set; }

        /// <summary>
        /// 服务工单数据carrier_list
        /// </summary>
        /// <value>服务工单数据carrier_list</value>
        [DataMember(Name = "carrier_list", EmitDefaultValue = false)]
        public string CarrierList { get; set; }

        /// <summary>
        /// 服务工单category_attribute_value
        /// </summary>
        /// <value>服务工单category_attribute_value</value>
        [DataMember(Name = "category_attribute_value", EmitDefaultValue = false)]
        public string CategoryAttributeValue { get; set; }

        /// <summary>
        /// 类目编码
        /// </summary>
        /// <value>类目编码</value>
        [DataMember(Name = "category_code", EmitDefaultValue = false)]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 类目id
        /// </summary>
        /// <value>类目id</value>
        [DataMember(Name = "category_ids", EmitDefaultValue = false)]
        public string CategoryIds { get; set; }

        /// <summary>
        /// 渠道类型
        /// </summary>
        /// <value>渠道类型</value>
        [DataMember(Name = "channel_type", EmitDefaultValue = false)]
        public string ChannelType { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        /// <value>描述信息</value>
        [DataMember(Name = "desc", EmitDefaultValue = false)]
        public string Desc { get; set; }

        /// <summary>
        /// img地址
        /// </summary>
        /// <value>img地址</value>
        [DataMember(Name = "img", EmitDefaultValue = false)]
        public string Img { get; set; }

        /// <summary>
        /// 关键词
        /// </summary>
        /// <value>关键词</value>
        [DataMember(Name = "key_word", EmitDefaultValue = false)]
        public string KeyWord { get; set; }

        /// <summary>
        /// 关键词列表
        /// </summary>
        /// <value>关键词列表</value>
        [DataMember(Name = "key_word_list", EmitDefaultValue = false)]
        public string KeyWordList { get; set; }

        /// <summary>
        /// logo图片地址
        /// </summary>
        /// <value>logo图片地址</value>
        [DataMember(Name = "logo", EmitDefaultValue = false)]
        public string Logo { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        /// <value>应用名称</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// 服务编码
        /// </summary>
        /// <value>服务编码</value>
        [DataMember(Name = "parent_service_code", EmitDefaultValue = false)]
        public string ParentServiceCode { get; set; }

        /// <summary>
        /// 服务工单详情region
        /// </summary>
        /// <value>服务工单详情region</value>
        [DataMember(Name = "region", EmitDefaultValue = false)]
        public string Region { get; set; }

        /// <summary>
        /// serv_search_catalogs
        /// </summary>
        /// <value>serv_search_catalogs</value>
        [DataMember(Name = "serv_search_catalogs", EmitDefaultValue = false)]
        public string ServSearchCatalogs { get; set; }

        /// <summary>
        /// 关键词
        /// </summary>
        /// <value>关键词</value>
        [DataMember(Name = "serv_search_keywords", EmitDefaultValue = false)]
        public string ServSearchKeywords { get; set; }

        /// <summary>
        /// 2020112321000021082348
        /// </summary>
        /// <value>2020112321000021082348</value>
        [DataMember(Name = "service_code", EmitDefaultValue = false)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        /// <value>服务名称</value>
        [DataMember(Name = "service_name", EmitDefaultValue = false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// 服务结束时间
        /// </summary>
        /// <value>服务结束时间</value>
        [DataMember(Name = "service_time_end", EmitDefaultValue = false)]
        public string ServiceTimeEnd { get; set; }

        /// <summary>
        /// 服务开始时间
        /// </summary>
        /// <value>服务开始时间</value>
        [DataMember(Name = "service_time_start", EmitDefaultValue = false)]
        public string ServiceTimeStart { get; set; }

        /// <summary>
        /// 服务短描述
        /// </summary>
        /// <value>服务短描述</value>
        [DataMember(Name = "short_desc", EmitDefaultValue = false)]
        public string ShortDesc { get; set; }

        /// <summary>
        /// 应用标识
        /// </summary>
        /// <value>应用标识</value>
        [DataMember(Name = "spec_code", EmitDefaultValue = false)]
        public string SpecCode { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        /// <value>模板id</value>
        [DataMember(Name = "template_id", EmitDefaultValue = false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchOrderDetailDataServiceItems {\n");
            sb.Append("  AreaCodes: ").Append(AreaCodes).Append("\n");
            sb.Append("  CarrierCode: ").Append(CarrierCode).Append("\n");
            sb.Append("  CarrierList: ").Append(CarrierList).Append("\n");
            sb.Append("  CategoryAttributeValue: ").Append(CategoryAttributeValue).Append("\n");
            sb.Append("  CategoryCode: ").Append(CategoryCode).Append("\n");
            sb.Append("  CategoryIds: ").Append(CategoryIds).Append("\n");
            sb.Append("  ChannelType: ").Append(ChannelType).Append("\n");
            sb.Append("  Desc: ").Append(Desc).Append("\n");
            sb.Append("  Img: ").Append(Img).Append("\n");
            sb.Append("  KeyWord: ").Append(KeyWord).Append("\n");
            sb.Append("  KeyWordList: ").Append(KeyWordList).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ParentServiceCode: ").Append(ParentServiceCode).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  ServSearchCatalogs: ").Append(ServSearchCatalogs).Append("\n");
            sb.Append("  ServSearchKeywords: ").Append(ServSearchKeywords).Append("\n");
            sb.Append("  ServiceCode: ").Append(ServiceCode).Append("\n");
            sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
            sb.Append("  ServiceTimeEnd: ").Append(ServiceTimeEnd).Append("\n");
            sb.Append("  ServiceTimeStart: ").Append(ServiceTimeStart).Append("\n");
            sb.Append("  ShortDesc: ").Append(ShortDesc).Append("\n");
            sb.Append("  SpecCode: ").Append(SpecCode).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
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
            return this.Equals(input as SearchOrderDetailDataServiceItems);
        }

        /// <summary>
        /// Returns true if SearchOrderDetailDataServiceItems instances are equal
        /// </summary>
        /// <param name="input">Instance of SearchOrderDetailDataServiceItems to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SearchOrderDetailDataServiceItems input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AreaCodes == input.AreaCodes ||
                    (this.AreaCodes != null &&
                    this.AreaCodes.Equals(input.AreaCodes))
                ) && 
                (
                    this.CarrierCode == input.CarrierCode ||
                    (this.CarrierCode != null &&
                    this.CarrierCode.Equals(input.CarrierCode))
                ) && 
                (
                    this.CarrierList == input.CarrierList ||
                    (this.CarrierList != null &&
                    this.CarrierList.Equals(input.CarrierList))
                ) && 
                (
                    this.CategoryAttributeValue == input.CategoryAttributeValue ||
                    (this.CategoryAttributeValue != null &&
                    this.CategoryAttributeValue.Equals(input.CategoryAttributeValue))
                ) && 
                (
                    this.CategoryCode == input.CategoryCode ||
                    (this.CategoryCode != null &&
                    this.CategoryCode.Equals(input.CategoryCode))
                ) && 
                (
                    this.CategoryIds == input.CategoryIds ||
                    (this.CategoryIds != null &&
                    this.CategoryIds.Equals(input.CategoryIds))
                ) && 
                (
                    this.ChannelType == input.ChannelType ||
                    (this.ChannelType != null &&
                    this.ChannelType.Equals(input.ChannelType))
                ) && 
                (
                    this.Desc == input.Desc ||
                    (this.Desc != null &&
                    this.Desc.Equals(input.Desc))
                ) && 
                (
                    this.Img == input.Img ||
                    (this.Img != null &&
                    this.Img.Equals(input.Img))
                ) && 
                (
                    this.KeyWord == input.KeyWord ||
                    (this.KeyWord != null &&
                    this.KeyWord.Equals(input.KeyWord))
                ) && 
                (
                    this.KeyWordList == input.KeyWordList ||
                    (this.KeyWordList != null &&
                    this.KeyWordList.Equals(input.KeyWordList))
                ) && 
                (
                    this.Logo == input.Logo ||
                    (this.Logo != null &&
                    this.Logo.Equals(input.Logo))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ParentServiceCode == input.ParentServiceCode ||
                    (this.ParentServiceCode != null &&
                    this.ParentServiceCode.Equals(input.ParentServiceCode))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.ServSearchCatalogs == input.ServSearchCatalogs ||
                    (this.ServSearchCatalogs != null &&
                    this.ServSearchCatalogs.Equals(input.ServSearchCatalogs))
                ) && 
                (
                    this.ServSearchKeywords == input.ServSearchKeywords ||
                    (this.ServSearchKeywords != null &&
                    this.ServSearchKeywords.Equals(input.ServSearchKeywords))
                ) && 
                (
                    this.ServiceCode == input.ServiceCode ||
                    (this.ServiceCode != null &&
                    this.ServiceCode.Equals(input.ServiceCode))
                ) && 
                (
                    this.ServiceName == input.ServiceName ||
                    (this.ServiceName != null &&
                    this.ServiceName.Equals(input.ServiceName))
                ) && 
                (
                    this.ServiceTimeEnd == input.ServiceTimeEnd ||
                    (this.ServiceTimeEnd != null &&
                    this.ServiceTimeEnd.Equals(input.ServiceTimeEnd))
                ) && 
                (
                    this.ServiceTimeStart == input.ServiceTimeStart ||
                    (this.ServiceTimeStart != null &&
                    this.ServiceTimeStart.Equals(input.ServiceTimeStart))
                ) && 
                (
                    this.ShortDesc == input.ShortDesc ||
                    (this.ShortDesc != null &&
                    this.ShortDesc.Equals(input.ShortDesc))
                ) && 
                (
                    this.SpecCode == input.SpecCode ||
                    (this.SpecCode != null &&
                    this.SpecCode.Equals(input.SpecCode))
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
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
                if (this.AreaCodes != null)
                {
                    hashCode = (hashCode * 59) + this.AreaCodes.GetHashCode();
                }
                if (this.CarrierCode != null)
                {
                    hashCode = (hashCode * 59) + this.CarrierCode.GetHashCode();
                }
                if (this.CarrierList != null)
                {
                    hashCode = (hashCode * 59) + this.CarrierList.GetHashCode();
                }
                if (this.CategoryAttributeValue != null)
                {
                    hashCode = (hashCode * 59) + this.CategoryAttributeValue.GetHashCode();
                }
                if (this.CategoryCode != null)
                {
                    hashCode = (hashCode * 59) + this.CategoryCode.GetHashCode();
                }
                if (this.CategoryIds != null)
                {
                    hashCode = (hashCode * 59) + this.CategoryIds.GetHashCode();
                }
                if (this.ChannelType != null)
                {
                    hashCode = (hashCode * 59) + this.ChannelType.GetHashCode();
                }
                if (this.Desc != null)
                {
                    hashCode = (hashCode * 59) + this.Desc.GetHashCode();
                }
                if (this.Img != null)
                {
                    hashCode = (hashCode * 59) + this.Img.GetHashCode();
                }
                if (this.KeyWord != null)
                {
                    hashCode = (hashCode * 59) + this.KeyWord.GetHashCode();
                }
                if (this.KeyWordList != null)
                {
                    hashCode = (hashCode * 59) + this.KeyWordList.GetHashCode();
                }
                if (this.Logo != null)
                {
                    hashCode = (hashCode * 59) + this.Logo.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.ParentServiceCode != null)
                {
                    hashCode = (hashCode * 59) + this.ParentServiceCode.GetHashCode();
                }
                if (this.Region != null)
                {
                    hashCode = (hashCode * 59) + this.Region.GetHashCode();
                }
                if (this.ServSearchCatalogs != null)
                {
                    hashCode = (hashCode * 59) + this.ServSearchCatalogs.GetHashCode();
                }
                if (this.ServSearchKeywords != null)
                {
                    hashCode = (hashCode * 59) + this.ServSearchKeywords.GetHashCode();
                }
                if (this.ServiceCode != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceCode.GetHashCode();
                }
                if (this.ServiceName != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceName.GetHashCode();
                }
                if (this.ServiceTimeEnd != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceTimeEnd.GetHashCode();
                }
                if (this.ServiceTimeStart != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceTimeStart.GetHashCode();
                }
                if (this.ShortDesc != null)
                {
                    hashCode = (hashCode * 59) + this.ShortDesc.GetHashCode();
                }
                if (this.SpecCode != null)
                {
                    hashCode = (hashCode * 59) + this.SpecCode.GetHashCode();
                }
                if (this.TemplateId != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateId.GetHashCode();
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
