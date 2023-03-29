using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrtaSeviye
{
    internal class SessizHarf
    {
        public SessizHarf()
        {
            Console.WriteLine("bir metin girin");
            string input = Console.ReadLine();
            string[] strings = input.Split(' ');

            string unsuz = "bcçdfgğhjklmnprsştvyz";
            int ikili = 0;

            foreach (var item in strings)
            {
                bool ikilimi = false;

                for (int i = 0; i < item.Length-1; i++)
                {
                    if (unsuz.Contains(item[i]) && unsuz.Contains(item[i + 1]))
                    {
                        ikilimi = true; break;
                    }
                    
                }
                Console.WriteLine(ikilimi + " ");
            }

        }
    }
}
