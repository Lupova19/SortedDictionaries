using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vavedi comanda,contact, nomer ");
            SortedDictionary<string, string> phonebook = new SortedDictionary<string, string>();

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "A")
                {
                    string name = command[1];
                    string phones = command[2];
                    phonebook[name] = phones;
                }
                if (command[0] == "S")
                {
                    string name = command[1];
                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Kontacta {name} ne sashtestvuva.");
                    }
                }
                else if (command[0] == "ListAll")
                {
                    Console.WriteLine("--------------------------------------------");

                    foreach (var item in phonebook)
                    {
                        Console.WriteLine($"{item.Key} -> {item.Value}");
                    }
                }
                else if (command[0] == "END")
                {
                    break;
                }
            }
        }
    }
}
