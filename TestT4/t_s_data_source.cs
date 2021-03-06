//-----------------------------------------------------------------------
// <copyright file=" t_s_data_source.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: t_s_data_source.cs
// * history : Created by T4 03/28/2018 17:16:33 
// </copyright>
//-----------------------------------------------------------------------
using System;
using Common.Object;
using System.ComponentModel.DataAnnotations.Schema;

namespace HydrometeorologyGISPluginLib.Data
{
    /// <summary>
    /// t_s_data_source Entity Model
    /// </summary>    
    [Table("t_s_data_source")]
    public class t_s_data_source : ObservableObject
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
    
        private string _db_key;
        /// <summary>
        /// 多数据源KEY
        /// </summary>
        public string db_key
        {
            get { return _db_key; }
            set { updateProper(ref _db_key, value);}
        }
    
        private string _description;
        /// <summary>
        /// 描述
        /// </summary>
        public string description
        {
            get { return _description; }
            set { updateProper(ref _description, value);}
        }
    
        private string _driver_class;
        /// <summary>
        /// 驱动class
        /// </summary>
        public string driver_class
        {
            get { return _driver_class; }
            set { updateProper(ref _driver_class, value);}
        }
    
        private string _url;
        /// <summary>
        /// db链接
        /// </summary>
        public string url
        {
            get { return _url; }
            set { updateProper(ref _url, value);}
        }
    
        private string _db_user;
        /// <summary>
        /// 用户名
        /// </summary>
        public string db_user
        {
            get { return _db_user; }
            set { updateProper(ref _db_user, value);}
        }
    
        private string _db_password;
        /// <summary>
        /// 密码
        /// </summary>
        public string db_password
        {
            get { return _db_password; }
            set { updateProper(ref _db_password, value);}
        }
    
        private string _db_type;
        /// <summary>
        /// 数据库类型
        /// </summary>
        public string db_type
        {
            get { return _db_type; }
            set { updateProper(ref _db_type, value);}
        }
    
        private string _db_name;
        /// <summary>
        /// 数据源名字
        /// </summary>
        public string db_name
        {
            get { return _db_name; }
            set { updateProper(ref _db_name, value);}
        }
    }
}
