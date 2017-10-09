using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Max_Method
{
	class Program
	{
		public static int GetMax(int a, int b)
		{
			if (a > b)
			{
				return a;
			}
			return b;
		}

		static void Main(string[] args)
		{
			int num1 = int.Parse(Console.ReadLine());
			int num2 = int.Parse(Console.ReadLine());
			int num3 = int.Parse(Console.ReadLine());

			int max1 = GetMax(num1, num2);
			int max2 = GetMax(max1, num3);

			Console.WriteLine(max2);
		}
	}
}
