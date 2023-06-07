using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CertificateUseResult Data Structure.
    /// </summary>
    [Serializable]
    public class CertificateUseResult : AopObject
    {
        /// <summary>
        /// 三方码
        /// </summary>
        [XmlElement("code")]
        public string Code { get; set; }

        /// <summary>
        /// 核销准备返回的支付宝平台加密券码
        /// </summary>
        [XmlElement("encrypted_code")]
        public string EncryptedCode { get; set; }

        /// <summary>
        /// 结果说明
        /// </summary>
        [XmlElement("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 核销结果枚举
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }

        /// <summary>
        /// 核销操作单号,核销成功必填,撤销核销使用
        /// </summary>
        [XmlElement("use_order_no")]
        public string UseOrderNo { get; set; }
    }
}
