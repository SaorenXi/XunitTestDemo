﻿using System;

namespace XUnitTest.Orders
{
    /// <summary>
    /// 测试方法的执行顺序
    /// </summary>
    [AttributeUsage(AttributeTargets.Method)]
    public class OrderAttribute : Attribute
    {
        /// <summary>
        /// 顺序
        /// </summary>
        public int Sort { get; set; }
        public OrderAttribute(int sort)
        {
            this.Sort = sort;
        }
    }
}
