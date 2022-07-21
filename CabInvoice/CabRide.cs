using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice_Generator
{
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
        public double ManyRidesSum(List<ride> multipleRides)
        {
            ///Takes input as a List which contains objects of ride class
            ///then each element of this list i.e ride object is passed to Ride class
            ///This is done to calculate fare for each object and then added to total
            double total = 0;
            foreach (var cost in multipleRides)
            {
                total += Ride(cost.km, cost.hrs);
            }
            return total;
        }
    }
}
