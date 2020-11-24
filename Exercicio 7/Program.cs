using System;

namespace Exercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numero");
            int[] numeros = new int [6];

            for (var contador = 0; contador < numeros.Length; contador++)
            {
                Console.WriteLine("Digite o numero "+contador);
                numeros[contador] = int.Parse(Console.ReadLine());

                Console.WriteLine();
            } 
            Console.WriteLine(numeros[4], numeros[3], numeros[2], numeros[1], numeros[0]);
            
        }
    }
}
