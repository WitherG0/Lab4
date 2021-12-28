using System;
using System.Text.RegularExpressions;

namespace P5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение: ");
            string s = Console.ReadLine();
			Console.WriteLine("------------------");

			first_way_5(s);
			Console.WriteLine("------------------");
			second_way_5(s);
			static void first_way_5(string s)
			{
				string[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
				for (int i = 0; i < words.Length; i++)
				{
					string word = words[i];
					if (Char.IsUpper(word[0]) && Char.IsNumber(word[word.Length - 1]) && Char.IsNumber(word[word.Length - 2]))
					{
						Console.WriteLine(words[i]);
					} else
                    {
						Console.WriteLine("Совпадений не найдено");
					}
				}
			}
			static void second_way_5(string s)
			{
				int k = 0;
				Regex regex = new Regex(@"\b[А-Я](\w*)+\d{2}\b");
				MatchCollection words = regex.Matches(s);
				if (words.Count > 0)
				{
					foreach (Match match in words)
						Console.WriteLine(match.Value);
				}
				else
				{
					k = 1;
				}
				Regex regex1 = new Regex(@"\b[A-Z](\w*)+\d{2}\b");
				MatchCollection words1 = regex1.Matches(s);
				if (words1.Count > 0)
				{
					foreach (Match match in words1)
						Console.WriteLine(match.Value);
				}
				else
				{
					k = 1;
				}
				if (k == 1) 
				{ 
					Console.WriteLine("Совпадений не найдено"); 
				}
			}
		}
    }
}
