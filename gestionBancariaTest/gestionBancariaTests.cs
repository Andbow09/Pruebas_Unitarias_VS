using gestionBancariaApp;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace gestionBancariaTest
{
    [TestClass]
    public class gestionBancariaTests
    {
        // unit test code [TestMethod]
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void excReintegro()
        {
            // preparación del caso de prueba
            double saldoInicial = -60;
            double reintegro = -30;
            double saldoActual = 0;
            double saldoEsperado = 20;

            gestionBancaria cuenta = new gestionBancaria(saldoInicial);
            // Método a probar
            cuenta.realizarReintegro(reintegro);
            // afirmación de la cuenta (valor esperado Vs. Valor obtenido)
            saldoActual = cuenta.obtenerSaldo();

            Assert.AreEqual(saldoEsperado, saldoActual, 0.001, "El saldo de la cuenta no es correcto");
        }
    }
}
