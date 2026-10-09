using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DE_dogagyak_3_2026._10._09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int keszlet = 20;
            int korok = 0;
            int dobas = 0;
            int kocka1 = 0;
            int kocka2 = 0;
            do
            {
                korok ++;
                kocka1 = rnd.Next(1, 7);
                kocka2 = rnd.Next(1, 7);
                dobas = kocka1 + kocka2;
                Console.Write($"A dobások: {kocka1} és {kocka2} (Összeg: {dobas})");
                if (dobas == 12)
                {
                    keszlet += 2;
                    Console.WriteLine("A karaván egy elhagyatott raktárt talált.");
                }
                else if (dobas%2 == 1)
                {
                    keszlet --;
                    Console.WriteLine("- Baleset! 1 hordó felrobbant!");
                }
                else
                {
                    Console.WriteLine("");
                }


            }
            while (keszlet < 30 && keszlet > 0 );
            Console.WriteLine($"A körök száma: {korok}");
            if (keszlet == 0)
            {
                Console.WriteLine("A karaván megsemmisült.");
            }
            else
            {
                Console.WriteLine("A karaván megérkezett.");
            }
            Console.ReadLine();

        }
    }
}
