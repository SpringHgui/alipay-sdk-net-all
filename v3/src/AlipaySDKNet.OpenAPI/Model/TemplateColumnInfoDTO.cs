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
    /// TemplateColumnInfoDTO
    /// </summary>
    [DataContract(Name = "TemplateColumnInfoDTO")]
    public partial class TemplateColumnInfoDTO : IEquatable<TemplateColumnInfoDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateColumnInfoDTO" /> class.
        /// </summary>
        /// <param name="code">标准栏位：行为由支付宝统一定，同时已经分配标准Code  BALANCE：会员卡余额  POINT：积分  LEVEL：等级  TELEPHONE：联系方式  自定义栏位：行为由商户定义，自定义Code码（只要无重复）.</param>
        /// <param name="groupTitle">若template_style_info.column_info_layout 的值为grid，此项为宫格项所属分组标题。可空。如果需要展示该项，还需支付宝内部进行特殊配置。.</param>
        /// <param name="iconId">当template_style_info.column_info_layout 的值为grid时，此参数必填。此项为宫格项的展示icon。通过接口（alipay.offline.material.image.upload）上传图片。.</param>
        /// <param name="moreInfo">moreInfo.</param>
        /// <param name="operateType">1、openNative：打开二级页面，展现 more中descs  2、openWeb：打开URL  3、staticinfo：静态信息  注意：  不填则默认staticinfo；  标准code尽量使用staticinfo，例如TELEPHONE商家电话栏位就只支持staticinfo；.</param>
        /// <param name="tag">只有当template_style_info.column_info_layout 的值为grid时，此参数有效。此项为宫格项标签，最多只会展示一个标签。.</param>
        /// <param name="title">栏目标题.</param>
        /// <param name="value">卡包详情页面，卡栏位右边展现的值    TELEPHONE栏位的商家联系电话号码由此value字段传入.</param>
        public TemplateColumnInfoDTO(string code = default(string), string groupTitle = default(string), string iconId = default(string), MoreInfoDTO moreInfo = default(MoreInfoDTO), string operateType = default(string), string tag = default(string), string title = default(string), string value = default(string))
        {
            this.Code = code;
            this.GroupTitle = groupTitle;
            this.IconId = iconId;
            this.MoreInfo = moreInfo;
            this.OperateType = operateType;
            this.Tag = tag;
            this.Title = title;
            this.Value = value;
        }

        /// <summary>
        /// 标准栏位：行为由支付宝统一定，同时已经分配标准Code  BALANCE：会员卡余额  POINT：积分  LEVEL：等级  TELEPHONE：联系方式  自定义栏位：行为由商户定义，自定义Code码（只要无重复）
        /// </summary>
        /// <value>标准栏位：行为由支付宝统一定，同时已经分配标准Code  BALANCE：会员卡余额  POINT：积分  LEVEL：等级  TELEPHONE：联系方式  自定义栏位：行为由商户定义，自定义Code码（只要无重复）</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// 若template_style_info.column_info_layout 的值为grid，此项为宫格项所属分组标题。可空。如果需要展示该项，还需支付宝内部进行特殊配置。
        /// </summary>
        /// <value>若template_style_info.column_info_layout 的值为grid，此项为宫格项所属分组标题。可空。如果需要展示该项，还需支付宝内部进行特殊配置。</value>
        [DataMember(Name = "group_title", EmitDefaultValue = false)]
        public string GroupTitle { get; set; }

        /// <summary>
        /// 当template_style_info.column_info_layout 的值为grid时，此参数必填。此项为宫格项的展示icon。通过接口（alipay.offline.material.image.upload）上传图片。
        /// </summary>
        /// <value>当template_style_info.column_info_layout 的值为grid时，此参数必填。此项为宫格项的展示icon。通过接口（alipay.offline.material.image.upload）上传图片。</value>
        [DataMember(Name = "icon_id", EmitDefaultValue = false)]
        public string IconId { get; set; }

        /// <summary>
        /// Gets or Sets MoreInfo
        /// </summary>
        [DataMember(Name = "more_info", EmitDefaultValue = false)]
        public MoreInfoDTO MoreInfo { get; set; }

        /// <summary>
        /// 1、openNative：打开二级页面，展现 more中descs  2、openWeb：打开URL  3、staticinfo：静态信息  注意：  不填则默认staticinfo；  标准code尽量使用staticinfo，例如TELEPHONE商家电话栏位就只支持staticinfo；
        /// </summary>
        /// <value>1、openNative：打开二级页面，展现 more中descs  2、openWeb：打开URL  3、staticinfo：静态信息  注意：  不填则默认staticinfo；  标准code尽量使用staticinfo，例如TELEPHONE商家电话栏位就只支持staticinfo；</value>
        [DataMember(Name = "operate_type", EmitDefaultValue = false)]
        public string OperateType { get; set; }

        /// <summary>
        /// 只有当template_style_info.column_info_layout 的值为grid时，此参数有效。此项为宫格项标签，最多只会展示一个标签。
        /// </summary>
        /// <value>只有当template_style_info.column_info_layout 的值为grid时，此参数有效。此项为宫格项标签，最多只会展示一个标签。</value>
        [DataMember(Name = "tag", EmitDefaultValue = false)]
        public string Tag { get; set; }

        /// <summary>
        /// 栏目标题
        /// </summary>
        /// <value>栏目标题</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// 卡包详情页面，卡栏位右边展现的值    TELEPHONE栏位的商家联系电话号码由此value字段传入
        /// </summary>
        /// <value>卡包详情页面，卡栏位右边展现的值    TELEPHONE栏位的商家联系电话号码由此value字段传入</value>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TemplateColumnInfoDTO {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  GroupTitle: ").Append(GroupTitle).Append("\n");
            sb.Append("  IconId: ").Append(IconId).Append("\n");
            sb.Append("  MoreInfo: ").Append(MoreInfo).Append("\n");
            sb.Append("  OperateType: ").Append(OperateType).Append("\n");
            sb.Append("  Tag: ").Append(Tag).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as TemplateColumnInfoDTO);
        }

        /// <summary>
        /// Returns true if TemplateColumnInfoDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateColumnInfoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateColumnInfoDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.GroupTitle == input.GroupTitle ||
                    (this.GroupTitle != null &&
                    this.GroupTitle.Equals(input.GroupTitle))
                ) && 
                (
                    this.IconId == input.IconId ||
                    (this.IconId != null &&
                    this.IconId.Equals(input.IconId))
                ) && 
                (
                    this.MoreInfo == input.MoreInfo ||
                    (this.MoreInfo != null &&
                    this.MoreInfo.Equals(input.MoreInfo))
                ) && 
                (
                    this.OperateType == input.OperateType ||
                    (this.OperateType != null &&
                    this.OperateType.Equals(input.OperateType))
                ) && 
                (
                    this.Tag == input.Tag ||
                    (this.Tag != null &&
                    this.Tag.Equals(input.Tag))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.GroupTitle != null)
                {
                    hashCode = (hashCode * 59) + this.GroupTitle.GetHashCode();
                }
                if (this.IconId != null)
                {
                    hashCode = (hashCode * 59) + this.IconId.GetHashCode();
                }
                if (this.MoreInfo != null)
                {
                    hashCode = (hashCode * 59) + this.MoreInfo.GetHashCode();
                }
                if (this.OperateType != null)
                {
                    hashCode = (hashCode * 59) + this.OperateType.GetHashCode();
                }
                if (this.Tag != null)
                {
                    hashCode = (hashCode * 59) + this.Tag.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.Value != null)
                {
                    hashCode = (hashCode * 59) + this.Value.GetHashCode();
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
