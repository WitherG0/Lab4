using System;

namespace P1
{
    class Program
    {
        static void Main(string[] args)
        {

            int k = 0;
            int p = 0;
            string s = "Привет мир.";
            foreach (char c in s)
            {
                k++;
            }
            
            char[] a = new char[k];
            foreach (char c in s)
            {
                a[p] = c;
                p++;
            }
            System.Collections.ArrayList unique = new System.Collections.ArrayList();

            for (int i = 0; i < a.Length; i++)
                if (unique.IndexOf(a[i]) == -1)
                    unique.Add(a[i]);

            
            for (int i = 0; i < unique.Count; i++)
                Console.WriteLine(unique[i] + " ");

            Console.ReadKey(true);
        }

    }
}
