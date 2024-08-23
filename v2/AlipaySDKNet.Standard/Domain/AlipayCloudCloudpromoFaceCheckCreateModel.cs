using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudpromoFaceCheckCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudpromoFaceCheckCreateModel : AopObject
    {
        /// <summary>
        /// 业务号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 商户自定义的用户Id。
        /// </summary>
        [XmlElement("custom_id")]
        public string CustomId { get; set; }

        /// <summary>
        /// 环境参数
        /// </summary>
        [XmlElement("env_data")]
        public string EnvData { get; set; }

        /// <summary>
        /// 智能体实例id
        /// </summary>
        [XmlElement("instance_id")]
        public string InstanceId { get; set; }

        /// <summary>
        /// 场景类型
        /// </summary>
        [XmlElement("scene_type")]
        public string SceneType { get; set; }
    }
}
