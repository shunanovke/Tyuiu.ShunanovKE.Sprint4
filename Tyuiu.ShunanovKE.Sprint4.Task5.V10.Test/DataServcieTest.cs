using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShunanovKE.Sprint4.Task5.V10.Lib;
namespace Tyuiu.ShunanovKE.Sprint4.Task5.V10.Test
{
    [TestClass]
    public class DataServcieTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matrix = { { 3, 2, -1 },
                              { -4, -3, 1 },
                              { 1, -2, 2 } };
            int res = ds.Calculate(matrix), wait = 9;
            Assert.AreEqual(res, wait);
        }
    }
}
