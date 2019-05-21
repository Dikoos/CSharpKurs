using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            string name = args[0];
            Console.WriteLine("Witaj świecie!");
            Console.WriteLine("Co tam ciekawego?"); // cw tab tab
            Console.WriteLine("eLO, " + args[0]);
            Console.WriteLine("Cześć, " +name);
            foreach (var ZimiennaForeach in args)
            {
                
                Console.WriteLine("Witaj, "+ i++ + ZimiennaForeach);
                
            }
        }
    }
}
