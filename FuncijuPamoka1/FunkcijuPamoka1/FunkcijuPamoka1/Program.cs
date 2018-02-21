using System;

namespace FunkcijuPamoka1
{
    class MainClass
    {
        public static void Main()
        {
            //ivedimas.
            Console.WriteLine("Iveskite 1 skaichiu.:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Iveskite 2 skaichiu.:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pasirinkite:\n1. SUMA\n2. SKIRTUMAS\n3. SANDAUGA\n4. DAUGYBA");
            int c = Convert.ToInt32(Console.ReadLine());

            //switch (MENU dalis).

            switch (c)
            {
                case 1:
                    suma(a,b);
                    break;
                case 2:
                    skirtumas(a, b);
                    break; 
                case 3:
                    sandauga(a, b);
                    break;
                case 4:
                    daugyba(a, b);
                    break;
                default:
                    Console.WriteLine("\nBLOGAS PASIRINKIMAS!\n");
                    break;
            }

        }

        //SUMA funkcija.

        static void suma(int sk1, int sk2)
        {
            int suma = sk1 + sk2;
            Console.WriteLine("SUMA = " + suma);
        }

        //MINUSAS funkcija.

        static void skirtumas(int sk1, int sk2)
        {
            int skirtumas = sk1 + sk2;
            Console.WriteLine("skirtumas = " + skirtumas);
        }

        //sandauga funkcija.

        static void sandauga(int sk1, int sk2)
        {
            int sandauga = sk1 + sk2;
            Console.WriteLine("sandauga = " + sandauga);
        }

        //sandauga funkcija.

        static void daugyba(int sk1, int sk2)
        {
            int daugyba = sk1 + sk2;
            Console.WriteLine("daugyba = " + daugyba);
        }
    }
}
