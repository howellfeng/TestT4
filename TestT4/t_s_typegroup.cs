//-----------------------------------------------------------------------
// <copyright file=" t_s_typegroup.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: t_s_typegroup.cs
// * history : Created by T4 03/28/2018 17:16:33 
// </copyright>
//-----------------------------------------------------------------------
using System;
using Common.Object;
using System.ComponentModel.DataAnnotations.Schema;

namespace HydrometeorologyGISPluginLib.Data
{
    /// <summary>
    /// t_s_typegroup Entity Model
    /// </summary>    
    [Table("t_s_typegroup")]
    public class t_s_typegroup : ObservableObject
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
    
        private string _typegroupcode;
        /// <summary>
        /// 字典分组编码
        /// </summary>
        public string typegroupcode
        {
            get { return _typegroupcode; }
            set { updateProper(ref _typegroupcode, value);}
        }
    
        private string _typegroupname;
        /// <summary>
        /// 字典分组名称
        /// </summary>
        public string typegroupname
        {
            get { return _typegroupname; }
            set { updateProper(ref _typegroupname, value);}
        }
    
        private DateTime? _create_date;
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? create_date
        {
            get { return _create_date; }
            set { updateProper(ref _create_date, value);}
        }
    
        private string _create_name;
        /// <summary>
        /// 创建用户
        /// </summary>
        public string create_name
        {
            get { return _create_name; }
            set { updateProper(ref _create_name, value);}
        }
    }
}
