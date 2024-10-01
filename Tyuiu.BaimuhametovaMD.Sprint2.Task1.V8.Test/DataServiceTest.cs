using Tyuiu.BaimuhametovaMD.Sprint2.Task1.V8.Lib;

namespace Tyuiu.BaimuhametovaMD.Sprint2.Task1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void OperationsValid()
        {
            DataService ds = new DataService();
            int a = 15, b = 16, c = 14, d = 335;
            bool[] res = ds.GetLogicOperations(a, b, c, d);
            Assert.AreEqual([true, false, true, false, false, false], res);
        }
    }
}