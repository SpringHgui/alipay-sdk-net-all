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
    /// AlipayOpenSpBlueseaactivityQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenSpBlueseaactivityQueryResponseModel")]
    public partial class AlipayOpenSpBlueseaactivityQueryResponseModel : IEquatable<AlipayOpenSpBlueseaactivityQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenSpBlueseaactivityQueryResponseModel" /> class.
        /// </summary>
        /// <param name="address">详细地址.</param>
        /// <param name="bizScene">蓝海活动的场景，包括直连餐饮（BLUE_SEA_FOOD_APPLY）、直连快消（BLUE_SEA_FMCG_APPLY）、间连餐饮（BLUE_SEA_FOOD_INDIRECT_APPLY）、间连快消（BLUE_SEA_FMCG_INDIRECT_APPLY）场景.</param>
        /// <param name="businessLic">营业执照，要求证件文本信息清晰可见。 资质信息请参见&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/01hd83\&quot;&gt;报名资质要求&lt;/a&gt;.</param>
        /// <param name="cityCode">城市编码。请按照https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx 表格中内容填写。 （参考资料： http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/）.</param>
        /// <param name="districtCode">区县编码。请按照https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx 表格中内容填写。 （参考资料： http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/）.</param>
        /// <param name="foodBusinessLic">食品经营许可证，要求证件文本信息清晰可见。资质信息请参见&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/01hd83\&quot;&gt;报名资质要求&lt;/a&gt;.</param>
        /// <param name="foodCirculateLic">食品流通许可证，要求证件文本信息清晰可见。资质信息请参见&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/01hd83\&quot;&gt;报名资质要求&lt;/a&gt;.</param>
        /// <param name="foodHealthLic">食品卫生许可证，要求证件文本信息清晰可见。资质信息请参见&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/01hd83\&quot;&gt;报名资质要求&lt;/a&gt;.</param>
        /// <param name="foodProductionLic">食品生产许可证，要求证件文本信息清晰可见。资质信息请参见&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/01hd83\&quot;&gt;报名资质要求&lt;/a&gt;.</param>
        /// <param name="foodServiceLic">餐饮服务许可证，要求证件文本信息清晰可见。资质信息请参见&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/01hd83\&quot;&gt;报名资质要求&lt;/a&gt;.</param>
        /// <param name="indoorPic">门头照，要求内景照片清晰可见。资质信息请参见&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/01hd83\&quot;&gt;报名资质要求&lt;/a&gt;.</param>
        /// <param name="memo">审核驳回原因，在订单状态为失败时有效.</param>
        /// <param name="merchantLogon">参与蓝海活动的商户支付宝账号，只有当参与直连蓝海活动场景（BLUE_SEA_FOOD_APPLY/BLUE_SEA_FMCG_APPLY）时才返回.</param>
        /// <param name="provinceCode">省份编码。请按照https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx 表格中内容填写。 （参考资料： http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/）.</param>
        /// <param name="shopEntrancePic">门头照，要求店铺外观照片清晰可见。资质信息请参见&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/01hd83\&quot;&gt;报名资质要求&lt;/a&gt;.</param>
        /// <param name="status">申请单状态，状态机参考（AUDITING:审核中，FAIL:报名失败，PASS:报名成功）.</param>
        /// <param name="subMerchantId">参与蓝海活动的间连商户账号，只有当参与间连蓝海活动场景（BLUE_SEA_FOOD_INDIRECT_APPLY/BLUE_SEA_FMCG_INDIRECT_APPLY）时才返回.</param>
        /// <param name="tobaccoLic">烟草专卖零售许可证，要求证件文本信息清晰可见。资质信息请参见&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/01hd83\&quot;&gt;报名资质要求&lt;/a&gt;.</param>
        public AlipayOpenSpBlueseaactivityQueryResponseModel(string address = default(string), string bizScene = default(string), string businessLic = default(string), string cityCode = default(string), string districtCode = default(string), string foodBusinessLic = default(string), string foodCirculateLic = default(string), string foodHealthLic = default(string), string foodProductionLic = default(string), string foodServiceLic = default(string), string indoorPic = default(string), string memo = default(string), string merchantLogon = default(string), string provinceCode = default(string), string shopEntrancePic = default(string), string status = default(string), string subMerchantId = default(string), string tobaccoLic = default(string))
        {
            this.Address = address;
            this.BizScene = bizScene;
            this.BusinessLic = businessLic;
            this.CityCode = cityCode;
            this.DistrictCode = districtCode;
            this.FoodBusinessLic = foodBusinessLic;
            this.FoodCirculateLic = foodCirculateLic;
            this.FoodHealthLic = foodHealthLic;
            this.FoodProductionLic = foodProductionLic;
            this.FoodServiceLic = foodServiceLic;
            this.IndoorPic = indoorPic;
            this.Memo = memo;
            this.MerchantLogon = merchantLogon;
            this.ProvinceCode = provinceCode;
            this.ShopEntrancePic = shopEntrancePic;
            this.Status = status;
            this.SubMerchantId = subMerchantId;
            this.TobaccoLic = tobaccoLic;
        }

        /// <summary>
        /// 详细地址
        /// </summary>
        /// <value>详细地址</value>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// 蓝海活动的场景，包括直连餐饮（BLUE_SEA_FOOD_APPLY）、直连快消（BLUE_SEA_FMCG_APPLY）、间连餐饮（BLUE_SEA_FOOD_INDIRECT_APPLY）、间连快消（BLUE_SEA_FMCG_INDIRECT_APPLY）场景
        /// </summary>
        /// <value>蓝海活动的场景，包括直连餐饮（BLUE_SEA_FOOD_APPLY）、直连快消（BLUE_SEA_FMCG_APPLY）、间连餐饮（BLUE_SEA_FOOD_INDIRECT_APPLY）、间连快消（BLUE_SEA_FMCG_INDIRECT_APPLY）场景</value>
        [DataMember(Name = "biz_scene", EmitDefaultValue = false)]
        public string BizScene { get; set; }

        /// <summary>
        /// 营业执照，要求证件文本信息清晰可见。 资质信息请参见&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/01hd83\&quot;&gt;报名资质要求&lt;/a&gt;
        /// </summary>
        /// <value>营业执照，要求证件文本信息清晰可见。 资质信息请参见&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/01hd83\&quot;&gt;报名资质要求&lt;/a&gt;</value>
        [DataMember(Name = "business_lic", EmitDefaultValue = false)]
        public string BusinessLic { get; set; }

        /// <summary>
        /// 城市编码。请按照https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx 表格中内容填写。 （参考资料： http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/）
        /// </summary>
        /// <value>城市编码。请按照https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx 表格中内容填写。 （参考资料： http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/）</value>
        [DataMember(Name = "city_code", EmitDefaultValue = false)]
        public string CityCode { get; set; }

        /// <summary>
        /// 区县编码。请按照https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx 表格中内容填写。 （参考资料： http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/）
        /// </summary>
        /// <value>区县编码。请按照https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx 表格中内容填写。 （参考资料： http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/）</value>
        [DataMember(Name = "district_code", EmitDefaultValue = false)]
        public string DistrictCode { get; set; }

        /// <summary>
        /// 食品经营许可证，要求证件文本信息清晰可见。资质信息请参见&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/01hd83\&quot;&gt;报名资质要求&lt;/a&gt;
        /// </summary>
        /// <value>食品经营许可证，要求证件文本信息清晰可见。资质信息请参见&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/01hd83\&quot;&gt;报名资质要求&lt;/a&gt;</value>
        [DataMember(Name = "food_business_lic", EmitDefaultValue = false)]
        public string FoodBusinessLic { get; set; }

        /// <summary>
        /// 食品流通许可证，要求证件文本信息清晰可见。资质信息请参见&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/01hd83\&quot;&gt;报名资质要求&lt;/a&gt;
        /// </summary>
        /// <value>食品流通许可证，要求证件文本信息清晰可见。资质信息请参见&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/01hd83\&quot;&gt;报名资质要求&lt;/a&gt;</value>
        [DataMember(Name = "food_circulate_lic", EmitDefaultValue = false)]
        public string FoodCirculateLic { get; set; }

        /// <summary>
        /// 食品卫生许可证，要求证件文本信息清晰可见。资质信息请参见&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/01hd83\&quot;&gt;报名资质要求&lt;/a&gt;
        /// </summary>
        /// <value>食品卫生许可证，要求证件文本信息清晰可见。资质信息请参见&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/01hd83\&quot;&gt;报名资质要求&lt;/a&gt;</value>
        [DataMember(Name = "food_health_lic", EmitDefaultValue = false)]
        public string FoodHealthLic { get; set; }

        /// <summary>
        /// 食品生产许可证，要求证件文本信息清晰可见。资质信息请参见&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/01hd83\&quot;&gt;报名资质要求&lt;/a&gt;
        /// </summary>
        /// <value>食品生产许可证，要求证件文本信息清晰可见。资质信息请参见&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/01hd83\&quot;&gt;报名资质要求&lt;/a&gt;</value>
        [DataMember(Name = "food_production_lic", EmitDefaultValue = false)]
        public string FoodProductionLic { get; set; }

        /// <summary>
        /// 餐饮服务许可证，要求证件文本信息清晰可见。资质信息请参见&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/01hd83\&quot;&gt;报名资质要求&lt;/a&gt;
        /// </summary>
        /// <value>餐饮服务许可证，要求证件文本信息清晰可见。资质信息请参见&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/01hd83\&quot;&gt;报名资质要求&lt;/a&gt;</value>
        [DataMember(Name = "food_service_lic", EmitDefaultValue = false)]
        public string FoodServiceLic { get; set; }

        /// <summary>
        /// 门头照，要求内景照片清晰可见。资质信息请参见&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/01hd83\&quot;&gt;报名资质要求&lt;/a&gt;
        /// </summary>
        /// <value>门头照，要求内景照片清晰可见。资质信息请参见&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/01hd83\&quot;&gt;报名资质要求&lt;/a&gt;</value>
        [DataMember(Name = "indoor_pic", EmitDefaultValue = false)]
        public string IndoorPic { get; set; }

        /// <summary>
        /// 审核驳回原因，在订单状态为失败时有效
        /// </summary>
        /// <value>审核驳回原因，在订单状态为失败时有效</value>
        [DataMember(Name = "memo", EmitDefaultValue = false)]
        public string Memo { get; set; }

        /// <summary>
        /// 参与蓝海活动的商户支付宝账号，只有当参与直连蓝海活动场景（BLUE_SEA_FOOD_APPLY/BLUE_SEA_FMCG_APPLY）时才返回
        /// </summary>
        /// <value>参与蓝海活动的商户支付宝账号，只有当参与直连蓝海活动场景（BLUE_SEA_FOOD_APPLY/BLUE_SEA_FMCG_APPLY）时才返回</value>
        [DataMember(Name = "merchant_logon", EmitDefaultValue = false)]
        public string MerchantLogon { get; set; }

        /// <summary>
        /// 省份编码。请按照https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx 表格中内容填写。 （参考资料： http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/）
        /// </summary>
        /// <value>省份编码。请按照https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx 表格中内容填写。 （参考资料： http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/）</value>
        [DataMember(Name = "province_code", EmitDefaultValue = false)]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// 门头照，要求店铺外观照片清晰可见。资质信息请参见&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/01hd83\&quot;&gt;报名资质要求&lt;/a&gt;
        /// </summary>
        /// <value>门头照，要求店铺外观照片清晰可见。资质信息请参见&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/01hd83\&quot;&gt;报名资质要求&lt;/a&gt;</value>
        [DataMember(Name = "shop_entrance_pic", EmitDefaultValue = false)]
        public string ShopEntrancePic { get; set; }

        /// <summary>
        /// 申请单状态，状态机参考（AUDITING:审核中，FAIL:报名失败，PASS:报名成功）
        /// </summary>
        /// <value>申请单状态，状态机参考（AUDITING:审核中，FAIL:报名失败，PASS:报名成功）</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// 参与蓝海活动的间连商户账号，只有当参与间连蓝海活动场景（BLUE_SEA_FOOD_INDIRECT_APPLY/BLUE_SEA_FMCG_INDIRECT_APPLY）时才返回
        /// </summary>
        /// <value>参与蓝海活动的间连商户账号，只有当参与间连蓝海活动场景（BLUE_SEA_FOOD_INDIRECT_APPLY/BLUE_SEA_FMCG_INDIRECT_APPLY）时才返回</value>
        [DataMember(Name = "sub_merchant_id", EmitDefaultValue = false)]
        public string SubMerchantId { get; set; }

        /// <summary>
        /// 烟草专卖零售许可证，要求证件文本信息清晰可见。资质信息请参见&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/01hd83\&quot;&gt;报名资质要求&lt;/a&gt;
        /// </summary>
        /// <value>烟草专卖零售许可证，要求证件文本信息清晰可见。资质信息请参见&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/01hd83\&quot;&gt;报名资质要求&lt;/a&gt;</value>
        [DataMember(Name = "tobacco_lic", EmitDefaultValue = false)]
        public string TobaccoLic { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenSpBlueseaactivityQueryResponseModel {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  BizScene: ").Append(BizScene).Append("\n");
            sb.Append("  BusinessLic: ").Append(BusinessLic).Append("\n");
            sb.Append("  CityCode: ").Append(CityCode).Append("\n");
            sb.Append("  DistrictCode: ").Append(DistrictCode).Append("\n");
            sb.Append("  FoodBusinessLic: ").Append(FoodBusinessLic).Append("\n");
            sb.Append("  FoodCirculateLic: ").Append(FoodCirculateLic).Append("\n");
            sb.Append("  FoodHealthLic: ").Append(FoodHealthLic).Append("\n");
            sb.Append("  FoodProductionLic: ").Append(FoodProductionLic).Append("\n");
            sb.Append("  FoodServiceLic: ").Append(FoodServiceLic).Append("\n");
            sb.Append("  IndoorPic: ").Append(IndoorPic).Append("\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
            sb.Append("  MerchantLogon: ").Append(MerchantLogon).Append("\n");
            sb.Append("  ProvinceCode: ").Append(ProvinceCode).Append("\n");
            sb.Append("  ShopEntrancePic: ").Append(ShopEntrancePic).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SubMerchantId: ").Append(SubMerchantId).Append("\n");
            sb.Append("  TobaccoLic: ").Append(TobaccoLic).Append("\n");
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
            return this.Equals(input as AlipayOpenSpBlueseaactivityQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenSpBlueseaactivityQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenSpBlueseaactivityQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenSpBlueseaactivityQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.BizScene == input.BizScene ||
                    (this.BizScene != null &&
                    this.BizScene.Equals(input.BizScene))
                ) && 
                (
                    this.BusinessLic == input.BusinessLic ||
                    (this.BusinessLic != null &&
                    this.BusinessLic.Equals(input.BusinessLic))
                ) && 
                (
                    this.CityCode == input.CityCode ||
                    (this.CityCode != null &&
                    this.CityCode.Equals(input.CityCode))
                ) && 
                (
                    this.DistrictCode == input.DistrictCode ||
                    (this.DistrictCode != null &&
                    this.DistrictCode.Equals(input.DistrictCode))
                ) && 
                (
                    this.FoodBusinessLic == input.FoodBusinessLic ||
                    (this.FoodBusinessLic != null &&
                    this.FoodBusinessLic.Equals(input.FoodBusinessLic))
                ) && 
                (
                    this.FoodCirculateLic == input.FoodCirculateLic ||
                    (this.FoodCirculateLic != null &&
                    this.FoodCirculateLic.Equals(input.FoodCirculateLic))
                ) && 
                (
                    this.FoodHealthLic == input.FoodHealthLic ||
                    (this.FoodHealthLic != null &&
                    this.FoodHealthLic.Equals(input.FoodHealthLic))
                ) && 
                (
                    this.FoodProductionLic == input.FoodProductionLic ||
                    (this.FoodProductionLic != null &&
                    this.FoodProductionLic.Equals(input.FoodProductionLic))
                ) && 
                (
                    this.FoodServiceLic == input.FoodServiceLic ||
                    (this.FoodServiceLic != null &&
                    this.FoodServiceLic.Equals(input.FoodServiceLic))
                ) && 
                (
                    this.IndoorPic == input.IndoorPic ||
                    (this.IndoorPic != null &&
                    this.IndoorPic.Equals(input.IndoorPic))
                ) && 
                (
                    this.Memo == input.Memo ||
                    (this.Memo != null &&
                    this.Memo.Equals(input.Memo))
                ) && 
                (
                    this.MerchantLogon == input.MerchantLogon ||
                    (this.MerchantLogon != null &&
                    this.MerchantLogon.Equals(input.MerchantLogon))
                ) && 
                (
                    this.ProvinceCode == input.ProvinceCode ||
                    (this.ProvinceCode != null &&
                    this.ProvinceCode.Equals(input.ProvinceCode))
                ) && 
                (
                    this.ShopEntrancePic == input.ShopEntrancePic ||
                    (this.ShopEntrancePic != null &&
                    this.ShopEntrancePic.Equals(input.ShopEntrancePic))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.SubMerchantId == input.SubMerchantId ||
                    (this.SubMerchantId != null &&
                    this.SubMerchantId.Equals(input.SubMerchantId))
                ) && 
                (
                    this.TobaccoLic == input.TobaccoLic ||
                    (this.TobaccoLic != null &&
                    this.TobaccoLic.Equals(input.TobaccoLic))
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
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.BizScene != null)
                {
                    hashCode = (hashCode * 59) + this.BizScene.GetHashCode();
                }
                if (this.BusinessLic != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessLic.GetHashCode();
                }
                if (this.CityCode != null)
                {
                    hashCode = (hashCode * 59) + this.CityCode.GetHashCode();
                }
                if (this.DistrictCode != null)
                {
                    hashCode = (hashCode * 59) + this.DistrictCode.GetHashCode();
                }
                if (this.FoodBusinessLic != null)
                {
                    hashCode = (hashCode * 59) + this.FoodBusinessLic.GetHashCode();
                }
                if (this.FoodCirculateLic != null)
                {
                    hashCode = (hashCode * 59) + this.FoodCirculateLic.GetHashCode();
                }
                if (this.FoodHealthLic != null)
                {
                    hashCode = (hashCode * 59) + this.FoodHealthLic.GetHashCode();
                }
                if (this.FoodProductionLic != null)
                {
                    hashCode = (hashCode * 59) + this.FoodProductionLic.GetHashCode();
                }
                if (this.FoodServiceLic != null)
                {
                    hashCode = (hashCode * 59) + this.FoodServiceLic.GetHashCode();
                }
                if (this.IndoorPic != null)
                {
                    hashCode = (hashCode * 59) + this.IndoorPic.GetHashCode();
                }
                if (this.Memo != null)
                {
                    hashCode = (hashCode * 59) + this.Memo.GetHashCode();
                }
                if (this.MerchantLogon != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantLogon.GetHashCode();
                }
                if (this.ProvinceCode != null)
                {
                    hashCode = (hashCode * 59) + this.ProvinceCode.GetHashCode();
                }
                if (this.ShopEntrancePic != null)
                {
                    hashCode = (hashCode * 59) + this.ShopEntrancePic.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.SubMerchantId != null)
                {
                    hashCode = (hashCode * 59) + this.SubMerchantId.GetHashCode();
                }
                if (this.TobaccoLic != null)
                {
                    hashCode = (hashCode * 59) + this.TobaccoLic.GetHashCode();
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
