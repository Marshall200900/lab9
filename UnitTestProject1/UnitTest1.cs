using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using prog99;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //Тестирование Point.OriginDistance()
        [TestMethod]
        public void TestPointOriginDistance1()
        {
            Point point = new Point(3, 4);
            double expected = 5;
            double actual = point.OriginDistance();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPointOriginDistance2()
        {
            Point point = new Point(0, 4);
            double expected = 4;
            double actual = point.OriginDistance();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestPointOriginDistance3()
        {
            Point point = new Point(0, 0);
            double expected = 0;
            double actual = point.OriginDistance();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestPointOriginDistance4()
        {
            Point point = new Point(0, -1);
            double expected = 1;
            double actual = point.OriginDistance();
            Assert.AreEqual(expected, actual);
        }

        //Тестирование операторов в Point
        [TestMethod]
        public void TestPointOperators1()
        {
            Point point = new Point(0, -1);
            double expectedX = -1;
            double expectedY = -2;
            point--;

            Assert.AreEqual(expectedX, point.X);
            Assert.AreEqual(expectedY, point.Y);

        }
        [TestMethod]
        public void TestPointOperators2()
        {
            Point point = new Point(0, -1);
            double expectedX = -1;
            double expectedY = 0;
            point = -point;
            Assert.AreEqual(expectedX, point.X);
            Assert.AreEqual(expectedY, point.Y);
        }
        [TestMethod]
        public void TestPointOperators3()
        {
            Point point = new Point(0, -1);
            double substract = 2;
            double expected = -2;
            point = point - substract;
            Assert.AreEqual(expected, point.X);
        }
        [TestMethod]
        public void TestPointOperators4()
        {
            Point point = new Point(0, -1);
            double substract = 2;
            double expected = -3;
            point = substract - point;
            Assert.AreEqual(expected, point.Y);
        }
        [TestMethod]
        public void TestPointOperators5()
        {
            Point point1 = new Point(0, 0);
            Point point2 = new Point(5, 0);
            double actual = point1 - point2;
            Assert.AreEqual(5, actual);
        }

        //Тестирование приведения типов

        [TestMethod]
        public void PointCasting1()
        {
            Point p = new Point(2.67, 201);
            int expected = 2;
            int actual = p;
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PointCasting2()
        {
            Point point1 = new Point(0, 2.67);
            double expected = 2.67;
            double actual = (double)point1;
            Assert.AreEqual(expected, actual);

        }

        //Тестирование массива
        [TestMethod]
        public void PointArray1()
        {
            PointArray arr = new PointArray(3);
            arr[0] = new Point(1, 1);
            arr[1] = new Point(2, 2);
            arr[2] = new Point(3, 3);
            double actual = arr.FindShortestDistance();
            Assert.AreEqual(Math.Sqrt(2), actual);
        }
    }
}
