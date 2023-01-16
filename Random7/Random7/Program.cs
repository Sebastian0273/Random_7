using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RandomG7());
        }
        static int Random5()
        {
            Random random = new Random();
            int num = random.Next(1, 6);

            return num;

        }

        static int RandomG7()
        {
            int numFinal = 0;
            while (true)
            {
                numFinal = 5 * (Random5() - 1) + (Random5() - 1);
                if (numFinal < 21)
                {
                    return (numFinal % 7 + 1);
                }
            }
        }
    }
}
