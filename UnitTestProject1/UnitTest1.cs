using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ConsoleAppTest;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ArgTest()
        {
            var mock = new Mock<IArg>();

            string[] args = {  };

            mock.Setup(p => p.CheckArgument(args)).Returns(false);

            MyClass objMyClass = new MyClass(mock.Object);

            var ActualOutput = objMyClass.CheckArgument(args);

            Assert.AreEqual(false, ActualOutput);
        }
    }
}
