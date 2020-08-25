using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace qSort
{
    class Program
    {
        static void qsort(int l, int r)
        {
            int i = l;
            int j = r;

            //
            int x = a[(l + r) / 2];
            //             

            if (r == l) return;

            while (i <= j)
            {

                // Console.WriteLine(i + " = " + j);
                // Console.ReadLine();

                while (a[i] < x)
                    i++;
                while (a[j] > x)
                    j--;

                if (i <= j)
                {
                    swap(ref a[i], ref a[j]);
                    i++;
                }
                //j--;


            }
            //j++;
            j--;


            //if (j>0)
            {
                if (l < j) qsort(l, j);
                if (i < r) qsort(i, r);
            }
        }
        //============================
        static void swap(ref int a, ref int b)
        {
            int k = a;
            a = b;
            b = k;
        }

        //====================================================
        static int[] a;

        static public void sort()
        {
            qsort(0, a.Length - 1);

        }

        //----------------------------------------------------


        static public void tester(int tests)
        {
            Console.WriteLine("test on " + tests + " mass");

            // подготовка
             a = new int[tests];
            Random R = new Random(999);

            for (int i = 0; i < tests; i++)
                a[i] = R.Next(90);

            // тест
            DateTime time = System.DateTime.Now;
            sort();
            Console.WriteLine("time passed: " + (DateTime.Now - time));


            bool check = true;
            for (int i = 1; i < tests; i++)
                if (a[i] < a[i - 1]) check = false;

            Console.WriteLine("is sorted: " + check);
        }


        static void Main(string[] args)
        {

            Console.WriteLine("merge sort tests\n");

            tester(1000);
            tester(5000);
            tester(20000);
            tester(50000);
            tester(100000);

            Console.WriteLine("\nfinished");

            Console.ReadLine();
        }
    }
}
