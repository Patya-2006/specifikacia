using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввести четырехзначные числа которые при делении на 133 дают в остатке 125,а при делении на 134 дают в остатке 111:");
                for(int i = 1000; i <= 9999; i++)
               {
                 if(i%133==125 && i%134==111)
                {

                Console.WriteLine(i);
                   Console.ReadKey();
                }
                }
            }
        }
    }

