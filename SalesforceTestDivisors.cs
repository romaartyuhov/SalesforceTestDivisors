using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesforceTest
{
    class SalesforceTestDivisors
    {

        static void Main()
        {
            int N;
            List<int> div = new List<int>();

            while (!int.TryParse(Console.ReadLine(), out N)) ;
            
            int sqtr = (int)Math.Sqrt(N);

            for (int i = 2; i < sqtr; ++i)
            {
                if (N % i == 0)
                {
                    div.Add(i);
                    div.Add(N / i);
                }
            }

            if (N % sqtr == 0)
            {
                if (N == sqtr * sqtr)
                {
                    div.Add(sqtr);
                }
                else
                {
                    div.Add(sqtr);
                    div.Add(N / sqtr);
                }
            }

            div.Sort();
            div.Add(N);

            for(int i=0; i < div.Count; ++i)
                Console.WriteLine(div[i]);

            Console.ReadKey();
        }
    }
}