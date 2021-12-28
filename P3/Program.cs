using System;

namespace P3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the string: ");
			string s = Console.ReadLine();
			first_way_3(s);
			Console.WriteLine(" ");
			second_way_3(s);
			static void first_way_3(string s)
			{
				
				string[] words = new string[s.Length];
				char[] trigger = { ' ' };
				int counter = 0;

				for (int i = 0; i < s.Length; i = s.IndexOfAny(trigger, i) + 1)
				{
					if (counter == 0)
					{
						s += " ";
					}
					for (int j = i; j != s.IndexOfAny(trigger, i) && j < s.Length; j++)
					{
						words[counter] += s[j];
					}
					counter++;
				}
				Array.Resize(ref words, counter);
				Array.Reverse(words);
				foreach (string word in words)
				{
					Console.Write(word + " ");
				}
				
			}
			static void second_way_3(string s)
			{
				string[] str = s.Split(new char[] { ' ', '.' }, StringSplitOptions.RemoveEmptyEntries);
				Array.Reverse(str);
				for (int i = 0; i < str.Length; i++)
				{
					if (i == str.Length - 1)
						Console.Write(str[i] + ".");
					else
						Console.Write(str[i] + " ");
				}
			}
		}
	}
}