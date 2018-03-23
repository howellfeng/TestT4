//-----------------------------------------------------------------------
// <copyright file=" cgform_button_sql.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: cgform_button_sql.cs
// * history : Created by T4 03/23/2018 16:39:14 
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChongQingNetCheckWebService.Models
{
    /// <summary>
    /// cgform_button_sql Entity Model
    /// </summary>    
    [Table("cgform_button_sql")]
    public class cgform_button_sql
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
        /// SQL内容
        /// </summary>
        public string CGB_SQL { get; set; }
    
        /// <summary>
        /// Sql名称
        /// </summary>
        public string CGB_SQL_NAME { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        public string CONTENT { get; set; }
    
        /// <summary>
        /// 表单ID
        /// </summary>
        public string FORM_ID { get; set; }
    }
}
