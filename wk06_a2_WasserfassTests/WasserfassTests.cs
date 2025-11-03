using Microsoft.VisualStudio.TestTools.UnitTesting;
using wk06_a2_Wasserfass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wk06_a2_Wasserfass.Tests
{
    [TestClass()]
    public class WasserfassTests
    {
        [TestMethod()]
        public void BefüllenTest0()
        {
            //Arange
            Wasserfass wasserfass1 = new Wasserfass(10, 190, 50, 200);

            //Act
            int fuellstand = wasserfass1.befüllen(20);

            //Assert
            Assert.AreEqual(70, fuellstand);
        }

        [TestMethod()]
        public void BefüllenTest1()
        {
            //Arange
            Wasserfass wasserfass1 = new Wasserfass(10, 190, 50, 200);

            //Act
            int fuellstand = wasserfass1.befüllen(140);

            //Assert
            Assert.AreEqual(190, fuellstand);
        }

        [TestMethod()]
        public void BefüllenTest2()
        {
            //Arange
            Wasserfass wasserfass1 = new Wasserfass(10, 190, 50, 200);

            //Act
            int fuellstand = wasserfass1.befüllen(150);

            //Assert
            Assert.AreEqual(200, fuellstand);
        }

        [TestMethod()]
        public void BefüllenTest3()
        {
            //Arange
            Wasserfass wasserfass1 = new Wasserfass(10, 190, 50, 200);

            //Act
            int fuellstand = wasserfass1.befüllen(200);

            //Assert
            Assert.AreEqual(200, fuellstand);
        }

        [TestMethod()]
        public void EntleerenTest0()
        {
            //Arange
            Wasserfass wasserfass1 = new Wasserfass(10, 190, 10, 200);

            //Act
            int fuellstand = wasserfass1.entleeren();

            //Assert
            Assert.AreEqual(0, fuellstand);
        }

        [TestMethod()]
        public void EntleerenTest1()
        {
            //Arange
            Wasserfass wasserfass1 = new Wasserfass(10, 190, 50, 200);

            //Act
            int fuellstand = wasserfass1.entleeren();

            //Assert
            Assert.AreEqual(0, fuellstand);
        }

        [TestMethod()]
        public void EntleerenTest2()
        {
            //Arange
            Wasserfass wasserfass1 = new Wasserfass(10, 190, 190, 200);

            //Act
            int fuellstand = wasserfass1.entleeren();

            //Assert
            Assert.AreEqual(0, fuellstand);
        }

        [TestMethod()]
        public void EntnehmenTest0()
        {
            //Arange
            Wasserfass wasserfass1 = new Wasserfass(10, 190, 50, 200);

            //Act
            int fuellstand = wasserfass1.entnehmen(20);

            //Assert
            Assert.AreEqual(30, fuellstand);
        }

        [TestMethod()]
        public void EntnehmenTest1()
        {
            //Arange
            Wasserfass wasserfass1 = new Wasserfass(10, 190, 50, 200);

            //Act
            int fuellstand = wasserfass1.entnehmen(20);

            //Assert
            Assert.AreEqual(30, fuellstand);
        }

        [TestMethod()]
        public void EntnehmenTest2()
        {
            //Arange
            Wasserfass wasserfass1 = new Wasserfass(10, 190, 50, 200);

            //Act
            int fuellstand = wasserfass1.entnehmen(40);

            //Assert
            Assert.AreEqual(10, fuellstand);
        }

        [TestMethod()]
        public void EntnehmenTest3()
        {
            //Arange
            Wasserfass wasserfass1 = new Wasserfass(10, 190, 50, 200);

            //Act
            int fuellstand = wasserfass1.entnehmen(50);

            //Assert
            Assert.AreEqual(10, fuellstand);
        }

        [TestMethod()]
        public void KonstruktorTest0()
        {
            //Arange&Act
            Wasserfass wasserfass1 = new Wasserfass(10, 190, 50, 200);

            //Assert
            Assert.AreEqual(50, wasserfass1.Fuellstand);
            Assert.AreEqual(200, wasserfass1.Kapazitaet);
        }

        [TestMethod()]
        public void KonstruktorTest1()
        {
            //Arange&Act
            Wasserfass wasserfass1 = new Wasserfass(10, 190, 30, 400);

            //Assert
            Assert.AreEqual(30, wasserfass1.Fuellstand);
            Assert.AreEqual(400, wasserfass1.Kapazitaet);
        }

        [TestMethod()]
        public void KonstruktorTest2()
        {
            //Arange&Act
            Wasserfass wasserfass1 = new Wasserfass();
            //Assert
            Assert.AreEqual(50, wasserfass1.Fuellstand);
            Assert.AreEqual(200, wasserfass1.Kapazitaet);
        }
    }
}