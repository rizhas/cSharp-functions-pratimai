using System;
namespace FunkcijuPamoka1
{
    public class EmptyClass
    {
        public static void Main()
        {
            Console.WriteLine("iveskit zmogaus svori:");
            float a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("iveskite zmogaus ugi:");
            float b = Convert.ToSingle(Console.ReadLine());
            float KMI = formule(a, b);
            Console.WriteLine("Jusu KMI yra " + KMI);

            if (KMI < 5)
            {
                Console.WriteLine("MIRES!");
            }
            else if (KMI < 15)
            {
                Console.WriteLine("badaujantis zhmogus.");
            }
            else if (KMI <= 18.5f)
            {
                Console.WriteLine("liesas zmogus.");
            }
            else if (KMI <= 25)
            {
                Console.WriteLine("normalaus svoriu zhmogus.");
            }
            else if (KMI <= 30)
            {
                Console.WriteLine("storas zhmogus.");
            }
            else if (KMI <= 40)
            {
                Console.WriteLine("nutukes zhmogus.");
            }
            else if (KMI > 40)
            {
                Console.WriteLine("LIGOTAS zhmogus.");
            }
        }



        static float formule(float svoris, float ugis)
        {
            float kmi = svoris / (ugis * ugis);
            return kmi;
        }
    }
}
