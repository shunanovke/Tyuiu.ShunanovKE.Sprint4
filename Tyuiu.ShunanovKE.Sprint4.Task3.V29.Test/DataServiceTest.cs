using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShunanovKE.Sprint4.Task3.V29.Lib;

namespace Tyuiu.ShunanovKE.Sprint4.Task3.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] array = { { 3, 3, 5, 5, 8 },
                             { 5, 9, 1, 5, 1 },
                             { 7, 3, 7, 3, 2 },
                             { 1, 3, 5, 5, 8 },
                             { 5, 9, 1, 5, 1 },};
            int res = ds.Calculate(array), wait = 525;
            Assert.AreEqual(res, wait);
        }
    }
}
