//-----------------------------------------------------------------------
// <copyright file=" t_s_data_rule.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: t_s_data_rule.cs
// * history : Created by T4 03/26/2018 22:24:20 
// </copyright>
//-----------------------------------------------------------------------
using System;
using Common.Object;
using System.ComponentModel.DataAnnotations.Schema;

namespace HydrometeorologyGISPluginLib.Data
{
    /// <summary>
    /// t_s_data_rule Entity Model
    /// </summary>    
    [Table("t_s_data_rule")]
    public class t_s_data_rule : ObservableObject
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
    
        private string _rule_name;
        /// <summary>
        /// 数据权限规则名称
        /// </summary>
        public string rule_name
        {
            get { return _rule_name; }
            set { updateProper(ref _rule_name, value);}
        }
    
        private string _rule_column;
        /// <summary>
        /// 字段
        /// </summary>
        public string rule_column
        {
            get { return _rule_column; }
            set { updateProper(ref _rule_column, value);}
        }
    
        private string _rule_conditions;
        /// <summary>
        /// 条件
        /// </summary>
        public string rule_conditions
        {
            get { return _rule_conditions; }
            set { updateProper(ref _rule_conditions, value);}
        }
    
        private string _rule_value;
        /// <summary>
        /// 规则值
        /// </summary>
        public string rule_value
        {
            get { return _rule_value; }
            set { updateProper(ref _rule_value, value);}
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
        /// 
        /// </summary>
        public string create_by
        {
            get { return _create_by; }
            set { updateProper(ref _create_by, value);}
        }
    
        private string _create_name;
        /// <summary>
        /// 创建时间
        /// </summary>
        public string create_name
        {
            get { return _create_name; }
            set { updateProper(ref _create_name, value);}
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
        /// 修改人
        /// </summary>
        public string update_by
        {
            get { return _update_by; }
            set { updateProper(ref _update_by, value);}
        }
    
        private string _update_name;
        /// <summary>
        /// 修改人名字
        /// </summary>
        public string update_name
        {
            get { return _update_name; }
            set { updateProper(ref _update_name, value);}
        }
    
        private string _functionId;
        /// <summary>
        /// 菜单ID
        /// </summary>
        public string functionId
        {
            get { return _functionId; }
            set { updateProper(ref _functionId, value);}
        }
    }
}
