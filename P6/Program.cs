using System;
using System.Text.RegularExpressions;

namespace P6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите пример вида «15 + 36 = 51»: ");
			string s = Console.ReadLine();
			Regex numbers = new Regex(@"-?\d+");
			MatchCollection nums = numbers.Matches(s);
			foreach (Match match in nums)
			{
				int num = int.Parse(match.Value);
				Console.WriteLine(num + "\a  ");
			}
			Console.ReadKey();
		}
    }
}
