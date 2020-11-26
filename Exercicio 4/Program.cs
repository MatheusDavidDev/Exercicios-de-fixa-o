using System;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {   
            int[] valores = new int[10];
            //int a;
            int maior = 0;
            int menor = 0;

            Console.WriteLine("Digite 10 valores");

            for (var contador = 0; contador < 10; contador++)
            {   
                Console.WriteLine($"Digite o valor {contador}");
                valores[contador] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("Voce digitou esses numeros");

            for (var contador = 0; contador < 10; contador++)
            {
                Console.Write(+valores[contador]+", ");
                if (contador==0){maior=valores[contador]; menor=valores[contador];}
                if (valores[contador]>maior)
                {
                    maior = valores[contador];
                }
                else{
                    if (valores[contador] <menor)
                    {
                        menor=valores[contador];
                    }
                }

            }
                Console.WriteLine("O maior valor digitado e de: "+maior );
                Console.WriteLine("O menor valor digitado e de: "+menor );

        }
    }
}
