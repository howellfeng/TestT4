//-----------------------------------------------------------------------
// <copyright file=" cgform_template.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: cgform_template.cs
// * history : Created by T4 03/22/2018 16:26:40 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace Console4Test
{
    /// <summary>
    /// cgform_template Entity Model
    /// </summary>    
    [Serializable]
    public class cgform_template
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
        /// 模板名称
        /// </summary>
        public string template_name { get; set; }
    
        /// <summary>
        /// 模板编码
        /// </summary>
        public string template_code { get; set; }
    
        /// <summary>
        /// 模板类型
        /// </summary>
        public string template_type { get; set; }
    
        /// <summary>
        /// 是否共享
        /// </summary>
        public string template_share { get; set; }
    
        /// <summary>
        /// 预览图
        /// </summary>
        public string template_pic { get; set; }
    
        /// <summary>
        /// 模板描述
        /// </summary>
        public string template_comment { get; set; }
    
        /// <summary>
        /// 列表模板名称

        /// </summary>
        public string template_list_name { get; set; }
    
        /// <summary>
        /// 录入模板名称
        /// </summary>
        public string template_add_name { get; set; }
    
        /// <summary>
        /// 编辑模板名
称
        /// </summary>
        public string template_update_name { get; set; }
    
        /// <summary>
        /// 查看页面模
板名称
        /// </summary>
        public string template_detail_name { get; set; }
    
        /// <summary>
        /// 有效状态
        /// </summary>
        public int status { get; set; }
    }
}
