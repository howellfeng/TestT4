//-----------------------------------------------------------------------
// <copyright file=" t_s_black_list.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: t_s_black_list.cs
// * history : Created by T4 03/23/2018 15:18:04 
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Console4Test
{
    /// <summary>
    /// t_s_black_list Entity Model
    /// </summary>    
    [Table("t_s_black_list")]
    public class t_s_black_list
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
        /// ip地址
        /// </summary>
        public string ip { get; set; }
    }
}
