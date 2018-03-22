//-----------------------------------------------------------------------
// <copyright file=" jp_demo_order_main.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: jp_demo_order_main.cs
// * history : Created by T4 03/22/2018 16:33:01 
// </copyright>
//-----------------------------------------------------------------------




    /// <summary>
    /// jp_demo_order_main Entity Model
    /// </summary>    
export class jp_demo_order_main
{
        /// <summary>
        /// 
        /// </summary>
    public ID:string;
    
        /// <summary>
        /// 
        /// </summary>
    public CREATE_DT:Date;
    
        /// <summary>
        /// 
        /// </summary>
    public CRTUSER:string;
    
        /// <summary>
        /// 
        /// </summary>
    public CRTUSER_NAME:string;
    
        /// <summary>
        /// 
        /// </summary>
    public DEL_DT:Date;
    
        /// <summary>
        /// 
        /// </summary>
    public DELFLAG:number;
    
        /// <summary>
        /// 总价(不含返款)
        /// </summary>
    public GO_ALL_PRICE:number;
    
        /// <summary>
        /// 联系人
        /// </summary>
    public GO_CONTACT_NAME:string;
    
        /// <summary>
        /// 备注
        /// </summary>
    public GO_CONTENT:string;
    
        /// <summary>
        /// 订单号
        /// </summary>
    public GO_ORDER_CODE:string;
    
        /// <summary>
        /// 订单人数
        /// </summary>
    public GO_ORDER_COUNT:number;
    
        /// <summary>
        /// 返款
        /// </summary>
    public GO_RETURN_PRICE:number;
    
        /// <summary>
        /// 手机
        /// </summary>
    public GO_TELPHONE:string;
    
        /// <summary>
        /// 订单类型
        /// </summary>
    public GODER_TYPE:string;
    
        /// <summary>
        /// 
        /// </summary>
    public MODIFIER:string;
    
        /// <summary>
        /// 
        /// </summary>
    public MODIFIER_NAME:string;
    
        /// <summary>
        /// 
        /// </summary>
    public MODIFY_DT:Date;
    
        /// <summary>
        /// 顾客类型 : 1直客 2同行
        /// </summary>
    public USERTYPE:string;
}

