using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate1
{// статический класс 
    static class MyClass
    { // метод 
        public static void Method()
        {
            Console.WriteLine(" Я могу делегаты! ");
        }
    }

    public delegate void MyDelegate();
}
