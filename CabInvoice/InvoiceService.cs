using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Invoice_Generator;

namespace CabInvoice
{
    public class InvoiceService
    {
        /// <InvoiceServices>
        /// used for storing the Dictionary having ID as key and List of othe details as the value>
        /// <AddToList>
        /// used for adding a list of rides in the DataBase dictionary
        /// <moreDetails>
        /// used for geting the details of a particular ID and returning the vtotalFare of that particular Id with all its rides
        Dictionary<int,List<ride>> DataBase = new Dictionary<int,List<ride>>();
        public moreDetails getFare(int UserID)
        {
            CabRide cab = new CabRide();
            List<ride> list = DataBase[UserID];
            moreDetails result = new moreDetails(0, 0);
            if (list != null && list.Count() > 0)
            {
                result = cab.ManyRidesSum(DataBase[UserID]);
            }
            return result;
        }
        public void AddToList(int UserID,List <ride> RidesList)
        {
            List<ride> list = new List<ride>();
            var res = DataBase[UserID];
            if(res!=null)
            {
                list=res;
            }
            foreach(var rides in RidesList)
            {
                list.Add(rides);
            }
            DataBase[UserID] = list;
        }
    }
}
