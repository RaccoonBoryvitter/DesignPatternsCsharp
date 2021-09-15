using Prototype.Models.Posts;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Helpers
{
    internal class PostRegistry
    {
        public List<IPost> Cache { get; set; }

        public void AddItem(IPost post)
        {
            if (post != null) Cache.Add(post);
            else throw new ArgumentNullException();
        }

        public List<IPost> GetByCityName(string cityName)
        {
            if (!string.IsNullOrEmpty(cityName)) 
                return Cache.Where(item => item.City.Name == cityName).ToList();
            else throw new ArgumentNullException();
        }
    }
}
