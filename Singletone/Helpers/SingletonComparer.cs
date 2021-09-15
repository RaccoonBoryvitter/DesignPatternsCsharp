using Singleton.Models;
using Singleton.Models.Posts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Helpers
{
    internal class SingletonComparer
    {
        internal static bool CompareBetweenPosts(IPost first, IPost second)
        {
            return first.Statistics == second.Statistics;
        }

        internal static bool CompareWithGlobalPoint(IPost post)
        {
            return DailyStatistics.Instance == post.Statistics;
        }
    }
}
