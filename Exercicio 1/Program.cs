using System;

namespace Estruturas_de_repetição
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira um número entre 0 e 10");
            int numero = int.Parse(Console.ReadLine());

            while (numero>10)
            {
                Console.WriteLine("Esse valor é inválido, por favor, insira um valor válido novamente");
                numero = int.Parse(Console.ReadLine());
            }

            while (numero<0)
            {
                Console.WriteLine("Esse valor é inválido, por favor, insira um valor válido novamente");
                numero = int.Parse(Console.ReadLine()); 
            }           
        }
    }
}
