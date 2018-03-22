//-----------------------------------------------------------------------
// <copyright file=" t_s_sms_sql.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: t_s_sms_sql.cs
// * history : Created by T4 03/22/2018 16:26:40 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace Console4Test
{
    /// <summary>
    /// t_s_sms_sql Entity Model
    /// </summary>    
    [Serializable]
    public class t_s_sms_sql
    {
        /// <summary>
        /// 主键
        /// </summary>
        public string id { get; set; }
    
        /// <summary>
        /// SQL名称
        /// </summary>
        public string sql_name { get; set; }
    
        /// <summary>
        /// SQL内容
        /// </summary>
        public string sql_content { get; set; }
    
        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime create_date { get; set; }
    
        /// <summary>
        /// 创建人登录名称
        /// </summary>
        public string create_by { get; set; }
    
        /// <summary>
        /// 创建人名称
        /// </summary>
        public string create_name { get; set; }
    
        /// <summary>
        /// 更新日期
        /// </summary>
        public DateTime update_date { get; set; }
    
        /// <summary>
        /// 更新人登录名称
        /// </summary>
        public string update_by { get; set; }
    
        /// <summary>
        /// 更新人名称
        /// </summary>
        public string update_name { get; set; }
    }
}
