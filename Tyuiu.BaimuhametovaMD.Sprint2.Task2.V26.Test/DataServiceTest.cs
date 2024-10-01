using Tyuiu.BaimuhametovaMD.Sprint2.Task2.V26.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint2.Task2.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void MethodValidInCheckedArea()
        {
            DataService ds = new DataService();
            int x = 8, y = 8;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(true, res);
        }
        [TestMethod]
        public void MethodValidInUncheckedArea()
        {
            DataService ds = new DataService();
            int x = 10, y = 10;
            bool res = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(false, res);
        }
    }
}