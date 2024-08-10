using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaListTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ▼ Greeting ▼
            Console.WriteLine(" ▼ Please write coffee names that you want list ▼ ");

            // ▼ Creating coffee generic list and taking names from user with for loop ▼
            List<string> coffeeList = new List<string>();
            for (int i = 1; i < 6; i++)
            {
                Console.Write($"Coffee {i}:");
                string userInput=Console.ReadLine();
                coffeeList.Add(userInput);
            }

            // ▼ Printing all coffee in coffee list ▼
            Console.WriteLine("▼ Names of coffee you entered ▼");
            foreach (string coffee in coffeeList)
            {
                Console.WriteLine(coffee);
            }
        }
    }
}
