using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchemaTest
{
    /// <summary>
    /// 模拟数据接口
    /// </summary>
    public class MockClient
    {
        /// <summary>
        /// 创建
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public bool AddSchema(SchemaDTO dto)
        {
            MockDatabase.Schema.Add(dto);
            return true;
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public SchemaDTO GetSchema(string schemaCode)
        {
            var entity = MockDatabase.Schema?.FirstOrDefault(a => a.SchemaCode == schemaCode);
            return entity;
        }

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public bool UpdateSchema(SchemaDTO dto)
        {
            var entity = MockDatabase.Schema?.FirstOrDefault(a => a.SchemaCode == dto.SchemaCode);
            if (entity != null)
            {
                entity.Name = dto.Name;
                return true;
            }
            return false;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        public bool RemoveSchema(string schemaCode)
        {
            var entity = MockDatabase.Schema?.FirstOrDefault(a => a.SchemaCode == schemaCode);
            if (entity != null)
            {
                MockDatabase.Schema.Remove(entity);
                return true;
            }
            return false;
        }
    }
}
