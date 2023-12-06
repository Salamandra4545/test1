using System;
using test1;

namespace MyTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MainClass func = new MainClass();

            Assert.AreEqual("1 число", func.Func(1));
            Assert.AreEqual("2 число", func.Func(2));
            Assert.AreEqual("some", func.Func(100));


        }
    }
}   