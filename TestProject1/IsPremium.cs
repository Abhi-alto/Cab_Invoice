using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Invoice_Generator;
using CabInvoice;

namespace TestProject1
{
    [TestClass]
    internal class IsPremium
    {
        [TestMethod]
        public void TestPremium()
        {
            CabRide cab = new CabRide();
            List<ride> faresSum = new List<ride>()
            {
                new ride(0.3, 1,true),
                new ride(10, 1),
                new ride(20, 3,true ),
                new ride(40, 2),
                new ride(15, 4,true)
            };
            moreDetails result = cab.ManyRidesSum(faresSum);
            Assert.AreEqual(1225, result.TotalFare);
        }
    }
}
