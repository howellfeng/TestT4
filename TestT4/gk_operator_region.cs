//-----------------------------------------------------------------------
// <copyright file=" gk_operator_region.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: gk_operator_region.cs
// * history : Created by T4 03/22/2018 16:26:40 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace Console4Test
{
    /// <summary>
    /// gk_operator_region Entity Model
    /// </summary>    
    [Serializable]
    public class gk_operator_region
    {
        /// <summary>
        /// 主键
        /// </summary>
        public string id { get; set; }
    
        /// <summary>
        /// 流程状态
        /// </summary>
        public string bpm_status { get; set; }
    
        /// <summary>
        /// 创建人名称
        /// </summary>
        public string create_name { get; set; }
    
        /// <summary>
        /// 创建人登录名称
        /// </summary>
        public string create_by { get; set; }
    
        /// <summary>
        /// 更新人名称
        /// </summary>
        public string update_name { get; set; }
    
        /// <summary>
        /// 更新人登录名称
        /// </summary>
        public string update_by { get; set; }
    
        /// <summary>
        /// 所属部门
        /// </summary>
        public string sys_org_code { get; set; }
    
        /// <summary>
        /// 所属公司
        /// </summary>
        public string sys_company_code { get; set; }
    
        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime create_date { get; set; }
    
        /// <summary>
        /// 更新日期
        /// </summary>
        public DateTime update_date { get; set; }
    
        /// <summary>
        /// 使用陆域土地面积
        /// </summary>
        public string land_area { get; set; }
    
        /// <summary>
        /// 使用陆域土地相关批文及文号
        /// </summary>
        public string land_approval_no { get; set; }
    
        /// <summary>
        /// 使用水域面积
        /// </summary>
        public string water_area { get; set; }
    
        /// <summary>
        /// 使用水域相关批文及文号
        /// </summary>
        public string water_approval_no { get; set; }
    
        /// <summary>
        /// 使用自然岸线长度
        /// </summary>
        public string nature_shoreline_length { get; set; }
    
        /// <summary>
        /// 使用自然岸线相关批文及文号
        /// </summary>
        public string shoreline_approval_no { get; set; }
    
        /// <summary>
        /// 关联港口经营人ID
        /// </summary>
        public string operator_id { get; set; }
    
        /// <summary>
        /// 涉及批文或证书扫描件
        /// </summary>
        public string scan_img { get; set; }
    }
}