//-----------------------------------------------------------------------
// <copyright file=" task_form.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: task_form.cs
// * history : Created by T4 03/26/2018 22:24:20 
// </copyright>
//-----------------------------------------------------------------------
using System;
using Common.Object;
using System.ComponentModel.DataAnnotations.Schema;

namespace HydrometeorologyGISPluginLib.Data
{
    /// <summary>
    /// task_form Entity Model
    /// </summary>    
    [Table("task_form")]
    public class task_form : ObservableObject
    {
        private string _id;
        /// <summary>
        /// 主键
        /// </summary>        
        public string id
        {
            get { return _id; }
            set { updateProper(ref _id, value);}
        }
    
        private string _data_id;
        /// <summary>
        /// 表单dataId
        /// </summary>
        public string data_id
        {
            get { return _data_id; }
            set { updateProper(ref _data_id, value);}
        }
    
        private string _form_id;
        /// <summary>
        /// 表单id
        /// </summary>
        public string form_id
        {
            get { return _form_id; }
            set { updateProper(ref _form_id, value);}
        }
    
        private string _object_code;
        /// <summary>
        /// objectCode
        /// </summary>
        public string object_code
        {
            get { return _object_code; }
            set { updateProper(ref _object_code, value);}
        }
    
        private string _object_type;
        /// <summary>
        /// objectType
        /// </summary>
        public string object_type
        {
            get { return _object_type; }
            set { updateProper(ref _object_type, value);}
        }
    
        private string _business_object_code;
        /// <summary>
        /// object_code
        /// </summary>
        public string business_object_code
        {
            get { return _business_object_code; }
            set { updateProper(ref _business_object_code, value);}
        }
    
        private string _subject;
        /// <summary>
        /// subject
        /// </summary>
        public string subject
        {
            get { return _subject; }
            set { updateProper(ref _subject, value);}
        }
    
        private string _user_code;
        /// <summary>
        /// 用户Code
        /// </summary>
        public string user_code
        {
            get { return _user_code; }
            set { updateProper(ref _user_code, value);}
        }
    
        private string _apply_ucid;
        /// <summary>
        /// apply_ucid
        /// </summary>
        public string apply_ucid
        {
            get { return _apply_ucid; }
            set { updateProper(ref _apply_ucid, value);}
        }
    
        private string _receive_number;
        /// <summary>
        /// 申请编号
        /// </summary>
        public string receive_number
        {
            get { return _receive_number; }
            set { updateProper(ref _receive_number, value);}
        }
    
        private string _user_name;
        /// <summary>
        /// 用户名
        /// </summary>
        public string user_name
        {
            get { return _user_name; }
            set { updateProper(ref _user_name, value);}
        }
    
        private DateTime? _over_time;
        /// <summary>
        /// 办结时间
        /// </summary>
        public DateTime? over_time
        {
            get { return _over_time; }
            set { updateProper(ref _over_time, value);}
        }
    
        private string _apply_account;
        /// <summary>
        /// 申请人
        /// </summary>
        public string apply_account
        {
            get { return _apply_account; }
            set { updateProper(ref _apply_account, value);}
        }
    
        private string _business_object_type;
        /// <summary>
        /// object_type
        /// </summary>
        public string business_object_type
        {
            get { return _business_object_type; }
            set { updateProper(ref _business_object_type, value);}
        }
    
        private string _item_name;
        /// <summary>
        /// 事项名称
        /// </summary>
        public string item_name
        {
            get { return _item_name; }
            set { updateProper(ref _item_name, value);}
        }
    
        private string _item_id;
        /// <summary>
        /// 事项ID
        /// </summary>
        public string item_id
        {
            get { return _item_id; }
            set { updateProper(ref _item_id, value);}
        }
    
        private string _apply_from;
        /// <summary>
        /// apply_from
        /// </summary>
        public string apply_from
        {
            get { return _apply_from; }
            set { updateProper(ref _apply_from, value);}
        }
    
        private string _opinion;
        /// <summary>
        /// opinion
        /// </summary>
        public string opinion
        {
            get { return _opinion; }
            set { updateProper(ref _opinion, value);}
        }
    
        private DateTime? _submit_time;
        /// <summary>
        /// 受理时间
        /// </summary>
        public DateTime? submit_time
        {
            get { return _submit_time; }
            set { updateProper(ref _submit_time, value);}
        }
    
        private string _status;
        /// <summary>
        /// 状态
        /// </summary>
        public string status
        {
            get { return _status; }
            set { updateProper(ref _status, value);}
        }
    
        private string _type;
        /// <summary>
        /// 事项类型
        /// </summary>
        public string type
        {
            get { return _type; }
            set { updateProper(ref _type, value);}
        }
    
        private string _license_number;
        /// <summary>
        /// 证照编号
        /// </summary>
        public string license_number
        {
            get { return _license_number; }
            set { updateProper(ref _license_number, value);}
        }
    
        private string _json_str;
        /// <summary>
        /// 详情信息
        /// </summary>
        public string json_str
        {
            get { return _json_str; }
            set { updateProper(ref _json_str, value);}
        }
    
        private string _license_str;
        /// <summary>
        /// 证照信息
        /// </summary>
        public string license_str
        {
            get { return _license_str; }
            set { updateProper(ref _license_str, value);}
        }
    
        private string _json_old_str;
        /// <summary>
        /// 更改前详细信息
        /// </summary>
        public string json_old_str
        {
            get { return _json_old_str; }
            set { updateProper(ref _json_old_str, value);}
        }
    
        private string _license_old_str;
        /// <summary>
        /// 更改前证照信息
        /// </summary>
        public string license_old_str
        {
            get { return _license_old_str; }
            set { updateProper(ref _license_old_str, value);}
        }
    
        private string _primary_id;
        /// <summary>
        /// 更新主表id
        /// </summary>
        public string primary_id
        {
            get { return _primary_id; }
            set { updateProper(ref _primary_id, value);}
        }
    }
}
