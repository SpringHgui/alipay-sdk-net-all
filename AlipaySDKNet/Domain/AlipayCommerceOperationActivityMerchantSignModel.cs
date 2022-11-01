using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceOperationActivityMerchantSignModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceOperationActivityMerchantSignModel : AopObject
    {
        /// <summary>
        /// 消费门槛（单位分）
        /// </summary>
        [XmlElement("consumption_threshold")]
        public long ConsumptionThreshold { get; set; }

        /// <summary>
        /// 优惠金额，单位分
        /// </summary>
        [XmlElement("discount_amount")]
        public long DiscountAmount { get; set; }

        /// <summary>
        /// 报名类型，NORMAL 常规类型，不限制, RESTRICTED 限制报名条件
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
