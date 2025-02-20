using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RiskApplyConsult Data Structure.
    /// </summary>
    [Serializable]
    public class RiskApplyConsult : AopObject
    {
        /// <summary>
        /// 风险咨询时间
        /// </summary>
        [XmlElement("consult_time")]
        public string ConsultTime { get; set; }

        /// <summary>
        /// 风险描述 1.该客户无风险 2.该客户存在潜在风险 3.该客户存在风险 4.未知风险
        /// </summary>
        [XmlElement("risk_desc")]
        public string RiskDesc { get; set; }

        /// <summary>
        /// 风险等级，有限枚举： 1.AC_NO_RISK（该客户无风险） 2.AC_POTENTIAL_RISK（该客户存在潜在风险） 3.AC_HIGH_RISK（该客户存在风险） 4.AC_UN_KNOWN（未知风险）
        /// </summary>
        [XmlElement("risk_level")]
        public string RiskLevel { get; set; }

        /// <summary>
        /// 风险场景，有限枚举：  User Account Risk：账户安全咨询  Enterprise Access Risk：社保风险咨询  Enterprise Manager Risk：董监高风险咨询 Account Limit Risk：限权风险咨询
        /// </summary>
        [XmlElement("risk_scene")]
        public string RiskScene { get; set; }
    }
}
