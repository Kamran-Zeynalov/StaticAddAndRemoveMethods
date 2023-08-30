namespace AddAndRemoveMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] myArray = { "Kamran", "Elvin", "Ramiz" };
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Orginal Array");
            Console.ForegroundColor = ConsoleColor.White;

            foreach (string s in myArray)
            {
                Console.WriteLine(s);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("New Array After Add");
            Console.ForegroundColor = ConsoleColor.White;

            string newItem = "Cemil";
            string[] newArrayAdded = ArrayHelper<string>.Add(ref myArray, newItem);

            foreach (string item in newArrayAdded)
            {
                Console.WriteLine(item);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("New Array After Remove");
            Console.ForegroundColor = ConsoleColor.White;

            string removeItem = "Kamran";
            string[] newArrayRemoved = ArrayHelper<string>.Remove(ref myArray, removeItem);

            foreach (string item in newArrayRemoved)
            {
                Console.WriteLine(item);
            }

        }
    }
}