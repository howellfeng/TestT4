//-----------------------------------------------------------------------
// <copyright file=" jform_cgreport_head.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: jform_cgreport_head.cs
// * history : Created by T4 03/26/2018 22:24:20 
// </copyright>
//-----------------------------------------------------------------------
using System;
using Common.Object;
using System.ComponentModel.DataAnnotations.Schema;

namespace HydrometeorologyGISPluginLib.Data
{
    /// <summary>
    /// jform_cgreport_head Entity Model
    /// </summary>    
    [Table("jform_cgreport_head")]
    public class jform_cgreport_head : ObservableObject
    {
        private string _ID;
        /// <summary>
        /// 
        /// </summary>        
        public string ID
        {
            get { return _ID; }
            set { updateProper(ref _ID, value);}
        }
    
        private string _CGR_SQL;
        /// <summary>
        /// 报表SQL
        /// </summary>
        public string CGR_SQL
        {
            get { return _CGR_SQL; }
            set { updateProper(ref _CGR_SQL, value);}
        }
    
        private string _CODE;
        /// <summary>
        /// 报表编码
        /// </summary>
        public string CODE
        {
            get { return _CODE; }
            set { updateProper(ref _CODE, value);}
        }
    
        private string _CONTENT;
        /// <summary>
        /// 描述
        /// </summary>
        public string CONTENT
        {
            get { return _CONTENT; }
            set { updateProper(ref _CONTENT, value);}
        }
    
        private string _NAME;
        /// <summary>
        /// 报表名字
        /// </summary>
        public string NAME
        {
            get { return _NAME; }
            set { updateProper(ref _NAME, value);}
        }
    
        private string _update_name;
        /// <summary>
        /// 修改人
        /// </summary>
        public string update_name
        {
            get { return _update_name; }
            set { updateProper(ref _update_name, value);}
        }
    
        private DateTime? _update_date;
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? update_date
        {
            get { return _update_date; }
            set { updateProper(ref _update_date, value);}
        }
    
        private string _update_by;
        /// <summary>
        /// 修改人id
        /// </summary>
        public string update_by
        {
            get { return _update_by; }
            set { updateProper(ref _update_by, value);}
        }
    
        private string _create_name;
        /// <summary>
        /// 创建人
        /// </summary>
        public string create_name
        {
            get { return _create_name; }
            set { updateProper(ref _create_name, value);}
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
    
        private string _create_by;
        /// <summary>
        /// 创建人id
        /// </summary>
        public string create_by
        {
            get { return _create_by; }
            set { updateProper(ref _create_by, value);}
        }
    
        private string _db_source;
        /// <summary>
        /// 动态数据源
        /// </summary>
        public string db_source
        {
            get { return _db_source; }
            set { updateProper(ref _db_source, value);}
        }
    
        private string _return_val_field;
        /// <summary>
        /// 返回值字段
        /// </summary>
        public string return_val_field
        {
            get { return _return_val_field; }
            set { updateProper(ref _return_val_field, value);}
        }
    
        private string _return_txt_field;
        /// <summary>
        /// 返回文本字段
        /// </summary>
        public string return_txt_field
        {
            get { return _return_txt_field; }
            set { updateProper(ref _return_txt_field, value);}
        }
    
        private string _pop_retype;
        /// <summary>
        /// 返回类型，单选或多选
        /// </summary>
        public string pop_retype
        {
            get { return _pop_retype; }
            set { updateProper(ref _pop_retype, value);}
        }
    }
}
