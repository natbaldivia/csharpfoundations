using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFinal___Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //Utilize um laço do tipo for para imprimir todos os múltiplos de 3, entre 1 e 100.
            //for (int i = 1; i < 100; i++)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            ////outro jeito de resolver:
            //for (int i = 3; i < 100; i += 3)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();


            //Escreva um for encadeado que imprima a tabuada de cada número
            for (int multiplicador = 0; multiplicador <= 10; multiplicador++)
            {
                for(int contador = 0; contador <= 10; contador++)
                {
                    Console.WriteLine(multiplicador + " * " + contador + " = " + multiplicador * contador);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
