//-----------------------------------------------------------------------
// <copyright file=" t_s_notice.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: t_s_notice.cs
// * history : Created by T4 03/28/2018 17:16:33 
// </copyright>
//-----------------------------------------------------------------------
using System;
using Common.Object;
using System.ComponentModel.DataAnnotations.Schema;

namespace HydrometeorologyGISPluginLib.Data
{
    /// <summary>
    /// t_s_notice Entity Model
    /// </summary>    
    [Table("t_s_notice")]
    public class t_s_notice : ObservableObject
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
    
        private string _notice_title;
        /// <summary>
        /// 通知标题
        /// </summary>
        public string notice_title
        {
            get { return _notice_title; }
            set { updateProper(ref _notice_title, value);}
        }
    
        private string _notice_content;
        /// <summary>
        /// 通知公告内容
        /// </summary>
        public string notice_content
        {
            get { return _notice_content; }
            set { updateProper(ref _notice_content, value);}
        }
    
        private string _notice_type;
        /// <summary>
        /// 通知公告类型（1：通知，2:公告）
        /// </summary>
        public string notice_type
        {
            get { return _notice_type; }
            set { updateProper(ref _notice_type, value);}
        }
    
        private string _notice_level;
        /// <summary>
        /// 通告授权级别（1:全员，2：角色，3：用户）
        /// </summary>
        public string notice_level
        {
            get { return _notice_level; }
            set { updateProper(ref _notice_level, value);}
        }
    
        private DateTime? _notice_term;
        /// <summary>
        /// 阅读期限
        /// </summary>
        public DateTime? notice_term
        {
            get { return _notice_term; }
            set { updateProper(ref _notice_term, value);}
        }
    
        private string _create_user;
        /// <summary>
        /// 创建者
        /// </summary>
        public string create_user
        {
            get { return _create_user; }
            set { updateProper(ref _create_user, value);}
        }
    
        private DateTime? _create_time;
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? create_time
        {
            get { return _create_time; }
            set { updateProper(ref _create_time, value);}
        }
    }
}
