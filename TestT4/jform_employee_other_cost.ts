//-----------------------------------------------------------------------
// <copyright file=" jform_employee_other_cost.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: jform_employee_other_cost.cs
// * history : Created by T4 03/22/2018 16:33:01 
// </copyright>
//-----------------------------------------------------------------------




    /// <summary>
    /// jform_employee_other_cost Entity Model
    /// </summary>    
export class jform_employee_other_cost
{
        /// <summary>
        /// id
        /// </summary>
    public id:string;
    
        /// <summary>
        /// 外键
        /// </summary>
    public fk_id:string;
    
        /// <summary>
        /// 事项
        /// </summary>
    public item:string;
    
        /// <summary>
        /// 费用
        /// </summary>
    public cost:number;
    
        /// <summary>
        /// 开始时间
        /// </summary>
    public begin_time:Date;
    
        /// <summary>
        /// 结束时间
        /// </summary>
    public end_time:Date;
    
        /// <summary>
        /// 备注
        /// </summary>
    public comments:string;
}

