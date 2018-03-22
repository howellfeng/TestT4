//-----------------------------------------------------------------------
// <copyright file=" t_s_base_user.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: t_s_base_user.cs
// * history : Created by T4 03/22/2018 16:33:01 
// </copyright>
//-----------------------------------------------------------------------




    /// <summary>
    /// t_s_base_user Entity Model
    /// </summary>    
export class t_s_base_user
{
        /// <summary>
        /// ID
        /// </summary>
    public ID:string;
    
        /// <summary>
        /// 同步流程
        /// </summary>
    public activitiSync:number;
    
        /// <summary>
        /// 浏览器
        /// </summary>
    public browser:string;
    
        /// <summary>
        /// 密码
        /// </summary>
    public password:string;
    
        /// <summary>
        /// 真实名字
        /// </summary>
    public realname:string;
    
        /// <summary>
        /// 签名
        /// </summary>
    public signature:byte[];
    
        /// <summary>
        /// 有效状态
        /// </summary>
    public status:number;
    
        /// <summary>
        /// 用户KEY
        /// </summary>
    public userkey:string;
    
        /// <summary>
        /// 用户账号
        /// </summary>
    public username:string;
    
        /// <summary>
        /// 部门ID
        /// </summary>
    public departid:string;
    
        /// <summary>
        /// 删除状态
        /// </summary>
    public delete_flag:number;
}

