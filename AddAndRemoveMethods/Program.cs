namespace AddAndRemoveMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] myArray = { "Kamran", "Bextiyar", "Paytaxt", "Torpaq", "Americooo", "Amsterdam" };

            ArrayHelper<string>.Add(ref myArray, "Fransa");
            ArrayHelper<string>.Add(ref myArray, "Ukraine");

            ArrayHelper<string>.Remove(ref myArray, "Bextiyar");
            ArrayHelper<string>.Remove(ref myArray, "Paytaxt");
            ArrayHelper<string>.Remove(ref myArray, "Torpaq");

            foreach (string item in myArray)
            {
                Console.WriteLine(item);
            }

        }
    }
}