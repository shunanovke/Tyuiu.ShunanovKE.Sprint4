﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShunanovKE.Sprint4.Task2.V16.Lib;

namespace Tyuiu.ShunanovKE.Sprint4.Task2.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] array = {3, 4, 5, 6, 7, 8, 9, 8, 9, 9 };
            int res = ds.Calculate(array), wait = 42;
            Assert.AreEqual(res, wait);
        }
    }
}
