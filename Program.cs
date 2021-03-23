using System;

namespace Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            String palavra;
            
            Console.Write("Digite uma frase contendo r:");
            palavra = Console.ReadLine();
            Console.WriteLine();
            Console.Write($"{palavra.Replace("rr","l").Replace("rR","l").Replace("RR","L").Replace("Rr","L").Replace("R","L").Replace("r"  , "l"  )} ");
            
        
        }
    }
}
