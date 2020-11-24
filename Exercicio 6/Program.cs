using System;

namespace Exercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 10 nomes");
            string[] nomes = new string[3];

            for (var contador = 0; contador < nomes.Length; contador++)
            {
                Console.WriteLine("Digite o nome "+contador);
                nomes[contador] = Console.ReadLine();
            } 

            Console.WriteLine("Digite o nome procurado");
            string presquisa = Console.ReadLine();

            for (var contador = 0; contador < nomes.Length; contador++)
            {
                   if (presquisa == nomes[contador])
                    {
                        Console.WriteLine("ACHEEI!");
                    }
            }

            
                       
        }
    }
}
