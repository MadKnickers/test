using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace NoahsArk
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animals = System.IO.File.ReadAllLines(@"animals.txt");
            foreach (var animal in animals)
            {
                System.Console.WriteLine(animal);
            }
            System.Console.ReadLine();
        }
    }
}
