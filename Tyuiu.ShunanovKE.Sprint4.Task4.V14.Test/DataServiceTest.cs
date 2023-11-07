using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShunanovKE.Sprint4.Task4.V14.Lib;

namespace Tyuiu.ShunanovKE.Sprint4.Task4.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] matrix = { { 3, 2, 1 },
                              { 4, 8, 1 },
                              { 1, 2, 2 } };
            int[,] res = ds.Calculate(matrix);
            int[,] wait = { { 0, 2, 0 },
                            { 4, 8, 0 },
                            { 0, 2, 2 } };
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
