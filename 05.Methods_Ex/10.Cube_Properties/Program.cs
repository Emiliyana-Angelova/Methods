using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cube_Properties
{
	class Program
	{
		static double CubeFace(double side)
		{
			return Math.Sqrt(2 * Math.Pow(side, 2));
		}

		static double CubeSpace(double side)
		{
			return Math.Sqrt(3 * Math.Pow(side, 2));
		}

		static double CubeVolume(double side)
		{
			return Math.Pow(side, 3);
		}
		static double CubeArea(double side)
		{
			return 6 * Math.Pow(side, 2);
		}

		static void Main(string[] args)
		{
			double input = double.Parse(Console.ReadLine());
			string parameter = Console.ReadLine().ToLower();
			double result = 0.0;

			switch (parameter)
			{
				case "face":
					result = CubeFace(input);
					break;
				case "space":
					result = CubeSpace(input);
					break;
				case "volume":
					result = CubeVolume(input);
					break;
				case "area":
					result = CubeArea(input);
					break;
			}

			Console.WriteLine("{0:f2}", result);
		}

	}
}
