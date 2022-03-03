using System;

namespace ConsoleApp1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length, width, unit_price, total_price;
            Console.WriteLine(" Please enter the length : ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the width : ");
            width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the cost per unit : ");
            unit_price = Convert.ToDouble(Console.ReadLine());

            total_price = length * width * unit_price;
            Console.WriteLine("The total cost is: " + total_price);
            Console.ReadKey();
            //This is my latest attempt
        }
    }
}