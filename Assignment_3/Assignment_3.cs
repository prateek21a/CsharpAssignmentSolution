﻿using System.Xml.Linq;
namespace ConsoleApp3
{
    internal class Assignment_3
    {
        /* static void Main(string[] args)
         {
             int[] arr = new int[8] { 1, 2, 6, 4, 3, 4, 2, 4 };
             var frequenyCount = count_element(arr);
             foreach (var count in frequenyCount)
             {
                 Console.WriteLine(" {0} : {1} Times", count.Key, count.Value);
             }
         }

  


             public static SortedDictionary<int, int> count_element(int[] arr)
             {
                 SortedDictionary<int, int> d = new SortedDictionary<int, int>();
                 foreach (int item in arr)
                 {
                     if (!(d.ContainsKey(item)))
                     {
                         d.Add(item, 1);
                     }
                     else
                     {
                         d[item]++;
                     }
                 }
                 return d;
             }*/




        /*  static void Main(string[] args)
          {
              int maths, chem, phy;
              Console.WriteLine("enter marks of maths");
              maths=Convert.ToInt16( Console.ReadLine());

   


              Console.WriteLine("enter marks of physics");
              chem = Convert.ToInt16(Console.ReadLine());

   

              Console.WriteLine("enter marks of chemistry");
              phy = Convert.ToInt16(Console.ReadLine());

   


              if(maths>=65 && phy>=55 && chem>=50)
                  {
                  Console.WriteLine("The candidate is eligible for admission.");
                  }
              else if(maths+phy>=140)
                  Console.WriteLine("The candidate is eligible for admission.");

   

              else
                  Console.WriteLine("The candidate is not eligible for admission.");

   


          }*/




        static void Main(string[] args)
        {
            int id;
            float unit;
            string name;
            Console.WriteLine("enter id");
            id = Convert.ToInt16(Console.ReadLine());




            Console.WriteLine("enter name ");
            name = Convert.ToString(Console.ReadLine());



            Console.WriteLine("enter unit of electricity used");
            unit = Convert.ToInt32(Console.ReadLine());




            Console.WriteLine("customer id is ={0}", id);
            Console.WriteLine("customer name is ={0}", name);
            Console.WriteLine("unit consumed is ={0}", unit);



            float bill = 0;



            if (unit <= 199)
            {
                bill = (1.20f * unit);
                Console.WriteLine("amount charged ={0}", bill);
            }



            else if (unit >= 200 && unit <= 400)
            {
                bill = unit - 200;
                Console.WriteLine("amount charged ={0}", (200 * 1.20) + (bill * 1.50));
            }




            else if (unit > 400 && unit <= 600)
            {
                bill = (unit - 400) * 1.80f + (200 * 1.20f) + (200 * 1.50f);
                Console.WriteLine("amount charged ={0}", (bill));
                Console.WriteLine("surcharged amount ={0}", 0.15 * bill);
                Console.WriteLine("total amount ={0}", 0.15 * bill + bill);
            }



            else if (unit > 600)
            {
                bill = (unit - 600) * 2f + ((200 * 1.20f) + (200 * 1.50f) + (200 * 1.80f));
                Console.WriteLine("amount charged ={0}", +bill);
                Console.WriteLine("surcharged amount ={0}", 0.15 * bill);
                Console.WriteLine("total amount ={0}", 0.15 * bill + bill);
            }




        }
    }
}