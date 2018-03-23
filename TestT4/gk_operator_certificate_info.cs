//-----------------------------------------------------------------------
// <copyright file=" gk_operator_certificate_info.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: gk_operator_certificate_info.cs
// * history : Created by T4 03/23/2018 16:39:14 
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChongQingNetCheckWebService.Models
{
    /// <summary>
    /// gk_operator_certificate_info Entity Model
    /// </summary>    
    [Table("gk_operator_certificate_info")]
    public class gk_operator_certificate_info
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
        /// 证书编号
        /// </summary>
        public string certification_no { get; set; }
    
        /// <summary>
        /// 发证机构
        /// </summary>
        public string certification_dept { get; set; }
    
        /// <summary>
        /// 发证日期
        /// </summary>
        public DateTime? release_date { get; set; }
    
        /// <summary>
        /// 有效期至
        /// </summary>
        public DateTime? expiry_date { get; set; }
    
        /// <summary>
        /// 证书状态
        /// </summary>
        public string certification_status { get; set; }
    
        /// <summary>
        /// 关联id
        /// </summary>
        public string operator_id { get; set; }
    }
}
