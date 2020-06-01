using System;
using System.Collections.Generic;

namespace boxing_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
        List<object> aList = new List<object>();
            aList.Add(7);
            aList.Add(28);
            aList.Add(-1);
            aList.Add(true);
            aList.Add("chair");

            int count =0;

            for(int i=0; i<aList.Count; i++)
            {
                if(aList[i] is int)
                {
                    System.Console.WriteLine(aList[i]+ " - " +"Int");
                    count = count + (int)aList[i];
                }
                if(aList[i] is bool)
                {
                    System.Console.WriteLine(aList[i]+ " - " +"Boolean");
                }
                if(aList[i] is string)
                {
                    System.Console.WriteLine(aList[i]+ " - " +"String");
                }
            }
            System.Console.WriteLine(count+ " - " +"Total of all Int types");
        }
    }
}
