using NUnit.Framework;
using NUnit.Framework.Internal;
using System.Diagnostics;

namespace UnitTestProject1
{
    [TestFixture]
    public class Second
    {
        [Test, Order(2), Category("NoNamespace")]
        public void Order2()
        {
            Debug.WriteLine(TestContext.CurrentContext.Test.MethodName);
        }
    }
}
