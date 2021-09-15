using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Models.Posts
{
    internal class DispatchPost : IPost
    {
        public string Id { get; } 

        public City City { get; set; }
        public string Address { get; set; }

        public DispatchPost(City city, string address)
        {
            Id = Guid.NewGuid().ToString();
            City = city;
            Address = address;
        }

        public IPost Clone()
        {
            return this.MemberwiseClone() as DispatchPost;
        }

        public IPost DeepClone()
        {
            DispatchPost copy = this.MemberwiseClone() as DispatchPost;
            copy.City = City.Clone();
            return copy;
        }

        public override bool Equals(object obj)
        {
            return obj is DispatchPost post &&
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
            string info = "\n=============== Dispatch Post Info ==============="
                       + $"\n + Post ID: {Id}"
                       + $"\n + City Location: {City.PostalCode} {City.Name}, {City.AreaISO}"
                       + $"\n + Address: {Address}"
                        + "\n==================================================";
            return info;
        }


    }
}
