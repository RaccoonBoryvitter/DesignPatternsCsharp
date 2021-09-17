using System;
using System.Collections.Generic;

namespace AbstractFactory.Helpers
{
    internal class ListRandomPicker
    {
        public static T PickFromList<T>(List<T> list) where T : class
        {
            int index = new Random().Next(list.Count);
            return list[index];
        }
    }
}
