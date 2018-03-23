//-----------------------------------------------------------------------
// <copyright file=" yz_operator_info.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: yz_operator_info.cs
// * history : Created by T4 03/23/2018 16:39:14 
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChongQingNetCheckWebService.Models
{
    /// <summary>
    /// yz_operator_info Entity Model
    /// </summary>    
    [Table("yz_operator_info")]
    public class yz_operator_info
    {
        /// <summary>
        /// 主键
        /// </summary>
        public string id { get; set; }
    
        /// <summary>
        /// 创建人名称
        /// </summary>
        public string create_name { get; set; }
    
        /// <summary>
        /// 创建人登录名称
        /// </summary>
        public string create_by { get; set; }
    
        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime? create_date { get; set; }
    
        /// <summary>
        /// 更新人名称
        /// </summary>
        public string update_name { get; set; }
    
        /// <summary>
        /// 更新人登录名称
        /// </summary>
        public string update_by { get; set; }
    
        /// <summary>
        /// 更新日期
        /// </summary>
        public DateTime? update_date { get; set; }
    
        /// <summary>
        /// 所属部门
        /// </summary>
        public string sys_org_code { get; set; }
    
        /// <summary>
        /// 所属公司
        /// </summary>
        public string sys_company_code { get; set; }
    
        /// <summary>
        /// 流程状态
        /// </summary>
        public string bpm_status { get; set; }
    
        /// <summary>
        /// 经营者中文名称
        /// </summary>
        public string chinese_name { get; set; }
    
        /// <summary>
        /// 行政区划
        /// </summary>
        public string district_code { get; set; }
    
        /// <summary>
        /// 注册地址
        /// </summary>
        public string registered_address { get; set; }
    
        /// <summary>
        /// 法定代表人
        /// </summary>
        public string legal_person { get; set; }
    
        /// <summary>
        /// 身份证号
        /// </summary>
        public string legal_card_no { get; set; }
    
        /// <summary>
        /// 经济类型
        /// </summary>
        public string economic_type { get; set; }
    
        /// <summary>
        /// 经营者法人营业执照号
        /// </summary>
        public string business_certificate_no { get; set; }
    
        /// <summary>
        /// 资金币种
        /// </summary>
        public string currency_kind { get; set; }
    
        /// <summary>
        /// 注册资本
        /// </summary>
        public string registered_capital { get; set; }
    
        /// <summary>
        /// 联系电话
        /// </summary>
        public string phone { get; set; }
    
        /// <summary>
        /// 传真
        /// </summary>
        public string fax { get; set; }
    
        /// <summary>
        /// 高级船员数量
        /// </summary>
        public string sailor_count { get; set; }
    
        /// <summary>
        /// 签订劳务合同的高级船员数量 
        /// </summary>
        public string pact_count { get; set; }
    
        /// <summary>
        /// 签订劳务合同高级船员占比
        /// </summary>
        public string percentage { get; set; }
    
        /// <summary>
        /// 申请客运经营范围
        /// </summary>
        public string passenger_area { get; set; }
    
        /// <summary>
        /// 申请货运经营范围 
        /// </summary>
        public string transport_area { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        public string remark { get; set; }
    
        /// <summary>
        /// 省际运输类型
        /// </summary>
        public string sj_tr_type { get; set; }
    
        /// <summary>
        /// 运输主水系类型
        /// </summary>
        public string water_type { get; set; }
    
        /// <summary>
        /// 经营者类型
        /// </summary>
        public string operator_type { get; set; }
    
        /// <summary>
        /// 区县运输类型
        /// </summary>
        public string qx_tr_type { get; set; }
    
        /// <summary>
        /// 是否集装箱班轮内支线
        /// </summary>
        public string container_liner { get; set; }
    
        /// <summary>
        /// 是否个体
        /// </summary>
        public string is_unit { get; set; }
    
        /// <summary>
        /// 开业方式
        /// </summary>
        public string open_type { get; set; }
    
        /// <summary>
        /// 沿海内河
        /// </summary>
        public string coastal_island { get; set; }
    
        /// <summary>
        /// 申请原因
        /// </summary>
        public string apply_reason { get; set; }
    
        /// <summary>
        /// 市内运输类型
        /// </summary>
        public string sn_tr_type { get; set; }
    
        /// <summary>
        /// 许可证编号
        /// </summary>
        public string certificate { get; set; }
    
        /// <summary>
        /// 企业状态
        /// </summary>
        public string status { get; set; }
    
        /// <summary>
        /// 最近年审年份
        /// </summary>
        public string check_time { get; set; }
    
        /// <summary>
        /// 经营许可证到期时间
        /// </summary>
        public DateTime? expire_time { get; set; }
    }
}
