using System;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {   
            int[] valores = new int[10];

            Console.WriteLine("Digite 10 valores");

            for (var contador = 0; contador < 10; contador++)
            {   
                Console.WriteLine($"Digite o valor {contador}");
                valores[contador] = int.Parse(Console.ReadLine());
            }
            
            
        }
    }
}
