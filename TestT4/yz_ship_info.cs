//-----------------------------------------------------------------------
// <copyright file=" yz_ship_info.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: yz_ship_info.cs
// * history : Created by T4 03/23/2018 15:18:04 
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Console4Test
{
    /// <summary>
    /// yz_ship_info Entity Model
    /// </summary>    
    [Table("yz_ship_info")]
    public class yz_ship_info
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
        /// 申请原因
        /// </summary>
        public string apply_reason { get; set; }
    
        /// <summary>
        /// 申请类型
        /// </summary>
        public string apply_type { get; set; }
    
        /// <summary>
        /// 船舶中文名称
        /// </summary>
        public string chinese_name { get; set; }
    
        /// <summary>
        /// 船舶英文名称
        /// </summary>
        public string english_name { get; set; }
    
        /// <summary>
        /// 沿海内河
        /// </summary>
        public string scope { get; set; }
    
        /// <summary>
        /// 运输主水系类型
        /// </summary>
        public string river_system { get; set; }
    
        /// <summary>
        /// 运输区域
        /// </summary>
        public string area { get; set; }
    
        /// <summary>
        /// 运输类型
        /// </summary>
        public string transport_type { get; set; }
    
        /// <summary>
        /// 是否集装箱班轮运输
        /// </summary>
        public string has_container { get; set; }
    
        /// <summary>
        /// 本船经营范围是否过闸
        /// </summary>
        public string has_sluice { get; set; }
    
        /// <summary>
        /// 曾用名
        /// </summary>
        public string used_name { get; set; }
    
        /// <summary>
        /// 船籍港
        /// </summary>
        public string registry { get; set; }
    
        /// <summary>
        /// 船舶初始登记号
        /// </summary>
        public string first_registration_no { get; set; }
    
        /// <summary>
        /// 船舶登记号
        /// </summary>
        public string registration_no { get; set; }
    
        /// <summary>
        /// 船检登记号
        /// </summary>
        public string check_registration_no { get; set; }
    
        /// <summary>
        /// 船舶识别号
        /// </summary>
        public string check_num { get; set; }
    
        /// <summary>
        /// 运力批文
        /// </summary>
        public string approval_no { get; set; }
    
        /// <summary>
        /// 船舶经营人id
        /// </summary>
        public string operator_id { get; set; }
    
        /// <summary>
        /// 经营人许可证号码
        /// </summary>
        public string operator_license_no { get; set; }
    
        /// <summary>
        /// 船舶所有人
        /// </summary>
        public string owner { get; set; }
    
        /// <summary>
        /// 所占船舶股份
        /// </summary>
        public string ratio { get; set; }
    
        /// <summary>
        /// 船舶管理人id
        /// </summary>
        public string manager_id { get; set; }
    
        /// <summary>
        /// 管理人许可证号码
        /// </summary>
        public string manager_license_no { get; set; }
    
        /// <summary>
        /// 船舶类型
        /// </summary>
        public string ship_type { get; set; }
    
        /// <summary>
        /// 船体材料
        /// </summary>
        public string hull_material { get; set; }
    
        /// <summary>
        /// 船舶总吨
        /// </summary>
        public string total_ton { get; set; }
    
        /// <summary>
        /// 净吨位
        /// </summary>
        public string suttle_ton { get; set; }
    
        /// <summary>
        /// 建成日期
        /// </summary>
        public DateTime? build_date { get; set; }
    
        /// <summary>
        /// 改建日期
        /// </summary>
        public DateTime? remould_date { get; set; }
    
        /// <summary>
        /// 主机台数
        /// </summary>
        public string mainframe_total_num { get; set; }
    
        /// <summary>
        /// 主机功率
        /// </summary>
        public string mainframe_total_power { get; set; }
    
        /// <summary>
        /// 参考载货量
        /// </summary>
        public string reference_capacity { get; set; }
    
        /// <summary>
        /// 载箱量
        /// </summary>
        public string containe_capacity { get; set; }
    
        /// <summary>
        /// 载车量
        /// </summary>
        public string vehicle_capacity { get; set; }
    
        /// <summary>
        /// 载气量
        /// </summary>
        public string gas_capacity { get; set; }
    
        /// <summary>
        /// 载客定额
        /// </summary>
        public string passenger_capacity { get; set; }
    
        /// <summary>
        /// 船舶来历
        /// </summary>
        public string ship_source { get; set; }
    
        /// <summary>
        /// 总长
        /// </summary>
        public string total_length { get; set; }
    
        /// <summary>
        /// 船长
        /// </summary>
        public string ship_length { get; set; }
    
        /// <summary>
        /// 船宽
        /// </summary>
        public string molded_width { get; set; }
    
        /// <summary>
        /// 型深
        /// </summary>
        public string molded_depth { get; set; }
    
        /// <summary>
        /// 载重吨
        /// </summary>
        public string load_ton { get; set; }
    
        /// <summary>
        /// 是否符合内河尺寸标准
        /// </summary>
        public string has_riverboat_norm { get; set; }
    
        /// <summary>
        /// 本船核定的经营范围
        /// </summary>
        public string check_scope { get; set; }
    
        /// <summary>
        /// 船舶营运证
        /// </summary>
        public string ship_cet_no { get; set; }
    
        /// <summary>
        /// 船舶状态
        /// </summary>
        public string status { get; set; }
    
        /// <summary>
        /// 最近年审年份
        /// </summary>
        public string check_time { get; set; }
    
        /// <summary>
        /// 船舶经营人
        /// </summary>
        public string operator_name { get; set; }
    
        /// <summary>
        /// 船舶管理人
        /// </summary>
        public string manager_name { get; set; }
    
        /// <summary>
        /// 船舶营运证到期时间
        /// </summary>
        public DateTime? expire_time { get; set; }
    }
}
