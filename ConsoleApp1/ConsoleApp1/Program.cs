using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string a = "1";
            //string b = "2";
            //string c = "3";
            //string d = "4";
            //string e = "5";
            //string f = "6";

            //int c = String.Compare(a,b);

            //string res = String.Concat(a,b,d,e,f);

            //string a = "hello world";

            //char[] attr = new char[10];

            //a.CopyTo(3,attr,0,5);

            //for (int i = 0; i < attr.Length; i++) {
            //    Console.WriteLine(attr[i]);
            //}

            //string a = "hello world";

            //string b = "wor2ld";

            //bool res = a.EndsWith(b);

            //bool res = a.Equals(b);

            //int res = a.IndexOf(b);

            string a = "hello world";

            //char[] b = new char[5] { 'w', 'o', 'r', 'l', 'd' };

            //int res = a.IndexOfAny(b);  //2

            string b = "0";

            //string res = a.Insert(2,b);

            bool res = String.IsNullOrEmpty(b);

            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
