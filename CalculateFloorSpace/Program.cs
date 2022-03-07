using System;

namespace CalculateFloorSpace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double unit_price, total_price = 0, total_area = 0, hourly_cost = 86,
            maximum_flooring_per_hour = 20, material_costs = 0, pi = Math.PI,
            triangle_base, triangle_height;

            string floor_type;

            Console.WriteLine("Please choose your floor type: 'c' circle, 'r' rectangle, 't' triangle: ");
            floor_type = Console.ReadLine();
            

            if (floor_type == "r")
            {
                Console.WriteLine(" Please enter the length : ");
                float length = float.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the width : ");
                float width = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the cost per unit : ");
                unit_price = Convert.ToDouble(Console.ReadLine());

                total_area = length * width;
                material_costs = unit_price * total_area;
                total_price = total_area / maximum_flooring_per_hour * hourly_cost + material_costs;
            }

            if (floor_type == "c")
            {
                Console.WriteLine(" Please enter the radius: ");
                float radius = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter the cost per unit : ");
                unit_price = Convert.ToDouble(Console.ReadLine());

                total_area = pi * radius * radius;
                material_costs = unit_price * total_area;
                total_price = total_area / maximum_flooring_per_hour * hourly_cost + material_costs;    
            }
            if (floor_type == "t")
            {
                Console.WriteLine("Please enter the base");
                triangle_base = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the height");
                triangle_height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the cost per unit : ");
                unit_price = Convert.ToDouble(Console.ReadLine());

                total_area = triangle_base * triangle_height / 2;
                material_costs = unit_price * total_area;
                total_price = total_area / maximum_flooring_per_hour * hourly_cost + material_costs;

            }
            Console.WriteLine("Total price $ " + total_price);
            Console.ReadKey();
        }
    }
}