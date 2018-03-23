//-----------------------------------------------------------------------
// <copyright file=" t_s_operation.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: t_s_operation.cs
// * history : Created by T4 03/23/2018 15:18:04 
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Console4Test
{
    /// <summary>
    /// t_s_operation Entity Model
    /// </summary>    
    [Table("t_s_operation")]
    public class t_s_operation
    {
        /// <summary>
        /// id
        /// </summary>
        public string ID { get; set; }
    
        /// <summary>
        /// 页面控件code
        /// </summary>
        public string operationcode { get; set; }
    
        /// <summary>
        /// 图标
        /// </summary>
        public string operationicon { get; set; }
    
        /// <summary>
        /// 页面名字
        /// </summary>
        public string operationname { get; set; }
    
        /// <summary>
        /// 状态
        /// </summary>
        public int? status { get; set; }
    
        /// <summary>
        /// 菜单ID
        /// </summary>
        public string functionid { get; set; }
    
        /// <summary>
        /// 图标ID
        /// </summary>
        public string iconid { get; set; }
    
        /// <summary>
        /// 规则类型：1/禁用 0/隐藏
        /// </summary>
        public int? operationtype { get; set; }
    }
}
