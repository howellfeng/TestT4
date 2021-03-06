//-----------------------------------------------------------------------
// <copyright file=" jform_cgreport_item.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: jform_cgreport_item.cs
// * history : Created by T4 03/28/2018 17:16:33 
// </copyright>
//-----------------------------------------------------------------------
using System;
using Common.Object;
using System.ComponentModel.DataAnnotations.Schema;

namespace HydrometeorologyGISPluginLib.Data
{
    /// <summary>
    /// jform_cgreport_item Entity Model
    /// </summary>    
    [Table("jform_cgreport_item")]
    public class jform_cgreport_item : ObservableObject
    {
        private string _ID;
        /// <summary>
        /// 
        /// </summary>        
        public string ID
        {
            get { return _ID; }
            set { updateProper(ref _ID, value);}
        }
    
        private string _S_FLAG;
        /// <summary>
        /// 是否查询
        /// </summary>
        public string S_FLAG
        {
            get { return _S_FLAG; }
            set { updateProper(ref _S_FLAG, value);}
        }
    
        private string _S_MODE;
        /// <summary>
        /// 查询模式
        /// </summary>
        public string S_MODE
        {
            get { return _S_MODE; }
            set { updateProper(ref _S_MODE, value);}
        }
    
        private string _CGRHEAD_ID;
        /// <summary>
        /// 报表ID
        /// </summary>
        public string CGRHEAD_ID
        {
            get { return _CGRHEAD_ID; }
            set { updateProper(ref _CGRHEAD_ID, value);}
        }
    
        private string _DICT_CODE;
        /// <summary>
        /// 字典CODE
        /// </summary>
        public string DICT_CODE
        {
            get { return _DICT_CODE; }
            set { updateProper(ref _DICT_CODE, value);}
        }
    
        private string _FIELD_HREF;
        /// <summary>
        /// 字段跳转URL
        /// </summary>
        public string FIELD_HREF
        {
            get { return _FIELD_HREF; }
            set { updateProper(ref _FIELD_HREF, value);}
        }
    
        private string _FIELD_NAME;
        /// <summary>
        /// 字段名字
        /// </summary>
        public string FIELD_NAME
        {
            get { return _FIELD_NAME; }
            set { updateProper(ref _FIELD_NAME, value);}
        }
    
        private string _FIELD_TXT;
        /// <summary>
        /// 字段文本
        /// </summary>
        public string FIELD_TXT
        {
            get { return _FIELD_TXT; }
            set { updateProper(ref _FIELD_TXT, value);}
        }
    
        private string _FIELD_TYPE;
        /// <summary>
        /// 字段类型
        /// </summary>
        public string FIELD_TYPE
        {
            get { return _FIELD_TYPE; }
            set { updateProper(ref _FIELD_TYPE, value);}
        }
    
        private string _IS_SHOW;
        /// <summary>
        /// 是否显示
        /// </summary>
        public string IS_SHOW
        {
            get { return _IS_SHOW; }
            set { updateProper(ref _IS_SHOW, value);}
        }
    
        private int? _ORDER_NUM;
        /// <summary>
        /// 排序
        /// </summary>
        public int? ORDER_NUM
        {
            get { return _ORDER_NUM; }
            set { updateProper(ref _ORDER_NUM, value);}
        }
    
        private string _REPLACE_VA;
        /// <summary>
        /// 取值表达式
        /// </summary>
        public string REPLACE_VA
        {
            get { return _REPLACE_VA; }
            set { updateProper(ref _REPLACE_VA, value);}
        }
    }
}
