using System;

namespace CalculateFloorSpace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double unitPrice, total = 0, totalArea = 0, hourlyCost = 86,
            maximumFlooringPerHour = 20, materialCosts = 0, pi = Math.PI,
            triangleBase, triangleHeight;

            string floorType;

            Console.WriteLine("Please choose your floor type: 'C' circle, 'R' rectangle, 'T' triangle: ");
            floorType = Console.ReadLine().ToUpper();


            if (floorType == "R")
            {
                Console.WriteLine(" Please enter the length : ");
                float length = float.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the width : ");
                float width = float.Parse(Console.ReadLine());
                totalArea = length * width;

            }

            if (floorType == "C")
            {
                Console.WriteLine(" Please enter the radius: ");
                float radius = float.Parse(Console.ReadLine());
                totalArea = pi * radius * radius;

            }
            if (floorType == "t")
            {
                Console.WriteLine("Please enter the base");
                triangleBase = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the height");
                triangleHeight = Convert.ToDouble(Console.ReadLine());

                totalArea = triangleBase * triangleHeight / 2;


            }
            Console.WriteLine("Enter the cost per unit : ");
            unitPrice = Convert.ToDouble(Console.ReadLine());

            materialCosts = unitPrice * totalArea;
            total = totalArea / maximumFlooringPerHour * hourlyCost + materialCosts;

            Console.WriteLine("Total price $ " + total);
            Console.ReadKey();
        }
    }
}