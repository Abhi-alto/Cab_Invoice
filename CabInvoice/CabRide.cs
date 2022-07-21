using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice_Generator
{
    public class moreDetails
    {
        public int Tride = 0;
        public double avg = 0;
        public double TotalFare = 0;
        public moreDetails(int totRides, double Tfare)
        {
            this.Tride = totRides;
            this.TotalFare = Tfare;
            avg = TotalFare / Tride;
        }

    }
    public class ride
    {
        public double km = 0,
               hrs = 0;
        public ride(double km, double hrs)
        {
            this.km = km;
            this.hrs = hrs;
        }
    }
    public class CabRide
    {
        const double Rate_PKM = 10,
                     Rate_pHr = 1,
                     min_fare = 5;
        public double Ride(double km, double hrs)
        {
            if ((km * Rate_PKM + hrs * Rate_pHr) >= min_fare)
            {
                return (km * Rate_PKM + hrs * Rate_pHr);
            }
            return min_fare;
        }
        public moreDetails ManyRidesSum(List<ride> multipleRides)
        {
            ///Takes input as a List which contains objects of ride class
            ///then each element of this list i.e ride object is passed to Ride class
            ///This is done to calculate fare for each object and then added to total
            double total = 0;
            foreach (var cost in multipleRides)
            {
                total += Ride(cost.km, cost.hrs);
            }
            moreDetails obj = new moreDetails(multipleRides.Count, total);                  //passed to calculate avg cost/ride
            return obj;
        }

    }
}
