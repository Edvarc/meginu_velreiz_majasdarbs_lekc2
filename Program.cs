using System;

namespace meginu_velreiz_MD_nr2_8_sept
{
    class Program
    {
        static void Main(string[] args)
        {
            //  1. UZDEVUMS --------------------------------------------------------------
            Console.WriteLine("Hello World!");
            Console.WriteLine("1. UZDEVUMS.  Kā Tevi sauc? Lūdzu, norādi lietotājvārdu:");
            string usn = Console.ReadLine();
            Console.WriteLine("Sveiks," + usn + "!");

            //  2. UZDEVUMS --------------------------------------------------------------
            Console.WriteLine("2. UZDEVUMS. Kāds ir Tavs vecums?");
            string age = Console.ReadLine();
            int age2 = int.Parse(age);
            int age3 = age2 + 1;
            Console.WriteLine("Nākamgad Tev paliks " + age3 + " , Tu esi pilngadīgs");

            //  3. UZDEVUMS --------------------------------------------------------------

            Console.WriteLine("3. UZDEVUMS. Uzraksti, lūdzu, vienu veselu skaitli:");
            string num1 = Console.ReadLine();
            int num1p = int.Parse(num1);
            Console.WriteLine("Paldies! Uzraksti, lūdzu, vēl vienu veselu skaitli un tad es pateikšu, kurš no tiem ir vislielākais! :)");
            string num2 = Console.ReadLine();
            int num2p = int.Parse(num2);
            Console.WriteLine("Ļoti jauki, paldies! Uzraksti, lūdzu, vēl pēdējo skaitlīti un tad es pateikšu, kurš no tiem ir vislielākais! :");
            //string num3 = Console.ReadLine();
            //int num3p = int.Parse(num3);  trešo nevar, jo max funkc. spēj atlasīt tikai no diviem lielāko.
            int nummax = Math.Max(num1p, num2p);
            Console.WriteLine("Lielākais skaitlis bija " + nummax);
            //tests 15 sept 


            // 5. UZDEVUMS -------------------------------

            Console.WriteLine("5. UZDEVUMS. Uzraksti, lūdzu, skaitli no 50 līdz 100!");
            string cipar1 = Console.ReadLine();
            int cipar1p = int.Parse(cipar1);
            Console.WriteLine("Paldies! Uzraksti, lūdzu, vēl vienu skaitli - no 10 līdz 20! Un pēc tam uzzināsi abu skaitļu dalījuma atlikumu!");
            string cipar2 = Console.ReadLine();
            int cipar2p = int.Parse(cipar2);
            int atlikums = cipar1p % cipar2p;
            Console.WriteLine("Atlikums:    " + atlikums);



            //7. uzdevums - Taisnstūra laukuma aprēķināšana
            //Iegūt no lietotāja taisnstūra malu vērtības un aprēķināt taisnstūra laukumu.
            // Precīzi jāaprēķina laukums arī ja tas sanāk decimāldaļās jānoapaļo ar 2 cipariem aiz komata


            Console.WriteLine("7. UZDEVUMS. Uzraksti, lūdzu, skaitli no 1 līdz 10!");
            string rect1 = Console.ReadLine();
            decimal rect1p = decimal.Parse(rect1);
            Console.WriteLine("Paldies! Uzraksti, lūdzu, vēl vienu skaitli - no 10 līdz 20! Un pēc tam uzzināsi taisnstūra, kura malu garumi ir Tevis tikko norādītie skaitļi, laukumu kv. cm!");
            string rect2 = Console.ReadLine();
            decimal rect2p = decimal.Parse(rect2);
            decimal laukums = rect1p * rect2p;
            decimal apalots = Math.Round(laukums, 2);
            Console.WriteLine("Laukums =    " + apalots);
        }
    }
}
