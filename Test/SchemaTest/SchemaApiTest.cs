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
        /// ������¼
        /// </summary>
        [Fact, Order(1)]
        public void AddSchema()
        {
            var response = new MockClient().AddSchema(new SchemaDTO
            {
                SchemaCode = _testSchemaCode,
                Name = "����"
            });
            Assert.True(response);
        }

        /// <summary>
        /// ��ѯ�ոմ����ļ�¼
        /// </summary>
        [Fact, Order(2)]
        public void GetSchema()
        {
            var response = new MockClient().GetSchema(_testSchemaCode);
            //��ʱ��¼
            _schemaDto = response;
            Assert.NotNull(response);
            Assert.Equal(_testSchemaCode, response.SchemaCode);
            Assert.Equal("����", response.Name);
        }

        /// <summary>
        /// ���¸ոմ��������ݼ�¼
        /// </summary>
        [Fact, Order(3)]
        public void UpdateSchema()
        {
            _schemaDto.Name = "jiujiu";
            var response = new MockClient().UpdateSchema(_schemaDto);
            Assert.True(response);
        }

        /// <summary>
        /// ��ѯ���º�ļ�¼
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
        /// ɾ����¼
        /// </summary>
        [Fact, Order(5)]
        public void RemoveSchema()
        {
            var response = new MockClient().RemoveSchema(_testSchemaCode);
            Assert.True(response);
        }
    }
}
