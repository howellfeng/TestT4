//-----------------------------------------------------------------------
// <copyright file=" gk_shoreline_location.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: gk_shoreline_location.cs
// * history : Created by T4 03/22/2018 16:33:01 
// </copyright>
//-----------------------------------------------------------------------




    /// <summary>
    /// gk_shoreline_location Entity Model
    /// </summary>    
export class gk_shoreline_location
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
        /// 点号
        /// </summary>
    public point_coordinate:string;
    
        /// <summary>
        /// X坐标
        /// </summary>
    public coordinate_xzhou:string;
    
        /// <summary>
        /// Y坐标
        /// </summary>
    public coordinate_yzhou:string;
    
        /// <summary>
        /// 关联id
        /// </summary>
    public operator_id:string;
}

