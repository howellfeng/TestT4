//-----------------------------------------------------------------------
// <copyright file=" t_s_function_group_user.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: t_s_function_group_user.cs
// * history : Created by T4 03/28/2018 17:16:33 
// </copyright>
//-----------------------------------------------------------------------
using System;
using Common.Object;
using System.ComponentModel.DataAnnotations.Schema;

namespace HydrometeorologyGISPluginLib.Data
{
    /// <summary>
    /// t_s_function_group_user Entity Model
    /// </summary>    
    [Table("t_s_function_group_user")]
    public class t_s_function_group_user : ObservableObject
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
    
        private string _group_id;
        /// <summary>
        /// 权限组ID
        /// </summary>
        public string group_id
        {
            get { return _group_id; }
            set { updateProper(ref _group_id, value);}
        }
    
        private string _user_id;
        /// <summary>
        /// 用户ID
        /// </summary>
        public string user_id
        {
            get { return _user_id; }
            set { updateProper(ref _user_id, value);}
        }
    
        private int? _type;
        /// <summary>
        /// 权限组类型
        /// </summary>
        public int? type
        {
            get { return _type; }
            set { updateProper(ref _type, value);}
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
    
        private string _create_by;
        /// <summary>
        /// 创建人id
        /// </summary>
        public string create_by
        {
            get { return _create_by; }
            set { updateProper(ref _create_by, value);}
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
    
        private string _update_name;
        /// <summary>
        /// 修改人
        /// </summary>
        public string update_name
        {
            get { return _update_name; }
            set { updateProper(ref _update_name, value);}
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
    
        private DateTime? _update_date;
        /// <summary>
        /// 修改时间
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
    }
}
