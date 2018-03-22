//-----------------------------------------------------------------------
// <copyright file=" log_http_client.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: log_http_client.cs
// * history : Created by T4 03/22/2018 16:26:40 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace Console4Test
{
    /// <summary>
    /// log_http_client Entity Model
    /// </summary>    
    [Serializable]
    public class log_http_client
    {
        /// <summary>
        /// 
        /// </summary>
        public string id { get; set; }
    
        /// <summary>
        /// 请求地址
        /// </summary>
        public string url { get; set; }
    
        /// <summary>
        /// 请求时间
        /// </summary>
        public DateTime date { get; set; }
    
        /// <summary>
        /// 请求状态
        /// </summary>
        public string http_status { get; set; }
    
        /// <summary>
        /// 数据状态
        /// </summary>
        public string data_status { get; set; }
    
        /// <summary>
        /// 备注
        /// </summary>
        public string note { get; set; }
    }
}