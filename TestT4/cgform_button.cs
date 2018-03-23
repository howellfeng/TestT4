//-----------------------------------------------------------------------
// <copyright file=" cgform_button.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: cgform_button.cs
// * history : Created by T4 03/23/2018 16:39:14 
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChongQingNetCheckWebService.Models
{
    /// <summary>
    /// cgform_button Entity Model
    /// </summary>    
    [Table("cgform_button")]
    public class cgform_button
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public string ID { get; set; }
    
        /// <summary>
        /// 按钮编码
        /// </summary>
        public string BUTTON_CODE { get; set; }
    
        /// <summary>
        /// 按钮图标
        /// </summary>
        public string button_icon { get; set; }
    
        /// <summary>
        /// 按钮名称
        /// </summary>
        public string BUTTON_NAME { get; set; }
    
        /// <summary>
        /// 按钮状态
        /// </summary>
        public string BUTTON_STATUS { get; set; }
    
        /// <summary>
        /// 按钮样式
        /// </summary>
        public string BUTTON_STYLE { get; set; }
    
        /// <summary>
        /// 表达式
        /// </summary>
        public string EXP { get; set; }
    
        /// <summary>
        /// 表单ID
        /// </summary>
        public string FORM_ID { get; set; }
    
        /// <summary>
        /// 按钮类型
        /// </summary>
        public string OPT_TYPE { get; set; }
    
        /// <summary>
        /// 排序
        /// </summary>
        public int? order_num { get; set; }
    }
}
