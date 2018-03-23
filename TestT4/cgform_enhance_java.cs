//-----------------------------------------------------------------------
// <copyright file=" cgform_enhance_java.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: cgform_enhance_java.cs
// * history : Created by T4 03/23/2018 16:39:14 
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChongQingNetCheckWebService.Models
{
    /// <summary>
    /// cgform_enhance_java Entity Model
    /// </summary>    
    [Table("cgform_enhance_java")]
    public class cgform_enhance_java
    {
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }
    
        /// <summary>
        /// 按钮编码
        /// </summary>
        public string button_code { get; set; }
    
        /// <summary>
        /// 类型
        /// </summary>
        public string cg_java_type { get; set; }
    
        /// <summary>
        /// 数值
        /// </summary>
        public string cg_java_value { get; set; }
    
        /// <summary>
        /// 表单ID
        /// </summary>
        public string form_id { get; set; }
    
        /// <summary>
        /// 生效状态
        /// </summary>
        public string active_status { get; set; }
    }
}
