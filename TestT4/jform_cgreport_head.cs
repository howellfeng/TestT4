//-----------------------------------------------------------------------
// <copyright file=" jform_cgreport_head.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: jform_cgreport_head.cs
// * history : Created by T4 03/23/2018 16:39:14 
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChongQingNetCheckWebService.Models
{
    /// <summary>
    /// jform_cgreport_head Entity Model
    /// </summary>    
    [Table("jform_cgreport_head")]
    public class jform_cgreport_head
    {
        /// <summary>
        /// 
        /// </summary>
        public string ID { get; set; }
    
        /// <summary>
        /// 报表SQL
        /// </summary>
        public string CGR_SQL { get; set; }
    
        /// <summary>
        /// 报表编码
        /// </summary>
        public string CODE { get; set; }
    
        /// <summary>
        /// 描述
        /// </summary>
        public string CONTENT { get; set; }
    
        /// <summary>
        /// 报表名字
        /// </summary>
        public string NAME { get; set; }
    
        /// <summary>
        /// 修改人
        /// </summary>
        public string update_name { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? update_date { get; set; }
    
        /// <summary>
        /// 修改人id
        /// </summary>
        public string update_by { get; set; }
    
        /// <summary>
        /// 创建人
        /// </summary>
        public string create_name { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? create_date { get; set; }
    
        /// <summary>
        /// 创建人id
        /// </summary>
        public string create_by { get; set; }
    
        /// <summary>
        /// 动态数据源
        /// </summary>
        public string db_source { get; set; }
    
        /// <summary>
        /// 返回值字段
        /// </summary>
        public string return_val_field { get; set; }
    
        /// <summary>
        /// 返回文本字段
        /// </summary>
        public string return_txt_field { get; set; }
    
        /// <summary>
        /// 返回类型，单选或多选
        /// </summary>
        public string pop_retype { get; set; }
    }
}
