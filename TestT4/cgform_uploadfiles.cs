//-----------------------------------------------------------------------
// <copyright file=" cgform_uploadfiles.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: cgform_uploadfiles.cs
// * history : Created by T4 03/22/2018 16:26:40 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace Console4Test
{
    /// <summary>
    /// cgform_uploadfiles Entity Model
    /// </summary>    
    [Serializable]
    public class cgform_uploadfiles
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public string id { get; set; }
    
        /// <summary>
        /// 表单字段
        /// </summary>
        public string CGFORM_FIELD { get; set; }
    
        /// <summary>
        /// 表单ID
        /// </summary>
        public string CGFORM_ID { get; set; }
    
        /// <summary>
        /// 表单名称
        /// </summary>
        public string CGFORM_NAME { get; set; }
    }
}
