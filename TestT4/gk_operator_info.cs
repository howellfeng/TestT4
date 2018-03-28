//-----------------------------------------------------------------------
// <copyright file=" gk_operator_info.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: gk_operator_info.cs
// * history : Created by T4 03/28/2018 17:16:33 
// </copyright>
//-----------------------------------------------------------------------
using System;
using Common.Object;
using System.ComponentModel.DataAnnotations.Schema;

namespace HydrometeorologyGISPluginLib.Data
{
    /// <summary>
    /// gk_operator_info Entity Model
    /// </summary>    
    [Table("gk_operator_info")]
    public class gk_operator_info : ObservableObject
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
    
        private string _bpm_status;
        /// <summary>
        /// 流程状态
        /// </summary>
        public string bpm_status
        {
            get { return _bpm_status; }
            set { updateProper(ref _bpm_status, value);}
        }
    
        private string _port_manager_dept;
        /// <summary>
        /// 所在地市港口管理部门
        /// </summary>
        public string port_manager_dept
        {
            get { return _port_manager_dept; }
            set { updateProper(ref _port_manager_dept, value);}
        }
    
        private string _port_operator_name;
        /// <summary>
        /// 港口经营人名称
        /// </summary>
        public string port_operator_name
        {
            get { return _port_operator_name; }
            set { updateProper(ref _port_operator_name, value);}
        }
    
        private string _legal_person;
        /// <summary>
        /// 法定代表人
        /// </summary>
        public string legal_person
        {
            get { return _legal_person; }
            set { updateProper(ref _legal_person, value);}
        }
    
        private string _port_operator_address;
        /// <summary>
        /// 港口经营单位办公地址
        /// </summary>
        public string port_operator_address
        {
            get { return _port_operator_address; }
            set { updateProper(ref _port_operator_address, value);}
        }
    
        private string _operator_type;
        /// <summary>
        /// 经营类型
        /// </summary>
        public string operator_type
        {
            get { return _operator_type; }
            set { updateProper(ref _operator_type, value);}
        }
    
        private string _contact_name;
        /// <summary>
        /// 联系人
        /// </summary>
        public string contact_name
        {
            get { return _contact_name; }
            set { updateProper(ref _contact_name, value);}
        }
    
        private string _contact_tel;
        /// <summary>
        /// 联系电话
        /// </summary>
        public string contact_tel
        {
            get { return _contact_tel; }
            set { updateProper(ref _contact_tel, value);}
        }
    
        private string _fax;
        /// <summary>
        /// 传真
        /// </summary>
        public string fax
        {
            get { return _fax; }
            set { updateProper(ref _fax, value);}
        }
    
        private string _email;
        /// <summary>
        /// 电子邮箱
        /// </summary>
        public string email
        {
            get { return _email; }
            set { updateProper(ref _email, value);}
        }
    
        private string _postcode;
        /// <summary>
        /// 邮编
        /// </summary>
        public string postcode
        {
            get { return _postcode; }
            set { updateProper(ref _postcode, value);}
        }
    
        private string _has_main_city;
        /// <summary>
        /// 是否为主城区
        /// </summary>
        public string has_main_city
        {
            get { return _has_main_city; }
            set { updateProper(ref _has_main_city, value);}
        }
    
        private string _port_type;
        /// <summary>
        /// 港口类型
        /// </summary>
        public string port_type
        {
            get { return _port_type; }
            set { updateProper(ref _port_type, value);}
        }
    
        private string _enclosure_path;
        /// <summary>
        /// 附件
        /// </summary>
        public string enclosure_path
        {
            get { return _enclosure_path; }
            set { updateProper(ref _enclosure_path, value);}
        }
    
        private string _approval_document;
        /// <summary>
        /// 岸线批复文件
        /// </summary>
        public string approval_document
        {
            get { return _approval_document; }
            set { updateProper(ref _approval_document, value);}
        }
    
        private string _remark;
        /// <summary>
        /// 备注
        /// </summary>
        public string remark
        {
            get { return _remark; }
            set { updateProper(ref _remark, value);}
        }
    }
}
