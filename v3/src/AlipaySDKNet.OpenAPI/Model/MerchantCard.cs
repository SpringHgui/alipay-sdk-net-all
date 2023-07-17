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
    /// MerchantCard
    /// </summary>
    [DataContract(Name = "MerchantCard")]
    public partial class MerchantCard : IEquatable<MerchantCard>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantCard" /> class.
        /// </summary>
        /// <param name="balance">资金卡余额，单位：元，精确到小数点后两位。.</param>
        /// <param name="bizCardNo">支付宝业务卡号  说明：  1、开卡成功后返回该参数，需要保存留用；  2、开卡/更新/删卡/查询卡接口请求中不需要传该参数；.</param>
        /// <param name="customAssets">会员卡自定义资产值，只供特定业务使用，通常接入无需关注.</param>
        /// <param name="externalCardNo">商户外部会员卡卡号  说明：  1、会员卡开卡接口，如果卡类型为外部会员卡，请求中则必须提供该参数；  2、更新、查询、删除等接口，请求中则不需要提供该参数值；.</param>
        /// <param name="frontImageId">卡面展示图片的图片ID，通过接口（alipay.offline.material.image.upload）上传图片    这里预期展示的是个人照片；  图片说明：1M以内，格式bmp、png、jpeg、jpg、gif；  图片尺寸为230*295px，可等比放大；.</param>
        /// <param name="frontTextList">卡面文案列表，1项对应1行文案，最多只能传入4行文案；  单行文案展现分为左右两部分，左边对应label字段，右边对应value；  形如： 学院    新闻学院.</param>
        /// <param name="level">会员卡等级（由商户自定义，并可以在卡模板创建时，定义等级信息）.</param>
        /// <param name="mdcodeInfo">mdcodeInfo.</param>
        /// <param name="openDate">会员卡开卡时间，格式为yyyy-MM-dd HH:mm:ss。会员卡更新时，该时间不支持修改，请传入调用开卡接口时传入的card_ext_info.open_date时间。.</param>
        /// <param name="point">会员卡积分，积分必须为数字型（可为浮点型，带2位小数点）.</param>
        /// <param name="templateId">会员卡更换不同的卡模板（该参数仅用在会员卡更新接口中）.</param>
        /// <param name="validDate">会员卡有效期，格式为yyyy-MM-dd HH:mm:ss。会员卡更新时，该时间不支持修改，请传入调用开卡接口时传入的card_ext_info.valid_date时间。.</param>
        public MerchantCard(string balance = default(string), string bizCardNo = default(string), string customAssets = default(string), string externalCardNo = default(string), string frontImageId = default(string), List<CardFrontTextDTO> frontTextList = default(List<CardFrontTextDTO>), string level = default(string), MdCodeInfoDTO mdcodeInfo = default(MdCodeInfoDTO), string openDate = default(string), string point = default(string), string templateId = default(string), string validDate = default(string))
        {
            this.Balance = balance;
            this.BizCardNo = bizCardNo;
            this.CustomAssets = customAssets;
            this.ExternalCardNo = externalCardNo;
            this.FrontImageId = frontImageId;
            this.FrontTextList = frontTextList;
            this.Level = level;
            this.MdcodeInfo = mdcodeInfo;
            this.OpenDate = openDate;
            this.Point = point;
            this.TemplateId = templateId;
            this.ValidDate = validDate;
        }

        /// <summary>
        /// 资金卡余额，单位：元，精确到小数点后两位。
        /// </summary>
        /// <value>资金卡余额，单位：元，精确到小数点后两位。</value>
        [DataMember(Name = "balance", EmitDefaultValue = false)]
        public string Balance { get; set; }

        /// <summary>
        /// 支付宝业务卡号  说明：  1、开卡成功后返回该参数，需要保存留用；  2、开卡/更新/删卡/查询卡接口请求中不需要传该参数；
        /// </summary>
        /// <value>支付宝业务卡号  说明：  1、开卡成功后返回该参数，需要保存留用；  2、开卡/更新/删卡/查询卡接口请求中不需要传该参数；</value>
        [DataMember(Name = "biz_card_no", EmitDefaultValue = false)]
        public string BizCardNo { get; set; }

        /// <summary>
        /// 会员卡自定义资产值，只供特定业务使用，通常接入无需关注
        /// </summary>
        /// <value>会员卡自定义资产值，只供特定业务使用，通常接入无需关注</value>
        [DataMember(Name = "custom_assets", EmitDefaultValue = false)]
        public string CustomAssets { get; set; }

        /// <summary>
        /// 商户外部会员卡卡号  说明：  1、会员卡开卡接口，如果卡类型为外部会员卡，请求中则必须提供该参数；  2、更新、查询、删除等接口，请求中则不需要提供该参数值；
        /// </summary>
        /// <value>商户外部会员卡卡号  说明：  1、会员卡开卡接口，如果卡类型为外部会员卡，请求中则必须提供该参数；  2、更新、查询、删除等接口，请求中则不需要提供该参数值；</value>
        [DataMember(Name = "external_card_no", EmitDefaultValue = false)]
        public string ExternalCardNo { get; set; }

        /// <summary>
        /// 卡面展示图片的图片ID，通过接口（alipay.offline.material.image.upload）上传图片    这里预期展示的是个人照片；  图片说明：1M以内，格式bmp、png、jpeg、jpg、gif；  图片尺寸为230*295px，可等比放大；
        /// </summary>
        /// <value>卡面展示图片的图片ID，通过接口（alipay.offline.material.image.upload）上传图片    这里预期展示的是个人照片；  图片说明：1M以内，格式bmp、png、jpeg、jpg、gif；  图片尺寸为230*295px，可等比放大；</value>
        [DataMember(Name = "front_image_id", EmitDefaultValue = false)]
        public string FrontImageId { get; set; }

        /// <summary>
        /// 卡面文案列表，1项对应1行文案，最多只能传入4行文案；  单行文案展现分为左右两部分，左边对应label字段，右边对应value；  形如： 学院    新闻学院
        /// </summary>
        /// <value>卡面文案列表，1项对应1行文案，最多只能传入4行文案；  单行文案展现分为左右两部分，左边对应label字段，右边对应value；  形如： 学院    新闻学院</value>
        [DataMember(Name = "front_text_list", EmitDefaultValue = false)]
        public List<CardFrontTextDTO> FrontTextList { get; set; }

        /// <summary>
        /// 会员卡等级（由商户自定义，并可以在卡模板创建时，定义等级信息）
        /// </summary>
        /// <value>会员卡等级（由商户自定义，并可以在卡模板创建时，定义等级信息）</value>
        [DataMember(Name = "level", EmitDefaultValue = false)]
        public string Level { get; set; }

        /// <summary>
        /// Gets or Sets MdcodeInfo
        /// </summary>
        [DataMember(Name = "mdcode_info", EmitDefaultValue = false)]
        public MdCodeInfoDTO MdcodeInfo { get; set; }

        /// <summary>
        /// 会员卡开卡时间，格式为yyyy-MM-dd HH:mm:ss。会员卡更新时，该时间不支持修改，请传入调用开卡接口时传入的card_ext_info.open_date时间。
        /// </summary>
        /// <value>会员卡开卡时间，格式为yyyy-MM-dd HH:mm:ss。会员卡更新时，该时间不支持修改，请传入调用开卡接口时传入的card_ext_info.open_date时间。</value>
        [DataMember(Name = "open_date", EmitDefaultValue = false)]
        public string OpenDate { get; set; }

        /// <summary>
        /// 会员卡积分，积分必须为数字型（可为浮点型，带2位小数点）
        /// </summary>
        /// <value>会员卡积分，积分必须为数字型（可为浮点型，带2位小数点）</value>
        [DataMember(Name = "point", EmitDefaultValue = false)]
        public string Point { get; set; }

        /// <summary>
        /// 会员卡更换不同的卡模板（该参数仅用在会员卡更新接口中）
        /// </summary>
        /// <value>会员卡更换不同的卡模板（该参数仅用在会员卡更新接口中）</value>
        [DataMember(Name = "template_id", EmitDefaultValue = false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// 会员卡有效期，格式为yyyy-MM-dd HH:mm:ss。会员卡更新时，该时间不支持修改，请传入调用开卡接口时传入的card_ext_info.valid_date时间。
        /// </summary>
        /// <value>会员卡有效期，格式为yyyy-MM-dd HH:mm:ss。会员卡更新时，该时间不支持修改，请传入调用开卡接口时传入的card_ext_info.valid_date时间。</value>
        [DataMember(Name = "valid_date", EmitDefaultValue = false)]
        public string ValidDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MerchantCard {\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  BizCardNo: ").Append(BizCardNo).Append("\n");
            sb.Append("  CustomAssets: ").Append(CustomAssets).Append("\n");
            sb.Append("  ExternalCardNo: ").Append(ExternalCardNo).Append("\n");
            sb.Append("  FrontImageId: ").Append(FrontImageId).Append("\n");
            sb.Append("  FrontTextList: ").Append(FrontTextList).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  MdcodeInfo: ").Append(MdcodeInfo).Append("\n");
            sb.Append("  OpenDate: ").Append(OpenDate).Append("\n");
            sb.Append("  Point: ").Append(Point).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  ValidDate: ").Append(ValidDate).Append("\n");
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
            return this.Equals(input as MerchantCard);
        }

        /// <summary>
        /// Returns true if MerchantCard instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantCard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantCard input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
                ) && 
                (
                    this.BizCardNo == input.BizCardNo ||
                    (this.BizCardNo != null &&
                    this.BizCardNo.Equals(input.BizCardNo))
                ) && 
                (
                    this.CustomAssets == input.CustomAssets ||
                    (this.CustomAssets != null &&
                    this.CustomAssets.Equals(input.CustomAssets))
                ) && 
                (
                    this.ExternalCardNo == input.ExternalCardNo ||
                    (this.ExternalCardNo != null &&
                    this.ExternalCardNo.Equals(input.ExternalCardNo))
                ) && 
                (
                    this.FrontImageId == input.FrontImageId ||
                    (this.FrontImageId != null &&
                    this.FrontImageId.Equals(input.FrontImageId))
                ) && 
                (
                    this.FrontTextList == input.FrontTextList ||
                    this.FrontTextList != null &&
                    input.FrontTextList != null &&
                    this.FrontTextList.SequenceEqual(input.FrontTextList)
                ) && 
                (
                    this.Level == input.Level ||
                    (this.Level != null &&
                    this.Level.Equals(input.Level))
                ) && 
                (
                    this.MdcodeInfo == input.MdcodeInfo ||
                    (this.MdcodeInfo != null &&
                    this.MdcodeInfo.Equals(input.MdcodeInfo))
                ) && 
                (
                    this.OpenDate == input.OpenDate ||
                    (this.OpenDate != null &&
                    this.OpenDate.Equals(input.OpenDate))
                ) && 
                (
                    this.Point == input.Point ||
                    (this.Point != null &&
                    this.Point.Equals(input.Point))
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.ValidDate == input.ValidDate ||
                    (this.ValidDate != null &&
                    this.ValidDate.Equals(input.ValidDate))
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
                if (this.Balance != null)
                {
                    hashCode = (hashCode * 59) + this.Balance.GetHashCode();
                }
                if (this.BizCardNo != null)
                {
                    hashCode = (hashCode * 59) + this.BizCardNo.GetHashCode();
                }
                if (this.CustomAssets != null)
                {
                    hashCode = (hashCode * 59) + this.CustomAssets.GetHashCode();
                }
                if (this.ExternalCardNo != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalCardNo.GetHashCode();
                }
                if (this.FrontImageId != null)
                {
                    hashCode = (hashCode * 59) + this.FrontImageId.GetHashCode();
                }
                if (this.FrontTextList != null)
                {
                    hashCode = (hashCode * 59) + this.FrontTextList.GetHashCode();
                }
                if (this.Level != null)
                {
                    hashCode = (hashCode * 59) + this.Level.GetHashCode();
                }
                if (this.MdcodeInfo != null)
                {
                    hashCode = (hashCode * 59) + this.MdcodeInfo.GetHashCode();
                }
                if (this.OpenDate != null)
                {
                    hashCode = (hashCode * 59) + this.OpenDate.GetHashCode();
                }
                if (this.Point != null)
                {
                    hashCode = (hashCode * 59) + this.Point.GetHashCode();
                }
                if (this.TemplateId != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateId.GetHashCode();
                }
                if (this.ValidDate != null)
                {
                    hashCode = (hashCode * 59) + this.ValidDate.GetHashCode();
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
