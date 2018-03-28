//-----------------------------------------------------------------------
// <copyright file=" jform_price1.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: jform_price1.cs
// * history : Created by T4 03/28/2018 17:16:33 
// </copyright>
//-----------------------------------------------------------------------
using System;
using Common.Object;
using System.ComponentModel.DataAnnotations.Schema;

namespace HydrometeorologyGISPluginLib.Data
{
    /// <summary>
    /// jform_price1 Entity Model
    /// </summary>    
    [Table("jform_price1")]
    public class jform_price1 : ObservableObject
    {
        private string _id;
        /// <summary>
        /// 
        /// </summary>        
        public string id
        {
            get { return _id; }
            set { updateProper(ref _id, value);}
        }
    
        private double? _a;
        /// <summary>
        /// 机构合计
        /// </summary>
        public double? a
        {
            get { return _a; }
            set { updateProper(ref _a, value);}
        }
    
        private double? _b1;
        /// <summary>
        /// 行政小计
        /// </summary>
        public double? b1
        {
            get { return _b1; }
            set { updateProper(ref _b1, value);}
        }
    
        private string _b11;
        /// <summary>
        /// 行政省
        /// </summary>
        public string b11
        {
            get { return _b11; }
            set { updateProper(ref _b11, value);}
        }
    
        private string _b12;
        /// <summary>
        /// 行政市
        /// </summary>
        public string b12
        {
            get { return _b12; }
            set { updateProper(ref _b12, value);}
        }
    
        private string _b13;
        /// <summary>
        /// 行政县
        /// </summary>
        public string b13
        {
            get { return _b13; }
            set { updateProper(ref _b13, value);}
        }
    
        private double? _b2;
        /// <summary>
        /// 事业合计
        /// </summary>
        public double? b2
        {
            get { return _b2; }
            set { updateProper(ref _b2, value);}
        }
    
        private double? _b3;
        /// <summary>
        /// 参公小计
        /// </summary>
        public double? b3
        {
            get { return _b3; }
            set { updateProper(ref _b3, value);}
        }
    
        private string _b31;
        /// <summary>
        /// 参公省
        /// </summary>
        public string b31
        {
            get { return _b31; }
            set { updateProper(ref _b31, value);}
        }
    
        private string _b32;
        /// <summary>
        /// 参公市
        /// </summary>
        public string b32
        {
            get { return _b32; }
            set { updateProper(ref _b32, value);}
        }
    
        private string _b33;
        /// <summary>
        /// 参公县
        /// </summary>
        public string b33
        {
            get { return _b33; }
            set { updateProper(ref _b33, value);}
        }
    
        private double? _c1;
        /// <summary>
        /// 全额拨款
        /// </summary>
        public double? c1
        {
            get { return _c1; }
            set { updateProper(ref _c1, value);}
        }
    
        private double? _c2;
        /// <summary>
        /// 差额拨款
        /// </summary>
        public double? c2
        {
            get { return _c2; }
            set { updateProper(ref _c2, value);}
        }
    
        private double? _c3;
        /// <summary>
        /// 自收自支
        /// </summary>
        public double? c3
        {
            get { return _c3; }
            set { updateProper(ref _c3, value);}
        }
    
        private int? _d;
        /// <summary>
        /// 经费合计
        /// </summary>
        public int? d
        {
            get { return _d; }
            set { updateProper(ref _d, value);}
        }
    
        private string _d1;
        /// <summary>
        /// 机构资质
        /// </summary>
        public string d1
        {
            get { return _d1; }
            set { updateProper(ref _d1, value);}
        }
    }
}
