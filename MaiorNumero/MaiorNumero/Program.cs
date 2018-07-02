using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            const int c = 10;
            int[] n = new int[c];
            int m = 0;
            int numero;

            Random random = new Random();


            for (int i = 0; i < c; i++)
            {
                numero = random.Next(100);
                n[i] = numero;
                Console.WriteLine(numero);

                if (i == 0)
                {
                    m = n[0];
                }

                else if (n[i] > m)
                {
                    m = n[i];
                }


            }

            Console.WriteLine("O maior:" + m);
            Console.ReadKey();
        }

    }
}
