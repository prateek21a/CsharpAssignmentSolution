using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Assignments
{
    internal class assignment1 {
       public static void Main()
        {
            // 1. print hello message
            /* Console.WriteLine("hello Message");*/



            //2.Display result of Addition , subtraction , product , quotient of two numbers

            /* int x, y;
             Console.WriteLine("Enter first no.");
             int num1 = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("Enter Second no.");
             int num2 = Convert.ToInt32(Console.ReadLine());

             Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
             Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
             Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);
             Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1 % num2);
 */


            // 3. Display result of Addition , subtraction , product , quotient of two numbers depending upon choice (using if else / switch)
            /*
             Console.WriteLine("Enter first no.");
             int num1 = Convert.ToInt32(Console.ReadLine());
 */
            /* Console.WriteLine("Enter Second no.");
             int num2 = Convert.ToInt32(Console.ReadLine());

             *//* Console.WriteLine("enter operstor : ");
               char  res = Convert.ToChar(Console.ReadLine());
  *//*
             Console.WriteLine("enter operstor : ");
             string op =Console.ReadLine();

             if (op == "+")
             {
                 Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
             }
             else if (op == "-")
             {
                 Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);

             }
             else if (op == "*")
             {
                 Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);

             }
             else if (op == "%")
             {
                 Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1 % num2);

             }
             else
             {
                 Console.WriteLine("Invalid operator");
             }
 */



            // 4.Display your name 10 times
            /* string name = " Prateek";
             for ( int i = 0; i < 10; i++ )
             {
                 Console.WriteLine(name);
             }*/




            // 5.Display all even numbers by using dowhile, while , for loop

            /* for ( int i = 2; i < 10; i++ )
             {
                 if ( i % 2 == 0)
                 {
                     Console.WriteLine(i);
                 }
             }*/

            // 6.Display all odd numbers by using dowhile, while , for loop
            /* for ( int i = 2; i < 10; i++ )
                {
                    if ( i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }*/


            //7.Display table of a number using any loops
            /* int n;
             n = Convert.ToInt32(Console.ReadLine());
             for ( int i = 1; i <=10; i++)
             {
                 Console.WriteLine( "{0} * {1} =  { 2} " ,n,i, (n*i));
             }*/

            //8.Display numbers from 100 to 5 with a gap of 3
            /*
                        for ( int i = 100; i >= 5; i -=3)
                        {
                            Console.WriteLine(i);
                        }*/




            // 9.Declare some integer varibales, assign them some values and display them in one line
            /*   int a = 10 ; int b = 20; int c = 30;
                Console.WriteLine($"(The value of a , b and c are :{a},{b },{c}");*/



            // 10.Declare some integer varibales, assign them some values and display them separate lines
            int a = 10; int b = 20; int c = 30;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);


        }

    }
}
