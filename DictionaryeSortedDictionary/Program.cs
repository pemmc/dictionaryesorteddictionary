using System;
using System.Collections.Generic;

using System.IO;

namespace DictionaryeSortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Dictionary<string, string> cookies = new Dictionary<string, string>();


            //add
            cookies.Add("user", "maria");
            cookies.Add("email", "maria@gmail.com");
            cookies.Add("phone", "9999934");

            //ou adiconando... mas agora ele está mudando o valor ehehe
            cookies["user"] = "Paulo";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "9999934";

            //assim dá erro.. só se for a primeira vez... já o outra forma tanto faz
            //cookies.Add("phone", "51 996300850");

            Console.WriteLine(cookies["user"]);
            Console.WriteLine(cookies["phone"]);

            if(cookies.ContainsKey("email"))
            {
                Console.WriteLine("contém a chave e-mail, removendo agora então");

                cookies.Remove("email");

            }

            Console.WriteLine("Size:  " + cookies.Count);

            //KEYVALUEPAIR 
            foreach(KeyValuePair<string, string> item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value );

            }

            //ou apenas o VAR
            foreach (var item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);

            }
            */

            //Windows
            //string path = @"C:\Users\apagar\Projects\DictionaryeSortedDictionary\file.txt";

            //macOS note
            //string path = "/Users/pauloeduardo/Projects/DictionaryeSortedDictionary/file.txt";

            //macOS PC
            string path = "/Users/nxgames/Projects/DictionaryeSortedDictionary/file.txt";

            Console.WriteLine("Full path: " + path);

            //214. Exercício proposto sobre Dictionary

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {

                    Dictionary<string, int> dictionary = new Dictionary<string, int>();

                    while (!sr.EndOfStream)
                    {

                        string[] votingRecord = sr.ReadLine().Split(',');
                        string candidate = votingRecord[0];
                        int votes = int.Parse(votingRecord[1]);

                        if (dictionary.ContainsKey(candidate))
                        {
                            dictionary[candidate] += votes;
                        }
                        else
                        {
                            dictionary[candidate] = votes;
                        }
                    }

                    foreach (var item in dictionary)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

        }
    }
}
