//-----------------------------------------------------------------------
// <copyright file=" gk_operator_roadstead.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: gk_operator_roadstead.cs
// * history : Created by T4 03/23/2018 16:39:14 
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChongQingNetCheckWebService.Models
{
    /// <summary>
    /// gk_operator_roadstead Entity Model
    /// </summary>    
    [Table("gk_operator_roadstead")]
    public class gk_operator_roadstead
    {
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }
    
        /// <summary>
        /// 创建人名称
        /// </summary>
        public string create_name { get; set; }
    
        /// <summary>
        /// 创建人登录名称
        /// </summary>
        public string create_by { get; set; }
    
        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime? create_date { get; set; }
    
        /// <summary>
        /// 更新人名称
        /// </summary>
        public string update_name { get; set; }
    
        /// <summary>
        /// 更新人登录名称
        /// </summary>
        public string update_by { get; set; }
    
        /// <summary>
        /// 更新日期
        /// </summary>
        public DateTime? update_date { get; set; }
    
        /// <summary>
        /// 所属部门
        /// </summary>
        public string sys_org_code { get; set; }
    
        /// <summary>
        /// 所属公司
        /// </summary>
        public string sys_company_code { get; set; }
    
        /// <summary>
        /// 流程状态
        /// </summary>
        public string bpm_status { get; set; }
    
        /// <summary>
        /// 服务港区名称
        /// </summary>
        public string port_id { get; set; }
    
        /// <summary>
        /// 锚地名称
        /// </summary>
        public string roadstead_name { get; set; }
    
        /// <summary>
        /// 锚地位置
        /// </summary>
        public string roadstead_position { get; set; }
    
        /// <summary>
        /// 锚地底质
        /// </summary>
        public string soil_type { get; set; }
    
        /// <summary>
        /// 锚位长度
        /// </summary>
        public string roadstead_length { get; set; }
    
        /// <summary>
        /// 锚位宽度
        /// </summary>
        public string roadstead_width { get; set; }
    
        /// <summary>
        /// 锚位半径
        /// </summary>
        public string roadstead_radius { get; set; }
    
        /// <summary>
        /// 锚地面积
        /// </summary>
        public string roadstead_area { get; set; }
    
        /// <summary>
        /// 锚地水深
        /// </summary>
        public string roadstead_depth { get; set; }
    
        /// <summary>
        /// 锚地最大水深
        /// </summary>
        public string roadstead_max_depth { get; set; }
    
        /// <summary>
        /// 浮筒个数
        /// </summary>
        public string buoy_num { get; set; }
    
        /// <summary>
        /// 锚泊艘数
        /// </summary>
        public string roadstead_num { get; set; }
    
        /// <summary>
        /// 锚地最大系泊能力
        /// </summary>
        public string roadstead_max_ton { get; set; }
    
        /// <summary>
        /// 锚地系泊能力
        /// </summary>
        public string roadstead_ton { get; set; }
    }
}
