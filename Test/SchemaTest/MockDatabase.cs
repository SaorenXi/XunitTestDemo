using System;
using System.Collections.Generic;
using System.Text;

namespace SchemaTest
{
    /// <summary>
    /// 数据库模拟
    /// </summary>
    public class MockDatabase
    {
        /// <summary>
        /// 模拟数据集合
        /// </summary>
        public static List<SchemaDTO> Schema { get; set; } = new List<SchemaDTO>();
    }
}
