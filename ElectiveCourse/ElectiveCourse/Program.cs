using System;

namespace ElectiveCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();
                int result;
                if (int.TryParse(input, out result))
                {
                    Console.WriteLine("реально число, хорош");
                }
                else
                {
                    Console.WriteLine("не число:(");
                }
            }
        }
    }
}
