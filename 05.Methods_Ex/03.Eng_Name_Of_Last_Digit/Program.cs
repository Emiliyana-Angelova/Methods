using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Eng_Name_Of_Last_Digit
{
	class Program
	{
		static string NameOfLastDigit(int input)
		{
			if (input == 0)
			{
				return "zero";
			}

			else if (input == 1)
			{
				return "one";
			}

			else if (input == 2)
			{
				return "two";
			}

			else if (input == 3)
			{
				return "three";
			}

			else if (input == 4)
			{
				return "four";
			}

			else if (input == 5)
			{
				return "five";
			}

			else if (input == 6)
			{
				return "six";
			}

			else if (input == 7)
			{
				return "seven";
			}

			else if (input == 8)
			{
				return "eight";
			}

			else if (input == 9)
			{
				return "nine";
			}

			return " ";
		}

		static void Main(string[] args)
		{
			Int64 input = Int64.Parse(Console.ReadLine());

			input = Math.Abs(input);

			int lastDigit = Convert.ToInt32(input % 10);

			string DigitToWord = NameOfLastDigit(lastDigit);

			Console.WriteLine(DigitToWord);


			/*string input = Console.ReadLine();

			string lastDigitToChar = input.Substring(input.Length - 1);

			int lastDigitToInt = Convert.ToInt32(lastDigitToChar);

			string resultToPrint = NameOfLastDigit(lastDigitToInt);

			Console.WriteLine(resultToPrint);*/
		}
	}
}  
