using Lab3_Ivan;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void QuadrilateralPrism()
        {
            Prism prism = new QuadrilateralPrism("", 7, 48);
            Assert.AreEqual(2352, prism.GetVolume());
        }

        [TestMethod]
        public void TrianglePrism()
        {
            Prism prism = new TrianglePrism("", 42, 74);
            Assert.AreEqual(1036, prism.GetVolume());
        }
    }
}
