//-----------------------------------------------------------------------
// <copyright file=" t_s_function_group_rel.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: t_s_function_group_rel.cs
// * history : Created by T4 03/22/2018 16:33:01 
// </copyright>
//-----------------------------------------------------------------------




    /// <summary>
    /// t_s_function_group_rel Entity Model
    /// </summary>    
export class t_s_function_group_rel
{
        /// <summary>
        /// ID
        /// </summary>
    public id:string;
    
        /// <summary>
        /// 权限组ID
        /// </summary>
    public group_id:string;
    
        /// <summary>
        /// 权限ID
        /// </summary>
    public auth_id:string;
    
        /// <summary>
        /// 页面操作权限
        /// </summary>
    public operation:string;
    
        /// <summary>
        /// 数据权限
        /// </summary>
    public datarule:string;
    
        /// <summary>
        /// 创建人
        /// </summary>
    public create_name:string;
    
        /// <summary>
        /// 创建人id
        /// </summary>
    public create_by:string;
    
        /// <summary>
        /// 创建时间
        /// </summary>
    public create_date:Date;
    
        /// <summary>
        /// 修改人
        /// </summary>
    public update_name:string;
    
        /// <summary>
        /// 修改人id
        /// </summary>
    public update_by:string;
    
        /// <summary>
        /// 修改时间
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
}

