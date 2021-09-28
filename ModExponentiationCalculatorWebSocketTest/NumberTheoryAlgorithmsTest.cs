using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModExponentiationCalculatorWebSocket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModExponentiationCalculatorWebSocketTest
{
    [TestClass]
    public class NumberTheoryAlgorithmsTest
    {
        [TestMethod]
        public void ModExponentiation_BaseOperation_Expected36()
        {
            NumberTheoryAlgorithms modCalculator = new NumberTheoryAlgorithms();

            var result = modCalculator.ModExponentiation(3, 644, 645);

            Assert.AreEqual(36, result);
        }
    }
}
