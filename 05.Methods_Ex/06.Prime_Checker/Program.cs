using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Prime_Checker
{
	class Program
	{
		static bool IsPrime(Int64 n)
		{
			if (n <= 1)
				return false;

			for (int i = 2; i <= Math.Sqrt(n); i++)
			{
				if (n % i == 0)
				{
					return false;
				}
			}
			return true;
		}

		static void Main(string[] args)
		{
			{
				Int64 input = Int64.Parse(Console.ReadLine());

				Console.WriteLine(IsPrime(input));
			}
		}
	}
}
