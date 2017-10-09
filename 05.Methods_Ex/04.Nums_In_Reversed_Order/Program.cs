using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Nums_In_Reversed_Order
{
	class Program
	{
		static decimal ReverseNumbers(decimal number)
		{
			string numberAsString = Convert.ToString(number);
			string reversDigits = null;

			for (int i = numberAsString.Length - 1; i >= 0; i--)
			{
				reversDigits += numberAsString[i];
			}
			return Convert.ToDecimal(reversDigits);
		}

		static void Main(string[] args)
		{
			decimal input = decimal.Parse(Console.ReadLine());
			decimal result = ReverseNumbers(input);

			Console.WriteLine(result);


			

		}
	}
}
