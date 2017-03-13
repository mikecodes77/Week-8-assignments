using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ArrayDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            // int [] ArrayDemo = { 1, 2, 3, 4, 5, 6, 7, 8};
            int[] ArrayDemo = new int[8];
            int[] Selection = new int[8];
            //int sub = ArrayDemo.Length - 1;
           // int custSelection;
            string num;
            //string selection;
            int x;
            for (x = 0; x < ArrayDemo.Length; ++x)
            {
                Write("Enter a whole number {0}: ", x + 1);
                num = ReadLine();
                ArrayDemo[x] = Convert.ToInt32(num);
            }
            WriteLine("\n--------------");
            WriteLine("Whole numbers in original order: ");

            for (x = 0; x < ArrayDemo.Length; ++x)
                Write("{0, 6}", ArrayDemo[x]);

            WriteLine("\n-----------------------------");
            Array.Sort(ArrayDemo);
            WriteLine("Whole numbers in sorted order: ");

            for (x = 0; x < ArrayDemo.Length; ++x)
                Write("{0, 6}", ArrayDemo[x]);

            WriteLine("\n------------------------------");
            Array.Reverse(ArrayDemo);
            WriteLine("Whole numbers in reverse order: ");

            for (x = 0; x < ArrayDemo.Length; ++x)
            {
                Write("{0, 6}", ArrayDemo[x]);
            }
            WriteLine("\n------------------------------");
            WriteLine("Would you like to view a prior selection?  Enter number 1- 8 to see that selection");

           // while (sub >= 0 && num < ArrayDemo[sub]) --sub;

          //  custSelection = Selection[sub];

            //num = ReadLine();
            //Selection[x] = Convert.ToInt32(num);
            //Array.BinarySearch(Selection, num);

            ReadLine();

            //for (int x = 0; x < ArrayDemo.Length; ++x)
              //  WriteLine("Pay rate {0} is {1}", x, payRate[x].ToString("C"));
        }
    }
}
