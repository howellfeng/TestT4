//-----------------------------------------------------------------------
// <copyright file=" t_s_user_org.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: t_s_user_org.cs
// * history : Created by T4 03/23/2018 15:18:04 
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Console4Test
{
    /// <summary>
    /// t_s_user_org Entity Model
    /// </summary>    
    [Table("t_s_user_org")]
    public class t_s_user_org
    {
        /// <summary>
        /// id
        /// </summary>
        public string ID { get; set; }
    
        /// <summary>
        /// 用户id
        /// </summary>
        public string user_id { get; set; }
    
        /// <summary>
        /// 部门id
        /// </summary>
        public string org_id { get; set; }
    }
}
