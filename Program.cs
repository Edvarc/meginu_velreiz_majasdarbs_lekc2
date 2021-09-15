using System;

namespace meginu_velreiz_MD_nr2_8_sept
{
    class Program
    {
        static void Main(string[] args)
        {
            //  1. UZDEVUMS --------------------------------------------------------------
            Console.WriteLine("Hello World!");
            Console.WriteLine("Kā Tevi sauc? Lūdzu, norādi lietotājvārdu:");
            string usn = Console.ReadLine();
            Console.WriteLine("Sveiks," + usn + "!");

            //  2. UZDEVUMS --------------------------------------------------------------
            Console.WriteLine("Kāds ir Tavs vecums?");
            string age = Console.ReadLine();
            int age2 = int.Parse(age);
            int age3 = age2 + 1;
            Console.WriteLine("Nākamgad Tev paliks " + age3 + " , Tu esi pilngadīgs");

            //  3. UZDEVUMS --------------------------------------------------------------

            Console.WriteLine("Uzraksti, lūdzu, vienu veselu skaitli:");
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


           


        }
    }
}
