using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddAndRemoveMethods
{
    internal static class ArrayHelper<T>
    {
        public static T[] Add(ref T[] array, T? value)
        {
            T[] newArray = new T[array.Length + 1];
            Array.Copy(array, newArray, array.Length);
            newArray[array.Length] = value;
            return newArray;
        }
        public static T[] Remove(ref T[] array, T? value)
        {
            int index = Array.IndexOf(array, value);
            if (index == -1) return array;

            T[] newArray = new T[array.Length - 1];
            Array.Copy(array, 0, newArray, 0, index);
            Array.Copy(array, index + 1, newArray, index, array.Length - index - 1);

            return newArray;
        }
    }
}
