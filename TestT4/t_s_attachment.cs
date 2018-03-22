//-----------------------------------------------------------------------
// <copyright file=" t_s_attachment.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: t_s_attachment.cs
// * history : Created by T4 03/22/2018 16:26:40 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace Console4Test
{
    /// <summary>
    /// t_s_attachment Entity Model
    /// </summary>    
    [Serializable]
    public class t_s_attachment
    {
        /// <summary>
        /// ID
        /// </summary>
        public string ID { get; set; }
    
        /// <summary>
        /// 附件内容
        /// </summary>
        public longblob attachmentcontent { get; set; }
    
        /// <summary>
        /// 附件名称
        /// </summary>
        public string attachmenttitle { get; set; }
    
        /// <summary>
        /// 业务类主键
        /// </summary>
        public string businesskey { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime createdate { get; set; }
    
        /// <summary>
        /// 扩展名
        /// </summary>
        public string extend { get; set; }
    
        /// <summary>
        /// note
        /// </summary>
        public string note { get; set; }
    
        /// <summary>
        /// 附件路径
        /// </summary>
        public string realpath { get; set; }
    
        /// <summary>
        /// 子类名称全路径
        /// </summary>
        public string subclassname { get; set; }
    
        /// <summary>
        /// swf格式路径
        /// </summary>
        public string swfpath { get; set; }
    
        /// <summary>
        /// BUSENTITYNAME
        /// </summary>
        public string BUSENTITYNAME { get; set; }
    
        /// <summary>
        /// INFOTYPEID
        /// </summary>
        public string INFOTYPEID { get; set; }
    
        /// <summary>
        /// 用户ID
        /// </summary>
        public string USERID { get; set; }
    }
}
