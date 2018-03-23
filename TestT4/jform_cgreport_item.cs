//-----------------------------------------------------------------------
// <copyright file=" jform_cgreport_item.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: jform_cgreport_item.cs
// * history : Created by T4 03/23/2018 15:18:04 
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Console4Test
{
    /// <summary>
    /// jform_cgreport_item Entity Model
    /// </summary>    
    [Table("jform_cgreport_item")]
    public class jform_cgreport_item
    {
        /// <summary>
        /// 
        /// </summary>
        public string ID { get; set; }
    
        /// <summary>
        /// 是否查询
        /// </summary>
        public string S_FLAG { get; set; }
    
        /// <summary>
        /// 查询模式
        /// </summary>
        public string S_MODE { get; set; }
    
        /// <summary>
        /// 报表ID
        /// </summary>
        public string CGRHEAD_ID { get; set; }
    
        /// <summary>
        /// 字典CODE
        /// </summary>
        public string DICT_CODE { get; set; }
    
        /// <summary>
        /// 字段跳转URL
        /// </summary>
        public string FIELD_HREF { get; set; }
    
        /// <summary>
        /// 字段名字
        /// </summary>
        public string FIELD_NAME { get; set; }
    
        /// <summary>
        /// 字段文本
        /// </summary>
        public string FIELD_TXT { get; set; }
    
        /// <summary>
        /// 字段类型
        /// </summary>
        public string FIELD_TYPE { get; set; }
    
        /// <summary>
        /// 是否显示
        /// </summary>
        public string IS_SHOW { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        public int? ORDER_NUM { get; set; }
    
        /// <summary>
        /// 取值表达式
        /// </summary>
        public string REPLACE_VA { get; set; }
    }
}
