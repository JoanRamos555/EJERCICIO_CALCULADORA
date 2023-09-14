using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Clase_14_09_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool t = false;
            do
            {
                t = false;
                String b;
                int x;
                int y;

                Console.WriteLine("Digite un numero");
                x = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite un numero");
                y = int.Parse(Console.ReadLine());

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Suma");

                Class1 opera = new Class1();
                int total1 = opera.Suma1(x, y);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(total1);
    

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Multiplicacion");
                int total2 = opera.multiplicar1(x, y);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(total2);

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Division");

                Class1 opera3 = new Class1();
                opera.dividir1(x, y);
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("Desea volver a operar?");

                b = Console.ReadLine();


                if (b=="no")
                {
                    t = true;
                }
                else
                {
                    t = false;
                }
                Console.ForegroundColor = ConsoleColor.White;

            } while (t==false);

        }
    }
}
