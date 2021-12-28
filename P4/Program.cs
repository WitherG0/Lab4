using System;

namespace P4
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.Write("Выберите способ: \"array\" или \"string\" ");
			string way = Console.ReadLine();
			switch (way)
			{
				case "array":
					first_way_4();
					break;
				case "string":
					second_way_4();
					break;
				default:
					break;
			}
			Console.ReadKey();
		}
		static void first_way_4()
		{
			int length = 7, number = 1;
			string[] s = new string[length];
			for (int i = 0; i < s.Length; i++)
			{
				Console.Write(number + ". ");
				Console.WriteLine("Enter the string: ");
				s[i] = Console.ReadLine();
				number++;
			}
			
			number = 1;
			foreach (string str in s)
			{
				string tempString = str.ToLower();
				char[] chars = tempString.ToCharArray();
				Console.WriteLine();
				if (chars.Length > 3 && chars[chars.Length - 1] == 'm' && chars[chars.Length - 2] == 'o' && chars[chars.Length - 3] == 'c' && chars[chars.Length - 4] == '.')
				{
					Console.Write(number + ". ");
					Console.WriteLine(str);
				}
				else if (chars.Length > 4 && Char.IsPunctuation(chars[chars.Length - 1]) && chars[chars.Length - 2] == 'm' && chars[chars.Length - 3] == 'o' && chars[chars.Length - 4] == 'c' && chars[chars.Length - 5] == '.')
				{
					Console.Write(number + ". ");
					Console.WriteLine(str);
				}
				else
				{
					for (int i = 0; i < chars.Length; i++)
					{
						if (i < chars.Length - 5)
						{
							if ((chars[i] == '.' && chars[i + 1] == 'c' && chars[i + 2] == 'o' && chars[i + 3] == 'm') && (Char.IsSeparator(chars[i + 4]) || Char.IsPunctuation(chars[i + 4])) && (chars[i + 5].Equals("") || Char.IsSeparator(chars[i + 5]) || Char.IsPunctuation(chars[i + 5])))
							{
								Console.Write(number + ". ");
								Console.WriteLine(str);
							}
						}
					}
				}
				number++;
			}
		}
		static void second_way_4()
		{
			int length = 7, number;
			string[] s = new string[length];
			string[] sLower = new string[length];
			for (int i = 0; i < s.Length; i++)
			{
				number = i + 1;
				Console.Write(number + ". ");
				Console.WriteLine("Enter the string: ");
				s[i] = Console.ReadLine();
				Console.WriteLine();
				sLower[i] = s[i].ToLower();
			}
			Console.WriteLine();
			Console.WriteLine("Strings that contains \".com\":\n");
			for (int i = 0; i < sLower.Length; i++)
			{
				string[] sLowerWords = sLower[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
				for (int j = 0; j < sLowerWords.Length; j++)
				{
					if (sLowerWords[i].EndsWith(".com") || sLowerWords[i].EndsWith(".com.") || sLowerWords[i].EndsWith(".com,"))
					{
						number = i + 1;
						Console.Write(number + ". ");
						Console.WriteLine(s[i] + "\n");
					}
				}
			}
			Console.WriteLine();
			int spaces = s[0].LastIndexOf(" ");
			int numOfStr = 0;
			for (int i = 0; i < s.Length; i++)
			{
				if (spaces > s[i].LastIndexOf(" "))
				{
					spaces = s[i].LastIndexOf(" ");
					numOfStr = i;
				}
			}
			Console.WriteLine("String with the smallest number of spaces: ");
			Console.WriteLine(s[numOfStr]); Console.WriteLine("Hello World!");
        }
    }
}
