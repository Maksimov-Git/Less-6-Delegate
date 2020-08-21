using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_4
{
    class Program
    {
        public static void Met1()
        {
            Console.WriteLine("I method 1");
        }
        public static void Met2()
        {
            Console.WriteLine("I method 2");
        }
        public static void Met3()
        {
            Console.WriteLine("I method 3");
        }

        public delegate void MyDelegate();

        static void Main(string[] args)
        {
            MyDelegate myDelegate = null;
            MyDelegate myDelegate1 = new MyDelegate(Met1);
            MyDelegate myDelegate2 = new MyDelegate(Met2);
            MyDelegate myDelegate3 = new MyDelegate(Met3);

            myDelegate = myDelegate1 + myDelegate2 + myDelegate3;

            myDelegate.Invoke();

            Console.WriteLine("myDelegate -= myDelegate2");
            myDelegate -= myDelegate2;
            myDelegate.Invoke();

            Console.WriteLine("myDelegate -= myDelegate1");
            myDelegate -= myDelegate1;
            myDelegate.Invoke();

            Console.ReadKey();
        }
    }
}


