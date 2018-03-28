//-----------------------------------------------------------------------
// <copyright file=" jform_cgreport_param.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: jform_cgreport_param.cs
// * history : Created by T4 03/28/2018 17:16:33 
// </copyright>
//-----------------------------------------------------------------------
using System;
using Common.Object;
using System.ComponentModel.DataAnnotations.Schema;

namespace HydrometeorologyGISPluginLib.Data
{
    /// <summary>
    /// jform_cgreport_param Entity Model
    /// </summary>    
    [Table("jform_cgreport_param")]
    public class jform_cgreport_param : ObservableObject
    {
        private string _id;
        /// <summary>
        /// 
        /// </summary>        
        public string id
        {
            get { return _id; }
            set { updateProper(ref _id, value);}
        }
    
        private string _create_name;
        /// <summary>
        /// 创建人名称
        /// </summary>
        public string create_name
        {
            get { return _create_name; }
            set { updateProper(ref _create_name, value);}
        }
    
        private string _create_by;
        /// <summary>
        /// 创建人登录名称
        /// </summary>
        public string create_by
        {
            get { return _create_by; }
            set { updateProper(ref _create_by, value);}
        }
    
        private DateTime? _create_date;
        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime? create_date
        {
            get { return _create_date; }
            set { updateProper(ref _create_date, value);}
        }
    
        private string _update_name;
        /// <summary>
        /// 更新人名称
        /// </summary>
        public string update_name
        {
            get { return _update_name; }
            set { updateProper(ref _update_name, value);}
        }
    
        private string _update_by;
        /// <summary>
        /// 更新人登录名称
        /// </summary>
        public string update_by
        {
            get { return _update_by; }
            set { updateProper(ref _update_by, value);}
        }
    
        private DateTime? _update_date;
        /// <summary>
        /// 更新日期
        /// </summary>
        public DateTime? update_date
        {
            get { return _update_date; }
            set { updateProper(ref _update_date, value);}
        }
    
        private string _sys_org_code;
        /// <summary>
        /// 所属部门
        /// </summary>
        public string sys_org_code
        {
            get { return _sys_org_code; }
            set { updateProper(ref _sys_org_code, value);}
        }
    
        private string _sys_company_code;
        /// <summary>
        /// 所属公司
        /// </summary>
        public string sys_company_code
        {
            get { return _sys_company_code; }
            set { updateProper(ref _sys_company_code, value);}
        }
    
        private string _param_name;
        /// <summary>
        /// 参数名称
        /// </summary>
        public string param_name
        {
            get { return _param_name; }
            set { updateProper(ref _param_name, value);}
        }
    
        private string _param_desc;
        /// <summary>
        /// 参数说明
        /// </summary>
        public string param_desc
        {
            get { return _param_desc; }
            set { updateProper(ref _param_desc, value);}
        }
    
        private string _param_value;
        /// <summary>
        /// 数值
        /// </summary>
        public string param_value
        {
            get { return _param_value; }
            set { updateProper(ref _param_value, value);}
        }
    
        private int? _seq;
        /// <summary>
        /// 排序
        /// </summary>
        public int? seq
        {
            get { return _seq; }
            set { updateProper(ref _seq, value);}
        }
    
        private string _cgrhead_id;
        /// <summary>
        /// 动态报表ID
        /// </summary>
        public string cgrhead_id
        {
            get { return _cgrhead_id; }
            set { updateProper(ref _cgrhead_id, value);}
        }
    }
}
