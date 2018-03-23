//-----------------------------------------------------------------------
// <copyright file=" jform_resume_info.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: jform_resume_info.cs
// * history : Created by T4 03/23/2018 16:39:14 
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChongQingNetCheckWebService.Models
{
    /// <summary>
    /// jform_resume_info Entity Model
    /// </summary>    
    [Table("jform_resume_info")]
    public class jform_resume_info
    {
        /// <summary>
        /// id
        /// </summary>
        public string id { get; set; }
    
        /// <summary>
        /// 姓名
        /// </summary>
        public string name { get; set; }
    
        /// <summary>
        /// 性别
        /// </summary>
        public string sex { get; set; }
    
        /// <summary>
        /// 生日
        /// </summary>
        public DateTime? birthday { get; set; }
    
        /// <summary>
        /// 电话号码
        /// </summary>
        public string telnum { get; set; }
    
        /// <summary>
        /// 电子邮箱
        /// </summary>
        public string email { get; set; }
    
        /// <summary>
        /// 最高学历
        /// </summary>
        public string degree { get; set; }
    
        /// <summary>
        /// 工作年限
        /// </summary>
        public string workyear { get; set; }
    
        /// <summary>
        /// 身份证号
        /// </summary>
        public string cardid { get; set; }
    
        /// <summary>
        /// 现居地
        /// </summary>
        public string habitation { get; set; }
    
        /// <summary>
        /// 户口所在地
        /// </summary>
        public string residence { get; set; }
    
        /// <summary>
        /// 期望薪资
        /// </summary>
        public string salary { get; set; }
    
        /// <summary>
        /// 期望工作地点
        /// </summary>
        public string work_place { get; set; }
    
        /// <summary>
        /// 工作类型
        /// </summary>
        public string work_type { get; set; }
    
        /// <summary>
        /// 到岗时间
        /// </summary>
        public DateTime? arrival_time { get; set; }
    
        /// <summary>
        /// 自我评价
        /// </summary>
        public string introduction { get; set; }
    }
}
