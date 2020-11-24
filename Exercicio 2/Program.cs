using System;

namespace Exercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //Entrada
            Console.WriteLine("Qual foi o tipo de combustivel ?");
            Console.WriteLine("Digite A = Alcool G = Gasolina");
            string combustivel = Console.ReadLine();
            Console.WriteLine("LITRAGEM");
            double litros = float.Parse(Console.ReadLine());

            double precoA = 4.90;
            double precoG = 5.30;
            

            //Processamento
            switch (combustivel)
            {
                case "A":
                    contaAlcool(precoA, litros);
                    break;

                case "G":    
                    contaGasolina(precoG, litros);
                    break;

                default:
                    break;
            }
            
        }

        static double contaAlcool(double a, double b){
              double valor = a * b;
                    if (b <= 20)
                    {
                        double desconto = valor * 3 /100;
                        Console.WriteLine($"O valor a pagar e de {valor - desconto}");
                    }else
                    {
                        double desconto = valor * 5 /100;
                        Console.WriteLine($"O valor a pagar e de {valor - desconto}");
                    }
                
            return a;
        }
    

        static double contaGasolina(double a, double b){
              double valor = a * b;
                    if (b <= 20)
                    {
                        double desconto = valor * 4 /100;
                        Console.WriteLine($"O valor a pagar e de {valor - desconto}");
                    }else
                    {
                        double desconto = valor * 6 /100;
                        Console.WriteLine($"O valor a pagar e de {valor - desconto}");
                    }
                
            return a;
        }



        
    }
}
