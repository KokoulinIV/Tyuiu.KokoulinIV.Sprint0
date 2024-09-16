using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KokoulinIV.Sprint0.Task3.V0.Lib;

namespace Tyuiu.KokoulinIV.Sprint0.Task3.V0.Test
{
    [TestClass]
    public class DataSersiceTest
    {
        [TestMethod]
        public void CheckedValid()
        {
            Assert.AreEqual(10, DataService.Sum(5,5));
        }
    }
}
