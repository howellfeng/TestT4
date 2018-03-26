//-----------------------------------------------------------------------
// <copyright file=" item.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: item.cs
// * history : Created by T4 03/26/2018 22:24:20 
// </copyright>
//-----------------------------------------------------------------------
using System;
using Common.Object;
using System.ComponentModel.DataAnnotations.Schema;

namespace HydrometeorologyGISPluginLib.Data
{
    /// <summary>
    /// item Entity Model
    /// </summary>    
    [Table("item")]
    public class item : ObservableObject
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
    
        private DateTime? _create_date;
        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime? create_date
        {
            get { return _create_date; }
            set { updateProper(ref _create_date, value);}
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
    
        private string _item_code;
        /// <summary>
        /// 事项编码
        /// </summary>
        public string item_code
        {
            get { return _item_code; }
            set { updateProper(ref _item_code, value);}
        }
    }
}
