//-----------------------------------------------------------------------
// <copyright file=" t_s_role_user.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: t_s_role_user.cs
// * history : Created by T4 03/23/2018 16:39:14 
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChongQingNetCheckWebService.Models
{
    /// <summary>
    /// t_s_role_user Entity Model
    /// </summary>    
    [Table("t_s_role_user")]
    public class t_s_role_user
    {
        /// <summary>
        /// ID
        /// </summary>
        public string ID { get; set; }
    
        /// <summary>
        /// 角色ID
        /// </summary>
        public string roleid { get; set; }
    
        /// <summary>
        /// 用户ID
        /// </summary>
        public string userid { get; set; }
    }
}
