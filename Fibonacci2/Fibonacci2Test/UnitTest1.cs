using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fibonacci2;

namespace Fibonacci2Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Fibonacci2.Form1 f2 = new Fibonacci2.Form1();
            int sonuc = f2.fibonacciHesapla(30);
            Assert.AreEqual(1346269, sonuc);
        }
    }
}
