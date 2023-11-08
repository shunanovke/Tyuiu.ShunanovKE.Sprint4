using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShunanovKE.Sprint4.Task7.V9.Lib;

namespace Tyuiu.ShunanovKE.Sprint4.Task7.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string str = "864299753";
            int n = 3, m = 3;
            int res = ds.Calculate(n, m, str);
            int wait = 4;
            Assert.AreEqual(res, wait);
        }
    }
}
