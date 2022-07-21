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
        [TestMethod]
        public void TestForMinFare()
        {
            CabRide cab = new CabRide();
            double cost = cab.Ride(0.3, 1);
            Assert.AreEqual(5, cost);
        }
        [TestMethod]
        public void TestMultipleRideFaresSum()
        {
            CabRide cab = new CabRide();
            List<ride> faresSum = new List<ride>()
            {
                new ride(0.3, 1),
                new ride(10, 1),
                new ride(20, 3 ),
                new ride(40, 2),
                new ride(15, 4)
            };
            moreDetails result = cab.ManyRidesSum(faresSum);
            Assert.AreEqual(865, result.TotalFare);
        }
        [TestMethod]
        public void TestMultipleRideFaresDetails()
        {
            CabRide cab = new CabRide();
            List<ride> faresSum = new List<ride>()
            {
                new ride(0.3, 1),
                new ride(10, 1),
                new ride(20, 3),
                new ride(40, 2),
                new ride(15, 4)
            };
            moreDetails result = cab.ManyRidesSum(faresSum);
            Assert.AreEqual(5, result.Tride);
            Assert.AreEqual(173, result.avg);
        }
    }
}