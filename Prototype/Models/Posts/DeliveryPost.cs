using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Models.Posts
{
    internal class DeliveryPost : IPost
    {
        public string Id { get; }

        public City City { get; set; }
        public string Address { get; set; }

        public DeliveryPost(City city, string address)
        {
            Id = Guid.NewGuid().ToString();
            City = city;
            Address = address;
        }

        public IPost Clone()
        {
            return this.MemberwiseClone() as DeliveryPost;
        }

        public IPost DeepClone()
        {
            DeliveryPost copy = this.MemberwiseClone() as DeliveryPost;
            copy.City = City.Clone();
            return copy;
        }

        public override bool Equals(object obj)
        {
            return obj is DeliveryPost post &&
                   Id == post.Id &&
                   EqualityComparer<City>.Default.Equals(City, post.City) &&
                   Address == post.Address;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, City, Address);
        }

        public override string ToString()
        {
            string info = "\n=============== Delivery Post Info ==============="
                       + $"\n + Post ID: {Id}"
                       + $"\n + City Location: {City.PostalCode} {City.Name}, {City.AreaISO}"
                       + $"\n + Address: {Address}"
                        + "\n==================================================\n";
            return info;
        }
    }
}
