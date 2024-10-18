using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElsoFeladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Add meg pontszámot (0 és 100 között): ");
            int pontszam = int.Parse(Console.ReadLine());

            if (pontszam < 0 || pontszam > 100)
            {
                Console.WriteLine("Érvénytelen pontszám");
            }
            else if (pontszam <= 49)
            {
                Console.WriteLine("Osztályzat: Elégtelen");
            }
            else if (pontszam <= 59)
            {
                Console.WriteLine("Osztályzat: Elégséges");
            }
            else if (pontszam <= 79)
            {
                Console.WriteLine("Osztályzat: Közepes");
            }
            else if (pontszam <= 89)
            {
                Console.WriteLine("Osztályzat: Jó");
            }
            else
            {
                Console.WriteLine("Osztályzat: Jeles");
            }
        }
    }
}
