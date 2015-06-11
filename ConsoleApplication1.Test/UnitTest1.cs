using NUnit.Framework;

namespace ConsoleApplication1.Test
{
    [TestFixture]
    public class TestHelper
    {
        [Test]
        public void SaySomething_Call_ReturnHello()
        {
            Assert.AreEqual("Helloo", new Helper().SaySomething());
        }
    }
}
