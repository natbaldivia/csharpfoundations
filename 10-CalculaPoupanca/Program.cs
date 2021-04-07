using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CalculaPoupanca
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 10 - calcula poupança");

            double valorInvestido = 1000;

            //0,36% = 0,0036 (taxa de rendimento da poupança)
            //valorInvestido = valorInvestido + valorInvestido * 0.0036;
            //Console.WriteLine("Após um mês você terá R$" + valorInvestido);

            //inicializando e declarndo variável
            int contadorMes = 1;

            //definindo condição do while
            while (contadorMes <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após " + contadorMes + "meses, você terá R$" + valorInvestido);

                //incrementando à variável.
                //contadorMes = contadorMes + 1;
                //contadorMes += 1;
                contadorMes++;
            }

            Console.ReadLine();
        }
    }
}
