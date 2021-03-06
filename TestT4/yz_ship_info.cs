//-----------------------------------------------------------------------
// <copyright file=" yz_ship_info.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: yz_ship_info.cs
// * history : Created by T4 03/28/2018 17:16:33 
// </copyright>
//-----------------------------------------------------------------------
using System;
using Common.Object;
using System.ComponentModel.DataAnnotations.Schema;

namespace HydrometeorologyGISPluginLib.Data
{
    /// <summary>
    /// yz_ship_info Entity Model
    /// </summary>    
    [Table("yz_ship_info")]
    public class yz_ship_info : ObservableObject
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
    
        private string _apply_reason;
        /// <summary>
        /// 申请原因
        /// </summary>
        public string apply_reason
        {
            get { return _apply_reason; }
            set { updateProper(ref _apply_reason, value);}
        }
    
        private string _apply_type;
        /// <summary>
        /// 申请类型
        /// </summary>
        public string apply_type
        {
            get { return _apply_type; }
            set { updateProper(ref _apply_type, value);}
        }
    
        private string _chinese_name;
        /// <summary>
        /// 船舶中文名称
        /// </summary>
        public string chinese_name
        {
            get { return _chinese_name; }
            set { updateProper(ref _chinese_name, value);}
        }
    
        private string _english_name;
        /// <summary>
        /// 船舶英文名称
        /// </summary>
        public string english_name
        {
            get { return _english_name; }
            set { updateProper(ref _english_name, value);}
        }
    
        private string _scope;
        /// <summary>
        /// 沿海内河
        /// </summary>
        public string scope
        {
            get { return _scope; }
            set { updateProper(ref _scope, value);}
        }
    
        private string _river_system;
        /// <summary>
        /// 运输主水系类型
        /// </summary>
        public string river_system
        {
            get { return _river_system; }
            set { updateProper(ref _river_system, value);}
        }
    
        private string _area;
        /// <summary>
        /// 运输区域
        /// </summary>
        public string area
        {
            get { return _area; }
            set { updateProper(ref _area, value);}
        }
    
        private string _transport_type;
        /// <summary>
        /// 运输类型
        /// </summary>
        public string transport_type
        {
            get { return _transport_type; }
            set { updateProper(ref _transport_type, value);}
        }
    
        private string _has_container;
        /// <summary>
        /// 是否集装箱班轮运输
        /// </summary>
        public string has_container
        {
            get { return _has_container; }
            set { updateProper(ref _has_container, value);}
        }
    
        private string _has_sluice;
        /// <summary>
        /// 本船经营范围是否过闸
        /// </summary>
        public string has_sluice
        {
            get { return _has_sluice; }
            set { updateProper(ref _has_sluice, value);}
        }
    
        private string _used_name;
        /// <summary>
        /// 曾用名
        /// </summary>
        public string used_name
        {
            get { return _used_name; }
            set { updateProper(ref _used_name, value);}
        }
    
        private string _registry;
        /// <summary>
        /// 船籍港
        /// </summary>
        public string registry
        {
            get { return _registry; }
            set { updateProper(ref _registry, value);}
        }
    
        private string _first_registration_no;
        /// <summary>
        /// 船舶初始登记号
        /// </summary>
        public string first_registration_no
        {
            get { return _first_registration_no; }
            set { updateProper(ref _first_registration_no, value);}
        }
    
        private string _registration_no;
        /// <summary>
        /// 船舶登记号
        /// </summary>
        public string registration_no
        {
            get { return _registration_no; }
            set { updateProper(ref _registration_no, value);}
        }
    
        private string _check_registration_no;
        /// <summary>
        /// 船检登记号
        /// </summary>
        public string check_registration_no
        {
            get { return _check_registration_no; }
            set { updateProper(ref _check_registration_no, value);}
        }
    
        private string _check_num;
        /// <summary>
        /// 船舶识别号
        /// </summary>
        public string check_num
        {
            get { return _check_num; }
            set { updateProper(ref _check_num, value);}
        }
    
        private string _approval_no;
        /// <summary>
        /// 运力批文
        /// </summary>
        public string approval_no
        {
            get { return _approval_no; }
            set { updateProper(ref _approval_no, value);}
        }
    
        private string _operator_id;
        /// <summary>
        /// 船舶经营人id
        /// </summary>
        public string operator_id
        {
            get { return _operator_id; }
            set { updateProper(ref _operator_id, value);}
        }
    
        private string _operator_license_no;
        /// <summary>
        /// 经营人许可证号码
        /// </summary>
        public string operator_license_no
        {
            get { return _operator_license_no; }
            set { updateProper(ref _operator_license_no, value);}
        }
    
        private string _owner;
        /// <summary>
        /// 船舶所有人
        /// </summary>
        public string owner
        {
            get { return _owner; }
            set { updateProper(ref _owner, value);}
        }
    
        private string _ratio;
        /// <summary>
        /// 所占船舶股份
        /// </summary>
        public string ratio
        {
            get { return _ratio; }
            set { updateProper(ref _ratio, value);}
        }
    
        private string _manager_id;
        /// <summary>
        /// 船舶管理人id
        /// </summary>
        public string manager_id
        {
            get { return _manager_id; }
            set { updateProper(ref _manager_id, value);}
        }
    
        private string _manager_license_no;
        /// <summary>
        /// 管理人许可证号码
        /// </summary>
        public string manager_license_no
        {
            get { return _manager_license_no; }
            set { updateProper(ref _manager_license_no, value);}
        }
    
