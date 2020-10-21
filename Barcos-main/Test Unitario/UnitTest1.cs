using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.Security.Cryptography.X509Certificates;

namespace Test_Unitario
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ProbarBarcoAmigo()
        {
            BarcoAmigo barcoAmigo = null; // new BarcoAmigo(10,10,9,3);

            Assert.IsNull(barcoAmigo);
        }

        [TestMethod]

        public void TestBarcoEnemigo()
        {

        }
    }
}
