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
            } 

            int[] numerosInver = new int[numeros.Length];
            
            for (var contador = 0; contador < numeros.Length; contador++)
            {
                numerosInver[contador] = numeros[numeros.Length -1 -contador];
            }

            for (var contador = 0; contador < numerosInver.Length; contador++)
            {
                int invertido = numerosInver[contador];
                Console.WriteLine($"a sequenci invertida e de: {invertido}");
            }

            
        }
    }
}
