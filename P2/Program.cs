using System;

namespace P2
{
    class Program
    {
        static void Main(string[] args)
        {
			
				Console.WriteLine("Введите предложение: ");
			string s = Console.ReadLine();
			first_way_2(s);
			second_way_2(s);
		}
			static void first_way_2(string s)
			{
				int counter = 0;
				for (int i = 0; i < s.Length; i++)
				{
					if (Char.IsLetter(s[i]) && (s[i + 1] == ' ' || s[i + 1] == '-' || s[i + 1] == '.' || s[i + 1] == ','))
					{
						Console.Write("{0}({1})", s[i], ++counter);
					}
					else
					{
						Console.Write(s[i]);
					}
				}
				Console.WriteLine();
			}
			static void second_way_2(string s)
			{
				string[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
				int counter = 1;
				for (int i = 0; i < words.Length; i++)
				{
					if (words[i].EndsWith(",") || words[i].EndsWith("."))
					{
						words[i] = words[i].Insert(words[i].Length, "(" + (counter) + ")");
					}
					else if (words[i] == "-" || words[i] == " ") continue;
					else
					{
						words[i] = words[i].Insert(words[i].Length, "(" + (counter) + ") ");
					}
					counter++;
				}
				foreach (String str in words)
					Console.Write(str);
				Console.WriteLine();
			}
		}
    }

