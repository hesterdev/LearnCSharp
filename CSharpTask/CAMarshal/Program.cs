using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace CAMarshal
{
    struct strA
    {
        char c;
        int a;
        //double b;
        void f()
        {
            Console.WriteLine("gary");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int size=Marshal.SizeOf(typeof(strA));
            Console.WriteLine(size);
            Console.WriteLine("Done!");
            Console.ReadKey();
        }
    }
}
