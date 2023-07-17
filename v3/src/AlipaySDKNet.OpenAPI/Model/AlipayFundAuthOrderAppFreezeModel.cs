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
    /// AlipayFundAuthOrderAppFreezeModel
    /// </summary>
    [DataContract(Name = "AlipayFundAuthOrderAppFreezeModel")]
    public partial class AlipayFundAuthOrderAppFreezeModel : IEquatable<AlipayFundAuthOrderAppFreezeModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundAuthOrderAppFreezeModel" /> class.
        /// </summary>
        /// <param name="amount">需要冻结的金额，单位为：元（人民币），精确到小数点后两位。 取值范围：[0.01,100000000.00].</param>
        /// <param name="businessParams">业务参数，如风控参数outRiskInfo等。.</param>
        /// <param name="disablePayChannels">无特殊需要请勿传入；商户可用该参数禁用支付渠道。 传入后用户不可使用列表中的渠道进行支付，目前支持两种禁用渠道：信用卡快捷（OPTIMIZED_MOTO）、信用卡卡通（BIGAMOUNT_CREDIT_CARTOON）。与可用支付渠道不能同时传入.</param>
        /// <param name="enablePayChannels">无特殊需要请勿传入；商户可用该参数指定支付渠道。 传入后用户仅能使用列表中的渠道进行支付，目前支持三种渠道，余额宝（MONEY_FUND）、花呗（PCREDIT_PAY）以及芝麻信用（CREDITZHIMA）。与禁用支付渠道不可同时传入.</param>
        /// <param name="extraParam">业务扩展参数，用于特定业务信息的传递，json格式。 1、category，信用类目，信用预授权场景必传，具体类目信息见https://opendocs.alipay.com/open/10719； 2、serviceId，信用服务id，信用预授权场景必传，需要联系芝麻客服获取，https://cshall.alipay.com/enterprise/index.htm?sourceId&#x3D;pc_zhima（右上角“有问题点我”进入咨询）； 3、creditExtInfo，信用参数，可选，如有需要请与芝麻约定后传入，信用服务说明见https://opendocs.alipay.com/open/11157/qlsxya.</param>
        /// <param name="identityParams">无特殊需要请勿传入；买家实名信息。 传入后支付宝会比对买家在支付宝端的实名信息。包含两个可选key： 1.identity_hash，买家姓名拼接身份证号后，使用SHA256摘要方式与UTF8编码后的hash值，返回的十六进制字符串，例如 “张三4566498798498498498498”对应的identity_hash应为“acc2b92ffc5ed9b472faa19748f10045c30434132784f774b00216a56b8841c6” 2.alipay_user_id，买家uid.</param>
        /// <param name="notifyUrl">通知地址.</param>
        /// <param name="orderTitle">订单标题。 业务订单的简单描述，如商品名称等.</param>
        /// <param name="outOrderNo">商户授权资金订单号。 商家自定义需保证在商户端不重复。仅支持字母、数字、下划线。.</param>
        /// <param name="outRequestNo">商户本次资金操作的请求流水号，用于标示请求流水的唯一性。 可与out_order_no相同，仅支持字母、数字、下划线。.</param>
        /// <param name="payTimeout">预授权订单相对超时时间。从商户客户端请求时间开始计算。 预授权订单允许的最晚授权时间，逾期将关闭该笔订单。取值范围：1m～15d。m-分钟，h-小时，d-天。 该参数数值不接受小数点， 如 1.5h，可转换为90m。 默认为15m。.</param>
        /// <param name="payeeLogonId">收款账户的支付宝登录号（email或手机号）。 如果传入则会校验该登录号对应的账号是否具备当前商户收款权限，如果商户希望用户能够使用花呗，则用户号(payee_user_id)和登录号(payee_logon_id)两者必须传入其一.</param>
        /// <param name="payeeUserId">收款账户的支付宝用户号。 以2088开头的16位纯数字，如果传入则会校验该账号是否具备当前商户收款权限，如果商户希望用户能够使用花呗，则用户号(payee_user_id)和登录号(payee_logon_id)两者必须传入其一.</param>
        /// <param name="productCode">销售产品码。 支付宝预授权产品固定为 PRE_AUTH_ONLINE.</param>
        /// <param name="sceneCode">场景码，用于区分预授权不同业务场景。如：当面预授权通用场景（O2O_AUTH_COMMON_SCENE）、支付宝预授权通用场景（ONLINE_AUTH_COMMON_SCENE）、境外当面预授权通用场景（OVERSEAS_O2O_AUTH_COMMON_SCENE）、境外支付预授权通用场景（OVERSEAS_ONLINE_AUTH_COMMON_SCENE）等.</param>
        /// <param name="settleCurrency">商户指定的结算币种。支持澳元：AUD, 新西兰元：NZD, 台币：TWD, 美元：USD, 欧元：EUR, 英镑：GBP.</param>
        /// <param name="timeoutExpress">预授权订单相对超时时间。从商户客户端请求时间开始计算。 预授权订单允许的最晚授权时间，逾期将关闭该笔订单。取值范围：1m～15d。m-分钟，h-小时，d-天。 该参数数值不接受小数点， 如 1.5h，可转换为90m。 默认为15m。.</param>
        /// <param name="transCurrency">标价币种,  amount 对应的币种单位。支持澳元：AUD, 新西兰元：NZD, 台币：TWD, 美元：USD, 欧元：EUR, 英镑：GBP, 人民币：CNY.</param>
        public AlipayFundAuthOrderAppFreezeModel(string amount = default(string), string businessParams = default(string), string disablePayChannels = default(string), string enablePayChannels = default(string), string extraParam = default(string), string identityParams = default(string), string notifyUrl = default(string), string orderTitle = default(string), string outOrderNo = default(string), string outRequestNo = default(string), string payTimeout = default(string), string payeeLogonId = default(string), string payeeUserId = default(string), string productCode = default(string), string sceneCode = default(string), string settleCurrency = default(string), string timeoutExpress = default(string), string transCurrency = default(string))
        {
            this.Amount = amount;
            this.BusinessParams = businessParams;
            this.DisablePayChannels = disablePayChannels;
            this.EnablePayChannels = enablePayChannels;
            this.ExtraParam = extraParam;
            this.IdentityParams = identityParams;
            this.NotifyUrl = notifyUrl;
            this.OrderTitle = orderTitle;
            this.OutOrderNo = outOrderNo;
            this.OutRequestNo = outRequestNo;
            this.PayTimeout = payTimeout;
            this.PayeeLogonId = payeeLogonId;
            this.PayeeUserId = payeeUserId;
            this.ProductCode = productCode;
            this.SceneCode = sceneCode;
            this.SettleCurrency = settleCurrency;
            this.TimeoutExpress = timeoutExpress;
            this.TransCurrency = transCurrency;
        }

        /// <summary>
        /// 需要冻结的金额，单位为：元（人民币），精确到小数点后两位。 取值范围：[0.01,100000000.00]
        /// </summary>
        /// <value>需要冻结的金额，单位为：元（人民币），精确到小数点后两位。 取值范围：[0.01,100000000.00]</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// 业务参数，如风控参数outRiskInfo等。
        /// </summary>
        /// <value>业务参数，如风控参数outRiskInfo等。</value>
        [DataMember(Name = "business_params", EmitDefaultValue = false)]
        public string BusinessParams { get; set; }

        /// <summary>
        /// 无特殊需要请勿传入；商户可用该参数禁用支付渠道。 传入后用户不可使用列表中的渠道进行支付，目前支持两种禁用渠道：信用卡快捷（OPTIMIZED_MOTO）、信用卡卡通（BIGAMOUNT_CREDIT_CARTOON）。与可用支付渠道不能同时传入
        /// </summary>
        /// <value>无特殊需要请勿传入；商户可用该参数禁用支付渠道。 传入后用户不可使用列表中的渠道进行支付，目前支持两种禁用渠道：信用卡快捷（OPTIMIZED_MOTO）、信用卡卡通（BIGAMOUNT_CREDIT_CARTOON）。与可用支付渠道不能同时传入</value>
        [DataMember(Name = "disable_pay_channels", EmitDefaultValue = false)]
        public string DisablePayChannels { get; set; }

        /// <summary>
        /// 无特殊需要请勿传入；商户可用该参数指定支付渠道。 传入后用户仅能使用列表中的渠道进行支付，目前支持三种渠道，余额宝（MONEY_FUND）、花呗（PCREDIT_PAY）以及芝麻信用（CREDITZHIMA）。与禁用支付渠道不可同时传入
        /// </summary>
        /// <value>无特殊需要请勿传入；商户可用该参数指定支付渠道。 传入后用户仅能使用列表中的渠道进行支付，目前支持三种渠道，余额宝（MONEY_FUND）、花呗（PCREDIT_PAY）以及芝麻信用（CREDITZHIMA）。与禁用支付渠道不可同时传入</value>
        [DataMember(Name = "enable_pay_channels", EmitDefaultValue = false)]
        public string EnablePayChannels { get; set; }

        /// <summary>
        /// 业务扩展参数，用于特定业务信息的传递，json格式。 1、category，信用类目，信用预授权场景必传，具体类目信息见https://opendocs.alipay.com/open/10719； 2、serviceId，信用服务id，信用预授权场景必传，需要联系芝麻客服获取，https://cshall.alipay.com/enterprise/index.htm?sourceId&#x3D;pc_zhima（右上角“有问题点我”进入咨询）； 3、creditExtInfo，信用参数，可选，如有需要请与芝麻约定后传入，信用服务说明见https://opendocs.alipay.com/open/11157/qlsxya
        /// </summary>
        /// <value>业务扩展参数，用于特定业务信息的传递，json格式。 1、category，信用类目，信用预授权场景必传，具体类目信息见https://opendocs.alipay.com/open/10719； 2、serviceId，信用服务id，信用预授权场景必传，需要联系芝麻客服获取，https://cshall.alipay.com/enterprise/index.htm?sourceId&#x3D;pc_zhima（右上角“有问题点我”进入咨询）； 3、creditExtInfo，信用参数，可选，如有需要请与芝麻约定后传入，信用服务说明见https://opendocs.alipay.com/open/11157/qlsxya</value>
        [DataMember(Name = "extra_param", EmitDefaultValue = false)]
        public string ExtraParam { get; set; }

        /// <summary>
        /// 无特殊需要请勿传入；买家实名信息。 传入后支付宝会比对买家在支付宝端的实名信息。包含两个可选key： 1.identity_hash，买家姓名拼接身份证号后，使用SHA256摘要方式与UTF8编码后的hash值，返回的十六进制字符串，例如 “张三4566498798498498498498”对应的identity_hash应为“acc2b92ffc5ed9b472faa19748f10045c30434132784f774b00216a56b8841c6” 2.alipay_user_id，买家uid
        /// </summary>
        /// <value>无特殊需要请勿传入；买家实名信息。 传入后支付宝会比对买家在支付宝端的实名信息。包含两个可选key： 1.identity_hash，买家姓名拼接身份证号后，使用SHA256摘要方式与UTF8编码后的hash值，返回的十六进制字符串，例如 “张三4566498798498498498498”对应的identity_hash应为“acc2b92ffc5ed9b472faa19748f10045c30434132784f774b00216a56b8841c6” 2.alipay_user_id，买家uid</value>
        [DataMember(Name = "identity_params", EmitDefaultValue = false)]
        public string IdentityParams { get; set; }

        /// <summary>
        /// 通知地址
        /// </summary>
        /// <value>通知地址</value>
        [DataMember(Name = "notify_url", EmitDefaultValue = false)]
        public string NotifyUrl { get; set; }

        /// <summary>
        /// 订单标题。 业务订单的简单描述，如商品名称等
        /// </summary>
        /// <value>订单标题。 业务订单的简单描述，如商品名称等</value>
        [DataMember(Name = "order_title", EmitDefaultValue = false)]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 商户授权资金订单号。 商家自定义需保证在商户端不重复。仅支持字母、数字、下划线。
        /// </summary>
        /// <value>商户授权资金订单号。 商家自定义需保证在商户端不重复。仅支持字母、数字、下划线。</value>
        [DataMember(Name = "out_order_no", EmitDefaultValue = false)]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 商户本次资金操作的请求流水号，用于标示请求流水的唯一性。 可与out_order_no相同，仅支持字母、数字、下划线。
        /// </summary>
        /// <value>商户本次资金操作的请求流水号，用于标示请求流水的唯一性。 可与out_order_no相同，仅支持字母、数字、下划线。</value>
        [DataMember(Name = "out_request_no", EmitDefaultValue = false)]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 预授权订单相对超时时间。从商户客户端请求时间开始计算。 预授权订单允许的最晚授权时间，逾期将关闭该笔订单。取值范围：1m～15d。m-分钟，h-小时，d-天。 该参数数值不接受小数点， 如 1.5h，可转换为90m。 默认为15m。
        /// </summary>
        /// <value>预授权订单相对超时时间。从商户客户端请求时间开始计算。 预授权订单允许的最晚授权时间，逾期将关闭该笔订单。取值范围：1m～15d。m-分钟，h-小时，d-天。 该参数数值不接受小数点， 如 1.5h，可转换为90m。 默认为15m。</value>
        [DataMember(Name = "pay_timeout", EmitDefaultValue = false)]
        public string PayTimeout { get; set; }

        /// <summary>
        /// 收款账户的支付宝登录号（email或手机号）。 如果传入则会校验该登录号对应的账号是否具备当前商户收款权限，如果商户希望用户能够使用花呗，则用户号(payee_user_id)和登录号(payee_logon_id)两者必须传入其一
        /// </summary>
        /// <value>收款账户的支付宝登录号（email或手机号）。 如果传入则会校验该登录号对应的账号是否具备当前商户收款权限，如果商户希望用户能够使用花呗，则用户号(payee_user_id)和登录号(payee_logon_id)两者必须传入其一</value>
        [DataMember(Name = "payee_logon_id", EmitDefaultValue = false)]
        public string PayeeLogonId { get; set; }

        /// <summary>
        /// 收款账户的支付宝用户号。 以2088开头的16位纯数字，如果传入则会校验该账号是否具备当前商户收款权限，如果商户希望用户能够使用花呗，则用户号(payee_user_id)和登录号(payee_logon_id)两者必须传入其一
        /// </summary>
        /// <value>收款账户的支付宝用户号。 以2088开头的16位纯数字，如果传入则会校验该账号是否具备当前商户收款权限，如果商户希望用户能够使用花呗，则用户号(payee_user_id)和登录号(payee_logon_id)两者必须传入其一</value>
        [DataMember(Name = "payee_user_id", EmitDefaultValue = false)]
        public string PayeeUserId { get; set; }

        /// <summary>
        /// 销售产品码。 支付宝预授权产品固定为 PRE_AUTH_ONLINE
        /// </summary>
        /// <value>销售产品码。 支付宝预授权产品固定为 PRE_AUTH_ONLINE</value>
        [DataMember(Name = "product_code", EmitDefaultValue = false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// 场景码，用于区分预授权不同业务场景。如：当面预授权通用场景（O2O_AUTH_COMMON_SCENE）、支付宝预授权通用场景（ONLINE_AUTH_COMMON_SCENE）、境外当面预授权通用场景（OVERSEAS_O2O_AUTH_COMMON_SCENE）、境外支付预授权通用场景（OVERSEAS_ONLINE_AUTH_COMMON_SCENE）等
        /// </summary>
        /// <value>场景码，用于区分预授权不同业务场景。如：当面预授权通用场景（O2O_AUTH_COMMON_SCENE）、支付宝预授权通用场景（ONLINE_AUTH_COMMON_SCENE）、境外当面预授权通用场景（OVERSEAS_O2O_AUTH_COMMON_SCENE）、境外支付预授权通用场景（OVERSEAS_ONLINE_AUTH_COMMON_SCENE）等</value>
        [DataMember(Name = "scene_code", EmitDefaultValue = false)]
        public string SceneCode { get; set; }

        /// <summary>
        /// 商户指定的结算币种。支持澳元：AUD, 新西兰元：NZD, 台币：TWD, 美元：USD, 欧元：EUR, 英镑：GBP
        /// </summary>
        /// <value>商户指定的结算币种。支持澳元：AUD, 新西兰元：NZD, 台币：TWD, 美元：USD, 欧元：EUR, 英镑：GBP</value>
        [DataMember(Name = "settle_currency", EmitDefaultValue = false)]
        public string SettleCurrency { get; set; }

        /// <summary>
        /// 预授权订单相对超时时间。从商户客户端请求时间开始计算。 预授权订单允许的最晚授权时间，逾期将关闭该笔订单。取值范围：1m～15d。m-分钟，h-小时，d-天。 该参数数值不接受小数点， 如 1.5h，可转换为90m。 默认为15m。
        /// </summary>
        /// <value>预授权订单相对超时时间。从商户客户端请求时间开始计算。 预授权订单允许的最晚授权时间，逾期将关闭该笔订单。取值范围：1m～15d。m-分钟，h-小时，d-天。 该参数数值不接受小数点， 如 1.5h，可转换为90m。 默认为15m。</value>
        [DataMember(Name = "timeout_express", EmitDefaultValue = false)]
        public string TimeoutExpress { get; set; }

        /// <summary>
        /// 标价币种,  amount 对应的币种单位。支持澳元：AUD, 新西兰元：NZD, 台币：TWD, 美元：USD, 欧元：EUR, 英镑：GBP, 人民币：CNY
        /// </summary>
        /// <value>标价币种,  amount 对应的币种单位。支持澳元：AUD, 新西兰元：NZD, 台币：TWD, 美元：USD, 欧元：EUR, 英镑：GBP, 人民币：CNY</value>
        [DataMember(Name = "trans_currency", EmitDefaultValue = false)]
        public string TransCurrency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayFundAuthOrderAppFreezeModel {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BusinessParams: ").Append(BusinessParams).Append("\n");
            sb.Append("  DisablePayChannels: ").Append(DisablePayChannels).Append("\n");
            sb.Append("  EnablePayChannels: ").Append(EnablePayChannels).Append("\n");
            sb.Append("  ExtraParam: ").Append(ExtraParam).Append("\n");
            sb.Append("  IdentityParams: ").Append(IdentityParams).Append("\n");
            sb.Append("  NotifyUrl: ").Append(NotifyUrl).Append("\n");
            sb.Append("  OrderTitle: ").Append(OrderTitle).Append("\n");
            sb.Append("  OutOrderNo: ").Append(OutOrderNo).Append("\n");
            sb.Append("  OutRequestNo: ").Append(OutRequestNo).Append("\n");
            sb.Append("  PayTimeout: ").Append(PayTimeout).Append("\n");
            sb.Append("  PayeeLogonId: ").Append(PayeeLogonId).Append("\n");
            sb.Append("  PayeeUserId: ").Append(PayeeUserId).Append("\n");
            sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
            sb.Append("  SceneCode: ").Append(SceneCode).Append("\n");
            sb.Append("  SettleCurrency: ").Append(SettleCurrency).Append("\n");
            sb.Append("  TimeoutExpress: ").Append(TimeoutExpress).Append("\n");
            sb.Append("  TransCurrency: ").Append(TransCurrency).Append("\n");
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
            return this.Equals(input as AlipayFundAuthOrderAppFreezeModel);
        }

        /// <summary>
        /// Returns true if AlipayFundAuthOrderAppFreezeModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayFundAuthOrderAppFreezeModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayFundAuthOrderAppFreezeModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.BusinessParams == input.BusinessParams ||
                    (this.BusinessParams != null &&
                    this.BusinessParams.Equals(input.BusinessParams))
                ) && 
                (
                    this.DisablePayChannels == input.DisablePayChannels ||
                    (this.DisablePayChannels != null &&
                    this.DisablePayChannels.Equals(input.DisablePayChannels))
                ) && 
                (
                    this.EnablePayChannels == input.EnablePayChannels ||
                    (this.EnablePayChannels != null &&
                    this.EnablePayChannels.Equals(input.EnablePayChannels))
                ) && 
                (
                    this.ExtraParam == input.ExtraParam ||
                    (this.ExtraParam != null &&
                    this.ExtraParam.Equals(input.ExtraParam))
                ) && 
                (
                    this.IdentityParams == input.IdentityParams ||
                    (this.IdentityParams != null &&
                    this.IdentityParams.Equals(input.IdentityParams))
                ) && 
                (
                    this.NotifyUrl == input.NotifyUrl ||
                    (this.NotifyUrl != null &&
                    this.NotifyUrl.Equals(input.NotifyUrl))
                ) && 
                (
                    this.OrderTitle == input.OrderTitle ||
                    (this.OrderTitle != null &&
                    this.OrderTitle.Equals(input.OrderTitle))
                ) && 
                (
                    this.OutOrderNo == input.OutOrderNo ||
                    (this.OutOrderNo != null &&
                    this.OutOrderNo.Equals(input.OutOrderNo))
                ) && 
                (
                    this.OutRequestNo == input.OutRequestNo ||
                    (this.OutRequestNo != null &&
                    this.OutRequestNo.Equals(input.OutRequestNo))
                ) && 
                (
                    this.PayTimeout == input.PayTimeout ||
                    (this.PayTimeout != null &&
                    this.PayTimeout.Equals(input.PayTimeout))
                ) && 
                (
                    this.PayeeLogonId == input.PayeeLogonId ||
                    (this.PayeeLogonId != null &&
                    this.PayeeLogonId.Equals(input.PayeeLogonId))
                ) && 
                (
                    this.PayeeUserId == input.PayeeUserId ||
                    (this.PayeeUserId != null &&
                    this.PayeeUserId.Equals(input.PayeeUserId))
                ) && 
                (
                    this.ProductCode == input.ProductCode ||
                    (this.ProductCode != null &&
                    this.ProductCode.Equals(input.ProductCode))
                ) && 
                (
                    this.SceneCode == input.SceneCode ||
                    (this.SceneCode != null &&
                    this.SceneCode.Equals(input.SceneCode))
                ) && 
                (
                    this.SettleCurrency == input.SettleCurrency ||
                    (this.SettleCurrency != null &&
                    this.SettleCurrency.Equals(input.SettleCurrency))
                ) && 
                (
                    this.TimeoutExpress == input.TimeoutExpress ||
                    (this.TimeoutExpress != null &&
                    this.TimeoutExpress.Equals(input.TimeoutExpress))
                ) && 
                (
                    this.TransCurrency == input.TransCurrency ||
                    (this.TransCurrency != null &&
                    this.TransCurrency.Equals(input.TransCurrency))
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
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.BusinessParams != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessParams.GetHashCode();
                }
                if (this.DisablePayChannels != null)
                {
                    hashCode = (hashCode * 59) + this.DisablePayChannels.GetHashCode();
                }
                if (this.EnablePayChannels != null)
                {
                    hashCode = (hashCode * 59) + this.EnablePayChannels.GetHashCode();
                }
                if (this.ExtraParam != null)
                {
                    hashCode = (hashCode * 59) + this.ExtraParam.GetHashCode();
                }
                if (this.IdentityParams != null)
                {
                    hashCode = (hashCode * 59) + this.IdentityParams.GetHashCode();
                }
                if (this.NotifyUrl != null)
                {
                    hashCode = (hashCode * 59) + this.NotifyUrl.GetHashCode();
                }
                if (this.OrderTitle != null)
                {
                    hashCode = (hashCode * 59) + this.OrderTitle.GetHashCode();
                }
                if (this.OutOrderNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutOrderNo.GetHashCode();
                }
                if (this.OutRequestNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutRequestNo.GetHashCode();
                }
                if (this.PayTimeout != null)
                {
                    hashCode = (hashCode * 59) + this.PayTimeout.GetHashCode();
                }
                if (this.PayeeLogonId != null)
                {
                    hashCode = (hashCode * 59) + this.PayeeLogonId.GetHashCode();
                }
                if (this.PayeeUserId != null)
                {
                    hashCode = (hashCode * 59) + this.PayeeUserId.GetHashCode();
                }
                if (this.ProductCode != null)
                {
                    hashCode = (hashCode * 59) + this.ProductCode.GetHashCode();
                }
                if (this.SceneCode != null)
                {
                    hashCode = (hashCode * 59) + this.SceneCode.GetHashCode();
                }
                if (this.SettleCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.SettleCurrency.GetHashCode();
                }
                if (this.TimeoutExpress != null)
                {
                    hashCode = (hashCode * 59) + this.TimeoutExpress.GetHashCode();
                }
                if (this.TransCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.TransCurrency.GetHashCode();
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
