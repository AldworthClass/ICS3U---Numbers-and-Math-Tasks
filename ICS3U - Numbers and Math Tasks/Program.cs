namespace ICS3U___Numbers_and_Math_Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ICS3U Topic 2 - Numbers and Math Tasks Solutions");
            Console.WriteLine("Task 1");
            Console.WriteLine("You earned " + (8 * 21).ToString("C"));
            Console.WriteLine();
            Console.WriteLine("Task 2");
            // The reason we use 6.0 when dividing is so that C# does floating point arithmetic (has decimals) instead of integer arithmetic (no decimals)
            Console.WriteLine("One egg is " + (6.0/12).ToString("C"));
            Console.WriteLine();
            Console.WriteLine("Task 3");
            Console.WriteLine("The tax on $79.99 is " + (79.88 * 0.13).ToString("C"));
            Console.WriteLine();
            Console.WriteLine("Task 4");
            // adding a backslash '\' allows you to display special characters.  Google Escape Codes in C# for more
            Console.WriteLine("There are " + (5 * 12 + 6) * 2.54 + " centimeters in 5'6\""); 
            Console.WriteLine();


        }
    }
}