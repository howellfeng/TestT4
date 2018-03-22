//-----------------------------------------------------------------------
// <copyright file=" jp_inner_mail.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: jp_inner_mail.cs
// * history : Created by T4 03/22/2018 16:26:40 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace Console4Test
{
    /// <summary>
    /// jp_inner_mail Entity Model
    /// </summary>    
    [Serializable]
    public class jp_inner_mail
    {
        /// <summary>
        /// 主键
        /// </summary>
        public string id { get; set; }
    
        /// <summary>
        /// 创建人名称
        /// </summary>
        public string create_name { get; set; }
    
        /// <summary>
        /// 创建人登录名称
        /// </summary>
        public string create_by { get; set; }
    
        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime create_date { get; set; }
    
        /// <summary>
        /// 主题
        /// </summary>
        public string title { get; set; }
    
        /// <summary>
        /// 附件
        /// </summary>
        public string attachment { get; set; }
    
        /// <summary>
        /// 内容
        /// </summary>
        public string content { get; set; }
    
        /// <summary>
        /// 状态
        /// </summary>
        public string status { get; set; }
    
        /// <summary>
        /// 接收者姓名列表
        /// </summary>
        public string receiver_names { get; set; }
    
        /// <summary>
        /// 收件人标识列表
        /// </summary>
        public string receiver_ids { get; set; }
    }
}
