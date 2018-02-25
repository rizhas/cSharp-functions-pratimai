using System;

namespace SkaiciusZodzhiais_NamuDarbai
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Ivedimas + bool (TIESA) + atvaizdavimas

            Console.WriteLine("Iveskite skaiciu nuo -20 iki 20.");
            // Skaiciaus patikrinimas. string
            string skaiciusZODZIAIS = Console.ReadLine();
            // Skaiciaus ribu patikrinimas. int
            bool tiesa = skaichiusTeisingas(skaiciusZODZIAIS);
            Console.WriteLine(tiesa);

            // Jeigu skaichius teisingai ivestas tesem uzduoti toliau.

            if (tiesa == true)
            {
                int konvertuotasSK = Convert.ToInt32(skaiciusZODZIAIS);
                bool tiesaINT = StringToInt(konvertuotasSK);
                Console.WriteLine("skaichius INT yra " + tiesaINT);
                string nulis = "";
                string desimtis = "";

                //Jaigu skaichius minusinis pridedam MINUSA ir perkelem ji i pliusine puse.

                if (konvertuotasSK < 0)
                {
                    nulis = "MINUS ";
                    konvertuotasSK = konvertuotasSK * -1;
                }

                if (konvertuotasSK > 20 && konvertuotasSK < 100)
                {
                    desimtis = Desimtis(ref konvertuotasSK);
                }

                //Spausdinam skaichiu ZHODZHIAIS.

                Console.WriteLine(nulis + desimtis + SpausdintiVienetus(konvertuotasSK));
            }

            //Praleidzhiam uzhduoti ir ishmetam klaida.

            else
            {
                Console.WriteLine("Kadangi Skaichius ivestas blogai, programa sustabdoma...");
            }

        }

        // Skaiciaus patikrinimas. string [FUNKCIJA]

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
            if (sk1 >= -100 && sk1 <= 100)
            {
                teisingas = true;
            }
            return teisingas;
        }

        // Teksto spausdinimas nuo -20 iki 20.

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
                case 30:
                    spausdintiZodziais = "TRISDESIMT";
                    break;
                case 40:
                    spausdintiZodziais = "KETURESDESIMT";
                    break;
                case 50:
                    spausdintiZodziais = "PENKESDESIMT";
                    break;
                default:
                    spausdintiZodziais = "NULIS";
                    break;
            }
            return spausdintiZodziais;
        }

        static string Desimtis(ref int sk1)
        {
            string vardas = "";
            if (sk1 > 20 && sk1 < 30)
            {
                vardas = "DVIDESIMT ";
                sk1 = sk1 - 20;
            }
            if (sk1 > 30 && sk1 < 40)
            {
                vardas = "TRISDESIMT ";
                sk1 = sk1 - 30;
            }
            if (sk1 > 40 && sk1 < 50)
            {
                vardas = "KETURESDESIMT ";
                sk1 = sk1 - 40;
            }
            if (sk1 > 50 && sk1 < 60)
            {
                vardas = "PENKESDESIMT ";
                sk1 = sk1 - 50;
            }
           

            return vardas;
        }
        //PABAIGA.
    }

}