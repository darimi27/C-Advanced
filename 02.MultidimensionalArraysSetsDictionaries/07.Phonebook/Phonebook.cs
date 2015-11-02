using System;
using System.Collections.Generic;
using System.Linq;
class Phonebook
{
    static void Main()
    {
        Dictionary<string, string> phonebook = new Dictionary<string, string>();
        var input = Console.ReadLine();
        List<string> temp = new List<string>();
        do
        {
            while (input != "search")
            {
                temp = input.Split('-').ToList();
                phonebook.Add(temp[0], temp[1]);
                temp.Clear();
                input = Console.ReadLine();
            }
            var search = Console.ReadLine();
            if (phonebook.ContainsKey(search))
            {

                Console.WriteLine("{0} -> {1}", search, phonebook[search]);
            }
            else
            {
                Console.WriteLine("Contact {0} does not exist.", search);

            }
        } while (true);

    }
}

