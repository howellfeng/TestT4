//-----------------------------------------------------------------------
// <copyright file=" t_s_category.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: t_s_category.cs
// * history : Created by T4 03/23/2018 15:18:04 
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Console4Test
{
    /// <summary>
    /// t_s_category Entity Model
    /// </summary>    
    [Table("t_s_category")]
    public class t_s_category
    {
        /// <summary>
        /// ID
        /// </summary>
        public string id { get; set; }
    
        /// <summary>
        /// 图标ID
        /// </summary>
        public string icon_id { get; set; }
    
        /// <summary>
        /// 类型编码
        /// </summary>
        public string code { get; set; }
    
        /// <summary>
        /// 类型名称
        /// </summary>
        public string name { get; set; }
    
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
        /// 上级ID
        /// </summary>
        public string parent_id { get; set; }
    
        /// <summary>
        /// 机构
        /// </summary>
        public string sys_org_code { get; set; }
    
        /// <summary>
        /// 公司
        /// </summary>
        public string sys_company_code { get; set; }
    
        /// <summary>
        /// 父邮编
        /// </summary>
        public string PARENT_CODE { get; set; }
    }
}
