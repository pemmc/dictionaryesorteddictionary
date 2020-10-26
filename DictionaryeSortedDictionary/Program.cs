using System;
using System.Collections.Generic;

namespace DictionaryeSortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
