using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();

            string more = "Y";

            while (more=="Y")
            {
                Console.WriteLine("Unesite ne znam, neki broj: ");

                lista.Add(int.Parse(Console.ReadLine()));
                Console.WriteLine("Jos unosa?");
                more = Console.ReadLine();
                if (more == "Y")
                {
                    continue;
                }
                else
                {
                    break;
                }
                                
            }//while end

            Console.WriteLine("Unjeli ste:");

            foreach (int a in lista)    
            {
                Console.WriteLine(a);
            }

            Console.ReadKey();



        }
    }
}
