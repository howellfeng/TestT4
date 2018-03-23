//-----------------------------------------------------------------------
// <copyright file=" t_s_function.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: t_s_function.cs
// * history : Created by T4 03/23/2018 16:39:14 
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChongQingNetCheckWebService.Models
{
    /// <summary>
    /// t_s_function Entity Model
    /// </summary>    
    [Table("t_s_function")]
    public class t_s_function
    {
        /// <summary>
        /// ID
        /// </summary>
        public string ID { get; set; }
    
        /// <summary>
        /// 菜单地址打开方式
        /// </summary>
        public int? functioniframe { get; set; }
    
        /// <summary>
        /// 菜单等级
        /// </summary>
        public int? functionlevel { get; set; }
    
        /// <summary>
        /// 菜单名字
        /// </summary>
        public string functionname { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        public string functionorder { get; set; }
    
        /// <summary>
        /// URL
        /// </summary>
        public string functionurl { get; set; }
    
        /// <summary>
        /// 父菜单ID
        /// </summary>
        public string parentfunctionid { get; set; }
    
        /// <summary>
        /// 图标ID
        /// </summary>
        public string iconid { get; set; }
    
        /// <summary>
        /// 桌面图标ID
        /// </summary>
        public string desk_iconid { get; set; }
    
        /// <summary>
        /// 菜单类型
        /// </summary>
        public int? functiontype { get; set; }
    
        /// <summary>
        /// ace图标样式
        /// </summary>
        public string function_icon_style { get; set; }
    
        /// <summary>
        /// 创建人id
        /// </summary>
        public string create_by { get; set; }
    
        /// <summary>
        /// 创建人
        /// </summary>
        public string create_name { get; set; }
    
        /// <summary>
        /// 修改人id
        /// </summary>
        public string update_by { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? update_date { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? create_date { get; set; }
    
        /// <summary>
        /// 修改人
        /// </summary>
        public string update_name { get; set; }
    }
}
