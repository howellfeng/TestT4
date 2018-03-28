//-----------------------------------------------------------------------
// <copyright file=" yz_enterprises_info.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: yz_enterprises_info.cs
// * history : Created by T4 03/28/2018 17:16:33 
// </copyright>
//-----------------------------------------------------------------------
using System;
using Common.Object;
using System.ComponentModel.DataAnnotations.Schema;

namespace HydrometeorologyGISPluginLib.Data
{
    /// <summary>
    /// yz_enterprises_info Entity Model
    /// </summary>    
    [Table("yz_enterprises_info")]
    public class yz_enterprises_info : ObservableObject
    {
        private string _id;
        /// <summary>
        /// 主键
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
    
        private string _chinese_name;
        /// <summary>
        /// 企业中文名
        /// </summary>
        public string chinese_name
        {
            get { return _chinese_name; }
            set { updateProper(ref _chinese_name, value);}
        }
    
        private string _manager_dept;
        /// <summary>
        /// 所在地航管部门
        /// </summary>
        public string manager_dept
        {
            get { return _manager_dept; }
            set { updateProper(ref _manager_dept, value);}
        }
    
        private string _district_code;
        /// <summary>
        /// 行政区划
        /// </summary>
        public string district_code
        {
            get { return _district_code; }
            set { updateProper(ref _district_code, value);}
        }
    
        private string _registered_address;
        /// <summary>
        /// 注册地址
        /// </summary>
        public string registered_address
        {
            get { return _registered_address; }
            set { updateProper(ref _registered_address, value);}
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
    
        private string _card_no;
        /// <summary>
        /// 身份证号
        /// </summary>
        public string card_no
        {
            get { return _card_no; }
            set { updateProper(ref _card_no, value);}
        }
    
        private string _economic_type;
        /// <summary>
        /// 经济类型
        /// </summary>
        public string economic_type
        {
            get { return _economic_type; }
            set { updateProper(ref _economic_type, value);}
        }
    
        private string _business_certificate_no;
        /// <summary>
        /// 企业法人营业执照号
        /// </summary>
        public string business_certificate_no
        {
            get { return _business_certificate_no; }
            set { updateProper(ref _business_certificate_no, value);}
        }
    
        private string _currency_kind;
        /// <summary>
        /// 资金币种
        /// </summary>
        public string currency_kind
        {
            get { return _currency_kind; }
            set { updateProper(ref _currency_kind, value);}
        }
    
        private string _registered_capital;
        /// <summary>
        /// 注册资本
        /// </summary>
        public string registered_capital
        {
            get { return _registered_capital; }
            set { updateProper(ref _registered_capital, value);}
        }
    
        private string _phone;
        /// <summary>
        /// 联系电话
        /// </summary>
        public string phone
        {
            get { return _phone; }
            set { updateProper(ref _phone, value);}
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
    
        private string _business_scope;
        /// <summary>
        /// 经营范围
        /// </summary>
        public string business_scope
        {
            get { return _business_scope; }
            set { updateProper(ref _business_scope, value);}
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
    
        private string _apply_reason;
        /// <summary>
        /// 申请原因
        /// </summary>
        public string apply_reason
        {
            get { return _apply_reason; }
            set { updateProper(ref _apply_reason, value);}
        }
    
        private string _enter_type;
        /// <summary>
        /// 企业类型
        /// </summary>
        public string enter_type
        {
            get { return _enter_type; }
            set { updateProper(ref _enter_type, value);}
        }
    
        private string _status;
        /// <summary>
        /// 管理企业状态
        /// </summary>
        public string status
        {
            get { return _status; }
            set { updateProper(ref _status, value);}
        }
    
        private string _check_time;
        /// <summary>
        /// 最近年审年份
        /// </summary>
        public string check_time
        {
            get { return _check_time; }
            set { updateProper(ref _check_time, value);}
        }
    
        private DateTime? _expire_time;
        /// <summary>
        /// 营运证到期时间
        /// </summary>
        public DateTime? expire_time
        {
            get { return _expire_time; }
            set { updateProper(ref _expire_time, value);}
        }
    
        private string _certificate;
        /// <summary>
        /// 管理企业营运证
        /// </summary>
        public string certificate
        {
            get { return _certificate; }
            set { updateProper(ref _certificate, value);}
        }
    }
}
