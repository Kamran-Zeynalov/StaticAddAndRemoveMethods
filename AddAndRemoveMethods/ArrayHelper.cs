using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace AddAndRemoveMethods
{
    internal static class ArrayHelper<T>
    {
        public static T[] Add(ref T[] array, T? value)
        {
            Array.Resize(ref array, array.Length + 1);
            array[^1] = value;
            return array;
        }
        public static T[] Remove(ref T[] array, T? value)
        {
            int index = Array.IndexOf(array, value);
            if (index == -1)
            {
                return array;
            }

            for (int i = index; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }

            Array.Resize(ref array, array.Length - 1);

            return array;
        }
    }
}
