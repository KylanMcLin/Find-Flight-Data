using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2
{
    class McLin_Kylan_assign2
    {
        static void Main(string[] args)
        {
            //Lists Of Data
            string[] airLine = { "Delta", "Southwest", "Spirit", "United", "Spirit", "Delta", "United", "Southwest", "Delta" };
            int[] flightNum = { 1100, 892, 741, 1941, 1811, 2391, 844, 1441, 2141 };
            string[] from = { "Atlanta", "Las Vagas", "Los Angeles", "Nashville", "Chicago", "Atlanta", "Chicago", "Las Vegas", "Boston" };
            int[] gate = { 2, 1, 8, 5, 2, 1, 5, 1, 2 };

            //getting all flights
            Console.WriteLine(FindFlightData(airLine, flightNum, from, gate));

            //getting all Delta flights
            Console.WriteLine(FindFlightData(airLine, flightNum, from, gate, "Delta"));

            //getting all flights with gate 2
            Console.WriteLine(FindFlightData(airLine, flightNum, from, gate, 2));

            //getting a specific flight
            Console.WriteLine(FindFlightData(airLine, flightNum, from, gate, "Southwest", 892));

            Console.ReadLine();

        }

        //Getting All Flights
        static string FindFlightData(string[] airLine, int[] flightNum, string[] from, int[] gate)
        {
            string allFlights = "";

            for (int index = 0; index < airLine.Length; index++)
            {

                allFlights += "Flight: " + airLine[index] + " " + flightNum[index] + ", From: " + from[index] + ", Gate: " + gate[index] + "\n";

            }

            Console.WriteLine("Getting All Flights");
            return allFlights;
        }

        //Searching For AirLine
        static string FindFlightData(string[] airLine, int[] flightNum, string[] from, int[] gate, string searchAirLine)
        {
            string allFlights = "";
            for (int index = 0; index < airLine.Length; index++)
            {

                if (airLine[index] == searchAirLine)
                {

                    allFlights += "Flight: " + airLine[index] + " " + flightNum[index] + ", From: " + from[index] + ", Gate: " + gate[index] + "\n";

                }

            }
            Console.WriteLine("Testing For AirLine");
            return allFlights;
        }

        //Searching For Gate
        static string FindFlightData(string[] airLine, int[] flightNum, string[] from, int[] gate, int searchGate)
        {
            string allFlights = "";
            for (int index = 0; index < airLine.Length; index++)
            {

                if (gate[index] == searchGate)
                {

                    allFlights += "Flight: " + airLine[index] + " " + flightNum[index] + ", From: " + from[index] + ", Gate: " + gate[index] + "\n";

                }

            }
            Console.WriteLine("Testing for Gate Number");
            return allFlights;
        }

        //Searching For Specific Flight
        static string FindFlightData(string[] airLine, int[] flightNum, string[] from, int[] gate, string searchAirLine, int searchFlightNum)
        {
            string allFlights = "";

            for (int index = 0; index < airLine.Length; index++)
            {

                if (airLine[index] == searchAirLine && flightNum[index] == searchFlightNum)
                {

                    allFlights += "Flight: " + airLine[index] + " " + flightNum[index] + ", From: " + from[index] + ", Gate: " + gate[index] + "\n";

                }

            }

            Console.WriteLine("Testing for Specific Flight");
            return allFlights;
        }
    }
}

