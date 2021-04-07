using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ConversõesEOutrosTiposNuméricos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario = 1200.50;
            //cast = para fazer a conversão por exemplo de um número double para int podemos colocar entre parênteses o (int) antes da variável
            //o int é um tipo de variável de 32 bits
            int salarioEmInteiro = (int)salario;

            Console.WriteLine(salarioEmInteiro);

            //O long é um tipo de variável de 64 bits
            long idade = 13000000000000000;
            Console.WriteLine(idade);

            //O short é um tipo de variável de 16 bits;
            short compras = 200;
            Console.WriteLine(compras);

            //o Float é um tipo de variável que aceita um número de casas decimais muito pequeno. É pouco utilizado e exige que eu coloque a letra 'f' depois do valor atribuído a ele
            float altura = 1.60f;
            Console.WriteLine(altura);

            Console.ReadLine();
        }
    }
}
