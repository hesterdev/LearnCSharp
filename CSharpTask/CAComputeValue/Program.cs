using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace CAComputeValue
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "1+9*8-3*2";
            var res = new DataTable().Compute(str, "");

            Console.WriteLine("{0} = {1}", str, res);
            Console.ReadKey();
        }
    }
}
