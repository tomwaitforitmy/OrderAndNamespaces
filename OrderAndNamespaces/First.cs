using NUnit.Framework;
using NUnit.Framework.Internal;
using System.Diagnostics;

namespace UnitTestProject1
{
    [TestFixture]
    public class First
    {
        [Test, Order(1), Category("NoNamespace")]
        public void Order1()
        {
            Debug.WriteLine(TestContext.CurrentContext.Test.MethodName);
        }
    }
}
