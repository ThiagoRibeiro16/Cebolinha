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
            Console.Write($"{palavra.Replace("r"  , "l"  )} ");
            
        
        }
    }
}
