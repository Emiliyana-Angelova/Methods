using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Center_Point
{
	class Program
	{
		static double Pitagor(double a, double b)
		{
			return Math.Sqrt((a * a) + (b * b));
		}

		static void Main(string[] args)
		{
			double x1 = double.Parse(Console.ReadLine());
			double y1 = double.Parse(Console.ReadLine());
			double x2 = double.Parse(Console.ReadLine());
			double y2 = double.Parse(Console.ReadLine());

			if (Pitagor(x1, y1) <= Pitagor(x2, y2))
			{
				System.Console.WriteLine("({0}, {1})", x1, y1);
			}
			else
			{
				System.Console.WriteLine("({0}, {1})", x2, y2);
			}
		}
	}
}
