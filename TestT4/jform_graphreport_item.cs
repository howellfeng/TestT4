//-----------------------------------------------------------------------
// <copyright file=" jform_graphreport_item.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: jform_graphreport_item.cs
// * history : Created by T4 03/23/2018 16:39:14 
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChongQingNetCheckWebService.Models
{
    /// <summary>
    /// jform_graphreport_item Entity Model
    /// </summary>    
    [Table("jform_graphreport_item")]
    public class jform_graphreport_item
    {
        /// <summary>
        /// id
        /// </summary>
        public string id { get; set; }
    
        /// <summary>
        /// 是否查询
        /// </summary>
        public string search_flag { get; set; }
    
        /// <summary>
        /// 查询模式
        /// </summary>
        public string search_mode { get; set; }
    
        /// <summary>
        /// cgreportHeadId
        /// </summary>
        public string cgreport_head_id { get; set; }
    
        /// <summary>
        /// 字典Code
        /// </summary>
        public string dict_code { get; set; }
    
        /// <summary>
        /// 字段href
        /// </summary>
        public string field_href { get; set; }
    
        /// <summary>
        /// 字段名
        /// </summary>
        public string field_name { get; set; }
    
        /// <summary>
        /// 字段文本
        /// </summary>
        public string field_txt { get; set; }
    
        /// <summary>
        /// 字段类型
        /// </summary>
        public string field_type { get; set; }
    
        /// <summary>
        /// 是否显示
        /// </summary>
        public string is_show { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        public int? order_num { get; set; }
    
        /// <summary>
        /// 取值表达式
        /// </summary>
        public string replace_va { get; set; }
    
        /// <summary>
        /// 显示图表
        /// </summary>
        public string is_graph { get; set; }
    
        /// <summary>
        /// 图表类型
        /// </summary>
        public string graph_type { get; set; }
    
        /// <summary>
        /// 图表名称
        /// </summary>
        public string graph_name { get; set; }
    
        /// <summary>
        /// 标签名称
        /// </summary>
        public string tab_name { get; set; }
    }
}
