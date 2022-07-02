using System;
using System.Collections.Generic;

namespace DictionatyExample
{
    class Program
    {
        static void Main(string[] args)
        {
            const int CAPACITY = 20;
            
            List<int> list = new List<int>(CAPACITY);

            Random random = new Random();

            for (int i = 0; i < 20; ++i)
            {
                list.Add(random.Next(0, 10));
            }

            Console.WriteLine($"[ {string.Join(",", list)} ]");

            Dictionary<int, bool> dictionary = new Dictionary<int, bool>();

            for (int i = 0; i < list.Count; ++i)
            {
                if (dictionary.ContainsKey(list[i]))
                {
                    list.Remove(list[i]);
                }
                else
                {
                    dictionary.Add(list[i], true);
                }
            }

            Console.WriteLine($"[ {string.Join(",", list)} ]");
        }
    }
}