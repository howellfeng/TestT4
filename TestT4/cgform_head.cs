//-----------------------------------------------------------------------
// <copyright file=" cgform_head.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: cgform_head.cs
// * history : Created by T4 03/22/2018 16:26:40 
// </copyright>
//-----------------------------------------------------------------------
using System;

namespace Console4Test
{
    /// <summary>
    /// cgform_head Entity Model
    /// </summary>    
    [Serializable]
    public class cgform_head
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public string id { get; set; }
    
        /// <summary>
        /// 表描述
        /// </summary>
        public string content { get; set; }
    
        /// <summary>
        /// 创建人
        /// </summary>
        public string create_by { get; set; }
    
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime create_date { get; set; }
    
        /// <summary>
        /// 创建人名称
        /// </summary>
        public string create_name { get; set; }
    
        /// <summary>
        /// 是否带checkbox
        /// </summary>
        public string is_checkbox { get; set; }
    
        /// <summary>
        /// 同步数据库状态
        /// </summary>
        public string is_dbsynch { get; set; }
    
        /// <summary>
        /// 是否分页
        /// </summary>
        public string is_pagination { get; set; }
    
        /// <summary>
        /// 是否是树
        /// </summary>
        public string is_tree { get; set; }
    
        /// <summary>
        /// 主键生成序列
        /// </summary>
        public string jform_pk_sequence { get; set; }
    
        /// <summary>
        /// 主键类型
        /// </summary>
        public string jform_pk_type { get; set; }
    
        /// <summary>
        /// 表类型:单表、主表、附表
        /// </summary>
        public int jform_type { get; set; }
    
        /// <summary>
        /// 表单版本号
        /// </summary>
        public string jform_version { get; set; }
    
        /// <summary>
        /// 查询模式
        /// </summary>
        public string querymode { get; set; }
    
        /// <summary>
        /// 
        /// </summary>
        public int relation_type { get; set; }
    
        /// <summary>
        /// 子表
        /// </summary>
        public string sub_table_str { get; set; }
    
        /// <summary>
        /// 附表排序序号
        /// </summary>
        public int tab_order { get; set; }
    
        /// <summary>
        /// 表名
        /// </summary>
        public string table_name { get; set; }
    
        /// <summary>
        /// 修改人
        /// </summary>
        public string update_by { get; set; }
    
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime update_date { get; set; }
    
        /// <summary>
        /// 修改人名字
        /// </summary>
        public string update_name { get; set; }
    
        /// <summary>
        /// 树形表单父id
        /// </summary>
        public string tree_parentid_fieldname { get; set; }
    
        /// <summary>
        /// 树表主键字段
        /// </summary>
        public string tree_id_fieldname { get; set; }
    
        /// <summary>
        /// 树开表单列字段
        /// </summary>
        public string tree_fieldname { get; set; }
    
        /// <summary>
        /// 表单分类
        /// </summary>
        public string jform_category { get; set; }
    
        /// <summary>
        /// PC表单模板
        /// </summary>
        public string form_template { get; set; }
    
        /// <summary>
        /// 表单模板样式(移动端)
        /// </summary>
        public string form_template_mobile { get; set; }
    
        /// <summary>
        /// '0'为物理表，‘1’为配置表
        /// </summary>
        public string table_type { get; set; }
    
        /// <summary>
        /// 表版本
        /// </summary>
        public int table_version { get; set; }
    
        /// <summary>
        /// 物理表id(配置表用)
        /// </summary>
        public string physice_id { get; set; }
    }
}
