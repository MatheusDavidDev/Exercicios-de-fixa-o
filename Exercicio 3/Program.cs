using System;

namespace Exercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Entrada
            Console.WriteLine("Program");
            Console.WriteLine("Qual foi o produto");
            string produto = Console.ReadLine();
            Console.WriteLine("Qual foi a quantidade adquiriada do produto");
            int quantidade = int.Parse(Console.ReadLine());
            Console.WriteLine("Preço unitario do produto");
            double valor = double.Parse(Console.ReadLine());

            //Processamento
            double total = valor * quantidade;
            if (quantidade <= 5)
            {
                double desconto = valor * 2 /100;
                Console.WriteLine($"O valor total da compra do {produto} em {quantidade} unidades é de {total - desconto}");
            }
            else if(quantidade > 5 || quantidade <= 10 )
            {
                double desconto = valor * 3 /100;
                Console.WriteLine($"O valor total da compra do {produto} em {quantidade} unidades é de {total - desconto}");
            }
            else{

                double desconto = valor * 5 /100;
                Console.WriteLine($"O valor total da compra do {produto} em {quantidade} unidades é de {total - desconto}");
            }




        }
    }
}
