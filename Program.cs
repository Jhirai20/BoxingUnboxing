using System;
using System.Collections.Generic;

namespace BoxingUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> list= new List<object>();
            list.Add(7);
            list.Add(28);
            list.Add(-1);
            list.Add(true);
            list.Add("chair");
            
            //output list via typecast
            foreach (var item in list)
            {
                if (item is int)
                {
                    Console.WriteLine(item);
                }
                if (item is bool)
                {
                    Console.WriteLine(item);
                }
                if (item is string)
                {
                    Console.WriteLine(item);
                }
            }
            //you don't have to type cast to output
            foreach (var item in list)
            {
                Console.Write(item +", ");
            }

            //sum up all ints in list
            int sum =0;
            foreach (var num in list)
            {
                if (num is int){
                    sum=(int)num+sum;
                }
            }
            Console.Write(sum);
        }
    }
}
