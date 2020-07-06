using System;

namespace SouthReplace
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.WriteLine("Digite a palavra a deformar (Somente letras).:");

            var v = Console.ReadLine();
            string result;

            var Deform = new Deform();

            if (!Deform.Deformer(v, out result)) 
            { 
                Console.WriteLine("Palavra informada Inválida. Deseja tentar Novamente?(Y/N)");
                var c = Console.ReadKey();

                if (c.Key == ConsoleKey.Y || c.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    goto start;
                }
                else
                {
                    Environment.Exit(0);
                }  
            }

            Console.WriteLine("##################");
            Console.WriteLine("Palavra informada: {0}", v);
            Console.WriteLine("Palavra deformada: {0}", result);
            Console.WriteLine("##################");
        }

    }

}
   
