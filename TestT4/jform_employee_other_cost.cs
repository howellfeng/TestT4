//-----------------------------------------------------------------------
// <copyright file=" jform_employee_other_cost.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: jform_employee_other_cost.cs
// * history : Created by T4 03/22/2018 16:26:40 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace Console4Test
{
    /// <summary>
    /// jform_employee_other_cost Entity Model
    /// </summary>    
    [Serializable]
    public class jform_employee_other_cost
    {
        /// <summary>
        /// id
        /// </summary>
        public string id { get; set; }
    
        /// <summary>
        /// 外键
        /// </summary>
        public string fk_id { get; set; }
    
        /// <summary>
        /// 事项
        /// </summary>
        public string item { get; set; }
    
        /// <summary>
        /// 费用
        /// </summary>
        public decimal cost { get; set; }
    
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime begin_time { get; set; }
    
        /// <summary>
        /// 结束时间
        /// </summary>
        public DateTime end_time { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        public string comments { get; set; }
    }
}
