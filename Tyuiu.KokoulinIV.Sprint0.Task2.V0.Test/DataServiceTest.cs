using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KokoulinIV.Sprint0.Task2.V0.Lib;

namespace Tyuiu.KokoulinIV.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessegValid()
        {
            var name = "Игорь";
            var res = DataService.GetMessege(name);

            Assert.AreEqual( "Привет..., Игорь", res);
        }
    }
}
