using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpTask
{
    class Program
    {
        static void Main(string[] args)
        {

            //Task t1 = Task.Factory.StartNew(delegate { MyMethodA(); });
            //Task t2 = Task.Factory.StartNew(delegate { MyMethodB(); });

            //t1.Wait();
            //t2.Wait();


            //Task.WaitAll(t1, t2);

            //Console.WriteLine("Hello world!");



            //Task t1 = new Task(MyMethod);
            //t1.Start();

            //Console.WriteLine("主线程代码运行结束");


            //Task t1 = new Task(F1);
            //t1.Start();
            ////t1.Wait();

            Task<string> t1 = Task.Factory.StartNew(() => "测试");
            t1.Wait();
            Console.WriteLine(t1.Result);


            Console.WriteLine("Done");
            Console.ReadKey();
        }

        private static void F1()
        {
            throw new NotImplementedException();
        }

        static void MyMethod()
        {
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine(DateTime.Now.ToString());
                Thread.Sleep(1000);
            }
        }



        private static int n = 20;
        private static void MyMethodA()
        {
            for (int i = 1; i <= n; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        private static void MyMethodB()
        {
            for (int i = 2; i <= n; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
