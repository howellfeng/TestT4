//-----------------------------------------------------------------------
// <copyright file=" gk_operator_store.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: gk_operator_store.cs
// * history : Created by T4 03/22/2018 16:26:40 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace Console4Test
{
    /// <summary>
    /// gk_operator_store Entity Model
    /// </summary>    
    [Serializable]
    public class gk_operator_store
    {
        /// <summary>
        /// 主键
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
        /// 所在港区名称
        /// </summary>
        public string harbour_name { get; set; }
    
        /// <summary>
        /// 仓库名称
        /// </summary>
        public string store_name { get; set; }
    
        /// <summary>
        /// 生产类型
        /// </summary>
        public string production_type { get; set; }
    
        /// <summary>
        /// 主要用途
        /// </summary>
        public string main_use { get; set; }
    
        /// <summary>
        /// 仓库总面积
        /// </summary>
        public string store_total_area { get; set; }
    
        /// <summary>
        /// 生产用仓库面积
        /// </summary>
        public string production_area { get; set; }
    
        /// <summary>
        /// 危险品仓库面积
        /// </summary>
        public string danger_area { get; set; }
    
        /// <summary>
        /// 生产用仓库容积
        /// </summary>
        public string production_volume { get; set; }
    
        /// <summary>
        /// 油库容积
        /// </summary>
        public string oil_volume { get; set; }
    
        /// <summary>
        /// 成品油容积
        /// </summary>
        public string finished_volume { get; set; }
    
        /// <summary>
        /// 圆筒仓容积
        /// </summary>
        public string tower_volume { get; set; }
    
        /// <summary>
        /// 粮食筒仓容积
        /// </summary>
        public string cereals_volume { get; set; }
    
        /// <summary>
        /// 水泥筒仓容积
        /// </summary>
        public string cement_volume { get; set; }
    
        /// <summary>
        /// 液体化工储罐容积
        /// </summary>
        public string liquid_volume { get; set; }
    
        /// <summary>
        /// 其他生产用仓库容积
        /// </summary>
        public string other_liquid { get; set; }
    
        /// <summary>
        /// 关联id
        /// </summary>
        public string operator_id { get; set; }
    }
}
