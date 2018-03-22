//-----------------------------------------------------------------------
// <copyright file=" jp_demo_order_product.cs" company="xxxx Enterprises">
// * Copyright (C) 2018 xxxx Enterprises All Rights Reserved
// * version : 4.0.30319.42000
// * author  : auto generated by T4
// * FileName: jp_demo_order_product.cs
// * history : Created by T4 03/22/2018 16:33:01 
// </copyright>
//-----------------------------------------------------------------------




    /// <summary>
    /// jp_demo_order_product Entity Model
    /// </summary>    
export class jp_demo_order_product
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
        /// 团购订单号
        /// </summary>
    public GO_ORDER_CODE:string;
    
        /// <summary>
        /// 备注
        /// </summary>
    public GOP_CONTENT:string;
    
        /// <summary>
        /// 个数
        /// </summary>
    public GOP_COUNT:number;
    
        /// <summary>
        /// 单价
        /// </summary>
    public GOP_ONE_PRICE:number;
    
        /// <summary>
        /// 产品名称
        /// </summary>
    public GOP_PRODUCT_NAME:string;
    
        /// <summary>
        /// 服务项目类型
        /// </summary>
    public GOP_PRODUCT_TYPE:string;
    
        /// <summary>
        /// 小计
        /// </summary>
    public GOP_SUM_PRICE:number;
    
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
}

