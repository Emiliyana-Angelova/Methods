using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Primes_In_Given_Range
{
	class Program
	{
		static bool IsPrime(int n)
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

		static List<int> FindPrimesInRange(int startNum, int endNum)

		{
			List<int> primeDigitsInRange = new List<int>();

			for (int i = startNum; i <= endNum; i++)
			{
				if (IsPrime(i))
					primeDigitsInRange.Add(i);
			}

			return primeDigitsInRange;
		}

		static void Main(string[] args)
		{
			int numberStart = int.Parse(Console.ReadLine());
			int numberEnd = int.Parse(Console.ReadLine());

			List<int> range = FindPrimesInRange(numberStart, numberEnd);
			System.Console.WriteLine(String.Join(", ", range.ToArray()));
		}
	}
}
