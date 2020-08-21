using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_3
{
    class Program
    {
        public static string Method(string Name)
        {
            return "Hello" + Name;
        }
        public delegate string MyDelegate(string Name);
        static void Main(string[] args)
        {
            MyDelegate myDelegate = new MyDelegate(Method);
            Console.WriteLine(myDelegate.Invoke(" world"));
            Console.ReadKey();
        }
    }
}
