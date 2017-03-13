using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Reverse3
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInt = 34;
            int middleInt = 712;
            int lastInt = 25;

            WriteLine("Before ref firstInt is {0}", firstInt);
            WriteLine(" and middleInt is {0}", middleInt);
            WriteLine(" and lastInt is {0}", lastInt);

            DisplayRef(ref firstInt, ref lastInt);

            WriteLine("Value of firstInt is now changed to {0}", firstInt);
            WriteLine(" and middleInt is {0}", middleInt);
            WriteLine(" and value of lastInt is now {0}", lastInt);


        }
        public static void DisplayRef(ref int numberOne, ref int numberTwo)
        {
            numberOne = 25;
            numberTwo = 34;

        }
    }
}
