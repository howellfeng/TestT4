//-----------------------------------------------------------------------
// <copyright file=" gk_operator_store.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: gk_operator_store.cs
// * history : Created by T4 03/22/2018 16:33:01 
// </copyright>
//-----------------------------------------------------------------------




    /// <summary>
    /// gk_operator_store Entity Model
    /// </summary>    
export class gk_operator_store
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
        /// 所在港区名称
        /// </summary>
    public harbour_name:string;
    
        /// <summary>
        /// 仓库名称
        /// </summary>
    public store_name:string;
    
        /// <summary>
        /// 生产类型
        /// </summary>
    public production_type:string;
    
        /// <summary>
        /// 主要用途
        /// </summary>
    public main_use:string;
    
        /// <summary>
        /// 仓库总面积
        /// </summary>
    public store_total_area:string;
    
        /// <summary>
        /// 生产用仓库面积
        /// </summary>
    public production_area:string;
    
        /// <summary>
        /// 危险品仓库面积
        /// </summary>
    public danger_area:string;
    
        /// <summary>
        /// 生产用仓库容积
        /// </summary>
    public production_volume:string;
    
        /// <summary>
        /// 油库容积
        /// </summary>
    public oil_volume:string;
    
        /// <summary>
        /// 成品油容积
        /// </summary>
    public finished_volume:string;
    
        /// <summary>
        /// 圆筒仓容积
        /// </summary>
    public tower_volume:string;
    
        /// <summary>
        /// 粮食筒仓容积
        /// </summary>
    public cereals_volume:string;
    
        /// <summary>
        /// 水泥筒仓容积
        /// </summary>
    public cement_volume:string;
    
        /// <summary>
        /// 液体化工储罐容积
        /// </summary>
    public liquid_volume:string;
    
        /// <summary>
        /// 其他生产用仓库容积
        /// </summary>
    public other_liquid:string;
    
        /// <summary>
        /// 关联id
        /// </summary>
    public operator_id:string;
}

