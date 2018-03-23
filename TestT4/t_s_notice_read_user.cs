//-----------------------------------------------------------------------
// <copyright file=" t_s_notice_read_user.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: t_s_notice_read_user.cs
// * history : Created by T4 03/23/2018 16:39:14 
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChongQingNetCheckWebService.Models
{
    /// <summary>
    /// t_s_notice_read_user Entity Model
    /// </summary>    
    [Table("t_s_notice_read_user")]
    public class t_s_notice_read_user
    {
        /// <summary>
        /// ID
        /// </summary>
        public string id { get; set; }
    
        /// <summary>
        /// 通告ID
        /// </summary>
        public string notice_id { get; set; }
    
        /// <summary>
        /// 用户ID
        /// </summary>
        public string user_id { get; set; }
    
        /// <summary>
        /// 是否已阅读
        /// </summary>
        public int? is_read { get; set; }
    
        /// <summary>
        /// 是否已删除
        /// </summary>
        public int? del_flag { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? create_time { get; set; }
    }
}
