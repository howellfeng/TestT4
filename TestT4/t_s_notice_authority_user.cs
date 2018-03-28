//-----------------------------------------------------------------------
// <copyright file=" t_s_notice_authority_user.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: t_s_notice_authority_user.cs
// * history : Created by T4 03/28/2018 17:16:33 
// </copyright>
//-----------------------------------------------------------------------
using System;
using Common.Object;
using System.ComponentModel.DataAnnotations.Schema;

namespace HydrometeorologyGISPluginLib.Data
{
    /// <summary>
    /// t_s_notice_authority_user Entity Model
    /// </summary>    
    [Table("t_s_notice_authority_user")]
    public class t_s_notice_authority_user : ObservableObject
    {
        private string _id;
        /// <summary>
        /// ID
        /// </summary>        
        public string id
        {
            get { return _id; }
            set { updateProper(ref _id, value);}
        }
    
        private string _notice_id;
        /// <summary>
        /// 通告ID
        /// </summary>
        public string notice_id
        {
            get { return _notice_id; }
            set { updateProper(ref _notice_id, value);}
        }
    
        private string _user_id;
        /// <summary>
        /// 授权用户ID
        /// </summary>
        public string user_id
        {
            get { return _user_id; }
            set { updateProper(ref _user_id, value);}
        }
    }
}
