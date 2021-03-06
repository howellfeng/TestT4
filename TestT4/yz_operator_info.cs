//-----------------------------------------------------------------------
// <copyright file=" yz_operator_info.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: yz_operator_info.cs
// * history : Created by T4 03/28/2018 17:16:33 
// </copyright>
//-----------------------------------------------------------------------
using System;
using Common.Object;
using System.ComponentModel.DataAnnotations.Schema;

namespace HydrometeorologyGISPluginLib.Data
{
    /// <summary>
    /// yz_operator_info Entity Model
    /// </summary>    
    [Table("yz_operator_info")]
    public class yz_operator_info : ObservableObject
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
        /// 经营者中文名称
        /// </summary>
        public string chinese_name
        {
            get { return _chinese_name; }
            set { updateProper(ref _chinese_name, value);}
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
    
        private string _legal_card_no;
        /// <summary>
        /// 身份证号
        /// </summary>
        public string legal_card_no
        {
            get { return _legal_card_no; }
            set { updateProper(ref _legal_card_no, value);}
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
        /// 经营者法人营业执照号
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
    
        private string _sailor_count;
        /// <summary>
        /// 高级船员数量
        /// </summary>
        public string sailor_count
        {
            get { return _sailor_count; }
            set { updateProper(ref _sailor_count, value);}
        }
    
        private string _pact_count;
        /// <summary>
        /// 签订劳务合同的高级船员数量 
        /// </summary>
        public string pact_count
        {
            get { return _pact_count; }
            set { updateProper(ref _pact_count, value);}
        }
    
        private string _percentage;
        /// <summary>
        /// 签订劳务合同高级船员占比
        /// </summary>
        public string percentage
        {
            get { return _percentage; }
            set { updateProper(ref _percentage, value);}
        }
    
        private string _passenger_area;
        /// <summary>
        /// 申请客运经营范围
        /// </summary>
        public string passenger_area
        {
            get { return _passenger_area; }
            set { updateProper(ref _passenger_area, value);}
        }
    
        private string _transport_area;
        /// <summary>
        /// 申请货运经营范围 
        /// </summary>
        public string transport_area
        {
            get { return _transport_area; }
            set { updateProper(ref _transport_area, value);}
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
    
        private string _sj_tr_type;
        /// <summary>
        /// 省际运输类型
        /// </summary>
        public string sj_tr_type
        {
            get { return _sj_tr_type; }
            set { updateProper(ref _sj_tr_type, value);}
        }
    
        private string _water_type;
        /// <summary>
        /// 运输主水系类型
        /// </summary>
        public string water_type
        {
            get { return _water_type; }
            set { updateProper(ref _water_type, value);}
        }
    
        private string _operator_type;
        /// <summary>
        /// 经营者类型
        /// </summary>
        public string operator_type
        {
            get { return _operator_type; }
            set { updateProper(ref _operator_type, value);}
        }
    
        private string _qx_tr_type;
        /// <summary>
        /// 区县运输类型
        /// </summary>
        public string qx_tr_type
        {
            get { return _qx_tr_type; }
            set { updateProper(ref _qx_tr_type, value);}
        }
    
        private string _container_liner;
        /// <summary>
        /// 是否集装箱班轮内支线
        /// </summary>
        public string container_liner
        {
            get { return _container_liner; }
            set { updateProper(ref _container_liner, value);}
        }
    
        private string _is_unit;
        /// <summary>
        /// 是否个体
        /// </summary>
        public string is_unit
        {
            get { return _is_unit; }
            set { updateProper(ref _is_unit, value);}
        }
    
        private string _open_type;
        /// <summary>
        /// 开业方式
        /// </summary>
        public string open_type
        {
            get { return _open_type; }
            set { updateProper(ref _open_type, value);}
        }
    
        private string _coastal_island;
        /// <summary>
        /// 沿海内河
        /// </summary>
        public string coastal_island
        {
            get { return _coastal_island; }
            set { updateProper(ref _coastal_island, value);}
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
    
        private string _sn_tr_type;
        /// <summary>
        /// 市内运输类型
        /// </summary>
        public string sn_tr_type
        {
            get { return _sn_tr_type; }
            set { updateProper(ref _sn_tr_type, value);}
        }
    
        private string _certificate;
        /// <summary>
        /// 许可证编号
        /// </summary>
        public string certificate
        {
            get { return _certificate; }
            set { updateProper(ref _certificate, value);}
        }
    
        private string _status;
        /// <summary>
        /// 企业状态
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
        /// 经营许可证到期时间
        /// </summary>
        public DateTime? expire_time
        {
            get { return _expire_time; }
            set { updateProper(ref _expire_time, value);}
        }
    }
}
