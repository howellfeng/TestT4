//-----------------------------------------------------------------------
// <copyright file=" jp_demo_activity.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: jp_demo_activity.cs
// * history : Created by T4 03/23/2018 15:18:04 
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Console4Test
{
    /// <summary>
    /// jp_demo_activity Entity Model
    /// </summary>    
    [Table("jp_demo_activity")]
    public class jp_demo_activity
    {
        /// <summary>
        /// ID
        /// </summary>
        public string id { get; set; }
    
        /// <summary>
        /// 活动名称
        /// </summary>
        public string name { get; set; }
    
        /// <summary>
        /// 活动开始时间
        /// </summary>
        public DateTime? begin_time { get; set; }
    
        /// <summary>
        ///  活动结束时间
        /// </summary>
        public DateTime? end_time { get; set; }
    
        /// <summary>
        /// 入口地址
        /// </summary>
        public string hdurl { get; set; }
    }
}
