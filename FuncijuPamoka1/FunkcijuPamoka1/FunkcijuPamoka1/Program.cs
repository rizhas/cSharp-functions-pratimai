using System;

namespace FunkcijuPamoka1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a;
            int b = Convert.ToInt32(Console.ReadLine());

            //for salyga.

            for (int i = 0; i < b; i++)
            {
                a = i;
                Console.WriteLine(a);
            }
        }
    }
}
