//-----------------------------------------------------------------------
// <copyright file=" shipmodel.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: shipmodel.cs
// * history : Created by T4 03/23/2018 15:18:04 
// </copyright>
//-----------------------------------------------------------------------
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Console4Test
{
    /// <summary>
    /// shipmodel Entity Model
    /// </summary>    
    [Table("shipmodel")]
    public class shipmodel
    {
        /// <summary>
        /// 
        /// </summary>
        public int? Id { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public float? Length { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public DateTime? BuildTime { get; set; }
    }
}
