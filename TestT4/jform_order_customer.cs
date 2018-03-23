//-----------------------------------------------------------------------
// <copyright file=" jform_order_customer.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: jform_order_customer.cs
// * history : Created by T4 03/23/2018 16:39:14 
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChongQingNetCheckWebService.Models
{
    /// <summary>
    /// jform_order_customer Entity Model
    /// </summary>    
    [Table("jform_order_customer")]
    public class jform_order_customer
    {
        /// <summary>
        /// 主键
        /// </summary>
        public string id { get; set; }
    
        /// <summary>
        /// 客户名
        /// </summary>
        public string name { get; set; }
    
        /// <summary>
        /// 单价
        /// </summary>
        public double? money { get; set; }
    
        /// <summary>
        /// 性别
        /// </summary>
        public string sex { get; set; }
    
        /// <summary>
        /// 电话
        /// </summary>
        public string telphone { get; set; }
    
        /// <summary>
        /// 外键
        /// </summary>
        public string fk_id { get; set; }
    
        /// <summary>
        /// 身份证扫描件
        /// </summary>
        public string sf_pic { get; set; }
    }
}
