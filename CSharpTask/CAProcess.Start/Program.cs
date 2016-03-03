using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace CAProcess.Start
{
    class Program
    {
        static void Main(string[] args)
        {
            //string fn = @"C:\Users\pc\Desktop\GIS不确定性框架体系与数据不确定性研究方法.pdf";
            //Process.Start(fn);

            //Process process = new Process();
            //process.StartInfo.FileName = "chrome.exe"; //IE浏览器,可以更换
            //process.StartInfo.Arguments = "www.baidu.com";
            //process.Start();

            //ProcessStartInfo processStartInfo = new ProcessStartInfo();
            //processStartInfo.FileName = "explorer.exe";//资源管理器
            //processStartInfo.Arguments = @"D:\";
            //Process.Start(processStartInfo);

            //Process.Start(@"F:\Program Files (x86)\Tencent\QQ\Bin\QQ.exe");

            Process.Start("explorer.exe", @"C:\Users\pc\Desktop\GIS不确定性框架体系与数据不确定性研究方法.pdf");
            Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}
