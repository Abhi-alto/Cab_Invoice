using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoice_Generator
{
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
    }
}
