using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_14_09_2023
{
    internal class Class1
    {
        public int Suma1(int a,int b)
        {
            Console.WriteLine("El resultado de la suma es: ");
            return a + b;
        }
        public int multiplicar1(int a, int b)
        {
            Console.WriteLine("El resultado de la multiplicacion es: ");
            return a*b;
        }
        public void dividir1(int a, int b)
        {


            if (b == 0)
            {
                do
                {
                    Console.WriteLine("Error, no se puede dividir por 0");

                    Console.WriteLine("Digite otro numero para el denominador");
                    b = int.Parse(Console.ReadLine());


                } while (b == 0);

            }

            Console.WriteLine("El resultado de la division es: ");
            Console.WriteLine(a / b);

        }


    }
}
