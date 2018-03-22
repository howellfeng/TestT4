//-----------------------------------------------------------------------
// <copyright file=" gk_operator_harbour.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: gk_operator_harbour.cs
// * history : Created by T4 03/22/2018 16:26:40 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace Console4Test
{
    /// <summary>
    /// gk_operator_harbour Entity Model
    /// </summary>    
    [Serializable]
    public class gk_operator_harbour
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
        public DateTime create_date { get; set; }
    
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
        public DateTime update_date { get; set; }
    
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
        /// 所属港口
        /// </summary>
        public string port_id { get; set; }
    
        /// <summary>
        /// 港区名称
        /// </summary>
        public string harbour_name { get; set; }
    
        /// <summary>
        /// 港区所在水域类型
        /// </summary>
        public string water_type { get; set; }
    
        /// <summary>
        /// 港区面积
        /// </summary>
        public string harbor_area { get; set; }
    
        /// <summary>
        /// 陆域面积
        /// </summary>
        public string land_area { get; set; }
    
        /// <summary>
        /// 水域范围
        /// </summary>
        public string water_range { get; set; }
    
        /// <summary>
        /// 水域面积
        /// </summary>
        public string water_area { get; set; }
    
        /// <summary>
        /// 港区规划面积
        /// </summary>
        public string harbor_planned_area { get; set; }
    
        /// <summary>
        /// 规划陆域面积
        /// </summary>
        public string land_planned_area { get; set; }
    
        /// <summary>
        /// 非工业生产用地规划面积
        /// </summary>
        public string non_industrial_planned_area { get; set; }
    
        /// <summary>
        /// 规划水域面积
        /// </summary>
        public string water_planned_area { get; set; }
    
        /// <summary>
        /// 港区自然岸线长度
        /// </summary>
        public string nature_shoreline_length { get; set; }
    
        /// <summary>
        /// 公用码头岸线长度
        /// </summary>
        public string wharf_shoreline_length { get; set; }
    
        /// <summary>
        /// 港区港口岸线长度
        /// </summary>
        public string port_shoreline_length { get; set; }
    
        /// <summary>
        /// 港口设施已使用岸线长度
        /// </summary>
        public string used_port_shoreline_length { get; set; }
    
        /// <summary>
        /// 港区地面坡度最大值
        /// </summary>
        public string max_ground_slope { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        public string remark { get; set; }
    }
}
