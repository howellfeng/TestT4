//-----------------------------------------------------------------------
// <copyright file=" yz_enterprise_yearcheck.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: yz_enterprise_yearcheck.cs
// * history : Created by T4 03/23/2018 16:39:14 
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChongQingNetCheckWebService.Models
{
    /// <summary>
    /// yz_enterprise_yearcheck Entity Model
    /// </summary>    
    [Table("yz_enterprise_yearcheck")]
    public class yz_enterprise_yearcheck
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
        /// 企业中文名称
        /// </summary>
        public string chinese_name { get; set; }
    
        /// <summary>
        /// 法定代表人
        /// </summary>
        public string legal_person { get; set; }
    
        /// <summary>
        /// 经济类型
        /// </summary>
        public string economic_type { get; set; }
    
        /// <summary>
        /// 注册资本
        /// </summary>
        public string register_money { get; set; }
    
        /// <summary>
        /// 注册地址
        /// </summary>
        public string register_address { get; set; }
    
        /// <summary>
        /// 联系电话
        /// </summary>
        public string phone { get; set; }
    
        /// <summary>
        /// 经营地址
        /// </summary>
        public string operator_address { get; set; }
    
        /// <summary>
        /// 传真
        /// </summary>
        public string fax { get; set; }
    
        /// <summary>
        /// 许可证发证机关
        /// </summary>
        public string certificate_organ { get; set; }
    
        /// <summary>
        /// 许可证编号
        /// </summary>
        public string certificate_number { get; set; }
    
        /// <summary>
        /// 经营范围
        /// </summary>
        public string business_area { get; set; }
    
        /// <summary>
        /// 年审年份
        /// </summary>
        public string check_year { get; set; }
    
        /// <summary>
        /// 申请日期
        /// </summary>
        public DateTime? apply_date { get; set; }
    
        /// <summary>
        /// 期末总资产
        /// </summary>
        public string terminal_total { get; set; }
    
        /// <summary>
        /// 期末净资产
        /// </summary>
        public string terminal_clean { get; set; }
    
        /// <summary>
        /// 运输或营业收入
        /// </summary>
        public string tran_income { get; set; }
    
        /// <summary>
        /// 运输或营业成本
        /// </summary>
        public string tran_cost { get; set; }
    
        /// <summary>
        /// 船用柴油消耗量
        /// </summary>
        public string diesel_use { get; set; }
    
        /// <summary>
        /// 船用燃料油消耗量
        /// </summary>
        public string fuel_use { get; set; }
    
        /// <summary>
        /// 货运量
        /// </summary>
        public string freight_number { get; set; }
    
        /// <summary>
        /// 客运量
        /// </summary>
        public string passenger_number { get; set; }
    
        /// <summary>
        /// 货运周转量
        /// </summary>
        public string freight_turnover { get; set; }
    
        /// <summary>
        /// 客运周转量
        /// </summary>
        public string passenger_turnover { get; set; }
    
        /// <summary>
        /// 客运代理量
        /// </summary>
        public string passenger_proxy { get; set; }
    
        /// <summary>
        /// 船舶代理量
        /// </summary>
        public string ship_proxy { get; set; }
    
        /// <summary>
        /// 货物代理量
        /// </summary>
        public string goods_proxy { get; set; }
    
        /// <summary>
        /// 船舶管理量
        /// </summary>
        public string ship_manage { get; set; }
    
        /// <summary>
        /// 安全管理体系情况
        /// </summary>
        public string safe_system { get; set; }
    
        /// <summary>
        /// 符合证明DOC编号
        /// </summary>
        public string doc_number { get; set; }
    
        /// <summary>
        /// 上年度生产经营情况分析
        /// </summary>
        public string produce_analysis { get; set; }
    
        /// <summary>
        /// 上年度安全生产情况及措施
        /// </summary>
        public string measure_analysis { get; set; }
    
        /// <summary>
        /// 存在的困难和问题
        /// </summary>
        public string question_exist { get; set; }
    
        /// <summary>
        /// 建议和意见
        /// </summary>
        public string suggestion { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        public string remark { get; set; }
    
        /// <summary>
        /// 状态
        /// </summary>
        public string status { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public string enterprise_id { get; set; }
    }
}