        private string _ship_type;
        /// <summary>
        /// 船舶类型
        /// </summary>
        public string ship_type
        {
            get { return _ship_type; }
            set { updateProper(ref _ship_type, value);}
        }
    
        private string _hull_material;
        /// <summary>
        /// 船体材料
        /// </summary>
        public string hull_material
        {
            get { return _hull_material; }
            set { updateProper(ref _hull_material, value);}
        }
    
        private string _total_ton;
        /// <summary>
        /// 船舶总吨
        /// </summary>
        public string total_ton
        {
            get { return _total_ton; }
            set { updateProper(ref _total_ton, value);}
        }
    
        private string _suttle_ton;
        /// <summary>
        /// 净吨位
        /// </summary>
        public string suttle_ton
        {
            get { return _suttle_ton; }
            set { updateProper(ref _suttle_ton, value);}
        }
    
        private DateTime? _build_date;
        /// <summary>
        /// 建成日期
        /// </summary>
        public DateTime? build_date
        {
            get { return _build_date; }
            set { updateProper(ref _build_date, value);}
        }
    
        private DateTime? _remould_date;
        /// <summary>
        /// 改建日期
        /// </summary>
        public DateTime? remould_date
        {
            get { return _remould_date; }
            set { updateProper(ref _remould_date, value);}
        }
    
        private string _mainframe_total_num;
        /// <summary>
        /// 主机台数
        /// </summary>
        public string mainframe_total_num
        {
            get { return _mainframe_total_num; }
            set { updateProper(ref _mainframe_total_num, value);}
        }
    
        private string _mainframe_total_power;
        /// <summary>
        /// 主机功率
        /// </summary>
        public string mainframe_total_power
        {
            get { return _mainframe_total_power; }
            set { updateProper(ref _mainframe_total_power, value);}
        }
    
        private string _reference_capacity;
        /// <summary>
        /// 参考载货量
        /// </summary>
        public string reference_capacity
        {
            get { return _reference_capacity; }
            set { updateProper(ref _reference_capacity, value);}
        }
    
        private string _containe_capacity;
        /// <summary>
        /// 载箱量
        /// </summary>
        public string containe_capacity
        {
            get { return _containe_capacity; }
            set { updateProper(ref _containe_capacity, value);}
        }
    
        private string _vehicle_capacity;
        /// <summary>
        /// 载车量
        /// </summary>
        public string vehicle_capacity
        {
            get { return _vehicle_capacity; }
            set { updateProper(ref _vehicle_capacity, value);}
        }
    
        private string _gas_capacity;
        /// <summary>
        /// 载气量
        /// </summary>
        public string gas_capacity
        {
            get { return _gas_capacity; }
            set { updateProper(ref _gas_capacity, value);}
        }
    
        private string _passenger_capacity;
        /// <summary>
        /// 载客定额
        /// </summary>
        public string passenger_capacity
        {
            get { return _passenger_capacity; }
            set { updateProper(ref _passenger_capacity, value);}
        }
    
        private string _ship_source;
        /// <summary>
        /// 船舶来历
        /// </summary>
        public string ship_source
        {
            get { return _ship_source; }
            set { updateProper(ref _ship_source, value);}
        }
    
        private string _total_length;
        /// <summary>
        /// 总长
        /// </summary>
        public string total_length
        {
            get { return _total_length; }
            set { updateProper(ref _total_length, value);}
        }
    
        private string _ship_length;
        /// <summary>
        /// 船长
        /// </summary>
        public string ship_length
        {
            get { return _ship_length; }
            set { updateProper(ref _ship_length, value);}
        }
    
        private string _molded_width;
        /// <summary>
        /// 船宽
        /// </summary>
        public string molded_width
        {
            get { return _molded_width; }
            set { updateProper(ref _molded_width, value);}
        }
    
        private string _molded_depth;
        /// <summary>
        /// 型深
        /// </summary>
        public string molded_depth
        {
            get { return _molded_depth; }
            set { updateProper(ref _molded_depth, value);}
        }
    
        private string _load_ton;
        /// <summary>
        /// 载重吨
        /// </summary>
        public string load_ton
        {
            get { return _load_ton; }
            set { updateProper(ref _load_ton, value);}
        }
    
        private string _has_riverboat_norm;
        /// <summary>
        /// 是否符合内河尺寸标准
        /// </summary>
        public string has_riverboat_norm
        {
            get { return _has_riverboat_norm; }
            set { updateProper(ref _has_riverboat_norm, value);}
        }
    
        private string _check_scope;
        /// <summary>
        /// 本船核定的经营范围
        /// </summary>
        public string check_scope
        {
            get { return _check_scope; }
            set { updateProper(ref _check_scope, value);}
        }
    
        private string _ship_cet_no;
        /// <summary>
        /// 船舶营运证
        /// </summary>
        public string ship_cet_no
        {
            get { return _ship_cet_no; }
            set { updateProper(ref _ship_cet_no, value);}
        }
    
        private string _status;
        /// <summary>
        /// 船舶状态
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
    
        private string _operator_name;
        /// <summary>
        /// 船舶经营人
        /// </summary>
        public string operator_name
        {
            get { return _operator_name; }
            set { updateProper(ref _operator_name, value);}
        }
    
        private string _manager_name;
        /// <summary>
        /// 船舶管理人
        /// </summary>
        public string manager_name
        {
            get { return _manager_name; }
            set { updateProper(ref _manager_name, value);}
        }
    
        private DateTime? _expire_time;
        /// <summary>
        /// 船舶营运证到期时间
        /// </summary>
        public DateTime? expire_time
        {
            get { return _expire_time; }
            set { updateProper(ref _expire_time, value);}
        }
    }
}
