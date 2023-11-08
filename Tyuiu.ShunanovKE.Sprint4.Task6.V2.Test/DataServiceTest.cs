using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShunanovKE.Sprint4.Task6.V2.Lib;

namespace Tyuiu.ShunanovKE.Sprint4.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] array = { "Белый", "Черный", "Зеленый", "Синий", "Красный", "Желтый", "Фиолетовый" };
            string[] res = ds.Calculate(array);
            string[] wait = { "Черный", "Зеленый", "Красный", "Желтый", "Фиолетовый" };
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
