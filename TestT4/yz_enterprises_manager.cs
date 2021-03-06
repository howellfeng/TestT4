//-----------------------------------------------------------------------
// <copyright file=" yz_enterprises_manager.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: yz_enterprises_manager.cs
// * history : Created by T4 03/28/2018 17:16:33 
// </copyright>
//-----------------------------------------------------------------------
using System;
using Common.Object;
using System.ComponentModel.DataAnnotations.Schema;

namespace HydrometeorologyGISPluginLib.Data
{
    /// <summary>
    /// yz_enterprises_manager Entity Model
    /// </summary>    
    [Table("yz_enterprises_manager")]
    public class yz_enterprises_manager : ObservableObject
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
    
        private string _name;
        /// <summary>
        /// 姓名
        /// </summary>
        public string name
        {
            get { return _name; }
            set { updateProper(ref _name, value);}
        }
    
        private string _sex;
        /// <summary>
        /// 性别
        /// </summary>
        public string sex
        {
            get { return _sex; }
            set { updateProper(ref _sex, value);}
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
    
        private string _dept;
        /// <summary>
        /// 所在部门
        /// </summary>
        public string dept
        {
            get { return _dept; }
            set { updateProper(ref _dept, value);}
        }
    
        private string _duty;
        /// <summary>
        /// 职务
        /// </summary>
        public string duty
        {
            get { return _duty; }
            set { updateProper(ref _duty, value);}
        }
    
        private string _duty_certificate_type;
        /// <summary>
        /// 适任证书类型
        /// </summary>
        public string duty_certificate_type
        {
            get { return _duty_certificate_type; }
            set { updateProper(ref _duty_certificate_type, value);}
        }
    
        private string _duty_certificate_no;
        /// <summary>
        /// 适任证书编号
        /// </summary>
        public string duty_certificate_no
        {
            get { return _duty_certificate_no; }
            set { updateProper(ref _duty_certificate_no, value);}
        }
    
        private DateTime? _contract_start_date;
        /// <summary>
        /// 聘用合同起
        /// </summary>
        public DateTime? contract_start_date
        {
            get { return _contract_start_date; }
            set { updateProper(ref _contract_start_date, value);}
        }
    
        private DateTime? _contract_end_date;
        /// <summary>
        /// 聘用合同至
        /// </summary>
        public DateTime? contract_end_date
        {
            get { return _contract_end_date; }
            set { updateProper(ref _contract_end_date, value);}
        }
    
        private string _address;
        /// <summary>
        /// 联系地址
        /// </summary>
        public string address
        {
            get { return _address; }
            set { updateProper(ref _address, value);}
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
    
        private string _email;
        /// <summary>
        /// 电子邮件
        /// </summary>
        public string email
        {
            get { return _email; }
            set { updateProper(ref _email, value);}
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
    
        private string _operator_id;
        /// <summary>
        /// 关联ID
        /// </summary>
        public string operator_id
        {
            get { return _operator_id; }
            set { updateProper(ref _operator_id, value);}
        }
    }
}
