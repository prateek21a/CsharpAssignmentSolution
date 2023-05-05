using System.Diagnostics.Tracing;
using System.Xml.Linq;

namespace Assig2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1.Print sum and average of elements of an Array
/*
            int[] num = new int[10];
            Console.WriteLine("enter element in array :");
            for (int i = 0; i < num.Length; i++)
            {
                Console.Write("element - {0} : ", i);
                num[i] = Convert.ToInt32(Console.ReadLine());
            }*//*
            float avg = 0;
            int sum = (from x in num select x).Sum();
            Console.WriteLine("sum is : {0} ", sum);

            double avg1 = (from x in num select x).Average();
            Console.WriteLine("average is : {0} ", avg1);*/




            //2.WAP to display sum of 3 by 3 matrices
            int[,] a = { { 1, 2, 3 }, { 4, 5, 6 }, { 5, 6, 7 } };
            int[,] b = { { 1, 2, 3 }, { 4, 5, 6 }, { 5, 6, 7 } };
            int[,] c = new int[3, 3];
            Console.WriteLine(c);
            for (int i = 0; i < a.GetLength(0); i++)
            {
                int rs = 0;
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    rs += c[i, j];
                    }
                Console.WriteLine(rs);
            }

            // 3.WAP to find the maximum element of an integer Array



            //int sum = 0;
            //for (int i = 0; i < num.Length; i++)
            //{
            //    sum += num[i];
            //}
            //avg = sum / num.Length;
            //Console.WriteLine("sUM IS {0} aVG IS {1}", sum, avg);
            //int sum = (from x in num select x).Sum();

            //4. WAP to print column wise sum of elements of 2 D Array
            /*static void Main(string[]args)
            {
                int n, m,i,j;
                int[,] a = new int[20, 20];
                Console.WriteLine("Enter the Number of Rows : ");
                m = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Number of Columns : ");
                n = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Elements");
                for (i = 1; i <= m; i++)
                {
                    for (j = 1; j <= n; j++)
                    {
                        a[i, j] = int.Parse(Console.ReadLine());
                    }
                }

     

     

                int c;
                for (i = 1; i <= n; i++)
                {
                    c = 0;
                    for (j = 1; j <= m; j++)
                    {
                        c = c + a[j, i];
                    }
                    Console.WriteLine("{0} Column Sum : {1}", i, c);
                }

     

            }*/











            //5. WAP to print row wise sum of elements of 2 D Array
            /*   static void Main(string[] args)
               {
                   int n, m, i, j;
                   int[,] a = new int[20, 20];
                   Console.WriteLine("Enter the Number of Rows : ");
                   m = int.Parse(Console.ReadLine());
                   Console.WriteLine("Enter the Number of Columns : ");
                   n = int.Parse(Console.ReadLine());
                   Console.WriteLine("Enter the Elements");
                   for (i = 1; i <= m; i++)
                   {
                       for (j = 1; j <= n; j++)
                       {
                           a[i, j] = int.Parse(Console.ReadLine());
                       }
                   }

     

     

                   int c;
                   for (i = 1; i <= n; i++)
                   {
                       c = 0;
                       for (j = 1; j <= m; j++)
                       {
                           c = c + a[i,j];
                       }
                       Console.WriteLine("{0} row Sum : {1}", i, c);
                   }

     

               }*/




        }





    }
    // Lazy Loading 
    /*  var list = (from x in num
                  select x);

      foreach (int x in list)
      {
          Console.WriteLine(x);
      }*/

    // Eager Loading
    /* list = (from x in num
             select x).ToArray();

     foreach (int x in list)
     {
         Console.WriteLine(x);
     }*/




    // int count = (from x in num select x).Count();


    /// Find even numbers

    /*        var evenlist = (from x in num
                            where x % 2 == 0
                            select x).ToList();
            Console.WriteLine("Even numbers ");
            foreach (int x in evenlist)
                Console.WriteLine(x);
*/
    // Methiod Syntax

    /*count = num.ToList().Count();
    Console.WriteLine(count);


    var list1 = num.ToList();
    evenlist = num.Where(x => x % 2 == 0).ToList();


*/



