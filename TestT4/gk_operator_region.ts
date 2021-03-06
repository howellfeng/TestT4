//-----------------------------------------------------------------------
// <copyright file=" gk_operator_region.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: gk_operator_region.cs
// * history : Created by T4 03/22/2018 16:33:01 
// </copyright>
//-----------------------------------------------------------------------




    /// <summary>
    /// gk_operator_region Entity Model
    /// </summary>    
export class gk_operator_region
{
        /// <summary>
        /// 主键
        /// </summary>
    public id:string;
    
        /// <summary>
        /// 流程状态
        /// </summary>
    public bpm_status:string;
    
        /// <summary>
        /// 创建人名称
        /// </summary>
    public create_name:string;
    
        /// <summary>
        /// 创建人登录名称
        /// </summary>
    public create_by:string;
    
        /// <summary>
        /// 更新人名称
        /// </summary>
    public update_name:string;
    
        /// <summary>
        /// 更新人登录名称
        /// </summary>
    public update_by:string;
    
        /// <summary>
        /// 所属部门
        /// </summary>
    public sys_org_code:string;
    
        /// <summary>
        /// 所属公司
        /// </summary>
    public sys_company_code:string;
    
        /// <summary>
        /// 创建日期
        /// </summary>
    public create_date:Date;
    
        /// <summary>
        /// 更新日期
        /// </summary>
    public update_date:Date;
    
        /// <summary>
        /// 使用陆域土地面积
        /// </summary>
    public land_area:string;
    
        /// <summary>
        /// 使用陆域土地相关批文及文号
        /// </summary>
    public land_approval_no:string;
    
        /// <summary>
        /// 使用水域面积
        /// </summary>
    public water_area:string;
    
        /// <summary>
        /// 使用水域相关批文及文号
        /// </summary>
    public water_approval_no:string;
    
        /// <summary>
        /// 使用自然岸线长度
        /// </summary>
    public nature_shoreline_length:string;
    
        /// <summary>
        /// 使用自然岸线相关批文及文号
        /// </summary>
    public shoreline_approval_no:string;
    
        /// <summary>
        /// 关联港口经营人ID
        /// </summary>
    public operator_id:string;
    
        /// <summary>
        /// 涉及批文或证书扫描件
        /// </summary>
    public scan_img:string;
}

