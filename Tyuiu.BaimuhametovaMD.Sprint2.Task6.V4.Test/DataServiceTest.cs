using Tyuiu.BaimuhametovaMD.Sprint2.Task6.V4.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint2.Task6.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void IsSearchValid()
        {
            DataService ds = new DataService();
            int value = 3;
            Assert.AreEqual("бубны", ds.FindCardSuit(value));
        }
    }
}