using Invoice_Generator;
Console.WriteLine("Welcome to the cab invoice problem");
CabRide cab = new CabRide();
List<ride> faresSum = new List<ride>()
            {
                new ride(0.3, 1),
                new ride(10, 1),
                new ride(20, 3 ),
                new ride(40, 2),
                new ride(15, 4)
            };
double result = cab.ManyRidesSum(faresSum);
Console.WriteLine("The sum for multiple rides is = " + result);