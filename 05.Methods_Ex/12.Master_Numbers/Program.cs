using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Master_Numbers
{
	class Program
	{
		static bool IsPalindrome(int number)
		{
			int n = number; 
			int rev = 0;

			while (n > 0)
			{
				int dig = n % 10;
				rev = rev * 10 + dig;
				n = n / 10;
			}

			if (number == rev)
				return true;

			return false;
		}

		static bool IsSumOfDigitsDevidedBySeven(int number)
		{
			int sumOfNumbers = 0;

			while (number > 0)
			{
				sumOfNumbers += number % 10;
				number = number / 10;
			}

			if (sumOfNumbers % 7 == 0)
				return true;

			return false;
		}

		static bool HasEventDigit(int number)
		{
			while (number > 0)
			{
				if (number % 2 == 0)
					return true;
				number = number / 10;
			}
			return false;
		}
		static void Main(string[] args)
		{
			int numbers = int.Parse(Console.ReadLine());
			for (int i = 1; i <= numbers; i++)
			{
				if (IsPalindrome(i))
					if (IsSumOfDigitsDevidedBySeven(i))
						if (HasEventDigit(i))
							Console.WriteLine(i);
			}
		}
	}
}
