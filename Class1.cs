using System;
using System.Collections.Generic;
using System.Text;

namespace Interview
{
    class Class1
    {
        static void Main()
        {
            Tests cc = new Tests();
            foreach (var item in Tests.TestCases())
            {
     cc.Test(item.GetValue(0).ToString(), item.GetValue(1).ToString(), Convert.ToBoolean(item.GetValue(2)));

     var result = new SimilarStringsChecker().CheckStrings(item.GetValue(0).ToString(), item.GetValue(1).ToString());

     Console.WriteLine(result.ToString()+ ',' + Convert.ToBoolean(item.GetValue(2)));

            }
            Console.ReadLine();
            


        }


    }
}
