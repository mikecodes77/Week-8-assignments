using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FlexibleArrayMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] one = new int[5] { 3, 5, 10, 10, 20 };
            int[] two = new int[3] { 5, 3, 7 };
            int[] three = new int[4] { 3, 5, 9, 3 };
            //int sum = one.Sum();
            int sum = 0;
            int tum = 0;
            int rum = 0;
            //string num;
            int i;
            int j;
            int k;



            for (i = 0; i < one.Length; i++)
            {
                //WriteLine("Display Value from Array one {0}", i +1);

                sum += one[i];
                Write("{0, 6}", one[i]);

            }
           
            WriteLine(" \nDisplay sum of ArrayOne: ");
            WriteLine(sum);

            WriteLine("\n--------------------------");
            for (j = 0; j < two.Length; j++)
            {
                //WriteLine("Display Value from Array two {0}", j + 1);
                tum += two[j];
                Write("{0, 6}", two[j]);
               
            }
            WriteLine(" \nDisplay sum of ArrayTwo: ");
            WriteLine(tum);

            WriteLine("\n--------------------------");
            for (k = 0; k < three.Length; k++)
            {
               // WriteLine("Display Value Array three {0}", k + 1);
                rum += three[k];
                Write("{0, 6}", three[k]);

            }
            WriteLine(" \nDisplay sum of ArrayThree: ");
            WriteLine(rum);

            ReadKey();

        }
    }
}
