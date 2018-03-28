//-----------------------------------------------------------------------
// <copyright file=" t_s_timetask.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: t_s_timetask.cs
// * history : Created by T4 03/28/2018 17:16:33 
// </copyright>
//-----------------------------------------------------------------------
using System;
using Common.Object;
using System.ComponentModel.DataAnnotations.Schema;

namespace HydrometeorologyGISPluginLib.Data
{
    /// <summary>
    /// t_s_timetask Entity Model
    /// </summary>    
    [Table("t_s_timetask")]
    public class t_s_timetask : ObservableObject
    {
        private string _ID;
        /// <summary>
        /// id
        /// </summary>        
        public string ID
        {
            get { return _ID; }
            set { updateProper(ref _ID, value);}
        }
    
        private string _CREATE_BY;
        /// <summary>
        /// 创建人
        /// </summary>
        public string CREATE_BY
        {
            get { return _CREATE_BY; }
            set { updateProper(ref _CREATE_BY, value);}
        }
    
        private DateTime? _CREATE_DATE;
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CREATE_DATE
        {
            get { return _CREATE_DATE; }
            set { updateProper(ref _CREATE_DATE, value);}
        }
    
        private string _CREATE_NAME;
        /// <summary>
        /// 创建人名字
        /// </summary>
        public string CREATE_NAME
        {
            get { return _CREATE_NAME; }
            set { updateProper(ref _CREATE_NAME, value);}
        }
    
        private string _CRON_EXPRESSION;
        /// <summary>
        /// cron表达式
        /// </summary>
        public string CRON_EXPRESSION
        {
            get { return _CRON_EXPRESSION; }
            set { updateProper(ref _CRON_EXPRESSION, value);}
        }
    
        private string _IS_EFFECT;
        /// <summary>
        /// 是否生效 0/未生效,1/生效
        /// </summary>
        public string IS_EFFECT
        {
            get { return _IS_EFFECT; }
            set { updateProper(ref _IS_EFFECT, value);}
        }
    
        private string _IS_START;
        /// <summary>
        /// 是否运行0停止,1运行
        /// </summary>
        public string IS_START
        {
            get { return _IS_START; }
            set { updateProper(ref _IS_START, value);}
        }
    
        private string _TASK_DESCRIBE;
        /// <summary>
        /// 任务描述
        /// </summary>
        public string TASK_DESCRIBE
        {
            get { return _TASK_DESCRIBE; }
            set { updateProper(ref _TASK_DESCRIBE, value);}
        }
    
        private string _TASK_ID;
        /// <summary>
        /// 任务ID
        /// </summary>
        public string TASK_ID
        {
            get { return _TASK_ID; }
            set { updateProper(ref _TASK_ID, value);}
        }
    
        private string _CLASS_NAME;
        /// <summary>
        /// 任务类名
        /// </summary>
        public string CLASS_NAME
        {
            get { return _CLASS_NAME; }
            set { updateProper(ref _CLASS_NAME, value);}
        }
    
        private string _RUN_SERVER_IP;
        /// <summary>
        /// 任务运行服务器IP
        /// </summary>
        public string RUN_SERVER_IP
        {
            get { return _RUN_SERVER_IP; }
            set { updateProper(ref _RUN_SERVER_IP, value);}
        }
    
        private string _RUN_SERVER;
        /// <summary>
        /// 远程主机（域名/IP+项目路径）
        /// </summary>
        public string RUN_SERVER
        {
            get { return _RUN_SERVER; }
            set { updateProper(ref _RUN_SERVER, value);}
        }
    
        private string _UPDATE_BY;
        /// <summary>
        /// 修改人
        /// </summary>
        public string UPDATE_BY
        {
            get { return _UPDATE_BY; }
            set { updateProper(ref _UPDATE_BY, value);}
        }
    
        private DateTime? _UPDATE_DATE;
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime? UPDATE_DATE
        {
            get { return _UPDATE_DATE; }
            set { updateProper(ref _UPDATE_DATE, value);}
        }
    
        private string _UPDATE_NAME;
        /// <summary>
        /// 修改人名称
        /// </summary>
        public string UPDATE_NAME
        {
            get { return _UPDATE_NAME; }
            set { updateProper(ref _UPDATE_NAME, value);}
        }
    }
}
