using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 5 - Caracteres e Textos");

            //character 16 bits
            char primeiraLetra = 'a';
            Console.WriteLine(primeiraLetra);

            //texto
            string titulo = "Alura Cursos de Tecnologia";
            Console.WriteLine(titulo);

            string vazio = "";
            Console.WriteLine(vazio);

            // o '@' permite que eu pule linhas num mesmo texto
            string listaCursos = @"
 - .NET
 - JAVA
 - Javascript";
            Console.WriteLine(listaCursos);

            string saudacao = "Olá, meu nome é ";
            string nome = "Natalia ";
            string continuacao = "e minha idade é ";
            int idade = 29;
            Console.WriteLine(saudacao + nome + continuacao + idade);

            Console.ReadLine();
        }
    }
}
