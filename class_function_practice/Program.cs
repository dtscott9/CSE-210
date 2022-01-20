using System;
using System.Collections.Generic;

namespace class_practice
{
    class Program
    {
        static void Main(string[] args)
        {
          

            List<string> cities = new List<string>();

            cities.Add("Rexburg");
            cities.Add("Phoenix");
            cities.Add("Boise");
            cities.Add("Vegas");
            cities.Add("Blackfoot");
            

            // foreach (string city in cities)
            // {
            //     Console.WriteLine(city);
            // }
            
            for (int i = 0; i < cities.Count; i ++)
            {
                Console.Write(cities[i]);
                Console.Write(" ");
            }

        //     PrintItinerary(cities);
            
        // static void PrintItinerary(List<string> cities)
        // {
        //     Console.WriteLine(cities[0]);

        // }
        }
    }
}
