using System;

namespace SkaiciusZodzhiais_NamuDarbai
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Ivedimas + bool (TIESA) + atvaizdavimas

            Console.WriteLine("Iveskite skaiciu nuo -20 iki 20.");
            string skaiciusZODZIAIS = Console.ReadLine();
            bool tiesa = skaichiusTeisingas(skaiciusZODZIAIS);
            Console.WriteLine(tiesa);

            if (tiesa == true)
            {
                int konvertuotasSK = Convert.ToInt32(skaiciusZODZIAIS);
                bool tiesaINT = StringToInt(konvertuotasSK);
                Console.WriteLine("skaichius INT yra " + tiesaINT);
                string nulis = "";
                if (konvertuotasSK < 0)
                {
                    nulis = "MINUS ";
                    konvertuotasSK = konvertuotasSK * -1;
                }
                Console.WriteLine(nulis + SpausdintiVienetus(konvertuotasSK));
            }
            else
            {
                Console.WriteLine("Kadangi Skaichius ivestas blogai, programa sustabdoma...");
            }

        }

        // Skaiciaus patikrinimas. [FUNKCIJA]

        static bool skaichiusTeisingas(string sk1)
        {
            for (int i = 0; i < sk1.Length; i++)
            {
                char simbolis = sk1[i];

                if (simbolis != '0' && simbolis != '1' && simbolis != '2' && simbolis != '3' && simbolis != '4' && simbolis != '5' && simbolis != '6' && simbolis != '7' && simbolis != '8' && simbolis != '9')
                {
                    if (simbolis != '-' || i != 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        // Konvertuoju string i INT ir patikrinu ar jis teisinguose rezhese.

        static bool StringToInt(int sk1)
        {
            bool teisingas = false;
            if (sk1 >= -20 && sk1 <= 20)
            {
                teisingas = true;
            }
            return teisingas;
        }

        static string SpausdintiVienetus(int sk1)
        {
            //string minus = "-";

            /*if (sk1 < 0)
            {
                minus = "MINUS ";
                sk1 = sk1 * -1;
            }*/

            string spausdintiZodziais = "blogai";
           
            switch (sk1)
            {
                case 1:
                    spausdintiZodziais = "VIENAS";
                    break;
                case 2:
                    spausdintiZodziais = "DU";
                    break;
                case 3:
                    spausdintiZodziais = "TRIS";
                    break;
                case 4:
                    spausdintiZodziais = "KETURI";
                    break;
                case 5:
                    spausdintiZodziais = "PENKI";
                    break;
                case 6:
                    spausdintiZodziais = "SESI";
                    break;
                case 7:
                    spausdintiZodziais = "SEPTINI";
                    break;
                case 8:
                    spausdintiZodziais = "ASTUONI";
                    break;
                case 9:
                    spausdintiZodziais = "DEVINI";
                    break;
                case 10:
                    spausdintiZodziais = "DESIMT";
                    break;
                case 11:
                    spausdintiZodziais = "VIENUOLIKA";
                    break;
                case 12:
                    spausdintiZodziais = "DVYLIKA";
                    break;
                case 13:
                    spausdintiZodziais = "TRYLIKA";
                    break;
                case 14:
                    spausdintiZodziais = "KETURIOLIKA";
                    break;
                case 15:
                    spausdintiZodziais = "PENKIOLIKA";
                    break;
                case 16:
                    spausdintiZodziais = "SESIOLIKA";
                    break;
                case 17:
                    spausdintiZodziais = "SEPTINIOLIKA";
                    break;
                case 18:
                    spausdintiZodziais = "ASTUONIOLIKA";
                    break;
                case 19:
                    spausdintiZodziais = "DEVINIOLIKA";
                    break;
                case 20:
                    spausdintiZodziais = "DVIDESIMT";
                    break;
                default:
                    spausdintiZodziais = "NULIS";
                    break;
            }
            return spausdintiZodziais;
        }
        //PABAIGA.
    }

}