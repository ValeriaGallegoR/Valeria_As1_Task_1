//PROG-8051 Assignment-1

namespace Valeria_As1_Task_1 {

    class Task1
    {
        static void Main(string[] args)
        {
            //Declaration of roundtrip cost variables
            double YyzToCgy = 1350 * 2;
            double YyzToVan = 1500 * 2;
            double YyzToYmq = 575 * 2;

            //Get the number of trips made by the user for each city
            Console.Write("Enter the number of trips to Calgary (CGY): ");
            int TripsToCgy = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of trips to Vancouver (VAN): ");
            int TripsToVan = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of trips to Montreal (YMQ): ");
            int TripsToYmq = int.Parse(Console.ReadLine());

            //Calculate total cost for each trip
            double TotalCostCgy = YyzToCgy * TripsToCgy;
            double TotalCostVan = YyzToVan * TripsToVan;
            double TotalCostYmq = YyzToYmq * TripsToYmq;

            //Calculate the total money spent by Carlo
            double TotalCostTrips = TotalCostCgy + TotalCostVan + TotalCostYmq;
        }
    }
}
