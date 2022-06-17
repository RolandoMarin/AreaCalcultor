using MarinAreaCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AreaCalculatorTest

{
    [TestClass]
    public class UnitTest1
    {
        private AreaCalc ac = new AreaCalc();
        [TestMethod]
        public void SquareAreaIntSuccess()
        {
            Assert.AreEqual(1, ac.getSquareArea(1,2));
        }
        [TestMethod]
        public void SquareAreaStringSuccess()
        {
            Assert.AreEqual(100, ac.getSquareArea("ten", "two"));
        }
        [TestMethod]
        public void RectangleAreaSuccess()
        {
            Assert.AreEqual(2, ac.getRectangleArea(1, 2));
    
        }
        [TestMethod]
        public void TriangleAreaSuccess()
        {
            Assert.AreEqual(12.5, ac.getTriangleArea(5, 5));

        }
        [TestMethod]
        public void ParallelogramAreaSuccess()
        {
            Assert.AreEqual(25, ac.getParrallelogramArea(5, 5));
        }
        [TestMethod]
        public void CircleRadiusSuccess()
        {
            Assert.AreEqual(2.5, ac.getCircleRadius(5));
        }
        [TestMethod]
        public void CircleDiameterSuccess()
        {
            Assert.AreEqual(10, ac.getCircleDiameter(5));
        }

    }
}