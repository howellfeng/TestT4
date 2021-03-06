//-----------------------------------------------------------------------
// <copyright file=" gk_operator_store.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: gk_operator_store.cs
// * history : Created by T4 03/28/2018 17:16:33 
// </copyright>
//-----------------------------------------------------------------------
using System;
using Common.Object;
using System.ComponentModel.DataAnnotations.Schema;

namespace HydrometeorologyGISPluginLib.Data
{
    /// <summary>
    /// gk_operator_store Entity Model
    /// </summary>    
    [Table("gk_operator_store")]
    public class gk_operator_store : ObservableObject
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
    
        private string _sys_org_code;
        /// <summary>
        /// 所属部门
        /// </summary>
        public string sys_org_code
        {
            get { return _sys_org_code; }
            set { updateProper(ref _sys_org_code, value);}
        }
    
        private string _sys_company_code;
        /// <summary>
        /// 所属公司
        /// </summary>
        public string sys_company_code
        {
            get { return _sys_company_code; }
            set { updateProper(ref _sys_company_code, value);}
        }
    
        private string _bpm_status;
        /// <summary>
        /// 流程状态
        /// </summary>
        public string bpm_status
        {
            get { return _bpm_status; }
            set { updateProper(ref _bpm_status, value);}
        }
    
        private string _harbour_name;
        /// <summary>
        /// 所在港区名称
        /// </summary>
        public string harbour_name
        {
            get { return _harbour_name; }
            set { updateProper(ref _harbour_name, value);}
        }
    
        private string _store_name;
        /// <summary>
        /// 仓库名称
        /// </summary>
        public string store_name
        {
            get { return _store_name; }
            set { updateProper(ref _store_name, value);}
        }
    
        private string _production_type;
        /// <summary>
        /// 生产类型
        /// </summary>
        public string production_type
        {
            get { return _production_type; }
            set { updateProper(ref _production_type, value);}
        }
    
        private string _main_use;
        /// <summary>
        /// 主要用途
        /// </summary>
        public string main_use
        {
            get { return _main_use; }
            set { updateProper(ref _main_use, value);}
        }
    
        private string _store_total_area;
        /// <summary>
        /// 仓库总面积
        /// </summary>
        public string store_total_area
        {
            get { return _store_total_area; }
            set { updateProper(ref _store_total_area, value);}
        }
    
        private string _production_area;
        /// <summary>
        /// 生产用仓库面积
        /// </summary>
        public string production_area
        {
            get { return _production_area; }
            set { updateProper(ref _production_area, value);}
        }
    
        private string _danger_area;
        /// <summary>
        /// 危险品仓库面积
        /// </summary>
        public string danger_area
        {
            get { return _danger_area; }
            set { updateProper(ref _danger_area, value);}
        }
    
        private string _production_volume;
        /// <summary>
        /// 生产用仓库容积
        /// </summary>
        public string production_volume
        {
            get { return _production_volume; }
            set { updateProper(ref _production_volume, value);}
        }
    
        private string _oil_volume;
        /// <summary>
        /// 油库容积
        /// </summary>
        public string oil_volume
        {
            get { return _oil_volume; }
            set { updateProper(ref _oil_volume, value);}
        }
    
        private string _finished_volume;
        /// <summary>
        /// 成品油容积
        /// </summary>
        public string finished_volume
        {
            get { return _finished_volume; }
            set { updateProper(ref _finished_volume, value);}
        }
    
        private string _tower_volume;
        /// <summary>
        /// 圆筒仓容积
        /// </summary>
        public string tower_volume
        {
            get { return _tower_volume; }
            set { updateProper(ref _tower_volume, value);}
        }
    
        private string _cereals_volume;
        /// <summary>
        /// 粮食筒仓容积
        /// </summary>
        public string cereals_volume
        {
            get { return _cereals_volume; }
            set { updateProper(ref _cereals_volume, value);}
        }
    
        private string _cement_volume;
        /// <summary>
        /// 水泥筒仓容积
        /// </summary>
        public string cement_volume
        {
            get { return _cement_volume; }
            set { updateProper(ref _cement_volume, value);}
        }
    
        private string _liquid_volume;
        /// <summary>
        /// 液体化工储罐容积
        /// </summary>
        public string liquid_volume
        {
            get { return _liquid_volume; }
            set { updateProper(ref _liquid_volume, value);}
        }
    
        private string _other_liquid;
        /// <summary>
        /// 其他生产用仓库容积
        /// </summary>
        public string other_liquid
        {
            get { return _other_liquid; }
            set { updateProper(ref _other_liquid, value);}
        }
    
        private string _operator_id;
        /// <summary>
        /// 关联id
        /// </summary>
        public string operator_id
        {
            get { return _operator_id; }
            set { updateProper(ref _operator_id, value);}
        }
    }
}
