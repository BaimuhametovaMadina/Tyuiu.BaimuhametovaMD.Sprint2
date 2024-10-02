using Tyuiu.BaimuhametovaMD.Sprint2.Task4.V2.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint2.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidIfXMoreThanYPlusThree()
        {
            double x = 5, y = 1;
            DataService ds = new DataService();
            Assert.AreEqual(11, ds.Calculate(x, y));
        }
        [TestMethod]
        public void ValidIfXLessThanYPlusThree()
        {
            double x = 1, y = 1;
            DataService ds = new DataService();
            Assert.AreEqual(2, ds.Calculate(x, y));
        }
    }
}