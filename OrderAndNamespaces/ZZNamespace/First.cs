using System.Diagnostics;
using NUnit.Framework;

namespace UnitTestProject1.ZZNamespace
{
    [TestFixture, Order(1)]
    public class First
    {
        [Test, Order(1), Category("WithNamespace")]
        public void Order1() //Should run first but runs second
        {
            Debug.WriteLine(TestContext.CurrentContext.Test.MethodName);
        }
    }
}
