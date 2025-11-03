using Microsoft.VisualStudio.TestTools.UnitTesting;
using wk06_a1_OO_Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk06_a1_OO_Calculator.Tests
{
    [TestClass()]
    public class Calculator0Tests
    {
        [TestMethod()]
        public void AddTest()
        {
            //Arange
            Calculator0 calculator = new Calculator0();

            //Act
            int lösung1 = calculator.Add(2, 3);

            //Assert
            Assert.AreEqual(5, lösung1);
        }

        [TestMethod()]
        public void MultTest()
        {
            //Arange
            Calculator0 calculator = new Calculator0();

            //Act
            int lösung1 = calculator.Mult(2, 3);

            //Assert
            Assert.AreEqual(6, lösung1);
        }

        [TestMethod()]
        public void SubTest()
        {
            //Arange
            Calculator0 calculator = new Calculator0();

            //Act
            int lösung1 = calculator.Add(5, 3);

            //Assert
            Assert.AreEqual(2, lösung1);
        }

        [TestMethod()]
        public void DivTest()
        {
            //Arange
            Calculator0 calculator = new Calculator0();

            //Act
            int lösung1 = calculator.Add(10, 5);

            //Assert
            Assert.AreEqual(2, lösung1);
        }
    }
}