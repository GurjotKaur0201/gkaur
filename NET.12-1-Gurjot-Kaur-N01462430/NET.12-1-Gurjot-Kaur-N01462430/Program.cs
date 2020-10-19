using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace NET._12_1_Gurjot_Kaur_N01462430
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get user input string
            Console.WriteLine("Enter the number series: ");
            string series = System.Console.ReadLine();

            //Split the input
            string[] arrseries = series.Split('+');
            for (int i = 0; i < arrseries.Length; i++)
            {
                Console.WriteLine("after split: " + arrseries[i]);
            }

            //String Array Length
            int arrLength = arrseries.Length;
            
            for (int i = 0; i < arrseries.Length; i++)
            {
                if (Regex.IsMatch(arrseries[i], @"[^0-9]"))
                {
                    arrseries[i] = arrseries[i].Replace(arrseries[i], "0");
                    Console.WriteLine("arrseries[" + i + "]= " + arrseries[i]);
                }
            }

            //Convert String Array into Int Array
            int[] ar = Array.ConvertAll(arrseries, Int32.Parse);
            for (int i = 0; i < ar.Length; i++)
            {
                Console.WriteLine(i + " = " + ar[i]);
            }

            //Calculate Sum of int array elements
            Console.WriteLine("Total= "+ar.Sum());
            System.Console.Read();
        }
    }
}
       