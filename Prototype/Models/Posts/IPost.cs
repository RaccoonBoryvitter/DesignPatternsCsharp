using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Models.Posts
{
    internal interface IPost
    {
        string Id { get; }
        City City { get; set; }
        string Address { get; set; }
        string ToString();
        IPost Clone();
        IPost DeepClone();
    }
}
