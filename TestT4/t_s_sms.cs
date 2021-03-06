//-----------------------------------------------------------------------
// <copyright file=" t_s_sms.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: t_s_sms.cs
// * history : Created by T4 03/28/2018 17:16:33 
// </copyright>
//-----------------------------------------------------------------------
using System;
using Common.Object;
using System.ComponentModel.DataAnnotations.Schema;

namespace HydrometeorologyGISPluginLib.Data
{
    /// <summary>
    /// t_s_sms Entity Model
    /// </summary>    
    [Table("t_s_sms")]
    public class t_s_sms : ObservableObject
    {
        private string _id;
        /// <summary>
        /// ID
        /// </summary>        
        public string id
        {
            get { return _id; }
            set { updateProper(ref _id, value);}
        }
    
        private string _create_name;
        /// <summary>
        /// 创建人名称
        /// </summary>
        public string create_name
        {
            get { return _create_name; }
            set { updateProper(ref _create_name, value);}
        }
    
        private string _create_by;
        /// <summary>
        /// 创建人登录名称
        /// </summary>
        public string create_by
        {
            get { return _create_by; }
            set { updateProper(ref _create_by, value);}
        }
    
        private DateTime? _create_date;
        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime? create_date
        {
            get { return _create_date; }
            set { updateProper(ref _create_date, value);}
        }
    
        private string _update_name;
        /// <summary>
        /// 更新人名称
        /// </summary>
        public string update_name
        {
            get { return _update_name; }
            set { updateProper(ref _update_name, value);}
        }
    
        private string _update_by;
        /// <summary>
        /// 更新人登录名称
        /// </summary>
        public string update_by
        {
            get { return _update_by; }
            set { updateProper(ref _update_by, value);}
        }
    
        private DateTime? _update_date;
        /// <summary>
        /// 更新日期
        /// </summary>
        public DateTime? update_date
        {
            get { return _update_date; }
            set { updateProper(ref _update_date, value);}
        }
    
        private string _es_title;
        /// <summary>
        /// 消息标题
        /// </summary>
        public string es_title
        {
            get { return _es_title; }
            set { updateProper(ref _es_title, value);}
        }
    
        private string _es_type;
        /// <summary>
        /// 消息类型
        /// </summary>
        public string es_type
        {
            get { return _es_type; }
            set { updateProper(ref _es_type, value);}
        }
    
        private string _es_sender;
        /// <summary>
        /// 发送人
        /// </summary>
        public string es_sender
        {
            get { return _es_sender; }
            set { updateProper(ref _es_sender, value);}
        }
    
        private string _es_receiver;
        /// <summary>
        /// 接收人
        /// </summary>
        public string es_receiver
        {
            get { return _es_receiver; }
            set { updateProper(ref _es_receiver, value);}
        }
    
        private string _es_content;
        /// <summary>
        /// 内容
        /// </summary>
        public string es_content
        {
            get { return _es_content; }
            set { updateProper(ref _es_content, value);}
        }
    
        private DateTime? _es_sendtime;
        /// <summary>
        /// 发送时间
        /// </summary>
        public DateTime? es_sendtime
        {
            get { return _es_sendtime; }
            set { updateProper(ref _es_sendtime, value);}
        }
    
        private string _remark;
        /// <summary>
        /// 备注
        /// </summary>
        public string remark
        {
            get { return _remark; }
            set { updateProper(ref _remark, value);}
        }
    
        private string _es_status;
        /// <summary>
        /// 发送状态
        /// </summary>
        public string es_status
        {
            get { return _es_status; }
            set { updateProper(ref _es_status, value);}
        }
    }
}
