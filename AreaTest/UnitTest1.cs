using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rezume;

namespace AreaTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRightTriangleCounting()
        {
            string[] sides = { "1 1 1", "5 5 1", "4 5 2", "5 4 3", "0,1 0,1 0,1" };
            foreach (string side in sides)
            {
                double a = Convert.ToDouble(side.Split(' ')[0]);
                double b = Convert.ToDouble(side.Split(' ')[1]);
                double c = Convert.ToDouble(side.Split(' ')[2]);
                double p = (a + b + c) / 2;
                Assert.AreEqual(Math.Sqrt(p * (p - a) * (p - b) * (p - c)), Areas.AreaTriangle(a, b, c));
            }
        }

        [TestMethod]
        public void TestTriangleException()
        {
            string[] sides = { "0 0 0", "7 4 3", "7 3,75 3,25" };
            foreach (string side in sides)
            {
                double a = Convert.ToDouble(side.Split(' ')[0]);
                double b = Convert.ToDouble(side.Split(' ')[1]);
                double c = Convert.ToDouble(side.Split(' ')[2]);
                Assert.ThrowsException<Exception>(() => { var res = Areas.AreaTriangle(a, b, c); });
            }
        }

        [TestMethod]
        public void TestRightCircleCounting()
        {
            double[] radius = { 0, 1, 10, 523, 1.12, 10001.2 };
            foreach (double r in radius)
            {
                Assert.AreEqual(Math.PI * Math.Pow(r, 2), Areas.AreaCircle(r));
            }
        }

        [TestMethod]
        public void TestCircleException()
        {
            double[] radius = { -1, -0.00000001 };
            foreach (double r in radius)
            {
                Assert.ThrowsException<Exception>(() => { var res = Areas.AreaCircle(r); });
            }
        }
    }
}