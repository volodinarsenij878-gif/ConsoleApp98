using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program55
{
    internal class Program
    {
        static void Main()
        {
            string s = null;
            int len;

            if (s != null)
            {
                len = s.Length;
            }
            else
            {
                // тут можно сделать логирование, вывод сообщения и т. д.
                len = 0;
            }

            Console.WriteLine($"Длина: {len}");
        }
    }
}

