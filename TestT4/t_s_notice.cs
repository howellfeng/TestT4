//-----------------------------------------------------------------------
// <copyright file=" t_s_notice.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: t_s_notice.cs
// * history : Created by T4 03/23/2018 15:18:04 
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Console4Test
{
    /// <summary>
    /// t_s_notice Entity Model
    /// </summary>    
    [Table("t_s_notice")]
    public class t_s_notice
    {
        /// <summary>
        /// ID
        /// </summary>
        public string id { get; set; }
    
        /// <summary>
        /// 通知标题
        /// </summary>
        public string notice_title { get; set; }
    
        /// <summary>
        /// 通知公告内容
        /// </summary>
        public string notice_content { get; set; }
    
        /// <summary>
        /// 通知公告类型（1：通知，2:公告）
        /// </summary>
        public string notice_type { get; set; }
    
        /// <summary>
        /// 通告授权级别（1:全员，2：角色，3：用户）
        /// </summary>
        public string notice_level { get; set; }
    
        /// <summary>
        /// 阅读期限
        /// </summary>
        public DateTime? notice_term { get; set; }
    
        /// <summary>
        /// 创建者
        /// </summary>
        public string create_user { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? create_time { get; set; }
    }
}
