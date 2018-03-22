//-----------------------------------------------------------------------
// <copyright file=" gk_operator_fairway.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: gk_operator_fairway.cs
// * history : Created by T4 03/22/2018 16:33:01 
// </copyright>
//-----------------------------------------------------------------------




    /// <summary>
    /// gk_operator_fairway Entity Model
    /// </summary>    
export class gk_operator_fairway
{
        /// <summary>
        /// 主键
        /// </summary>
    public id:string;
    
        /// <summary>
        /// 创建人名称
        /// </summary>
    public create_name:string;
    
        /// <summary>
        /// 创建人登录名称
        /// </summary>
    public create_by:string;
    
        /// <summary>
        /// 创建日期
        /// </summary>
    public create_date:Date;
    
        /// <summary>
        /// 更新人名称
        /// </summary>
    public update_name:string;
    
        /// <summary>
        /// 更新人登录名称
        /// </summary>
    public update_by:string;
    
        /// <summary>
        /// 更新日期
        /// </summary>
    public update_date:Date;
    
        /// <summary>
        /// 所属部门
        /// </summary>
    public sys_org_code:string;
    
        /// <summary>
        /// 所属公司
        /// </summary>
    public sys_company_code:string;
    
        /// <summary>
        /// 流程状态
        /// </summary>
    public bpm_status:string;
    
        /// <summary>
        /// 服务的港区名称
        /// </summary>
    public port_id:string;
    
        /// <summary>
        /// 航道名称
        /// </summary>
    public fairway_name:string;
    
        /// <summary>
        /// 航道起点名称
        /// </summary>
    public fairway_start:string;
    
        /// <summary>
        /// 航道讫点名称
        /// </summary>
    public fairway_end:string;
    
        /// <summary>
        /// 航道长度
        /// </summary>
    public fairway_length:string;
    
        /// <summary>
        /// 航道水深最小值
        /// </summary>
    public fairway_min_depth:string;
    
        /// <summary>
        /// 航道水深最大值
        /// </summary>
    public fairway_max_depth:string;
    
        /// <summary>
        /// 航道通过能力
        /// </summary>
    public fairway_ton:string;
    
        /// <summary>
        /// 航道宽度
        /// </summary>
    public fairway_width:string;
    
        /// <summary>
        /// 航道有效宽度
        /// </summary>
    public fairway_effective_width:string;
}
