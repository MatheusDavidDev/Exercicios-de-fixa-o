using System;

namespace Exercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada");
            //int resultado = 0;
            //int tabuada = 0;

            for (var contador = 0; contador < 11; contador++)
            {
                Console.WriteLine("-------------");
                Console.WriteLine("Tabuada do "+contador);
                for (var tabuada = 0; tabuada < 11; tabuada++)
                {
                    int resultado = contador * tabuada;
                    Console.WriteLine(+contador+ " X "+tabuada+ " = " +resultado );
                }
            }
        }
    }
}
