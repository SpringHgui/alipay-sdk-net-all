using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CardTemplateSaleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CardTemplateSaleInfo : AopObject
    {
        /// <summary>
        /// 售卖结束时间
        /// </summary>
        [XmlElement("salable_end_time")]
        public string SalableEndTime { get; set; }

        /// <summary>
        /// 售卖开始时间
        /// </summary>
        [XmlElement("salable_start_time")]
        public string SalableStartTime { get; set; }
    }
}
