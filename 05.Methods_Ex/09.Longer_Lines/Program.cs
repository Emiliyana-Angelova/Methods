using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Longer_Lines
{
	class Program
	{
		static double Pitagor(double a, double b)

		{
			return Math.Sqrt((a * a) + (b * b));
		}

		static double distanceBetweentTwoPoints(double x1, double y1, double x2, double y2)

		{
			return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
		}

		static void Main(string[] args)
		{
			double x1 = double.Parse(Console.ReadLine());
			double y1 = double.Parse(Console.ReadLine());
			double x2 = double.Parse(Console.ReadLine());
			double y2 = double.Parse(Console.ReadLine());
			double x3 = double.Parse(Console.ReadLine());
			double y3 = double.Parse(Console.ReadLine());
			double x4 = double.Parse(Console.ReadLine());
			double y4 = double.Parse(Console.ReadLine());

			double line1 = distanceBetweentTwoPoints(x1, y1, x2, y2);
			double line2 = distanceBetweentTwoPoints(x3, y3, x4, y4);

			if (line1 >= line2)
			{
				if (Pitagor(x1, y1) <= Pitagor(x2, y2))
				{
					Console.WriteLine("({0}, {1})({2}, {3})", x1, y1, x2, y2);
				}
				else
				{
					Console.WriteLine("({0}, {1})({2}, {3})", x2, y2, x1, y1);
				}

			}

			else
			{
				if (Pitagor(x3, y3) <= Pitagor(x4, y4))
				{
					Console.WriteLine("({0}, {1})({2}, {3})", x3, y3, x4, y4);
				}
				else
				{
					Console.WriteLine("({0}, {1})({2}, {3})", x4, y4, x3, y3);
				}
			}
		}
	}
}
