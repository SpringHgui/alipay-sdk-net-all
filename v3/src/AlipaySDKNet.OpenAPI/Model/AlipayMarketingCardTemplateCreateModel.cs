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
    /// AlipayMarketingCardTemplateCreateModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingCardTemplateCreateModel")]
    public partial class AlipayMarketingCardTemplateCreateModel : IEquatable<AlipayMarketingCardTemplateCreateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingCardTemplateCreateModel" /> class.
        /// </summary>
        /// <param name="accessVersion">接入版本.</param>
        /// <param name="bizNoPrefix">业务卡号前缀，由商户指定  支付宝业务卡号生成规则：biz_no_prefix(商户指定)卡号前缀 + biz_no_suffix(实时生成）卡号后缀.</param>
        /// <param name="bizNoSuffixLen">业务卡号后缀长度，与biz_no_prefix配合，扣除系统预留2位，剩下对应seq长度。在生成卡号时，若seq位数不足前置补0，若seq位数超出则以实际为准。举例：设为10，其中8位用于生成seq，可覆盖1亿用户，即使seq超过1亿，生成卡号也不报错，但总长度不得超过32位。建议按需设置合适的值，以获得长度一致的业务卡号，建议长度20，性能更好。.</param>
        /// <param name="cardActionList">\&quot;卡行动点配置； 行动点，即用户可点击跳转的区块，类似按钮控件的交互； 单张卡最多定制3个行动点。如果各项的配置内容完全一样，展示时会进行去重。\&quot;.</param>
        /// <param name="cardLevelConf">卡级别配置.</param>
        /// <param name="cardSpecTag">卡特定标签，只供特定业务使用，通常接入无需关注.</param>
        /// <param name="cardType">卡类型.</param>
        /// <param name="columnInfoList">栏位信息.</param>
        /// <param name="fieldRuleList">\&quot;字段规则列表，会员卡开卡过程中，会员卡信息的生成规则， 例如：卡有效期为开卡后两年内有效，则设置为：DATE_IN_FUTURE\&quot;.</param>
        /// <param name="mdcodeNotifyConf">mdcodeNotifyConf.</param>
        /// <param name="notifyUrl">通知地址.</param>
        /// <param name="openCardConf">openCardConf.</param>
        /// <param name="paidOuterCardConf">paidOuterCardConf.</param>
        /// <param name="pubChannels">卡模板投放渠道.</param>
        /// <param name="requestId">请求ID，商家自定义且并保证唯一性。.</param>
        /// <param name="serviceLabelList">服务标签列表.</param>
        /// <param name="shopIds">会员卡上架门店id（支付宝门店id），即发放会员卡的商家门店id.</param>
        /// <param name="spiAppId">spi应用id，为实现spi.alipay.user.opencard.get接口的app_id。若是第三方代理模式，可以设置成服务商的 APPID 或者是商家自己的 APPID； 若不是第三方代理模式，只能设置商家自己的 APPID。.</param>
        /// <param name="templateBenefitInfo">\&quot;权益信息， 1、在卡包的卡详情页面会自动添加“会员权益”栏位，展现此字段配置的会员卡权益信息， 2、如果添加门店渠道，则可在门店页展现会员卡的权益\&quot;.</param>
        /// <param name="templateFormConfig">templateFormConfig.</param>
        /// <param name="templateStyleInfo">templateStyleInfo.</param>
        /// <param name="writeOffType">卡包详情页面中展现出的卡码（可用于扫码核销）  (1) 静态码 qrcode: 二维码，扫码得商户开卡传入的external_card_no barcode: 条形码，扫码得商户开卡传入的external_card_no  (2) 动态码-支付宝生成码值(动态码会在2分钟左右后过期) dqrcode: 动态二维码，扫码得到的码值可配合会员卡查询接口使用 dbarcode: 动态条形码，扫码得到的码值可配合会员卡查询接口使用  (3) 动态码-商家自主生成码值（码值、时效性都由商户控制） mdqrcode: 商户动态二维码，扫码得商户自主传入的码值 mdbarcode: 商户动态条码，扫码得商户自主传入的码值 如需使用商户动态码，对接详情参见 &lt;a  href&#x3D;\&quot;https://opendocs.alipay.com/open/02y7gt\&quot;&gt;商户动态发码&lt;/a&gt;。.</param>
        public AlipayMarketingCardTemplateCreateModel(string accessVersion = default(string), string bizNoPrefix = default(string), string bizNoSuffixLen = default(string), List<TemplateActionInfoDTO> cardActionList = default(List<TemplateActionInfoDTO>), List<TemplateCardLevelConfDTO> cardLevelConf = default(List<TemplateCardLevelConfDTO>), string cardSpecTag = default(string), string cardType = default(string), List<TemplateColumnInfoDTO> columnInfoList = default(List<TemplateColumnInfoDTO>), List<TemplateFieldRuleDTO> fieldRuleList = default(List<TemplateFieldRuleDTO>), TemplateMdcodeNotifyConfDTO mdcodeNotifyConf = default(TemplateMdcodeNotifyConfDTO), string notifyUrl = default(string), TemplateOpenCardConfDTO openCardConf = default(TemplateOpenCardConfDTO), PaidOuterCardTemplateConfDTO paidOuterCardConf = default(PaidOuterCardTemplateConfDTO), List<PubChannelDTO> pubChannels = default(List<PubChannelDTO>), string requestId = default(string), List<string> serviceLabelList = default(List<string>), List<string> shopIds = default(List<string>), string spiAppId = default(string), List<TemplateBenefitInfoDTO> templateBenefitInfo = default(List<TemplateBenefitInfoDTO>), TemplateFormConfig templateFormConfig = default(TemplateFormConfig), TemplateStyleInfoDTO templateStyleInfo = default(TemplateStyleInfoDTO), string writeOffType = default(string))
        {
            this.AccessVersion = accessVersion;
            this.BizNoPrefix = bizNoPrefix;
            this.BizNoSuffixLen = bizNoSuffixLen;
            this.CardActionList = cardActionList;
            this.CardLevelConf = cardLevelConf;
            this.CardSpecTag = cardSpecTag;
            this.CardType = cardType;
            this.ColumnInfoList = columnInfoList;
            this.FieldRuleList = fieldRuleList;
            this.MdcodeNotifyConf = mdcodeNotifyConf;
            this.NotifyUrl = notifyUrl;
            this.OpenCardConf = openCardConf;
            this.PaidOuterCardConf = paidOuterCardConf;
            this.PubChannels = pubChannels;
            this.RequestId = requestId;
            this.ServiceLabelList = serviceLabelList;
            this.ShopIds = shopIds;
            this.SpiAppId = spiAppId;
            this.TemplateBenefitInfo = templateBenefitInfo;
            this.TemplateFormConfig = templateFormConfig;
            this.TemplateStyleInfo = templateStyleInfo;
            this.WriteOffType = writeOffType;
        }

        /// <summary>
        /// 接入版本
        /// </summary>
        /// <value>接入版本</value>
        [DataMember(Name = "access_version", EmitDefaultValue = false)]
        public string AccessVersion { get; set; }

        /// <summary>
        /// 业务卡号前缀，由商户指定  支付宝业务卡号生成规则：biz_no_prefix(商户指定)卡号前缀 + biz_no_suffix(实时生成）卡号后缀
        /// </summary>
        /// <value>业务卡号前缀，由商户指定  支付宝业务卡号生成规则：biz_no_prefix(商户指定)卡号前缀 + biz_no_suffix(实时生成）卡号后缀</value>
        [DataMember(Name = "biz_no_prefix", EmitDefaultValue = false)]
        public string BizNoPrefix { get; set; }

        /// <summary>
        /// 业务卡号后缀长度，与biz_no_prefix配合，扣除系统预留2位，剩下对应seq长度。在生成卡号时，若seq位数不足前置补0，若seq位数超出则以实际为准。举例：设为10，其中8位用于生成seq，可覆盖1亿用户，即使seq超过1亿，生成卡号也不报错，但总长度不得超过32位。建议按需设置合适的值，以获得长度一致的业务卡号，建议长度20，性能更好。
        /// </summary>
        /// <value>业务卡号后缀长度，与biz_no_prefix配合，扣除系统预留2位，剩下对应seq长度。在生成卡号时，若seq位数不足前置补0，若seq位数超出则以实际为准。举例：设为10，其中8位用于生成seq，可覆盖1亿用户，即使seq超过1亿，生成卡号也不报错，但总长度不得超过32位。建议按需设置合适的值，以获得长度一致的业务卡号，建议长度20，性能更好。</value>
        [DataMember(Name = "biz_no_suffix_len", EmitDefaultValue = false)]
        public string BizNoSuffixLen { get; set; }

        /// <summary>
        /// \&quot;卡行动点配置； 行动点，即用户可点击跳转的区块，类似按钮控件的交互； 单张卡最多定制3个行动点。如果各项的配置内容完全一样，展示时会进行去重。\&quot;
        /// </summary>
        /// <value>\&quot;卡行动点配置； 行动点，即用户可点击跳转的区块，类似按钮控件的交互； 单张卡最多定制3个行动点。如果各项的配置内容完全一样，展示时会进行去重。\&quot;</value>
        [DataMember(Name = "card_action_list", EmitDefaultValue = false)]
        public List<TemplateActionInfoDTO> CardActionList { get; set; }

        /// <summary>
        /// 卡级别配置
        /// </summary>
        /// <value>卡级别配置</value>
        [DataMember(Name = "card_level_conf", EmitDefaultValue = false)]
        public List<TemplateCardLevelConfDTO> CardLevelConf { get; set; }

        /// <summary>
        /// 卡特定标签，只供特定业务使用，通常接入无需关注
        /// </summary>
        /// <value>卡特定标签，只供特定业务使用，通常接入无需关注</value>
        [DataMember(Name = "card_spec_tag", EmitDefaultValue = false)]
        public string CardSpecTag { get; set; }

        /// <summary>
        /// 卡类型
        /// </summary>
        /// <value>卡类型</value>
        [DataMember(Name = "card_type", EmitDefaultValue = false)]
        public string CardType { get; set; }

        /// <summary>
        /// 栏位信息
        /// </summary>
        /// <value>栏位信息</value>
        [DataMember(Name = "column_info_list", EmitDefaultValue = false)]
        public List<TemplateColumnInfoDTO> ColumnInfoList { get; set; }

        /// <summary>
        /// \&quot;字段规则列表，会员卡开卡过程中，会员卡信息的生成规则， 例如：卡有效期为开卡后两年内有效，则设置为：DATE_IN_FUTURE\&quot;
        /// </summary>
        /// <value>\&quot;字段规则列表，会员卡开卡过程中，会员卡信息的生成规则， 例如：卡有效期为开卡后两年内有效，则设置为：DATE_IN_FUTURE\&quot;</value>
        [DataMember(Name = "field_rule_list", EmitDefaultValue = false)]
        public List<TemplateFieldRuleDTO> FieldRuleList { get; set; }

        /// <summary>
        /// Gets or Sets MdcodeNotifyConf
        /// </summary>
        [DataMember(Name = "mdcode_notify_conf", EmitDefaultValue = false)]
        public TemplateMdcodeNotifyConfDTO MdcodeNotifyConf { get; set; }

        /// <summary>
        /// 通知地址
        /// </summary>
        /// <value>通知地址</value>
        [DataMember(Name = "notify_url", EmitDefaultValue = false)]
        public string NotifyUrl { get; set; }

        /// <summary>
        /// Gets or Sets OpenCardConf
        /// </summary>
        [DataMember(Name = "open_card_conf", EmitDefaultValue = false)]
        public TemplateOpenCardConfDTO OpenCardConf { get; set; }

        /// <summary>
        /// Gets or Sets PaidOuterCardConf
        /// </summary>
        [DataMember(Name = "paid_outer_card_conf", EmitDefaultValue = false)]
        public PaidOuterCardTemplateConfDTO PaidOuterCardConf { get; set; }

        /// <summary>
        /// 卡模板投放渠道
        /// </summary>
        /// <value>卡模板投放渠道</value>
        [DataMember(Name = "pub_channels", EmitDefaultValue = false)]
        public List<PubChannelDTO> PubChannels { get; set; }

        /// <summary>
        /// 请求ID，商家自定义且并保证唯一性。
        /// </summary>
        /// <value>请求ID，商家自定义且并保证唯一性。</value>
        [DataMember(Name = "request_id", EmitDefaultValue = false)]
        public string RequestId { get; set; }

        /// <summary>
        /// 服务标签列表
        /// </summary>
        /// <value>服务标签列表</value>
        [DataMember(Name = "service_label_list", EmitDefaultValue = false)]
        public List<string> ServiceLabelList { get; set; }

        /// <summary>
        /// 会员卡上架门店id（支付宝门店id），即发放会员卡的商家门店id
        /// </summary>
        /// <value>会员卡上架门店id（支付宝门店id），即发放会员卡的商家门店id</value>
        [DataMember(Name = "shop_ids", EmitDefaultValue = false)]
        public List<string> ShopIds { get; set; }

        /// <summary>
        /// spi应用id，为实现spi.alipay.user.opencard.get接口的app_id。若是第三方代理模式，可以设置成服务商的 APPID 或者是商家自己的 APPID； 若不是第三方代理模式，只能设置商家自己的 APPID。
        /// </summary>
        /// <value>spi应用id，为实现spi.alipay.user.opencard.get接口的app_id。若是第三方代理模式，可以设置成服务商的 APPID 或者是商家自己的 APPID； 若不是第三方代理模式，只能设置商家自己的 APPID。</value>
        [DataMember(Name = "spi_app_id", EmitDefaultValue = false)]
        public string SpiAppId { get; set; }

        /// <summary>
        /// \&quot;权益信息， 1、在卡包的卡详情页面会自动添加“会员权益”栏位，展现此字段配置的会员卡权益信息， 2、如果添加门店渠道，则可在门店页展现会员卡的权益\&quot;
        /// </summary>
        /// <value>\&quot;权益信息， 1、在卡包的卡详情页面会自动添加“会员权益”栏位，展现此字段配置的会员卡权益信息， 2、如果添加门店渠道，则可在门店页展现会员卡的权益\&quot;</value>
        [DataMember(Name = "template_benefit_info", EmitDefaultValue = false)]
        public List<TemplateBenefitInfoDTO> TemplateBenefitInfo { get; set; }

        /// <summary>
        /// Gets or Sets TemplateFormConfig
        /// </summary>
        [DataMember(Name = "template_form_config", EmitDefaultValue = false)]
        public TemplateFormConfig TemplateFormConfig { get; set; }

        /// <summary>
        /// Gets or Sets TemplateStyleInfo
        /// </summary>
        [DataMember(Name = "template_style_info", EmitDefaultValue = false)]
        public TemplateStyleInfoDTO TemplateStyleInfo { get; set; }

        /// <summary>
        /// 卡包详情页面中展现出的卡码（可用于扫码核销）  (1) 静态码 qrcode: 二维码，扫码得商户开卡传入的external_card_no barcode: 条形码，扫码得商户开卡传入的external_card_no  (2) 动态码-支付宝生成码值(动态码会在2分钟左右后过期) dqrcode: 动态二维码，扫码得到的码值可配合会员卡查询接口使用 dbarcode: 动态条形码，扫码得到的码值可配合会员卡查询接口使用  (3) 动态码-商家自主生成码值（码值、时效性都由商户控制） mdqrcode: 商户动态二维码，扫码得商户自主传入的码值 mdbarcode: 商户动态条码，扫码得商户自主传入的码值 如需使用商户动态码，对接详情参见 &lt;a  href&#x3D;\&quot;https://opendocs.alipay.com/open/02y7gt\&quot;&gt;商户动态发码&lt;/a&gt;。
        /// </summary>
        /// <value>卡包详情页面中展现出的卡码（可用于扫码核销）  (1) 静态码 qrcode: 二维码，扫码得商户开卡传入的external_card_no barcode: 条形码，扫码得商户开卡传入的external_card_no  (2) 动态码-支付宝生成码值(动态码会在2分钟左右后过期) dqrcode: 动态二维码，扫码得到的码值可配合会员卡查询接口使用 dbarcode: 动态条形码，扫码得到的码值可配合会员卡查询接口使用  (3) 动态码-商家自主生成码值（码值、时效性都由商户控制） mdqrcode: 商户动态二维码，扫码得商户自主传入的码值 mdbarcode: 商户动态条码，扫码得商户自主传入的码值 如需使用商户动态码，对接详情参见 &lt;a  href&#x3D;\&quot;https://opendocs.alipay.com/open/02y7gt\&quot;&gt;商户动态发码&lt;/a&gt;。</value>
        [DataMember(Name = "write_off_type", EmitDefaultValue = false)]
        public string WriteOffType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingCardTemplateCreateModel {\n");
            sb.Append("  AccessVersion: ").Append(AccessVersion).Append("\n");
            sb.Append("  BizNoPrefix: ").Append(BizNoPrefix).Append("\n");
            sb.Append("  BizNoSuffixLen: ").Append(BizNoSuffixLen).Append("\n");
            sb.Append("  CardActionList: ").Append(CardActionList).Append("\n");
            sb.Append("  CardLevelConf: ").Append(CardLevelConf).Append("\n");
            sb.Append("  CardSpecTag: ").Append(CardSpecTag).Append("\n");
            sb.Append("  CardType: ").Append(CardType).Append("\n");
            sb.Append("  ColumnInfoList: ").Append(ColumnInfoList).Append("\n");
            sb.Append("  FieldRuleList: ").Append(FieldRuleList).Append("\n");
            sb.Append("  MdcodeNotifyConf: ").Append(MdcodeNotifyConf).Append("\n");
            sb.Append("  NotifyUrl: ").Append(NotifyUrl).Append("\n");
            sb.Append("  OpenCardConf: ").Append(OpenCardConf).Append("\n");
            sb.Append("  PaidOuterCardConf: ").Append(PaidOuterCardConf).Append("\n");
            sb.Append("  PubChannels: ").Append(PubChannels).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("  ServiceLabelList: ").Append(ServiceLabelList).Append("\n");
            sb.Append("  ShopIds: ").Append(ShopIds).Append("\n");
            sb.Append("  SpiAppId: ").Append(SpiAppId).Append("\n");
            sb.Append("  TemplateBenefitInfo: ").Append(TemplateBenefitInfo).Append("\n");
            sb.Append("  TemplateFormConfig: ").Append(TemplateFormConfig).Append("\n");
            sb.Append("  TemplateStyleInfo: ").Append(TemplateStyleInfo).Append("\n");
            sb.Append("  WriteOffType: ").Append(WriteOffType).Append("\n");
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
            return this.Equals(input as AlipayMarketingCardTemplateCreateModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingCardTemplateCreateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingCardTemplateCreateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingCardTemplateCreateModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccessVersion == input.AccessVersion ||
                    (this.AccessVersion != null &&
                    this.AccessVersion.Equals(input.AccessVersion))
                ) && 
                (
                    this.BizNoPrefix == input.BizNoPrefix ||
                    (this.BizNoPrefix != null &&
                    this.BizNoPrefix.Equals(input.BizNoPrefix))
                ) && 
                (
                    this.BizNoSuffixLen == input.BizNoSuffixLen ||
                    (this.BizNoSuffixLen != null &&
                    this.BizNoSuffixLen.Equals(input.BizNoSuffixLen))
                ) && 
                (
                    this.CardActionList == input.CardActionList ||
                    this.CardActionList != null &&
                    input.CardActionList != null &&
                    this.CardActionList.SequenceEqual(input.CardActionList)
                ) && 
                (
                    this.CardLevelConf == input.CardLevelConf ||
                    this.CardLevelConf != null &&
                    input.CardLevelConf != null &&
                    this.CardLevelConf.SequenceEqual(input.CardLevelConf)
                ) && 
                (
                    this.CardSpecTag == input.CardSpecTag ||
                    (this.CardSpecTag != null &&
                    this.CardSpecTag.Equals(input.CardSpecTag))
                ) && 
                (
                    this.CardType == input.CardType ||
                    (this.CardType != null &&
                    this.CardType.Equals(input.CardType))
                ) && 
                (
                    this.ColumnInfoList == input.ColumnInfoList ||
                    this.ColumnInfoList != null &&
                    input.ColumnInfoList != null &&
                    this.ColumnInfoList.SequenceEqual(input.ColumnInfoList)
                ) && 
                (
                    this.FieldRuleList == input.FieldRuleList ||
                    this.FieldRuleList != null &&
                    input.FieldRuleList != null &&
                    this.FieldRuleList.SequenceEqual(input.FieldRuleList)
                ) && 
                (
                    this.MdcodeNotifyConf == input.MdcodeNotifyConf ||
                    (this.MdcodeNotifyConf != null &&
                    this.MdcodeNotifyConf.Equals(input.MdcodeNotifyConf))
                ) && 
                (
                    this.NotifyUrl == input.NotifyUrl ||
                    (this.NotifyUrl != null &&
                    this.NotifyUrl.Equals(input.NotifyUrl))
                ) && 
                (
                    this.OpenCardConf == input.OpenCardConf ||
                    (this.OpenCardConf != null &&
                    this.OpenCardConf.Equals(input.OpenCardConf))
                ) && 
                (
                    this.PaidOuterCardConf == input.PaidOuterCardConf ||
                    (this.PaidOuterCardConf != null &&
                    this.PaidOuterCardConf.Equals(input.PaidOuterCardConf))
                ) && 
                (
                    this.PubChannels == input.PubChannels ||
                    this.PubChannels != null &&
                    input.PubChannels != null &&
                    this.PubChannels.SequenceEqual(input.PubChannels)
                ) && 
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
                ) && 
                (
                    this.ServiceLabelList == input.ServiceLabelList ||
                    this.ServiceLabelList != null &&
                    input.ServiceLabelList != null &&
                    this.ServiceLabelList.SequenceEqual(input.ServiceLabelList)
                ) && 
                (
                    this.ShopIds == input.ShopIds ||
                    this.ShopIds != null &&
                    input.ShopIds != null &&
                    this.ShopIds.SequenceEqual(input.ShopIds)
                ) && 
                (
                    this.SpiAppId == input.SpiAppId ||
                    (this.SpiAppId != null &&
                    this.SpiAppId.Equals(input.SpiAppId))
                ) && 
                (
                    this.TemplateBenefitInfo == input.TemplateBenefitInfo ||
                    this.TemplateBenefitInfo != null &&
                    input.TemplateBenefitInfo != null &&
                    this.TemplateBenefitInfo.SequenceEqual(input.TemplateBenefitInfo)
                ) && 
                (
                    this.TemplateFormConfig == input.TemplateFormConfig ||
                    (this.TemplateFormConfig != null &&
                    this.TemplateFormConfig.Equals(input.TemplateFormConfig))
                ) && 
                (
                    this.TemplateStyleInfo == input.TemplateStyleInfo ||
                    (this.TemplateStyleInfo != null &&
                    this.TemplateStyleInfo.Equals(input.TemplateStyleInfo))
                ) && 
                (
                    this.WriteOffType == input.WriteOffType ||
                    (this.WriteOffType != null &&
                    this.WriteOffType.Equals(input.WriteOffType))
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
                if (this.AccessVersion != null)
                {
                    hashCode = (hashCode * 59) + this.AccessVersion.GetHashCode();
                }
                if (this.BizNoPrefix != null)
                {
                    hashCode = (hashCode * 59) + this.BizNoPrefix.GetHashCode();
                }
                if (this.BizNoSuffixLen != null)
                {
                    hashCode = (hashCode * 59) + this.BizNoSuffixLen.GetHashCode();
                }
                if (this.CardActionList != null)
                {
                    hashCode = (hashCode * 59) + this.CardActionList.GetHashCode();
                }
                if (this.CardLevelConf != null)
                {
                    hashCode = (hashCode * 59) + this.CardLevelConf.GetHashCode();
                }
                if (this.CardSpecTag != null)
                {
                    hashCode = (hashCode * 59) + this.CardSpecTag.GetHashCode();
                }
                if (this.CardType != null)
                {
                    hashCode = (hashCode * 59) + this.CardType.GetHashCode();
                }
                if (this.ColumnInfoList != null)
                {
                    hashCode = (hashCode * 59) + this.ColumnInfoList.GetHashCode();
                }
                if (this.FieldRuleList != null)
                {
                    hashCode = (hashCode * 59) + this.FieldRuleList.GetHashCode();
                }
                if (this.MdcodeNotifyConf != null)
                {
                    hashCode = (hashCode * 59) + this.MdcodeNotifyConf.GetHashCode();
                }
                if (this.NotifyUrl != null)
                {
                    hashCode = (hashCode * 59) + this.NotifyUrl.GetHashCode();
                }
                if (this.OpenCardConf != null)
                {
                    hashCode = (hashCode * 59) + this.OpenCardConf.GetHashCode();
                }
                if (this.PaidOuterCardConf != null)
                {
                    hashCode = (hashCode * 59) + this.PaidOuterCardConf.GetHashCode();
                }
                if (this.PubChannels != null)
                {
                    hashCode = (hashCode * 59) + this.PubChannels.GetHashCode();
                }
                if (this.RequestId != null)
                {
                    hashCode = (hashCode * 59) + this.RequestId.GetHashCode();
                }
                if (this.ServiceLabelList != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceLabelList.GetHashCode();
                }
                if (this.ShopIds != null)
                {
                    hashCode = (hashCode * 59) + this.ShopIds.GetHashCode();
                }
                if (this.SpiAppId != null)
                {
                    hashCode = (hashCode * 59) + this.SpiAppId.GetHashCode();
                }
                if (this.TemplateBenefitInfo != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateBenefitInfo.GetHashCode();
                }
                if (this.TemplateFormConfig != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateFormConfig.GetHashCode();
                }
                if (this.TemplateStyleInfo != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateStyleInfo.GetHashCode();
                }
                if (this.WriteOffType != null)
                {
                    hashCode = (hashCode * 59) + this.WriteOffType.GetHashCode();
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
