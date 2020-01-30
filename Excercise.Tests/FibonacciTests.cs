using Fibonacci;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Excercise.Tests
{
    [TestClass]
    public class FibonacciTests
    {
        private FibonacciCalc calc;

        [TestInitialize]
        public void Init()
        {
            calc = new FibonacciCalc();
        }

        [TestMethod]
        public void Case_1()
        {
            //Arrange
            var input    = 1;
            var expected = 0;

            //Act
            var result = calc.GetNthFib(input);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Case_2()
        {
            //Arrange
            var input    = 2;
            var expected = 1;

            //Act
            var result = calc.GetNthFib(input);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Case_3()
        {
            //Arrange
            var input    = 3;
            var expected = 1;

            //Act
            var result = calc.GetNthFib(input);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Case_4()
        {
            //Arrange
            var input    = 4;
            var expected = 2;

            //Act
            var result = calc.GetNthFib(input);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Case_5()
        {
            //Arrange
            var input    = 5;
            var expected = 3;

            //Act
            var result = calc.GetNthFib(input);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Case_6()
        {
            //Arrange
            var input    = 6;
            var expected = 5;

            //Act
            var result = calc.GetNthFib(input);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Case_7()
        {
            //Arrange
            var input    = 7;
            var expected = 8;

            //Act
            var result = calc.GetNthFib(input);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Case_8()
        {
            //Arrange
            var input    = 8;
            var expected = 13;

            //Act
            var result = calc.GetNthFib(input);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Case_9()
        {
            //Arrange
            var input    = 9;
            var expected = 21;

            //Act
            var result = calc.GetNthFib(input);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Case_10()
        {
            //Arrange
            var input    = 10;
            var expected = 34;

            //Act
            var result = calc.GetNthFib(input);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Case_11()
        {
            //Arrange
            var input    = 11;
            var expected = 55;

            //Act
            var result = calc.GetNthFib(input);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Case_12()
        {
            //Arrange
            var input    = 12;
            var expected = 89;

            //Act
            var result = calc.GetNthFib(input);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Case_13()
        {
            //Arrange
            var input    = 13;
            var expected = 144;

            //Act
            var result = calc.GetNthFib(input);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Case_14()
        {
            //Arrange
            var input    = 14;
            var expected = 233;

            //Act
            var result = calc.GetNthFib(input);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Case_15()
        {
            //Arrange
            var input    = 15;
            var expected = 377;

            //Act
            var result = calc.GetNthFib(input);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Case_16()
        {
            //Arrange
            var input    = 16;
            var expected = 610;

            //Act
            var result = calc.GetNthFib(input);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Case_17()
        {
            //Arrange
            var input    = 17;
            var expected = 987;

            //Act
            var result = calc.GetNthFib(input);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Case_18()
        {
            //Arrange
            var input    = 18;
            var expected = 1597;

            //Act
            var result = calc.GetNthFib(input);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}