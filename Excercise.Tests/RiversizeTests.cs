using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            int[,]    input    = { { 0 } };
            int[]     expected = { };
            List<int> output   = riverFinder.RiverSizes(input);
            output.Sort();

            Assert.AreEqual(expected.Length, output.Count);
        }

        [TestMethod]
        public void Case_03()
        {
            int[,]    input    = { { 1, 1, 1, 0, 1, 1, 0, 0, 0, 1, 0 } };
            var expected = new List<int>{ 1, 2, 3 };

            List<int> output   = riverFinder.RiverSizes(input);
            output.Sort();

            Assert.AreEqual(expected.Count, output.Count);

            for (int i = 0; i < output.Count; i++)
            {
                Assert.AreEqual(expected[i], output[i]);
            }
        }
    }
}
