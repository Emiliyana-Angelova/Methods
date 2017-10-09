using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fibonacci_Numbers
{
	class Program
	{
		static int Fibonacci(int number)
		{
			int f0 = 1;
			int f1 = 1;

			for (int i = 0; i < number - 1; i++)
			{
				var fNext = f0 + f1;
				f0 = f1;
				f1 = fNext;
			}
			return f1;
		}

		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());
			int result = Fibonacci(number);

			Console.WriteLine(result);			
		}
	}
}
