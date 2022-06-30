using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;

namespace Calculator.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Skladuvaet()
        {
            float x = 47.3F, y = 84.12F;
            string c = "+";
            float expected = x + y;
            Form1 TEST = new Form1();
            float actual = TEST.MathClass.Calculate(x, y, c);
            Assert.AreEqual(expected, actual, "NEPRAVILNO");
        }

        [TestMethod]
        public void Otnimaet()
        {
            float x = 216.97F, y = 81.28F;
            string c = "-";
            float expected = x - y;
            Form1 TEST = new Form1();
            float actual = TEST.MathClass.Calculate(x, y, c);
            Assert.AreEqual(expected, actual, "NEPRAVILNO");
        }

        [TestMethod]
        public void Umnozhaet()
        {
            float x = 123F, y = 321F;
            string c = "*";
            float expected = x * y;
            Form1 TEST = new Form1();
            float actual = TEST.MathClass.Calculate(x, y, c);
            Assert.AreEqual(expected, actual, "NEPRAVILNO");
        }

        [TestMethod]
        public void Delit()
        {
            float x = 929.99F, y = 115.11F;
            string c = "/";
            float expected = x / y;
            Form1 TEST = new Form1();
            float actual = TEST.MathClass.Calculate(x, y, c);
            Assert.AreEqual(expected, actual, "NEPRAVILNO");
        }
        [TestMethod]
        public void logo()
        {
            float x = 9.29F, y = 2;
            string c = "log";
            float expected = (float)Math.Log(x,y);
            Form1 TEST = new Form1();
            float actual = TEST.MathClass.Calculate(x, y, c);
            Assert.AreEqual(expected, actual, "NEPRAVILNO");
        }
        [TestMethod]
        public void Tan()
        {
            float x = 142.29F, y = 121.21F;
            string c = "tan";
            float expected = (float)Math.Tan(x);
            Form1 TEST = new Form1();
            float actual = TEST.MathClass.Calculate(x, y, c);
            Assert.AreEqual(expected, actual, "NEPRAVILNO");
        }






    }
}
