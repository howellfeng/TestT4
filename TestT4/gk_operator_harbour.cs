//-----------------------------------------------------------------------
// <copyright file=" gk_operator_harbour.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: gk_operator_harbour.cs
// * history : Created by T4 03/26/2018 22:24:20 
// </copyright>
//-----------------------------------------------------------------------
using System;
using Common.Object;
using System.ComponentModel.DataAnnotations.Schema;

namespace HydrometeorologyGISPluginLib.Data
{
    /// <summary>
    /// gk_operator_harbour Entity Model
    /// </summary>    
    [Table("gk_operator_harbour")]
    public class gk_operator_harbour : ObservableObject
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
    
        private string _port_id;
        /// <summary>
        /// 所属港口
        /// </summary>
        public string port_id
        {
            get { return _port_id; }
            set { updateProper(ref _port_id, value);}
        }
    
        private string _harbour_name;
        /// <summary>
        /// 港区名称
        /// </summary>
        public string harbour_name
        {
            get { return _harbour_name; }
            set { updateProper(ref _harbour_name, value);}
        }
    
        private string _water_type;
        /// <summary>
        /// 港区所在水域类型
        /// </summary>
        public string water_type
        {
            get { return _water_type; }
            set { updateProper(ref _water_type, value);}
        }
    
        private string _harbor_area;
        /// <summary>
        /// 港区面积
        /// </summary>
        public string harbor_area
        {
            get { return _harbor_area; }
            set { updateProper(ref _harbor_area, value);}
        }
    
        private string _land_area;
        /// <summary>
        /// 陆域面积
        /// </summary>
        public string land_area
        {
            get { return _land_area; }
            set { updateProper(ref _land_area, value);}
        }
    
        private string _water_range;
        /// <summary>
        /// 水域范围
        /// </summary>
        public string water_range
        {
            get { return _water_range; }
            set { updateProper(ref _water_range, value);}
        }
    
        private string _water_area;
        /// <summary>
        /// 水域面积
        /// </summary>
        public string water_area
        {
            get { return _water_area; }
            set { updateProper(ref _water_area, value);}
        }
    
        private string _harbor_planned_area;
        /// <summary>
        /// 港区规划面积
        /// </summary>
        public string harbor_planned_area
        {
            get { return _harbor_planned_area; }
            set { updateProper(ref _harbor_planned_area, value);}
        }
    
        private string _land_planned_area;
        /// <summary>
        /// 规划陆域面积
        /// </summary>
        public string land_planned_area
        {
            get { return _land_planned_area; }
            set { updateProper(ref _land_planned_area, value);}
        }
    
        private string _non_industrial_planned_area;
        /// <summary>
        /// 非工业生产用地规划面积
        /// </summary>
        public string non_industrial_planned_area
        {
            get { return _non_industrial_planned_area; }
            set { updateProper(ref _non_industrial_planned_area, value);}
        }
    
        private string _water_planned_area;
        /// <summary>
        /// 规划水域面积
        /// </summary>
        public string water_planned_area
        {
            get { return _water_planned_area; }
            set { updateProper(ref _water_planned_area, value);}
        }
    
        private string _nature_shoreline_length;
        /// <summary>
        /// 港区自然岸线长度
        /// </summary>
        public string nature_shoreline_length
        {
            get { return _nature_shoreline_length; }
            set { updateProper(ref _nature_shoreline_length, value);}
        }
    
        private string _wharf_shoreline_length;
        /// <summary>
        /// 公用码头岸线长度
        /// </summary>
        public string wharf_shoreline_length
        {
            get { return _wharf_shoreline_length; }
            set { updateProper(ref _wharf_shoreline_length, value);}
        }
    
        private string _port_shoreline_length;
        /// <summary>
        /// 港区港口岸线长度
        /// </summary>
        public string port_shoreline_length
        {
            get { return _port_shoreline_length; }
            set { updateProper(ref _port_shoreline_length, value);}
        }
    
        private string _used_port_shoreline_length;
        /// <summary>
        /// 港口设施已使用岸线长度
        /// </summary>
        public string used_port_shoreline_length
        {
            get { return _used_port_shoreline_length; }
            set { updateProper(ref _used_port_shoreline_length, value);}
        }
    
        private string _max_ground_slope;
        /// <summary>
        /// 港区地面坡度最大值
        /// </summary>
        public string max_ground_slope
        {
            get { return _max_ground_slope; }
            set { updateProper(ref _max_ground_slope, value);}
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
    }
}
