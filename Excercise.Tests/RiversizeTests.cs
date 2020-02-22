using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Riversizes;

namespace AlgoExpert.Excercise.Tests
{
    [TestClass]
    public class RiversizeTests
    {
        private RiverFinder riverFinder;

        [TestInitialize]
        public void Init()
        {
            riverFinder = new RiverFinder();
        }

        [TestMethod]
        public void Case_01()
        {
            int[,] input    = { { 0 } };
            int[]  expected = { };
            var    output   = riverFinder.RiverSizes(input);
            output.Sort();

            Assert.AreEqual(expected.Length, output.Count);
        }

        [TestMethod]
        public void Case_03()
        {
            int[,] input    = { { 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 0 } };
            var    expected = new List<int> { 1, 2, 3 };

            var output = riverFinder.RiverSizes(input);
            output.Sort();

            Assert.AreEqual(expected.Count, output.Count);

            for (var i = 0; i < output.Count; i++)
                Assert.AreEqual(expected[i], output[i]);
        }

        [TestMethod]
        public void Case_04()
        {
            var expectedResult = new List<int> { 1, 6, 8, 14 };

            int[,] input =
            {
                { 0, 1, 1, 0, 1, 0, 0, 1 },
                { 0, 1, 1, 0, 1, 0, 0, 1 },
                { 1, 1, 1, 0, 1, 0, 0, 1 },
                { 0, 1, 0, 0, 1, 1, 1, 1 },
                { 0, 0, 1, 0, 1, 0, 0, 1 },
                { 1, 1, 1, 0, 0, 0, 0, 1 },
                { 0, 1, 1, 0, 1, 0, 0, 1 }
            };

            var result = riverFinder.RiverSizes(input);
            result.Sort();

            Assert.AreEqual(expectedResult.Count, result.Count);

            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(expectedResult[i], result[i]);
            }
        }
    }
}