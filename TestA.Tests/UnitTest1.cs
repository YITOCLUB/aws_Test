using Common;

namespace sample165.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string result = Utils.GetRequestId("");
            Assert.True(!string.IsNullOrEmpty(result), "NG");
        }
        [Fact]
        public void Test2()
        {
            string result = Utils.GetRequestId("");
            Assert.NotNull(result);
        }
        [Fact]
        public void Test3()
        {
            string result = Utils.GetRequestId("");
            Assert.IsType<string>(result);
        }

    }
}