using System;

namespace ConsoleApp1 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Cost to cover specified area by length and width
            double length,
                width,
                unit_price,
                total_price, 
                total_area, 
                hourly_cost = 86,
                maximum_flooring_per_hour = 20,
                material_costs;

            
            Console.WriteLine(" Please enter the length : ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the width : ");
            width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the cost per unit : ");
            unit_price = Convert.ToDouble(Console.ReadLine());

            total_area = length * width; //100
            material_costs = unit_price * total_area; // 15*100 = 1500
            //Console.WriteLine("The total cost is $: " + total_price);

            total_price = total_area / maximum_flooring_per_hour * hourly_cost + material_costs;
            Console.WriteLine("The total price is $: " + total_price);
            Console.ReadKey();

        }
    }
}