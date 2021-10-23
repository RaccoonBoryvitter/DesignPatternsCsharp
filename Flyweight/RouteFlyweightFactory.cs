using System;
using System.Collections.Generic;
using System.Linq;

namespace Flyweight
{
    internal class RouteFlyweightFactory
    {
        private List<Tuple<RouteFlyweight, string>> flyweights;

        public RouteFlyweightFactory(params Route[] routes)
        {
            flyweights = routes.Select(r => new Tuple<RouteFlyweight, string>(
                                                    new RouteFlyweight(r), GetKey(r)
                                                    )
                                      )
                               .ToList();
        }

        public RouteFlyweight GetFlyweight(Route sharedState)
        {
            string key = GetKey(sharedState);

            if(flyweights.Where(f => f.Item2 == key).Count() == 0)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Can't find this flyweight, creating a new one...");
                Console.ForegroundColor = ConsoleColor.White;
                flyweights.Add(new Tuple<RouteFlyweight, string>(
                    new RouteFlyweight(sharedState), key
                ));
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Reusing existing flyweight...");
                Console.ForegroundColor = ConsoleColor.White;
            }

            return flyweights.Where(i => i.Item2 == key).FirstOrDefault().Item1;
        }

        public void ListFlyweights()
        {
            var count = flyweights.Count;
            Console.WriteLine($"\nApplication has {count} flyweights:");
            foreach (var flyweight in flyweights)
            {
                Console.WriteLine(flyweight.Item2);
            }
            Console.WriteLine();
        }

        private string GetKey(Route route)
        {
            return $"{route.From}->{route.To}";
        }
    }
}
