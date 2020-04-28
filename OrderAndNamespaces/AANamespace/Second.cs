using System.Diagnostics;
using NUnit.Framework;

namespace UnitTestProject1.AANamespace
{
    [TestFixture, Order(2)]
    public class Second
    {
        [Test, Order(2), Category("WithNamespace")]
        public void Order2() //Should run second but runs first
        {
            Debug.WriteLine(TestContext.CurrentContext.Test.MethodName);
        }
    }
}
