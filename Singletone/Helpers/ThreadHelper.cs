using Singleton.Models;
using Singleton.Models.Posts;
using Singleton.Models.Vehicles;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Singleton.Helpers
{
    internal class ThreadHelper
    {

        internal static void ProcessThreads(int threadAmount, List<CargoVehicle> vehicles, List<IPost> posts)
        {
            List<Thread> threads = InitializeThreads(threadAmount);
            foreach (Thread t in threads)
            {
                PostVehiclePair pair = new PostVehiclePair(PickRandomFromList(posts),
                                                           PickRandomFromList(vehicles));
                t.Start(pair);
                t.Join();
            }
        }

        private static List<Thread> InitializeThreads(int threadAmount)
        {
            List<Thread> threads = new List<Thread>();
            for (int i = 0; i < threadAmount; i++)
            {
                threads.Add(new Thread(new ParameterizedThreadStart(Process)));
            }

            return threads;
        }

        private static void Process(object pair)
        {
            PostVehiclePair p = pair as PostVehiclePair;
            p.Post.ProcessCargo(p.Vehicle);
            Console.WriteLine(DailyStatistics.Instance.GetInfo());
        }

        private static T PickRandomFromList<T>(List<T> list) where T : class
        {
            int index = new Random().Next(list.Count);
            return list[index];
        }

        private class PostVehiclePair
        {
            internal IPost Post { get; set; }
            internal CargoVehicle Vehicle { get; set; }

            public PostVehiclePair(IPost post, CargoVehicle vehicle)
            {
                Post = post;
                Vehicle = vehicle;
            }
        }
    }
}
