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
    internal class InvoiceServiceTest
    {
        [TestMethod]
        public void Service()
        {
            int Id = 2;
            InvoiceService user = new InvoiceService();
            user.AddToList(2, new List<ride>()
            {
                new ride(0.3, 1),
                new ride(10, 1),
                new ride(20, 3 ),
                new ride(40, 2),
                new ride(15, 4)
            });
            user.AddToList(3, new List<ride>()
            {
                new ride(10, 1),
                new ride(20, 3 ),
                new ride(40, 2),
                new ride(15, 4)        //861
            });
            var res = user.getFare(2);
            Assert.AreEqual(865, res.TotalFare);
        }
    }
}
