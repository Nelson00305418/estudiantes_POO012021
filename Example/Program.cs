using System;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c =0;

            Console.WriteLine("Enter a value:");
            a = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter another value:");
            b = Int32.Parse(Console.ReadLine());

            //se modifico el nombre del metodo sum a AddNumbers
            Console.WriteLine($"Multiplying the values of {b} to {a} give: {AddNumbers(a,b)}");
            
        }

        //changed the method to do a multiplying instead of subtracting (TaskA)
        public static int AddNumbers(int a, int b)
        {
            return a * b;
        }
    }
}
