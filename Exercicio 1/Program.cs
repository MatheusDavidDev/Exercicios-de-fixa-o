using System;

namespace Exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada
            Console.WriteLine("Digite seu ano de nascimento");
            int ano = int.Parse(Console.ReadLine());

            //Processamento 
            int idade = 2020 - ano;

            //Exibicao
            if (idade >= 18)
            {
                Console.WriteLine("Voce podera votar esse ano!");
            }else
            {
                Console.WriteLine("Voce NAO poder votar esse ano!");
            }

        }
    }
}
