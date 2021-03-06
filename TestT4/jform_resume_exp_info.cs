//-----------------------------------------------------------------------
// <copyright file=" jform_resume_exp_info.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: jform_resume_exp_info.cs
// * history : Created by T4 03/28/2018 17:16:33 
// </copyright>
//-----------------------------------------------------------------------
using System;
using Common.Object;
using System.ComponentModel.DataAnnotations.Schema;

namespace HydrometeorologyGISPluginLib.Data
{
    /// <summary>
    /// jform_resume_exp_info Entity Model
    /// </summary>    
    [Table("jform_resume_exp_info")]
    public class jform_resume_exp_info : ObservableObject
    {
        private string _id;
        /// <summary>
        /// id
        /// </summary>        
        public string id
        {
            get { return _id; }
            set { updateProper(ref _id, value);}
        }
    
        private string _resume_id;
        /// <summary>
        /// 简历信息表ID
        /// </summary>
        public string resume_id
        {
            get { return _resume_id; }
            set { updateProper(ref _resume_id, value);}
        }
    
        private DateTime? _begin_date;
        /// <summary>
        /// 开始日期
        /// </summary>
        public DateTime? begin_date
        {
            get { return _begin_date; }
            set { updateProper(ref _begin_date, value);}
        }
    
        private DateTime? _end_date;
        /// <summary>
        /// 结束日期
        /// </summary>
        public DateTime? end_date
        {
            get { return _end_date; }
            set { updateProper(ref _end_date, value);}
        }
    
        private string _company_name;
        /// <summary>
        /// 公司名称
        /// </summary>
        public string company_name
        {
            get { return _company_name; }
            set { updateProper(ref _company_name, value);}
        }
    
        private string _depart_name;
        /// <summary>
        /// 部门名称
        /// </summary>
        public string depart_name
        {
            get { return _depart_name; }
            set { updateProper(ref _depart_name, value);}
        }
    
        private string _post;
        /// <summary>
        /// 职位
        /// </summary>
        public string post
        {
            get { return _post; }
            set { updateProper(ref _post, value);}
        }
    
        private string _experience;
        /// <summary>
        /// 工作描述
        /// </summary>
        public string experience
        {
            get { return _experience; }
            set { updateProper(ref _experience, value);}
        }
    }
}
