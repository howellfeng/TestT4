//-----------------------------------------------------------------------
// <copyright file=" jeecg_order_product.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: jeecg_order_product.cs
// * history : Created by T4 03/23/2018 16:39:14 
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChongQingNetCheckWebService.Models
{
    /// <summary>
    /// jeecg_order_product Entity Model
    /// </summary>    
    [Table("jeecg_order_product")]
    public class jeecg_order_product
    {
        /// <summary>
        /// 
        /// </summary>
        public string ID { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public DateTime? CREATE_DT { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public string CRTUSER { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public string CRTUSER_NAME { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public DateTime? DEL_DT { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public int? DELFLAG { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public string GO_ORDER_CODE { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public string GOP_CONTENT { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public int? GOP_COUNT { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public decimal? GOP_ONE_PRICE { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public string GOP_PRODUCT_NAME { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public string GOP_PRODUCT_TYPE { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public decimal? GOP_SUM_PRICE { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public string MODIFIER { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public string MODIFIER_NAME { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public DateTime? MODIFY_DT { get; set; }
    }
}
