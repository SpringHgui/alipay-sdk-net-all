/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2025-02-06
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
    /// AlipayIserviceCcmServicerecordCreateModel
    /// </summary>
    [DataContract(Name = "AlipayIserviceCcmServicerecordCreateModel")]
    public partial class AlipayIserviceCcmServicerecordCreateModel : IEquatable<AlipayIserviceCcmServicerecordCreateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayIserviceCcmServicerecordCreateModel" /> class.
        /// </summary>
        /// <param name="acid">来电唯一标识.</param>
        /// <param name="aid">客服坐席号(软电话中定义的).</param>
        /// <param name="ani">主叫号码.</param>
        /// <param name="asid">恒生专用来电唯一标识.</param>
        /// <param name="categoryList">类目信息(详细信息请参考具体类型描述).</param>
        /// <param name="chatBeginTime">标准时间格式：yyyy-MM-dd HH:mm:ss.</param>
        /// <param name="chatEndTime">标准时间格式：yyyy-MM-dd HH:mm:ss.</param>
        /// <param name="city">来电地址.</param>
        /// <param name="creatorId">创建者ID.</param>
        /// <param name="disconSymbol">先挂断方 AGENT:客服 CUSTOMER:客户.</param>
        /// <param name="dnis">被叫号码.</param>
        /// <param name="fileSize">文件大小.</param>
        /// <param name="gmtCreate">创建时间(yyyy-MM-dd HH:mm:ss).</param>
        /// <param name="gmtModified">修改时间.</param>
        /// <param name="memo">服务记录备注信息.</param>
        /// <param name="modifierId">修改人ID.</param>
        /// <param name="outboundTaskId">外呼任务ID.</param>
        /// <param name="satisfaction">满意度 0:非常满意 1:满意 2:一般 3:不满意 4:非常不满意.</param>
        /// <param name="satisfactionMemo">满意度补充信息.</param>
        /// <param name="serviceSource">1:客户来电 4:电话回访 5:网点服务 6:在线服务 7:外呼任务 8:手动外呼 9:在线离线留言.</param>
        /// <param name="serviceTime">服务时长(单位:秒).</param>
        /// <param name="skillgroupId">技能组ID.</param>
        /// <param name="skillgroupName">技能组名称(技能组ID对应的技能组名称).</param>
        /// <param name="tntInstId">业务租户.</param>
        /// <param name="userId">来访用户唯一标识ID.</param>
        /// <param name="verifyResult">IVR验证结果 ROLE_N:未定位到用户 CERTNO_Y_PWD_Y:证件号码+交易密码验证通过 CERTNO_Y_PWD_N:证件号码验证通过+交易密码不通过 CERTNO_Y_PWD_UNKNOW:证件号码验证通过 PHONE_Y_PWD_Y:来电手机+交易密码验证通过 PHONE_Y_PWD_N:来电手机+交易密码未通过 PHONE_Y_PWD_UNKNOW:来电手机账户 SEARCH_Y_PWD_Y:搜索定位用户+推屏交易密码通过 SEARCH_Y_PWD_N:搜索定位用户+推屏交易密码未通过 SEARCH_Y_PWD_UNKNOW:搜索定位用户.</param>
        public AlipayIserviceCcmServicerecordCreateModel(string acid = default(string), string aid = default(string), string ani = default(string), string asid = default(string), List<ServiceRecordCatRequest> categoryList = default(List<ServiceRecordCatRequest>), string chatBeginTime = default(string), string chatEndTime = default(string), string city = default(string), string creatorId = default(string), string disconSymbol = default(string), string dnis = default(string), int fileSize = default(int), string gmtCreate = default(string), string gmtModified = default(string), string memo = default(string), string modifierId = default(string), string outboundTaskId = default(string), string satisfaction = default(string), string satisfactionMemo = default(string), string serviceSource = default(string), int serviceTime = default(int), string skillgroupId = default(string), string skillgroupName = default(string), string tntInstId = default(string), string userId = default(string), string verifyResult = default(string))
        {
            this.Acid = acid;
            this.Aid = aid;
            this.Ani = ani;
            this.Asid = asid;
            this.CategoryList = categoryList;
            this.ChatBeginTime = chatBeginTime;
            this.ChatEndTime = chatEndTime;
            this.City = city;
            this.CreatorId = creatorId;
            this.DisconSymbol = disconSymbol;
            this.Dnis = dnis;
            this.FileSize = fileSize;
            this.GmtCreate = gmtCreate;
            this.GmtModified = gmtModified;
            this.Memo = memo;
            this.ModifierId = modifierId;
            this.OutboundTaskId = outboundTaskId;
            this.Satisfaction = satisfaction;
            this.SatisfactionMemo = satisfactionMemo;
            this.ServiceSource = serviceSource;
            this.ServiceTime = serviceTime;
            this.SkillgroupId = skillgroupId;
            this.SkillgroupName = skillgroupName;
            this.TntInstId = tntInstId;
            this.UserId = userId;
            this.VerifyResult = verifyResult;
        }

        /// <summary>
        /// 来电唯一标识
        /// </summary>
        /// <value>来电唯一标识</value>
        [DataMember(Name = "acid", EmitDefaultValue = false)]
        public string Acid { get; set; }

        /// <summary>
        /// 客服坐席号(软电话中定义的)
        /// </summary>
        /// <value>客服坐席号(软电话中定义的)</value>
        [DataMember(Name = "aid", EmitDefaultValue = false)]
        public string Aid { get; set; }

        /// <summary>
        /// 主叫号码
        /// </summary>
        /// <value>主叫号码</value>
        [DataMember(Name = "ani", EmitDefaultValue = false)]
        public string Ani { get; set; }

        /// <summary>
        /// 恒生专用来电唯一标识
        /// </summary>
        /// <value>恒生专用来电唯一标识</value>
        [DataMember(Name = "asid", EmitDefaultValue = false)]
        public string Asid { get; set; }

        /// <summary>
        /// 类目信息(详细信息请参考具体类型描述)
        /// </summary>
        /// <value>类目信息(详细信息请参考具体类型描述)</value>
        [DataMember(Name = "category_list", EmitDefaultValue = false)]
        public List<ServiceRecordCatRequest> CategoryList { get; set; }

        /// <summary>
        /// 标准时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <value>标准时间格式：yyyy-MM-dd HH:mm:ss</value>
        [DataMember(Name = "chat_begin_time", EmitDefaultValue = false)]
        public string ChatBeginTime { get; set; }

        /// <summary>
        /// 标准时间格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <value>标准时间格式：yyyy-MM-dd HH:mm:ss</value>
        [DataMember(Name = "chat_end_time", EmitDefaultValue = false)]
        public string ChatEndTime { get; set; }

        /// <summary>
        /// 来电地址
        /// </summary>
        /// <value>来电地址</value>
        [DataMember(Name = "city", EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// 创建者ID
        /// </summary>
        /// <value>创建者ID</value>
        [DataMember(Name = "creator_id", EmitDefaultValue = false)]
        public string CreatorId { get; set; }

        /// <summary>
        /// 先挂断方 AGENT:客服 CUSTOMER:客户
        /// </summary>
        /// <value>先挂断方 AGENT:客服 CUSTOMER:客户</value>
        [DataMember(Name = "discon_symbol", EmitDefaultValue = false)]
        public string DisconSymbol { get; set; }

        /// <summary>
        /// 被叫号码
        /// </summary>
        /// <value>被叫号码</value>
        [DataMember(Name = "dnis", EmitDefaultValue = false)]
        public string Dnis { get; set; }

        /// <summary>
        /// 文件大小
        /// </summary>
        /// <value>文件大小</value>
        [DataMember(Name = "file_size", EmitDefaultValue = false)]
        public int FileSize { get; set; }

        /// <summary>
        /// 创建时间(yyyy-MM-dd HH:mm:ss)
        /// </summary>
        /// <value>创建时间(yyyy-MM-dd HH:mm:ss)</value>
        [DataMember(Name = "gmt_create", EmitDefaultValue = false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        /// <value>修改时间</value>
        [DataMember(Name = "gmt_modified", EmitDefaultValue = false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// 服务记录备注信息
        /// </summary>
        /// <value>服务记录备注信息</value>
        [DataMember(Name = "memo", EmitDefaultValue = false)]
        public string Memo { get; set; }

        /// <summary>
        /// 修改人ID
        /// </summary>
        /// <value>修改人ID</value>
        [DataMember(Name = "modifier_id", EmitDefaultValue = false)]
        public string ModifierId { get; set; }

        /// <summary>
        /// 外呼任务ID
        /// </summary>
        /// <value>外呼任务ID</value>
        [DataMember(Name = "outbound_task_id", EmitDefaultValue = false)]
        public string OutboundTaskId { get; set; }

        /// <summary>
        /// 满意度 0:非常满意 1:满意 2:一般 3:不满意 4:非常不满意
        /// </summary>
        /// <value>满意度 0:非常满意 1:满意 2:一般 3:不满意 4:非常不满意</value>
        [DataMember(Name = "satisfaction", EmitDefaultValue = false)]
        public string Satisfaction { get; set; }

        /// <summary>
        /// 满意度补充信息
        /// </summary>
        /// <value>满意度补充信息</value>
        [DataMember(Name = "satisfaction_memo", EmitDefaultValue = false)]
        public string SatisfactionMemo { get; set; }

        /// <summary>
        /// 1:客户来电 4:电话回访 5:网点服务 6:在线服务 7:外呼任务 8:手动外呼 9:在线离线留言
        /// </summary>
        /// <value>1:客户来电 4:电话回访 5:网点服务 6:在线服务 7:外呼任务 8:手动外呼 9:在线离线留言</value>
        [DataMember(Name = "service_source", EmitDefaultValue = false)]
        public string ServiceSource { get; set; }

        /// <summary>
        /// 服务时长(单位:秒)
        /// </summary>
        /// <value>服务时长(单位:秒)</value>
        [DataMember(Name = "service_time", EmitDefaultValue = false)]
        public int ServiceTime { get; set; }

        /// <summary>
        /// 技能组ID
        /// </summary>
        /// <value>技能组ID</value>
        [DataMember(Name = "skillgroup_id", EmitDefaultValue = false)]
        public string SkillgroupId { get; set; }

        /// <summary>
        /// 技能组名称(技能组ID对应的技能组名称)
        /// </summary>
        /// <value>技能组名称(技能组ID对应的技能组名称)</value>
        [DataMember(Name = "skillgroup_name", EmitDefaultValue = false)]
        public string SkillgroupName { get; set; }

        /// <summary>
        /// 业务租户
        /// </summary>
        /// <value>业务租户</value>
        [DataMember(Name = "tnt_inst_id", EmitDefaultValue = false)]
        public string TntInstId { get; set; }

        /// <summary>
        /// 来访用户唯一标识ID
        /// </summary>
        /// <value>来访用户唯一标识ID</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// IVR验证结果 ROLE_N:未定位到用户 CERTNO_Y_PWD_Y:证件号码+交易密码验证通过 CERTNO_Y_PWD_N:证件号码验证通过+交易密码不通过 CERTNO_Y_PWD_UNKNOW:证件号码验证通过 PHONE_Y_PWD_Y:来电手机+交易密码验证通过 PHONE_Y_PWD_N:来电手机+交易密码未通过 PHONE_Y_PWD_UNKNOW:来电手机账户 SEARCH_Y_PWD_Y:搜索定位用户+推屏交易密码通过 SEARCH_Y_PWD_N:搜索定位用户+推屏交易密码未通过 SEARCH_Y_PWD_UNKNOW:搜索定位用户
        /// </summary>
        /// <value>IVR验证结果 ROLE_N:未定位到用户 CERTNO_Y_PWD_Y:证件号码+交易密码验证通过 CERTNO_Y_PWD_N:证件号码验证通过+交易密码不通过 CERTNO_Y_PWD_UNKNOW:证件号码验证通过 PHONE_Y_PWD_Y:来电手机+交易密码验证通过 PHONE_Y_PWD_N:来电手机+交易密码未通过 PHONE_Y_PWD_UNKNOW:来电手机账户 SEARCH_Y_PWD_Y:搜索定位用户+推屏交易密码通过 SEARCH_Y_PWD_N:搜索定位用户+推屏交易密码未通过 SEARCH_Y_PWD_UNKNOW:搜索定位用户</value>
        [DataMember(Name = "verify_result", EmitDefaultValue = false)]
        public string VerifyResult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayIserviceCcmServicerecordCreateModel {\n");
            sb.Append("  Acid: ").Append(Acid).Append("\n");
            sb.Append("  Aid: ").Append(Aid).Append("\n");
            sb.Append("  Ani: ").Append(Ani).Append("\n");
            sb.Append("  Asid: ").Append(Asid).Append("\n");
            sb.Append("  CategoryList: ").Append(CategoryList).Append("\n");
            sb.Append("  ChatBeginTime: ").Append(ChatBeginTime).Append("\n");
            sb.Append("  ChatEndTime: ").Append(ChatEndTime).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  CreatorId: ").Append(CreatorId).Append("\n");
            sb.Append("  DisconSymbol: ").Append(DisconSymbol).Append("\n");
            sb.Append("  Dnis: ").Append(Dnis).Append("\n");
            sb.Append("  FileSize: ").Append(FileSize).Append("\n");
            sb.Append("  GmtCreate: ").Append(GmtCreate).Append("\n");
            sb.Append("  GmtModified: ").Append(GmtModified).Append("\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
            sb.Append("  ModifierId: ").Append(ModifierId).Append("\n");
            sb.Append("  OutboundTaskId: ").Append(OutboundTaskId).Append("\n");
            sb.Append("  Satisfaction: ").Append(Satisfaction).Append("\n");
            sb.Append("  SatisfactionMemo: ").Append(SatisfactionMemo).Append("\n");
            sb.Append("  ServiceSource: ").Append(ServiceSource).Append("\n");
            sb.Append("  ServiceTime: ").Append(ServiceTime).Append("\n");
            sb.Append("  SkillgroupId: ").Append(SkillgroupId).Append("\n");
            sb.Append("  SkillgroupName: ").Append(SkillgroupName).Append("\n");
            sb.Append("  TntInstId: ").Append(TntInstId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  VerifyResult: ").Append(VerifyResult).Append("\n");
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
            return this.Equals(input as AlipayIserviceCcmServicerecordCreateModel);
        }

        /// <summary>
        /// Returns true if AlipayIserviceCcmServicerecordCreateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayIserviceCcmServicerecordCreateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayIserviceCcmServicerecordCreateModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Acid == input.Acid ||
                    (this.Acid != null &&
                    this.Acid.Equals(input.Acid))
                ) && 
                (
                    this.Aid == input.Aid ||
                    (this.Aid != null &&
                    this.Aid.Equals(input.Aid))
                ) && 
                (
                    this.Ani == input.Ani ||
                    (this.Ani != null &&
                    this.Ani.Equals(input.Ani))
                ) && 
                (
                    this.Asid == input.Asid ||
                    (this.Asid != null &&
                    this.Asid.Equals(input.Asid))
                ) && 
                (
                    this.CategoryList == input.CategoryList ||
                    this.CategoryList != null &&
                    input.CategoryList != null &&
                    this.CategoryList.SequenceEqual(input.CategoryList)
                ) && 
                (
                    this.ChatBeginTime == input.ChatBeginTime ||
                    (this.ChatBeginTime != null &&
                    this.ChatBeginTime.Equals(input.ChatBeginTime))
                ) && 
                (
                    this.ChatEndTime == input.ChatEndTime ||
                    (this.ChatEndTime != null &&
                    this.ChatEndTime.Equals(input.ChatEndTime))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.CreatorId == input.CreatorId ||
                    (this.CreatorId != null &&
                    this.CreatorId.Equals(input.CreatorId))
                ) && 
                (
                    this.DisconSymbol == input.DisconSymbol ||
                    (this.DisconSymbol != null &&
                    this.DisconSymbol.Equals(input.DisconSymbol))
                ) && 
                (
                    this.Dnis == input.Dnis ||
                    (this.Dnis != null &&
                    this.Dnis.Equals(input.Dnis))
                ) && 
                (
                    this.FileSize == input.FileSize ||
                    this.FileSize.Equals(input.FileSize)
                ) && 
                (
                    this.GmtCreate == input.GmtCreate ||
                    (this.GmtCreate != null &&
                    this.GmtCreate.Equals(input.GmtCreate))
                ) && 
                (
                    this.GmtModified == input.GmtModified ||
                    (this.GmtModified != null &&
                    this.GmtModified.Equals(input.GmtModified))
                ) && 
                (
                    this.Memo == input.Memo ||
                    (this.Memo != null &&
                    this.Memo.Equals(input.Memo))
                ) && 
                (
                    this.ModifierId == input.ModifierId ||
                    (this.ModifierId != null &&
                    this.ModifierId.Equals(input.ModifierId))
                ) && 
                (
                    this.OutboundTaskId == input.OutboundTaskId ||
                    (this.OutboundTaskId != null &&
                    this.OutboundTaskId.Equals(input.OutboundTaskId))
                ) && 
                (
                    this.Satisfaction == input.Satisfaction ||
                    (this.Satisfaction != null &&
                    this.Satisfaction.Equals(input.Satisfaction))
                ) && 
                (
                    this.SatisfactionMemo == input.SatisfactionMemo ||
                    (this.SatisfactionMemo != null &&
                    this.SatisfactionMemo.Equals(input.SatisfactionMemo))
                ) && 
                (
                    this.ServiceSource == input.ServiceSource ||
                    (this.ServiceSource != null &&
                    this.ServiceSource.Equals(input.ServiceSource))
                ) && 
                (
                    this.ServiceTime == input.ServiceTime ||
                    this.ServiceTime.Equals(input.ServiceTime)
                ) && 
                (
                    this.SkillgroupId == input.SkillgroupId ||
                    (this.SkillgroupId != null &&
                    this.SkillgroupId.Equals(input.SkillgroupId))
                ) && 
                (
                    this.SkillgroupName == input.SkillgroupName ||
                    (this.SkillgroupName != null &&
                    this.SkillgroupName.Equals(input.SkillgroupName))
                ) && 
                (
                    this.TntInstId == input.TntInstId ||
                    (this.TntInstId != null &&
                    this.TntInstId.Equals(input.TntInstId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.VerifyResult == input.VerifyResult ||
                    (this.VerifyResult != null &&
                    this.VerifyResult.Equals(input.VerifyResult))
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
                if (this.Acid != null)
                {
                    hashCode = (hashCode * 59) + this.Acid.GetHashCode();
                }
                if (this.Aid != null)
                {
                    hashCode = (hashCode * 59) + this.Aid.GetHashCode();
                }
                if (this.Ani != null)
                {
                    hashCode = (hashCode * 59) + this.Ani.GetHashCode();
                }
                if (this.Asid != null)
                {
                    hashCode = (hashCode * 59) + this.Asid.GetHashCode();
                }
                if (this.CategoryList != null)
                {
                    hashCode = (hashCode * 59) + this.CategoryList.GetHashCode();
                }
                if (this.ChatBeginTime != null)
                {
                    hashCode = (hashCode * 59) + this.ChatBeginTime.GetHashCode();
                }
                if (this.ChatEndTime != null)
                {
                    hashCode = (hashCode * 59) + this.ChatEndTime.GetHashCode();
                }
                if (this.City != null)
                {
                    hashCode = (hashCode * 59) + this.City.GetHashCode();
                }
                if (this.CreatorId != null)
                {
                    hashCode = (hashCode * 59) + this.CreatorId.GetHashCode();
                }
                if (this.DisconSymbol != null)
                {
                    hashCode = (hashCode * 59) + this.DisconSymbol.GetHashCode();
                }
                if (this.Dnis != null)
                {
                    hashCode = (hashCode * 59) + this.Dnis.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FileSize.GetHashCode();
                if (this.GmtCreate != null)
                {
                    hashCode = (hashCode * 59) + this.GmtCreate.GetHashCode();
                }
                if (this.GmtModified != null)
                {
                    hashCode = (hashCode * 59) + this.GmtModified.GetHashCode();
                }
                if (this.Memo != null)
                {
                    hashCode = (hashCode * 59) + this.Memo.GetHashCode();
                }
                if (this.ModifierId != null)
                {
                    hashCode = (hashCode * 59) + this.ModifierId.GetHashCode();
                }
                if (this.OutboundTaskId != null)
                {
                    hashCode = (hashCode * 59) + this.OutboundTaskId.GetHashCode();
                }
                if (this.Satisfaction != null)
                {
                    hashCode = (hashCode * 59) + this.Satisfaction.GetHashCode();
                }
                if (this.SatisfactionMemo != null)
                {
                    hashCode = (hashCode * 59) + this.SatisfactionMemo.GetHashCode();
                }
                if (this.ServiceSource != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceSource.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ServiceTime.GetHashCode();
                if (this.SkillgroupId != null)
                {
                    hashCode = (hashCode * 59) + this.SkillgroupId.GetHashCode();
                }
                if (this.SkillgroupName != null)
                {
                    hashCode = (hashCode * 59) + this.SkillgroupName.GetHashCode();
                }
                if (this.TntInstId != null)
                {
                    hashCode = (hashCode * 59) + this.TntInstId.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
                }
                if (this.VerifyResult != null)
                {
                    hashCode = (hashCode * 59) + this.VerifyResult.GetHashCode();
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
