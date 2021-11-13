using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryNum
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int c = 0;
            bool b = true;
            ArrayList ar = new ArrayList();

            while (b)
            {
                if (n / 2 == 1)
                {
                    c = n / 2;
                    ar.Add(n % 2);
                    ar.Add(c);
                    break;

                }
                else
                {
                    c = n % 2;

                    n = n / 2;

                }

                ar.Add(c);
            }

            ar.Reverse();

            foreach (var a in ar)
            {
                Console.Write(a);
            }

            
            Console.ReadLine();
        }
        
    }

}
