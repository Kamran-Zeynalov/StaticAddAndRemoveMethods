internal static class ArrayHelperHelpers
{
    public static T[] Add<T>(ref T[] array, T? value)
    {
        T[] newArray = new T[array.Length + 1];
        Array.Copy(array, newArray, array.Length);
        newArray[array.Length] = value;
        return newArray;
    }
}