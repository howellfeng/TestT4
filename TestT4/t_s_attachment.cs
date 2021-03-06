//-----------------------------------------------------------------------
// <copyright file=" t_s_attachment.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: t_s_attachment.cs
// * history : Created by T4 03/28/2018 17:16:33 
// </copyright>
//-----------------------------------------------------------------------
using System;
using Common.Object;
using System.ComponentModel.DataAnnotations.Schema;

namespace HydrometeorologyGISPluginLib.Data
{
    /// <summary>
    /// t_s_attachment Entity Model
    /// </summary>    
    [Table("t_s_attachment")]
    public class t_s_attachment : ObservableObject
    {
        private string _ID;
        /// <summary>
        /// ID
        /// </summary>        
        public string ID
        {
            get { return _ID; }
            set { updateProper(ref _ID, value);}
        }
    
        private longblob _attachmentcontent;
        /// <summary>
        /// 附件内容
        /// </summary>
        public longblob attachmentcontent
        {
            get { return _attachmentcontent; }
            set { updateProper(ref _attachmentcontent, value);}
        }
    
        private string _attachmenttitle;
        /// <summary>
        /// 附件名称
        /// </summary>
        public string attachmenttitle
        {
            get { return _attachmenttitle; }
            set { updateProper(ref _attachmenttitle, value);}
        }
    
        private string _businesskey;
        /// <summary>
        /// 业务类主键
        /// </summary>
        public string businesskey
        {
            get { return _businesskey; }
            set { updateProper(ref _businesskey, value);}
        }
    
        private DateTime? _createdate;
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? createdate
        {
            get { return _createdate; }
            set { updateProper(ref _createdate, value);}
        }
    
        private string _extend;
        /// <summary>
        /// 扩展名
        /// </summary>
        public string extend
        {
            get { return _extend; }
            set { updateProper(ref _extend, value);}
        }
    
        private string _note;
        /// <summary>
        /// note
        /// </summary>
        public string note
        {
            get { return _note; }
            set { updateProper(ref _note, value);}
        }
    
        private string _realpath;
        /// <summary>
        /// 附件路径
        /// </summary>
        public string realpath
        {
            get { return _realpath; }
            set { updateProper(ref _realpath, value);}
        }
    
        private string _subclassname;
        /// <summary>
        /// 子类名称全路径
        /// </summary>
        public string subclassname
        {
            get { return _subclassname; }
            set { updateProper(ref _subclassname, value);}
        }
    
        private string _swfpath;
        /// <summary>
        /// swf格式路径
        /// </summary>
        public string swfpath
        {
            get { return _swfpath; }
            set { updateProper(ref _swfpath, value);}
        }
    
        private string _BUSENTITYNAME;
        /// <summary>
        /// BUSENTITYNAME
        /// </summary>
        public string BUSENTITYNAME
        {
            get { return _BUSENTITYNAME; }
            set { updateProper(ref _BUSENTITYNAME, value);}
        }
    
        private string _INFOTYPEID;
        /// <summary>
        /// INFOTYPEID
        /// </summary>
        public string INFOTYPEID
        {
            get { return _INFOTYPEID; }
            set { updateProper(ref _INFOTYPEID, value);}
        }
    
        private string _USERID;
        /// <summary>
        /// 用户ID
        /// </summary>
        public string USERID
        {
            get { return _USERID; }
            set { updateProper(ref _USERID, value);}
        }
    }
}
