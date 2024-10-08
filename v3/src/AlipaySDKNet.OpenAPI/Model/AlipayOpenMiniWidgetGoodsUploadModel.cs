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
    /// AlipayOpenMiniWidgetGoodsUploadModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniWidgetGoodsUploadModel")]
    public partial class AlipayOpenMiniWidgetGoodsUploadModel : IEquatable<AlipayOpenMiniWidgetGoodsUploadModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniWidgetGoodsUploadModel" /> class.
        /// </summary>
        /// <param name="goodsList">商品信息列表.</param>
        /// <param name="miniAppId">用于承接品的商家小程序ID.</param>
        /// <param name="pid">品的售卖商家，即承接该品的小程序背后的商家。和mini_app_id要求对应.</param>
        public AlipayOpenMiniWidgetGoodsUploadModel(List<WidgetGoodsInfo> goodsList = default(List<WidgetGoodsInfo>), string miniAppId = default(string), string pid = default(string))
        {
            this.GoodsList = goodsList;
            this.MiniAppId = miniAppId;
            this.Pid = pid;
        }

        /// <summary>
        /// 商品信息列表
        /// </summary>
        /// <value>商品信息列表</value>
        [DataMember(Name = "goods_list", EmitDefaultValue = false)]
        public List<WidgetGoodsInfo> GoodsList { get; set; }

        /// <summary>
        /// 用于承接品的商家小程序ID
        /// </summary>
        /// <value>用于承接品的商家小程序ID</value>
        [DataMember(Name = "mini_app_id", EmitDefaultValue = false)]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 品的售卖商家，即承接该品的小程序背后的商家。和mini_app_id要求对应
        /// </summary>
        /// <value>品的售卖商家，即承接该品的小程序背后的商家。和mini_app_id要求对应</value>
        [DataMember(Name = "pid", EmitDefaultValue = false)]
        public string Pid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniWidgetGoodsUploadModel {\n");
            sb.Append("  GoodsList: ").Append(GoodsList).Append("\n");
            sb.Append("  MiniAppId: ").Append(MiniAppId).Append("\n");
            sb.Append("  Pid: ").Append(Pid).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniWidgetGoodsUploadModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniWidgetGoodsUploadModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniWidgetGoodsUploadModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniWidgetGoodsUploadModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GoodsList == input.GoodsList ||
                    this.GoodsList != null &&
                    input.GoodsList != null &&
                    this.GoodsList.SequenceEqual(input.GoodsList)
                ) && 
                (
                    this.MiniAppId == input.MiniAppId ||
                    (this.MiniAppId != null &&
                    this.MiniAppId.Equals(input.MiniAppId))
                ) && 
                (
                    this.Pid == input.Pid ||
                    (this.Pid != null &&
                    this.Pid.Equals(input.Pid))
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
                if (this.GoodsList != null)
                {
                    hashCode = (hashCode * 59) + this.GoodsList.GetHashCode();
                }
                if (this.MiniAppId != null)
                {
                    hashCode = (hashCode * 59) + this.MiniAppId.GetHashCode();
                }
                if (this.Pid != null)
                {
                    hashCode = (hashCode * 59) + this.Pid.GetHashCode();
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
