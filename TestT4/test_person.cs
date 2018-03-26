//-----------------------------------------------------------------------
// <copyright file=" test_person.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: test_person.cs
// * history : Created by T4 03/26/2018 22:24:20 
// </copyright>
//-----------------------------------------------------------------------
using System;
using Common.Object;
using System.ComponentModel.DataAnnotations.Schema;

namespace HydrometeorologyGISPluginLib.Data
{
    /// <summary>
    /// test_person Entity Model
    /// </summary>    
    [Table("test_person")]
    public class test_person : ObservableObject
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
        /// 名字
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
    
        private DateTime? _birthday;
        /// <summary>
        /// 生日
        /// </summary>
        public DateTime? birthday
        {
            get { return _birthday; }
            set { updateProper(ref _birthday, value);}
        }
    
        private string _conets;
        /// <summary>
        /// 个人简介
        /// </summary>
        public string conets
        {
            get { return _conets; }
            set { updateProper(ref _conets, value);}
        }
    
        private string _cexs;
        /// <summary>
        /// 测性别
        /// </summary>
        public string cexs
        {
            get { return _cexs; }
            set { updateProper(ref _cexs, value);}
        }
    
        private double? _salary;
        /// <summary>
        /// 工资
        /// </summary>
        public double? salary
        {
            get { return _salary; }
            set { updateProper(ref _salary, value);}
        }
    
        private string _fiel_jls;
        /// <summary>
        /// 简历附件
        /// </summary>
        public string fiel_jls
        {
            get { return _fiel_jls; }
            set { updateProper(ref _fiel_jls, value);}
        }
    
        private string _tou_pic;
        /// <summary>
        /// 个人头像
        /// </summary>
        public string tou_pic
        {
            get { return _tou_pic; }
            set { updateProper(ref _tou_pic, value);}
        }
    }
}
