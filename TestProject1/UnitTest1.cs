using Microsoft.VisualStudio.TestTools.UnitTesting;
using Invoice_Generator;
namespace Invoice_TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestNormalFare()
        {
            CabRide cab = new CabRide();
            double cost = cab.Ride(10, 5);
            Assert.AreEqual(105, cost);
        }
    }
}