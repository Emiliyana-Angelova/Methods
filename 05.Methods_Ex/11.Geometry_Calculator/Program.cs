using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Geometry_Calculator
{
	class Program
	{
		static double TriangleArea(double side, double height)
		{
			return ((side * height) / 2);
		}

		static double SquareArea(double side)
		{
			return (side * side);
		}

		static double RectangleArea(double sideA, double sideB)
		{
			return (sideA * sideB);
		}

		static double CircleArea(double radius)
		{
			return (Math.PI * (radius * radius));
		}

		static void Main(string[] args)
		{
			string figureType = Console.ReadLine().ToLower();
			double area = 0.00d;

			if (figureType == "triangle")
			{
				double side = double.Parse(Console.ReadLine());
				double height = double.Parse(Console.ReadLine());

				area = TriangleArea(side, height);
			}

			else if (figureType == "rectangle")
			{
				double sideA = double.Parse(Console.ReadLine());
				double sideB = double.Parse(Console.ReadLine());

				area = RectangleArea(sideA, sideB);
			}

			else if (figureType == "square")
			{
				double side = double.Parse(Console.ReadLine());

				area = SquareArea(side);
			}

			else if (figureType == "circle")
			{
				double radius = double.Parse(Console.ReadLine());

				area = CircleArea(radius);
			}

			Console.WriteLine("{0:f2}", area);
		}
	}
}
