//-----------------------------------------------------------------------
// <copyright file=" t_s_log.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: t_s_log.cs
// * history : Created by T4 03/28/2018 17:16:33 
// </copyright>
//-----------------------------------------------------------------------
using System;
using Common.Object;
using System.ComponentModel.DataAnnotations.Schema;

namespace HydrometeorologyGISPluginLib.Data
{
    /// <summary>
    /// t_s_log Entity Model
    /// </summary>    
    [Table("t_s_log")]
    public class t_s_log : ObservableObject
    {
        private string _ID;
        /// <summary>
        /// id
        /// </summary>        
        public string ID
        {
            get { return _ID; }
            set { updateProper(ref _ID, value);}
        }
    
        private string _broswer;
        /// <summary>
        /// 浏览器
        /// </summary>
        public string broswer
        {
            get { return _broswer; }
            set { updateProper(ref _broswer, value);}
        }
    
        private string _logcontent;
        /// <summary>
        /// 日志内容
        /// </summary>
        public string logcontent
        {
            get { return _logcontent; }
            set { updateProper(ref _logcontent, value);}
        }
    
        private int? _loglevel;
        /// <summary>
        /// 日志级别
        /// </summary>
        public int? loglevel
        {
            get { return _loglevel; }
            set { updateProper(ref _loglevel, value);}
        }
    
        private string _note;
        /// <summary>
        /// IP
        /// </summary>
        public string note
        {
            get { return _note; }
            set { updateProper(ref _note, value);}
        }
    
        private DateTime? _operatetime;
        /// <summary>
        /// 操作时间
        /// </summary>
        public DateTime? operatetime
        {
            get { return _operatetime; }
            set { updateProper(ref _operatetime, value);}
        }
    
        private int? _operatetype;
        /// <summary>
        /// 操作类型
        /// </summary>
        public int? operatetype
        {
            get { return _operatetype; }
            set { updateProper(ref _operatetype, value);}
        }
    
        private string _userid;
        /// <summary>
        /// 用户ID
        /// </summary>
        public string userid
        {
            get { return _userid; }
            set { updateProper(ref _userid, value);}
        }
    
        private string _username;
        /// <summary>
        /// 用户账号
        /// </summary>
        public string username
        {
            get { return _username; }
            set { updateProper(ref _username, value);}
        }
    
        private string _realname;
        /// <summary>
        /// 真实名字
        /// </summary>
        public string realname
        {
            get { return _realname; }
            set { updateProper(ref _realname, value);}
        }
    }
}
