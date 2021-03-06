//-----------------------------------------------------------------------
// <copyright file=" jform_employee_cost_claim.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: jform_employee_cost_claim.cs
// * history : Created by T4 03/28/2018 17:16:33 
// </copyright>
//-----------------------------------------------------------------------
using System;
using Common.Object;
using System.ComponentModel.DataAnnotations.Schema;

namespace HydrometeorologyGISPluginLib.Data
{
    /// <summary>
    /// jform_employee_cost_claim Entity Model
    /// </summary>    
    [Table("jform_employee_cost_claim")]
    public class jform_employee_cost_claim : ObservableObject
    {
        private string _id;
        /// <summary>
        /// id
        /// </summary>        
        public string id
        {
            get { return _id; }
            set { updateProper(ref _id, value);}
        }
    
        private string _staff_name;
        /// <summary>
        /// 职工姓名
        /// </summary>
        public string staff_name
        {
            get { return _staff_name; }
            set { updateProper(ref _staff_name, value);}
        }
    
        private string _depart;
        /// <summary>
        /// 部门
        /// </summary>
        public string depart
        {
            get { return _depart; }
            set { updateProper(ref _depart, value);}
        }
    
        private string _staff_no;
        /// <summary>
        /// 员工编号
        /// </summary>
        public string staff_no
        {
            get { return _staff_no; }
            set { updateProper(ref _staff_no, value);}
        }
    
        private string _staff_post;
        /// <summary>
        /// 职位
        /// </summary>
        public string staff_post
        {
            get { return _staff_post; }
            set { updateProper(ref _staff_post, value);}
        }
    
        private string _pay_way;
        /// <summary>
        /// 打款方式
        /// </summary>
        public string pay_way
        {
            get { return _pay_way; }
            set { updateProper(ref _pay_way, value);}
        }
    
        private string _acct_bank;
        /// <summary>
        /// 开户行
        /// </summary>
        public string acct_bank
        {
            get { return _acct_bank; }
            set { updateProper(ref _acct_bank, value);}
        }
    
        private string _card_no;
        /// <summary>
        /// 卡号
        /// </summary>
        public string card_no
        {
            get { return _card_no; }
            set { updateProper(ref _card_no, value);}
        }
    
        private string _tele_no;
        /// <summary>
        /// 联系手机号
        /// </summary>
        public string tele_no
        {
            get { return _tele_no; }
            set { updateProper(ref _tele_no, value);}
        }
    
        private decimal? _cost_all;
        /// <summary>
        /// 费用合计
        /// </summary>
        public decimal? cost_all
        {
            get { return _cost_all; }
            set { updateProper(ref _cost_all, value);}
        }
    
        private string _documents;
        /// <summary>
        /// 单据数量
        /// </summary>
        public string documents
        {
            get { return _documents; }
            set { updateProper(ref _documents, value);}
        }
    
        private string _cost_upper;
        /// <summary>
        /// 费用大写
        /// </summary>
        public string cost_upper
        {
            get { return _cost_upper; }
            set { updateProper(ref _cost_upper, value);}
        }
    
        private decimal? _prepaid_fee;
        /// <summary>
        /// 预支款项
        /// </summary>
        public decimal? prepaid_fee
        {
            get { return _prepaid_fee; }
            set { updateProper(ref _prepaid_fee, value);}
        }
    
        private decimal? _real_fee;
        /// <summary>
        /// 实际支付
        /// </summary>
        public decimal? real_fee
        {
            get { return _real_fee; }
            set { updateProper(ref _real_fee, value);}
        }
    
        private DateTime? _fill_time;
        /// <summary>
        /// 
        /// </summary>
        public DateTime? fill_time
        {
            get { return _fill_time; }
            set { updateProper(ref _fill_time, value);}
        }
    
        private DateTime? _apply_time;
        /// <summary>
        /// 
        /// </summary>
        public DateTime? apply_time
        {
            get { return _apply_time; }
            set { updateProper(ref _apply_time, value);}
        }
    
        private string _apply_by;
        /// <summary>
        /// 申请人
        /// </summary>
        public string apply_by
        {
            get { return _apply_by; }
            set { updateProper(ref _apply_by, value);}
        }
    
        private string _comments;
        /// <summary>
        /// 备注
        /// </summary>
        public string comments
        {
            get { return _comments; }
            set { updateProper(ref _comments, value);}
        }
    
        private string _depart_approve;
        /// <summary>
        /// 部门审批
        /// </summary>
        public string depart_approve
        {
            get { return _depart_approve; }
            set { updateProper(ref _depart_approve, value);}
        }
    
        private string _finance_approve;
        /// <summary>
        /// 财务审批
        /// </summary>
        public string finance_approve
        {
            get { return _finance_approve; }
            set { updateProper(ref _finance_approve, value);}
        }
    
        private string _mgr_approve;
        /// <summary>
        /// 总经理审批
        /// </summary>
        public string mgr_approve
        {
            get { return _mgr_approve; }
            set { updateProper(ref _mgr_approve, value);}
        }
    
        private string _treasurer;
        /// <summary>
        /// 出纳
        /// </summary>
        public string treasurer
        {
            get { return _treasurer; }
            set { updateProper(ref _treasurer, value);}
        }
    }
}
