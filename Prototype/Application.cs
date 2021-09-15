using Prototype.Models;
using Prototype.Models.Posts;
using System;
using System.Collections.Generic;

namespace Prototype
{
    internal class Application
    {
        static void Main(string[] args)
        {
            City chernivtsi = new City("UA-77", "Chernivtsi", "58012");
            City khmelnytskyi = new City("UA-68", "Khmelnytskyi", "29000");
            City lviv = new City("UA-46", "Lviv", "79007");

            IPost deliveryPost1 = new DeliveryPost(chernivtsi, "Golovna, 55");
            IPost deliveryPost2 = deliveryPost1.Clone();
            IPost deliveryPost3 = deliveryPost1.Clone();

            List<IPost> chernivstiPosts = new List<IPost>
            {
                deliveryPost1, deliveryPost2, deliveryPost3
            };

            chernivstiPosts.ForEach(i => Console.WriteLine(i));

            chernivtsi.PostalCode = "fsdfsdg";

            chernivstiPosts.ForEach(i => Console.WriteLine(i));

            IPost dispatchPost1 = new DispatchPost(khmelnytskyi, "Arbatska, 12");
            IPost dispatchPost2 = dispatchPost1.DeepClone();
            IPost dispatchPost3 = dispatchPost1.DeepClone();

            List<IPost> khmelnytskiyPosts = new List<IPost>
            {
                dispatchPost1, dispatchPost2, dispatchPost3
            };

            khmelnytskiyPosts.ForEach(i => Console.WriteLine(i));
            khmelnytskyi.PostalCode = "3dfgdfg";
            khmelnytskiyPosts.ForEach(i => Console.WriteLine(i));
        }
    }
}
