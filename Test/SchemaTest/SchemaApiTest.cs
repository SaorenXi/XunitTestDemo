using Xunit;
using XUnitTest.Orders;

namespace SchemaTest
{
    [TestCaseOrderer("SchemaTest.TestOrders", "SchemaTest")]
    public class SchemaApiTest
    {
        private string _testSchemaCode = $"xunittest123";
        private static SchemaDTO _schemaDto = null;

        /// <summary>
        /// 创建记录
        /// </summary>
        [Fact, Order(1)]
        public void AddSchema()
        {
            var response = new MockClient().AddSchema(new SchemaDTO
            {
                SchemaCode = _testSchemaCode,
                Name = "哈哈"
            });
            Assert.True(response);
        }

        /// <summary>
        /// 查询刚刚创建的记录
        /// </summary>
        [Fact, Order(2)]
        public void GetSchema()
        {
            var response = new MockClient().GetSchema(_testSchemaCode);
            //临时记录
            _schemaDto = response;
            Assert.NotNull(response);
            Assert.Equal(_testSchemaCode, response.SchemaCode);
            Assert.Equal("哈哈", response.Name);
        }

        /// <summary>
        /// 更新刚刚创建的数据记录
        /// </summary>
        [Fact, Order(3)]
        public void UpdateSchema()
        {
            _schemaDto.Name = "jiujiu";
            var response = new MockClient().UpdateSchema(_schemaDto);
            Assert.True(response);
        }

        /// <summary>
        /// 查询更新后的记录
        /// </summary>
        [Fact, Order(4)]
        public void GetAfterUpdatedSchema()
        {
            var response = new MockClient().GetSchema(_testSchemaCode);
            Assert.NotNull(response);
            Assert.Equal(_testSchemaCode, response.SchemaCode);
            Assert.Equal("jiujiu", response.Name);
        }

        /// <summary>
        /// 删除记录
        /// </summary>
        [Fact, Order(5)]
        public void RemoveSchema()
        {
            var response = new MockClient().RemoveSchema(_testSchemaCode);
            Assert.True(response);
        }
    }
}
