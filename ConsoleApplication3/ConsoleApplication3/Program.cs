using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int iznos;
            int manje=0;
            int vise=0;
            
            Console.WriteLine("Molimo unesite broj klijenata banke");
            int N=Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Unesite iznos novca na racunu klijenta br." + i);
                iznos = Convert.ToInt32(Console.ReadLine());
                if (iznos < 1000)
                    manje++;
                else if (iznos > 100000)
                    vise++;
            }
            Console.WriteLine("Manje od 1000 dinara na racunu ima "+ manje +" klijenata,dok vise od 100000 ima "+ vise +" klijenata");
        }
    }
}
