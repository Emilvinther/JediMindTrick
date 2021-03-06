using System;
using System.Collections.Generic;

namespace JediMindTrick
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Dictionary<String, int> names = new Dictionary<String, int>();
            names.Add("Emil", 28);
            names["Frederik"] = 26;

            foreach (var pair in names)
            {
                Console.WriteLine("Found: " + pair.Value + ", with key: " + pair.Key);
            }

            Dictionary<String,bool> characters = new Dictionary<String,bool>()
            {
                {"Luke", true },
                {"Han", false },
                {"Chewbakka", false }
            };

            characters.Remove("Han");

            foreach (var pair in characters)
            {
                Console.WriteLine("Found: " + pair.Value + ", with key: " + pair.Key);
            }



            Console.ReadKey();
        }
    }
}
