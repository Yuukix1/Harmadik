using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harmadik
{
    class Program
    {
        static void Main(string[] args)
        {
            const int diakokSzama = 5;
            string[] diakNevek = new string[diakokSzama];
            int[] pontszamok = new int[diakokSzama];

            
            for (int i = 0; i < diakokSzama; i++)
            {
                Console.Write($"Kérem, adja meg a {i + 1}. diák nevét: ");
                diakNevek[i] = Console.ReadLine();

                int pontszam;
                while (true)
                {
                    Console.Write($"Kérem, adja meg a(z) {diakNevek[i]} pontszámát: ");
                    string bemenet = Console.ReadLine();

                    
                    if (int.TryParse(bemenet, out pontszam))
                    {
                        pontszamok[i] = pontszam;
                        break; 
                    }
                    else
                    {
                        Console.WriteLine("Kérlek, adj meg egy érvényes számot!");
                    }
                }
            }

            
            double atlagPontszam = 0;
            int legmagasabbPontszam = pontszamok[0];
            int legalacsonyabbPontszam = pontszamok[0];
            string legmagasabbDiak = diakNevek[0];
            string legalacsonyabbDiak = diakNevek[0];

            for (int i = 0; i < diakokSzama; i++)
            {
                atlagPontszam += pontszamok[i];

               
                if (pontszamok[i] > legmagasabbPontszam)
                {
                    legmagasabbPontszam = pontszamok[i];
                    legmagasabbDiak = diakNevek[i];
                }

                if (pontszamok[i] < legalacsonyabbPontszam)
                {
                    legalacsonyabbPontszam = pontszamok[i];
                    legalacsonyabbDiak = diakNevek[i];
                }
            }

            
            atlagPontszam /= diakokSzama;

            
            Console.WriteLine($"\nÁtlagpontszám: {atlagPontszam:F2}");
            Console.WriteLine($"Legmagasabb pontszám: {legmagasabbPontszam}, Diák: {legmagasabbDiak}");
            Console.WriteLine($"Legalacsonyabb pontszám: {legalacsonyabbPontszam}, Diák: {legalacsonyabbDiak}");

            
            bool vanElegtelen = false;
            foreach (int pontszam in pontszamok)
            {
                if (pontszam < 50)
                {
                    vanElegtelen = true;
                    break;
                }
            }

            if (vanElegtelen)
            {
                Console.WriteLine("Van elégtelen pontszám!");
            }
            Console.ReadKey();
        }
    }
}