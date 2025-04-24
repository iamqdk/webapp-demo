using WebappDemo.Common;

namespace WebappDemo.Test
{
    public class HelperTest
    {
        [TestCase(1, 2, 3)]
        [TestCase(5, 1, 6)]
        public void Test_MathHelper_Sum(int x, int y, int result)
        {
            Assert.That(MathHelper.Sum(x, y), Is.EqualTo(result));

        }
    }
}