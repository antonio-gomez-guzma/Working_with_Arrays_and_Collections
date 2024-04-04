using System;
using System.Collections.Generic;

namespace Pluralsight.ArraysCollections.Demos
{
	class Program
	{
		static void Main(string[] args)
		{
			BusRoute route40 = new BusRoute(40, "Morecambe", "Preston");
			BusRoute route42 = new BusRoute(42, "Lancaster", "Blackpool");

            BusRoute[] routes = new BusRoute[4];

            routes[0] = route40;
            routes[1] = route42;
            routes[2] = new BusRoute(100, "University", "Morecambe");
            routes[3] = new BusRoute(555, "Lancaster", "Keswick");

            for (int i = 0; i < routes.Length; i++)
                Console.WriteLine($"{i}: {routes[i]}");
        }
	}
}
