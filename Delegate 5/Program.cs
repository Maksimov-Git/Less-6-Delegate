using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_5
{
    public delegate void MySimDelegate();

    public delegate int MyDelegate1(int a,int b);
    class Program
    {
        static void Main(string[] args)
        {
            //анонимные делегаты
            MySimDelegate mySimDelegate = new MySimDelegate( delegate { Console.WriteLine("hello"); });
           // предположение делегата
            MySimDelegate mySimDelegate1 = delegate { Console.WriteLine("hello"); };

            MyDelegate1 myDelegate1 = delegate (int a, int b) { return a + b;  };

            mySimDelegate();
            Console.WriteLine(myDelegate1(2,3));

            Console.ReadKey();

        }
    }
}
