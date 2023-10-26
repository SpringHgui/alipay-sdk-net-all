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
    /// AlipayTradeCreateModel
    /// </summary>
    [DataContract(Name = "AlipayTradeCreateModel")]
    public partial class AlipayTradeCreateModel : IEquatable<AlipayTradeCreateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayTradeCreateModel" /> class.
        /// </summary>
        /// <param name="agreementSignParams">agreementSignParams.</param>
        /// <param name="alipayStoreId">支付宝店铺编号。 指商户创建门店后支付宝生成的门店ID。.</param>
        /// <param name="bkagentReqInfo">bkagentReqInfo.</param>
        /// <param name="body">订单附加信息。 如果请求时传递了该参数，将在异步通知、对账单中原样返回，同时会在商户和用户的pc账单详情中作为交易描述展示.</param>
        /// <param name="businessParams">businessParams.</param>
        /// <param name="buyerId">买家支付宝用户ID。 2088开头的16位纯数字，小程序场景下获取用户ID请参考：&lt;a target&#x3D;\&quot;_blank\&quot; href&#x3D;\&quot;https://opendocs.alipay.com/mini/introduce/authcode\&quot; &gt;用户授权&lt;/a&gt;; 其它场景下获取用户ID请参考：&lt;a target&#x3D;\&quot;_blank\&quot; href&#x3D;\&quot;https://opendocs.alipay.com/open/284/106001/#s4\&quot; &gt;网页授权获取用户信息&lt;/a&gt;; 注：交易的买家与卖家不能相同。.</param>
        /// <param name="buyerLogonId">买家支付宝登录账号。 buyer_logon_id和buyer_id两者传其一，和buyer_id不能同时为空，建议通过buyer_id来传递买家信息。.</param>
        /// <param name="buyerOpenId">买家支付宝用户唯一标识.</param>
        /// <param name="disablePayChannels">禁用渠道,用户不可用指定渠道支付，多个渠道以逗号分割  注，与enable_pay_channels互斥  &lt;a href&#x3D;\&quot;https://docs.open.alipay.com/common/wifww7\&quot;&gt;渠道列表&lt;/a&gt;.</param>
        /// <param name="discountableAmount">可打折金额。 参与优惠计算的金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]。  如果同时传入了【可打折金额】、【不可打折金额】和【订单总金额】，则必须满足如下条件：【订单总金额】&#x3D;【可打折金额】+【不可打折金额】。 如果订单金额全部参与优惠计算，则【可打折金额】和【不可打折金额】都无需传入。.</param>
        /// <param name="enablePayChannels">指定支付渠道。 用户只能使用指定的渠道进行支付，多个渠道以逗号分割。 与disable_pay_channels互斥，支持传入的值：&lt;a target&#x3D;\&quot;_blank\&quot; href&#x3D;\&quot;https://docs.open.alipay.com/common/wifww7\&quot;&gt;渠道列表&lt;/a&gt;。 注：如果传入了指定支付渠道，则用户只能用指定内的渠道支付，包括营销渠道也要指定才能使用。该参数可能导致用户支付受限，慎用。.</param>
        /// <param name="extUserInfo">extUserInfo.</param>
        /// <param name="extendParams">extendParams.</param>
        /// <param name="goodsDetail">订单包含的商品列表信息，json格式。.</param>
        /// <param name="logisticsDetail">logisticsDetail.</param>
        /// <param name="merchantOrderNo">商户的原始订单号.</param>
        /// <param name="notifyUrl">通知地址.</param>
        /// <param name="opAppId">小程序支付中，商户实际经营主体的小程序应用的appid.</param>
        /// <param name="opBuyerOpenId">买家支付宝用户唯一标识（商户实际经营主体的小程序应用关联的买家open_id）.</param>
        /// <param name="operatorId">商户操作员编号。.</param>
        /// <param name="outTradeNo">商户订单号。 由商家自定义，64个字符以内，仅支持字母、数字、下划线且需保证在商户端不重复。.</param>
        /// <param name="passbackParams">公用回传参数。 如果请求时传递了该参数，支付宝会在异步通知时将该参数原样返回。.</param>
        /// <param name="productCode">产品码。 商家和支付宝签约的产品码。 枚举值（点击查看签约情况）： &lt;a target&#x3D;\&quot;_blank\&quot; href&#x3D;\&quot;https://opensupport.alipay.com/support/codelab/detail/486/487\&quot;&gt;FACE_TO_FACE_PAYMENT&lt;/a&gt;：当面付产品； 默认值为FACE_TO_FACE_PAYMENT。.</param>
        /// <param name="queryOptions">返回参数选项。 商户通过传递该参数来定制需要额外返回的信息字段，数组格式。包括但不限于：[\&quot;enterprise_pay_info\&quot;,\&quot;hyb_amount\&quot;].</param>
        /// <param name="receiverAddressInfo">receiverAddressInfo.</param>
        /// <param name="royaltyInfo">royaltyInfo.</param>
        /// <param name="sellerId">卖家支付宝用户ID。 当需要指定收款账号时，通过该参数传入，如果该值为空，则默认为商户签约账号对应的支付宝用户ID。 收款账号优先级规则：门店绑定的收款账户&gt;请求传入的seller_id&gt;商户签约账号对应的支付宝用户ID； 注：直付通和机构间联场景下seller_id无需传入或者保持跟pid一致； 如果传入的seller_id与pid不一致，需要联系支付宝小二配置收款关系；.</param>
        /// <param name="settleInfo">settleInfo.</param>
        /// <param name="storeId">商户门店编号。 指商户创建门店时输入的门店编号。.</param>
        /// <param name="subMerchant">subMerchant.</param>
        /// <param name="subject">订单标题。 注意：不可使用特殊字符，如 /，&#x3D;，&amp; 等。.</param>
        /// <param name="terminalId">商户机具终端编号。.</param>
        /// <param name="timeExpire">订单绝对超时时间。 格式为yyyy-MM-dd HH:mm:ss。 注：time_expire和timeout_express两者只需传入一个或者都不传，如果两者都传，优先使用time_expire。.</param>
        /// <param name="timeoutExpress">订单相对超时时间。从交易创建时间开始计算。 该笔订单允许的最晚付款时间，逾期将关闭交易。取值范围：1m～15d。m-分钟，h-小时，d-天，1c-当天（1c-当天的情况下，无论交易何时创建，都在0点关闭）。 该参数数值不接受小数点， 如 1.5h，可转换为 90m。 当面付场景默认值为3h。 注：time_expire和timeout_express两者只需传入一个或者都不传，如果两者都传，优先使用time_expire。.</param>
        /// <param name="totalAmount">订单总金额。 单位为元，精确到小数点后两位，取值范围：[0.01,100000000] 。.</param>
        /// <param name="undiscountableAmount">不可打折金额。 不参与优惠计算的金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]。  如果同时传入了【可打折金额】、【不可打折金额】和【订单总金额】，则必须满足如下条件：【订单总金额】&#x3D;【可打折金额】+【不可打折金额】。 如果订单金额全部参与优惠计算，则【可打折金额】和【不可打折金额】都无需传入。.</param>
        public AlipayTradeCreateModel(SignParams agreementSignParams = default(SignParams), string alipayStoreId = default(string), BkAgentReqInfo bkagentReqInfo = default(BkAgentReqInfo), string body = default(string), BusinessParams businessParams = default(BusinessParams), string buyerId = default(string), string buyerLogonId = default(string), string buyerOpenId = default(string), string disablePayChannels = default(string), string discountableAmount = default(string), string enablePayChannels = default(string), ExtUserInfo extUserInfo = default(ExtUserInfo), ExtendParams extendParams = default(ExtendParams), List<GoodsDetail> goodsDetail = default(List<GoodsDetail>), LogisticsDetail logisticsDetail = default(LogisticsDetail), string merchantOrderNo = default(string), string notifyUrl = default(string), string opAppId = default(string), string opBuyerOpenId = default(string), string operatorId = default(string), string outTradeNo = default(string), string passbackParams = default(string), string productCode = default(string), List<string> queryOptions = default(List<string>), ReceiverAddressInfo receiverAddressInfo = default(ReceiverAddressInfo), RoyaltyInfo royaltyInfo = default(RoyaltyInfo), string sellerId = default(string), SettleInfo settleInfo = default(SettleInfo), string storeId = default(string), SubMerchant subMerchant = default(SubMerchant), string subject = default(string), string terminalId = default(string), string timeExpire = default(string), string timeoutExpress = default(string), string totalAmount = default(string), string undiscountableAmount = default(string))
        {
            this.AgreementSignParams = agreementSignParams;
            this.AlipayStoreId = alipayStoreId;
            this.BkagentReqInfo = bkagentReqInfo;
            this.Body = body;
            this.BusinessParams = businessParams;
            this.BuyerId = buyerId;
            this.BuyerLogonId = buyerLogonId;
            this.BuyerOpenId = buyerOpenId;
            this.DisablePayChannels = disablePayChannels;
            this.DiscountableAmount = discountableAmount;
            this.EnablePayChannels = enablePayChannels;
            this.ExtUserInfo = extUserInfo;
            this.ExtendParams = extendParams;
            this.GoodsDetail = goodsDetail;
            this.LogisticsDetail = logisticsDetail;
            this.MerchantOrderNo = merchantOrderNo;
            this.NotifyUrl = notifyUrl;
            this.OpAppId = opAppId;
            this.OpBuyerOpenId = opBuyerOpenId;
            this.OperatorId = operatorId;
            this.OutTradeNo = outTradeNo;
            this.PassbackParams = passbackParams;
            this.ProductCode = productCode;
            this.QueryOptions = queryOptions;
            this.ReceiverAddressInfo = receiverAddressInfo;
            this.RoyaltyInfo = royaltyInfo;
            this.SellerId = sellerId;
            this.SettleInfo = settleInfo;
            this.StoreId = storeId;
            this.SubMerchant = subMerchant;
            this.Subject = subject;
            this.TerminalId = terminalId;
            this.TimeExpire = timeExpire;
            this.TimeoutExpress = timeoutExpress;
            this.TotalAmount = totalAmount;
            this.UndiscountableAmount = undiscountableAmount;
        }

        /// <summary>
        /// Gets or Sets AgreementSignParams
        /// </summary>
        [DataMember(Name = "agreement_sign_params", EmitDefaultValue = false)]
        public SignParams AgreementSignParams { get; set; }

        /// <summary>
        /// 支付宝店铺编号。 指商户创建门店后支付宝生成的门店ID。
        /// </summary>
        /// <value>支付宝店铺编号。 指商户创建门店后支付宝生成的门店ID。</value>
        [DataMember(Name = "alipay_store_id", EmitDefaultValue = false)]
        public string AlipayStoreId { get; set; }

        /// <summary>
        /// Gets or Sets BkagentReqInfo
        /// </summary>
        [DataMember(Name = "bkagent_req_info", EmitDefaultValue = false)]
        public BkAgentReqInfo BkagentReqInfo { get; set; }

        /// <summary>
        /// 订单附加信息。 如果请求时传递了该参数，将在异步通知、对账单中原样返回，同时会在商户和用户的pc账单详情中作为交易描述展示
        /// </summary>
        /// <value>订单附加信息。 如果请求时传递了该参数，将在异步通知、对账单中原样返回，同时会在商户和用户的pc账单详情中作为交易描述展示</value>
        [DataMember(Name = "body", EmitDefaultValue = false)]
        public string Body { get; set; }

        /// <summary>
        /// Gets or Sets BusinessParams
        /// </summary>
        [DataMember(Name = "business_params", EmitDefaultValue = false)]
        public BusinessParams BusinessParams { get; set; }

        /// <summary>
        /// 买家支付宝用户ID。 2088开头的16位纯数字，小程序场景下获取用户ID请参考：&lt;a target&#x3D;\&quot;_blank\&quot; href&#x3D;\&quot;https://opendocs.alipay.com/mini/introduce/authcode\&quot; &gt;用户授权&lt;/a&gt;; 其它场景下获取用户ID请参考：&lt;a target&#x3D;\&quot;_blank\&quot; href&#x3D;\&quot;https://opendocs.alipay.com/open/284/106001/#s4\&quot; &gt;网页授权获取用户信息&lt;/a&gt;; 注：交易的买家与卖家不能相同。
        /// </summary>
        /// <value>买家支付宝用户ID。 2088开头的16位纯数字，小程序场景下获取用户ID请参考：&lt;a target&#x3D;\&quot;_blank\&quot; href&#x3D;\&quot;https://opendocs.alipay.com/mini/introduce/authcode\&quot; &gt;用户授权&lt;/a&gt;; 其它场景下获取用户ID请参考：&lt;a target&#x3D;\&quot;_blank\&quot; href&#x3D;\&quot;https://opendocs.alipay.com/open/284/106001/#s4\&quot; &gt;网页授权获取用户信息&lt;/a&gt;; 注：交易的买家与卖家不能相同。</value>
        [DataMember(Name = "buyer_id", EmitDefaultValue = false)]
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家支付宝登录账号。 buyer_logon_id和buyer_id两者传其一，和buyer_id不能同时为空，建议通过buyer_id来传递买家信息。
        /// </summary>
        /// <value>买家支付宝登录账号。 buyer_logon_id和buyer_id两者传其一，和buyer_id不能同时为空，建议通过buyer_id来传递买家信息。</value>
        [DataMember(Name = "buyer_logon_id", EmitDefaultValue = false)]
        public string BuyerLogonId { get; set; }

        /// <summary>
        /// 买家支付宝用户唯一标识
        /// </summary>
        /// <value>买家支付宝用户唯一标识</value>
        [DataMember(Name = "buyer_open_id", EmitDefaultValue = false)]
        public string BuyerOpenId { get; set; }

        /// <summary>
        /// 禁用渠道,用户不可用指定渠道支付，多个渠道以逗号分割  注，与enable_pay_channels互斥  &lt;a href&#x3D;\&quot;https://docs.open.alipay.com/common/wifww7\&quot;&gt;渠道列表&lt;/a&gt;
        /// </summary>
        /// <value>禁用渠道,用户不可用指定渠道支付，多个渠道以逗号分割  注，与enable_pay_channels互斥  &lt;a href&#x3D;\&quot;https://docs.open.alipay.com/common/wifww7\&quot;&gt;渠道列表&lt;/a&gt;</value>
        [DataMember(Name = "disable_pay_channels", EmitDefaultValue = false)]
        public string DisablePayChannels { get; set; }

        /// <summary>
        /// 可打折金额。 参与优惠计算的金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]。  如果同时传入了【可打折金额】、【不可打折金额】和【订单总金额】，则必须满足如下条件：【订单总金额】&#x3D;【可打折金额】+【不可打折金额】。 如果订单金额全部参与优惠计算，则【可打折金额】和【不可打折金额】都无需传入。
        /// </summary>
        /// <value>可打折金额。 参与优惠计算的金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]。  如果同时传入了【可打折金额】、【不可打折金额】和【订单总金额】，则必须满足如下条件：【订单总金额】&#x3D;【可打折金额】+【不可打折金额】。 如果订单金额全部参与优惠计算，则【可打折金额】和【不可打折金额】都无需传入。</value>
        [DataMember(Name = "discountable_amount", EmitDefaultValue = false)]
        public string DiscountableAmount { get; set; }

        /// <summary>
        /// 指定支付渠道。 用户只能使用指定的渠道进行支付，多个渠道以逗号分割。 与disable_pay_channels互斥，支持传入的值：&lt;a target&#x3D;\&quot;_blank\&quot; href&#x3D;\&quot;https://docs.open.alipay.com/common/wifww7\&quot;&gt;渠道列表&lt;/a&gt;。 注：如果传入了指定支付渠道，则用户只能用指定内的渠道支付，包括营销渠道也要指定才能使用。该参数可能导致用户支付受限，慎用。
        /// </summary>
        /// <value>指定支付渠道。 用户只能使用指定的渠道进行支付，多个渠道以逗号分割。 与disable_pay_channels互斥，支持传入的值：&lt;a target&#x3D;\&quot;_blank\&quot; href&#x3D;\&quot;https://docs.open.alipay.com/common/wifww7\&quot;&gt;渠道列表&lt;/a&gt;。 注：如果传入了指定支付渠道，则用户只能用指定内的渠道支付，包括营销渠道也要指定才能使用。该参数可能导致用户支付受限，慎用。</value>
        [DataMember(Name = "enable_pay_channels", EmitDefaultValue = false)]
        public string EnablePayChannels { get; set; }

        /// <summary>
        /// Gets or Sets ExtUserInfo
        /// </summary>
        [DataMember(Name = "ext_user_info", EmitDefaultValue = false)]
        public ExtUserInfo ExtUserInfo { get; set; }

        /// <summary>
        /// Gets or Sets ExtendParams
        /// </summary>
        [DataMember(Name = "extend_params", EmitDefaultValue = false)]
        public ExtendParams ExtendParams { get; set; }

        /// <summary>
        /// 订单包含的商品列表信息，json格式。
        /// </summary>
        /// <value>订单包含的商品列表信息，json格式。</value>
        [DataMember(Name = "goods_detail", EmitDefaultValue = false)]
        public List<GoodsDetail> GoodsDetail { get; set; }

        /// <summary>
        /// Gets or Sets LogisticsDetail
        /// </summary>
        [DataMember(Name = "logistics_detail", EmitDefaultValue = false)]
        public LogisticsDetail LogisticsDetail { get; set; }

        /// <summary>
        /// 商户的原始订单号
        /// </summary>
        /// <value>商户的原始订单号</value>
        [DataMember(Name = "merchant_order_no", EmitDefaultValue = false)]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 通知地址
        /// </summary>
        /// <value>通知地址</value>
        [DataMember(Name = "notify_url", EmitDefaultValue = false)]
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 小程序支付中，商户实际经营主体的小程序应用的appid
        /// </summary>
        /// <value>小程序支付中，商户实际经营主体的小程序应用的appid</value>
        [DataMember(Name = "op_app_id", EmitDefaultValue = false)]
        public string OpAppId { get; set; }

        /// <summary>
        /// 买家支付宝用户唯一标识（商户实际经营主体的小程序应用关联的买家open_id）
        /// </summary>
        /// <value>买家支付宝用户唯一标识（商户实际经营主体的小程序应用关联的买家open_id）</value>
        [DataMember(Name = "op_buyer_open_id", EmitDefaultValue = false)]
        public string OpBuyerOpenId { get; set; }

        /// <summary>
        /// 商户操作员编号。
        /// </summary>
        /// <value>商户操作员编号。</value>
        [DataMember(Name = "operator_id", EmitDefaultValue = false)]
        public string OperatorId { get; set; }

        /// <summary>
        /// 商户订单号。 由商家自定义，64个字符以内，仅支持字母、数字、下划线且需保证在商户端不重复。
        /// </summary>
        /// <value>商户订单号。 由商家自定义，64个字符以内，仅支持字母、数字、下划线且需保证在商户端不重复。</value>
        [DataMember(Name = "out_trade_no", EmitDefaultValue = false)]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 公用回传参数。 如果请求时传递了该参数，支付宝会在异步通知时将该参数原样返回。
        /// </summary>
        /// <value>公用回传参数。 如果请求时传递了该参数，支付宝会在异步通知时将该参数原样返回。</value>
        [DataMember(Name = "passback_params", EmitDefaultValue = false)]
        public string PassbackParams { get; set; }

        /// <summary>
        /// 产品码。 商家和支付宝签约的产品码。 枚举值（点击查看签约情况）： &lt;a target&#x3D;\&quot;_blank\&quot; href&#x3D;\&quot;https://opensupport.alipay.com/support/codelab/detail/486/487\&quot;&gt;FACE_TO_FACE_PAYMENT&lt;/a&gt;：当面付产品； 默认值为FACE_TO_FACE_PAYMENT。
        /// </summary>
        /// <value>产品码。 商家和支付宝签约的产品码。 枚举值（点击查看签约情况）： &lt;a target&#x3D;\&quot;_blank\&quot; href&#x3D;\&quot;https://opensupport.alipay.com/support/codelab/detail/486/487\&quot;&gt;FACE_TO_FACE_PAYMENT&lt;/a&gt;：当面付产品； 默认值为FACE_TO_FACE_PAYMENT。</value>
        [DataMember(Name = "product_code", EmitDefaultValue = false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// 返回参数选项。 商户通过传递该参数来定制需要额外返回的信息字段，数组格式。包括但不限于：[\&quot;enterprise_pay_info\&quot;,\&quot;hyb_amount\&quot;]
        /// </summary>
        /// <value>返回参数选项。 商户通过传递该参数来定制需要额外返回的信息字段，数组格式。包括但不限于：[\&quot;enterprise_pay_info\&quot;,\&quot;hyb_amount\&quot;]</value>
        [DataMember(Name = "query_options", EmitDefaultValue = false)]
        public List<string> QueryOptions { get; set; }

        /// <summary>
        /// Gets or Sets ReceiverAddressInfo
        /// </summary>
        [DataMember(Name = "receiver_address_info", EmitDefaultValue = false)]
        public ReceiverAddressInfo ReceiverAddressInfo { get; set; }

        /// <summary>
        /// Gets or Sets RoyaltyInfo
        /// </summary>
        [DataMember(Name = "royalty_info", EmitDefaultValue = false)]
        public RoyaltyInfo RoyaltyInfo { get; set; }

        /// <summary>
        /// 卖家支付宝用户ID。 当需要指定收款账号时，通过该参数传入，如果该值为空，则默认为商户签约账号对应的支付宝用户ID。 收款账号优先级规则：门店绑定的收款账户&gt;请求传入的seller_id&gt;商户签约账号对应的支付宝用户ID； 注：直付通和机构间联场景下seller_id无需传入或者保持跟pid一致； 如果传入的seller_id与pid不一致，需要联系支付宝小二配置收款关系；
        /// </summary>
        /// <value>卖家支付宝用户ID。 当需要指定收款账号时，通过该参数传入，如果该值为空，则默认为商户签约账号对应的支付宝用户ID。 收款账号优先级规则：门店绑定的收款账户&gt;请求传入的seller_id&gt;商户签约账号对应的支付宝用户ID； 注：直付通和机构间联场景下seller_id无需传入或者保持跟pid一致； 如果传入的seller_id与pid不一致，需要联系支付宝小二配置收款关系；</value>
        [DataMember(Name = "seller_id", EmitDefaultValue = false)]
        public string SellerId { get; set; }

        /// <summary>
        /// Gets or Sets SettleInfo
        /// </summary>
        [DataMember(Name = "settle_info", EmitDefaultValue = false)]
        public SettleInfo SettleInfo { get; set; }

        /// <summary>
        /// 商户门店编号。 指商户创建门店时输入的门店编号。
        /// </summary>
        /// <value>商户门店编号。 指商户创建门店时输入的门店编号。</value>
        [DataMember(Name = "store_id", EmitDefaultValue = false)]
        public string StoreId { get; set; }

        /// <summary>
        /// Gets or Sets SubMerchant
        /// </summary>
        [DataMember(Name = "sub_merchant", EmitDefaultValue = false)]
        public SubMerchant SubMerchant { get; set; }

        /// <summary>
        /// 订单标题。 注意：不可使用特殊字符，如 /，&#x3D;，&amp; 等。
        /// </summary>
        /// <value>订单标题。 注意：不可使用特殊字符，如 /，&#x3D;，&amp; 等。</value>
        [DataMember(Name = "subject", EmitDefaultValue = false)]
        public string Subject { get; set; }

        /// <summary>
        /// 商户机具终端编号。
        /// </summary>
        /// <value>商户机具终端编号。</value>
        [DataMember(Name = "terminal_id", EmitDefaultValue = false)]
        public string TerminalId { get; set; }

        /// <summary>
        /// 订单绝对超时时间。 格式为yyyy-MM-dd HH:mm:ss。 注：time_expire和timeout_express两者只需传入一个或者都不传，如果两者都传，优先使用time_expire。
        /// </summary>
        /// <value>订单绝对超时时间。 格式为yyyy-MM-dd HH:mm:ss。 注：time_expire和timeout_express两者只需传入一个或者都不传，如果两者都传，优先使用time_expire。</value>
        [DataMember(Name = "time_expire", EmitDefaultValue = false)]
        public string TimeExpire { get; set; }

        /// <summary>
        /// 订单相对超时时间。从交易创建时间开始计算。 该笔订单允许的最晚付款时间，逾期将关闭交易。取值范围：1m～15d。m-分钟，h-小时，d-天，1c-当天（1c-当天的情况下，无论交易何时创建，都在0点关闭）。 该参数数值不接受小数点， 如 1.5h，可转换为 90m。 当面付场景默认值为3h。 注：time_expire和timeout_express两者只需传入一个或者都不传，如果两者都传，优先使用time_expire。
        /// </summary>
        /// <value>订单相对超时时间。从交易创建时间开始计算。 该笔订单允许的最晚付款时间，逾期将关闭交易。取值范围：1m～15d。m-分钟，h-小时，d-天，1c-当天（1c-当天的情况下，无论交易何时创建，都在0点关闭）。 该参数数值不接受小数点， 如 1.5h，可转换为 90m。 当面付场景默认值为3h。 注：time_expire和timeout_express两者只需传入一个或者都不传，如果两者都传，优先使用time_expire。</value>
        [DataMember(Name = "timeout_express", EmitDefaultValue = false)]
        public string TimeoutExpress { get; set; }

        /// <summary>
        /// 订单总金额。 单位为元，精确到小数点后两位，取值范围：[0.01,100000000] 。
        /// </summary>
        /// <value>订单总金额。 单位为元，精确到小数点后两位，取值范围：[0.01,100000000] 。</value>
        [DataMember(Name = "total_amount", EmitDefaultValue = false)]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 不可打折金额。 不参与优惠计算的金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]。  如果同时传入了【可打折金额】、【不可打折金额】和【订单总金额】，则必须满足如下条件：【订单总金额】&#x3D;【可打折金额】+【不可打折金额】。 如果订单金额全部参与优惠计算，则【可打折金额】和【不可打折金额】都无需传入。
        /// </summary>
        /// <value>不可打折金额。 不参与优惠计算的金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]。  如果同时传入了【可打折金额】、【不可打折金额】和【订单总金额】，则必须满足如下条件：【订单总金额】&#x3D;【可打折金额】+【不可打折金额】。 如果订单金额全部参与优惠计算，则【可打折金额】和【不可打折金额】都无需传入。</value>
        [DataMember(Name = "undiscountable_amount", EmitDefaultValue = false)]
        public string UndiscountableAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayTradeCreateModel {\n");
            sb.Append("  AgreementSignParams: ").Append(AgreementSignParams).Append("\n");
            sb.Append("  AlipayStoreId: ").Append(AlipayStoreId).Append("\n");
            sb.Append("  BkagentReqInfo: ").Append(BkagentReqInfo).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  BusinessParams: ").Append(BusinessParams).Append("\n");
            sb.Append("  BuyerId: ").Append(BuyerId).Append("\n");
            sb.Append("  BuyerLogonId: ").Append(BuyerLogonId).Append("\n");
            sb.Append("  BuyerOpenId: ").Append(BuyerOpenId).Append("\n");
            sb.Append("  DisablePayChannels: ").Append(DisablePayChannels).Append("\n");
            sb.Append("  DiscountableAmount: ").Append(DiscountableAmount).Append("\n");
            sb.Append("  EnablePayChannels: ").Append(EnablePayChannels).Append("\n");
            sb.Append("  ExtUserInfo: ").Append(ExtUserInfo).Append("\n");
            sb.Append("  ExtendParams: ").Append(ExtendParams).Append("\n");
            sb.Append("  GoodsDetail: ").Append(GoodsDetail).Append("\n");
            sb.Append("  LogisticsDetail: ").Append(LogisticsDetail).Append("\n");
            sb.Append("  MerchantOrderNo: ").Append(MerchantOrderNo).Append("\n");
            sb.Append("  NotifyUrl: ").Append(NotifyUrl).Append("\n");
            sb.Append("  OpAppId: ").Append(OpAppId).Append("\n");
            sb.Append("  OpBuyerOpenId: ").Append(OpBuyerOpenId).Append("\n");
            sb.Append("  OperatorId: ").Append(OperatorId).Append("\n");
            sb.Append("  OutTradeNo: ").Append(OutTradeNo).Append("\n");
            sb.Append("  PassbackParams: ").Append(PassbackParams).Append("\n");
            sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
            sb.Append("  QueryOptions: ").Append(QueryOptions).Append("\n");
            sb.Append("  ReceiverAddressInfo: ").Append(ReceiverAddressInfo).Append("\n");
            sb.Append("  RoyaltyInfo: ").Append(RoyaltyInfo).Append("\n");
            sb.Append("  SellerId: ").Append(SellerId).Append("\n");
            sb.Append("  SettleInfo: ").Append(SettleInfo).Append("\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  SubMerchant: ").Append(SubMerchant).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  TerminalId: ").Append(TerminalId).Append("\n");
            sb.Append("  TimeExpire: ").Append(TimeExpire).Append("\n");
            sb.Append("  TimeoutExpress: ").Append(TimeoutExpress).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  UndiscountableAmount: ").Append(UndiscountableAmount).Append("\n");
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
            return this.Equals(input as AlipayTradeCreateModel);
        }

        /// <summary>
        /// Returns true if AlipayTradeCreateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayTradeCreateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayTradeCreateModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AgreementSignParams == input.AgreementSignParams ||
                    (this.AgreementSignParams != null &&
                    this.AgreementSignParams.Equals(input.AgreementSignParams))
                ) && 
                (
                    this.AlipayStoreId == input.AlipayStoreId ||
                    (this.AlipayStoreId != null &&
                    this.AlipayStoreId.Equals(input.AlipayStoreId))
                ) && 
                (
                    this.BkagentReqInfo == input.BkagentReqInfo ||
                    (this.BkagentReqInfo != null &&
                    this.BkagentReqInfo.Equals(input.BkagentReqInfo))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.BusinessParams == input.BusinessParams ||
                    (this.BusinessParams != null &&
                    this.BusinessParams.Equals(input.BusinessParams))
                ) && 
                (
                    this.BuyerId == input.BuyerId ||
                    (this.BuyerId != null &&
                    this.BuyerId.Equals(input.BuyerId))
                ) && 
                (
                    this.BuyerLogonId == input.BuyerLogonId ||
                    (this.BuyerLogonId != null &&
                    this.BuyerLogonId.Equals(input.BuyerLogonId))
                ) && 
                (
                    this.BuyerOpenId == input.BuyerOpenId ||
                    (this.BuyerOpenId != null &&
                    this.BuyerOpenId.Equals(input.BuyerOpenId))
                ) && 
                (
                    this.DisablePayChannels == input.DisablePayChannels ||
                    (this.DisablePayChannels != null &&
                    this.DisablePayChannels.Equals(input.DisablePayChannels))
                ) && 
                (
                    this.DiscountableAmount == input.DiscountableAmount ||
                    (this.DiscountableAmount != null &&
                    this.DiscountableAmount.Equals(input.DiscountableAmount))
                ) && 
                (
                    this.EnablePayChannels == input.EnablePayChannels ||
                    (this.EnablePayChannels != null &&
                    this.EnablePayChannels.Equals(input.EnablePayChannels))
                ) && 
                (
                    this.ExtUserInfo == input.ExtUserInfo ||
                    (this.ExtUserInfo != null &&
                    this.ExtUserInfo.Equals(input.ExtUserInfo))
                ) && 
                (
                    this.ExtendParams == input.ExtendParams ||
                    (this.ExtendParams != null &&
                    this.ExtendParams.Equals(input.ExtendParams))
                ) && 
                (
                    this.GoodsDetail == input.GoodsDetail ||
                    this.GoodsDetail != null &&
                    input.GoodsDetail != null &&
                    this.GoodsDetail.SequenceEqual(input.GoodsDetail)
                ) && 
                (
                    this.LogisticsDetail == input.LogisticsDetail ||
                    (this.LogisticsDetail != null &&
                    this.LogisticsDetail.Equals(input.LogisticsDetail))
                ) && 
                (
                    this.MerchantOrderNo == input.MerchantOrderNo ||
                    (this.MerchantOrderNo != null &&
                    this.MerchantOrderNo.Equals(input.MerchantOrderNo))
                ) && 
                (
                    this.NotifyUrl == input.NotifyUrl ||
                    (this.NotifyUrl != null &&
                    this.NotifyUrl.Equals(input.NotifyUrl))
                ) && 
                (
                    this.OpAppId == input.OpAppId ||
                    (this.OpAppId != null &&
                    this.OpAppId.Equals(input.OpAppId))
                ) && 
                (
                    this.OpBuyerOpenId == input.OpBuyerOpenId ||
                    (this.OpBuyerOpenId != null &&
                    this.OpBuyerOpenId.Equals(input.OpBuyerOpenId))
                ) && 
                (
                    this.OperatorId == input.OperatorId ||
                    (this.OperatorId != null &&
                    this.OperatorId.Equals(input.OperatorId))
                ) && 
                (
                    this.OutTradeNo == input.OutTradeNo ||
                    (this.OutTradeNo != null &&
                    this.OutTradeNo.Equals(input.OutTradeNo))
                ) && 
                (
                    this.PassbackParams == input.PassbackParams ||
                    (this.PassbackParams != null &&
                    this.PassbackParams.Equals(input.PassbackParams))
                ) && 
                (
                    this.ProductCode == input.ProductCode ||
                    (this.ProductCode != null &&
                    this.ProductCode.Equals(input.ProductCode))
                ) && 
                (
                    this.QueryOptions == input.QueryOptions ||
                    this.QueryOptions != null &&
                    input.QueryOptions != null &&
                    this.QueryOptions.SequenceEqual(input.QueryOptions)
                ) && 
                (
                    this.ReceiverAddressInfo == input.ReceiverAddressInfo ||
                    (this.ReceiverAddressInfo != null &&
                    this.ReceiverAddressInfo.Equals(input.ReceiverAddressInfo))
                ) && 
                (
                    this.RoyaltyInfo == input.RoyaltyInfo ||
                    (this.RoyaltyInfo != null &&
                    this.RoyaltyInfo.Equals(input.RoyaltyInfo))
                ) && 
                (
                    this.SellerId == input.SellerId ||
                    (this.SellerId != null &&
                    this.SellerId.Equals(input.SellerId))
                ) && 
                (
                    this.SettleInfo == input.SettleInfo ||
                    (this.SettleInfo != null &&
                    this.SettleInfo.Equals(input.SettleInfo))
                ) && 
                (
                    this.StoreId == input.StoreId ||
                    (this.StoreId != null &&
                    this.StoreId.Equals(input.StoreId))
                ) && 
                (
                    this.SubMerchant == input.SubMerchant ||
                    (this.SubMerchant != null &&
                    this.SubMerchant.Equals(input.SubMerchant))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.TerminalId == input.TerminalId ||
                    (this.TerminalId != null &&
                    this.TerminalId.Equals(input.TerminalId))
                ) && 
                (
                    this.TimeExpire == input.TimeExpire ||
                    (this.TimeExpire != null &&
                    this.TimeExpire.Equals(input.TimeExpire))
                ) && 
                (
                    this.TimeoutExpress == input.TimeoutExpress ||
                    (this.TimeoutExpress != null &&
                    this.TimeoutExpress.Equals(input.TimeoutExpress))
                ) && 
                (
                    this.TotalAmount == input.TotalAmount ||
                    (this.TotalAmount != null &&
                    this.TotalAmount.Equals(input.TotalAmount))
                ) && 
                (
                    this.UndiscountableAmount == input.UndiscountableAmount ||
                    (this.UndiscountableAmount != null &&
                    this.UndiscountableAmount.Equals(input.UndiscountableAmount))
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
                if (this.AgreementSignParams != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementSignParams.GetHashCode();
                }
                if (this.AlipayStoreId != null)
                {
                    hashCode = (hashCode * 59) + this.AlipayStoreId.GetHashCode();
                }
                if (this.BkagentReqInfo != null)
                {
                    hashCode = (hashCode * 59) + this.BkagentReqInfo.GetHashCode();
                }
                if (this.Body != null)
                {
                    hashCode = (hashCode * 59) + this.Body.GetHashCode();
                }
                if (this.BusinessParams != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessParams.GetHashCode();
                }
                if (this.BuyerId != null)
                {
                    hashCode = (hashCode * 59) + this.BuyerId.GetHashCode();
                }
                if (this.BuyerLogonId != null)
                {
                    hashCode = (hashCode * 59) + this.BuyerLogonId.GetHashCode();
                }
                if (this.BuyerOpenId != null)
                {
                    hashCode = (hashCode * 59) + this.BuyerOpenId.GetHashCode();
                }
                if (this.DisablePayChannels != null)
                {
                    hashCode = (hashCode * 59) + this.DisablePayChannels.GetHashCode();
                }
                if (this.DiscountableAmount != null)
                {
                    hashCode = (hashCode * 59) + this.DiscountableAmount.GetHashCode();
                }
                if (this.EnablePayChannels != null)
                {
                    hashCode = (hashCode * 59) + this.EnablePayChannels.GetHashCode();
                }
                if (this.ExtUserInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ExtUserInfo.GetHashCode();
                }
                if (this.ExtendParams != null)
                {
                    hashCode = (hashCode * 59) + this.ExtendParams.GetHashCode();
                }
                if (this.GoodsDetail != null)
                {
                    hashCode = (hashCode * 59) + this.GoodsDetail.GetHashCode();
                }
                if (this.LogisticsDetail != null)
                {
                    hashCode = (hashCode * 59) + this.LogisticsDetail.GetHashCode();
                }
                if (this.MerchantOrderNo != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantOrderNo.GetHashCode();
                }
                if (this.NotifyUrl != null)
                {
                    hashCode = (hashCode * 59) + this.NotifyUrl.GetHashCode();
                }
                if (this.OpAppId != null)
                {
                    hashCode = (hashCode * 59) + this.OpAppId.GetHashCode();
                }
                if (this.OpBuyerOpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpBuyerOpenId.GetHashCode();
                }
                if (this.OperatorId != null)
                {
                    hashCode = (hashCode * 59) + this.OperatorId.GetHashCode();
                }
                if (this.OutTradeNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutTradeNo.GetHashCode();
                }
                if (this.PassbackParams != null)
                {
                    hashCode = (hashCode * 59) + this.PassbackParams.GetHashCode();
                }
                if (this.ProductCode != null)
                {
                    hashCode = (hashCode * 59) + this.ProductCode.GetHashCode();
                }
                if (this.QueryOptions != null)
                {
                    hashCode = (hashCode * 59) + this.QueryOptions.GetHashCode();
                }
                if (this.ReceiverAddressInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ReceiverAddressInfo.GetHashCode();
                }
                if (this.RoyaltyInfo != null)
                {
                    hashCode = (hashCode * 59) + this.RoyaltyInfo.GetHashCode();
                }
                if (this.SellerId != null)
                {
                    hashCode = (hashCode * 59) + this.SellerId.GetHashCode();
                }
                if (this.SettleInfo != null)
                {
                    hashCode = (hashCode * 59) + this.SettleInfo.GetHashCode();
                }
                if (this.StoreId != null)
                {
                    hashCode = (hashCode * 59) + this.StoreId.GetHashCode();
                }
                if (this.SubMerchant != null)
                {
                    hashCode = (hashCode * 59) + this.SubMerchant.GetHashCode();
                }
                if (this.Subject != null)
                {
                    hashCode = (hashCode * 59) + this.Subject.GetHashCode();
                }
                if (this.TerminalId != null)
                {
                    hashCode = (hashCode * 59) + this.TerminalId.GetHashCode();
                }
                if (this.TimeExpire != null)
                {
                    hashCode = (hashCode * 59) + this.TimeExpire.GetHashCode();
                }
                if (this.TimeoutExpress != null)
                {
                    hashCode = (hashCode * 59) + this.TimeoutExpress.GetHashCode();
                }
                if (this.TotalAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TotalAmount.GetHashCode();
                }
                if (this.UndiscountableAmount != null)
                {
                    hashCode = (hashCode * 59) + this.UndiscountableAmount.GetHashCode();
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
