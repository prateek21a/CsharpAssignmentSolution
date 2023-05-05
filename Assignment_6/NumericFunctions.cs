﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonFunctions
{
    public class NumericFunctions
    {
        public int Add(params int[] num) 
        {

            return num.Sum();
        }
        public int Subtract(int ? num1 , int ? num2) {
            num1 = num1 ?? 10;
            num2 = num2 ?? 10;
            return num1.Value- num2.Value; }

        public int Product(int num1 , int num2)
        {
            return (num1 * num2);
        }
        public int Divide(int num1, int num2)
        {
            return (num1 /  num2);
        }
        public int MaxNum(params int[] num)
        {
            return num.Max();
        }
        public int MinNum(params int[] num)
        {
            return num.Min();
        }
        public bool IsEven(int num)
        {
            return num%2==0 ? true : false;
        }
        public bool IsOdd(int num)
        {
            return num % 2 != 0 ? true : false;
        }
    }
}
